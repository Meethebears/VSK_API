using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace REPO.Models
{
    public partial class CheckModel
    {
        public string emmas_code { get; set; }
        public string packing_delivery_addr { get; set; }
        public DateTime packing_job_date { get; set; }
        public string pMessage { get; set; }
        public string chk_pj { get; set; }
        public string packing_job_no { get; set; }
    }
    public partial class PackingModel
    {
        public string keywords { get; set; }
        public string invnumber { get; set; }
        public string invname { get; set; }
        public string invcode { get; set; }
        public string invaddress { get; set; }
        public string invemlocation { get; set; }
        public string invpkuser { get; set; }

        public string invcustpo { get; set; }
        public string carregis { get; set; }
        public string clame { get; set; }
        public string edno { get; set; }
        public string tsno { get; set; }
        public string model { get; set; }
        public string evcode { get; set; }
        public string evname { get; set; }
        public string evadd { get; set; }
        public string evtel { get; set; }
        public string invkline { get; set; }


        public DateTime invdate { get; set; }
        public string pMessage { get; set; }
        public string created_by { get; set; }
        public DateTime created_date { get; set; }
        public string updated_by { get; set; }
        public DateTime updated_date { get; set; }
        public int record_status { get; set; }
    }
    public partial class InvModel
    {
        public string keywords { get; set; }
        public string invnumber { get; set; }
        public string invname { get; set; }
        public string invcode { get; set; }
        public DateTime invdate { get; set; }
        public string invaddress { get; set; }
        public string invpo { get; set; }
        public string invitem { get; set; }
        public string userid { get; set; }
        public string pMessage { get; set; }
        public string created_by { get; set; }
        public DateTime created_date { get; set; }
        public string updated_by { get; set; }
        public DateTime updated_date { get; set; }
        public int record_status { get; set; }
    }
    public partial class LovModel
    {
        public string trans_id { get; set; }
        public string temp_id { get; set; }
        public string keywords { get; set; }
        public string pMessage { get; set; }
        public string lov_id { get; set; }
        public string lov_group { get; set; }
        public string lov_type { get; set; }
        public string parent_lov_id { get; set; }
        public string lov_code { get; set; }
        public string lov1 { get; set; }
        public string lov2 { get; set; }
        public string lov3 { get; set; }
        public string lov4 { get; set; }
        public string lov5 { get; set; }
        public string lov6 { get; set; }
        public string lov7 { get; set; }
        public string lov8 { get; set; }
        public string lov9 { get; set; }
        public string lov10 { get; set; }
        public string lov_desc { get; set; }
        public string lov_order { get; set; }
        public string active_flag { get; set; }
        public string created_by { get; set; }
        public DateTime created_date { get; set; }
        public string updated_by { get; set; }
        public DateTime updated_date { get; set; }
    }
    public partial class TempModel
    {
        public string mode { get; set; }
        public string keywords { get; set; }
        public int prepages { get; set; }
        public string job_detail_qty { get; set; }
        public string trans_id { get; set; }
        public string temp_id { get; set; }
        public string pMessage { get; set; }
        public string packing_job_id { get; set; }
        public string packing_job_no { get; set; }
        public DateTime packing_job_date { get; set; }
        public string salefile_number { get; set; }
        public string salefile_name { get; set; }
        public string salefile_invcode { get; set; }
        public string salefile_invpo { get; set; }
        public string salefile_item { get; set; }
        public string salefile_userid { get; set; }
        public DateTime salefile_startdate { get; set; }
        public string salefile_evcode { get; set; }
        public string salefile_evname { get; set; }
        public string salefile_evadd { get; set; }
        public string salefile_tsno { get; set; }
        public string packing_box { get; set; }
        public string packing_box_name { get; set; }
        public string packing_delivery_name { get; set; }
        public string packing_delivery_addr { get; set; }
        public string packing_delivery_emlocation { get; set; }
        public string packing_round { get; set; }
        public string packing_type { get; set; }
        public string packing_evcode { get; set; }
        public string packing_evname { get; set; }
        public string packing_tsno { get; set; }
        public string packing_item_status { get; set; }
        public string lov_packing_name { get; set; }
        public string vendor_id { get; set; }
        public string lov_deliverycost_code { get; set; }
        public string emmas_code { get; set; }
        public string emmas_sender_name { get; set; }
        public string packing_ref_code { get; set; }
        public int count_box { get; set; }
        public int count_inv { get; set; }
        public int item_list { get; set; }
        public int item_verify { get; set; }
        public int item_total { get; set; }

        public int box_A { get; set; }
        public int box_B { get; set; }
        public int box_C { get; set; }
        public int box_D { get; set; }
        public int box_E { get; set; }
        public int box_F { get; set; }
        public int box_Z { get; set; }

        public int packing_box_qty { get; set; }
        public int packing_box_a { get; set; }
        public int packing_box_b { get; set; }
        public int packing_box_c { get; set; }
        public int packing_box_d { get; set; }
        public int packing_box_e { get; set; }
        public int packing_box_f { get; set; }
        public int packing_box_z { get; set; }

        public string job_detail_id { get; set; }
        public string job_no { get; set; }
        public string job_item_code { get; set; }
        public string job_item_name { get; set; }
        public string job_item_barcode { get; set; }
        public string job_item_spcodes { get; set; }
        public int job_item_qty { get; set; }
        public int job_item_trnqty { get; set; }
        public string job_item_unit { get; set; }
        public string job_item_price { get; set; }

        public DateTime packing_jobdate_start { get; set; }
        public DateTime packing_jobdate_end { get; set; }
        public string created_by { get; set; }
        public DateTime created_datetime { get; set; }
        public string updated_by { get; set; }
        public DateTime updated_datetime { get; set; }
        public int record_status { get; set; }
        public string packing_status { get; set; }
        public string event_status { get; set; }
        public string job_packing_ref { get; set; }

        public string box_trans_id { get; set; }
        public string packing_share_job_id { get; set; }
        public string packing_share_job_no { get; set; }
        public string packing_share_box_id { get; set; }
        public string packing_share_box_name { get; set; }
        public int packing_share_box_qty { get; set; }
        public string packing_share_desrcipt { get; set; }
        public int share_box { get; set; }

        public string packing_remark { get; set; }

        public string invcustpo { get; set; }
        public string carregis { get; set; }
        public string clame { get; set; }
        public string edno { get; set; }
        public string tsno { get; set; }
        public string model { get; set; }
        public string evcode { get; set; }
        public string evname { get; set; }
        public string evadd { get; set; }
        public string evtel { get; set; }
        public string invkline { get; set; }


        public string company_name { get; set; }
        public string company_address { get; set; }
        public string company_district { get; set; }
        public string company_sub_district { get; set; }
        public string company_province { get; set; }
        public string company_postal_code { get; set; }
        public string company_tel { get; set; }
        public string sender_name { get; set; }
        public string cumtomer_code { get; set; }
        public string cumtomer_name { get; set; }
        public string delivery_emlocation { get; set; }
        public string eaddress { get; set; }
        public string etumbol { get; set; }
        public string eamphur { get; set; }
        public string eprovinc { get; set; }
        public string ezip { get; set; }
        public string etel { get; set; }
        public string delivery_cost { get; set; }
        public string vendor_name { get; set; }


        public string number { get; set; }
        public string packing_job_no_bat { get; set; }
        public int packing_bat_qty { get; set; }
        public int packing_delivery_cycle { get; set; }
        public int delivery_cycle { get; set; }
        public DateTime job_date { get; set; }
        public string company { get; set; }
        public string send_start { get; set; }
        public string pay_type { get; set; }
        public string send_end { get; set; }
        public string send_addr { get; set; }

        public string invemlocation { get; set; }
        public string address_id { get; set; }
        public string location_name { get; set; }
        public string glb_amphur_name { get; set; }
        public string glb_district_name { get; set; }
        public string glb_province_name { get; set; }
        public string lov_id { get; set; }
        public string lov1 { get; set; }
        public string lov_code { get; set; }
        public string name { get; set; }
        public string edefault { get; set; }

        public string emmas_addr_id { get; set; }
        public string packing_delivery_tumbol { get; set; }
        public string packing_delivery_amphur { get; set; }
        public string packing_delivery_provinc { get; set; }
        public string packing_delivery_zip { get; set; }
        
        public int pages { get; set; }
        public int show { get; set; }

        public string row_number { get; set; }
        public string inv_number { get; set; }
        public string job_tms { get; set; }
        public string box_qty { get; set; }
        public string cod { get; set; }
        public int tdefault { get; set; }

        public string photo_gbarcode { get; set; }

        public string round { get; set; }
        public DateTime remark_date { get; set; }
        public string remark_type { get; set; }
        public string remark_text { get; set; }

    }

}