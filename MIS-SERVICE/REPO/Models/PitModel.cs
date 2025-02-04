﻿using System;
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
    }
    public partial class Carmodel_MasterModel
    {
        public string mode { get; set; }
        public string id { get; set; }
        public string text { get; set; }
        public string keywords { get; set; }
        public string keywords_1 { get; set; }
        public string code { get; set; }
        public string name { get; set; }
        public string gbarcode { get; set; }
        public string spcodes { get; set; }
        public string gdescript { get; set; }
        public string uom { get; set; }
        public string ganme { get; set; }
        public string codechr { get; set; }
        public string itemgroup { get; set; }
        public string groupname { get; set; }
        public string type { get; set; }
        public string model_id { get; set; }
        public string minor_id { get; set; }
        public string brand_id { get; set; }
        public string brand_name { get; set; }
        public string brand_code  { get; set; }
        public string model_code  { get; set; }
        public string model_name  { get; set; }
        public string minor_code { get; set; }
        public string minor_name { get; set; }
        public string cartype { get; set; }
        public int record_status { get; set; }
        public string lov_id { get; set; }
        public string lov_code { get; set; }
        public string lov1 { get; set; }
        public string modelmix { get; set; }
        public string images { get; set; }
        public string vehicle_model { get; set; }
        public string minor_change { get; set; }
        public string body_type { get; set; }
        public string hign_stant { get; set; }
        public string street_name { get; set; }
        public string ref_photo_main { get; set; }
        public string car_models { get; set; }
        public string car_models_ref { get; set; }

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
        public string vehicle_model { get; set; }
        public string minor_change { get; set; }
        public string body_type { get; set; }
        public string hign_stant { get; set; }
        public string street_name { get; set; }
        public string record_status { get; set; }
        public string created_by { get; set; }
        public string created_datetime { get; set; }
        public string pMessage { get; set; }
    }
}