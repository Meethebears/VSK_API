using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace REPO.Models
{
    public partial class TempItemModelMixModel
    {

        public string trans_id { get; set; }
        public string ref_id { get; set; }
        public string data_year { get; set; }
        public string data_mouth { get; set; }
        public string data_name { get; set; }
        public int data_qty { get; set; }
        public DateTime created_date { get; set; }
        public DateTime last_updatetime { get; set; }
        
    }

    public class ItemSelectModel
    {
        public string id { get; set; }
        public string text { get; set; }
        public string name { get; set; }
        public string gnamechr { get; set; }
        public string keywords { get; set; }

    }

    public partial class ItemModelMixModel
    {
        
        public string query_code { get; set; }
        public int photo_item { get; set; }
        public int pages { get; set; }
        public int show { get; set; }
        public string keywords { get; set; }
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
        public string modelmix { get; set; }

        public string vehicle_brand { get; set; }
        public string vehicle_segments { get; set; }
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

        public string chassis { get; set; }
        public string horsepower { get; set; }
        public string wheel { get; set; }
        public string head_shape { get; set; }
        public string chassis_model { get; set; }
        public string chassis_code { get; set; }
        public string transmission { get; set; }
        public string gross_vehicle_weight { get; set; }

    }

}