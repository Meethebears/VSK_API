using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace REPO.Models
{
    public class LoscanModel
    {
        public string mode { get; set; }
        public string pMessage { get; set; }
        public DateTime job_date_start { get; set; }
        public DateTime job_date_end { get; set; }

        public string trans_id { get; set; }
        public string temp_id { get; set; }

        public int countitem_all { get; set; }
        public int countitem_incomplete { get; set; }
        public int countitem_updated { get; set; }
        public int countitem_complete { get; set; }

        public DateTime scan_date { get; set; }
        public string user_scan { get; set; }
        public string wh { get; set; }
        public string location { get; set; }
        public string glocat { get; set; }
        public string code { get; set; }
        public string name { get; set; }
        public string spcodes { get; set; }
        public string barcode { get; set; }
        public string remarks { get; set; }

        public string action_type { get; set; }
        public string event_status { get; set; }
        public string text_status { get; set; }
        public string text_status_verify { get; set; }
        public int record_status { get; set; }

        public int item_qty { get; set; }
        public int item_warning { get; set; }
        public int item_success { get; set; }

        public string created_by { get; set; }
        public DateTime created_datetime { get; set; } 
        public string updated_by { get; set; }
        public DateTime updated_datetime { get; set; }


    }

}