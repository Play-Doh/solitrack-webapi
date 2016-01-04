using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using JobsAPI.Models;

// JSON looks like this from a monitor
//"Details": "SPDE job was cancelled while still processing."
//"Data": null
//"Device": "sspd02_t6_pdmexxxx"
//"Message": null
//"ID1": 231736
//"ID2": 199
//"ID3": null

// JSON look like this from a checkpoint
//"JobID": 227861
//"JobUID": "8228797C-7CB4-4757-B13F-3EF90EFF77F7"
//"CheckpointID": 4
//"CheckpointUID": "a0ecdcd5-f538-4cac-a00e-dc7c53474b4c"
//"CheckpointName": "Acxiom Powerstream Complete"

namespace JobsAPI.MyClasses
{
    public class CreateJsonOutput
    {
        public JToken JsonTokenBuilder(List<File> JsonFileList)
        {
            Monitor hookMonitor = new Monitor();
            JTokenWriter jout = new JTokenWriter();
            using (var db = new stdbContext())
            {
                jout.WriteStartObject();
                jout.WritePropertyName("Job Selection");
                jout.WriteStartArray();

                foreach (var file in JsonFileList)
                {
                    jout.WriteStartObject();
                    hookMonitor = db.Monitors.FirstOrDefault(x => x.StorageFolderID == file.StorageFolderID);
                    jout.WritePropertyName("InputDir");
                    jout.WriteValue(hookMonitor.WatchFolder.ToString());
                    jout.WritePropertyName("FileName");
                    jout.WriteValue(file.FileName.ToString());
                    jout.WritePropertyName("JobID-Messages");
                    jout.WriteStartArray();
                    // let's get the jobs that match on FileID
                    IQueryable<Job> joblistquery = db.Jobs
                                        .Where(x => x.FileID == file.FileID);

                    foreach (var job in joblistquery)
                    {
                        // let's get the full list of jobs with transactions to get messages from
                        IQueryable<Job> subjoblistquery = db.Jobs
                            .Where(x => x.TransactionUID == job.TransactionUID);

                        foreach (var subjob in subjoblistquery)
                        {
                            jout.WriteStartObject();
                            jout.WritePropertyName(subjob.JobID.ToString());
                            jout.WriteStartArray();

                            // Let's get the messages for each TransactionID
                            IQueryable<JobMessage> messagelistquery = db.JobMessages
                                .Where(x => x.JobID == subjob.JobID)
                                .OrderBy(x => x.Timestamp);

                            foreach (var message in messagelistquery)
                            {
                                jout.WriteStartObject();
                                jout.WritePropertyName(message.Timestamp.ToString());
                                jout.WriteValue(message.Message.ToString());
                                //jout.WriteValue(String.Format("{0} | {1}", message.Timestamp, message.Message));
                                jout.WriteEndObject();
                            }
                            jout.WriteEndArray();
                            jout.WriteEndObject();
                        }
                    }
                    jout.WriteEndArray();
                    jout.WriteEndObject();
                }
                jout.WriteEndArray();
                jout.WriteEndObject();
            }
            return jout.Token;
        }
    }
}