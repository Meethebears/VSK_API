using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace REPO.Models
{
    public partial class CheckBrModel
    {
        public string pMessage { get; set; }
        public string ref_id { get; set; }
        public string keywords { get; set; }

        public DateTime trndate_start { get; set; }
        public DateTime trndate_end { get; set; }

        public string id { get; set; }
        public string text { get; set; }
        public string job_id { get; set; }
        public string job_no { get; set; }
        public DateTime job_date { get; set; }
        public string job_branch { get; set; }
        public string job_status { get; set; }
        public string job_remark { get; set; }
        public string location_branch { get; set; }
        public string check_branch { get; set; }

        public string barcode { get; set; }
        public string job_scan { get; set; }
        public int job_round { get; set; }
        public int job_qty { get; set; }
        public int sku_qty { get; set; }
        public int item_qty { get; set; }
        public int check_template { get; set; }
        public string action_type { get; set; }

        public string job_detail_id { get; set; }
        public string job_detail_no { get; set; }
        public DateTime job_detail_date { get; set; }
        public string job_detail_branch { get; set; }
        public string job_detail_barcode { get; set; }
        public string job_detail_spcodes { get; set; }
        public string job_detail_item_name { get; set; }
        public int job_detail_qty { get; set; }
        public int job_detail_trnqty { get; set; }
        public int job_detail_oldqty { get; set; }
        public int job_detail_qty_remark { get; set; }
        public string job_detail_unit { get; set; }
        public string job_detail_remark { get; set; }

        public string remark_id { get; set; }
        public DateTime remark_date { get; set; }
        public DateTime remark_job_date { get; set; }
        public string remark_job_no { get; set; }
        public string remark_barcode { get; set; }
        public string remark_description { get; set; }
        public int remark_qty { get; set; }
        public int remark_status { get; set; }
        public string job_remark_status { get; set; }

        public string created_by { get; set; }
        public DateTime created_datetime { get; set; }
        public string updated_by { get; set; }
        public DateTime updated_datetime { get; set; }
        public int record_status { get; set; }
        public string event_status { get; set; }

        public string number { get; set; }
        public string invcode { get; set; }
        public string invname { get; set; }
        public DateTime invdate { get; set; }
        public int item { get; set; }
        public DateTime startdate { get; set; }
        public int rdeleted { get; set; }
        public string mode { get; set; }
        public string p1 { get; set; }
        public string p2 { get; set; }
        public string p3 { get; set; }
        public string p4 { get; set; }
        public string p5 { get; set; }
        public int show { get; set; }
        public int pages { get; set; }

        public DateTime br_invdate { get; set; }
        public int br_item { get; set; }
        public int br_qty { get; set; }
        public DateTime br_startdate { get; set; }
        public string br_rdeleted { get; set; }
        public string br_number { get; set; }
        public string br_invcode { get; set; }
        public string br_invname { get; set; }

        public string cb_job_no { get; set; }
        public int cb_qty { get; set; }
        public string cb_created_by { get; set; }
        public DateTime cb_created_datatime { get; set; }
        public string cb_updated_by { get; set; }
        public DateTime cb_updated_datatime { get; set; }

        public DateTime updated_datetime_start { get; set; }
        public DateTime updated_datetime_end { get; set; }

        public int count_item { get; set; }
        public int sum_qty { get; set; }
        public int sum_trnqty { get; set; }
        public int sum_qty_remark { get; set; }
    }

    public partial class CheckBrDataModel
    {
        public string pMessage { get; set; }
        public string ref_id { get; set; }
        public string job_id { get; set; }
        public int job_round { get; set; }
        public DateTime job_date { get; set; }
        public string job_code { get; set; }
        public string job_branch { get; set; }
        public string job_no { get; set; }
        public int job_qty { get; set; }
        public string job_type { get; set; }
        public DateTime job_invdate { get; set; }
        public string job_invpo { get; set; }
        public DateTime job_startdate { get; set; }
        public float job_invsumtt { get; set; }
        public int job_invdue { get; set; }
        public string created_by { get; set; }
        public DateTime created_datetime { get; set; }
        public string updated_by { get; set; }
        public DateTime updated_datetime { get; set; }
        public int record_status { get; set; }
        public string event_status { get; set; }
        public string location_branch { get; set; }
        public string action_type { get; set; }

    }

    public partial class CheckBrParamModel
    {
        public string pMessage { get; set; }
        public string ref_id { get; set; }
        public int job_round { get; set; }
        public DateTime job_date { get; set; }
        public string job_code { get; set; }
        public string job_branch { get; set; }
        public string job_no { get; set; }
        public int job_qty { get; set; }
        public string created_by { get; set; }
        public string location_branch { get; set; }
    }

    public partial class CheckBrParamCModel
    {
        public string pMessage { get; set; }
        public string ref_id { get; set; }
        public int job_round { get; set; }
        public DateTime job_date { get; set; }
        public string job_code { get; set; }
        public string job_branch { get; set; }
        public string job_no { get; set; }
        public int job_qty { get; set; }
        public string created_by { get; set; }
        public DateTime job_invdate { get; set; }
        public string job_invpo { get; set; }
        public DateTime job_startdate { get; set; }
        public float job_invsumtt { get; set; }
        public int job_invdue { get; set; }
        public string location_branch { get; set; }
    }

    public partial class CheckBrParamGModel
    {
        public int job_round { get; set; }
        public DateTime job_date { get; set; }
    }

}