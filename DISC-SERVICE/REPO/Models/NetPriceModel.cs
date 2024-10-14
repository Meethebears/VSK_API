using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace REPO.Models
{
    public partial class NetPrice_Model
    {
        public string mode { get; set; }
        public string trans_id { get; set; }
        public string discount_type { get; set; }
        public string netprice_code { get; set; }
        public string netprice_name { get; set; }
        public string emmas_code { get; set; }
        public string emmas_name { get; set; }
        public string emmas_name_veriry { get; set; }
        public string code { get; set; }
        public string lname { get; set; }
        public string typevat { get; set; }
        public string TYPE { get; set; }
        public string remark { get; set; }
        public DateTime procdate { get; set; }
        public string procby { get; set; }
        public string userid { get; set; }
        public string created_by { get; set; }
        public DateTime created_date { get; set; }
        public string updated_by { get; set; }
        public DateTime updated_date { get; set; }
        public DateTime upload_datetime { get; set; }
        public string event_name { get; set; }
        public string event_status { get; set; }
        public string text_status { get; set; }
        public int record_status { get; set; }
        public int count_trans { get; set; }
        public string ref_id { get; set; }
        public string tx_status_code { get; set; }
        public string tx_status_name { get; set; }
        public string tx_status_code_netprice { get; set; }
        public string tx_status_code_emmas { get; set; }
        public string tx_status_error_1 { get; set; }
    }
    public partial class NetPrice_Prnetfile_Model
    {
        public string mode { get; set; }
        public string ref_id { get; set; }
        public string emmas_code { get; set; }
        public string emmas_name { get; set; }
        public string emmas_name_veriry { get; set; }
        public string netprice_code { get; set; }
        public string netprice_name { get; set; }
        public string code { get; set; }
        public string lname { get; set; }
        public string remark { get; set; }
        public string procby { get; set; }
        public DateTime procdate { get; set; }
        public string userid { get; set; }
        public string named { get; set; }
        public string TYPE { get; set; }
        public string carbrand { get; set; }
        public string chrcode { get; set; }
        public string gmodel { get; set; }
        public string typeb { get; set; }
        public string pMessage { get; set; }
        public int count_trans { get; set; }
        public string created_by { get; set; }
        public DateTime created_date { get; set; }
  
    }
    public partial class prnetfileModel
    {
        public string mode { get; set; }
        public string trans_id { get; set; }
        public string prnetfile_code { get; set; }
        public string prnetfile_lname { get; set; }
        public string prnetfile_remark { get; set; }
        public DateTime prnetfile_procdate { get; set; }
        public string prnetfile_procby { get; set; }
        public string prnetfile_userid { get; set; }
        public string prnetfile_named { get; set; }
        public string prnetfile_TYPE { get; set; }
        public string prnetfile_carbrand { get; set; }
        public string prnetfile_chrcode { get; set; }
        public string prnetfile_gmodel { get; set; }
        public string prnetfile_typeb { get; set; }
        public DateTime upload_datetime { get; set; }
        public string event_name { get; set; }
        public string event_status { get; set; }

        //action strat//
        public string code { get; set; }
        public string lname { get; set; }
        public string remark { get; set; }
        public DateTime procdate { get; set; }
        public string procby { get; set; }
        public string userid { get; set; }
        public string named { get; set; }
        public string TYPE { get; set; }
        public string carbrand { get; set; }
        public string chrcode { get; set; }
        public string gmodel { get; set; }
        public string typeb { get; set; }
        public string created_by { get; set; }
        public DateTime created_date { get; set; }
        public string updated_by { get; set; }
        public DateTime updated_date { get; set; }
        public string record_status { get; set; }
        public string ref_id { get; set; }
        //action end//

    }

    public partial class prnettraModel
    {
        public string mode { get; set; }
        public string trans_id { get; set; }
        public string gcode { get; set; }
        public string chk_gcode { get; set; }
        public string gname { get; set; }
        public string chk_gname { get; set; }
        public string gbarcode { get; set; }
        public string gpartno { get; set; }
        public double Qty_A { get; set; }
        public double Qty_B { get; set; }
        public double NetPrice { get; set; }
        public string gunit { get; set; }
        public string chk_gunit { get; set; }
        public double gcost { get; set; }
        public string userid { get; set; }
        public DateTime startdate { get; set; }
        public string prtype { get; set; }
        public double avgcost { get; set; }
        public double gprice { get; set; }
        public double gpriceA { get; set; }
        public double gpriceB { get; set; }
        public double gpriceC { get; set; }
        public double gpriceD { get; set; }
        public double gpriceE { get; set; }
        public double gpriceF { get; set; }
        public string TYPE { get; set; }
        public string carbrand { get; set; }
        public string named { get; set; }
        public string ecode { get; set; }
        public string recdup { get; set; }
        public double avgsalecost { get; set; }
        public double stmas_AvgSalecost { get; set; }
        public string created_by { get; set; }
        public DateTime created_date { get; set; }
        public string updated_by { get; set; }
        public DateTime updated_date { get; set; }
        public string record_status { get; set; }
        public string text_status { get; set; }
        public DateTime upload_datetime { get; set; }
        public string event_name { get; set; }
        public string event_status { get; set; }
        public string chk_duplicate { get; set; }
        public string session_id { get; set; }
        public string ref_id { get; set; }
        public int count_trans { get; set; }

    }
    public partial class prnetcheckModel
    {
        public string check_status { get; set; }
        public string ecode { get; set; }
        public string gcode { get; set; }
        public string gunit { get; set; }

    }
}