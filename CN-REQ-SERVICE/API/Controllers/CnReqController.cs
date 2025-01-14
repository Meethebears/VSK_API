﻿using REPO.Models;
using REPO.Controllers;
using System.Web.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;

namespace API.Controllers
{
    public class CnReqController : ApiController
    {
        #region Cn_Req_Saletra_Get
        [Route("api/Cn_Req_Saletra_Get")]
        [HttpGet]
        public ResponseModel Cn_Req_Saletra_Get([FromUri] string cn_req_salefile_number)
        {

            try
            {
                CultureInfo cultureinfo = new CultureInfo("en-US");

                CnReqRepository CnReqRepository = new CnReqRepository();

                List<CnReqSaletraModel> Cn_Req_Saletra_Get = CnReqRepository.Cn_Req_Saletra_Get(cn_req_salefile_number);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = Cn_Req_Saletra_Get;
                _ResponseModel.length = Cn_Req_Saletra_Get.Count();
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

        #region Cn_Req_Job_Daily_Get
        [Route("api/Cn_Req_Job_Daily_Get")]
        [HttpGet]
        public ResponseModel Cn_Pre_Job_Get([FromUri] CnReqModel CnReqModel)
        {

            try
            {
                CultureInfo cultureinfo = new CultureInfo("en-US");

                CnReqRepository CnReqRepository = new CnReqRepository();

                List<CnReqModel> Cn_Req_Job_Daily_Get = CnReqRepository.Cn_Req_Job_Daily_Get();

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = Cn_Req_Job_Daily_Get;
                _ResponseModel.length = Cn_Req_Job_Daily_Get.Count();
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

        #region Cn_Req_Job_Create
        [Route("api/Cn_Req_Job_Create")]
        [HttpPut]
        public ResponseModel Cn_Req_Job_Create([FromBody] CnReqModel CnReqModel)
        {

            try
            {
                //  CultureInfo cultureinfo = new CultureInfo("en-US");

                CnReqRepository CnReqRepository = new CnReqRepository();

                List<CnReqModel> Cn_Req_Job_Create = CnReqRepository.Cn_Req_Job_Create(CnReqModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = Cn_Req_Job_Create;
                _ResponseModel.length = Cn_Req_Job_Create.Count();
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

        #region Cn_Req_Job_Search_Get
        [Route("api/Cn_Req_Job_Search_Get")]
        [HttpGet]
        public ResponseModel Cn_Req_Job_Search_Get([FromUri] CnReqModel CnReqModel)
        {

            try
            {
                CultureInfo cultureinfo = new CultureInfo("en-US");

                CnReqRepository CnReqRepository = new CnReqRepository();

                List<CnReqModel> Cn_Req_Job_Search_Get = CnReqRepository.Cn_Req_Job_Search_Get(CnReqModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = Cn_Req_Job_Search_Get;
                _ResponseModel.length = Cn_Req_Job_Search_Get.Count();
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

        #region Cn_Req_Source_Update
        [Route("api/Cn_Req_Source_Update")]
        [HttpPut]
        public ResponseModel Cn_Req_Source_Update([FromBody] CnReqSourceModel CnReqSourceModel)
        {

            try
            {
                //  CultureInfo cultureinfo = new CultureInfo("en-US");

                CnReqRepository CnReqRepository = new CnReqRepository();

                CnReqRepository.Cn_Req_Source_Update(CnReqSourceModel);

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

        #region Cn_Req_Assige_Update
        [Route("api/Cn_Req_Assige_Update")]
        [HttpPut]
        public ResponseModel Cn_Req_Assige_Update([FromBody] CnReqAssigeModel CnReqAssigeModel)
        {

            try
            {
                //  CultureInfo cultureinfo = new CultureInfo("en-US");

                CnReqRepository CnReqRepository = new CnReqRepository();

                CnReqRepository.Cn_Req_Assige_Update(CnReqAssigeModel);

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

        #region Cn_Req_Driver_Update
        [Route("api/Cn_Req_Driver_Update")]
        [HttpPut]
        public ResponseModel Cn_Req_Driver_Update([FromBody] CnReqDriverModel CnReqDriverModel)
        {

            try
            {
                //  CultureInfo cultureinfo = new CultureInfo("en-US");

                CnReqRepository CnReqRepository = new CnReqRepository();

                CnReqRepository.Cn_Req_Driver_Update(CnReqDriverModel);

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

        #region Cn_Req_Condition_Update
        [Route("api/Cn_Req_Condition_Update")]
        [HttpPut]
        public ResponseModel Cn_Req_Condition_Update([FromBody] CnReqConditionModel CnReqConditionModel)
        {

            try
            {
                //  CultureInfo cultureinfo = new CultureInfo("en-US");

                CnReqRepository CnReqRepository = new CnReqRepository();

                CnReqRepository.Cn_Req_Condition_Update(CnReqConditionModel);

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

        #region Cn_Req_Status_Update
        [Route("api/Cn_Req_Status_Update")]
        [HttpPut]
        public ResponseModel Cn_Req_Status_Update([FromBody] CnReqStatusModel CnReqStatusModel)
        {

            try
            {
                //  CultureInfo cultureinfo = new CultureInfo("en-US");

                CnReqRepository CnReqRepository = new CnReqRepository();

                CnReqRepository.Cn_Req_Status_Update(CnReqStatusModel);

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

        #region Cn_Req_Source_Get
        [Route("api/Cn_Req_Source_Get")]
        [HttpGet]
        public ResponseModel Cn_Req_Source_Get([FromUri] CnReqSourceModel CnReqSourceModel)
        {

            try
            {
                CultureInfo cultureinfo = new CultureInfo("en-US");

                CnReqRepository CnReqRepository = new CnReqRepository();

                List<CnReqSourceModel> Cn_Req_Source_Get = CnReqRepository.Cn_Req_Source_Get(CnReqSourceModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = Cn_Req_Source_Get;
                _ResponseModel.length = Cn_Req_Source_Get.Count();
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

        #region Cn_Req_Status_Get
        [Route("api/Cn_Req_Status_Get")]
        [HttpGet]
        public ResponseModel Cn_Req_Status_Get([FromUri] CnReqStatusModel CnReqStatusModel)
        {

            try
            {
                CultureInfo cultureinfo = new CultureInfo("en-US");

                CnReqRepository CnReqRepository = new CnReqRepository();

                List<CnReqStatusModel> Cn_Req_Status_Get = CnReqRepository.Cn_Req_Status_Get(CnReqStatusModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = Cn_Req_Status_Get;
                _ResponseModel.length = Cn_Req_Status_Get.Count();
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

        #region Cn_Req_Driver_Get
        [Route("api/Cn_Req_Driver_Get")]
        [HttpGet]
        public ResponseModel Cn_Req_Driver_Get([FromUri] CnReqDriverModel CnReqDriverModel)
        {

            try
            {
                CultureInfo cultureinfo = new CultureInfo("en-US");

                CnReqRepository CnReqRepository = new CnReqRepository();

                List<CnReqDriverModel> Cn_Req_Driver_Get = CnReqRepository.Cn_Req_Driver_Get(CnReqDriverModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = Cn_Req_Driver_Get;
                _ResponseModel.length = Cn_Req_Driver_Get.Count();
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

        #region Cn_Req_Condition_Get
        [Route("api/Cn_Req_Condition_Get")]
        [HttpGet]
        public ResponseModel Cn_Req_Condition_Get([FromUri] CnReqConditionModel CnReqConditionModel)
        {

            try
            {
                CultureInfo cultureinfo = new CultureInfo("en-US");

                CnReqRepository CnReqRepository = new CnReqRepository();

                List<CnReqConditionModel> Cn_Req_Condition_Get = CnReqRepository.Cn_Req_Condition_Get(CnReqConditionModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = Cn_Req_Condition_Get;
                _ResponseModel.length = Cn_Req_Condition_Get.Count();
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

        #region Cn_Req_Assige_Get
        [Route("api/Cn_Req_Assige_Get")]
        [HttpGet]
        public ResponseModel Cn_Req_Assige_Get([FromUri] CnReqAssigeModel CnReqAssigeModel)
        {

            try
            {
                CultureInfo cultureinfo = new CultureInfo("en-US");

                CnReqRepository CnReqRepository = new CnReqRepository();

                List<CnReqAssigeModel> Cn_Req_Assige_Get = CnReqRepository.Cn_Req_Assige_Get(CnReqAssigeModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = Cn_Req_Assige_Get;
                _ResponseModel.length = Cn_Req_Assige_Get.Count();
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

        #region Cn_Req_Cause_Master_Get
        [Route("api/Cn_Req_Cause_Master_Get")]
        [HttpGet]
        public ResponseModel Cn_Req_Cause_Master_Get()
        {

            try
            {
                CultureInfo cultureinfo = new CultureInfo("en-US");

                CnReqRepository CnReqRepository = new CnReqRepository();

                List<CnReqLOVModel> Cn_Req_Cause_Master_Get = CnReqRepository.Cn_Req_Cause_Master_Get();

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = Cn_Req_Cause_Master_Get;
                _ResponseModel.length = Cn_Req_Cause_Master_Get.Count();
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

        #region Cn_Req_Assige_Master_Get
        [Route("api/Cn_Req_Assige_Master_Get")]
        [HttpGet]
        public ResponseModel Cn_Req_Assige_Master_Get()
        {

            try
            {
                CultureInfo cultureinfo = new CultureInfo("en-US");

                CnReqRepository CnReqRepository = new CnReqRepository();

                List<CnReqLOVModel> Cn_Req_Assige_Master_Get = CnReqRepository.Cn_Req_Assige_Master_Get();

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = Cn_Req_Assige_Master_Get;
                _ResponseModel.length = Cn_Req_Assige_Master_Get.Count();
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

        #region Cn_Req_Source_Master_Get
        [Route("api/Cn_Req_Source_Master_Get")]
        [HttpGet]
        public ResponseModel Cn_Req_Source_Master_Get()
        {

            try
            {
                CultureInfo cultureinfo = new CultureInfo("en-US");

                CnReqRepository CnReqRepository = new CnReqRepository();

                List<CnReqLOVModel> Cn_Req_Source_Master_Get = CnReqRepository.Cn_Req_Source_Master_Get();

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = Cn_Req_Source_Master_Get;
                _ResponseModel.length = Cn_Req_Source_Master_Get.Count();
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

        #region Cn_Req_Status_Master_Get
        [Route("api/Cn_Req_Status_Master_Get")]
        [HttpGet]
        public ResponseModel Cn_Req_Status_Master_Get()
        {

            try
            {
                CultureInfo cultureinfo = new CultureInfo("en-US");

                CnReqRepository CnReqRepository = new CnReqRepository();

                List<CnReqLOVModel> Cn_Req_Status_Master_Get = CnReqRepository.Cn_Req_Status_Master_Get();

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = Cn_Req_Status_Master_Get;
                _ResponseModel.length = Cn_Req_Status_Master_Get.Count();
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

        #region Cn_Req_Remark_Get
        [Route("api/Cn_Req_Remark_Get")]
        [HttpGet]
        public ResponseModel Cn_Req_Remark_Get([FromUri] CnReqRemarkModel CnReqRemarkModel)
        {

            try
            {
                CultureInfo cultureinfo = new CultureInfo("en-US");

                CnReqRepository CnReqRepository = new CnReqRepository();

                List<CnReqRemarkModel> Cn_Req_Remark_Get = CnReqRepository.Cn_Req_Remark_Get(CnReqRemarkModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = Cn_Req_Remark_Get;
                _ResponseModel.length = Cn_Req_Remark_Get.Count();
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

        #region Cn_Req_Remark_Update
        [Route("api/Cn_Req_Remark_Update")]
        [HttpPut]
        public ResponseModel Cn_Req_Remark_Update([FromBody] CnReqRemarkModel CnReqRemarkModel)
        {

            try
            {
                //  CultureInfo cultureinfo = new CultureInfo("en-US");

                CnReqRepository CnReqRepository = new CnReqRepository();

                CnReqRepository.Cn_Req_Remark_Update(CnReqRemarkModel);

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

        #region Cn_Req_Cause_Get
        [Route("api/Cn_Req_Cause_Get")]
        [HttpGet]
        public ResponseModel Cn_Req_Cause_Get([FromUri] CnReqCauseModel CnReqCauseModel)
        {

            try
            {
                CultureInfo cultureinfo = new CultureInfo("en-US");

                CnReqRepository CnReqRepository = new CnReqRepository();

                List<CnReqCauseModel> Cn_Req_Cause_Get = CnReqRepository.Cn_Req_Cause_Get(CnReqCauseModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = Cn_Req_Cause_Get;
                _ResponseModel.length = Cn_Req_Cause_Get.Count();
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

        #region Cn_Req_Cause_Update
        [Route("api/Cn_Req_Cause_Update")]
        [HttpPut]
        public ResponseModel Cn_Req_Cause_Update([FromBody] CnReqCauseModel CnReqCauseModel)
        {

            try
            {
                //  CultureInfo cultureinfo = new CultureInfo("en-US");

                CnReqRepository CnReqRepository = new CnReqRepository();

                CnReqRepository.Cn_Req_Cause_Update(CnReqCauseModel);

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

        #region Cn_Req_Job_Update
        [Route("api/Cn_Req_Job_Update")]
        [HttpPut]
        public ResponseModel Cn_Req_Job_Update([FromBody] CnReqModel CnReqModel)
        {

            try
            {
                //  CultureInfo cultureinfo = new CultureInfo("en-US");

                CnReqRepository CnReqRepository = new CnReqRepository();

                CnReqRepository.Cn_Req_Job_Update(CnReqModel);

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


        // Tan Cr 2023-08-07 STRAT
        #region Cn_Req_Saletra_Branch_Get
        [Route("api/Cn_Req_Saletra_Branch_Get")]
        [HttpGet]
        public ResponseModel Cn_Req_Saletra_Branch_Get([FromUri] string branch, string number)
        {
            try
            {
                CnReqRepository CnReqRepository = new CnReqRepository();
                ResponseModel _ResponseModel = new ResponseModel();

                List<CnReqSaletraModel> Cn_Req_Saletra_Branch_Get = CnReqRepository.Cn_Req_Saletra_Branch_Get(branch, number);

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = Cn_Req_Saletra_Branch_Get;
                _ResponseModel.length = Cn_Req_Saletra_Branch_Get.Count();
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

        #region Cn_Req_Tmp_Saletra_Create
        [Route("api/Cn_Req_Tmp_Saletra_Create")]
        [HttpPost]
        public ResponseModel Cn_Req_Tmp_Saletra_Create([FromBody] CnReqModel CnReqModel)
        {
            try
            {
                CnReqRepository CnReqRepository = new CnReqRepository();

                List<CnReqModel> Cn_Req_Tmp_Saletra_Create = CnReqRepository.Cn_Req_Tmp_Saletra_Create(CnReqModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = Cn_Req_Tmp_Saletra_Create;
                _ResponseModel.length = Cn_Req_Tmp_Saletra_Create.Count();
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
        // Tan Cr 2023-08-07 END

    }
}
