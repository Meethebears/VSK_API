using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace REPO.Models
{
    public partial class SlipModel
    {
        public string trans_id { get; set; }
        public string slip_jobno { get; set; }
        public string slip_refno { get; set; }
        public string slip_datetime { get; set; }
        public string slip_total { get; set; }
        public string slip_bank { get; set; }
        public string slip_cuscode { get; set; }
        public string slip_cusname { get; set; }
        public string branch { get; set; }
        public DateTime slip_jobdate { get; set; }
        public int record_status { get; set; }
        public string created_by { get; set; }
        public DateTime created_datetime { get; set; }
        public string updated_by { get; set; }
        public DateTime updated_datetime { get; set; }
        public string pMessage { get; set; }
    }
     
    public partial class SlipBillModel
    {
        public string trans_id { get; set; }
        public string ref_id { get; set; }
        public string bill_no { get; set; }
        public string bill_invname { get; set; }
        public float bill_invtotal { get; set; }
        public string bill_invpay { get; set; }
        public DateTime bill_invdate { get; set; }
        public string bill_userid { get; set; }
        public string bill_invcode { get; set; }
        public string bill_branch { get; set; }
        public string branch { get; set; }
        public string slip_cuscode { get; set; }
        public string invnumber { get; set; }
        public string invcode { get; set; }
        public string invname { get; set; }
        public DateTime invdate { get; set; }
        public float invsumtt { get; set; }
        public string invpay { get; set; }
        public string invuserid { get; set; }
        public string invpkuser { get; set; } //20231101
        public int record_status { get; set; }
        public string created_by { get; set; }
        public DateTime created_datetime { get; set; }
        public string updated_by { get; set; }
        public DateTime updated_datetime { get; set; }
        public string pMessage { get; set; }

        public string invpo { get; set; }
        public string invbranch { get; set; }
        public string invrdeleted { get; set; }
        public string invdescript { get; set; }

        public float invpaych { get; set; }
        public float invpaytr { get; set; }
        public float invpaycr { get; set; }
        public float invpayoth { get; set; }
        public int invtoption { get; set; }
        public int invdue { get; set; }
        public string invtype { get; set; }
        public string billinvpkuser { get; set; }

    }

    public partial class SlipImageModel
    {
        public string trans_id { get; set; }
        public string ref_id { get; set; }
        public string job_no { get; set; }
        public string image_name { get; set; }
        public string record_status { get; set; }
        public string created_by { get; set; }
        public DateTime created_date { get; set; }
        public string updated_by { get; set; }
        public DateTime updated_date { get; set; }
    }

    public partial class SlipAllModel
    {
        public string ref_id { get; set; }
        public string job_no { get; set; }
        public string trans_id { get; set; }
        public float sum_bill { get; set; }
        public string slip_jobno { get; set; }
        public string slip_refno { get; set; }
        public string slip_datetime { get; set; }
        public string slip_total { get; set; }
        public string slip_bank { get; set; }
        public string slip_cuscode { get; set; }
        public string slip_cusname { get; set; }
        public DateTime slip_jobdate { get; set; }
        public int record_status { get; set; }
        public string created_by { get; set; }
        public DateTime created_datetime { get; set; }
        public DateTime created_date { get; set; }
        public string updated_by { get; set; }
        public DateTime updated_datetime { get; set; }
        public string pMessage { get; set; }
        public string image_no { get; set; }
        public string image_name { get; set; }
        public string slip_bill { get; set; }
        public string count_bill { get; set; }
        public string slip_cuslname { get; set; }
        public string branch { get; set; }
        public DateTime slip_datetime_start { get; set; }
        public DateTime slip_datetime_end { get; set; }
        public DateTime slip_jobdate_start { get; set; }
        public DateTime slip_jobdate_end { get; set; }
        public DateTime trndate_start { get; set; }
        public DateTime trndate_end { get; set; }

    }

    public partial class Master_Model
    {
        public string mode { get; set; }
        public string keywords { get; set; }
        public string keywords1 { get; set; }
        public string keywords2 { get; set; }
        public string keywords3 { get; set; }
        public string id { get; set; }
        public string text { get; set; }
        public string code { get; set; }
        public string name { get; set; }

    }

}