using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace REPO.Models
{
    public partial class LogEventModel
    {
        public string trans_id { get; set; }
        public string event_id { get; set; }
        public DateTime event_date { get; set; }
        public string ref_id { get; set; }
        public string event_number { get; set; }
        public string domain_id { get; set; }
        public string app_name { get; set; }
        public string seasion_id { get; set; }
        public string user_id { get; set; }
        public string screen_name { get; set; }
        public string event_name { get; set; }
        public string event_status { get; set; }
        public string client_name { get; set; }
        public string db_name { get; set; }
        public string event_data { get; set; }
        public string error_message { get; set; }
        public string error_stacktrace { get; set; }
        public string error_source { get; set; }
    }

    public partial class LogErrorModel
    {
        public string trans_id { get; set; }
        public string error_id { get; set; }
        public DateTime error_date { get; set; }
        public string source_id { get; set; }
        public string error_message { get; set; }
        public string error_stacktrace { get; set; }
        public string error_source { get; set; }
    }
}