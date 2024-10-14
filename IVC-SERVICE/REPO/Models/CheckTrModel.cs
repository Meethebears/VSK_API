using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace REPO.Models
{
    public partial class CheckTrModel
    {
        public string tranfer_number { get; set; }
        public string tr_status { get; set; }
        public DateTime trndate_start { get; set; }
        public DateTime trndate_end { get; set; }

        public string job_detail_barcode { get; set; }
        public int job_detail_qty { get; set; }
        public DateTime job_date { get; set; }

        public string trans_id { get; set; }
        public DateTime tr_date { get; set; }
        public string tr_number { get; set; }
        public string pMessage { get; set; }
        public string gbarcode { get; set; }
        public string tr_scan { get; set; }
        public string r_remark { get; set; }
        public int r_qty { get; set; }
        public int tr_qty { get; set; }
      
        public string tr_detail_id { get; set; }
        public DateTime tr_detail_trndate { get; set; }
        public string tr_detail_no { get; set; }
        public string tr_detail_gbarcode { get; set; }
        public string tr_detail_spcodes { get; set; }
        public string tr_detail_stkname { get; set; }
        public string tr_detail_stkcode { get; set; }
        public string tr_detail_stktype { get; set; }
        public string tr_detail_empcod { get; set; }
        public string tr_detail_stkunit { get; set; }
        public int tr_detail_qty { get; set; }
        public int tr_detail_trnqty { get; set; }
        public string tr_detail_location { get; set; }
        public string tr_detail_remark { get; set; }
        public int tr_detail_qty_remark { get; set; }
        public int tr_detail_qty_item { get; set; }

        public string tr_remark_id { get; set; }
        public DateTime tr_remark_trndate { get; set; }
        public string tr_remark_no { get; set; }
        public string tr_remark_gbarcode { get; set; }
        public string tr_remark_detail { get; set; }
        public int tr_remark_qty { get; set; }
        public string tr_remark_status { get; set; }

        public string created_by { get; set; }
        public DateTime created_datetime { get; set; }
        public string updated_by { get; set; }
        public DateTime updated_datetime { get; set; }
        public int record_status { get; set; }

    }

}