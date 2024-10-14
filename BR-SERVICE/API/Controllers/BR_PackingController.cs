using REPO.Controllers;
using REPO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace API.Controllers
{
    public class BR_PackingController : ApiController
    {

        [Route("v1/PACKING_LIST_DC")]
        [HttpGet]
        public ResponseModel PACKING_LIST_DC([FromUri] PbrGetModel PbrGetModel)
        {
            try
            {
                BR_PackingRepository BR_PackingRepository = new BR_PackingRepository();

                List<PbrGetModel> PACKING_LIST_DC = BR_PackingRepository.PACKING_LIST_DC(PbrGetModel);

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
        public ResponseModel PACKING_TACKING_DC([FromUri] PbrGetModel PbrGetModel)
        {
            try
            {
                BR_PackingRepository BR_PackingRepository = new BR_PackingRepository();

                List<PbrGetModel> PACKING_TACKING_DC = BR_PackingRepository.PACKING_TACKING_DC(PbrGetModel);

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


        [Route("v1/PACKING_LIST_BR")]
        [HttpGet]
        public ResponseModel PACKING_LIST_BR([FromUri] PbrGetModel PbrGetModel)
        {
            try
            {
                BR_PackingRepository BR_PackingRepository = new BR_PackingRepository();

                List<PbrGetModel> PACKING_LIST_BR = BR_PackingRepository.PACKING_LIST_BR(PbrGetModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = PACKING_LIST_BR;
                _ResponseModel.length = PACKING_LIST_BR.Count();
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

        [Route("v1/PACKING_TACKING_BR")]
        [HttpGet]
        public ResponseModel PACKING_TACKING_BR([FromUri] PbrGetModel PbrGetModel)
        {
            try
            {
                BR_PackingRepository BR_PackingRepository = new BR_PackingRepository();

                List<PbrGetModel> PACKING_TACKING_BR = BR_PackingRepository.PACKING_TACKING_BR(PbrGetModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = PACKING_TACKING_BR;
                _ResponseModel.length = PACKING_TACKING_BR.Count();
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



        [Route("v1/PACKING_CHECK_JOB_BR")]
        [HttpGet]
        public ResponseModel PACKING_CHECK_JOB_BR([FromUri] PbrInputModel PbrInputModel)
        {
            try
            {
                BR_PackingRepository BR_PackingRepository = new BR_PackingRepository();

                List<PbrGetModel> PACKING_CHECK_JOB_BR = BR_PackingRepository.PACKING_CHECK_JOB_BR(PbrInputModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = PACKING_CHECK_JOB_BR;
                _ResponseModel.length = PACKING_CHECK_JOB_BR.Count();
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

        [Route("v1/PACKING_CHECK_INVOICE_BR")]
        [HttpGet]
        public ResponseModel PACKING_CHECK_INVOICE_BR([FromUri] PbrInputModel PbrInputModel)
        {
            try
            {
                BR_PackingRepository BR_PackingRepository = new BR_PackingRepository();

                List<PbrGetModel> PACKING_CHECK_INVOICE_BR = BR_PackingRepository.PACKING_CHECK_INVOICE_BR(PbrInputModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = PACKING_CHECK_INVOICE_BR;
                _ResponseModel.length = PACKING_CHECK_INVOICE_BR.Count();
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

        [Route("v1/PACKING_CHECK_ADDRESS_BR")]
        [HttpGet]
        public ResponseModel PACKING_CHECK_ADDRESS_BR([FromUri] PbrInputModel PbrInputModel)
        {
            try
            {
                BR_PackingRepository BR_PackingRepository = new BR_PackingRepository();

                List<PbrCheckAddrModel> PACKING_CHECK_ADDRESS_BR = BR_PackingRepository.PACKING_CHECK_ADDRESS_BR(PbrInputModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = PACKING_CHECK_ADDRESS_BR;
                _ResponseModel.length = PACKING_CHECK_ADDRESS_BR.Count();
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

        [Route("v1/PACKING_INVOICE_DELIVERY_ADDRESS_GET_BR")]
        [HttpGet]
        public ResponseModel PACKING_INVOICE_DELIVERY_ADDRESS_GET_BR([FromUri] PbrInputModel PbrInputModel)
        {
            try
            {
                BR_PackingRepository BR_PackingRepository = new BR_PackingRepository();

                List<PbrGetModel> PACKING_INVOICE_DELIVERY_ADDRESS_GET_BR = BR_PackingRepository.PACKING_INVOICE_DELIVERY_ADDRESS_GET_BR(PbrInputModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = PACKING_INVOICE_DELIVERY_ADDRESS_GET_BR;
                _ResponseModel.length = PACKING_INVOICE_DELIVERY_ADDRESS_GET_BR.Count();
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

        [Route("v1/PACKING_TRP_VENDOR_GET_BR")]
        [HttpGet]
        public ResponseModel PACKING_TRP_VENDOR_GET_BR([FromUri] PbrInputModel PbrInputModel)
        {
            try
            {
                BR_PackingRepository BR_PackingRepository = new BR_PackingRepository();

                List<PbrGetModel> PACKING_TRP_VENDOR_GET_BR = BR_PackingRepository.PACKING_TRP_VENDOR_GET_BR(PbrInputModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = PACKING_TRP_VENDOR_GET_BR;
                _ResponseModel.length = PACKING_TRP_VENDOR_GET_BR.Count();
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


        [Route("v1/PACKING_JOB_CREATE_BR")]
        [HttpPost]
        public ResponseModel PACKING_JOB_CREATE_BR([FromBody] PbrDataModel PbrDataModel)
        {
            try
            {
                BR_PackingRepository BR_PackingRepository = new BR_PackingRepository();

                List<PbrDataModel> PACKING_JOB_CREATE_BR = BR_PackingRepository.PACKING_JOB_CREATE_BR(PbrDataModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = PACKING_JOB_CREATE_BR;
                _ResponseModel.length = PACKING_JOB_CREATE_BR.Count();
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

        [Route("v1/PACKING_JOB_DETAIL_BR")]
        [HttpGet]
        public ResponseModel PACKING_JOB_DETAIL_BR([FromUri] PbrInputModel PbrInputModel)
        {
            try
            {
                BR_PackingRepository BR_PackingRepository = new BR_PackingRepository();

                List<PbrGetModel> PACKING_JOB_DETAIL_BR = BR_PackingRepository.PACKING_JOB_DETAIL_BR(PbrInputModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = PACKING_JOB_DETAIL_BR;
                _ResponseModel.length = PACKING_JOB_DETAIL_BR.Count();
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

        [Route("v1/PACKING_JOB_DELETE_BR")]
        [HttpDelete]
        public ResponseModel PACKING_JOB_DELETE_BR([FromBody] PbrGetModel PbrGetModel)
        {
            try
            {
                BR_PackingRepository BR_PackingRepository = new BR_PackingRepository();

                List<PbrGetModel> PACKING_JOB_DELETE_BR = BR_PackingRepository.PACKING_JOB_DELETE_BR(PbrGetModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = PACKING_JOB_DELETE_BR;
                _ResponseModel.length = PACKING_JOB_DELETE_BR.Count();
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

        [Route("v1/PACKING_JOB_SUCCESS_BR")]
        [HttpPut]
        public ResponseModel PACKING_JOB_SUCCESS_BR([FromBody] PbrDataModel PbrDataModel)
        {
            try
            {
                BR_PackingRepository BR_PackingRepository = new BR_PackingRepository();

                List<PbrDataModel> PACKING_JOB_SUCCESS_BR = BR_PackingRepository.PACKING_JOB_SUCCESS_BR(PbrDataModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = PACKING_JOB_SUCCESS_BR;
                _ResponseModel.length = PACKING_JOB_SUCCESS_BR.Count();
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


        [Route("v1/PACKING_JOB_PAYMENT_TYPE_UPDATE_BR")]
        [HttpPut]
        public ResponseModel PACKING_JOB_PAYMENT_TYPE_UPDATE_BR([FromBody] PbrDataModel PbrDataModel)
        {
            try
            {
                BR_PackingRepository BR_PackingRepository = new BR_PackingRepository();

                List<PbrDataModel> PACKING_JOB_PAYMENT_TYPE_UPDATE_BR = BR_PackingRepository.PACKING_JOB_PAYMENT_TYPE_UPDATE_BR(PbrDataModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = PACKING_JOB_PAYMENT_TYPE_UPDATE_BR;
                _ResponseModel.length = PACKING_JOB_PAYMENT_TYPE_UPDATE_BR.Count();
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

        [Route("v1/PACKING_JOB_TRANSPORT_COMPANY_UPDATE_BR")]
        [HttpPut]
        public ResponseModel PACKING_JOB_TRANSPORT_COMPANY_UPDATE_BR([FromBody] PbrDataModel PbrDataModel)
        {
            try
            {
                BR_PackingRepository BR_PackingRepository = new BR_PackingRepository();

                List<PbrDataModel> PACKING_JOB_TRANSPORT_COMPANY_UPDATE_BR = BR_PackingRepository.PACKING_JOB_TRANSPORT_COMPANY_UPDATE_BR(PbrDataModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = PACKING_JOB_TRANSPORT_COMPANY_UPDATE_BR;
                _ResponseModel.length = PACKING_JOB_TRANSPORT_COMPANY_UPDATE_BR.Count();
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

        [Route("v1/PACKING_JOB_INFORMATION_STATUS_UPDATE_BR")]
        [HttpPut]
        public ResponseModel PACKING_JOB_INFORMATION_STATUS_UPDATE_BR([FromBody] PbrDataModel PbrDataModel)
        {
            try
            {
                BR_PackingRepository BR_PackingRepository = new BR_PackingRepository();

                List<PbrDataModel> PACKING_JOB_INFORMATION_STATUS_UPDATE_BR = BR_PackingRepository.PACKING_JOB_INFORMATION_STATUS_UPDATE_BR(PbrDataModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = PACKING_JOB_INFORMATION_STATUS_UPDATE_BR;
                _ResponseModel.length = PACKING_JOB_INFORMATION_STATUS_UPDATE_BR.Count();
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


        [Route("v1/PACKING_INVOICE_CREATE_BR")]
        [HttpPost]
        public ResponseModel PACKING_INVOICE_CREATE_BR([FromBody] PbrInvModel PbrInvModel)
        {
            try
            {
                BR_PackingRepository BR_PackingRepository = new BR_PackingRepository();

                List<PbrInvModel> PACKING_INVOICE_CREATE_BR = BR_PackingRepository.PACKING_INVOICE_CREATE_BR(PbrInvModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = PACKING_INVOICE_CREATE_BR;
                _ResponseModel.length = PACKING_INVOICE_CREATE_BR.Count();
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

        [Route("v1/PACKING_INVOICE_LIST_BR")]
        [HttpGet]
        public ResponseModel PACKING_INVOICE_LIST_BR([FromUri] PbrInvModel PbrInvModel)
        {
            try
            {
                BR_PackingRepository BR_PackingRepository = new BR_PackingRepository();

                List<PbrInvModel> PACKING_INVOICE_LIST_BR = BR_PackingRepository.PACKING_INVOICE_LIST_BR(PbrInvModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = PACKING_INVOICE_LIST_BR;
                _ResponseModel.length = PACKING_INVOICE_LIST_BR.Count();
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

        [Route("v1/PACKING_INVOICE_VERIFY_BR")]
        [HttpPut]
        public ResponseModel PACKING_INVOICE_VERIFY_BR([FromBody] PbrInvModel PbrInvModel)
        {
            try
            {
                BR_PackingRepository BR_PackingRepository = new BR_PackingRepository();

                List<PbrInvModel> PACKING_INVOICE_VERIFY_BR = BR_PackingRepository.PACKING_INVOICE_VERIFY_BR(PbrInvModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = PACKING_INVOICE_VERIFY_BR;
                _ResponseModel.length = PACKING_INVOICE_VERIFY_BR.Count();
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

        [Route("v1/PACKING_INVOICE_DELETE_BR")]
        [HttpDelete]
        public ResponseModel PACKING_INVOICE_DELETE_BR([FromBody] PbrInvModel PbrInvModel)
        {
            try
            {
                BR_PackingRepository BR_PackingRepository = new BR_PackingRepository();

                List<PbrInvModel> PACKING_INVOICE_DELETE_BR = BR_PackingRepository.PACKING_INVOICE_DELETE_BR(PbrInvModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = PACKING_INVOICE_DELETE_BR;
                _ResponseModel.length = PACKING_INVOICE_DELETE_BR.Count();
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

        [Route("v1/PACKING_INVOICE_CHANGE_BR")]
        [HttpPut]
        public ResponseModel PACKING_INVOICE_CHANGE_BR([FromBody] PbrInvModel PbrInvModel)
        {
            try
            {
                BR_PackingRepository BR_PackingRepository = new BR_PackingRepository();

                List<PbrInvModel> PACKING_INVOICE_CHANGE_BR = BR_PackingRepository.PACKING_INVOICE_CHANGE_BR(PbrInvModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = PACKING_INVOICE_CHANGE_BR;
                _ResponseModel.length = PACKING_INVOICE_CHANGE_BR.Count();
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


        [Route("v1/PACKING_ITEM_CREATE_BR")]
        [HttpPost]
        public ResponseModel PACKING_ITEM_CREATE_BR([FromBody] PbrItemModel PbrItemModel)
        {
            try
            {
                BR_PackingRepository BR_PackingRepository = new BR_PackingRepository();

                List<PbrItemModel> PACKING_ITEM_CREATE_BR = BR_PackingRepository.PACKING_ITEM_CREATE_BR(PbrItemModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = PACKING_ITEM_CREATE_BR;
                _ResponseModel.length = PACKING_ITEM_CREATE_BR.Count();
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

        [Route("v1/PACKING_ITEM_GET_BR")]
        [HttpGet]
        public ResponseModel PACKING_ITEM_GET_BR([FromUri] PbrItemModel PbrItemModel)
        {
            try
            {
                BR_PackingRepository BR_PackingRepository = new BR_PackingRepository();

                List<PbrItemModel> PACKING_ITEM_GET_BR = BR_PackingRepository.PACKING_ITEM_GET_BR(PbrItemModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = PACKING_ITEM_GET_BR;
                _ResponseModel.length = PACKING_ITEM_GET_BR.Count();
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

        [Route("v1/PACKING_ITEM_DETAIL_BR")]
        [HttpGet]
        public ResponseModel PACKING_ITEM_DETAIL_BR([FromUri] PbrItemModel PbrItemModel)
        {
            try
            {
                BR_PackingRepository BR_PackingRepository = new BR_PackingRepository();

                List<PbrItemModel> PACKING_ITEM_DETAIL_BR = BR_PackingRepository.PACKING_ITEM_DETAIL_BR(PbrItemModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = PACKING_ITEM_DETAIL_BR;
                _ResponseModel.length = PACKING_ITEM_DETAIL_BR.Count();
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

        [Route("v1/PACKING_ITEM_COUNT_BR")]
        [HttpGet]
        public ResponseModel PACKING_ITEM_COUNT_BR([FromUri] PbrItemModel PbrItemModel)
        {
            try
            {
                BR_PackingRepository BR_PackingRepository = new BR_PackingRepository();

                List<PbrItemModel> PACKING_ITEM_COUNT_BR = BR_PackingRepository.PACKING_ITEM_COUNT_BR(PbrItemModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = PACKING_ITEM_COUNT_BR;
                _ResponseModel.length = PACKING_ITEM_COUNT_BR.Count();
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

        [Route("v1/PACKING_ITEM_UPDATE_BR")]
        [HttpPut]
        public ResponseModel PACKING_ITEM_UPDATE_BR([FromBody] PbrItemModel PbrItemModel)
        {
            try
            {
                BR_PackingRepository BR_PackingRepository = new BR_PackingRepository();

                List<PbrItemModel> PACKING_ITEM_UPDATE_BR = BR_PackingRepository.PACKING_ITEM_UPDATE_BR(PbrItemModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = PACKING_ITEM_UPDATE_BR;
                _ResponseModel.length = PACKING_ITEM_UPDATE_BR.Count();
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

        [Route("v1/PACKING_ITEM_SUCCESS_BR")]
        [HttpPut]
        public ResponseModel PACKING_ITEM_SUCCESS_BR([FromBody] PbrItemModel PbrItemModel)
        {
            try
            {
                BR_PackingRepository BR_PackingRepository = new BR_PackingRepository();

                List<PbrItemModel> PACKING_ITEM_SUCCESS_BR = BR_PackingRepository.PACKING_ITEM_SUCCESS_BR(PbrItemModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = PACKING_ITEM_SUCCESS_BR;
                _ResponseModel.length = PACKING_ITEM_SUCCESS_BR.Count();
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


        [Route("v1/PACKING_BOX_GET_BR")]
        [HttpGet]
        public ResponseModel PACKING_BOX_GET_BR([FromUri] PbrMasterModel PbrMasterModel)
        {
            try
            {
                BR_PackingRepository BR_PackingRepository = new BR_PackingRepository();

                List<PbrMasterModel> PACKING_BOX_GET_BR = BR_PackingRepository.PACKING_BOX_GET_BR(PbrMasterModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = PACKING_BOX_GET_BR;
                _ResponseModel.length = PACKING_BOX_GET_BR.Count();
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

        [Route("v1/PACKING_BOX_CREATE_BR_V1")]
        [HttpPost]
        public ResponseModel PACKING_BOX_CREATE_BR_V1([FromBody] PbrBoxModel PbrBoxModel)
        {
            try
            {
                BR_PackingRepository BR_PackingRepository = new BR_PackingRepository();

                List<PbrBoxModel> PACKING_BOX_CREATE_BR_V1 = BR_PackingRepository.PACKING_BOX_CREATE_BR_V1(PbrBoxModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = PACKING_BOX_CREATE_BR_V1;
                _ResponseModel.length = PACKING_BOX_CREATE_BR_V1.Count();
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

        [Route("v1/PACKING_BOX_CREATE_BR")]
        [HttpPost]
        public ResponseModel PACKING_BOX_CREATE_BR([FromBody] IEnumerable<PbrBoxModel> PbrBoxModel)
        {
            try
            {
                ResponseModel _ResponseModel = new ResponseModel();

                BR_PackingRepository BR_PackingRepository = new BR_PackingRepository();

                List<PbrBoxModel> ImportDataArrayData = new List<PbrBoxModel>();

                int i = 1;

                foreach (var ImportUpdateDataItem in PbrBoxModel)
                {
                    PbrBoxModel ImportDataArrayModel_data = new PbrBoxModel();

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

                BR_PackingRepository.PACKING_BOX_CREATE_BR(ImportDataArrayData);

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                //_ResponseModel.data = PACKING_BOX_UPDATE_BR;
                //_ResponseModel.length = PACKING_BOX_UPDATE_BR.Count();
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

        [Route("v1/PACKING_BOX_DETAIL_BR")]
        [HttpGet]
        public ResponseModel PACKING_BOX_DETAIL_BR([FromUri] PbrBoxModel PbrBoxModel)
        {
            try
            {
                BR_PackingRepository BR_PackingRepository = new BR_PackingRepository();

                List<PbrBoxModel> PACKING_BOX_DETAIL_BR = BR_PackingRepository.PACKING_BOX_DETAIL_BR(PbrBoxModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = PACKING_BOX_DETAIL_BR;
                _ResponseModel.length = PACKING_BOX_DETAIL_BR.Count();
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

        [Route("v1/PACKING_BOX_UPDATE_BR")]
        [HttpPut]
        public ResponseModel PACKING_BOX_UPDATE_BR([FromBody] IEnumerable<PbrBoxModel> PbrBoxModel)
        {
            try
            {
                ResponseModel _ResponseModel = new ResponseModel();

                BR_PackingRepository BR_PackingRepository = new BR_PackingRepository();

                List<PbrBoxModel> ImportDataArrayData = new List<PbrBoxModel>();

                int i = 1;

                foreach (var ImportUpdateDataItem in PbrBoxModel)
                {
                    PbrBoxModel ImportDataArrayModel_data = new PbrBoxModel();

                    ImportDataArrayModel_data.ref_id = ImportUpdateDataItem.ref_id;
                    ImportDataArrayModel_data.job_no = ImportUpdateDataItem.job_no;
                    ImportDataArrayModel_data.box_id = ImportUpdateDataItem.box_id;
                    ImportDataArrayModel_data.box_qty = ImportUpdateDataItem.box_qty;
                    ImportDataArrayModel_data.updated_by = ImportUpdateDataItem.updated_by;

                    ImportDataArrayData.Add(ImportDataArrayModel_data);

                    i++;
                }

                BR_PackingRepository.PACKING_BOX_UPDATE_BR(ImportDataArrayData);

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                //_ResponseModel.data = PACKING_BOX_UPDATE_BR;
                //_ResponseModel.length = PACKING_BOX_UPDATE_BR.Count();
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

        [Route("v1/PACKING_BOX_SUCCESS_BR")]
        [HttpPut]
        public ResponseModel PACKING_BOX_SUCCESS_BR([FromBody] PbrBoxModel PbrBoxModel)
        {
            try
            {
                BR_PackingRepository BR_PackingRepository = new BR_PackingRepository();

                List<PbrBoxModel> PACKING_BOX_SUCCESS_BR = BR_PackingRepository.PACKING_BOX_SUCCESS_BR(PbrBoxModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = PACKING_BOX_SUCCESS_BR;
                _ResponseModel.length = PACKING_BOX_SUCCESS_BR.Count();
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

        [Route("v1/PACKING_BOX_DELETE_BR")]
        [HttpDelete]
        public ResponseModel PACKING_BOX_DELETE_BR([FromBody] PbrBoxModel PbrBoxModel)
        {
            try
            {
                BR_PackingRepository BR_PackingRepository = new BR_PackingRepository();

                List<PbrBoxModel> PACKING_BOX_DELETE_BR = BR_PackingRepository.PACKING_BOX_DELETE_BR(PbrBoxModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = PACKING_BOX_DELETE_BR;
                _ResponseModel.length = PACKING_BOX_DELETE_BR.Count();
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


        [Route("v1/PACKING_BOX_SHARE_GET_BR")]
        [HttpGet]
        public ResponseModel PACKING_BOX_SHARE_GET_BR([FromUri] PbrGetModel PbrGetModel)
        {
            try
            {
                BR_PackingRepository BR_PackingRepository = new BR_PackingRepository();

                List<PbrGetModel> PACKING_BOX_SHARE_GET_BR = BR_PackingRepository.PACKING_BOX_SHARE_GET_BR(PbrGetModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = PACKING_BOX_SHARE_GET_BR;
                _ResponseModel.length = PACKING_BOX_SHARE_GET_BR.Count();
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

        [Route("v1/PACKING_BOX_SHARE_CREATE_BR")]
        [HttpPost]
        public ResponseModel PACKING_BOX_SHARE_CREATE_BR([FromBody] IEnumerable<PbrBoxModel> PbrBoxModel)
        {
            try
            {
                ResponseModel _ResponseModel = new ResponseModel();

                BR_PackingRepository BR_PackingRepository = new BR_PackingRepository();

                List<PbrBoxModel> ImportDataArrayData = new List<PbrBoxModel>();

                int i = 1;

                foreach (var ImportUpdateDataItem in PbrBoxModel)
                {
                    PbrBoxModel ImportDataArrayModel_data = new PbrBoxModel();

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

                BR_PackingRepository.PACKING_BOX_SHARE_CREATE_BR(ImportDataArrayData);

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                //_ResponseModel.data = PACKING_BOX_UPDATE_BR;
                //_ResponseModel.length = PACKING_BOX_UPDATE_BR.Count();
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


        [Route("v1/PACKING_BATCH_NO_GET_BR")]
        [HttpGet]
        public ResponseModel PACKING_BATCH_NO_GET_BR([FromUri] PbrBatchModel PbrBatchModel)
        {
            try
            {
                BR_PackingRepository BR_PackingRepository = new BR_PackingRepository();

                List<PbrBatchModel> PACKING_BATCH_NO_GET_BR = BR_PackingRepository.PACKING_BATCH_NO_GET_BR(PbrBatchModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = PACKING_BATCH_NO_GET_BR;
                _ResponseModel.length = PACKING_BATCH_NO_GET_BR.Count();
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

        [Route("v1/PACKING_BATCH_LIST_BR")]
        [HttpGet]
        public ResponseModel PACKING_BATCH_LIST_BR([FromUri] PbrBatchModel PbrBatchModel)
        {
            try
            {
                BR_PackingRepository BR_PackingRepository = new BR_PackingRepository();

                List<PbrBatchModel> PACKING_BATCH_LIST_BR = BR_PackingRepository.PACKING_BATCH_LIST_BR(PbrBatchModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = PACKING_BATCH_LIST_BR;
                _ResponseModel.length = PACKING_BATCH_LIST_BR.Count();
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

        [Route("v1/PACKING_BATCH_UPDATE_BR")]
        [HttpPut]
        public ResponseModel PACKING_BATCH_UPDATE_BR([FromBody] PbrBatchModel PbrBatchModel)
        {
            try
            {
                BR_PackingRepository BR_PackingRepository = new BR_PackingRepository();

                List<PbrBatchModel> PACKING_BATCH_UPDATE_BR = BR_PackingRepository.PACKING_BATCH_UPDATE_BR(PbrBatchModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = PACKING_BATCH_UPDATE_BR;
                _ResponseModel.length = PACKING_BATCH_UPDATE_BR.Count();
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

        [Route("v1/PACKING_BATCH_DELETE_BR")]
        [HttpDelete]
        public ResponseModel PACKING_BATCH_DELETE_BR([FromBody] PbrBatchModel PbrBatchModel)
        {
            try
            {
                BR_PackingRepository BR_PackingRepository = new BR_PackingRepository();

                List<PbrBatchModel> PACKING_BATCH_DELETE_BR = BR_PackingRepository.PACKING_BATCH_DELETE_BR(PbrBatchModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = PACKING_BATCH_DELETE_BR;
                _ResponseModel.length = PACKING_BATCH_DELETE_BR.Count();
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


        [Route("v1/PACKING_SHIPPING_NOTE_BR")]
        [HttpGet]
        public ResponseModel PACKING_SHIPPING_NOTE_BR([FromUri] PbrInputModel PbrInputModel)
        {
            try
            {
                BR_PackingRepository BR_PackingRepository = new BR_PackingRepository();

                List<PbrGetModel> PACKING_SHIPPING_NOTE_BR = BR_PackingRepository.PACKING_SHIPPING_NOTE_BR(PbrInputModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = PACKING_SHIPPING_NOTE_BR;
                _ResponseModel.length = PACKING_SHIPPING_NOTE_BR.Count();
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


        [Route("v1/PACKING_REMARK_LIST_BR")]
        [HttpGet]
        public ResponseModel PACKING_REMARK_LIST_BR([FromUri] PbrRemarkModel PbrRemarkModel)
        {
            try
            {
                BR_PackingRepository BR_PackingRepository = new BR_PackingRepository();

                List<PbrRemarkModel> PACKING_REMARK_LIST_BR = BR_PackingRepository.PACKING_REMARK_LIST_BR(PbrRemarkModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = PACKING_REMARK_LIST_BR;
                _ResponseModel.length = PACKING_REMARK_LIST_BR.Count();
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

        [Route("v1/PACKING_REMARK_CREATE_BR")]
        [HttpPost]
        public ResponseModel PACKING_REMARK_CREATE_BR([FromBody] PbrRemarkModel PbrRemarkModel)
        {
            try
            {
                BR_PackingRepository BR_PackingRepository = new BR_PackingRepository();

                List<PbrRemarkModel> PACKING_REMARK_CREATE_BR = BR_PackingRepository.PACKING_REMARK_CREATE_BR(PbrRemarkModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = PACKING_REMARK_CREATE_BR;
                _ResponseModel.length = PACKING_REMARK_CREATE_BR.Count();
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

        [Route("v1/PACKING_REMARK_DELETE_BR")]
        [HttpDelete]
        public ResponseModel PACKING_REMARK_DELETE_BR([FromBody] PbrRemarkModel PbrRemarkModel)
        {
            try
            {
                BR_PackingRepository BR_PackingRepository = new BR_PackingRepository();

                List<PbrRemarkModel> PACKING_REMARK_DELETE_BR = BR_PackingRepository.PACKING_REMARK_DELETE_BR(PbrRemarkModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = PACKING_REMARK_DELETE_BR;
                _ResponseModel.length = PACKING_REMARK_DELETE_BR.Count();
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


        [Route("v1/PACKING_LOADING_CHECK_BR")]
        [HttpGet]
        public ResponseModel PACKING_LOADING_CHECK_BR([FromUri] PbrLoadingModel PbrLoadingModel)
        {
            try
            {
                BR_PackingRepository BR_PackingRepository = new BR_PackingRepository();

                List<PbrLoadingModel> PACKING_LOADING_CHECK_BR = BR_PackingRepository.PACKING_LOADING_CHECK_BR(PbrLoadingModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = PACKING_LOADING_CHECK_BR;
                _ResponseModel.length = PACKING_LOADING_CHECK_BR.Count();
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

        [Route("v1/PACKING_LOADING_GET_BR")]
        [HttpGet]
        public ResponseModel PACKING_LOADING_GET_BR([FromUri] PbrLoadingModel PbrLoadingModel)
        {
            try
            {
                BR_PackingRepository BR_PackingRepository = new BR_PackingRepository();

                List<PbrLoadingModel> PACKING_LOADING_GET_BR = BR_PackingRepository.PACKING_LOADING_GET_BR(PbrLoadingModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = PACKING_LOADING_GET_BR;
                _ResponseModel.length = PACKING_LOADING_GET_BR.Count();
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

        [Route("v1/PACKING_LOADING_CREATE_BR")]
        [HttpPost]
        public ResponseModel PACKING_LOADING_CREATE_BR([FromBody] PbrLoadingModel PbrLoadingModel)
        {
            try
            {
                BR_PackingRepository BR_PackingRepository = new BR_PackingRepository();

                List<PbrLoadingModel> PACKING_LOADING_CREATE_BR = BR_PackingRepository.PACKING_LOADING_CREATE_BR(PbrLoadingModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = PACKING_LOADING_CREATE_BR;
                _ResponseModel.length = PACKING_LOADING_CREATE_BR.Count();
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

        [Route("v1/PACKING_LOADING_TMS_LIST_BR")]
        [HttpGet]
        public ResponseModel PACKING_LOADING_TMS_LIST_BR([FromUri] PbrLoadingModel PbrLoadingModel)
        {
            try
            {
                BR_PackingRepository BR_PackingRepository = new BR_PackingRepository();

                List<PbrLoadingModel> PACKING_LOADING_TMS_LIST_BR = BR_PackingRepository.PACKING_LOADING_TMS_LIST_BR(PbrLoadingModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = PACKING_LOADING_TMS_LIST_BR;
                _ResponseModel.length = PACKING_LOADING_TMS_LIST_BR.Count();
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

        [Route("v1/PACKING_LOADING_UPDATE_BR")]
        [HttpPut]
        public ResponseModel PACKING_LOADING_UPDATE_BR([FromBody] PbrLoadingModel PbrLoadingModel)
        {
            try
            {
                BR_PackingRepository BR_PackingRepository = new BR_PackingRepository();

                List<PbrLoadingModel> PACKING_LOADING_UPDATE_BR = BR_PackingRepository.PACKING_LOADING_UPDATE_BR(PbrLoadingModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = PACKING_LOADING_UPDATE_BR;
                _ResponseModel.length = PACKING_LOADING_UPDATE_BR.Count();
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

        [Route("v1/PACKING_LOADING_DELETE_BR")]
        [HttpDelete]
        public ResponseModel PACKING_LOADING_DELETE_BR([FromBody] PbrLoadingModel PbrLoadingModel)
        {
            try
            {
                BR_PackingRepository BR_PackingRepository = new BR_PackingRepository();

                List<PbrLoadingModel> PACKING_LOADING_DELETE_BR = BR_PackingRepository.PACKING_LOADING_DELETE_BR(PbrLoadingModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = PACKING_LOADING_DELETE_BR;
                _ResponseModel.length = PACKING_LOADING_DELETE_BR.Count();
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

        [Route("v1/PACKING_LOADING_LIST_BR")]
        [HttpGet]
        public ResponseModel PACKING_LOADING_LIST_BR([FromUri] PbrLoadingModel PbrLoadingModel)
        {
            try
            {
                BR_PackingRepository BR_PackingRepository = new BR_PackingRepository();

                List<PbrLoadingModel> PACKING_LOADING_LIST_BR = BR_PackingRepository.PACKING_LOADING_LIST_BR(PbrLoadingModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = PACKING_LOADING_LIST_BR;
                _ResponseModel.length = PACKING_LOADING_LIST_BR.Count();
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

        [Route("v1/PACKING_TMS_GET_BR")]
        [HttpGet]
        public ResponseModel PACKING_TMS_GET_BR([FromUri] PbrLoadingModel PbrLoadingModel)
        {
            try
            {
                BR_PackingRepository BR_PackingRepository = new BR_PackingRepository();

                List<PbrLoadingModel> PACKING_TMS_GET_BR = BR_PackingRepository.PACKING_TMS_GET_BR(PbrLoadingModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = PACKING_TMS_GET_BR;
                _ResponseModel.length = PACKING_TMS_GET_BR.Count();
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

        [Route("v1/PACKING_LOADING_COVER_SHEET_BR")]
        [HttpGet]
        public ResponseModel PACKING_LOADING_COVER_SHEET_BR([FromUri] PbrGetModel PbrGetModel)
        {
            try
            {
                BR_PackingRepository BR_PackingRepository = new BR_PackingRepository();

                List<PbrGetModel> PACKING_LOADING_COVER_SHEET_BR = BR_PackingRepository.PACKING_LOADING_COVER_SHEET_BR(PbrGetModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = PACKING_LOADING_COVER_SHEET_BR;
                _ResponseModel.length = PACKING_LOADING_COVER_SHEET_BR.Count();
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

        [Route("v1/PACKING_LOADING_DELIVERY_LIST_BR")]
        [HttpGet]
        public ResponseModel PACKING_LOADING_DELIVERY_LIST_BR([FromUri] PbrLoadingModel PbrLoadingModel)
        {
            try
            {
                BR_PackingRepository BR_PackingRepository = new BR_PackingRepository();

                List<PbrLoadingModel> PACKING_LOADING_DELIVERY_LIST_BR = BR_PackingRepository.PACKING_LOADING_DELIVERY_LIST_BR(PbrLoadingModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = PACKING_LOADING_DELIVERY_LIST_BR;
                _ResponseModel.length = PACKING_LOADING_DELIVERY_LIST_BR.Count();
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



        [Route("v1/PACKING_RECEIVE_BOX_CHECK_BR")]
        [HttpGet]
        public ResponseModel PACKING_RECEIVE_BOX_CHECK_BR([FromUri] PbrReceiveBoxModel PbrReceiveBoxModel)
        {
            try
            {
                BR_PackingRepository BR_PackingRepository = new BR_PackingRepository();

                List<PbrReceiveBoxModel> PACKING_RECEIVE_BOX_CHECK_BR = BR_PackingRepository.PACKING_RECEIVE_BOX_CHECK_BR(PbrReceiveBoxModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = PACKING_RECEIVE_BOX_CHECK_BR;
                _ResponseModel.length = PACKING_RECEIVE_BOX_CHECK_BR.Count();
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

        [Route("v1/PACKING_RECEIVE_BOX_JOB_BR")]
        [HttpGet]
        public ResponseModel PACKING_RECEIVE_BOX_JOB_BR([FromUri] PbrReceiveBoxModel PbrReceiveBoxModel)
        {
            try
            {
                BR_PackingRepository BR_PackingRepository = new BR_PackingRepository();

                List<PbrReceiveBoxModel> PACKING_RECEIVE_BOX_JOB_BR = BR_PackingRepository.PACKING_RECEIVE_BOX_JOB_BR(PbrReceiveBoxModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = PACKING_RECEIVE_BOX_JOB_BR;
                _ResponseModel.length = PACKING_RECEIVE_BOX_JOB_BR.Count();
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

        [Route("v1/PACKING_RECEIVE_BOX_GET_BR")]
        [HttpGet]
        public ResponseModel PACKING_RECEIVE_BOX_GET_BR([FromUri] PbrReceiveBoxModel PbrReceiveBoxModel)
        {
            try
            {
                BR_PackingRepository BR_PackingRepository = new BR_PackingRepository();

                List<PbrReceiveBoxModel> PACKING_RECEIVE_BOX_GET_BR = BR_PackingRepository.PACKING_RECEIVE_BOX_GET_BR(PbrReceiveBoxModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = PACKING_RECEIVE_BOX_GET_BR;
                _ResponseModel.length = PACKING_RECEIVE_BOX_GET_BR.Count();
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

        [Route("v1/PACKING_RECEIVE_BOX_LIST_BR")]
        [HttpGet]
        public ResponseModel PACKING_RECEIVE_BOX_LIST_BR([FromUri] PbrReceiveBoxModel PbrReceiveBoxModel)
        {
            try
            {
                BR_PackingRepository BR_PackingRepository = new BR_PackingRepository();

                List<PbrReceiveBoxModel> PACKING_RECEIVE_BOX_LIST_BR = BR_PackingRepository.PACKING_RECEIVE_BOX_LIST_BR(PbrReceiveBoxModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = PACKING_RECEIVE_BOX_LIST_BR;
                _ResponseModel.length = PACKING_RECEIVE_BOX_LIST_BR.Count();
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

        [Route("v1/PACKING_RECEIVE_BOX_DATA_BR")]
        [HttpGet]
        public ResponseModel PACKING_RECEIVE_BOX_DATA_BR([FromUri] PbrReceiveBoxModel PbrReceiveBoxModel)
        {
            try
            {
                BR_PackingRepository BR_PackingRepository = new BR_PackingRepository();

                List<PbrReceiveBoxModel> PACKING_RECEIVE_BOX_DATA_BR = BR_PackingRepository.PACKING_RECEIVE_BOX_DATA_BR(PbrReceiveBoxModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = PACKING_RECEIVE_BOX_DATA_BR;
                _ResponseModel.length = PACKING_RECEIVE_BOX_DATA_BR.Count();
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

        [Route("v1/PACKING_RECEIVE_BOX_CREATE_BR")]
        [HttpPost]
        public ResponseModel PACKING_RECEIVE_BOX_CREATE_BR([FromBody] PbrReceiveBoxModel PbrReceiveBoxModel)
        {
            try
            {
                BR_PackingRepository BR_PackingRepository = new BR_PackingRepository();

                List<PbrReceiveBoxModel> PACKING_RECEIVE_BOX_CREATE_BR = BR_PackingRepository.PACKING_RECEIVE_BOX_CREATE_BR(PbrReceiveBoxModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = PACKING_RECEIVE_BOX_CREATE_BR;
                _ResponseModel.length = PACKING_RECEIVE_BOX_CREATE_BR.Count();
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

        [Route("v1/PACKING_RECEIVE_BOX_UPDATE_BR")]
        [HttpPut]
        public ResponseModel PACKING_RECEIVE_BOX_UPDATE_BR([FromBody] PbrReceiveBoxModel PbrReceiveBoxModel)
        {
            try
            {
                BR_PackingRepository BR_PackingRepository = new BR_PackingRepository();

                List<PbrReceiveBoxModel> PACKING_RECEIVE_BOX_UPDATE_BR = BR_PackingRepository.PACKING_RECEIVE_BOX_UPDATE_BR(PbrReceiveBoxModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = PACKING_RECEIVE_BOX_UPDATE_BR;
                _ResponseModel.length = PACKING_RECEIVE_BOX_UPDATE_BR.Count();
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


        [Route("v1/PACKING_RECEIVE_ITEM_DETAIL_BR")]
        [HttpGet]
        public ResponseModel PACKING_RECEIVE_ITEM_DETAIL_BR([FromUri] PbrReceiveItemModel PbrReceiveItemModel)
        {
            try
            {
                BR_PackingRepository BR_PackingRepository = new BR_PackingRepository();

                List<PbrReceiveItemModel> PACKING_RECEIVE_ITEM_DETAIL_BR = BR_PackingRepository.PACKING_RECEIVE_ITEM_DETAIL_BR(PbrReceiveItemModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = PACKING_RECEIVE_ITEM_DETAIL_BR;
                _ResponseModel.length = PACKING_RECEIVE_ITEM_DETAIL_BR.Count();
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

        [Route("v1/PACKING_RECEIVE_ITEM_LIST_BR")]
        [HttpGet]
        public ResponseModel PACKING_RECEIVE_ITEM_LIST_BR([FromUri] PbrReceiveItemModel PbrReceiveItemModel)
        {
            try
            {
                BR_PackingRepository BR_PackingRepository = new BR_PackingRepository();

                List<PbrReceiveItemModel> PACKING_RECEIVE_ITEM_LIST_BR = BR_PackingRepository.PACKING_RECEIVE_ITEM_LIST_BR(PbrReceiveItemModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = PACKING_RECEIVE_ITEM_LIST_BR;
                _ResponseModel.length = PACKING_RECEIVE_ITEM_LIST_BR.Count();
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

        [Route("v1/PACKING_RECEIVE_ITEM_CREATE_BR")]
        [HttpPost]
        public ResponseModel PACKING_RECEIVE_ITEM_CREATE_BR([FromBody] PbrReceiveItemModel PbrReceiveItemModel)
        {
            try
            {
                BR_PackingRepository BR_PackingRepository = new BR_PackingRepository();

                List<PbrReceiveItemModel> PACKING_RECEIVE_ITEM_CREATE_BR = BR_PackingRepository.PACKING_RECEIVE_ITEM_CREATE_BR(PbrReceiveItemModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = PACKING_RECEIVE_ITEM_CREATE_BR;
                _ResponseModel.length = PACKING_RECEIVE_ITEM_CREATE_BR.Count();
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

        [Route("v1/PACKING_RECEIVE_ITEM_DELETE_BR")]
        [HttpDelete]
        public ResponseModel PACKING_RECEIVE_ITEM_DELETE_BR([FromBody] PbrReceiveItemModel PbrReceiveItemModel)
        {
            try
            {
                BR_PackingRepository BR_PackingRepository = new BR_PackingRepository();

                List<PbrReceiveItemModel> PACKING_RECEIVE_ITEM_DELETE_BR = BR_PackingRepository.PACKING_RECEIVE_ITEM_DELETE_BR(PbrReceiveItemModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = PACKING_RECEIVE_ITEM_DELETE_BR;
                _ResponseModel.length = PACKING_RECEIVE_ITEM_DELETE_BR.Count();
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

        [Route("v1/PACKING_RECEIVE_ITEM_VERIFY_BR")]
        [HttpGet]
        public ResponseModel PACKING_RECEIVE_ITEM_VERIFY_BR([FromUri] string ref_id, string item_barcode, int item_qty)
        {
            try
            {
                BR_PackingRepository BR_PackingRepository = new BR_PackingRepository();

                List<PbrReceiveItemModel> PACKING_RECEIVE_ITEM_VERIFY_BR = BR_PackingRepository.PACKING_RECEIVE_ITEM_VERIFY_BR(ref_id, item_barcode, item_qty);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = PACKING_RECEIVE_ITEM_VERIFY_BR;
                _ResponseModel.length = PACKING_RECEIVE_ITEM_VERIFY_BR.Count();
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


        [Route("v1/PACKING_RECEIVE_JOB_VERIFY_BR")]
        [HttpPut]
        public ResponseModel PACKING_RECEIVE_JOB_VERIFY_BR([FromBody] PbrReceiveItemModel PbrReceiveItemModel)
        {
            try
            {
                BR_PackingRepository BR_PackingRepository = new BR_PackingRepository();

                List<PbrReceiveItemModel> PACKING_RECEIVE_JOB_VERIFY_BR = BR_PackingRepository.PACKING_RECEIVE_JOB_VERIFY_BR(PbrReceiveItemModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = PACKING_RECEIVE_JOB_VERIFY_BR;
                _ResponseModel.length = PACKING_RECEIVE_JOB_VERIFY_BR.Count();
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


        [Route("v1/PACKING_RECEIVE_JOB_VERIFY_ALERT_BR")]
        [HttpGet]
        public ResponseModel PACKING_RECEIVE_JOB_VERIFY_ALERT_BR([FromUri] string ref_id)
        {
            try
            {
                BR_PackingRepository BR_PackingRepository = new BR_PackingRepository();

                List<PbrReceiveItemModel> PACKING_RECEIVE_ITEM_VERIFY_BR = BR_PackingRepository.PACKING_RECEIVE_JOB_VERIFY_ALERT_BR(ref_id);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = PACKING_RECEIVE_ITEM_VERIFY_BR;
                _ResponseModel.length = PACKING_RECEIVE_ITEM_VERIFY_BR.Count();
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


        [Route("v1/PACKING_RECEIVE_LIST_BR")]
        [HttpGet]
        public ResponseModel PACKING_RECEIVE_LIST_BR([FromUri] PbrReceiveGetModel PbrReceiveGetModel)
        {
            try
            {
                BR_PackingRepository BR_PackingRepository = new BR_PackingRepository();

                List<PbrReceiveGetModel> PACKING_RECEIVE_LIST_BR = BR_PackingRepository.PACKING_RECEIVE_LIST_BR(PbrReceiveGetModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = PACKING_RECEIVE_LIST_BR;
                _ResponseModel.length = PACKING_RECEIVE_LIST_BR.Count();
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


        [Route("v1/PACKING_TEMPLATE_LIST_BR")]
        [HttpGet]
        public ResponseModel PACKING_TEMPLATE_LIST_BR([FromUri] PbrTemplateGetModel PbrTemplateGetModel)
        {
            try
            {
                BR_PackingRepository BR_PackingRepository = new BR_PackingRepository();

                List<PbrTemplateGetModel> PACKING_TEMPLATE_LIST_BR = BR_PackingRepository.PACKING_TEMPLATE_LIST_BR(PbrTemplateGetModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = PACKING_TEMPLATE_LIST_BR;
                _ResponseModel.length = PACKING_TEMPLATE_LIST_BR.Count();
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

        [Route("v1/PACKING_TEMPLATE_CREATE_BR")]
        [HttpPost]
        public ResponseModel PACKING_TEMPLATE_CREATE_BR([FromBody] PbrTemplateGetModel PbrTemplateGetModel)
        {
            try
            {
                BR_PackingRepository BR_PackingRepository = new BR_PackingRepository();

                List<PbrTemplateGetModel> PACKING_TEMPLATE_CREATE_BR = BR_PackingRepository.PACKING_TEMPLATE_CREATE_BR(PbrTemplateGetModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = PACKING_TEMPLATE_CREATE_BR;
                _ResponseModel.length = PACKING_TEMPLATE_CREATE_BR.Count();
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

        [Route("v1/PACKING_TEMPLATE_GET_BR")]
        [HttpGet]
        public ResponseModel PACKING_TEMPLATE_GET_BR([FromUri] PbrTemplateGetModel PbrTemplateGetModel)
        {
            try
            {
                BR_PackingRepository BR_PackingRepository = new BR_PackingRepository();

                List<PbrTemplateGetModel> PACKING_TEMPLATE_GET_BR = BR_PackingRepository.PACKING_TEMPLATE_GET_BR(PbrTemplateGetModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = PACKING_TEMPLATE_GET_BR;
                _ResponseModel.length = PACKING_TEMPLATE_GET_BR.Count();
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


        [Route("v1/PACKING_CASE_CREATE_BR")]
        [HttpPost]
        public ResponseModel PACKING_CASE_CREATE_BR([FromBody] PbrCaseGetModel PbrCaseGetModel)
        {
            try
            {
                BR_PackingRepository BR_PackingRepository = new BR_PackingRepository();

                List<PbrCaseGetModel> PACKING_CASE_CREATE_BR = BR_PackingRepository.PACKING_CASE_CREATE_BR(PbrCaseGetModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = PACKING_CASE_CREATE_BR;
                _ResponseModel.length = PACKING_CASE_CREATE_BR.Count();
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

        [Route("v1/PACKING_CASE_LIST_BR")]
        [HttpGet]
        public ResponseModel PACKING_CASE_LIST_BR([FromUri] PbrCaseGetModel PbrCaseGetModel)
        {
            try
            {
                BR_PackingRepository BR_PackingRepository = new BR_PackingRepository();

                List<PbrCaseGetModel> PACKING_CASE_LIST_BR = BR_PackingRepository.PACKING_CASE_LIST_BR(PbrCaseGetModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = PACKING_CASE_LIST_BR;
                _ResponseModel.length = PACKING_CASE_LIST_BR.Count();
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
        
        [Route("v1/PACKING_CASE_HISTORY_BR")]
        [HttpGet]
        public ResponseModel PACKING_CASE_HISTORY_BR([FromUri] PbrCaseGetModel PbrCaseGetModel)
        {
            try
            {
                BR_PackingRepository BR_PackingRepository = new BR_PackingRepository();

                List<PbrCaseGetModel> PACKING_CASE_HISTORY_BR = BR_PackingRepository.PACKING_CASE_HISTORY_BR(PbrCaseGetModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = PACKING_CASE_HISTORY_BR;
                _ResponseModel.length = PACKING_CASE_HISTORY_BR.Count();
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

        [Route("v1/PACKING_CASE_UPDATE_BR")]
        [HttpPut]
        public ResponseModel PACKING_CASE_UPDATE_BR([FromBody] PbrCaseGetModel PbrCaseGetModel)
        {
            try
            {
                BR_PackingRepository BR_PackingRepository = new BR_PackingRepository();

                List<PbrCaseGetModel> PACKING_CASE_UPDATE_BR = BR_PackingRepository.PACKING_CASE_UPDATE_BR(PbrCaseGetModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = PACKING_CASE_UPDATE_BR;
                _ResponseModel.length = PACKING_CASE_UPDATE_BR.Count();
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

        [Route("v1/PACKING_CASE_SCAN_CREATE_BR")]
        [HttpPost]
        public ResponseModel PACKING_CASE_SCAN_CREATE_BR([FromBody] PbrCaseGetModel PbrCaseGetModel)
        {
            try
            {
                BR_PackingRepository BR_PackingRepository = new BR_PackingRepository();

                List<PbrCaseGetModel> PACKING_CASE_SCAN_CREATE_BR = BR_PackingRepository.PACKING_CASE_SCAN_CREATE_BR(PbrCaseGetModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = PACKING_CASE_SCAN_CREATE_BR;
                _ResponseModel.length = PACKING_CASE_SCAN_CREATE_BR.Count();
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

        [Route("v1/PACKING_CASE_SCAN_LIST_BR")]
        [HttpGet]
        public ResponseModel PACKING_CASE_SCAN_LIST_BR([FromUri] PbrCaseGetModel PbrCaseGetModel)
        {
            try
            {
                BR_PackingRepository BR_PackingRepository = new BR_PackingRepository();

                List<PbrCaseGetModel> PACKING_CASE_SCAN_LIST_BR = BR_PackingRepository.PACKING_CASE_SCAN_LIST_BR(PbrCaseGetModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = PACKING_CASE_SCAN_LIST_BR;
                _ResponseModel.length = PACKING_CASE_SCAN_LIST_BR.Count();
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

        [Route("v1/PACKING_MASTER_BR")]
        [HttpGet]
        public ResponseModel PACKING_MASTER_BR([FromUri] ResponseSelect2Model ResponseSelect2Model)
        {
            try
            {
                BR_PackingRepository BR_PackingRepository = new BR_PackingRepository();

                List<ResponseSelect2Model> PACKING_MASTER_BR = BR_PackingRepository.PACKING_MASTER_BR(ResponseSelect2Model);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = PACKING_MASTER_BR;
                _ResponseModel.length = PACKING_MASTER_BR.Count();
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


        [Route("v1/PACKING_ITEM_FIND_BARCODE")]
        [HttpGet]
        public ResponseModel PACKING_ITEM_FIND_BARCODE([FromUri] string ref_id, string job_scan)
        {
            try
            {
                BR_PackingRepository BR_PackingRepository = new BR_PackingRepository();

                List<string> PACKING_ITEM_FIND_BARCODE = BR_PackingRepository.PACKING_ITEM_FIND_BARCODE(ref_id, job_scan);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = PACKING_ITEM_FIND_BARCODE;
                _ResponseModel.length = PACKING_ITEM_FIND_BARCODE.Count();
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

        [Route("v1/PACKING_SCAN_CREATE")]
        [HttpPost]
        public ResponseModel PACKING_SCAN_CREATE([FromBody] PbrItemBatchScanModel PbrItemBatchScanModel)
        {
            try
            {
                BR_PackingRepository BR_PackingRepository = new BR_PackingRepository();

                List<PbrItemBatchScanModel> PACKING_SCAN_CREATE = BR_PackingRepository.PACKING_SCAN_CREATE(PbrItemBatchScanModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = PACKING_SCAN_CREATE;
                _ResponseModel.length = PACKING_SCAN_CREATE.Count();
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

        [Route("v1/PACKING_ITEM_BATCH_SCAN")]
        [HttpPost]
        public ResponseModel PACKING_ITEM_BATCH_SCAN([FromBody] PbrItemBatchScanModel PbrItemBatchScanModel)
        {
            try
            {

                ResponseModel _ResponseCheckModel = new ResponseModel();

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseCheckModel = PACKING_ITEM_FIND_BARCODE(PbrItemBatchScanModel.ref_id, PbrItemBatchScanModel.job_scan);

                BR_PackingRepository BR_PackingRepository = new BR_PackingRepository();

                if (_ResponseCheckModel.length != 0)
                {

                    _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                    _ResponseModel.length = _ResponseCheckModel.length;
                    _ResponseModel.data = _ResponseCheckModel.data;
                    _ResponseModel.status = "Success";
                }
                else
                {
                    BR_PackingRepository.PACKING_SCAN_CREATE(PbrItemBatchScanModel);

                    _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                    _ResponseModel.length = _ResponseCheckModel.length;
                    _ResponseModel.error_message = "ไม่พบรายการสินค้า";
                    _ResponseModel.status = "Error";
                }

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
