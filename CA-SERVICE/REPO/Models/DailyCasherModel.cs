using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace REPO.Models
{
    public partial class DailyCasherModel
    {
        public int count_bill { get; set; }
        public int chk_job { get; set; }
        public string mode { get; set; }
        public string trans_id { get; set; }

        public string ref_id { get; set; }
        public DateTime job_date { get; set; }
        public DateTime job_date_start { get; set; }
        public DateTime job_date_end { get; set; }
        public string status { get; set; }
        public string branch { get; set; }
        public float cash_amount { get; set; }
        public float cash { get; set; }
        public float accrued { get; set; }
        public float edc { get; set; }
        public float accrued_receive { get; set; }
        public float transfer_payment { get; set; }
        public float cash_today { get; set; }
        public float coupons { get; set; }
        public string description { get; set; }
        public string csh_description { get; set; }
        public string csh_saveby { get; set; }
        public DateTime csh_dateby { get; set; }
        public string acc_description { get; set; }
        public string acc_saveby { get; set; }
        public DateTime acc_dateby { get; set; }
        public string confirm_status { get; set; }
        public string event_status { get; set; }
        public string text_status { get; set; }
        public string pay_status { get; set; }
        public string action_status { get; set; }

        public int record_status { get; set; }
        public string created_by { get; set; }
        public DateTime created_datetime { get; set; }
        public string updated_by { get; set; }
        public DateTime updated_datetime { get; set; }
        public string pMessage { get; set; }
        public string check_type { get; set; }

        public DateTime invdate_start { get; set; }
        public DateTime invdate_end { get; set; }

        public DateTime invdate { get; set; }
        public string number { get; set; }
        public string invnumber { get; set; }
        public string invpo { get; set; }
        public string invcode { get; set; }
        public string invname { get; set; }
        public float invsumtt { get; set; }
        public string invpay { get; set; }
        public string invuserid { get; set; }
        public string invbranch { get; set; }
        public string invremark { get; set; }
        public string invpkuser { get; set; }

        public float invpaych { get; set; }
        public float invpaytr { get; set; }
        public float invpaycr { get; set; }
        public float invpayoth { get; set; }
        public int invtoption { get; set; }
        public int invdue { get; set; }
        public string invtype { get; set; }

        public float sum_accrued { get; set; }
        public float sum_accrued_receive { get; set; }
        public float accrued_receive_total { get; set; }
        public int accrued_receive_total_bill { get; set; }
        public DateTime stamp_date { get; set; }
        public DateTime pay_date { get; set; }
        public string upload_by { get; set; }
        public DateTime upload_datetime { get; set; }

        public DateTime file_date { get; set; }
        public string file_type { get; set; }
        public string file_remark { get; set; }
        public string file_name { get; set; }
        public string file_folder { get; set; }
        public string file_path { get; set; }
        public string file_type_name { get; set; }
    }
    public partial class InvoiceModel
    {
        public string number { get; set; }
        public string branch { get; set; }
        public DateTime invdate { get; set; }
        public string invnumber { get; set; }
        public string invpo { get; set; }
        public string invcode { get; set; }
        public string invname { get; set; }
        public float invsumtt { get; set; }
        public string invpay { get; set; }
        public string invuserid { get; set; }
        public string invbranch { get; set; }
        public string invpkuser { get; set; }
        public string invrdeleted { get; set; }
        public string invdescript { get; set; }

        public float invpaych { get; set; }
        public float invpaytr { get; set; }
        public float invpaycr { get; set; }
        public float invpayoth { get; set; }
        public int invtoption { get; set; }
        public int invdue { get; set; }
        public string invtype { get; set; }

        public string pMessage { get; set; }
    }

}