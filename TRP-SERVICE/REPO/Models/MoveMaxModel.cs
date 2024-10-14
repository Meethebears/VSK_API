using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace REPO.Models
{
    public partial class MXInvModel
    {

        public string trans_id { get; set; }
        public string ref_id { get; set; }
        public string job_no { get; set; }

        public string inv_number { get; set; }
        public DateTime inv_date { get; set; }
        public string inv_po { get; set; }
        public string inv_code { get; set; }
        public string inv_name { get; set; }
        public string inv_item { get; set; }
        public string inv_trans { get; set; }
        public int inv_due { get; set; }
        public float inv_paycash { get; set; }
        public float inv_paytran { get; set; }
        public float inv_paycard { get; set; }
        public float inv_payoth { get; set; }
        public float inv_sumtt { get; set; }
        public float inv_cod { get; set; }
        public int inv_toption { get; set; }
        public string inv_descript { get; set; }
        public DateTime inv_startdate { get; set; }
        public string inv_userid { get; set; }
        public string inv_pkuser { get; set; }
        public string event_status { get; set; }
        public int record_status { get; set; }
        public string created_by { get; set; }
        public DateTime created_datetime { get; set; }
        public string updated_by { get; set; }
        public DateTime updated_datetime { get; set; }
        public string inv_kline { get; set; }
        public string inv_branch { get; set; }
        public string inv_custpo { get; set; }
        public string inv_address_name { get; set; }
        public string inv_delivery_address { get; set; }
        public string inv_delivery_evcode { get; set; }
        public string inv_delivery_evname { get; set; }
        public string inv_delivery_evadd { get; set; }
        public string inv_delivery_evtel { get; set; }
        public string inv_eaddress { get; set; }
        public string inv_elocation { get; set; }
        public string location_branch { get; set; }
        public string job_type { get; set; }

        public string pMessage { get; set; }

    }

    public partial class MXTimeModel
    {

        public int row_no { get; set; }
        public string mode { get; set; }
        public string job_date { get; set; }
        public string ref_id { get; set; }
        public string driver_id { get; set; }
        public string driver_name { get; set; }
        public int delivery_drop { get; set; }
        public int delivery_back { get; set; }
        public int delivery_cod { get; set; }
        public int s_1 { get; set; }
        public int s_2 { get; set; }
        public int s_3 { get; set; }
        public int s_4 { get; set; }
        public int s_5 { get; set; }
        public string delivery_status { get; set; }
        public DateTime delivery_time { get; set; }
        public DateTime last_updatetime { get; set; }

        public string pMessage { get; set; }

    }

    public partial class MM_ResponseModel
    {
        public string result_datetime { get; set; }
        public int length { get; set; }
        public string status { get; set; }
        public string error_message { get; set; }
        public string error_stacktrace { get; set; }
        public string error_source { get; set; }
        public object manifestNoteList { set; get; }
        public object ProductList { set; get; }
        public int Productlength { get; set; }
        public string ref_id { get; set; }
        public object data { set; get; }

    }
    public partial class MM_ShippingNoteBookingModel
    {
        public string deliveryProjectCode { get; set; }
        public string endRouteLineCode { get; set; }
        public string endRouteLineName { get; set; }
        public string companyAcronym { get; set; }
        public string coopfirmCode { get; set; }
        public string driverCode { get; set; }
        public string driverName { get; set; }
        public string vehicleCode { get; set; }
        public string addOnVehicleCode { get; set; }
        public string vehicleTypeCode { get; set; }
        public string fuelTypeCode { get; set; }
        public int vehicleFuelUseRate { get; set; }
        public int vehiclePercentReFuel { get; set; }
        public string startDistributionCenterCode { get; set; }
        public string startConsumerDistributionCenterCode { get; set; }
        public string underDistributionCenterCode { get; set; }
        public int startType { get; set; }
        public string documentDate { get; set; }
        public string receiveProductDate { get; set; }
        public bool hasSubApprove { get; set; }
        public bool useMilkrun { get; set; }
        public double totalDistance { get; set; }
        public string code { get; set; }
        public string startDeliveryDate { get; set; }
        public string endDeliveryDate { get; set; }
        public int paymentType { get; set; }
        public string merchantCode { get; set; }
        public string distributionCenterCode { get; set; }
        public string sender_name { get; set; }
        public string sender_addressDescription { get; set; }
        public string sender_address { get; set; }
        public string receiver_code { get; set; }
        public string receiver_name { get; set; }
        public string receiver_addressDescription { get; set; }
        public string receiver_address { get; set; }
        public double receiver_lat { get; set; }
        public double receiver_lng { get; set; }
        public string contactTel { get; set; }
        public string shipmentPriceType { get; set; }
        public string deliveryPrice { get; set; }
        public string pickUpAddressText { get; set; }
        public string pickUpAddress { get; set; }
        public string sendAddressText { get; set; }
        public string sendAddress { get; set; }
        public string created_by { get; set; }
        public DateTime created_date { get; set; }
        public string ref_id { get; set; }
        public string ProductList { get; set; }
        public string pMessage { get; set; }

    }
    public partial class MM_ProductListModel
    {
        public DateTime date { get; set; }
        public string code { get; set; }
        public string name { get; set; }
        public string orderNo { get; set; }
        public string packageNo { get; set; }
        public double cod { get; set; }
        public string description { get; set; }
        public double qty { get; set; }
        public string unitCode { get; set; }
        public string hasCalWeightPerUnit { get; set; }
        public double weightPerUnit { get; set; }
        public string volumeType { get; set; }
        public double boxSizeWidth { get; set; }
        public double boxSizeLength { get; set; }
        public double boxSizeHeight { get; set; }
        public bool hasCalVolumePerUnit { get; set; }
        public double volumePerUnit { get; set; }
        public string created_by { get; set; }
        public DateTime created_date { get; set; }
        public string ref_id { get; set; }
        public string invcode { get; set; }
        public string invname { get; set; }
        public string evname { get; set; }
        public string evadd { get; set; }
        public string eaddress { get; set; }
        public string elocation { get; set; }
        public string pMessage { get; set; }
        public string BRANCH { get; set; }
        public string NUMBER { get; set; }
        public DateTime JOBDATE { get; set; }
        public string REF_ID { get; set; }
        public string CREATE_BY { get; set; }


    }
    public partial class MM_ManifestNoteJobModel
    {
        public string trans_id { get; set; }
        public string mm_manifestNoteId { get; set; }
        public string mm_manifestNoteNumber { get; set; }
        public string mm_shippingNoteResId { get; set; }
        public string mm_shippingNoteResCode { get; set; }
        public string mm_state { get; set; }
        public string ref_id { get; set; }
        public string job_type { get; set; }
        public string endRouteLineName { get; set; }
        public string driverName { get; set; }
        public string updated_by { get; set; }
        public DateTime updated_date { get; set; }

    }
    public partial class MM_ManifestNoteModel
    {
        public string driver_id { get; set; }
        public string job_date { get; set; }
        public string job_type { get; set; }
        public string job_start_date { get; set; }
        public string job_end_date { get; set; }
        public string f_trans_id { get; set; }
        public string f_endRouteLineCode { get; set; }
        public string f_driverCode { get; set; }
        public string f_vehicleCode { get; set; }
        public int f_vehicleFuelUseRate { get; set; }
        public int f_vehiclePercentReFuel { get; set; }
        public int f_startType { get; set; }
        public string f_code { get; set; }
        public string f_receiver_code { get; set; }
        public string f_receiver_name { get; set; }
        public string f_receiver_addressDescription { get; set; }
        public string f_receiver_address { get; set; }
        public string f_created_by { get; set; }
        public DateTime f_created_date { get; set; }
        public DateTime f_documentDate { get; set; }
        public DateTime documentDate { get; set; }
        public string p_trans_id { get; set; }
        public string p_shippingNoteResCode { get; set; }
        public string p_code { get; set; }
        public string p_name { get; set; }
        public string p_orderNo { get; set; }
        public string p_packageNo { get; set; }
        public double p_cod { get; set; }
        public string p_description { get; set; }
        public double p_qty { get; set; }
        public string p_unitCode { get; set; }
        public string r_trans_id { get; set; }
        public string r_mm_manifestNoteId { get; set; }
        public string r_mm_manifestNoteNumber { get; set; }
        public string r_mm_shippingNoteResId { get; set; }
        public string r_mm_shippingNoteResCode { get; set; }
        public DateTime r_created_datetime { get; set; }
        public DateTime created_date { get; set; }
        public string ref_id { get; set; }

        public float cod { get; set; }
        public int currentStatus { get; set; }
        public string currentStatusDate { get; set; }
        public string currentStatusDateText { get; set; }
        public string currentStatusText { get; set; }
        public string currentStatusTimeText { get; set; }
        public float deliveryPrice { get; set; }
        public int deliveryProjectId { get; set; }
        public string deliveryProjectName { get; set; }
        public string driverName { get; set; }
        public string endDeliveryDate { get; set; }
        public string endDeliveryDateText { get; set; }
        public int endRouteLineId { get; set; }
        public int id { get; set; }
        public string manifestNoteDocumentDate { get; set; }
        public string manifestNoteDocumentDateText { get; set; }
        public string manifestNoteNumber { get; set; }
        public string manifestNoteTypeName { get; set; }
        public string manifestNoteUnderDcName { get; set; }
        public string merchantName { get; set; }
        public string paymentTypeName { get; set; }
        public string pointAddress { get; set; }
        public string pointCode { get; set; }
        public string pointName { get; set; }
        public string productName { get; set; }
        public int qty { get; set; }
        public int qtyPics { get; set; }
        public string receiverAddress { get; set; }
        public string receiverName { get; set; }
        public string routeLineName { get; set; }
        public string senderAddress { get; set; }
        public string senderName { get; set; }
        public string shippingNoteDate { get; set; }
        public string shippingNoteDateText { get; set; }
        public string shippingNoteNumber { get; set; }
        public string startDeliveryDate { get; set; }
        public string startDeliveryDateText { get; set; }
        public int underDistributionCenterId { get; set; }
        public string vehicleLicensePlate { get; set; }
        public float volume { get; set; }
        public float weight { get; set; }
        public DateTime last_updatetime { get; set; }
        public string endRouteLineCode { get; set; }
        public string driverCode { get; set; }
        public string vehicleCode { get; set; }
        public string ProductList { get; set; }
        public int receiver_code { get; set; }
        public int orderNo { get; set; }

    }
    public partial class MM_ShipmentDailyModel
    {
        public float cod { get; set; }
        public int currentStatus { get; set; }
        public string currentStatusDate { get; set; }
        public string currentStatusDateText { get; set; }
        public string currentStatusText { get; set; }
        public string currentStatusTimeText { get; set; }
        public float deliveryPrice { get; set; }
        public int deliveryProjectId { get; set; }
        public string deliveryProjectName { get; set; }
        public string driverName { get; set; }
        public string endDeliveryDate { get; set; }
        public string endDeliveryDateText { get; set; }
        public int endRouteLineId { get; set; }
        public int id { get; set; }
        public string manifestNoteDocumentDate { get; set; }
        public string manifestNoteDocumentDateText { get; set; }
        public string manifestNoteNumber { get; set; }
        public string manifestNoteTypeName { get; set; }
        public string manifestNoteUnderDcName { get; set; }
        public string merchantName { get; set; }
        public string paymentTypeName { get; set; }
        public string pointAddress { get; set; }
        public string pointCode { get; set; }
        public string pointName { get; set; }
        public string productName { get; set; }
        public int qty { get; set; }
        public int qtyPics { get; set; }
        public string receiverAddress { get; set; }
        public string receiverName { get; set; }
        public string routeLineName { get; set; }
        public string senderAddress { get; set; }
        public string senderName { get; set; }
        public string shippingNoteDate { get; set; }
        public string shippingNoteDateText { get; set; }
        public string shippingNoteNumber { get; set; }
        public string startDeliveryDate { get; set; }
        public string startDeliveryDateText { get; set; }
        public int underDistributionCenterId { get; set; }
        public string vehicleLicensePlate { get; set; }
        public float volume { get; set; }
        public float weight { get; set; }
        public DateTime last_updatetime { get; set; }
        public string ref_id { get; set; }
        public string closeJobDate { get; set; }
        public string closeJobDateText { get; set; }
        public string latitudeEndMile { get; set; }
        public string latitudeStartMile { get; set; }
        public string longitudeEndMile { get; set; }
        public string longitudeStartMile { get; set; }
        public string openJobDate { get; set; }
        public string openJobDateText { get; set; }
        public string job_date { get; set; }

    }
    public partial class TackingDeliveryModel
    {

        public DateTime startdate { get; set; }
        public DateTime enddate { get; set; }
        public string mode { get; set; }
        public string em_number { get; set; }
        public string pk_number { get; set; }
        public string iv_number { get; set; }
        public string routeline { get; set; }
        public string vehicle { get; set; }
        public int status { get; set; }
        public string driver { get; set; }
        public string manifestNoteNumber { get; set; }
        public string shippingNoteNumber { get; set; }
        public string job_type { get; set; }

        public string pk_invdate { get; set; }
        public string pk_invcode { get; set; }
        public string pk_invname { get; set; }
        public string pk_pknumberc { get; set; }
        public string pk_invtrans { get; set; }
        public DateTime pk_startdate { get; set; }
        public string pk_userid { get; set; }
        public string pk_chkuserid { get; set; }
        public string pk_chktime { get; set; }
        public string em_eline { get; set; }
        public string em_ekcust { get; set; }

        public string cpk_created_by { get; set; }
        public DateTime cpk_created_time { get; set; }

        public int iv_item { get; set; }
        public int iv_trnqty { get; set; }
        public float iv_invsumtt { get; set; }
        public string iv_invkline { get; set; }
        public string iv_userid { get; set; }
        public DateTime iv_startdate { get; set; }

        public string Diff_Confirm_HM { get; set; }
        public string Diff_INV_HM { get; set; }
        public string Diff_TRP_HM { get; set; }
        public string Diff_Delivery_HM { get; set; }
        public string Diff_PK_MX_HM { get; set; }


        public string created_by { get; set; }
        public DateTime created_date { get; set; }
        public int currentStatus { get; set; }
        public string currentStatusText { get; set; }
        public string currentStatusDate { get; set; }
        public string currentStatusDateText { get; set; }
        public string currentStatusTimeText { get; set; }
        public string driverCode { get; set; }
        public string driverName { get; set; }
        public float cod { get; set; }
        public string vehicleCode { get; set; }
        public string endRouteLineCode { get; set; }
        public string endRouteLineName { get; set; }
        public string receiver_addressDescription { get; set; }

    }


}
