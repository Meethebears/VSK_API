using REPO.Controllers;
using REPO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace API.Controllers
{
    public class MB_PackingController : ApiController
    {

        [Route("v1/PACKING_LIST_DC")]
        [HttpGet]
        public ResponseModel PACKING_LIST_DC([FromUri] PckGetModel PckGetModel)
        {
            try
            {
                MB_PackingRepository MB_PackingRepository = new MB_PackingRepository();

                List<PckGetModel> PACKING_LIST_DC = MB_PackingRepository.PACKING_LIST_DC(PckGetModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = PACKING_LIST_DC;
                _ResponseModel.length = PACKING_LIST_DC.Count();
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

        [Route("v1/PACKING_TACKING_DC")]
        [HttpGet]
        public ResponseModel PACKING_TACKING_DC([FromUri] PckGetModel PckGetModel)
        {
            try
            {
                MB_PackingRepository MB_PackingRepository = new MB_PackingRepository();

                List<PckGetModel> PACKING_TACKING_DC = MB_PackingRepository.PACKING_TACKING_DC(PckGetModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = PACKING_TACKING_DC;
                _ResponseModel.length = PACKING_TACKING_DC.Count();
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


        [Route("v1/PACKING_LIST_MB")]
        [HttpGet]
        public ResponseModel PACKING_LIST_MB([FromUri] PckGetModel PckGetModel)
        {
            try
            {
                MB_PackingRepository MB_PackingRepository = new MB_PackingRepository();

                List<PckGetModel> PACKING_LIST_MB = MB_PackingRepository.PACKING_LIST_MB(PckGetModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = PACKING_LIST_MB;
                _ResponseModel.length = PACKING_LIST_MB.Count();
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

        [Route("v1/PACKING_TACKING_MB")]
        [HttpGet]
        public ResponseModel PACKING_TACKING_MB([FromUri] PckGetModel PckGetModel)
        {
            try
            {
                MB_PackingRepository MB_PackingRepository = new MB_PackingRepository();

                List<PckGetModel> PACKING_TACKING_MB = MB_PackingRepository.PACKING_TACKING_MB(PckGetModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = PACKING_TACKING_MB;
                _ResponseModel.length = PACKING_TACKING_MB.Count();
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



        [Route("v1/PACKING_CHECK_JOB_MB")]
        [HttpGet]
        public ResponseModel PACKING_CHECK_JOB_MB([FromUri] PckInputModel PckInputModel)
        {
            try
            {
                MB_PackingRepository MB_PackingRepository = new MB_PackingRepository();

                List<PckGetModel> PACKING_CHECK_JOB_MB = MB_PackingRepository.PACKING_CHECK_JOB_MB(PckInputModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = PACKING_CHECK_JOB_MB;
                _ResponseModel.length = PACKING_CHECK_JOB_MB.Count();
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

        [Route("v1/PACKING_CHECK_ADDRESS_MB")]
        [HttpGet]
        public ResponseModel PACKING_CHECK_ADDRESS_MB([FromUri] PckInputModel PckInputModel)
        {
            try
            {
                MB_PackingRepository MB_PackingRepository = new MB_PackingRepository();

                List<PckCheckAddrModel> PACKING_CHECK_ADDRESS_MB = MB_PackingRepository.PACKING_CHECK_ADDRESS_MB(PckInputModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = PACKING_CHECK_ADDRESS_MB;
                _ResponseModel.length = PACKING_CHECK_ADDRESS_MB.Count();
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

        [Route("v1/PACKING_INVOICE_DELIVERY_ADDRESS_GET_MB")]
        [HttpGet]
        public ResponseModel PACKING_INVOICE_DELIVERY_ADDRESS_GET_MB([FromUri] PckInputModel PckInputModel)
        {
            try
            {
                MB_PackingRepository MB_PackingRepository = new MB_PackingRepository();

                List<PckGetModel> PACKING_INVOICE_DELIVERY_ADDRESS_GET_MB = MB_PackingRepository.PACKING_INVOICE_DELIVERY_ADDRESS_GET_MB(PckInputModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = PACKING_INVOICE_DELIVERY_ADDRESS_GET_MB;
                _ResponseModel.length = PACKING_INVOICE_DELIVERY_ADDRESS_GET_MB.Count();
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

        [Route("v1/PACKING_TRP_VENDOR_GET_MB")]
        [HttpGet]
        public ResponseModel PACKING_TRP_VENDOR_GET_MB([FromUri] PckInputModel PckInputModel)
        {
            try
            {
                MB_PackingRepository MB_PackingRepository = new MB_PackingRepository();

                List<PckGetModel> PACKING_TRP_VENDOR_GET_MB = MB_PackingRepository.PACKING_TRP_VENDOR_GET_MB(PckInputModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = PACKING_TRP_VENDOR_GET_MB;
                _ResponseModel.length = PACKING_TRP_VENDOR_GET_MB.Count();
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


        [Route("v1/PACKING_JOB_CREATE_DC")]
        [HttpPost]
        public ResponseModel PACKING_JOB_CREATE_DC([FromBody] PckDataModel PckDataModel)
        {
            try
            {
                MB_PackingRepository MB_PackingRepository = new MB_PackingRepository();

                List<PckDataModel> PACKING_JOB_CREATE_DC = MB_PackingRepository.PACKING_JOB_CREATE_DC(PckDataModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = PACKING_JOB_CREATE_DC;
                _ResponseModel.length = PACKING_JOB_CREATE_DC.Count();
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

        [Route("v1/PACKING_JOB_CREATE_MB")]
        [HttpPost]
        public ResponseModel PACKING_JOB_CREATE_MB([FromBody] PckDataModel PckDataModel)
        {
            try
            {
                MB_PackingRepository MB_PackingRepository = new MB_PackingRepository();

                List<PckDataModel> PACKING_JOB_CREATE_MB = MB_PackingRepository.PACKING_JOB_CREATE_MB(PckDataModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = PACKING_JOB_CREATE_MB;
                _ResponseModel.length = PACKING_JOB_CREATE_MB.Count();
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

        [Route("v1/PACKING_JOB_DETAIL_MB")]
        [HttpGet]
        public ResponseModel PACKING_JOB_DETAIL_MB([FromUri] PckInputModel PckInputModel)
        {
            try
            {
                MB_PackingRepository MB_PackingRepository = new MB_PackingRepository();

                List<PckGetModel> PACKING_JOB_DETAIL_MB = MB_PackingRepository.PACKING_JOB_DETAIL_MB(PckInputModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = PACKING_JOB_DETAIL_MB;
                _ResponseModel.length = PACKING_JOB_DETAIL_MB.Count();
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

        [Route("v1/PACKING_JOB_DELETE_MB")]
        [HttpDelete]
        public ResponseModel PACKING_JOB_DELETE_MB([FromBody] PckGetModel PckGetModel)
        {
            try
            {
                MB_PackingRepository MB_PackingRepository = new MB_PackingRepository();

                List<PckGetModel> PACKING_JOB_DELETE_MB = MB_PackingRepository.PACKING_JOB_DELETE_MB(PckGetModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = PACKING_JOB_DELETE_MB;
                _ResponseModel.length = PACKING_JOB_DELETE_MB.Count();
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


        [Route("v1/PACKING_JOB_PAYMENT_TYPE_UPDATE_MB")]
        [HttpPut]
        public ResponseModel PACKING_JOB_PAYMENT_TYPE_UPDATE_MB([FromBody] PckDataModel PckDataModel)
        {
            try
            {
                MB_PackingRepository MB_PackingRepository = new MB_PackingRepository();

                List<PckDataModel> PACKING_JOB_PAYMENT_TYPE_UPDATE_MB = MB_PackingRepository.PACKING_JOB_PAYMENT_TYPE_UPDATE_MB(PckDataModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = PACKING_JOB_PAYMENT_TYPE_UPDATE_MB;
                _ResponseModel.length = PACKING_JOB_PAYMENT_TYPE_UPDATE_MB.Count();
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

        [Route("v1/PACKING_JOB_TRANSPORT_COMPANY_UPDATE_MB")]
        [HttpPut]
        public ResponseModel PACKING_JOB_TRANSPORT_COMPANY_UPDATE_MB([FromBody] PckDataModel PckDataModel)
        {
            try
            {
                MB_PackingRepository MB_PackingRepository = new MB_PackingRepository();

                List<PckDataModel> PACKING_JOB_TRANSPORT_COMPANY_UPDATE_MB = MB_PackingRepository.PACKING_JOB_TRANSPORT_COMPANY_UPDATE_MB(PckDataModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = PACKING_JOB_TRANSPORT_COMPANY_UPDATE_MB;
                _ResponseModel.length = PACKING_JOB_TRANSPORT_COMPANY_UPDATE_MB.Count();
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

        [Route("v1/PACKING_JOB_INFORMATION_STATUS_UPDATE_MB")]
        [HttpPut]
        public ResponseModel PACKING_JOB_INFORMATION_STATUS_UPDATE_MB([FromBody] PckDataModel PckDataModel)
        {
            try
            {
                MB_PackingRepository MB_PackingRepository = new MB_PackingRepository();

                List<PckDataModel> PACKING_JOB_INFORMATION_STATUS_UPDATE_MB = MB_PackingRepository.PACKING_JOB_INFORMATION_STATUS_UPDATE_MB(PckDataModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = PACKING_JOB_INFORMATION_STATUS_UPDATE_MB;
                _ResponseModel.length = PACKING_JOB_INFORMATION_STATUS_UPDATE_MB.Count();
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


        [Route("v1/PACKING_INVOICE_CREATE_MB")]
        [HttpPost]
        public ResponseModel PACKING_INVOICE_CREATE_MB([FromBody] PckInvModel PckInvModel)
        {
            try
            {
                MB_PackingRepository MB_PackingRepository = new MB_PackingRepository();

                List<PckInvModel> PACKING_INVOICE_CREATE_MB = MB_PackingRepository.PACKING_INVOICE_CREATE_MB(PckInvModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = PACKING_INVOICE_CREATE_MB;
                _ResponseModel.length = PACKING_INVOICE_CREATE_MB.Count();
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

        [Route("v1/PACKING_INVOICE_LIST_MB")]
        [HttpGet]
        public ResponseModel PACKING_INVOICE_LIST_MB([FromUri] PckInvModel PckInvModel)
        {
            try
            {
                MB_PackingRepository MB_PackingRepository = new MB_PackingRepository();

                List<PckInvModel> PACKING_INVOICE_LIST_MB = MB_PackingRepository.PACKING_INVOICE_LIST_MB(PckInvModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = PACKING_INVOICE_LIST_MB;
                _ResponseModel.length = PACKING_INVOICE_LIST_MB.Count();
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

        [Route("v1/PACKING_INVOICE_VERIFY_MB")]
        [HttpPut]
        public ResponseModel PACKING_INVOICE_VERIFY_MB([FromBody] PckInvModel PckInvModel)
        {
            try
            {
                MB_PackingRepository MB_PackingRepository = new MB_PackingRepository();

                List<PckInvModel> PACKING_INVOICE_VERIFY_MB = MB_PackingRepository.PACKING_INVOICE_VERIFY_MB(PckInvModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = PACKING_INVOICE_VERIFY_MB;
                _ResponseModel.length = PACKING_INVOICE_VERIFY_MB.Count();
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

        [Route("v1/PACKING_INVOICE_DELETE_MB")]
        [HttpDelete]
        public ResponseModel PACKING_INVOICE_DELETE_MB([FromBody] PckInvModel PckInvModel)
        {
            try
            {
                MB_PackingRepository MB_PackingRepository = new MB_PackingRepository();

                List<PckInvModel> PACKING_INVOICE_DELETE_MB = MB_PackingRepository.PACKING_INVOICE_DELETE_MB(PckInvModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = PACKING_INVOICE_DELETE_MB;
                _ResponseModel.length = PACKING_INVOICE_DELETE_MB.Count();
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


        [Route("v1/PACKING_ITEM_CREATE_MB")]
        [HttpPost]
        public ResponseModel PACKING_ITEM_CREATE_MB([FromBody] PckItemModel PckItemModel)
        {
            try
            {
                MB_PackingRepository MB_PackingRepository = new MB_PackingRepository();

                List<PckItemModel> PACKING_ITEM_CREATE_MB = MB_PackingRepository.PACKING_ITEM_CREATE_MB(PckItemModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = PACKING_ITEM_CREATE_MB;
                _ResponseModel.length = PACKING_ITEM_CREATE_MB.Count();
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

        [Route("v1/PACKING_ITEM_GET_MB")]
        [HttpGet]
        public ResponseModel PACKING_ITEM_GET_MB([FromUri] PckItemModel PckItemModel)
        {
            try
            {
                MB_PackingRepository MB_PackingRepository = new MB_PackingRepository();

                List<PckItemModel> PACKING_ITEM_GET_MB = MB_PackingRepository.PACKING_ITEM_GET_MB(PckItemModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = PACKING_ITEM_GET_MB;
                _ResponseModel.length = PACKING_ITEM_GET_MB.Count();
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

        [Route("v1/PACKING_ITEM_COUNT_MB")]
        [HttpGet]
        public ResponseModel PACKING_ITEM_COUNT_MB([FromUri] PckItemModel PckItemModel)
        {
            try
            {
                MB_PackingRepository MB_PackingRepository = new MB_PackingRepository();

                List<PckItemModel> PACKING_ITEM_COUNT_MB = MB_PackingRepository.PACKING_ITEM_COUNT_MB(PckItemModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = PACKING_ITEM_COUNT_MB;
                _ResponseModel.length = PACKING_ITEM_COUNT_MB.Count();
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

        [Route("v1/PACKING_ITEM_UPDATE_MB")]
        [HttpPut]
        public ResponseModel PACKING_ITEM_UPDATE_MB([FromBody] PckItemModel PckItemModel)
        {
            try
            {
                MB_PackingRepository MB_PackingRepository = new MB_PackingRepository();

                List<PckItemModel> PACKING_ITEM_UPDATE_MB = MB_PackingRepository.PACKING_ITEM_UPDATE_MB(PckItemModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = PACKING_ITEM_UPDATE_MB;
                _ResponseModel.length = PACKING_ITEM_UPDATE_MB.Count();
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

        [Route("v1/PACKING_ITEM_SUCCESS_MB")]
        [HttpPut]
        public ResponseModel PACKING_ITEM_SUCCESS_MB([FromBody] PckItemModel PckItemModel)
        {
            try
            {
                MB_PackingRepository MB_PackingRepository = new MB_PackingRepository();

                List<PckItemModel> PACKING_ITEM_SUCCESS_MB = MB_PackingRepository.PACKING_ITEM_SUCCESS_MB(PckItemModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = PACKING_ITEM_SUCCESS_MB;
                _ResponseModel.length = PACKING_ITEM_SUCCESS_MB.Count();
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


        [Route("v1/PACKING_BOX_GET_MB")]
        [HttpGet]
        public ResponseModel PACKING_BOX_GET_MB([FromUri] PckMasterModel PckMasterModel)
        {
            try
            {
                MB_PackingRepository MB_PackingRepository = new MB_PackingRepository();

                List<PckMasterModel> PACKING_BOX_GET_MB = MB_PackingRepository.PACKING_BOX_GET_MB(PckMasterModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = PACKING_BOX_GET_MB;
                _ResponseModel.length = PACKING_BOX_GET_MB.Count();
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

        [Route("v1/PACKING_BOX_CREATE_MB_V1")]
        [HttpPost]
        public ResponseModel PACKING_BOX_CREATE_MB_V1([FromBody] PckBoxModel PckBoxModel)
        {
            try
            {
                MB_PackingRepository MB_PackingRepository = new MB_PackingRepository();

                List<PckBoxModel> PACKING_BOX_CREATE_MB_V1 = MB_PackingRepository.PACKING_BOX_CREATE_MB_V1(PckBoxModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = PACKING_BOX_CREATE_MB_V1;
                _ResponseModel.length = PACKING_BOX_CREATE_MB_V1.Count();
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
        
        [Route("v1/PACKING_BOX_CREATE_MB")]
        [HttpPost]
        public ResponseModel PACKING_BOX_CREATE_MB([FromBody] IEnumerable<PckBoxModel> PckBoxModel)
        {
            try
            {
                ResponseModel _ResponseModel = new ResponseModel();

                MB_PackingRepository MB_PackingRepository = new MB_PackingRepository();

                List<PckBoxModel> ImportDataArrayData = new List<PckBoxModel>();

                int i = 1;

                foreach (var ImportUpdateDataItem in PckBoxModel)
                {
                    PckBoxModel ImportDataArrayModel_data = new PckBoxModel();

                    ImportDataArrayModel_data.ref_id = ImportUpdateDataItem.ref_id;
                    ImportDataArrayModel_data.job_no = ImportUpdateDataItem.job_no;
                    ImportDataArrayModel_data.box_id = ImportUpdateDataItem.box_id;
                    ImportDataArrayModel_data.box_qty = ImportUpdateDataItem.box_qty;
                    ImportDataArrayModel_data.created_by = ImportUpdateDataItem.created_by;
                    //ImportDataArrayModel_data.share_box_trans_id = ImportUpdateDataItem.share_box_trans_id;
                    //ImportDataArrayModel_data.share_ref_box_ref_id = ImportUpdateDataItem.share_ref_box_ref_id;

                    ImportDataArrayData.Add(ImportDataArrayModel_data);

                    i++;
                }

                MB_PackingRepository.PACKING_BOX_CREATE_MB(ImportDataArrayData);

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                //_ResponseModel.data = PACKING_BOX_UPDATE_MB;
                //_ResponseModel.length = PACKING_BOX_UPDATE_MB.Count();
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

        [Route("v1/PACKING_BOX_DETAIL_MB")]
        [HttpGet]
        public ResponseModel PACKING_BOX_DETAIL_MB([FromUri] PckBoxModel PckBoxModel)
        {
            try
            {
                MB_PackingRepository MB_PackingRepository = new MB_PackingRepository();

                List<PckBoxModel> PACKING_BOX_DETAIL_MB = MB_PackingRepository.PACKING_BOX_DETAIL_MB(PckBoxModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = PACKING_BOX_DETAIL_MB;
                _ResponseModel.length = PACKING_BOX_DETAIL_MB.Count();
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

        [Route("v1/PACKING_BOX_UPDATE_MB")]
        [HttpPut]
        public ResponseModel PACKING_BOX_UPDATE_MB([FromBody] IEnumerable<PckBoxModel> PckBoxModel)
        {
            try
            {
                ResponseModel _ResponseModel = new ResponseModel();

                MB_PackingRepository MB_PackingRepository = new MB_PackingRepository();

                List<PckBoxModel> ImportDataArrayData = new List<PckBoxModel>();

                int i = 1;

                foreach (var ImportUpdateDataItem in PckBoxModel)
                {
                    PckBoxModel ImportDataArrayModel_data = new PckBoxModel();

                    ImportDataArrayModel_data.ref_id = ImportUpdateDataItem.ref_id;
                    ImportDataArrayModel_data.job_no = ImportUpdateDataItem.job_no;
                    ImportDataArrayModel_data.box_id = ImportUpdateDataItem.box_id;
                    ImportDataArrayModel_data.box_qty = ImportUpdateDataItem.box_qty;
                    ImportDataArrayModel_data.updated_by = ImportUpdateDataItem.updated_by;

                    ImportDataArrayData.Add(ImportDataArrayModel_data);

                    i++;
                }

                MB_PackingRepository.PACKING_BOX_UPDATE_MB(ImportDataArrayData);

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                //_ResponseModel.data = PACKING_BOX_UPDATE_MB;
                //_ResponseModel.length = PACKING_BOX_UPDATE_MB.Count();
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

        [Route("v1/PACKING_BOX_SUCCESS_MB")]
        [HttpPut]
        public ResponseModel PACKING_BOX_SUCCESS_MB([FromBody] PckBoxModel PckBoxModel)
        {
            try
            {
                MB_PackingRepository MB_PackingRepository = new MB_PackingRepository();

                List<PckBoxModel> PACKING_BOX_SUCCESS_MB = MB_PackingRepository.PACKING_BOX_SUCCESS_MB(PckBoxModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = PACKING_BOX_SUCCESS_MB;
                _ResponseModel.length = PACKING_BOX_SUCCESS_MB.Count();
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

        [Route("v1/PACKING_BOX_DELETE_MB")]
        [HttpDelete]
        public ResponseModel PACKING_BOX_DELETE_MB([FromBody] PckBoxModel PckBoxModel)
        {
            try
            {
                MB_PackingRepository MB_PackingRepository = new MB_PackingRepository();

                List<PckBoxModel> PACKING_BOX_DELETE_MB = MB_PackingRepository.PACKING_BOX_DELETE_MB(PckBoxModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = PACKING_BOX_DELETE_MB;
                _ResponseModel.length = PACKING_BOX_DELETE_MB.Count();
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


        [Route("v1/PACKING_BOX_SHARE_GET_MB")]
        [HttpGet]
        public ResponseModel PACKING_BOX_SHARE_GET_MB([FromUri] PckGetModel PckGetModel)
        {
            try
            {
                MB_PackingRepository MB_PackingRepository = new MB_PackingRepository();

                List<PckGetModel> PACKING_BOX_SHARE_GET_MB = MB_PackingRepository.PACKING_BOX_SHARE_GET_MB(PckGetModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = PACKING_BOX_SHARE_GET_MB;
                _ResponseModel.length = PACKING_BOX_SHARE_GET_MB.Count();
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

        [Route("v1/PACKING_BOX_SHARE_CREATE_MB")]
        [HttpPost]
        public ResponseModel PACKING_BOX_SHARE_CREATE_MB([FromBody] IEnumerable<PckBoxModel> PckBoxModel)
        {
            try
            {
                ResponseModel _ResponseModel = new ResponseModel();

                MB_PackingRepository MB_PackingRepository = new MB_PackingRepository();

                List<PckBoxModel> ImportDataArrayData = new List<PckBoxModel>();

                int i = 1;

                foreach (var ImportUpdateDataItem in PckBoxModel)
                {
                    PckBoxModel ImportDataArrayModel_data = new PckBoxModel();

                    ImportDataArrayModel_data.ref_id = ImportUpdateDataItem.ref_id;
                    ImportDataArrayModel_data.job_no = ImportUpdateDataItem.job_no;
                    ImportDataArrayModel_data.box_id = ImportUpdateDataItem.box_id;
                    ImportDataArrayModel_data.box_qty = ImportUpdateDataItem.box_qty;
                    ImportDataArrayModel_data.created_by = ImportUpdateDataItem.created_by;
                    ImportDataArrayModel_data.share_box_trans_id = ImportUpdateDataItem.share_box_trans_id;
                    ImportDataArrayModel_data.share_ref_box_ref_id = ImportUpdateDataItem.share_ref_box_ref_id;

                    ImportDataArrayData.Add(ImportDataArrayModel_data);

                    i++;
                }

                MB_PackingRepository.PACKING_BOX_SHARE_CREATE_MB(ImportDataArrayData);

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                //_ResponseModel.data = PACKING_BOX_UPDATE_MB;
                //_ResponseModel.length = PACKING_BOX_UPDATE_MB.Count();
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


        [Route("v1/PACKING_REMARK_LIST_MB")]
        [HttpGet]
        public ResponseModel PACKING_REMARK_LIST_MB([FromUri] PckRemarkModel PckRemarkModel)
        {
            try
            {
                MB_PackingRepository MB_PackingRepository = new MB_PackingRepository();

                List<PckRemarkModel> PACKING_REMARK_LIST_MB = MB_PackingRepository.PACKING_REMARK_LIST_MB(PckRemarkModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = PACKING_REMARK_LIST_MB;
                _ResponseModel.length = PACKING_REMARK_LIST_MB.Count();
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

        [Route("v1/PACKING_REMARK_CREATE_MB")]
        [HttpPost]
        public ResponseModel PACKING_REMARK_CREATE_MB([FromBody] PckRemarkModel PckRemarkModel)
        {
            try
            {
                MB_PackingRepository MB_PackingRepository = new MB_PackingRepository();

                List<PckRemarkModel> PACKING_REMARK_CREATE_MB = MB_PackingRepository.PACKING_REMARK_CREATE_MB(PckRemarkModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = PACKING_REMARK_CREATE_MB;
                _ResponseModel.length = PACKING_REMARK_CREATE_MB.Count();
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

        [Route("v1/PACKING_REMARK_DELETE_MB")]
        [HttpDelete]
        public ResponseModel PACKING_REMARK_DELETE_MB([FromBody] PckRemarkModel PckRemarkModel)
        {
            try
            {
                MB_PackingRepository MB_PackingRepository = new MB_PackingRepository();

                List<PckRemarkModel> PACKING_REMARK_DELETE_MB = MB_PackingRepository.PACKING_REMARK_DELETE_MB(PckRemarkModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = PACKING_REMARK_DELETE_MB;
                _ResponseModel.length = PACKING_REMARK_DELETE_MB.Count();
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


        [Route("v1/PACKING_LOADING_CHECK_MB")]
        [HttpGet]
        public ResponseModel PACKING_LOADING_CHECK_MB([FromUri] PckLoadingModel PckLoadingModel)
        {
            try
            {
                MB_PackingRepository MB_PackingRepository = new MB_PackingRepository();

                List<PckLoadingModel> PACKING_LOADING_CHECK_MB = MB_PackingRepository.PACKING_LOADING_CHECK_MB(PckLoadingModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = PACKING_LOADING_CHECK_MB;
                _ResponseModel.length = PACKING_LOADING_CHECK_MB.Count();
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

        [Route("v1/PACKING_LOADING_GET_MB")]
        [HttpGet]
        public ResponseModel PACKING_LOADING_GET_MB([FromUri] PckLoadingModel PckLoadingModel)
        {
            try
            {
                MB_PackingRepository MB_PackingRepository = new MB_PackingRepository();

                List<PckLoadingModel> PACKING_LOADING_GET_MB = MB_PackingRepository.PACKING_LOADING_GET_MB(PckLoadingModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = PACKING_LOADING_GET_MB;
                _ResponseModel.length = PACKING_LOADING_GET_MB.Count();
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

        [Route("v1/PACKING_LOADING_CREATE_MB")]
        [HttpPost]
        public ResponseModel PACKING_LOADING_CREATE_MB([FromBody] PckLoadingModel PckLoadingModel)
        {
            try
            {
                MB_PackingRepository MB_PackingRepository = new MB_PackingRepository();

                List<PckLoadingModel> PACKING_LOADING_CREATE_MB = MB_PackingRepository.PACKING_LOADING_CREATE_MB(PckLoadingModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = PACKING_LOADING_CREATE_MB;
                _ResponseModel.length = PACKING_LOADING_CREATE_MB.Count();
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

        [Route("v1/PACKING_LOADING_TMS_LIST_MB")]
        [HttpGet]
        public ResponseModel PACKING_LOADING_TMS_LIST_MB([FromUri] PckLoadingModel PckLoadingModel)
        {
            try
            {
                MB_PackingRepository MB_PackingRepository = new MB_PackingRepository();

                List<PckLoadingModel> PACKING_LOADING_TMS_LIST_MB = MB_PackingRepository.PACKING_LOADING_TMS_LIST_MB(PckLoadingModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = PACKING_LOADING_TMS_LIST_MB;
                _ResponseModel.length = PACKING_LOADING_TMS_LIST_MB.Count();
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

        [Route("v1/PACKING_LOADING_UPDATE_MB")]
        [HttpPut]
        public ResponseModel PACKING_LOADING_UPDATE_MB([FromBody] PckLoadingModel PckLoadingModel)
        {
            try
            {
                MB_PackingRepository MB_PackingRepository = new MB_PackingRepository();

                List<PckLoadingModel> PACKING_LOADING_UPDATE_MB = MB_PackingRepository.PACKING_LOADING_UPDATE_MB(PckLoadingModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = PACKING_LOADING_UPDATE_MB;
                _ResponseModel.length = PACKING_LOADING_UPDATE_MB.Count();
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

        [Route("v1/PACKING_LOADING_DELETE_MB")]
        [HttpDelete]
        public ResponseModel PACKING_LOADING_DELETE_MB([FromBody] PckLoadingModel PckLoadingModel)
        {
            try
            {
                MB_PackingRepository MB_PackingRepository = new MB_PackingRepository();

                List<PckLoadingModel> PACKING_LOADING_DELETE_MB = MB_PackingRepository.PACKING_LOADING_DELETE_MB(PckLoadingModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = PACKING_LOADING_DELETE_MB;
                _ResponseModel.length = PACKING_LOADING_DELETE_MB.Count();
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

        [Route("v1/PACKING_LOADING_LIST_MB")]
        [HttpGet]
        public ResponseModel PACKING_LOADING_LIST_MB([FromUri] PckLoadingModel PckLoadingModel)
        {
            try
            {
                MB_PackingRepository MB_PackingRepository = new MB_PackingRepository();

                List<PckLoadingModel> PACKING_LOADING_LIST_MB = MB_PackingRepository.PACKING_LOADING_LIST_MB(PckLoadingModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = PACKING_LOADING_LIST_MB;
                _ResponseModel.length = PACKING_LOADING_LIST_MB.Count();
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

        [Route("v1/PACKING_TMS_GET_MB")]
        [HttpGet]
        public ResponseModel PACKING_TMS_GET_MB([FromUri] PckLoadingModel PckLoadingModel)
        {
            try
            {
                MB_PackingRepository MB_PackingRepository = new MB_PackingRepository();

                List<PckLoadingModel> PACKING_TMS_GET_MB = MB_PackingRepository.PACKING_TMS_GET_MB(PckLoadingModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = PACKING_TMS_GET_MB;
                _ResponseModel.length = PACKING_TMS_GET_MB.Count();
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

        [Route("v1/PACKING_LOADING_COVER_SHEET_MB")]
        [HttpGet]
        public ResponseModel PACKING_LOADING_COVER_SHEET_MB([FromUri] PckGetModel PckGetModel)
        {
            try
            {
                MB_PackingRepository MB_PackingRepository = new MB_PackingRepository();

                List<PckGetModel> PACKING_LOADING_COVER_SHEET_MB = MB_PackingRepository.PACKING_LOADING_COVER_SHEET_MB(PckGetModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = PACKING_LOADING_COVER_SHEET_MB;
                _ResponseModel.length = PACKING_LOADING_COVER_SHEET_MB.Count();
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

        [Route("v1/PACKING_LOADING_DELIVERY_LIST_MB")]
        [HttpGet]
        public ResponseModel PACKING_LOADING_DELIVERY_LIST_MB([FromUri] PckLoadingModel PckLoadingModel)
        {
            try
            {
                MB_PackingRepository MB_PackingRepository = new MB_PackingRepository();

                List<PckLoadingModel> PACKING_LOADING_DELIVERY_LIST_MB = MB_PackingRepository.PACKING_LOADING_DELIVERY_LIST_MB(PckLoadingModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = PACKING_LOADING_DELIVERY_LIST_MB;
                _ResponseModel.length = PACKING_LOADING_DELIVERY_LIST_MB.Count();
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


        [Route("v1/PACKING_MASTER")]
        [HttpGet]
        public ResponseModel PACKING_MASTER([FromUri] ResponseSelect2Model ResponseSelect2Model)
        {
            try
            {
                MB_PackingRepository MB_PackingRepository = new MB_PackingRepository();

                List<ResponseSelect2Model> PACKING_MASTER = MB_PackingRepository.PACKING_MASTER(ResponseSelect2Model);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = PACKING_MASTER;
                _ResponseModel.length = PACKING_MASTER.Count();
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
