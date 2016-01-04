using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JobsAPI.Models
{
    public class AlertWebhook
    {
        // JSON looks like this from a monitor
        //"Details": "SPDE job was cancelled while still processing."
        //"Data": null
        //"Device": "sspd02_t6_pdmexxxx"
        //"Message": null
        //"ID1": 231736
        //"ID2": 199
        //"ID3": null

        public string Details { get; set; }
        public string Data { get; set; }
        public string Device { get; set; }
        public string Message { get; set; }
        public int ID1 { get; set; }
        public int ID2 { get; set; }
        public string ID3 { get; set; }
    }
}