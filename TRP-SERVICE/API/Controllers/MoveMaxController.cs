using REPO.Controllers;
using REPO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace API.Controllers
{
    public class MoveMaxController : ApiController
    {

        [Route("v1/MM_ManifestNoteJobCreate")]
        [HttpPost]
        public ResponseModel MM_ManifestNoteJob_Create([FromBody] List<MM_ManifestNoteJobModel> MM_ManifestNoteJobModel)
        {
            try
            {
                ResponseModel _ResponseModel = new ResponseModel();

                MoveMaxRepository MoveMaxRepository = new MoveMaxRepository();

                List<MM_ManifestNoteJobModel> ImportDataArrayData = new List<MM_ManifestNoteJobModel>();

                int i = 1;

                foreach (var ImportUpdateDataItem in MM_ManifestNoteJobModel)
                {
                    MM_ManifestNoteJobModel ImportDataArrayModel_data = new MM_ManifestNoteJobModel();

                    ImportDataArrayModel_data.mm_manifestNoteId = ImportUpdateDataItem.mm_manifestNoteId;
                    ImportDataArrayModel_data.mm_manifestNoteNumber = ImportUpdateDataItem.mm_manifestNoteNumber;
                    ImportDataArrayModel_data.mm_shippingNoteResId = ImportUpdateDataItem.mm_shippingNoteResId;
                    ImportDataArrayModel_data.mm_shippingNoteResCode = ImportUpdateDataItem.mm_shippingNoteResCode;
                    ImportDataArrayModel_data.ref_id = ImportUpdateDataItem.ref_id;
                    ImportDataArrayModel_data.job_type = ImportUpdateDataItem.job_type;
                    ImportDataArrayModel_data.endRouteLineName = ImportUpdateDataItem.endRouteLineName;
                    ImportDataArrayModel_data.driverName = ImportUpdateDataItem.driverName;

                    ImportDataArrayData.Add(ImportDataArrayModel_data);

                    i++;
                }

                MoveMaxRepository.MM_ManifestNoteJob_Create(ImportDataArrayData);

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                //_ResponseModel.data = ImportData_CarModelMix_Tmp;
                //_ResponseModel.length = ImportData_CarModelMix_Tmp.Count();
                _ResponseModel.status = "Success";

                return _ResponseModel;
            }
            catch (Exception ex)
            {
                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.status = "Error";
                _ResponseModel.status = ex.ToString();

                return _ResponseModel;
            }
        }

        [Route("v1/MM_ManifestNoteJob_Delete")]
        [HttpDelete]
        public ResponseModel MM_ManifestNoteJob_Delete([FromBody] MM_ManifestNoteJobModel MM_ManifestNoteJobModel)
        {
            try
            {
                MoveMaxRepository MoveMaxRepository = new MoveMaxRepository();

                List<MM_ManifestNoteJobModel> MM_ManifestNoteJob_Delete = MoveMaxRepository.MM_ManifestNoteJob_Delete(MM_ManifestNoteJobModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = MM_ManifestNoteJob_Delete;
                _ResponseModel.length = MM_ManifestNoteJob_Delete.Count();
                _ResponseModel.status = "Success";

                return _ResponseModel;
            }
            catch (Exception ex)
            {
                ResponseModel _ResponseModel = new ResponseModel();
                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.status = "Error";
                _ResponseModel.error_message = ex.Message.ToString();
                _ResponseModel.error_stacktrace = ex.StackTrace.ToString();
                _ResponseModel.error_source = ex.Source.ToString();

                return _ResponseModel;
            }

        }

        [Route("v1/MM_ManifestNote_List")]
        [HttpGet]
        public ResponseModel MM_ManifestNote_List([FromUri] MM_ManifestNoteModel MM_ManifestNoteModel)
        {
            try
            {
                MoveMaxRepository MoveMaxRepository = new MoveMaxRepository();
                ResponseModel _ResponseModel = new ResponseModel();

                List<MM_ManifestNoteModel> MM_ManifestNote_List = MoveMaxRepository.MM_ManifestNote_List(MM_ManifestNoteModel);

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = MM_ManifestNote_List;
                _ResponseModel.length = MM_ManifestNote_List.Count();
                _ResponseModel.status = "Success";

                return _ResponseModel;
            }
            catch (Exception ex)
            {
                ResponseModel _ResponseModel = new ResponseModel();
                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.status = "Error";
                _ResponseModel.error_message = ex.Message.ToString();
                _ResponseModel.error_stacktrace = ex.StackTrace.ToString();
                _ResponseModel.error_source = ex.Source.ToString();

                return _ResponseModel;
            }

        }

        [Route("v1/MM_ManiFestNoteRoute_List")]
        [HttpGet]
        public ResponseModel MM_ManiFestNoteRoute_List([FromUri] MM_ManifestNoteModel MM_ManifestNoteModel)
        {
            try
            {
                MoveMaxRepository MoveMaxRepository = new MoveMaxRepository();
                ResponseModel _ResponseModel = new ResponseModel();

                List<MM_ManifestNoteModel> MM_ManiFestNoteRoute_List = MoveMaxRepository.MM_ManiFestNoteRoute_List(MM_ManifestNoteModel);

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = MM_ManiFestNoteRoute_List;
                _ResponseModel.length = MM_ManiFestNoteRoute_List.Count();
                _ResponseModel.status = "Success";

                return _ResponseModel;
            }
            catch (Exception ex)
            {
                ResponseModel _ResponseModel = new ResponseModel();
                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.status = "Error";
                _ResponseModel.error_message = ex.Message.ToString();
                _ResponseModel.error_stacktrace = ex.StackTrace.ToString();
                _ResponseModel.error_source = ex.Source.ToString();

                return _ResponseModel;
            }

        }

        [Route("v1/MM_ProductMulit_Create")]
        [HttpPost]
        public ResponseModel MM_ProductMulit_Create(string BRANCH, string NUMBER, string REF_ID, string CREATE_BY)
        {
            try
            {
                MoveMaxRepository MoveMaxRepository = new MoveMaxRepository();
                ResponseModel _ResponseModel = new ResponseModel();

                List<MM_ProductListModel> MM_ProductMulit_Create = MoveMaxRepository.MM_ProductMulit_Create( BRANCH, NUMBER, REF_ID, CREATE_BY);

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = MM_ProductMulit_Create;
                _ResponseModel.length = MM_ProductMulit_Create.Count();
                _ResponseModel.status = "Success";

                return _ResponseModel;
            }
            catch (Exception ex)
            {
                ResponseModel _ResponseModel = new ResponseModel();
                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.status = "Error";
                _ResponseModel.error_message = ex.Message.ToString();
                _ResponseModel.error_stacktrace = ex.StackTrace.ToString();
                _ResponseModel.error_source = ex.Source.ToString();

                return _ResponseModel;
            }

        }


        [Route("v1/MM_ProductMulit_Get")]
        [HttpGet]
        public ResponseModel MM_ProductMulit_Get([FromUri] string NUMBER, string REF_ID, string CREATE_BY)
        {
            try
            {
                MoveMaxRepository MoveMaxRepository = new MoveMaxRepository();
                ResponseModel _ResponseModel = new ResponseModel();

                List<MM_ProductListModel> MM_ProductMulit_Get = MoveMaxRepository.MM_ProductMulit_Get(NUMBER, REF_ID, CREATE_BY);

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = MM_ProductMulit_Get;
                _ResponseModel.length = MM_ProductMulit_Get.Count();
                _ResponseModel.status = "Success";

                return _ResponseModel;
            }
            catch (Exception ex)
            {
                ResponseModel _ResponseModel = new ResponseModel();
                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.status = "Error";
                _ResponseModel.error_message = ex.Message.ToString();
                _ResponseModel.error_stacktrace = ex.StackTrace.ToString();
                _ResponseModel.error_source = ex.Source.ToString();

                return _ResponseModel;
            }

        }

        [Route("v1/MM_ProductMulit_Delete")]
        [HttpDelete]
        public ResponseModel MM_ProductMulit_Delete(string NUMBER, string REF_ID, string CREATE_BY)
        {
            try
            {
                MoveMaxRepository MoveMaxRepository = new MoveMaxRepository();

                List<MM_ProductListModel> MM_ProductMulit_Delete = MoveMaxRepository.MM_ProductMulit_Delete(NUMBER, REF_ID, CREATE_BY);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = MM_ProductMulit_Delete;
                _ResponseModel.length = MM_ProductMulit_Delete.Count();
                _ResponseModel.status = "Success";

                return _ResponseModel;
            }
            catch (Exception ex)
            {
                ResponseModel _ResponseModel = new ResponseModel();
                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.status = "Error";
                _ResponseModel.error_message = ex.Message.ToString();
                _ResponseModel.error_stacktrace = ex.StackTrace.ToString();
                _ResponseModel.error_source = ex.Source.ToString();

                return _ResponseModel;
            }

        }

        [Route("v1/MM_ManifestNoteBike_Get")]
        [HttpGet]
        public MM_ResponseModel MM_ManifestNoteBike_Get([FromUri] string NUMBER, [FromUri] string ROUTE, [FromUri] string DRIVER, string VEHICLE, [FromUri] string CREATE_BY)
        {
            try
            {

                MoveMaxRepository MoveMaxRepository = new MoveMaxRepository();

                List<MM_ShippingNoteBookingModel> MM_ShippingNoteBookingBike_Get = (List<MM_ShippingNoteBookingModel>)MoveMaxRepository.MM_ShippingNoteBookingBike_Get(NUMBER, ROUTE, DRIVER, VEHICLE, CREATE_BY);
                List<MM_ProductListModel> MM_ProductBike_Get = (List<MM_ProductListModel>)MoveMaxRepository.MM_ProductBike_Get(NUMBER, MM_ShippingNoteBookingBike_Get[0].code, CREATE_BY);

                MM_ResponseModel _MM_ResponseModel = new MM_ResponseModel();
                _MM_ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _MM_ResponseModel.manifestNoteList = MM_ShippingNoteBookingBike_Get;
                _MM_ResponseModel.length = MM_ShippingNoteBookingBike_Get.Count();
                _MM_ResponseModel.ProductList = MM_ProductBike_Get;
                _MM_ResponseModel.Productlength = MM_ProductBike_Get.Count();
                _MM_ResponseModel.status = "Success";

                return _MM_ResponseModel;
            }
            catch (Exception ex)
            {
                MM_ResponseModel _MM_ResponseModel = new MM_ResponseModel();
                _MM_ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _MM_ResponseModel.status = "Error";
                _MM_ResponseModel.error_message = ex.Message.ToString();
                _MM_ResponseModel.error_stacktrace = ex.StackTrace.ToString();
                _MM_ResponseModel.error_source = ex.Source.ToString();

                return _MM_ResponseModel;
            }

        }

        [Route("v1/MM_ShippingNoteBookingMulit_Get")]
        [HttpGet]
        public MM_ResponseModel MM_ShippingNoteBookingMulit_Get([FromUri] string REF_ID, string ROUTE, string DRIVER, string VEHICLE, DateTime JOBDATE, string CREATE_BY)
        {
            try
            {
                MoveMaxRepository MoveMaxRepository = new MoveMaxRepository();
                MM_ResponseModel _ResponseModel = new MM_ResponseModel();

                List<MM_ShippingNoteBookingModel> MM_ShippingNoteBookingMulit_Get = MoveMaxRepository.MM_ShippingNoteBookingMulit_Get(REF_ID, ROUTE, DRIVER, VEHICLE, JOBDATE, CREATE_BY);

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.manifestNoteList = MM_ShippingNoteBookingMulit_Get;
                _ResponseModel.length = MM_ShippingNoteBookingMulit_Get.Count();
                _ResponseModel.status = "Success";

                return _ResponseModel;
            }
            catch (Exception ex)
            {
                MM_ResponseModel _ResponseModel = new MM_ResponseModel();
                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.status = "Error";
                _ResponseModel.error_message = ex.Message.ToString();
                _ResponseModel.error_stacktrace = ex.StackTrace.ToString();
                _ResponseModel.error_source = ex.Source.ToString();

                return _ResponseModel;
            }

        }

        [Route("v1/MM_ManiFestNote_Create")]
        [HttpGet]
        public ResponseModel MM_ManiFestNote_Create([FromUri] string REF_ID)
        {
            try
            {
                MoveMaxRepository MoveMaxRepository = new MoveMaxRepository();
                ResponseModel _ResponseModel = new ResponseModel();

                List<MM_ProductListModel> MM_ManiFestNote_Create = MoveMaxRepository.MM_ManiFestNote_Create(REF_ID);

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = MM_ManiFestNote_Create;
                _ResponseModel.length = MM_ManiFestNote_Create.Count();
                _ResponseModel.status = "Success";

                return _ResponseModel;
            }
            catch (Exception ex)
            {
                ResponseModel _ResponseModel = new ResponseModel();
                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.status = "Error";
                _ResponseModel.error_message = ex.Message.ToString();
                _ResponseModel.error_stacktrace = ex.StackTrace.ToString();
                _ResponseModel.error_source = ex.Source.ToString();

                return _ResponseModel;
            }

        }


        [Route("v1/MM_ShipmentDaily_Create")]
        [HttpPost]
        public ResponseModel MM_ShipmentDaily_Create([FromBody] List<MM_ShipmentDailyModel> MM_ShipmentDailyModel)
        {
            try
            {
                ResponseModel _ResponseModel = new ResponseModel();

                MoveMaxRepository MoveMaxRepository = new MoveMaxRepository();

                List<MM_ShipmentDailyModel> ImportDataArrayData = new List<MM_ShipmentDailyModel>();

                int i = 1;

                foreach (var ImportUpdateDataItem in MM_ShipmentDailyModel)
                {
                    MM_ShipmentDailyModel ImportDataArrayModel_data = new MM_ShipmentDailyModel();

                    ImportDataArrayModel_data.cod = ImportUpdateDataItem.cod;
                    ImportDataArrayModel_data.currentStatus = ImportUpdateDataItem.currentStatus;
                    ImportDataArrayModel_data.currentStatusDate = ImportUpdateDataItem.currentStatusDate;
                    ImportDataArrayModel_data.currentStatusDateText = ImportUpdateDataItem.currentStatusDateText;
                    ImportDataArrayModel_data.currentStatusText = ImportUpdateDataItem.currentStatusText;
                    ImportDataArrayModel_data.currentStatusTimeText = ImportUpdateDataItem.currentStatusTimeText;
                    ImportDataArrayModel_data.deliveryPrice = ImportUpdateDataItem.deliveryPrice;
                    ImportDataArrayModel_data.deliveryProjectId = ImportUpdateDataItem.deliveryProjectId;
                    ImportDataArrayModel_data.deliveryProjectName = ImportUpdateDataItem.deliveryProjectName;
                    ImportDataArrayModel_data.driverName = ImportUpdateDataItem.driverName;
                    ImportDataArrayModel_data.endDeliveryDate = ImportUpdateDataItem.endDeliveryDate;
                    ImportDataArrayModel_data.endDeliveryDateText = ImportUpdateDataItem.endDeliveryDateText;
                    ImportDataArrayModel_data.endRouteLineId = ImportUpdateDataItem.endRouteLineId;
                    ImportDataArrayModel_data.id = ImportUpdateDataItem.id;
                    ImportDataArrayModel_data.manifestNoteDocumentDate = ImportUpdateDataItem.manifestNoteDocumentDate;
                    ImportDataArrayModel_data.manifestNoteDocumentDateText = ImportUpdateDataItem.manifestNoteDocumentDateText;
                    ImportDataArrayModel_data.manifestNoteNumber = ImportUpdateDataItem.manifestNoteNumber;
                    ImportDataArrayModel_data.manifestNoteTypeName = ImportUpdateDataItem.manifestNoteTypeName;
                    ImportDataArrayModel_data.manifestNoteUnderDcName = ImportUpdateDataItem.manifestNoteUnderDcName;
                    ImportDataArrayModel_data.merchantName = ImportUpdateDataItem.merchantName;
                    ImportDataArrayModel_data.paymentTypeName = ImportUpdateDataItem.paymentTypeName;
                    ImportDataArrayModel_data.pointAddress = ImportUpdateDataItem.pointAddress;
                    ImportDataArrayModel_data.pointCode = ImportUpdateDataItem.pointCode;
                    ImportDataArrayModel_data.pointName = ImportUpdateDataItem.pointName;
                    ImportDataArrayModel_data.productName = ImportUpdateDataItem.productName;
                    ImportDataArrayModel_data.qty = ImportUpdateDataItem.qty;
                    ImportDataArrayModel_data.qtyPics = ImportUpdateDataItem.qtyPics;
                    ImportDataArrayModel_data.receiverAddress = ImportUpdateDataItem.receiverAddress;
                    ImportDataArrayModel_data.receiverName = ImportUpdateDataItem.receiverName;
                    ImportDataArrayModel_data.routeLineName = ImportUpdateDataItem.routeLineName;
                    ImportDataArrayModel_data.senderAddress = ImportUpdateDataItem.senderAddress;
                    ImportDataArrayModel_data.senderName = ImportUpdateDataItem.senderName;
                    ImportDataArrayModel_data.shippingNoteDate = ImportUpdateDataItem.shippingNoteDate;
                    ImportDataArrayModel_data.shippingNoteDateText = ImportUpdateDataItem.shippingNoteDateText;
                    ImportDataArrayModel_data.shippingNoteNumber = ImportUpdateDataItem.shippingNoteNumber;
                    ImportDataArrayModel_data.startDeliveryDate = ImportUpdateDataItem.startDeliveryDate;
                    ImportDataArrayModel_data.startDeliveryDateText = ImportUpdateDataItem.startDeliveryDateText;
                    ImportDataArrayModel_data.underDistributionCenterId = ImportUpdateDataItem.underDistributionCenterId;
                    ImportDataArrayModel_data.vehicleLicensePlate = ImportUpdateDataItem.vehicleLicensePlate;
                    ImportDataArrayModel_data.volume = ImportUpdateDataItem.volume;
                    ImportDataArrayModel_data.weight = ImportUpdateDataItem.weight;
                    ImportDataArrayModel_data.ref_id = ImportUpdateDataItem.ref_id;
                    ImportDataArrayModel_data.last_updatetime = ImportUpdateDataItem.last_updatetime;
                    ImportDataArrayModel_data.closeJobDate = ImportUpdateDataItem.closeJobDate;
                    ImportDataArrayModel_data.closeJobDateText = ImportUpdateDataItem.closeJobDateText;
                    ImportDataArrayModel_data.latitudeEndMile = ImportUpdateDataItem.latitudeEndMile;
                    ImportDataArrayModel_data.latitudeStartMile = ImportUpdateDataItem.latitudeStartMile;
                    ImportDataArrayModel_data.longitudeEndMile = ImportUpdateDataItem.longitudeEndMile;
                    ImportDataArrayModel_data.longitudeStartMile = ImportUpdateDataItem.longitudeStartMile;
                    ImportDataArrayModel_data.openJobDate = ImportUpdateDataItem.openJobDate;
                    ImportDataArrayModel_data.openJobDateText = ImportUpdateDataItem.openJobDateText;

                    ImportDataArrayData.Add(ImportDataArrayModel_data);

                    i++;
                }

                MoveMaxRepository.MM_ShipmentDaily_Create(ImportDataArrayData);

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                //_ResponseModel.data = MM_ShipmentDaily_Create;
                //_ResponseModel.length = MM_ShipmentDaily_Create.Count();
                _ResponseModel.status = "Success";

                return _ResponseModel;
            }
            catch (Exception ex)
            {
                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.status = "Error";
                _ResponseModel.status = ex.ToString();

                return _ResponseModel;
            }
        }

        [Route("v1/MM_Shipmentdaily_Sync_Get")]
        [HttpGet]
        public ResponseModel MM_Shipmentdaily_Sync_Get([FromUri] MM_ShipmentDailyModel MM_ShipmentDailyModel)
        {
            try
            {
                MoveMaxRepository MoveMaxRepository = new MoveMaxRepository();
                ResponseModel _ResponseModel = new ResponseModel();

                List<MM_ShipmentDailyModel> MM_Shipmentdaily_Sync_Get = MoveMaxRepository.MM_Shipmentdaily_Sync_Get(MM_ShipmentDailyModel);

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = MM_Shipmentdaily_Sync_Get;
                _ResponseModel.length = MM_Shipmentdaily_Sync_Get.Count();
                _ResponseModel.status = "Success";

                return _ResponseModel;
            }
            catch (Exception ex)
            {
                ResponseModel _ResponseModel = new ResponseModel();
                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.status = "Error";
                _ResponseModel.error_message = ex.Message.ToString();
                _ResponseModel.error_stacktrace = ex.StackTrace.ToString();
                _ResponseModel.error_source = ex.Source.ToString();

                return _ResponseModel;
            }

        }


        [Route("v1/MM_ProductPck_Get")]
        [HttpGet]
        public MM_ResponseModel MM_ProductPck_Get([FromUri] string REF_ID)
        {
            try
            {
                MoveMaxRepository MoveMaxRepository = new MoveMaxRepository();
                MM_ResponseModel _ResponseModel = new MM_ResponseModel();

                List<MM_ProductListModel> MM_ProductPck_Get = MoveMaxRepository.MM_ProductPck_Get(REF_ID);

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = MM_ProductPck_Get;
                _ResponseModel.manifestNoteList = MM_ProductPck_Get;
                _ResponseModel.length = MM_ProductPck_Get.Count();
                _ResponseModel.status = "Success";

                return _ResponseModel;
            }
            catch (Exception ex)
            {
                MM_ResponseModel _ResponseModel = new MM_ResponseModel();
                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.status = "Error";
                _ResponseModel.error_message = ex.Message.ToString();
                _ResponseModel.error_stacktrace = ex.StackTrace.ToString();
                _ResponseModel.error_source = ex.Source.ToString();

                return _ResponseModel;
            }

        }

        [Route("v1/MM_ProductPck_Create")]
        [HttpPost]
        public ResponseModel MM_ProductPck_Create([FromBody] List<MM_ProductListModel> MM_ProductListModel)
        {
            try
            {
                ResponseModel _ResponseModel = new ResponseModel();

                MoveMaxRepository MoveMaxRepository = new MoveMaxRepository();

                List<MM_ProductListModel> ImportDataArrayData = new List<MM_ProductListModel>();

                int i = 1;

                foreach (var ImportUpdateDataItem in MM_ProductListModel)
                {
                    MM_ProductListModel ImportDataArrayModel_data = new MM_ProductListModel();

                    ImportDataArrayModel_data.NUMBER = ImportUpdateDataItem.NUMBER;
                    ImportDataArrayModel_data.JOBDATE = ImportUpdateDataItem.JOBDATE;
                    ImportDataArrayModel_data.REF_ID = ImportUpdateDataItem.REF_ID;
                    ImportDataArrayModel_data.CREATE_BY = ImportUpdateDataItem.CREATE_BY;

                    ImportDataArrayData.Add(ImportDataArrayModel_data);

                    i++;
                }

                MoveMaxRepository.MM_ProductPck_Create(ImportDataArrayData);

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                //_ResponseModel.data = ImportData_CarModelMix_Tmp;
                //_ResponseModel.length = ImportData_CarModelMix_Tmp.Count();
                _ResponseModel.status = "Success";

                return _ResponseModel;
            }
            catch (Exception ex)
            {
                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.status = "Error";
                _ResponseModel.status = ex.ToString();

                return _ResponseModel;
            }
        }

        [Route("v1/MM_ShippingNoteBookingPck_Get")]
        [HttpGet]
        public MM_ResponseModel MM_ShippingNoteBookingPck_Get([FromUri] string REF_ID, string ROUTE, string DRIVER, string VEHICLE, DateTime JOBDATE, string CREATE_BY)
        {
            try
            {
                MoveMaxRepository MoveMaxRepository = new MoveMaxRepository();
                MM_ResponseModel _ResponseModel = new MM_ResponseModel();

                List<MM_ShippingNoteBookingModel> MM_ShippingNoteBookingPck_Get = MoveMaxRepository.MM_ShippingNoteBookingPck_Get(REF_ID, ROUTE, DRIVER, VEHICLE, JOBDATE, CREATE_BY);

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.manifestNoteList = MM_ShippingNoteBookingPck_Get;
                _ResponseModel.length = MM_ShippingNoteBookingPck_Get.Count();
                _ResponseModel.status = "Success";

                return _ResponseModel;
            }
            catch (Exception ex)
            {
                MM_ResponseModel _ResponseModel = new MM_ResponseModel();
                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.status = "Error";
                _ResponseModel.error_message = ex.Message.ToString();
                _ResponseModel.error_stacktrace = ex.StackTrace.ToString();
                _ResponseModel.error_source = ex.Source.ToString();

                return _ResponseModel;
            }

        }


        [Route("v1/MM_ShippingNoteBR_Get")]
        [HttpGet]
        public MM_ResponseModel MM_ShippingNoteBR_Get([FromUri] string REF_ID, [FromUri] string NUMBER, [FromUri] string ROUTE, [FromUri] string DRIVER, [FromUri] string CREATE_BY)
        {
            try
            {

                MoveMaxRepository MoveMaxRepository = new MoveMaxRepository();

                List<MM_ShippingNoteBookingModel> MM_ShippingNoteBR_Get = (List<MM_ShippingNoteBookingModel>)MoveMaxRepository.MM_ShippingNoteBR_Get(REF_ID, NUMBER, ROUTE, DRIVER, CREATE_BY);
                List<MM_ProductListModel> MM_ProductBR_Get = (List<MM_ProductListModel>)MoveMaxRepository.MM_ProductBR_Get(NUMBER, MM_ShippingNoteBR_Get[0].code, CREATE_BY);

                MM_ResponseModel _MM_ResponseModel = new MM_ResponseModel();
                _MM_ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _MM_ResponseModel.manifestNoteList = MM_ShippingNoteBR_Get;
                _MM_ResponseModel.length = MM_ShippingNoteBR_Get.Count();
                _MM_ResponseModel.ProductList = MM_ProductBR_Get;
                _MM_ResponseModel.Productlength = MM_ProductBR_Get.Count();
                _MM_ResponseModel.status = "Success";

                return _MM_ResponseModel;
            }
            catch (Exception ex)
            {
                MM_ResponseModel _MM_ResponseModel = new MM_ResponseModel();
                _MM_ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _MM_ResponseModel.status = "Error";
                _MM_ResponseModel.error_message = ex.Message.ToString();
                _MM_ResponseModel.error_stacktrace = ex.StackTrace.ToString();
                _MM_ResponseModel.error_source = ex.Source.ToString();

                return _MM_ResponseModel;
            }

        }

        [Route("v1/MM_ProductBRMulit_Get")]
        [HttpGet]
        public ResponseModel MM_ProductBRMulit_Get([FromUri] string NUMBER, string REF_ID, string CREATE_BY)
        {
            try
            {
                MoveMaxRepository MoveMaxRepository = new MoveMaxRepository();
                ResponseModel _ResponseModel = new ResponseModel();

                List<MM_ProductListModel> MM_ProductBRMulit_Get = MoveMaxRepository.MM_ProductBRMulit_Get(NUMBER, REF_ID, CREATE_BY);

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = MM_ProductBRMulit_Get;
                _ResponseModel.length = MM_ProductBRMulit_Get.Count();
                _ResponseModel.status = "Success";

                return _ResponseModel;
            }
            catch (Exception ex)
            {
                ResponseModel _ResponseModel = new ResponseModel();
                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.status = "Error";
                _ResponseModel.error_message = ex.Message.ToString();
                _ResponseModel.error_stacktrace = ex.StackTrace.ToString();
                _ResponseModel.error_source = ex.Source.ToString();

                return _ResponseModel;
            }

        }


        [Route("v1/MM_ProductPMulit_Get")]
        [HttpGet]
        public ResponseModel MM_ProductPMulit_Get([FromUri] string NUMBER, string REF_ID, string CREATE_BY)
        {
            try
            {
                MoveMaxRepository MoveMaxRepository = new MoveMaxRepository();
                ResponseModel _ResponseModel = new ResponseModel();

                List<MM_ProductListModel> MM_ProductPMulit_Get = MoveMaxRepository.MM_ProductPMulit_Get(NUMBER, REF_ID, CREATE_BY);

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = MM_ProductPMulit_Get;
                _ResponseModel.length = MM_ProductPMulit_Get.Count();
                _ResponseModel.status = "Success";

                return _ResponseModel;
            }
            catch (Exception ex)
            {
                ResponseModel _ResponseModel = new ResponseModel();
                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.status = "Error";
                _ResponseModel.error_message = ex.Message.ToString();
                _ResponseModel.error_stacktrace = ex.StackTrace.ToString();
                _ResponseModel.error_source = ex.Source.ToString();

                return _ResponseModel;
            }

        }


        [Route("v1/MM_ShippingNoteP_Get")]
        [HttpGet]
        public MM_ResponseModel MM_ShippingNoteP_Get([FromUri] string REF_ID, [FromUri] string NUMBER, [FromUri] string ROUTE, [FromUri] string DRIVER, [FromUri] string CREATE_BY)
        {
            try
            {

                MoveMaxRepository MoveMaxRepository = new MoveMaxRepository();

                List<MM_ShippingNoteBookingModel> MM_ShippingNoteP_Get = (List<MM_ShippingNoteBookingModel>)MoveMaxRepository.MM_ShippingNoteP_Get(REF_ID, NUMBER, ROUTE, DRIVER, CREATE_BY);
                List<MM_ProductListModel> MM_ProductP_Get = (List<MM_ProductListModel>)MoveMaxRepository.MM_ProductP_Get(NUMBER, MM_ShippingNoteP_Get[0].code, CREATE_BY);

                MM_ResponseModel _MM_ResponseModel = new MM_ResponseModel();
                _MM_ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _MM_ResponseModel.manifestNoteList = MM_ShippingNoteP_Get;
                _MM_ResponseModel.length = MM_ShippingNoteP_Get.Count();
                _MM_ResponseModel.ProductList = MM_ProductP_Get;
                _MM_ResponseModel.Productlength = MM_ProductP_Get.Count();
                _MM_ResponseModel.status = "Success";

                return _MM_ResponseModel;
            }
            catch (Exception ex)
            {
                MM_ResponseModel _MM_ResponseModel = new MM_ResponseModel();
                _MM_ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _MM_ResponseModel.status = "Error";
                _MM_ResponseModel.error_message = ex.Message.ToString();
                _MM_ResponseModel.error_stacktrace = ex.StackTrace.ToString();
                _MM_ResponseModel.error_source = ex.Source.ToString();

                return _MM_ResponseModel;
            }

        }


        [Route("v1/MM_ProductRefMulit_Get")]
        [HttpGet]
        public ResponseModel MM_ProductRefMulit_Get([FromUri] string NUMBER, string REF_ID, string CREATE_BY)
        {
            try
            {
                MoveMaxRepository MoveMaxRepository = new MoveMaxRepository();
                ResponseModel _ResponseModel = new ResponseModel();

                List<MM_ProductListModel> MM_ProductRefMulit_Get = MoveMaxRepository.MM_ProductRefMulit_Get(NUMBER, REF_ID, CREATE_BY);

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = MM_ProductRefMulit_Get;
                _ResponseModel.length = MM_ProductRefMulit_Get.Count();
                _ResponseModel.status = "Success";

                return _ResponseModel;
            }
            catch (Exception ex)
            {
                ResponseModel _ResponseModel = new ResponseModel();
                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.status = "Error";
                _ResponseModel.error_message = ex.Message.ToString();
                _ResponseModel.error_stacktrace = ex.StackTrace.ToString();
                _ResponseModel.error_source = ex.Source.ToString();

                return _ResponseModel;
            }

        }

        [Route("v1/MM_ShippingNoteRef_Get")]
        [HttpGet]
        public MM_ResponseModel MM_ShippingNoteRef_Get([FromUri] string REF_ID, [FromUri] string NUMBER, [FromUri] string ROUTE, [FromUri] string DRIVER, [FromUri] string CREATE_BY)
        {
            try
            {

                MoveMaxRepository MoveMaxRepository = new MoveMaxRepository();

                List<MM_ShippingNoteBookingModel> MM_ShippingNoteRef_Get = (List<MM_ShippingNoteBookingModel>)MoveMaxRepository.MM_ShippingNoteRef_Get(REF_ID, NUMBER, ROUTE, DRIVER, CREATE_BY);
                List<MM_ProductListModel> MM_ProductRef_Get = (List<MM_ProductListModel>)MoveMaxRepository.MM_ProductRef_Get(NUMBER, MM_ShippingNoteRef_Get[0].code, CREATE_BY);

                MM_ResponseModel _MM_ResponseModel = new MM_ResponseModel();
                _MM_ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _MM_ResponseModel.manifestNoteList = MM_ShippingNoteRef_Get;
                _MM_ResponseModel.length = MM_ShippingNoteRef_Get.Count();
                _MM_ResponseModel.ProductList = MM_ProductRef_Get;
                _MM_ResponseModel.Productlength = MM_ProductRef_Get.Count();
                _MM_ResponseModel.status = "Success";

                return _MM_ResponseModel;
            }
            catch (Exception ex)
            {
                MM_ResponseModel _MM_ResponseModel = new MM_ResponseModel();
                _MM_ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _MM_ResponseModel.status = "Error";
                _MM_ResponseModel.error_message = ex.Message.ToString();
                _MM_ResponseModel.error_stacktrace = ex.StackTrace.ToString();
                _MM_ResponseModel.error_source = ex.Source.ToString();

                return _MM_ResponseModel;
            }

        }



        [Route("v1/MX_DOCUMENT_CREATE")]
        [HttpPost]
        public ResponseModel MX_DOCUMENT_CREATE([FromBody] MXInvModel MXInvModel)
        {
            try
            {
                MoveMaxRepository MoveMaxRepository = new MoveMaxRepository();

                List<MXInvModel> MX_DOCUMENT_CREATE = MoveMaxRepository.MX_DOCUMENT_CREATE(MXInvModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = MX_DOCUMENT_CREATE;
                _ResponseModel.length = MX_DOCUMENT_CREATE.Count();
                _ResponseModel.status = "Success";

                return _ResponseModel;
            }
            catch (Exception ex)
            {
                ResponseModel _ResponseModel = new ResponseModel();
                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.status = "Error";
                _ResponseModel.error_message = ex.Message.ToString();
                _ResponseModel.error_stacktrace = ex.StackTrace.ToString();
                _ResponseModel.error_source = ex.Source.ToString();

                return _ResponseModel;
            }

        }

        [Route("v1/MX_DOCUMENT_DELETE")]
        [HttpDelete]
        public ResponseModel MX_DOCUMENT_DELETE([FromBody] MXInvModel MXInvModel)
        {
            try
            {
                MoveMaxRepository MoveMaxRepository = new MoveMaxRepository();

                List<MXInvModel> MX_DOCUMENT_DELETE = MoveMaxRepository.MX_DOCUMENT_DELETE(MXInvModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = MX_DOCUMENT_DELETE;
                _ResponseModel.length = MX_DOCUMENT_DELETE.Count();
                _ResponseModel.status = "Success";

                return _ResponseModel;
            }
            catch (Exception ex)
            {
                ResponseModel _ResponseModel = new ResponseModel();
                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.status = "Error";
                _ResponseModel.error_message = ex.Message.ToString();
                _ResponseModel.error_stacktrace = ex.StackTrace.ToString();
                _ResponseModel.error_source = ex.Source.ToString();

                return _ResponseModel;
            }

        }

        [Route("v1/MX_DOCUMENT_LIST")]
        [HttpGet]
        public ResponseModel MX_DOCUMENT_LIST([FromUri] MXInvModel MXInvModel)
        {
            try
            {
                MoveMaxRepository MoveMaxRepository = new MoveMaxRepository();

                List<MXInvModel> MX_DOCUMENT_LIST = MoveMaxRepository.MX_DOCUMENT_LIST(MXInvModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = MX_DOCUMENT_LIST;
                _ResponseModel.length = MX_DOCUMENT_LIST.Count();
                _ResponseModel.status = "Success";

                return _ResponseModel;
            }
            catch (Exception ex)
            {
                ResponseModel _ResponseModel = new ResponseModel();
                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.status = "Error";
                _ResponseModel.error_message = ex.Message.ToString();
                _ResponseModel.error_stacktrace = ex.StackTrace.ToString();
                _ResponseModel.error_source = ex.Source.ToString();

                return _ResponseModel;
            }

        }

        [Route("v1/MX_DELIVERY_TIME_TACKING")]
        [HttpGet]
        public ResponseModel MX_DELIVERY_TIME_TACKING([FromUri] MXTimeModel MXTimeModel)
        {
            try
            {
                MoveMaxRepository MoveMaxRepository = new MoveMaxRepository();

                List<MXTimeModel> MX_DELIVERY_TIME_TACKING = MoveMaxRepository.MX_DELIVERY_TIME_TACKING(MXTimeModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = MX_DELIVERY_TIME_TACKING;
                _ResponseModel.length = MX_DELIVERY_TIME_TACKING.Count();
                _ResponseModel.status = "Success";

                return _ResponseModel;
            }
            catch (Exception ex)
            {
                ResponseModel _ResponseModel = new ResponseModel();
                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.status = "Error";
                _ResponseModel.error_message = ex.Message.ToString();
                _ResponseModel.error_stacktrace = ex.StackTrace.ToString();
                _ResponseModel.error_source = ex.Source.ToString();

                return _ResponseModel;
            }

        }

        [Route("v1/MX_DELIVERY_TIME_TACKING_JOB")]
        [HttpGet]
        public ResponseModel MX_DELIVERY_TIME_TACKING_JOB([FromUri] MM_ManifestNoteModel MM_ManifestNoteModel)
        {
            try
            {
                MoveMaxRepository MoveMaxRepository = new MoveMaxRepository();
                ResponseModel _ResponseModel = new ResponseModel();

                List<MM_ManifestNoteModel> MX_DELIVERY_TIME_TACKING_JOB = MoveMaxRepository.MX_DELIVERY_TIME_TACKING_JOB(MM_ManifestNoteModel);

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = MX_DELIVERY_TIME_TACKING_JOB;
                _ResponseModel.length = MX_DELIVERY_TIME_TACKING_JOB.Count();
                _ResponseModel.status = "Success";

                return _ResponseModel;
            }
            catch (Exception ex)
            {
                ResponseModel _ResponseModel = new ResponseModel();
                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.status = "Error";
                _ResponseModel.error_message = ex.Message.ToString();
                _ResponseModel.error_stacktrace = ex.StackTrace.ToString();
                _ResponseModel.error_source = ex.Source.ToString();

                return _ResponseModel;
            }

        }

        [Route("v1/MX_DOCUMENT_CREATE_LIST")]
        [HttpPost]
        public ResponseModel MX_DOCUMENT_CREATE_LIST([FromBody] List<MXInvModel> MXInvModel)
        {
            try
            {
                ResponseModel _ResponseModel = new ResponseModel();

                MoveMaxRepository MoveMaxRepository = new MoveMaxRepository();

                List<MXInvModel> ImportDataArrayData = new List<MXInvModel>();

                int i = 1;

                foreach (var ImportUpdateDataItem in MXInvModel)
                {
                    MXInvModel ImportDataArrayModel_data = new MXInvModel();

                    ImportDataArrayModel_data.ref_id = ImportUpdateDataItem.ref_id;
                    ImportDataArrayModel_data.job_no = ImportUpdateDataItem.job_no;
                    ImportDataArrayModel_data.inv_number = ImportUpdateDataItem.inv_number;
                    ImportDataArrayModel_data.inv_date = ImportUpdateDataItem.inv_date;
                    ImportDataArrayModel_data.inv_po = ImportUpdateDataItem.inv_po;
                    ImportDataArrayModel_data.inv_code = ImportUpdateDataItem.inv_code;
                    ImportDataArrayModel_data.inv_name = ImportUpdateDataItem.inv_name;
                    ImportDataArrayModel_data.inv_item = ImportUpdateDataItem.inv_item;
                    ImportDataArrayModel_data.inv_trans = ImportUpdateDataItem.inv_trans;
                    ImportDataArrayModel_data.inv_due = ImportUpdateDataItem.inv_due;
                    ImportDataArrayModel_data.inv_paycash = ImportUpdateDataItem.inv_paycash;
                    ImportDataArrayModel_data.inv_paytran = ImportUpdateDataItem.inv_paytran;
                    ImportDataArrayModel_data.inv_paycard = ImportUpdateDataItem.inv_paycard;
                    ImportDataArrayModel_data.inv_payoth = ImportUpdateDataItem.inv_payoth;
                    ImportDataArrayModel_data.inv_cod = ImportUpdateDataItem.inv_cod;
                    ImportDataArrayModel_data.inv_sumtt = ImportUpdateDataItem.inv_sumtt;
                    ImportDataArrayModel_data.inv_toption = ImportUpdateDataItem.inv_toption;
                    ImportDataArrayModel_data.inv_descript = ImportUpdateDataItem.inv_descript;
                    ImportDataArrayModel_data.inv_startdate = ImportUpdateDataItem.inv_startdate;
                    ImportDataArrayModel_data.inv_kline = ImportUpdateDataItem.inv_kline;
                    ImportDataArrayModel_data.inv_branch = ImportUpdateDataItem.inv_branch;
                    ImportDataArrayModel_data.inv_custpo = ImportUpdateDataItem.inv_custpo;
                    ImportDataArrayModel_data.inv_userid = ImportUpdateDataItem.inv_userid;
                    ImportDataArrayModel_data.inv_pkuser = ImportUpdateDataItem.inv_pkuser;
                    ImportDataArrayModel_data.created_by = ImportUpdateDataItem.created_by;
                    ImportDataArrayModel_data.inv_address_name = ImportUpdateDataItem.inv_address_name;
                    ImportDataArrayModel_data.inv_delivery_address = ImportUpdateDataItem.inv_delivery_address;
                    ImportDataArrayModel_data.inv_delivery_evcode = ImportUpdateDataItem.inv_delivery_evcode;
                    ImportDataArrayModel_data.inv_delivery_evname = ImportUpdateDataItem.inv_delivery_evname;
                    ImportDataArrayModel_data.inv_delivery_evadd = ImportUpdateDataItem.inv_delivery_evadd;
                    ImportDataArrayModel_data.inv_delivery_evtel = ImportUpdateDataItem.inv_delivery_evtel;
                    ImportDataArrayModel_data.inv_eaddress = ImportUpdateDataItem.inv_eaddress;
                    ImportDataArrayModel_data.inv_elocation = ImportUpdateDataItem.inv_elocation;
                    ImportDataArrayModel_data.location_branch = ImportUpdateDataItem.location_branch;
                    ImportDataArrayModel_data.job_type = ImportUpdateDataItem.job_type;

                    ImportDataArrayData.Add(ImportDataArrayModel_data);

                    i++;
                }

                MoveMaxRepository.MX_DOCUMENT_CREATE_LIST(ImportDataArrayData);

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                //_ResponseModel.data = MM_ShipmentDaily_Create;
                //_ResponseModel.length = MM_ShipmentDaily_Create.Count();
                _ResponseModel.status = "Success";

                return _ResponseModel;
            }
            catch (Exception ex)
            {
                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.status = "Error";
                _ResponseModel.status = ex.ToString();

                return _ResponseModel;
            }
        }

        [Route("v1/MX_JOB_GET")]
        [HttpGet]
        public ResponseModel MX_JOB_GET([FromUri] MM_ManifestNoteJobModel MM_ManifestNoteJobModel)
        {
            try
            {
                MoveMaxRepository MoveMaxRepository = new MoveMaxRepository();
                ResponseModel _ResponseModel = new ResponseModel();

                List<MM_ManifestNoteJobModel> MX_JOB_GET = MoveMaxRepository.MX_JOB_GET(MM_ManifestNoteJobModel);

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = MX_JOB_GET;
                _ResponseModel.length = MX_JOB_GET.Count();
                _ResponseModel.status = "Success";

                return _ResponseModel;
            }
            catch (Exception ex)
            {
                ResponseModel _ResponseModel = new ResponseModel();
                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.status = "Error";
                _ResponseModel.error_message = ex.Message.ToString();
                _ResponseModel.error_stacktrace = ex.StackTrace.ToString();
                _ResponseModel.error_source = ex.Source.ToString();

                return _ResponseModel;
            }

        }

        [Route("v1/PK_TO_DELIVERY_TACKING_MX")]
        [HttpGet]
        public ResponseModel PK_TO_DELIVERY_TACKING_MX([FromUri] TackingDeliveryModel TackingDeliveryModel)
        {
            try
            {
                MoveMaxRepository MoveMaxRepository = new MoveMaxRepository();
                ResponseModel _ResponseModel = new ResponseModel();

                List<TackingDeliveryModel> PK_TO_DELIVERY_TACKING_MX = MoveMaxRepository.PK_TO_DELIVERY_TACKING_MX(TackingDeliveryModel);

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = PK_TO_DELIVERY_TACKING_MX;
                _ResponseModel.length = PK_TO_DELIVERY_TACKING_MX.Count();
                _ResponseModel.status = "Success";

                return _ResponseModel;
            }
            catch (Exception ex)
            {
                ResponseModel _ResponseModel = new ResponseModel();
                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.status = "Error";
                _ResponseModel.error_message = ex.Message.ToString();
                _ResponseModel.error_stacktrace = ex.StackTrace.ToString();
                _ResponseModel.error_source = ex.Source.ToString();

                return _ResponseModel;
            }

        }

        [Route("v1/MX_DELIVERY_TRACKING_ONL")]
        [HttpGet]
        public ResponseModel MX_DELIVERY_TRACKING_ONL([FromUri] MM_ManifestNoteModel MM_ManifestNoteModel)
        {
            try
            {
                MoveMaxRepository MoveMaxRepository = new MoveMaxRepository();
                ResponseModel _ResponseModel = new ResponseModel();

                List<MM_ManifestNoteModel> MX_DELIVERY_TRACKING_ONL = MoveMaxRepository.MX_DELIVERY_TRACKING_ONL(MM_ManifestNoteModel);

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = MX_DELIVERY_TRACKING_ONL;
                _ResponseModel.length = MX_DELIVERY_TRACKING_ONL.Count();
                _ResponseModel.status = "Success";

                return _ResponseModel;
            }
            catch (Exception ex)
            {
                ResponseModel _ResponseModel = new ResponseModel();
                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.status = "Error";
                _ResponseModel.error_message = ex.Message.ToString();
                _ResponseModel.error_stacktrace = ex.StackTrace.ToString();
                _ResponseModel.error_source = ex.Source.ToString();

                return _ResponseModel;
            }

        }

    }
}
