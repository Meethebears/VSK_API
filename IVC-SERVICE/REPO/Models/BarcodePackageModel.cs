using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace REPO.Models
{
    public class BarcodePackageFileModel
    {
        public string trans_id { get; set; }
        public string ref_id { get; set; }
        public int item_no { get; set; }
        public DateTime job_date { get; set; }
        public int data_all { get; set; }
        public int data_error { get; set; }
        public int data_success { get; set; }
        public string event_status { get; set; }
        public int record_status { get; set; }
        public string created_by { get; set; }
        public DateTime created_datetime { get; set; }
        public string updated_by { get; set; }
        public DateTime updated_datetime { get; set; }
    }

    public class BarcodePackageDataModel
    {
        public string trans_id { get; set; }
        public string ref_id { get; set; }
        public string package_code { get; set; }
        public int item_no { get; set; }
        public string barcode_vsk { get; set; }
        public string barcode_package { get; set; }
        public string item_note { get; set; }
        public string action_type { get; set; }
        public string text_status { get; set; }
        public string event_status { get; set; }
        public int record_status { get; set; }
        public string created_by{ get; set; }
        public DateTime created_datetime{ get; set; }
        public string updated_by { get; set; }
        public DateTime updated_datetime { get; set; }
    }

    public class BarcodePackageVerifyModel
    {
        public string trans_id { get; set; }
        public string ref_id { get; set; }
        public string package_code { get; set; }
        public int item_no { get; set; }
        public string barcode_vsk { get; set; }
        public string barcode_package { get; set; }
        public string item_note { get; set; }

        public string item_code { get; set; }
        public string item_name { get; set; }
        public string item_spcodes { get; set; }
        public string item_glocat { get; set; }

        public string action_type { get; set; }
        public string text_status { get; set; }
        public string event_status { get; set; }
        public int record_status { get; set; }
        public string created_by { get; set; }
        public DateTime created_datetime { get; set; }
        public string updated_by { get; set; }
        public DateTime updated_datetime { get; set; }
    }

    public class BarcodePackageParamModel
    {
        public string ref_id { get; set; }

    }

    public class BarcodePackageSearchModel
    {
        public string keywords { get; set; }
        public int barcode_vsk { get; set; }
        public int barcode_package { get; set; }
        public int package_code { get; set; }
        public int item_code { get; set; }
        public int item_name { get; set; }
        public int item_spcodes { get; set; }
    }

    public class BarcodePackageListModel
    {
        public string trans_id { get; set; }
        public string ref_id { get; set; }
        public string package_code { get; set; }
        public string barcode_vsk { get; set; }
        public string barcode_package { get; set; }

        public string item_code { get; set; }
        public string item_name { get; set; }
        public string item_spcodes { get; set; }
        public string item_note { get; set; }
        
        public string action_type { get; set; }
        public string text_status { get; set; }
        public string event_status { get; set; }
        public int record_status { get; set; }
        public string created_by { get; set; }
        public DateTime created_datetime { get; set; }
        public string updated_by { get; set; }
        public DateTime updated_datetime { get; set; }
        public string deleted_by { get; set; }
        public DateTime deleted_datetime { get; set; }

    }
}