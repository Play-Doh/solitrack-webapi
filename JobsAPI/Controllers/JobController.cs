using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using JobsAPI.Models;
using System.Text;
using System.IO;

namespace JobsAPI.Controllers
{
    public class JobController : ApiController
    {
        JTokenWriter jout = new JTokenWriter();

        // GET api/<controller>
        public IHttpActionResult Get()
        //public JToken Get()
        {
            SOLitrackApplicationAPI appAPI = new SOLitrackApplicationAPI("SOLITRACK SERVER NAME");
            StringBuilder webreturn = new StringBuilder();
            webreturn.Append(appAPI.Client.GetVersion());        
            return Ok(webreturn);
        }

        // GET api/<controller>/5
        // public string Get(string id)
        public JToken Get(string id)
        {
            List<Models.File> filelist = new List<Models.File>();
            using (var db = new stdbContext())
            {
                // let's get the files that match the search name
                IQueryable<Models.File> filelistquery = db.Files
                    .Where(x => x.FileName.Contains(id))
                    .OrderByDescending(x => x.Added)
                    .Take(15);

                foreach (var file in filelistquery)
                {
                    filelist.Add(file);
                }
            }
            MyClasses.CreateJsonOutput JsonOut = new MyClasses.CreateJsonOutput();
            return JsonOut.JsonTokenBuilder(filelist);
        }

        // POST: api/job/action
        //public void Post([FromBody] JToken value)
        [Route("api/job/MJ")]
        public void Post([FromBody] JToken mjin)
        {
            Job hookJob = new Job();
            Models.File hookFile = new Models.File();
            List<Models.File> hookFiles = new List<Models.File>();
            Monitor hookMonitor = new Monitor();
            StringBuilder outfile = new StringBuilder();
            CheckpointWebhook hookval = new CheckpointWebhook();

            hookval = JsonConvert.DeserializeObject<CheckpointWebhook>(mjin.ToString());

            using (var db = new stdbContext())
            {
                hookJob = db.Jobs.Single(x => x.JobID == hookval.JobID);
                // we only want to lookup completed jobs : JobStateID 8 == Completed
                // if we get back other stateID's, the DB is not done with those jobs yet and we cannot look them up yet
                // and we don't know when they will be done if this is to remain stateless
                if (hookJob.JobStateID == 8)
                {
                    if (hookJob.RootJobID != null)
                    {
                        hookJob = db.Jobs.SingleOrDefault(x => x.JobID == hookJob.RootJobID);
                    }

                    hookFile = db.Files.SingleOrDefault(x => x.FileID == hookJob.FileID);
                    hookFiles.Add(hookFile);
                    MyClasses.CreateJsonOutput JsonOut = new MyClasses.CreateJsonOutput();
                    JToken ReturnToken = JsonOut.JsonTokenBuilder(hookFiles);
                    hookMonitor = db.Monitors.SingleOrDefault(x => x.StorageFolderID == hookFile.StorageFolderID);
                    outfile.Append(hookMonitor.WatchFolder.Replace("incoming", "outgoing")).Append(Path.DirectorySeparatorChar).Append(hookFile.FileName).Append(".log");

                    //write out the JToken
                    try
                    {
                        using (StreamWriter webOut = new StreamWriter(outfile.ToString(), false))
                        {
                            JObject jo = (JObject)ReturnToken;
                            webOut.WriteLine(jo.ToString());
                        }
                    }
                    catch (Exception e)
                    {
                        using (StreamWriter webOut = System.IO.File.CreateText(outfile.ToString()))
                        {
                            webOut.WriteLine(String.Format("There was an error : {0}", e.ToString()));
                        }
                    }
                }
            }
        }

        // POST: api/job/action
        [Route("api/job/AJ")]
        public void PostAJ([FromBody] JToken ajin)
        {
            Job hookJob = new Job();
            Models.File hookFile = new Models.File();
            List<Models.File> hookFiles = new List<Models.File>();
            Monitor hookMonitor = new Monitor();
            StringBuilder outfile = new StringBuilder();
            AlertWebhook hookval = new AlertWebhook();

            hookval = JsonConvert.DeserializeObject<AlertWebhook>(ajin.ToString());

            using (var db = new stdbContext())
            {
                hookJob = db.Jobs.Single(x => x.JobID == hookval.ID1);
                if (hookJob.JobStateID == 10)
                {
                    //Let's create a File object with the right JobID
                    // Job from JSON

                    if (hookJob.RootJobID != null)
                    {
                        hookJob = db.Jobs.SingleOrDefault(x => x.JobID == hookJob.RootJobID);
                    }

                    hookFile = db.Files.SingleOrDefault(x => x.FileID == hookJob.FileID);
                    hookFiles.Add(hookFile);
                    MyClasses.CreateJsonOutput JsonOut = new MyClasses.CreateJsonOutput();
                    JToken ReturnToken = JsonOut.JsonTokenBuilder(hookFiles);
                    hookMonitor = db.Monitors.SingleOrDefault(x => x.StorageFolderID == hookFile.StorageFolderID);
                    outfile.Append(hookMonitor.WatchFolder.Replace("incoming", "outgoing")).Append(Path.DirectorySeparatorChar).Append(hookFile.FileName).Append(".err");

                    try
                    {
                        using (StreamWriter webOut = new StreamWriter(outfile.ToString(), false))
                        {
                            JObject jo = (JObject)ReturnToken;
                            webOut.WriteLine(jo.ToString());
                        }
                    }
                    catch (Exception e)
                    {
                        using (StreamWriter webOut = System.IO.File.CreateText(outfile.ToString()))
                        {
                            webOut.WriteLine(String.Format("There was an error : {0}", e.ToString()));
                        }
                    }
                }
            }
        }


        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }



}