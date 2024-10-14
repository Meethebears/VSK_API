using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace REPO.Models
{
    public partial class DashboardWHOrdertypeModel
    {
        public DateTime invdate { get; set; }
        public string WH { get; set; }
        public string Ordertype_Code { get; set; }
        public string Ordertype_Name { get; set; }
        public int INTIME_SKU_1_3 { get; set; }
        public int LATETIME_SKU_1_3 { get; set; }
        public int INTIME_SKU_4_6 { get; set; }
        public int LATETIME_SKU_4_6 { get; set; }
        public int INTIME_SKU_7 { get; set; }
        public int LATETIME_SKU_7 { get; set; }
        public DateTime lastupdate { get; set; }
    }
    public partial class DashboardIVOrderypeModel
    {
        public DateTime invdate { get; set; }
        public string condition { get; set; }
        public int SFR { get; set; }
        public int SFR_INTIME { get; set; }
        public int SFR_LATE { get; set; }
        public int DUR { get; set; }
        public int DUR_INTIME { get; set; }
        public int DUR_LATE { get; set; }
        public int DSD { get; set; }
        public int DSD_INTIME { get; set; }
        public int DSD_LATE { get; set; }
        public int DND { get; set; }
        public int DND_INTIME { get; set; }
        public int DND_LATE { get; set; }
        public int CUS { get; set; }
        public int CUS_INTIME { get; set; }
        public int CUS_LATE { get; set; }
        public int DSR { get; set; }
        public int DSR_INTIME { get; set; }
        public int DSR_LATE { get; set; }
        public int ECM { get; set; }
        public int ECM_INTIME { get; set; }
        public int ECM_LATE { get; set; }
        public int EXP { get; set; }
        public int EXP_INTIME { get; set; }
        public int EXP_LATE { get; set; }
        public int OTH { get; set; }
        public int OTH_INTIME { get; set; }
        public int OTH_LATE { get; set; }
        public DateTime lastupdate { get; set; }
    }

    public partial class DashboardWHDetailModel
    {
        public DateTime invdate { get; set; }
        public string invtrans { get; set; }
        public string invcode { get; set; }
        public string invname { get; set; }
        public string stkzone { get; set; }
        public string stkcod { get; set; }
        public string gbarcode { get; set; }
        public string stkname { get; set; }
        public string number { get; set; }
        public int delivery_stdtime { get; set; }
        public DateTime startdate { get; set; }
        public DateTime lastupdate { get; set; }
    }

    public partial class DashboardPKNotIVDetailModel
    {
        public DateTime invdate { get; set; }
        public string invcode { get; set; }
        public string invname { get; set; }
        public string number { get; set; }
        public string userid { get; set; }
        public string invtrans { get; set; }
        public int delivery_stdtime { get; set; }
        public int delivery_ontime { get; set; }
        public DateTime chktime { get; set; }
        public DateTime startdate { get; set; }
    }

    public partial class DashboardPKWITHTRPDetailModel
    {
        public DateTime invdate { get; set; }
        public string invcode { get; set; }
        public string invname { get; set; }
        public string number { get; set; }
        public string taxnumb { get; set; }
        public string invtrans { get; set; }
        public string job_no { get; set; }
        public string statusId { get; set; }
        public string status { get; set; }
        public double cod { get; set; }
        public DateTime trp_created_date { get; set; }
        public DateTime startdate { get; set; }
    }

    public partial class DashboardIVWITHTRPDetailModel
    {
        public DateTime invdate { get; set; }
        public string invcode { get; set; }
        public string invname { get; set; }
        public string number { get; set; }
        public string invpo { get; set; }
        public string invtrans { get; set; }
        public string job_no { get; set; }
        public string statusId { get; set; }
        public string status { get; set; }
        public double cod { get; set; }
        public string invuser { get; set; }
        public string pkuser { get; set; }
        public int delivery_stdtime { get; set; }
        public int delivery_ontime { get; set; }
        public DateTime trp_created_date { get; set; }
        public DateTime startdate { get; set; }
    }

    public partial class DashboardIVNotTRPDetailPeriodModel
    {
        public DateTime invdate { get; set; }
        public string invcode { get; set; }
        public string invname { get; set; }
        public string invpo { get; set; }
        public DateTime pkdate { get; set; }
        public string number { get; set; }
        public string invtrans { get; set; }
        public string invuser { get; set; }
        public string pkuser { get; set; }
        public int delivery_stdtime { get; set; }
        public int delivery_ontime { get; set; }
        public DateTime startdate { get; set; }
    }

}