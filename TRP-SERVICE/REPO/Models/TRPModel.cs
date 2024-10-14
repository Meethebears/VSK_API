﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace REPO.Models
{
    public partial class TMS_JOBModel
    {
        public DateTime tms_job_date { get; set; }
        public string tms_job_route { get; set; }
        public string tms_job_plate { get; set; }
        public string tms_job_name { get; set; }
        public string tms_job_no { get; set; }
        public string tms_job_cus_name { get; set; }
        public DateTime tms_job_created_date { get; set; }
        public DateTime tms_job_delivery_date { get; set; }

    }

    public partial class TMS_JOB_IMPORTModel
    {
        public double cod { get; set; }
        public DateTime createDate { get; set; }
        public DateTime currentStatusDate { get; set; }
        public string description { get; set; }
        public double dimension { get; set; }
        public string distributionCenter { get; set; }
        public string driver { get; set; }
        public double endMile { get; set; }
        public DateTime expDeliveryDate { get; set; }
        public string manifestCode { get; set; }
        public string manifestType { get; set; }
        public string merchantName { get; set; }
        public string phoneNumber { get; set; }
        public string projectName { get; set; }
        public double qty { get; set; }
        public string recipientAddress { get; set; }
        public string recipientName { get; set; }
        public string recipientPostalCode { get; set; }
        public string recipientProvince { get; set; }
        public string routeLineName { get; set; }
        public DateTime shippingDate { get; set; }
        public string shippingNoteNumber { get; set; }
        public double startMile { get; set; }
        public string status { get; set; }
        public double statusId { get; set; }
        public double totalDeliveryAttempts { get; set; }
        public double totalDistance { get; set; }
        public double totalMile { get; set; }
        public string vehicle { get; set; }
        public string vehicleAddOn { get; set; }
        public double weight { get; set; }

    }

    public partial class TMS_JOB_EXPORTModel
    {
        public double chk_drop { get; set; }
        public string deliveryProjectCode { get; set; }
        public string underDistributionCenterCode { get; set; }
        public string vehicleLicensePlate { get; set; }
        public double vehicleFuelUseRate { get; set; }
        public double vehiclePercentReFuel { get; set; }
        public string addOnVehicleLicensePlate { get; set; }
        public string driverCode { get; set; }
        public string driverName { get; set; }
        public DateTime manifestNoteCreateDate { get; set; }
        public double manifestNoteStartType { get; set; }
        public string startDistributionCenterCode { get; set; }
        public string endRouteLineCode { get; set; }
        public DateTime receiveProductDate { get; set; }
        public string shippingNoteList { get; set; }
        public string shippingNoteCode { get; set; }
        public string shippingNoteDescription { get; set; }
        public DateTime deliveryDate { get; set; }
        public string packageNumber { get; set; }
        public double productAmount { get; set; }
        public double codPrice { get; set; }
        public double weight { get; set; }
        public double volume { get; set; }
        public string senderName { get; set; }
        public string receiverName { get; set; }
        public string actualReceiverName { get; set; }
        public double receiverContact { get; set; }
        public string receiverAddress { get; set; }
        public double lat { get; set; }
        public double lng { get; set; }
        public string productCode { get; set; }
        public string startConsumerDistributionCenterCode { get; set; }

    }

    public partial class TMS_JOB_ITEMModel
    {
        public string pMessage { get; set; }

        public string tran_id { get; set; }
        public string job_number { get; set; }
        public string ref_id { get; set; }
        public DateTime job_date { get; set; }
        public string job_start_date { get; set; }
        public string job_end_date { get; set; }
        public string job_no { get; set; }
        public string job_invoice_no { get; set; }
        public DateTime job_invoice_date { get; set; }
        public string job_pk_no { get; set; }
        public int job_qty { get; set; }
        public float invnet { get; set; }
        public string invcode { get; set; }
        public string job_delivery_name { get; set; }
        public string job_delivery_addr { get; set; }
        public string route_no { get; set; }
        public string route_name { get; set; }
        public string driver_id { get; set; }
        public string driver_fullname { get; set; }
        public string HHID { get; set; }
        public string job_plate { get; set; }
        public string plate_name { get; set; }
        public DateTime tms_job_created_date { get; set; }
        public DateTime tms_job_delivery_startdate { get; set; }
        public DateTime tms_job_delivery_date { get; set; }
        public DateTime created_date { get; set; }
        public DateTime route_no_prev { get; set; }
        public DateTime review_date { get; set; }
        public string created_by { get; set; }
        public double truck_count { get; set; }
        public double bill_count { get; set; }
        public string mode { get; set; }
        public double startMile { get; set; }
        public double endMile { get; set; }
        public double totalMile { get; set; }
        public string status { get; set; }
        public int statusId { get; set; }
        public DateTime upload_datetime { get; set; }
        public float cod_price { get; set; }
        public string delivery_type { get; set; }
        public string delivery_status { get; set; }
        public string payment_type { get; set; }
        public string job_status { get; set; }
        public string job_type { get; set; }
        public string location_branch { get; set; }

        public int chk_job { get; set; }
        public int batch_no { get; set; }
        public DateTime created_timestamp { get; set; }

        public string updated_by { get; set; }
        public DateTime updated_datetime { get; set; }
        public string description { get; set; }
        public string bill_list { get; set; }
        public string e_delivery_address { get; set; }
        public string inv_description { get; set; }
        public int record_status { get; set; }
        public string job_description { get; set; }
        public string job_emmas_addres { get; set; }
        public string derivery_status { get; set; }
        //public double codPrice { get; set; }

        public int job_total { get; set; }
        public float ptice_total { get; set; }
        public int h_darivery_success { get; set; }
        public int h_darivery_pending { get; set; }
        public int h_darivery_failed { get; set; }

        public string shippingNoteNumber { get; set; }
        public string recipientName { get; set; }
        public string recipientAddress { get; set; }
        public string recipientProvince { get; set; }
        public string recipientPostalCode { get; set; }
        public string phoneNumber { get; set; }
        public string qty { get; set; }
        public string weight { get; set; }
        public string dimension { get; set; }
        public string projectName { get; set; }
        public string manifestType { get; set; }
        public string shippingDate { get; set; }
        public string routeLineName { get; set; }
        public string manifestCode { get; set; }
        public string vehicle { get; set; }
        public string driver { get; set; }
        public string vehicleAddOn { get; set; }
        public string distributionCenter { get; set; }
        public string merchantName { get; set; }
        public string cod { get; set; }
        public string createDate { get; set; }
        public DateTime expDeliveryDate { get; set; }
        public string totalDeliveryAttempts { get; set; }
        public DateTime currentStatusDate { get; set; }
        public string latitudeFinishJob { get; set; }
        public string longitudeFinishJob { get; set; }

        public DateTime last_update { get; set; }
        public DateTime driver_time_start { get; set; }
        public DateTime salefile_startdate { get; set; }
        public string salefile_number { get; set; }
        public string salefile_invpo { get; set; }
        public string salefile_invcode { get; set; }
        public string salefile_name { get; set; }
        public int salefile_item { get; set; }

    }

    public partial class SalefileModel
    {
        public string number { get; set; }
        public DateTime invdate { get; set; }
        public string invcode { get; set; }
        public string invbook { get; set; }
        public int invno { get; set; }
        public string invname { get; set; }
        public int invdue { get; set; }
        public DateTime duedate { get; set; }
        public double invnet { get; set; }
        public double invearnamo { get; set; }
        public double invvat { get; set; }
        public double invsumtt { get; set; }
        public double invgcost { get; set; }
        public double invprofit { get; set; }
        public string invscode { get; set; }
        public double invdisp1 { get; set; }
        public double invdisp2 { get; set; }
        public double invdisp3 { get; set; }
        public double discount { get; set; }
        public string trntype { get; set; }
        public int invbill { get; set; }
        public string invpo { get; set; }
        public double invother { get; set; }
        public string descript { get; set; }
        public DateTime startdate { get; set; }
        public string userid { get; set; }
        public bool biclosed { get; set; }
        public double resum { get; set; }
        public double rt_count { get; set; }
        public double rt_sumtt { get; set; }
        public double ex_sumtt { get; set; }
        public double bo_sumtt { get; set; }
        public string option_ { get; set; }
        public string invtrans { get; set; }
        public int item { get; set; }
        public string invref { get; set; }
        public int trans { get; set; }
        public string REMARK { get; set; }
        public string biline { get; set; }
        public bool rdeleted { get; set; }
        public string usrdel { get; set; }
        public DateTime deltime { get; set; }
        public string order_id { get; set; }
        public string invflag { get; set; }
        public string acccode { get; set; }
        public string egroup { get; set; }
        public string travouc { get; set; }
        public string batchno { get; set; }
        public int payref { get; set; }
        public bool isclosed { get; set; }
        public string recvouc { get; set; }
        public string pbranch { get; set; }
        public double RECM { get; set; }
        public double CHANGM { get; set; }
        public string TAXINVW { get; set; }
        public double INVCREDIT { get; set; }
        public double taxamo { get; set; }
        public DateTime taxstamp { get; set; }
        public string PAYBANK { get; set; }
        public int PAYMENT { get; set; }
        public string comno { get; set; }
        public int ckcash { get; set; }
        public double paycash { get; set; }
        public int cktran { get; set; }
        public double paytran { get; set; }
        public int ckcard { get; set; }
        public double paycard { get; set; }
        public int ckoth { get; set; }
        public double perc { get; set; }
        public double charge { get; set; }
        public double payoth { get; set; }
        public DateTime grecdate { get; set; }
        public string grecnum { get; set; }
        public string emlocation { get; set; }
        public DateTime earnestrec { get; set; }
        public string invearnest { get; set; }
        public double resumear { get; set; }
        public string saleinv { get; set; }
        public int usercf { get; set; }
        public string ipaddress { get; set; }
        public string pcname { get; set; }
        public double cardamo { get; set; }
        public string cashierno { get; set; }
        public string taxinvoice { get; set; }
        public string poref { get; set; }
        public double deposit { get; set; }
        public double unpaid { get; set; }
        public double rsinvnet { get; set; }
        public double rsinvvat { get; set; }
        public double rsinvsum { get; set; }
        public double rsbalance { get; set; }
        public DateTime currdate { get; set; }
        public double toppvat { get; set; }
        public string retno { get; set; }
        public double retamo { get; set; }
        public string invcustpo { get; set; }
        public string carregis { get; set; }
        public string pkuser { get; set; }
        public string remarkb { get; set; }
        public string clame { get; set; }
        public string edno { get; set; }
        public string tsno { get; set; }
        public string model { get; set; }
        public string evcode { get; set; }
        public string evname { get; set; }
        public string evadd { get; set; }
        public string evtel { get; set; }
        public string invkline { get; set; }
        public int jobnumb { get; set; }
        public int jobitem { get; set; }
        public string etruck { get; set; }
        public string edriver { get; set; }
        public DateTime cartimeout { get; set; }
        public int jobapproved { get; set; }
        public int rechk_exps { get; set; }
        public int toption { get; set; }
        public int jobConfirm { get; set; }
        public string bodyNo { get; set; }
        public string flagrec { get; set; }
        public string exp_by { get; set; }
        public DateTime exp_datetime { get; set; }
        public DateTime start_invdate { get; set; }
        public DateTime end_invdate { get; set; }
        public string eaddress_full { get; set; }
        public string e_delivery_address { get; set; }
        public string delivery_address { get; set; }
        public string emmas_addres { get; set; }
    }

    public partial class APmasModel
    {
        public string code { get; set; }
        public string lname { get; set; }
        public string paddress { get; set; }
        public string ptumbol { get; set; }
        public string pamphur { get; set; }
        public string pprovinc { get; set; }
        public string pzip { get; set; }
        public string pfax { get; set; }
        public string ptel { get; set; }
        public string pamount { get; set; }
        public string premark { get; set; }
        public string pdescript { get; set; }

    }

    public partial class BRModel
    {

        public string invbook { get; set; }
        public string invno { get; set; }
        public string number { get; set; }
        public string invcode { get; set; }
        public string invname { get; set; }
        public DateTime invdate { get; set; }
        public DateTime taxdate { get; set; }
        public float invnet { get; set; }
        public float invvat { get; set; }
        public float invsumtt { get; set; }
        public float invdisp1 { get; set; }
        public float discount { get; set; }
        public string trntype { get; set; }
        public string trnbill { get; set; }
        public string biclosed { get; set; }
        public string invpo { get; set; }
        public string poref { get; set; }
        public string invother { get; set; }
        public string descript { get; set; }
        public string userid { get; set; }
        public string resum { get; set; }
        public string invscode { get; set; }
        public string isclosed { get; set; }
        public string tax { get; set; }
        public int item { get; set; }
        public DateTime startdate { get; set; }
        public string payref { get; set; }
        public int rdeleted { get; set; }
        public string usrdel { get; set; }
        public DateTime deltime { get; set; }
        public string acccode { get; set; }
        public string chkprice { get; set; }
        public string travouc { get; set; }
        public string chkpo { get; set; }
        public string payvouc { get; set; }
        public string invdue { get; set; }
        public DateTime duedate { get; set; }
        public string netcost { get; set; }
        public string pbranch { get; set; }
        public string punumber { get; set; }
        public string ipaddress { get; set; }
        public string pcname { get; set; }
        public string transref { get; set; }
        public string upprice { get; set; }
        public string qtypercent { get; set; }
        public string savestock { get; set; }
        public string brnumber { get; set; }


    }

    public partial class REQModel
    {

        public string REF_ID { get; set; }
        public DateTime JOB_DATE { get; set; }
        public DateTime JOB_TIME { get; set; }
        public string JOB_NO { get; set; }
        public DateTime CN_DATE { get; set; }
        public string CN_NO { get; set; }
        public DateTime CN_CREATEDATE { get; set; }
        public DateTime IV_DATE { get; set; }
        public string IV_NO { get; set; }
        public string PK_NO { get; set; }
        public string ITEM_BARCODE { get; set; }
        public string ITEM_NAME { get; set; }
        public string ITEM_WH { get; set; }
        public string CUS_CODE { get; set; }
        public string CUS_NAME { get; set; }
        public string cn_req_job_qty { get; set; }
        public int cn_req_job_source { get; set; }
        public string cn_req_job_cause { get; set; }
        public string cn_req_job_note { get; set; }
        public string created_by { get; set; }

    }

    public partial class PKToTMSModel
    {
        public DateTime invdate { get; set; }
        public string number { get; set; }
        public string invcode { get; set; }
        public string invname { get; set; }
        public DateTime startdate { get; set; }
        public string userid { get; set; }
        public string invpo { get; set; }
        public DateTime inv_startdate { get; set; }
        public string inv_userid { get; set; }
        public DateTime chktime { get; set; }
        public string chkuserid { get; set; }
        public string job_no { get; set; }
        public string route_name { get; set; }
        public string driver_fullname { get; set; }
        public string plate_name { get; set; }
        public DateTime created_date { get; set; }
        public DateTime tms_job_delivery_startdate { get; set; }
        public DateTime tms_job_delivery_date { get; set; }
        public double startMile { get; set; }
        public double endMile { get; set; }
        public double totalMile { get; set; }
        public string status { get; set; }
        public string statusId { get; set; }

    }

    public partial class CnReqModel
    {
        public string cn_req_job_id { get; set; }
        public string cn_req_job_jobno { get; set; }
        public DateTime cn_req_job_date { get; set; }
        public string cn_req_salefile_number { get; set; }
        public string cn_req_salefile_stkcod { get; set; }
        public int cn_req_job_qty { get; set; }
        public string cn_req_job_cause { get; set; }
        public string cn_req_job_lastassige { get; set; }
        public string cn_req_job_source { get; set; }
        public string cn_req_job_note { get; set; }
        public string created_by { get; set; }
        public DateTime created_date { get; set; }
        public string updated_by { get; set; }
        public DateTime updated_date { get; set; }
        public int record_status { get; set; }
        public string cn_req_job_last_item_condition { get; set; }
        public string cn_req_job_lastdriver { get; set; }
        public string ref_id { get; set; }

    }

    public partial class TMSModelClose
    {
        public string job_no { get; set; }
        public string job_invoice_no { get; set; }
        public string description { get; set; }
        public string created_by { get; set; }

    }
}