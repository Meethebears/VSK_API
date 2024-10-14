using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace REPO.Models
{
    public partial class pre_groupModel
    {
        public string mode { get; set; }
        public string trans_id { get; set; }
        public string discount_type { get; set; }
        public string code { get; set; }
        public string lname { get; set; }
        public string typevat { get; set; }
        public string remark { get; set; }
        public DateTime procdate { get; set; }
        public string procby { get; set; }
        public string userid { get; set; }
        public string created_by { get; set; }
        public DateTime created_date { get; set; }
        public DateTime upload_datetime { get; set; }
        public string event_name { get; set; }
        public string event_status { get; set; }
    }

    public partial class pre_emmaspModel
    {
        public string mode { get; set; }
        public string trans_id { get; set; }
        public string discount_type { get; set; }
        public string emmas_code { get; set; }
        public string emmas_lname { get; set; }
        public string emmas_address { get; set; }
        public string emmas_tumbol { get; set; }
        public string emmas_eamphur { get; set; }
        public string emmas_eprovinc { get; set; }
        public string emmas_zip { get; set; }
        public string emmas_netprice { get; set; }
        public string emmas_egdis { get; set; }
        public string dis_pre_group_code { get; set; }
        public string created_by { get; set; }
        public DateTime created_date { get; set; }
        public DateTime upload_datetime { get; set; }
        public string event_name { get; set; }
        public string event_status { get; set; }
    }

    public partial class count_item_Model
    {
        public int count { get; set; }
        public int item { get; set; }
        public string gcode { get; set; }

    }

    public partial class gdisheadModel
    {
        public string mode { get; set; }
        public string trans_id { get; set; }
        public string code { get; set; }
        public string lname { get; set; }
        public string remark { get; set; }
        public DateTime procdate { get; set; }
        public string procby { get; set; }
        public string userid { get; set; }
        public string created_by { get; set; }
        public DateTime created_date { get; set; }
        public string updated_by { get; set; }
        public DateTime updated_date { get; set; }
        public string record_status { get; set; }
        public string event_name { get; set; }
        public string event_status { get; set; }
        public string ref_id { get; set; }
    }

    public partial class ediscountModel
    {
        public string mode { get; set; }
        public string trans_id { get; set; }
        public string ref_id { get; set; }
        public string code { get; set; }
        public string cargroup { get; set; }
        public string chrcode { get; set; }
        public double dvat { get; set; }
        public string ecode { get; set; }
        public string userid { get; set; }
        public DateTime startdate { get; set; }
        public string dcost { get; set; }
        public string dcostby { get; set; }
        public string text_status { get; set; }
        public string updated_by { get; set; }
        public DateTime dcostTime { get; set; }


        public double adis1 { get; set; }
        public double adis2 { get; set; }
        public double adis3 { get; set; }

        public double bdis1 { get; set; }
        public double bdis2 { get; set; }
        public double bdis3 { get; set; }

        public double cdis1 { get; set; }
        public double cdis2 { get; set; }
        public double cdis3 { get; set; }

        public double ddis1 { get; set; }
        public double ddis2 { get; set; }
        public double ddis3 { get; set; }

        public double edis1 { get; set; }
        public double edis2 { get; set; }
        public double edis3 { get; set; }

        public double fdis1 { get; set; }
        public double fdis2 { get; set; }
        public double fdis3 { get; set; }

        public double gdis1 { get; set; }
        public double gdis2 { get; set; }
        public double gdis3 { get; set; }

        public double hdis1 { get; set; }
        public double hdis2 { get; set; }
        public double hdis3 { get; set; }

        public double idis1 { get; set; }
        public double idis2 { get; set; }
        public double idis3 { get; set; }

        public double jdis1 { get; set; }
        public double jdis2 { get; set; }
        public double jdis3 { get; set; }

        public double kdis1 { get; set; }
        public double kdis2 { get; set; }
        public double kdis3 { get; set; }

        public double Ldis1 { get; set; }
        public double Ldis2 { get; set; }
        public double Ldis3 { get; set; }

        public string created_by { get; set; }
        public DateTime created_date { get; set; }
        public DateTime upload_datetime { get; set; }
        public string record_status { get; set; }
        public string event_name { get; set; }
        public string event_status { get; set; }
        public string chk_duplicate { get; set; }
        public int count_trans { get; set; }

    }


}