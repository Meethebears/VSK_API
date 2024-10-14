using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace REPO.Models
{

    public partial class PbrInputModel
    {

        public string trans_id { get; set; }
        public string ref_id { get; set; }
        public string job_no { get; set; }
        public string job_batchno { get; set; }
        public string inv_number { get; set; }
        public DateTime job_date { get; set; }
        public int job_round { get; set; }
        public string location_branch { get; set; }
        public string receiver_id { get; set; }
        public string receiver_code { get; set; }
        public string receiver_delivery_address { get; set; }
        public string receiver_type { get; set; }

        public string mode { get; set; }
        public string pMessage { get; set; }

    }

    public partial class PbrGetModel
    {

        public DateTime job_date_start { get; set; }
        public DateTime job_date_end { get; set; }
        public int pages { get; set; }
        public int show { get; set; }
        public string mode { get; set; }
        public string id { get; set; }
        public string text { get; set; }
        public string emlocation { get; set; }

        public string trans_id { get; set; }
        public string ref_id { get; set; }
        public string job_no { get; set; }
        public DateTime job_date { get; set; }
        public int job_round { get; set; }
        public int job_batchno { get; set; }
        public string job_step { get; set; }
        public string job_verify { get; set; }
        public string sender_company_id { get; set; }
        public string sender_company_code { get; set; }
        public string sender_company_name { get; set; }
        public string company_name { get; set; }
        public string company_address { get; set; }
        public string company_district { get; set; }
        public string company_sub_district { get; set; }
        public string company_province { get; set; }
        public string company_postal_code { get; set; }
        public string company_tel { get; set; }
        public string receiver_addr_id { get; set; }
        public string receiver_id { get; set; }
        public string receiver_code { get; set; }
        public string receiver_name { get; set; }
        public string receiver_address_name { get; set; }
        public string receiver_delivery_address { get; set; }
        public string receiver_delivery_evcode { get; set; }
        public string receiver_delivery_evname { get; set; }
        public string receiver_delivery_tsno { get; set; }
        public string transport_company_id { get; set; }
        public string transport_company_name { get; set; }
        public string payment_type_id { get; set; }
        public string payment_type_name { get; set; }
        public string receiver_delivery_tumbol { get; set; }
        public string receiver_delivery_amphur { get; set; }
        public string receiver_delivery_provinc { get; set; }
        public string receiver_delivery_zip { get; set; }
        public string receiver_type { get; set; }
        public string receiver_custpo { get; set; }
        public string information_status { get; set; }
        public string item_status { get; set; }
        public string box_status { get; set; }
        public string event_status { get; set; }
        public int record_status { get; set; }
        public string created_by { get; set; }
        public DateTime created_datetime { get; set; }
        public string updated_by { get; set; }
        public DateTime updated_datetime { get; set; }
        public string deleted_by { get; set; }
        public DateTime deleted_datetime { get; set; }
        public string job_remark { get; set; }
        public string location_branch { get; set; }

        public string inv_number { get; set; }
        public string inv_descript { get; set; }
        public string remark_text { get; set; }

        public string box_id { get; set; }
        public string box_name { get; set; }
        public int box_qty { get; set; }
        public int inv_qty { get; set; }
        public int item_qty { get; set; }
        public int item_trnqty { get; set; }
        public int item_sku { get; set; }

        public string share_box_trans_id { get; set; }
        public string share_box_job_no { get; set; }
        public string share_ref_box_ref_id { get; set; }
        public string box_type { get; set; }

        public string branch_code_out { get; set; }
        public string branch_code_in { get; set; }

        public int row_no { get; set; }
        public DateTime time_strat { get; set; }
        public DateTime time_end { get; set; }
        public DateTime time_delete { get; set; }
        public string time_total { get; set; }
        public string event_job { get; set; }

        public string pMessage { get; set; }

    }

    public partial class PbrDataModel
    {

        public string trans_id { get; set; }
        public string ref_id { get; set; }
        public string job_no { get; set; }
        public DateTime job_date { get; set; }
        public int job_round { get; set; }

        public string sender_company_id { get; set; }
        public string sender_company_code { get; set; }
        public string sender_company_name { get; set; }
        public string receiver_addr_id { get; set; }
        public string receiver_id { get; set; }
        public string receiver_code { get; set; }
        public string receiver_name { get; set; }
        public string receiver_address_name { get; set; }
        public string receiver_delivery_address { get; set; }
        public string receiver_delivery_evcode { get; set; }
        public string receiver_delivery_evname { get; set; }
        public string receiver_delivery_tsno { get; set; }
        public string transport_company_id { get; set; }
        public string payment_type_id { get; set; }
        public string receiver_delivery_tumbol { get; set; }
        public string receiver_delivery_amphur { get; set; }
        public string receiver_delivery_provinc { get; set; }
        public string receiver_delivery_zip { get; set; }
        public string receiver_type { get; set; }
        public string receiver_custpo { get; set; }
        public string created_by { get; set; }
        public string updated_by { get; set; }
        public string deleted_by { get; set; }
        public string location_branch { get; set; }
        public string inv_number { get; set; }

        public string pMessage { get; set; }

    }

    public partial class PbrCheckAddrModel
    {

        public string id { get; set; }
        public string text { get; set; }
        public string emlocation { get; set; }
        public string address_id { get; set; }
        public string emmas_code { get; set; }
        public string location_name { get; set; }
        public string eaddress { get; set; }
        public string etumbol { get; set; }
        public string eamphur { get; set; }
        public string eprovinc { get; set; }
        public string ezip { get; set; }
        public string vendor_id { get; set; }
        public string vendor_name { get; set; }
        public string lov_id { get; set; }
        public string lov1 { get; set; }
        public string lov_code { get; set; }
        public string edefault { get; set; }
        public string tdefault { get; set; }

        public string pMessage { get; set; }

    }

    public partial class PbrInvModel
    {

        public string trans_id { get; set; }
        public string ref_id { get; set; }
        public string job_no { get; set; }
        public DateTime job_date { get; set; }
        public string job_scan { get; set; }
        public string job_number { get; set; }

        public string inv_number { get; set; }
        public DateTime inv_date { get; set; }
        public string inv_po { get; set; }
        public string inv_code { get; set; }
        public string inv_name { get; set; }
        public string inv_item { get; set; }
        public string inv_trans { get; set; }
        public string inv_due { get; set; }
        public string inv_paycash { get; set; }
        public string inv_paytran { get; set; }
        public string inv_paycard { get; set; }
        public string inv_payoth { get; set; }
        public string inv_sumtt { get; set; }
        public string inv_toption { get; set; }
        public string inv_descript { get; set; }
        public string inv_startdate { get; set; }
        public string inv_userid { get; set; }
        public string inv_pkuser { get; set; }
        public string event_status { get; set; }
        public string record_status { get; set; }
        public string created_by { get; set; }
        public string created_datetime { get; set; }
        public string updated_by { get; set; }
        public string updated_datetime { get; set; }
        public string inv_kline { get; set; }
        public string inv_branch { get; set; }
        public string inv_custpo { get; set; }
        public string inv_type { get; set; }
        public string receiver_type { get; set; }

        public string pMessage { get; set; }

    }

    public partial class PbrItemModel
    {

        public string trans_id { get; set; }
        public string ref_id { get; set; }
        public string job_no { get; set; }
        public string inv_number { get; set; }
        public string inv_po { get; set; }
        public string inv_descript { get; set; }
        public string item_code { get; set; }
        public string item_name { get; set; }
        public string item_barcode { get; set; }
        public string item_spcodes { get; set; }
        public int item_qty { get; set; }
        public int item_trnqty { get; set; }
        public string item_unit { get; set; }
        public string item_glocat { get; set; }
        public string job_status { get; set; }
        public string event_status { get; set; }
        public int record_status { get; set; }
        public string created_by { get; set; }
        public DateTime created_datetime { get; set; }
        public string updated_by { get; set; }
        public DateTime updated_datetime { get; set; }
        public DateTime updated_datetime_end { get; set; }

        public string pMessage { get; set; }
        public string keywords { get; set; }
        public string job_qty { get; set; }
        public string job_scan { get; set; }
        public int pages { get; set; }
        public int show { get; set; }
        public int count_item { get; set; }
        public int sum_qty { get; set; }
        public int sum_trnqty { get; set; }
        public int sum_qty_remark { get; set; }
        public float item_price { get; set; }
    }

    public partial class PbrBoxModel
    {

        public string share_ref_box_ref_id { get; set; }
        public string share_box_trans_id { get; set; }
        public string trans_id { get; set; }
        public string ref_id { get; set; }
        public string job_no { get; set; }
        public string inv_number { get; set; }
        public string box_id { get; set; }
        public string box_name { get; set; }
        public int box_qty { get; set; }
        public int box_a { get; set; }
        public int box_b { get; set; }
        public int box_c { get; set; }
        public int box_d { get; set; }
        public int box_d_l { get; set; }
        public int box_e { get; set; }
        public int box_f { get; set; }
        public int box_z { get; set; }
        public string event_status { get; set; }
        public int record_status { get; set; }
        public string created_by { get; set; }
        public DateTime created_datetime { get; set; }
        public string updated_by { get; set; }
        public DateTime updated_datetime { get; set; }

        public string information_status { get; set; }
        public string item_status { get; set; }
        public string box_status { get; set; }

        public string pMessage { get; set; }
        public string mode { get; set; }
        public string keywords { get; set; }

        public string lov_id { get; set; }
        public string lov1 { get; set; }
        public string receiver_id { get; set; }
        public string receiver_code { get; set; }
        public string receiver_delivery_address { get; set; }
    }

    public partial class PbrBatchModel
    {

        public string mode { get; set; }
        public string trans_id { get; set; }
        public string ref_id { get; set; }
        public string box_id { get; set; }
        public string batch_qty { get; set; }
        public string job_no { get; set; }
        public string inv_number { get; set; }
        public string job_batchno { get; set; }
        public string barcode { get; set; }
        public int box { get; set; }
        public int sku { get; set; }
        public int qty { get; set; }
        public string remark_text { get; set; }
        public string text_status { get; set; }
        public string event_status { get; set; }
        public string action_type { get; set; }
        public int record_status { get; set; }
        public string created_by { get; set; }
        public DateTime created_datetime { get; set; }
        public string updated_by { get; set; }
        public DateTime updated_datetime { get; set; }

        public string item_glocat { get; set; }
        public string item_code { get; set; }
        public string item_name { get; set; }
        public string item_spcodes { get; set; }
        public string search_item { get; set; }
        public string pMessage { get; set; }
    }


    public partial class PbrRemarkModel
    {

        public string trans_id { get; set; }
        public string ref_id { get; set; }
        public string delivery_ref_id { get; set; }
        public string job_no { get; set; }
        public DateTime remark_date { get; set; }
        public string remark_type { get; set; }
        public string remark_text { get; set; }
        public string event_status { get; set; }
        public int record_status { get; set; }
        public string created_by { get; set; }
        public DateTime created_datetime { get; set; }
        public string updated_by { get; set; }
        public DateTime updated_datetime { get; set; }

        public string pMessage { get; set; }
        public string mode { get; set; }
        public string keywords { get; set; }

    }

    public partial class PbrLoadingModel
    {

        public string job_branch { get; set; }
        public string job_scan { get; set; }
        public string job_round { get; set; }
        public DateTime job_date_start { get; set; }
        public DateTime job_date_end { get; set; }
        public DateTime job_date { get; set; }
        public string trans_id { get; set; }
        public string job_id { get; set; }
        public string ref_id { get; set; }
        public string job_no { get; set; }
        public string job_batno { get; set; }
        public string job_batchno { get; set; }
        public string delivery_ref_id { get; set; }
        public string ref_job_id { get; set; }
        public string ref_tms_job { get; set; }
        public string ref_movemax_job { get; set; }
        public int job_qty { get; set; }
        public int job_trnqty { get; set; }
        public string location_branch { get; set; }
        public string event_status { get; set; }
        public int record_status { get; set; }
        public string created_by { get; set; }
        public DateTime created_datetime { get; set; }
        public string updated_by { get; set; }
        public DateTime updated_datetime { get; set; }

        public string receiver_id { get; set; }
        public string sender_company_code { get; set; }
        public string receiver_code { get; set; }
        public string receiver_name { get; set; }
        public string receiver_address_name { get; set; }
        public string receiver_delivery_address { get; set; }
        public string transport_company_name { get; set; }
        public string payment_type_id { get; set; }
        public string payment_type_name { get; set; }

        public int row_number { get; set; }
        public string inv_number { get; set; }
        public string job_tms { get; set; }
        public string box_id { get; set; }
        public int box_qty { get; set; }
        public float cod { get; set; }

        public string pMessage { get; set; }
        public string mode { get; set; }
        public string keywords { get; set; }

    }

    public partial class PbrReceiveBoxModel
    {

        public string job_loading { get; set; }
        public string job_status { get; set; }
        public string job_scan { get; set; }
        public string job_round { get; set; }
        public string job_branch_code { get; set; }
        public string job_branch_name { get; set; }
        public string job_branch { get; set; }
        public int job_batch { get; set; }
        public string job_batch_out { get; set; }
        public string job_batch_in { get; set; }
        public string job_remark { get; set; }
        public string location_branch { get; set; }
        public DateTime job_date_start { get; set; }
        public DateTime job_date_end { get; set; }
        public DateTime job_date { get; set; }
        public string trans_id { get; set; }
        public string job_id { get; set; }
        public string ref_id { get; set; }
        public string job_no { get; set; }
        public string job_batno { get; set; }
        public string job_batchno { get; set; }
        public string delivery_ref_id { get; set; }
        public string ref_job_id { get; set; }
        public string ref_tms_job { get; set; }
        public string ref_movemax_job { get; set; }
        public int job_qty { get; set; }
        public int job_trnqty { get; set; }
        public string event_status { get; set; }
        public int record_status { get; set; }
        public string created_by { get; set; }
        public DateTime created_datetime { get; set; }
        public string updated_by { get; set; }
        public DateTime updated_datetime { get; set; }

        public string receiver_id { get; set; }
        public string sender_company_code { get; set; }
        public string receiver_code { get; set; }
        public string receiver_name { get; set; }
        public string receiver_address_name { get; set; }
        public string receiver_delivery_address { get; set; }
        public string transport_company_name { get; set; }
        public string payment_type_id { get; set; }
        public string payment_type_name { get; set; }
        public string box_type { get; set; }

        public string search_item { get; set; }
        public string search_box_status { get; set; }

        public string remark_cover_sheet { get; set; }
        public string remark_text { get; set; }

        public int row_number { get; set; }
        public string inv_number { get; set; }
        public string job_tms { get; set; }
        public int box_qty { get; set; }
        public int sku_qty { get; set; }
        public int item_qty { get; set; }
        public float cod { get; set; }

        public string pMessage { get; set; }
        public string mode { get; set; }
        public string keywords { get; set; }

        public string event_status_box { get; set; }
        public string event_status_item { get; set; }

    }

    public partial class PbrReceiveItemModel
    {

        public string trans_id { get; set; }
        public string ref_id { get; set; }
        public string job_no { get; set; }
        public string job_batno { get; set; }
        public string inv_number { get; set; }
        public string item_code { get; set; }
        public string item_name { get; set; }
        public string item_barcode { get; set; }
        public string item_spcodes { get; set; }
        public int item_qty { get; set; }
        public int item_trnqty { get; set; }
        public string item_unit { get; set; }
        public string item_glocat { get; set; }
        public string job_status { get; set; }
        public string text_status { get; set; }
        public string event_status { get; set; }
        public int record_status { get; set; }
        public string created_by { get; set; }
        public DateTime created_datetime { get; set; }
        public string updated_by { get; set; }
        public DateTime updated_datetime { get; set; }
        public DateTime updated_datetime_end { get; set; }

        public string gnamechr { get; set; }
        public string product_division { get; set; }
        public string main_category { get; set; }
        public string sub_category { get; set; }

        public string pMessage { get; set; }
        public string keywords { get; set; }
        public string job_qty { get; set; }
        public string job_scan { get; set; }
        public int pages { get; set; }
        public int show { get; set; }
        public int count_item { get; set; }
        public int sku_qty { get; set; }
        public int sum_qty { get; set; }
        public int sum_trnqty { get; set; }
        public int sum_qty_remark { get; set; }

    }

    public partial class PbrReceiveGetModel
    {
        public string job_date_start { get; set; }
        public string job_date_end { get; set; }

        public string trans_id { get; set; }
        public string ref_id { get; set; }
        public string ref_id_job { get; set; }
        public string ref_id_loading { get; set; }
        public string ref_id_receive { get; set; }
        public string ref_job_id { get; set; }

        public string job_loading { get; set; }
        public string job_type { get; set; }
        public string job_no { get; set; }
        public DateTime job_date { get; set; }
        public int job_round { get; set; }
        public int check_template { get; set; }
        public string job_name { get; set; }
        public string job_status { get; set; }
        public string pj_no { get; set; }
        public DateTime pj_dae { get; set; }
        public string br_no { get; set; }
        public DateTime br_date { get; set; }
        public DateTime ld_date { get; set; }
        public int ld_round { get; set; }
        public DateTime rc_date { get; set; }
        public int rc_round { get; set; }
        public string item_barcode { get; set; }
        public string item_name { get; set; }
        public string job_case { get; set; }
        public string job_remark { get; set; }
        public string job_branch { get; set; }

        public int item_qty { get; set; }
        public int box_qty { get; set; }
        public int item_sku { get; set; }

        public string location_branch { get; set; }
        public string item_status { get; set; }
        public string box_status { get; set; }
        public string event_status { get; set; }
        public string case_status { get; set; }
        public int record_status { get; set; }
        public string created_by { get; set; }
        public DateTime created_datetime { get; set; }
        public string updated_by { get; set; }
        public DateTime updated_datetime { get; set; }
        public string deleted_by { get; set; }
        public DateTime deleted_datetime { get; set; }

        public string pMessage { get; set; }
        public string mode { get; set; }
        public string keywords { get; set; }
        public int pages { get; set; }
        public int show { get; set; }

    }

    public partial class PbrCaseGetModel
    {
        public string job_date_start { get; set; }
        public string job_date_end { get; set; }

        public string trans_id { get; set; }
        public string ref_id { get; set; }
        public string ref_id_job { get; set; }
        public string ref_id_loading { get; set; }
        public string ref_id_receive { get; set; }
        public string ref_job_id { get; set; }

        public string job_assige { get; set; }
        public string job_ref { get; set; }
        public string job_loading { get; set; }
        public string job_scan { get; set; }
        public string job_no { get; set; }
        public DateTime job_date { get; set; }
        public int job_round { get; set; }
        public string job_name { get; set; }
        public string job_status { get; set; }
        public string pj_no { get; set; }
        public DateTime pj_date { get; set; }
        public string br_no { get; set; }
        public string po_no { get; set; }
        public DateTime br_date { get; set; }
        public DateTime ld_date { get; set; }
        public int ld_round { get; set; }
        public DateTime rc_date { get; set; }
        public int rc_round { get; set; }
        public string item_barcode { get; set; }
        public string code { get; set; }
        public string barcode { get; set; }
        public string spcodes { get; set; }
        public string name { get; set; }
        public string uom { get; set; }
        public string item_name { get; set; }
        public string job_case { get; set; }
        public string job_description { get; set; }
        public string job_remark { get; set; }
        public string job_branch { get; set; }

        public int qty { get; set; }
        public int job_qty { get; set; }
        public int scan_qty { get; set; }
        public int item_qty { get; set; }
        public int box_qty { get; set; }
        public int item_sku { get; set; }

        public string location_branch { get; set; }
        public string item_status { get; set; }
        public string box_status { get; set; }
        public string event_status { get; set; }
        public string case_status { get; set; }
        public int record_status { get; set; }
        public string created_by { get; set; }
        public DateTime created_datetime { get; set; }
        public string updated_by { get; set; }
        public DateTime updated_datetime { get; set; }
        public string deleted_by { get; set; }
        public DateTime deleted_datetime { get; set; }

        public string pMessage { get; set; }
        public string mode { get; set; }
        public string keywords { get; set; }
        public int pages { get; set; }
        public int show { get; set; }

    }

    public partial class PbrTemplateGetModel
    {

        public string ref_id { get; set; }
        public string trans_id { get; set; }
        public string job_remark { get; set; }
        public string mode { get; set; }

        public string job_no { get; set; }
        public string job_loading { get; set; }
        public string job_loading_round { get; set; }
        public string job_type { get; set; }
        public DateTime job_date { get; set; }
        public int job_round { get; set; }
        public string job_code { get; set; }
        public string job_name { get; set; }
        public string job_branch { get; set; }
        public string job_status { get; set; }

        public int sku_qty { get; set; }
        public int item_qty { get; set; }
        public int box_qty { get; set; }
        public int item_sku { get; set; }

        public int sku_qty_mr { get; set; }
        public int item_qty_mr { get; set; }

        public int sku_qty_po { get; set; }
        public int item_qty_po { get; set; }

        public string location_branch { get; set; }
        public string event_status { get; set; }
        public int record_status { get; set; }
        public string created_by { get; set; }
        public DateTime created_datetime { get; set; }
        public string updated_by { get; set; }
        public DateTime updated_datetime { get; set; }
        public string deleted_by { get; set; }
        public DateTime deleted_datetime { get; set; }
        public string pMessage { get; set; }

    }

    public partial class PbrMasterModel
    {

        public string pMessage { get; set; }
        public string mode { get; set; }
        public string keywords { get; set; }
        public string id { get; set; }
        public string text { get; set; }
    }

    public partial class PbrItemBatchScanModel
    {
        public string ref_id { get; set; }
        public string job_no { get; set; }
        public string job_invnumber { get; set; }
        public string job_scan { get; set; }
        public int job_qty { get; set; }
        public string updated_by { get; set; }
        public string pMessage { get; set; }
    }

}