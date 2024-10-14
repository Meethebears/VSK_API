using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace REPO.Models
{
    public partial class CheckInvModel
    {
        public string inv_number { get; set; }
        public string keyword { get; set; }
        public string job_id { get; set; }
        public string job_number { get; set; }
        public string job_inv_number { get; set; }
        public string job_pk_number { get; set; }
        public string job_inv_emmas { get; set; }
        public string job_inv_address { get; set; }
        public DateTime job_inv_date { get; set; }
        public int job_inv_qty { get; set; }
        public string job_detail_id { get; set; }
        public string job_item_code { get; set; }
        public string job_item_name { get; set; }
        public string job_item_barcode { get; set; }
        public string job_item_spcodes { get; set; }
        public int job_item_qty { get; set; }
        public int job_item_trnqty { get; set; }
        public int job_detail_qty { get; set; }
        public string job_item_unit { get; set; }
        public string job_item_price { get; set; }
        public string created_by { get; set; }
        public DateTime created_date { get; set; }
        public string updated_by { get; set; }
        public DateTime updated_date { get; set; }
        public int record_status { get; set; }
        public string check_status { get; set; }
        public string pMessage { get; set; }
        public DateTime jobdate_start { get; set; }
        public DateTime jobdate_end { get; set; }

    }

}