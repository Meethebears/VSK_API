using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace REPO.Models
{
    public partial class StockRequestModel
    {
        public string pMessage { get; set; }

        public string job_id { get; set; }
        public string job_no { get; set; }
        public string job_branch_start { get; set; }
        public string job_branch_end { get; set; }
        public string job_user_start { get; set; }
        public string job_user_end { get; set; }
        public string job_user_approval { get; set; }
        public string job_status { get; set; }
        public string job_remark { get; set; }
        public string job_type { get; set; }
        public string job_cause { get; set; }
        public string event_status { get; set; }
        public int record_status { get; set; }
        public string created_by { get; set; }
        public DateTime created_datetime { get; set; }
        public string updated_by { get; set; }
        public DateTime updated_datetime { get; set; }
        public DateTime job_date { get; set; }
        public DateTime job_approval_datetime { get; set; }
        public string job_approval_by { get; set; }

        public string j_event_status { get; set; }
        public int j_record_status { get; set; }
        public string j_created_by { get; set; }
        public DateTime j_created_datetime { get; set; }
        public string j_updated_by { get; set; }
        public DateTime j_updated_datetime { get; set; }

        public string detail_id { get; set; }
        public string detail_ref_id { get; set; }
        public string detail_job_no { get; set; }
        public string detail_barcode { get; set; }
        public string detail_spcodes { get; set; }
        public string detail_item_code { get; set; }
        public string detail_item_name { get; set; }
        public int detail_qty { get; set; }
        public string detail_unit { get; set; }
        public string detail_subunit { get; set; }
        public float  detail_price { get; set; }
        public int detail_incomplete_qty { get; set; }
        public string detail_incomplete_remark { get; set; }

        public string d_event_status { get; set; }
        public int d_record_status { get; set; }
        public string d_created_by { get; set; }
        public DateTime d_created_datetime { get; set; }
        public string d_updated_by { get; set; }
        public DateTime d_updated_datetime { get; set; }

        public int item_qty { get; set; }
        public DateTime trndate_start { get; set; }
        public DateTime trndate_end { get; set; }

    }

}