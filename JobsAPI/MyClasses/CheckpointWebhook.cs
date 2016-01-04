using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JobsAPI.Models
{
    public class CheckpointWebhook
    {
        // JSON look like this from a checkpoint
        //"JobID": 227861
        //"JobUID": "8228797C-7CB4-4757-B13F-3EF90EFF77F7"
        //"CheckpointID": 4
        //"CheckpointUID": "a0ecdcd5-f538-4cac-a00e-dc7c53474b4c"
        //"CheckpointName": "Acxiom Powerstream Complete"

        public int JobID { get; set; }
        public string JobUID { get; set; }
        public int CheckpointID { get; set; }
        public string CheckpointUID { get; set; }
        public string CheckpointName { get; set; }
    }
}