using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace REPO.Models
{
    public partial class ManualGetModel
    {
        public string manual_id { get; set; }
        public string manual_name { get; set; }
        public string category_id { get; set; }
        public string category_name { get; set; }
        public string author { get; set; }
        public string description { get; set; }
        public string file_path { get; set; }
        public string event_status { get; set; }
        public int recode_status { get; set; }
        public string created_by { get; set; }
        public DateTime created_datetime { get; set; }
        public string updated_by { get; set; }
        public DateTime updated_datetime { get; set; }
        public int order_by { get; set; }

    }
}