﻿using REPO.Models;
using REPO.Controllers;
using System.Web.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;

namespace API.Controllers
{
    public class DashboardController : ApiController
    {


        #region Dashboard_Create
        [Route("api/Dashboard_Create")]
        [HttpGet]
        public ResponseModel Dashboard_Create([FromUri] DashboardModel DashboardModel)
        {

            try
            {
                CultureInfo cultureinfo = new CultureInfo("en-US");

                DashboardRepository DashboardRepository = new DashboardRepository();

                List<DashboardModel> Dashboard_Create = DashboardRepository.Dashboard_Create(DashboardModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = Dashboard_Create;
                _ResponseModel.length = Dashboard_Create.Count();
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
        #endregion

        #region Dashboard_Total
        [Route("api/Dashboard_Total")]
        [HttpGet]
        public ResponseModel Dashboard_Total([FromUri] DashboardModel DashboardModel)
        {

            try
            {
                CultureInfo cultureinfo = new CultureInfo("en-US");

                DashboardRepository DashboardRepository = new DashboardRepository();

                List<DashboardModel> Dashboard_Total = DashboardRepository.Dashboard_Total(DashboardModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = Dashboard_Total;
                _ResponseModel.length = Dashboard_Total.Count();
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
        #endregion

        #region Dashboard_Get
        [Route("api/Dashboard_Get")]
        [HttpGet]
        public ResponseModel Dashboard_Get([FromUri] DashboardModel DashboardModel)
        {

            try
            {
                CultureInfo cultureinfo = new CultureInfo("en-US");

                DashboardRepository DashboardRepository = new DashboardRepository();

                List<DashboardModel> Dashboard_Get = DashboardRepository.Dashboard_Get(DashboardModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = Dashboard_Get;
                _ResponseModel.length = Dashboard_Get.Count();
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
        #endregion

        #region Dashboard_Invoice_Create
        [Route("api/Dashboard_Invoice_Create")]
        [HttpGet]
        public ResponseModel Dashboard_Invoice_Create([FromUri] InvoiceModel InvoiceModel)
        {

            try
            {
                CultureInfo cultureinfo = new CultureInfo("en-US");

                DashboardRepository DashboardRepository = new DashboardRepository();

                List<InvoiceModel> Dashboard_Invoice_Create = DashboardRepository.Dashboard_Invoice_Create(InvoiceModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = Dashboard_Invoice_Create;
                _ResponseModel.length = Dashboard_Invoice_Create.Count();
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
        #endregion

        #region Dashboard_Invoice_Get
        [Route("api/Dashboard_Invoice_Get")]
        [HttpGet]
        public ResponseModel Dashboard_Invoice_Get([FromUri] InvoiceModel InvoiceModel)
        {

            try
            {
                CultureInfo cultureinfo = new CultureInfo("en-US");

                DashboardRepository DashboardRepository = new DashboardRepository();

                List<InvoiceModel> Dashboard_Invoice_Get = DashboardRepository.Dashboard_Invoice_Get(InvoiceModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = Dashboard_Invoice_Get;
                _ResponseModel.length = Dashboard_Invoice_Get.Count();
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
        #endregion

        #region Dashboard_Invoice_Total
        [Route("api/Dashboard_Invoice_Total")]
        [HttpGet]
        public ResponseModel Dashboard_Invoice_Total([FromUri] InvoiceModel InvoiceModel)
        {

            try
            {
                CultureInfo cultureinfo = new CultureInfo("en-US");

                DashboardRepository DashboardRepository = new DashboardRepository();

                List<InvoiceModel> Dashboard_Invoice_Total = DashboardRepository.Dashboard_Invoice_Total(InvoiceModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = Dashboard_Invoice_Total;
                _ResponseModel.length = Dashboard_Invoice_Total.Count();
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
        #endregion

        #region Dashboard_Invoice_Backlog
        [Route("api/Dashboard_Invoice_Backlog")]
        [HttpGet]
        public ResponseModel Dashboard_Invoice_Backlog([FromUri] InvoiceModel InvoiceModel)
        {

            try
            {
                CultureInfo cultureinfo = new CultureInfo("en-US");

                DashboardRepository DashboardRepository = new DashboardRepository();

                List<InvoiceModel> Dashboard_Invoice_Backlog = DashboardRepository.Dashboard_Invoice_Backlog(InvoiceModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = Dashboard_Invoice_Backlog;
                _ResponseModel.length = Dashboard_Invoice_Backlog.Count();
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
        #endregion

        #region TRP_TMS_Sync_Add
        [Route("v1/TRP_TMS_Sync_Add")]
        [HttpPost]
        public ResponseModel TRP_TMS_Sync_Add(List<TMS_JOBModel> TMS_JOBModel)
        {
            try
            {
                DashboardRepository TRPRepository = new DashboardRepository();

                TRPRepository.TRP_TMS_Sync_Delete();

                List<TMS_JOBModel> TMS_JOBModelList = new List<TMS_JOBModel>();

                foreach (var TMS_JOBItem in TMS_JOBModel)
                {
                    TMS_JOBModel TMS_JOBModel_data = new TMS_JOBModel();

                    TMS_JOBModel_data.tms_job_date = TMS_JOBItem.tms_job_date;
                    TMS_JOBModel_data.tms_job_route = TMS_JOBItem.tms_job_route;
                    TMS_JOBModel_data.tms_job_plate = TMS_JOBItem.tms_job_plate;
                    TMS_JOBModel_data.tms_job_name = TMS_JOBItem.tms_job_name;
                    TMS_JOBModel_data.tms_job_no = TMS_JOBItem.tms_job_no;
                    TMS_JOBModel_data.tms_job_cus_name = TMS_JOBItem.tms_job_cus_name;
                    TMS_JOBModel_data.tms_job_created_date = TMS_JOBItem.tms_job_created_date;
                    TMS_JOBModel_data.tms_job_delivery_date = TMS_JOBItem.tms_job_delivery_date;
                    TMS_JOBModel_data.tms_job_status = TMS_JOBItem.tms_job_status;

                    TMS_JOBModelList.Add(TMS_JOBModel_data);

                }

                TRPRepository.TRP_TMS_Sync_Add(TMS_JOBModelList);

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
        #endregion

    }
}
