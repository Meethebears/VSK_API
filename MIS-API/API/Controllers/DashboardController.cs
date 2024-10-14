using REPO.Controllers;
using REPO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace API.Controllers
{
    public class DashboardController : ApiController
    {

        [Route("v4/DashboardWHAllCreate")]
        [HttpGet]
        public ResponseModel DashboardWHAllCreate([FromUri] string INVDATE)
        {
            try
            {
                DashboardWHCreate("F1", INVDATE);
                DashboardWHCreate("F2", INVDATE);
                DashboardWHCreate("F3", INVDATE);
                ResponseModel _ResponseModel = new ResponseModel();
                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
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

        [Route("v4/DashboardWHCreate")]
        [HttpGet]
        public ResponseModel DashboardWHCreate([FromUri] string STKZONE, [FromUri] string INVDATE)
        {
            try
            {
                DashbordRepository DashbordRepository = new DashbordRepository();

                DashbordRepository.DashboardWH_Create(STKZONE,INVDATE);
                ResponseModel _ResponseModel = new ResponseModel();
                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
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

        [Route("v4/DashboardWHGet")]
        [HttpGet]
        public ResponseModel DashboardWH_GET([FromUri] string STKZONE, [FromUri] string INVDATE)
        {
            try
            {
                DashbordRepository DashbordRepository = new DashbordRepository();

                List<DashboardWHOrdertypeModel> DashboardWH_GET = (List<DashboardWHOrdertypeModel>)DashbordRepository.DashboardWH_GET(STKZONE, INVDATE);

                ResponseModel _ResponseModel = new ResponseModel();
                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = DashboardWH_GET;
                _ResponseModel.length = DashboardWH_GET.Count();
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

        [Route("v4/DashboardWHDetailGET")]
        [HttpGet]
        public ResponseModel DashboardWHDetail_GET([FromUri] string STKZONE, [FromUri] string INVDATE, [FromUri] string ORDERTYPE)
        {
            try
            {
                DashbordRepository DashbordRepository = new DashbordRepository();

                List<DashboardWHDetailModel> DashboardWHDetail_GET = (List<DashboardWHDetailModel>)DashbordRepository.DashboardWHDetail_GET(STKZONE, INVDATE, ORDERTYPE);

                ResponseModel _ResponseModel = new ResponseModel();
                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = DashboardWHDetail_GET;
                _ResponseModel.length = DashboardWHDetail_GET.Count();
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

        [Route("v4/DashboardIVOrdertypeCreate")]
        [HttpGet]
        public ResponseModel DashboardIVOrdertypeCreate([FromUri] string INVDATE)
        {
            try
            {
                DashbordRepository DashbordRepository = new DashbordRepository();

                DashbordRepository.DashboardIVOrdertype_Create(INVDATE);
                ResponseModel _ResponseModel = new ResponseModel();
                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
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

        [Route("v4/DashboardIVOrdertypeGet")]
        [HttpGet]
        public ResponseModel DashboardIVOrdertype_Get([FromUri] string INVDATE)
        {
            try
            {
                DashbordRepository DashbordRepository = new DashbordRepository();

                List<DashboardIVOrderypeModel> DashboardIVOrdertype_Get = (List<DashboardIVOrderypeModel>)DashbordRepository.DashboardIVOrdertype_Get(INVDATE);

                ResponseModel _ResponseModel = new ResponseModel();
                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = DashboardIVOrdertype_Get;
                _ResponseModel.length = DashboardIVOrdertype_Get.Count();
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

        [Route("v4/DashboardPKNotIVDetailGET")]
        [HttpGet]
        public ResponseModel DashboardPKNotIVDetail_GET([FromUri] string INVDATE, [FromUri] string ORDERTYPE)
        {
            try
            {
                DashbordRepository DashbordRepository = new DashbordRepository();

                List<DashboardPKNotIVDetailModel> DashboardIVOrdertype_Get = (List<DashboardPKNotIVDetailModel>)DashbordRepository.DashboardPKNotIVDetail_GET(INVDATE, ORDERTYPE);

                ResponseModel _ResponseModel = new ResponseModel();
                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = DashboardIVOrdertype_Get;
                _ResponseModel.length = DashboardIVOrdertype_Get.Count();
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

        [Route("v4/DashboardPKWITHIVDetailGet")]
        [HttpGet]
        public ResponseModel DashboardPKWITHIVDetail_GET([FromUri] string INVDATE, [FromUri] string ORDERTYPE)
        {
            try
            {
                DashbordRepository DashbordRepository = new DashbordRepository();

                List<DashboardPKWITHTRPDetailModel> DashboardPKWITHIVDetail_GET = (List<DashboardPKWITHTRPDetailModel>)DashbordRepository.DashboardPKWITHIVDetail_GET(INVDATE, ORDERTYPE);

                ResponseModel _ResponseModel = new ResponseModel();
                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = DashboardPKWITHIVDetail_GET;
                _ResponseModel.length = DashboardPKWITHIVDetail_GET.Count();
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

        [Route("v4/DashboardPKWITHIVDetailPeriodGet")]
        [HttpGet]
        public ResponseModel DashboardPKWITHIVDetailPeriod_GET([FromUri] string INVDATE, [FromUri] string ORDERTYPE, [FromUri] string STARTTIME, [FromUri] string ENDTIME)
        {
            try
            {
                DashbordRepository DashbordRepository = new DashbordRepository();

                List<DashboardPKWITHTRPDetailModel> DashboardPKWITHIVDetail_GET = (List<DashboardPKWITHTRPDetailModel>)DashbordRepository.DashboardPKWITHIVDetailPeriod_GET(INVDATE, ORDERTYPE, STARTTIME, ENDTIME);

                ResponseModel _ResponseModel = new ResponseModel();
                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = DashboardPKWITHIVDetail_GET;
                _ResponseModel.length = DashboardPKWITHIVDetail_GET.Count();
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

        [Route("v4/DashboardIVNotTRPDetailPeriodGet")]
        [HttpGet]
        public ResponseModel DashboardIVNotTRPDetailPeriod_GET([FromUri] string INVDATE, [FromUri] string ORDERTYPE, [FromUri] string STARTTIME, [FromUri] string ENDTIME)
        {
            try
            {
                DashbordRepository DashbordRepository = new DashbordRepository();

                List<DashboardIVNotTRPDetailPeriodModel> DashboardIVNotTRPDetailPeriod_GET = (List<DashboardIVNotTRPDetailPeriodModel>)DashbordRepository.DashboardIVNotTRPDetailPeriod_GET(INVDATE, ORDERTYPE, STARTTIME, ENDTIME);

                ResponseModel _ResponseModel = new ResponseModel();
                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = DashboardIVNotTRPDetailPeriod_GET;
                _ResponseModel.length = DashboardIVNotTRPDetailPeriod_GET.Count();
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

        [Route("v4/DashboardIVWITHTRPDetailPeriod_Get")]
        [HttpGet]
        public ResponseModel DashboardIVWITHTRPDetailPeriod_GET([FromUri] string INVDATE, [FromUri] string ORDERTYPE, [FromUri] string STARTTIME, [FromUri] string ENDTIME)
        {
            try
            {
                DashbordRepository DashbordRepository = new DashbordRepository();

                List<DashboardIVWITHTRPDetailModel> DashboardIVWITHTRPDetailPeriod_GET = (List<DashboardIVWITHTRPDetailModel>)DashbordRepository.DashboardIVWITHTRPDetailPeriod_GET(INVDATE, ORDERTYPE, STARTTIME, ENDTIME);

                ResponseModel _ResponseModel = new ResponseModel();
                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = DashboardIVWITHTRPDetailPeriod_GET;
                _ResponseModel.length = DashboardIVWITHTRPDetailPeriod_GET.Count();
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
