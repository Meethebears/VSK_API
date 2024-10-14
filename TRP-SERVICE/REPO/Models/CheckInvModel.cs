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

    public partial class CheckInvInputModel
    {
        public string ref_id { get; set; }
        public string keywords { get; set; }
        public string job_no { get; set; }
        public string job_scan { get; set; }
        public string job_qty { get; set; }
        public string job_number { get; set; }
        public string job_branch { get; set; }
        public string job_status { get; set; }
        public string location_branch { get; set; }

        public string pMessage { get; set; }
        public string created_by { get; set; }
        public string updated_by { get; set; }
        public int pages { get; set; }
        public int show { get; set; }

    }

    public partial class CheckListInputModel
    {
        public DateTime trndate_start { get; set; }
        public DateTime trndate_end { get; set; }
        public string ref_id { get; set; }
        public string mode { get; set; }
        public string job_no { get; set; }
        public string job_number { get; set; }
        public string job_branch { get; set; }
        public string job_status { get; set; }
        public string location_branch { get; set; }
        public string created_by { get; set; }
        public int pages { get; set; }
        public int show { get; set; }

    }

    public partial class CheckInvDataModel
    {
        public string ref_id { get; set; }
        public string trans_id { get; set; }
        public string job_id { get; set; }
        public string job_no { get; set; }
        public string job_invnumber { get; set; }
        public string job_invdate { get; set; }
        public string job_invpo { get; set; }
        public string job_invcode { get; set; }
        public string job_invname { get; set; }
        public string job_invitem { get; set; }
        public string job_invdescript { get; set; }
        public string job_invbranch { get; set; }
        public string job_invcustpo { get; set; }
        public string job_invcustpo_verify { get; set; }
        public string job_detail_id { get; set; }
        public string job_detail_no { get; set; }
        public string job_detail_number { get; set; }
        public string job_detail_branch { get; set; }
        public string job_detail_barcode { get; set; }
        public string job_detail_spcodes { get; set; }
        public string job_detail_item_name { get; set; }
        public int job_detail_qty { get; set; }
        public int job_detail_trnqty { get; set; }
        public string job_detail_unit { get; set; }

        public int data_length { get; set; }
        public int count_item { get; set; }
        public int sum_qty { get; set; }
        public int sum_trnqty { get; set; }
        public int sum_qty_remark { get; set; }
        public DateTime updated_datetime_end { get; set; }
        public DateTime last_updatetime { get; set; }

        public string location_branch { get; set; }
        public string event_status { get; set; }
        public string created_by { get; set; }
        public DateTime created_datetime { get; set; }
        public string updated_by { get; set; }
        public DateTime updated_datetime { get; set; }
        public int record_status { get; set; }
        public int job_detail_qty_remark { get; set; }
        public string job_detail_remark { get; set; }
        public string job_status { get; set; }
        public string pMessage { get; set; }
        public int pages { get; set; }
        public int show { get; set; }

    }

    public partial class CheckInvCountModel
    {

        public string ref_id { get; set; }
        public int count_item { get; set; }
        public int sum_qty { get; set; }
        public int sum_qty_remark { get; set; }
        public int sum_trnqty { get; set; }
        public DateTime updated_datetime_end { get; set; }
        public DateTime last_updatetime { get; set; }

    }
}