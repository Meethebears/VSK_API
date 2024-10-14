using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace REPO.Models
{

    public partial class CarMasterPmtModel
    {
        public string mode { get; set; }
        public string keywords { get; set; }
        public string keywords_1 { get; set; }
        public string keywords_2 { get; set; }
        public string keywords_3 { get; set; }
        public string keywords_4 { get; set; }
        public string keywords_5 { get; set; }
        public string keywords_6 { get; set; }
        public string lov_group { get; set; }
        public string lov_type { get; set; }
        public string active_flag { get; set; }

    }

    public partial class CarMasterModel
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

    public partial class LovDataModel
    {

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
        public string lov11 { get; set; }
        public string lov12 { get; set; }
        public string lov13 { get; set; }
        public string lov14 { get; set; }
        public string lov_desc { get; set; }
        public int lov_order { get; set; }
        public string active_flag { get; set; }
        public string created_by { get; set; }
        public DateTime created_date { get; set; }
        public string updated_by { get; set; }
        public DateTime updated_date { get; set; }

    }

}