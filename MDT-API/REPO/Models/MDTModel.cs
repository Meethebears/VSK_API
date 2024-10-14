using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace REPO.Models
{
    public partial class MDTModel
    {
        public string trans_id { get; set; }
        public DateTime invdate { get; set; }
        public string number { get; set; }
        public string branch { get; set; }
        public string bill_no { get; set; }
        public string invcode { get; set; }
        public string invname { get; set; }
        public string userid { get; set; }
        public string driver { get; set; }
        public DateTime startdate { get; set; }
        public DateTime created_datetime { get; set; }
        public int record_status { get; set; }

    }

}
