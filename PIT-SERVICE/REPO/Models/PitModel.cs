using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace REPO.Models
{
    public partial class Carmodel_tmp_Model
    {
        public string mode { get; set; }
        public string temp_id { get; set; }
        public string countitem_all { get; set; }
        public string countitem_incomplete { get; set; }
        public string countitem_complete { get; set; }
        public string countitem_updated { get; set; }
        public string record_status { get; set; }
        public string created_by { get; set; }
        public DateTime created_datetime { get; set; }
        public string updated_by { get; set; }
        public DateTime updated_datetime { get; set; }

    }
    public partial class Carmodel_tmptran_Model
    {
        public string mode { get; set; }
        public string trans_id { get; set; }
        public string temp_id { get; set; }
        public string model_id { get; set; }
        public string modelmix { get; set; }
        public string modelmixed { get; set; }
        public string gbarcode { get; set; }
        public string spcodes { get; set; }
        public string gnamechr { get; set; }
        public string cartype { get; set; }
        public string vehicle_brand { get; set; }
        public string vehicle_model { get; set; }
        public string minor_change { get; set; }
        public string minor_start { get; set; }
        public string minor_end { get; set; }
        public string model_change { get; set; }
        public string model_start { get; set; }
        public string model_end { get; set; }
        public string fuel_type { get; set; }
        public string engine_displacement { get; set; }
        public string engine_code { get; set; }
        public string transmission_type { get; set; }
        public string body_type { get; set; }
        public string hign_stant { get; set; }
        public string wheel_drive { get; set; }
        public string street_name { get; set; }
        public string model_code { get; set; }
        public string code_e { get; set; }
        public string remarks { get; set; }
        public string action { get; set; }
        public string record_status { get; set; }
        public string text_status { get; set; }
        public string chk_duplicate { get; set; }
        public string created_by { get; set; }
        public DateTime created_datetime { get; set; }
        public string updated_by { get; set; }
        public DateTime updated_datetime { get; set; }
        public string pMessage { get; set; }
        public string photo_id { get; set; }
        public string photo_name { get; set; }
        public string photo_no { get; set; }
        public string photo_folder { get; set; }
        public string photo_url { get; set; }
        public string check_photo { get; set; }
        public string images { get; set; }
        public string car_models { get; set; }
        public string car_models_ref { get; set; }

        public string vehicle_segments { get; set; }
        public string chassis { get; set; }
        public string horsepower { get; set; }
        public string wheel { get; set; }
        public string head_shape { get; set; }
        public string chassis_model { get; set; }
        public string chassis_code { get; set; }
        public string transmission { get; set; }
        public string gross_vehicle_weight { get; set; }
        public string code_status { get; set; }
        public int item { get; set; }

    }
    public partial class Carmodel_MasterModel
    {
        public string mode { get; set; }
        public int pages { get; set; }
        public int show { get; set; }
        public string id { get; set; }
        public string text { get; set; }
        public string keywords { get; set; }
        public string keywords_1 { get; set; }
        public string keywords_2 { get; set; }
        public string keywords_3 { get; set; }
        public string keywords_4 { get; set; }
        public string keywords_5 { get; set; }
        public string keywords_6 { get; set; }
        public string code { get; set; }
        public string gname { get; set; }
        public string name { get; set; }
        public string gbarcode { get; set; }
        public string chrcode { get; set; }
        public string spcodes { get; set; }
        public string gnamechr { get; set; }
        public string goem { get; set; }
        public string gmodel { get; set; }
        public string gused { get; set; }
        public string ganme { get; set; }
        public string codechr { get; set; }
        public string stmas_carbrand { get; set; }
        public string stmas_carmodel { get; set; }
        public string stmas_cargeneration { get; set; }
        public string itemgroup { get; set; }
        public string groupname { get; set; }
        public string type { get; set; }
        public string avgsalecost { get; set; }
        public float gprice { get; set; }
        public float gprice_a { get; set; }
        public float gprice_b { get; set; }
        public float gprice_c { get; set; }
        public float gprice_d { get; set; }
        public float gprice_e { get; set; }
        public float gprice_f { get; set; }
        public string uom { get; set; }
        public string code_a { get; set; }
        public string code_b { get; set; }
        public string code_c { get; set; }
        public string code_d { get; set; }
        public string code_e { get; set; }
        public string codeoem { get; set; }
        public string data_type { get; set; }
        public string model_id { get; set; }
        public string minor_id { get; set; }
        public string brand_id { get; set; }
        public string brand_name { get; set; }
        public string brand_code { get; set; }
        public string model_code { get; set; }
        public string model_name { get; set; }
        public string minor_code { get; set; }
        public string minor_name { get; set; }
        public string cartype { get; set; }
        public string min_model_change { get; set; }
        public string max_model_change { get; set; }
        public string product_division { get; set; }
        public string main_category { get; set; }
        public string sub_category { get; set; }
        public int record_status { get; set; }
        public string lov_id { get; set; }
        public string lov_code { get; set; }
        public string lov1 { get; set; }
        public string modelmix { get; set; }
        public string images { get; set; }
        public int photo_item { get; set; }
        public string vehicle_brand { get; set; }
        public string vehicle_model { get; set; }
        public string model_change { get; set; }
        public string minor_change { get; set; }
        public string fuel_type { get; set; }
        public string engine_displacement { get; set; }
        public string engine_code { get; set; }
        public string transmission_type { get; set; }
        public string wheel_drive { get; set; }
        public string body_type { get; set; }
        public string hign_stant { get; set; }
        public string street_name { get; set; }
        public string ref_photo_main { get; set; }
        public string car_models { get; set; }
        public string car_models_ref { get; set; }
        public string photo_id { get; set; }
        public string photo_data { get; set; }
        public string photo_name { get; set; }
        public string photo_lname { get; set; }
        public string photo_folder { get; set; }
        public string photo_gbarcode { get; set; }
        public string photo_ref { get; set; }
        public string photo_position { get; set; }
        public string userid { get; set; }
        public string text_status { get; set; }
        public DateTime startdate { get; set; }
        public string created_by { get; set; }
        public DateTime created_date { get; set; }
        public DateTime created_datetime { get; set; }

        public string updated_by { get; set; }
        public DateTime updated_datetime { get; set; }


        public string vehicle_segments { get; set; }
        public string chassis { get; set; }
        public string horsepower { get; set; }
        public string wheel { get; set; }
        public string head_shape { get; set; }
        public string chassis_model { get; set; }
        public string chassis_code { get; set; }
        public string transmission { get; set; }
        public string gross_vehicle_weight { get; set; }
        public string code_status { get; set; }

        public string car_shape_id { get; set; }
        public string car_shape_no { get; set; }
        public string car_shape_code { get; set; }
        public string car_shape_name { get; set; }
        public string car_shape_type { get; set; }
        public string car_shape_remark { get; set; }

        public string car_picture_id { get; set; }
        public string car_picture_code { get; set; }
        public string car_picture_name { get; set; }
        public string car_picture_folder { get; set; }
        public string car_picture_type { get; set; }
        public string car_picture_ref_id { get; set; }
        public int car_picture_order { get; set; }
        public int car_picture_def { get; set; }
        public int img_qty { get; set; }
        public string ref_shape_id { get; set; }
        public string ref_shape_code { get; set; }

        public int check_photo { get; set; }
        public string cs_images { get; set; }
        public string pMessage { get; set; }

    }
    public partial class Carmodel_Check_Model
    {
        public string modelmixed { get; set; }
        public string minor_change { get; set; }
        public string model_change { get; set; }
        public string fuel_type { get; set; }
        public string engine_displacement { get; set; }
        public string engine_code { get; set; }
        public string transmission_type { get; set; }
        public string body_type { get; set; }
        public string hign_stant { get; set; }
        public string wheel_drive { get; set; }
        public string street_name { get; set; }
        public string pMessage { get; set; }
    }
    public partial class Carmodel_Photo_Model
    {
        public string mode { get; set; }
        public string photo_id { get; set; }
        public string model_id { get; set; }
        public string temp_id { get; set; }
        public string modelmix { get; set; }
        public string photo_name { get; set; }
        public string photo_folder { get; set; }
        public string photo_url { get; set; }
        public string photo_type { get; set; }
        public string photo_no { get; set; }

        public string vehicle_segments { get; set; }
        public string vehicle_model { get; set; }
        public string model_change { get; set; }
        public string minor_change { get; set; }
        public string body_type { get; set; }
        public string hign_stant { get; set; }
        public string chassis_model { get; set; }
        public string wheel_drive { get; set; }
        public string wheel { get; set; }
        public string street_name { get; set; }
        public string record_status { get; set; }
        public string created_by { get; set; }
        public string created_datetime { get; set; }
        public string pMessage { get; set; }
    }

    public partial class Carmodel_Gcode
    {
        public string mode { get; set; }
        public string id { get; set; }
        public string text { get; set; }
        public string keywords { get; set; }
        public string code { get; set; }
        public string gname { get; set; }
        public string name { get; set; }
        public string gbarcode { get; set; }
        public string chrcode { get; set; }
        public string spcodes { get; set; }
        public string gnamechr { get; set; }
        public string codechr { get; set; }
        public string vehicle_segments { get; set; }
        public string vehicle_brand { get; set; }
        public string vehicle_model { get; set; }
        public string cartype { get; set; }
        public string model_change { get; set; }
        public string minor_change { get; set; }
        public string fuel_type { get; set; }
        public string engine_displacement { get; set; }
        public string engine_code { get; set; }
        public string transmission_type { get; set; }
        public string wheel_drive { get; set; }
        public string body_type { get; set; }
        public string hign_stant { get; set; }
        public string street_name { get; set; }
        public string product_division { get; set; }
        public string main_category { get; set; }
        public string sub_category { get; set; }


    }
}