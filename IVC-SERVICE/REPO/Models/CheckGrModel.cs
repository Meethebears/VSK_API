using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace REPO.Models
{

    public class CheckGrDataModel
    {
        public string pMessage { get; set; }
    }

    public class CheckGrParamCreateModel
    {
        public string number { get; set; }
        public string created_by { get; set; }
    }

    public class CheckGrParamGetModel
    {
        public string number { get; set; }
    }

    public class CheckGrParamVerifyModel
    {
        public string number { get; set; }
        public string barcode_vsk { get; set; }
        public string barcode_package { get; set; }
        public int qty { get; set; }
        public string created_by { get; set; }
    }

    public class CheckGrFileModel
    {
        public string trans_id { get; set; }
        public string ref_id { get; set; }
        public string number { get; set; }
        public DateTime invdate { get; set; }
        public string invpo { get; set; }
        public string invcode { get; set; }
        public string invname { get; set; }
        public string descript { get; set; }
        public int item { get; set; }
        public string userid { get; set; }
        public DateTime startdate { get; set; }
        public string event_status { get; set; }
        public int record_status { get; set; }
        public string created_by { get; set; }
        public DateTime created_datetime { get; set; }
        public string updated_by { get; set; }
        public DateTime updated_datetime { get; set; }
    }

    public class CheckGrTraModel
    {
        public string trans_id { get; set; }
        public string ref_id { get; set; }
        public string batchno { get; set; }
        public string pobatch { get; set; }
        public string stkcod { get; set; }
        public string gbarcode { get; set; }
        public string spcodes { get; set; }
        public string barcode_package { get; set; }
        public int qty { get; set; }
        public int trnqty { get; set; }
        public string event_status { get; set; }
        public int record_status { get; set; }
        public string created_by { get; set; }
        public DateTime created_datetime { get; set; }
        public string updated_by { get; set; }
        public DateTime updated_datetime { get; set; }
        public string number { get; set; }
        public string name { get; set; }
        public string uom { get; set; }
    }
}