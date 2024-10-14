using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace REPO.Models
{
    public partial class MRPItemImportModel
    {
        public string trans_id { get; set; }
        public string Destination_Site { get; set; }
        public string Item_Code { get; set; }
        public string Remark { get; set; }
        public string MIN { get; set; }
        public string MAX { get; set; }
        public string Replenish_Status { get; set; }
        public string Action { get; set; }
        public string created_by { get; set; }
        public string created_date { get; set; }
        public string ImportFilename { get; set; }
        public string ImportPathname { get; set; }
        public string validate_code { get; set; }

    }

    public partial class ItemSetupModel
    {
        public string BRANCH { get; set; }

        public string Item_Code { get; set; }
        public string Item_Name { get; set; }
        public string UOM { get; set; }
        public int Transfer_Qty_Required { get; set; }
        public float GCOST { get; set; }
        public string ZONE { get; set; }
        public string CODE_1 { get; set; }
        public string CODE_2 { get; set; }
        public string CODE_3 { get; set; }
        public string CODE_4 { get; set; }
        public string Barcode { get; set; }
        public string Spcodes { get; set; }
        public string Source_Site { get; set; }
        public string Destination_Site { get; set; }
        public string Source_Site_Stock_Status { get; set; }
        public string Replenish_Status { get; set; }
        public int MIN { get; set; }
        public int MAX { get; set; }
        public float VSM_SOM { get; set; }
        public float SOH_Destination { get; set; }
        public int Pending_PO { get; set; }
        public int Transit_QTY { get; set; }
        public int Pack_Code_Rounding { get; set; }
        public string Backlog_Ctrl { get; set; }
        public string Formula { get; set; }
        public string Good_Seller_Flag { get; set; }
        public string Remark { get; set; }
        public DateTime lastupdated { get; set; }

     
        public string Action { get; set; }
        public string created_by { get; set; }
        public string ImportFilename { get; set; }
        public string ImportPathname { get; set; }


    }

}