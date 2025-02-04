﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace REPO.Models
{
    public partial class MasterModel
    {
        //start 1 รายละเอียด //
        public string keywords { get; set; }
        public int chk_dup { get; set; }
        public string code { get; set; }
        public string gname { get; set; }
        public string codechr { get; set; }
        public string ctype { get; set; }
        public string userid { get; set; }
        public string rec { get; set; }
        public string function_type { get; set; }
        public DateTime startdate { get; set; }
        
    }

    public partial class Stmas_ExpModel
    {
        //start 1 รายละเอียด //
        public string Mode { get; set; }
        public string part_number { get; set; }
        public string code { get; set; }
        public string code_name { get; set; }
        public string gbarcode { get; set; }
        public string chrcode { get; set; }
        public string spcodes { get; set; }
        public string gzone { get; set; }
        public string gprice { get; set; }
        public string UOM { get; set; }
        public string qtysmall { get; set; }
        public string gmodel { get; set; }
        public string carbrand { get; set; }
        public string cartype { get; set; }
        public string carmodel { get; set; }
        public string carfmyear { get; set; }
        public string cartoyear { get; set; }
        public string carGeneration { get; set; }
        public string carEngine { get; set; }
        public string carBody { get; set; }
        public string serviceyear { get; set; }
        public DateTime startdate { get; set; }
        public string name { get; set; }
        public string goem { get; set; }
        public string gremark { get; set; }
        public string codeOem { get; set; }
        public string code_aexp { get; set; }
        public string name_aexp { get; set; }
        public string code_a { get; set; }
        public string code_b { get; set; }
        public string code_c { get; set; }
        public string code_d { get; set; }
        public string code_e { get; set; }
        public string code_a_name { get; set; }
        public string code_b_name { get; set; }
        public string code_c_name { get; set; }
        public string code_d_name { get; set; }
        public string code_e_name { get; set; }
        public string code_aexp_name { get; set; }
        public string code_bexp_name { get; set; }
        public string code_cexp_name { get; set; }
        public string code_dexp_name { get; set; }
        public string code_eexp_name { get; set; }
        public string gnamechr { get; set; }
        public string glocat { get; set; }
        public string coderef { get; set; }
        public string temp_id { get; set; }
        public string created_by { get; set; }
        public string created_by2 { get; set; }
        public string record_status { get; set; }
        public string stmas_code_compare { get; set; }
        public string stmas_name_compare { get; set; }
        public string stmas_exp_name_compare { get; set; }
        public string code_a_compare { get; set; }
        public string code_b_compare { get; set; }
        public string code_c_compare { get; set; }
        public string code_d_compare { get; set; }
        public string code_e_compare { get; set; }
        public string c5_code { get; set; }
        public string c5_gname { get; set; }
        public string c5_carbrand_code { get; set; }
        public string c5_carbrand { get; set; }
        public string c5_model_code { get; set; }
        public string c5_model_name { get; set; }
        public string c5_carFmyear { get; set; }
        public string c5_carToyear { get; set; }
        public string c5_carGeneration { get; set; }
        public string c5_cartype { get; set; }
        public string stmas_name { get; set; }
        public string action_type { get; set; }
        public string sub_category { get; set; }
        public string main_category { get; set; }
        public string product_division { get; set; }
        public string gdescript { get; set; }
        public string TYPE { get; set; }
        public string GUSED { get; set; }


    }

    public partial class Item_masterModel
    {
        //start 1 รายละเอียด //
        public string code { get; set; }
        public string gname { get; set; }
        public string codechr { get; set; }
        public string ctype { get; set; }
        public string id { get; set; }
        public string text { get; set; }
        public string keywords { get; set; }
        public string tables { get; set; }
         
    }

    public partial class Action_stmasModel
    {
        public string action_type { get; set; }
        public string temp_id { get; set; }
        public string coderef { get; set; }
        public string codeexp { get; set; }
        public string code { get; set; }
        public string name { get; set; }
        public string codeoem { get; set; }
        public string car_brand { get; set; }
        public string car_model { get; set; }
        public string g_model { get; set; }
        public string car_fm { get; set; }
        public string car_to { get; set; }
        public string car_generation { get; set; }
        public string car_engine { get; set; }
        public string car_body { get; set; }
        public string code_a { get; set; }
        public string code_b { get; set; }
        public string code_c { get; set; }
        public string code_d { get; set; }
        public string code_e { get; set; }
        public string code_a_name { get; set; }
        public string code_b_name { get; set; }
        public string code_c_name { get; set; }
        public string code_d_name { get; set; }
        public string code_e_name { get; set; }
        public string gremark { get; set; }
        public string created_by { get; set; }
        public string created_by2 { get; set; }
        public DateTime created_date { get; set; }
        public string updated_by { get; set; }
        public string updated_by2 { get; set; }
        public DateTime updated_date { get; set; }
        public int record_status { get; set; }
        public string Mode { get; set; }
        public string pMessage { get; set; }
        public string gdescript { get; set; }
        public string stmas_code_compare { get; set; }
        public string stmas_name_compare { get; set; }
        public string stmas_exp_name_compare { get; set; }
        public string code_a_compare { get; set; }
        public string code_b_compare { get; set; }
        public string code_c_compare { get; set; }
        public string code_d_compare { get; set; }
        public string code_e_compare { get; set; }

    }

    public partial class Chk_Stmas_ExpModel
    {
        public string keywords { get; set; }
        public string chk_dup { get; set; }
        public string code_dup { get; set; }
        public string name_dup { get; set; }
        public string code { get; set; }
        public string name { get; set; }
       
    }

    public partial class ImportDataModel
    {
        public string temp_id { get; set; }
        public int countitem_all { get; set; }
        public int countitem_incomplete { get; set; }
        public int countitem_complete { get; set; }
        public string created_by { get; set; }
        public string created_by2 { get; set; }
        public DateTime created_date { get; set; }
        public string updated_by { get; set; }
        public string updated_by2 { get; set; }
        public DateTime updated_date { get; set; }
        public int record_status { get; set; }
        public int countitem_updated { get; set; }
    }

}