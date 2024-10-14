using REPO.Controllers;
using REPO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace API.Controllers
{
    public class DailyCasherController : ApiController
    {

        [Route("v1/INVOICE_GET")]
        [HttpGet]
        public ResponseModel INVOICE_GET([FromUri] InvoiceModel InvoiceModel)
        {
            try
            {
                DailyCasherRepository DailyCasherRepository = new DailyCasherRepository();

                List<InvoiceModel> INVOICE_GET = DailyCasherRepository.INVOICE_GET(InvoiceModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = INVOICE_GET;
                _ResponseModel.length = INVOICE_GET.Count();
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

        [Route("v1/INVOICE_VSK_GET")]
        [HttpGet]
        public ResponseModel INVOICE_VSK_GET([FromUri] InvoiceModel InvoiceModel)
        {
            try
            {
                DailyCasherRepository DailyCasherRepository = new DailyCasherRepository();

                List<InvoiceModel> INVOICE_VSK_GET = DailyCasherRepository.INVOICE_VSK_GET(InvoiceModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = INVOICE_VSK_GET;
                _ResponseModel.length = INVOICE_VSK_GET.Count();
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

        //[Route("v1/CUSTOMER_GET")]
        //[HttpGet]
        //public ResponseModel CUSTOMER_GET([FromUri] DailyCasherModel DailyCasherModel)
        //{
        //    try
        //    {
        //        DailyCasherRepository DailyCasherRepository = new DailyCasherRepository();

        //        List<DailyCasherModel> CUSTOMER_GET = DailyCasherRepository.CUSTOMER_GET(DailyCasherModel);

        //        ResponseModel _ResponseModel = new ResponseModel();

        //        _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
        //        _ResponseModel.data = CUSTOMER_GET;
        //        _ResponseModel.length = CUSTOMER_GET.Count();
        //        _ResponseModel.status = "Success";

        //        return _ResponseModel;
        //    }
        //    catch (Exception ex)
        //    {
        //        ResponseModel _ResponseModel = new ResponseModel();
        //        _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
        //        _ResponseModel.status = "Error";
        //        _ResponseModel.error_message = ex.Message.ToString();
        //        _ResponseModel.error_stacktrace = ex.StackTrace.ToString();
        //        _ResponseModel.error_source = ex.Source.ToString();

        //        return _ResponseModel;
        //    }

        //}

        [Route("v1/CUSTOMER_GET")]
        [HttpGet]
        public ResponseModel CUSTOMER_GET([FromUri] string mode = "", string ref_id = "", string invdate = "", string invdate_start = "", string invdate_end = "", string invcode = "", string branch = "")
        {
            try
            {
                DailyCasherRepository DailyCasherRepository = new DailyCasherRepository();

                List<DailyCasherModel> CUSTOMER_GET = DailyCasherRepository.CUSTOMER_GET(mode, ref_id, invdate, invdate_start, invdate_end, invcode, branch);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = CUSTOMER_GET;
                _ResponseModel.length = CUSTOMER_GET.Count();
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

        [Route("v1/DAILY_CASHIER_LIST")]
        [HttpGet]
        public ResponseModel DAILY_CASHIER_LIST([FromUri] DailyCasherModel DailyCasherModel)
        {
            try
            {
                DailyCasherRepository DailyCasherRepository = new DailyCasherRepository();

                List<DailyCasherModel> DAILY_CASHIER_LIST = DailyCasherRepository.DAILY_CASHIER_LIST(DailyCasherModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = DAILY_CASHIER_LIST;
                _ResponseModel.length = DAILY_CASHIER_LIST.Count();
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

        [Route("v1/DAILY_CASHIER_CHECK")]
        [HttpGet]
        public ResponseModel DAILY_CASHIER_CHECK([FromUri] DailyCasherModel DailyCasherModel)
        {
            try
            {
                DailyCasherRepository DailyCasherRepository = new DailyCasherRepository();

                List<DailyCasherModel> DAILY_CASHIER_CHECK = DailyCasherRepository.DAILY_CASHIER_CHECK(DailyCasherModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = DAILY_CASHIER_CHECK;
                _ResponseModel.length = DAILY_CASHIER_CHECK.Count();
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

        [Route("v1/DAILY_CASHIER_SYNC")]
        [HttpGet]
        public ResponseModel DAILY_CASHIER_SYNC([FromUri] DailyCasherModel DailyCasherModel)
        {
            try
            {
                DailyCasherRepository DailyCasherRepository = new DailyCasherRepository();

                List<DailyCasherModel> DAILY_CASHIER_SYNC = DailyCasherRepository.DAILY_CASHIER_SYNC(DailyCasherModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = DAILY_CASHIER_SYNC;
                _ResponseModel.length = DAILY_CASHIER_SYNC.Count();
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

        [Route("v1/DAILY_CASHIER_JOB")]
        [HttpGet]
        public ResponseModel DAILY_CASHIER_JOB([FromUri] DailyCasherModel DailyCasherModel)
        {
            try
            {
                DailyCasherRepository DailyCasherRepository = new DailyCasherRepository();

                List<DailyCasherModel> DAILY_CASHIER_JOB = DailyCasherRepository.DAILY_CASHIER_JOB(DailyCasherModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = DAILY_CASHIER_JOB;
                _ResponseModel.length = DAILY_CASHIER_JOB.Count();
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

        [Route("v1/DAILY_CASHIER_DETAIL")]
        [HttpGet]
        public ResponseModel DAILY_CASHIER_DETAIL([FromUri] DailyCasherModel DailyCasherModel)
        {
            try
            {
                DailyCasherRepository DailyCasherRepository = new DailyCasherRepository();

                List<DailyCasherModel> DAILY_CASHIER_DETAIL = DailyCasherRepository.DAILY_CASHIER_DETAIL(DailyCasherModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = DAILY_CASHIER_DETAIL;
                _ResponseModel.length = DAILY_CASHIER_DETAIL.Count();
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

        [Route("v1/DAILY_CASHIER_HISTORY")]
        [HttpGet]
        public ResponseModel DAILY_CASHIER_HISTORY([FromUri] DailyCasherModel DailyCasherModel)
        {
            try
            {
                DailyCasherRepository DailyCasherRepository = new DailyCasherRepository();

                List<DailyCasherModel> DAILY_CASHIER_HISTORY = DailyCasherRepository.DAILY_CASHIER_HISTORY(DailyCasherModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = DAILY_CASHIER_HISTORY;
                _ResponseModel.length = DAILY_CASHIER_HISTORY.Count();
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
       
        [Route("v1/DAILY_CASHIER_UPDATE_STATUS")]
        [HttpGet]
        public ResponseModel DAILY_CASHIER_UPDATE_STATUS([FromUri] DailyCasherModel DailyCasherModel)
        {
            try
            {
                DailyCasherRepository DailyCasherRepository = new DailyCasherRepository();

                List<DailyCasherModel> DAILY_CASHIER_UPDATE_STATUS = DailyCasherRepository.DAILY_CASHIER_UPDATE_STATUS(DailyCasherModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = DAILY_CASHIER_UPDATE_STATUS;
                _ResponseModel.length = DAILY_CASHIER_UPDATE_STATUS.Count();
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

        [Route("v1/DAILY_CASHIER_FILE_LIST")]
        [HttpGet]
        public ResponseModel DAILY_CASHIER_FILE_LIST([FromUri] DailyCasherModel DailyCasherModel)
        {
            try
            {
                DailyCasherRepository DailyCasherRepository = new DailyCasherRepository();

                List<DailyCasherModel> DAILY_CASHIER_FILE_LIST = DailyCasherRepository.DAILY_CASHIER_FILE_LIST(DailyCasherModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = DAILY_CASHIER_FILE_LIST;
                _ResponseModel.length = DAILY_CASHIER_FILE_LIST.Count();
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

        [Route("v1/DAILY_CASHIER_FILE_UPLOAD")]
        [HttpPost]
        public ResponseModel DAILY_CASHIER_FILE_UPLOAD([FromBody] DailyCasherModel DailyCasherModel)
        {
            try
            {
                DailyCasherRepository DailyCasherRepository = new DailyCasherRepository();

                List<DailyCasherModel> DAILY_CASHIER_FILE_UPLOAD = DailyCasherRepository.DAILY_CASHIER_FILE_UPLOAD(DailyCasherModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = DAILY_CASHIER_FILE_UPLOAD;
                _ResponseModel.length = DAILY_CASHIER_FILE_UPLOAD.Count();
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

        [Route("v1/DAILY_CASHIER_FILE_DELETE")]
        [HttpDelete]
        public ResponseModel DAILY_CASHIER_FILE_DELETE(DailyCasherModel DailyCasherModel)
        {
            try
            {
                DailyCasherRepository DailyCasherRepository = new DailyCasherRepository();

                List<DailyCasherModel> DAILY_CASHIER_FILE_DELETE = DailyCasherRepository.DAILY_CASHIER_FILE_DELETE(DailyCasherModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = DAILY_CASHIER_FILE_DELETE;
                _ResponseModel.length = DAILY_CASHIER_FILE_DELETE.Count();
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

        [Route("v1/ACCRUED_CREATE")]
        [HttpGet]
        public ResponseModel ACCRUED_CREATE([FromUri] DailyCasherModel DailyCasherModel)
        {
            try
            {
                DailyCasherRepository DailyCasherRepository = new DailyCasherRepository();

                List<DailyCasherModel> ACCRUED_CREATE = DailyCasherRepository.ACCRUED_CREATE(DailyCasherModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = ACCRUED_CREATE;
                _ResponseModel.length = ACCRUED_CREATE.Count();
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

        [Route("v1/ACCRUED_LIST")]
        [HttpGet]
        public ResponseModel ACCRUED_LIST([FromUri] DailyCasherModel DailyCasherModel)
        {
            try
            {
                DailyCasherRepository DailyCasherRepository = new DailyCasherRepository();

                List<DailyCasherModel> ACCRUED_LIST = DailyCasherRepository.ACCRUED_LIST(DailyCasherModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = ACCRUED_LIST;
                _ResponseModel.length = ACCRUED_LIST.Count();
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

        [Route("v1/ACCRUED_REMARK")]
        [HttpPut]
        public ResponseModel ACCRUED_REMARK([FromBody] DailyCasherModel DailyCasherModel)
        {
            try
            {
                DailyCasherRepository DailyCasherRepository = new DailyCasherRepository();

                List<DailyCasherModel> ACCRUED_REMARK = DailyCasherRepository.ACCRUED_REMARK(DailyCasherModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = ACCRUED_REMARK;
                _ResponseModel.length = ACCRUED_REMARK.Count();
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

        [Route("v1/ACCRUED_DELETE")]
        [HttpDelete]
        public ResponseModel ACCRUED_DELETE(DailyCasherModel DailyCasherModel)
        {
            try
            {
                DailyCasherRepository DailyCasherRepository = new DailyCasherRepository();

                List<DailyCasherModel> ACCRUED_DELETE = DailyCasherRepository.ACCRUED_DELETE(DailyCasherModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = ACCRUED_DELETE;
                _ResponseModel.length = ACCRUED_DELETE.Count();
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


        [Route("v1/ACCRUED_RECEIVE_CREATE")]
        [HttpGet]
        public ResponseModel ACCRUED_RECEIVE_CREATE([FromUri] DailyCasherModel DailyCasherModel)
        {
            try
            {
                DailyCasherRepository DailyCasherRepository = new DailyCasherRepository();

                List<DailyCasherModel> ACCRUED_RECEIVE_CREATE = DailyCasherRepository.ACCRUED_RECEIVE_CREATE(DailyCasherModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = ACCRUED_RECEIVE_CREATE;
                _ResponseModel.length = ACCRUED_RECEIVE_CREATE.Count();
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

        [Route("v1/ACCRUED_RECEIVE_LIST")]
        [HttpGet]
        public ResponseModel ACCRUED_RECEIVE_LIST([FromUri] DailyCasherModel DailyCasherModel)
        {
            try
            {
                DailyCasherRepository DailyCasherRepository = new DailyCasherRepository();

                List<DailyCasherModel> ACCRUED_RECEIVE_LIST = DailyCasherRepository.ACCRUED_RECEIVE_LIST(DailyCasherModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = ACCRUED_RECEIVE_LIST;
                _ResponseModel.length = ACCRUED_RECEIVE_LIST.Count();
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

        [Route("v1/ACCRUED_RECEIVE_DELETE")]
        [HttpDelete]
        public ResponseModel ACCRUED_RECEIVE_DELETE(DailyCasherModel DailyCasherModel)
        {
            try
            {
                DailyCasherRepository DailyCasherRepository = new DailyCasherRepository();

                List<DailyCasherModel> ACCRUED_RECEIVE_DELETE = DailyCasherRepository.ACCRUED_RECEIVE_DELETE(DailyCasherModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = ACCRUED_RECEIVE_DELETE;
                _ResponseModel.length = ACCRUED_RECEIVE_DELETE.Count();
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


        [Route("v1/RECEIVE_BILL_CREATE")]
        [HttpPost]
        public ResponseModel RECEIVE_BILL_CREATE([FromBody] DailyCasherModel DailyCasherModel)
        {
            try
            {
                DailyCasherRepository DailyCasherRepository = new DailyCasherRepository();

                List<DailyCasherModel> RECEIVE_BILL_CREATE = DailyCasherRepository.RECEIVE_BILL_CREATE(DailyCasherModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = RECEIVE_BILL_CREATE;
                _ResponseModel.length = RECEIVE_BILL_CREATE.Count();
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

        [Route("v1/RECEIVE_BILL_LIST")]
        [HttpGet]
        public ResponseModel RECEIVE_BILL_LIST([FromUri] DailyCasherModel DailyCasherModel)
        {
            try
            {
                DailyCasherRepository DailyCasherRepository = new DailyCasherRepository();

                List<DailyCasherModel> RECEIVE_BILL_LIST = DailyCasherRepository.RECEIVE_BILL_LIST(DailyCasherModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = RECEIVE_BILL_LIST;
                _ResponseModel.length = RECEIVE_BILL_LIST.Count();
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

        [Route("v1/RECEIVE_BILL_DELETE")]
        [HttpDelete]
        public ResponseModel RECEIVE_BILL_DELETE(DailyCasherModel DailyCasherModel)
        {
            try
            {
                DailyCasherRepository DailyCasherRepository = new DailyCasherRepository();

                List<DailyCasherModel> RECEIVE_BILL_DELETE = DailyCasherRepository.RECEIVE_BILL_DELETE(DailyCasherModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = RECEIVE_BILL_DELETE;
                _ResponseModel.length = RECEIVE_BILL_DELETE.Count();
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

        [Route("v1/RECEIVE_BILL_VERIFY_LIST")]
        [HttpGet]
        public ResponseModel RECEIVE_BILL_VERIFY_LIST([FromUri] DailyCasherModel DailyCasherModel)
        {
            try
            {
                DailyCasherRepository DailyCasherRepository = new DailyCasherRepository();

                List<DailyCasherModel> RECEIVE_BILL_VERIFY_LIST = DailyCasherRepository.RECEIVE_BILL_VERIFY_LIST(DailyCasherModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = RECEIVE_BILL_VERIFY_LIST;
                _ResponseModel.length = RECEIVE_BILL_VERIFY_LIST.Count();
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

        [Route("v1/RECEIVE_BILL_VERIFY_UPLOAD")]
        [HttpGet]
        public ResponseModel RECEIVE_BILL_VERIFY_UPLOAD([FromUri] DailyCasherModel DailyCasherModel)
        {
            try
            {
                DailyCasherRepository DailyCasherRepository = new DailyCasherRepository();

                List<DailyCasherModel> RECEIVE_BILL_VERIFY_UPLOAD = DailyCasherRepository.RECEIVE_BILL_VERIFY_UPLOAD(DailyCasherModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = RECEIVE_BILL_VERIFY_UPLOAD;
                _ResponseModel.length = RECEIVE_BILL_VERIFY_UPLOAD.Count();
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

        [Route("v1/RECEIVE_BILL_VERIFY_UPLOAD_CHECK")]
        [HttpGet]
        public ResponseModel RECEIVE_BILL_VERIFY_UPLOAD_CHECK([FromUri] DailyCasherModel DailyCasherModel)
        {
            try
            {
                DailyCasherRepository DailyCasherRepository = new DailyCasherRepository();

                List<DailyCasherModel> RECEIVE_BILL_VERIFY_UPLOAD_CHECK = DailyCasherRepository.RECEIVE_BILL_VERIFY_UPLOAD_CHECK(DailyCasherModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = RECEIVE_BILL_VERIFY_UPLOAD_CHECK;
                _ResponseModel.length = RECEIVE_BILL_VERIFY_UPLOAD_CHECK.Count();
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

        [Route("v1/DAILY_CASHIER_ACTION")]
        [HttpGet]
        public ResponseModel DAILY_CASHIER_ACTION([FromUri] DailyCasherModel DailyCasherModel)
        {
            try
            {
                DailyCasherRepository DailyCasherRepository = new DailyCasherRepository();

                List<DailyCasherModel> DAILY_CASHIER_ACTION = DailyCasherRepository.DAILY_CASHIER_ACTION(DailyCasherModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = DAILY_CASHIER_ACTION;
                _ResponseModel.length = DAILY_CASHIER_ACTION.Count();
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

        [Route("v1/DAILY_CASHIER_MASTER")]
        [HttpGet]
        public ResponseModel DAILY_CASHIER_MASTER([FromUri] ResponseSelect2Model ResponseSelect2Model)
        {
            try
            {
                DailyCasherRepository DailyCasherRepository = new DailyCasherRepository();

                List<ResponseSelect2Model> DAILY_CASHIER_MASTER = DailyCasherRepository.DAILY_CASHIER_MASTER(ResponseSelect2Model);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = DAILY_CASHIER_MASTER;
                _ResponseModel.length = DAILY_CASHIER_MASTER.Count();
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
