﻿using REPO.Models;
using REPO.Controllers;
using System.Web.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;

namespace API.Controllers
{
    public class HrController : ApiController
    {
        #region Hr_Job_Get
        [Route("api/Hr_Job_Get")]
        [HttpGet]
        public ResponseModel Hr_Job_Get([FromUri] JobModel JobModel)
        {

            try
            {
                CultureInfo cultureinfo = new CultureInfo("en-US");

                HrRepository HrRepository = new HrRepository();

                List<JobModel> Hr_Job_Get = HrRepository.Hr_Job_Get(JobModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = Hr_Job_Get;
                _ResponseModel.length = Hr_Job_Get.Count();
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

        #region Hr_Job_List
        [Route("api/Hr_Job_List")]
        [HttpGet]
        public ResponseModel Hr_Job_List([FromUri] JobModel JobModel)
        {

            try
            {
                CultureInfo cultureinfo = new CultureInfo("en-US");

                HrRepository HrRepository = new HrRepository();

                List<JobModel> Hr_Job_List = HrRepository.Hr_Job_List(JobModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = Hr_Job_List;
                _ResponseModel.length = Hr_Job_List.Count();
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

        #region Hr_Job_Create
        [Route("api/Hr_Job_Create")]
        [HttpPost]
        public ResponseModel Hr_Job_Create([FromBody] JobModel JobModel)
        {

            try
            {
                CultureInfo cultureinfo = new CultureInfo("en-US");

                HrRepository HrRepository = new HrRepository();

                List<JobModel> Hr_Job_Create = HrRepository.Hr_Job_Create(JobModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = Hr_Job_Create;
                _ResponseModel.length = Hr_Job_Create.Count();
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

        #region Hr_Job_Update
        [Route("api/Hr_Job_Update")]
        [HttpPut]
        public ResponseModel Hr_Job_Update([FromBody] JobModel JobModel)
        {

            try
            {
                CultureInfo cultureinfo = new CultureInfo("en-US");

                HrRepository HrRepository = new HrRepository();

                List<JobModel> Hr_Job_Update = HrRepository.Hr_Job_Update(JobModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = Hr_Job_Update;
                _ResponseModel.length = Hr_Job_Update.Count();
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

        #region Hr_Job_Delete
        [Route("api/Hr_Job_Delete")]
        [HttpDelete]
        public ResponseModel Hr_Job_Delete([FromBody] JobModel JobModel)
        {

            try
            {
                CultureInfo cultureinfo = new CultureInfo("en-US");

                HrRepository HrRepository = new HrRepository();

                List<JobModel> Hr_Job_Delete = HrRepository.Hr_Job_Delete(JobModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = Hr_Job_Delete;
                _ResponseModel.length = Hr_Job_Delete.Count();
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

        #region Hr_Employee_Detail
        [Route("api/Hr_Employee_Detail")]
        [HttpGet]
        public ResponseModel Hr_Employee_Detail([FromUri] DetailModel DetailModel)
        {

            try
            {
                CultureInfo cultureinfo = new CultureInfo("en-US");

                HrRepository HrRepository = new HrRepository();

                List<DetailModel> Hr_Employee_Detail = HrRepository.Hr_Employee_Detail(DetailModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = Hr_Employee_Detail;
                _ResponseModel.length = Hr_Employee_Detail.Count();
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

        #region Hr_Employee_Time
        [Route("api/Hr_Employee_Time")]
        [HttpGet]
        public ResponseModel Hr_Employee_Time([FromUri] DetailModel DetailModel)
        {

            try
            {
                CultureInfo cultureinfo = new CultureInfo("en-US");

                HrRepository HrRepository = new HrRepository();

                List<DetailModel> Hr_Employee_Time = HrRepository.Hr_Employee_Time(DetailModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = Hr_Employee_Time;
                _ResponseModel.length = Hr_Employee_Time.Count();
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

        #region Hr_Quarter_Get
        [Route("api/Hr_Quarter_Get")]
        [HttpGet]
        public ResponseModel Hr_Quarter_Get([FromUri] QuarterModel QuarterModel)
        {

            try
            {
                CultureInfo cultureinfo = new CultureInfo("en-US");

                HrRepository HrRepository = new HrRepository();

                List<QuarterModel> Hr_Quarter_Get = HrRepository.Hr_Quarter_Get(QuarterModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = Hr_Quarter_Get;
                _ResponseModel.length = Hr_Quarter_Get.Count();
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

        #region Hr_Quarter_Create
        [Route("api/Hr_Quarter_Create")]
        [HttpPost]
        public ResponseModel Hr_Quarter_Create([FromBody] QuarterModel QuarterModel)
        {

            try
            {
                CultureInfo cultureinfo = new CultureInfo("en-US");

                HrRepository HrRepository = new HrRepository();

                List<QuarterModel> Hr_Quarter_Create = HrRepository.Hr_Quarter_Create(QuarterModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = Hr_Quarter_Create;
                _ResponseModel.length = Hr_Quarter_Create.Count();
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

        #region Hr_Quarter_Update
        [Route("api/Hr_Quarter_Update")]
        [HttpPost]
        public ResponseModel Hr_Quarter_Update([FromBody] QuarterModel QuarterModel)
        {

            try
            {
                CultureInfo cultureinfo = new CultureInfo("en-US");

                HrRepository HrRepository = new HrRepository();

                List<QuarterModel> Hr_Quarter_Update = HrRepository.Hr_Quarter_Update(QuarterModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = Hr_Quarter_Update;
                _ResponseModel.length = Hr_Quarter_Update.Count();
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

        #region Hr_Create_Data
        [Route("api/Hr_Create_Data")]
        [HttpPost]
        public ResponseModel Hr_Create_Data([FromBody] CreateDATAModel CreateDATAModel)
        {

            try
            {
                CultureInfo cultureinfo = new CultureInfo("en-US");

                HrRepository HrRepository = new HrRepository();

                List<CreateDATAModel> Hr_Create_Data = HrRepository.Hr_Create_Data(CreateDATAModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = Hr_Create_Data;
                _ResponseModel.length = Hr_Create_Data.Count();
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

        #region Hr_Create_Score
        [Route("api/Hr_Create_Score")]
        [HttpPost]
        public ResponseModel Hr_Create_Score(List<ScoreCreateModel> ScoreCreateModel)
        {
            try
            {
                HrRepository HrRepository = new HrRepository();

                //HrRepository.TRP_TMS_Sync_Delete();

                List<ScoreCreateModel> HR_ScoreModelList = new List<ScoreCreateModel>();

                foreach (var HR_SCOREItem in ScoreCreateModel)
                {
                    ScoreCreateModel HR_SCOREModel_data = new ScoreCreateModel();

                    HR_SCOREModel_data.sc_data_id = HR_SCOREItem.sc_data_id;
                    HR_SCOREModel_data.sc_topic = HR_SCOREItem.sc_topic;
                    HR_SCOREModel_data.sc_weight = HR_SCOREItem.sc_weight;
                    HR_SCOREModel_data.sc_score = HR_SCOREItem.sc_score;
                    HR_SCOREModel_data.sc_comment = HR_SCOREItem.sc_comment;
                    HR_SCOREModel_data.sc_order = HR_SCOREItem.sc_order;
                    HR_SCOREModel_data.created_by = HR_SCOREItem.created_by;
                    HR_SCOREModel_data.sc_subheader_id = HR_SCOREItem.sc_subheader_id;


                    HR_ScoreModelList.Add(HR_SCOREModel_data);

                }

                HrRepository.Hr_Create_Score(HR_ScoreModelList);

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

        #region Hr_Update_Data
        [Route("api/Hr_Update_Data")]
        [HttpPut]
        public ResponseModel Hr_Update_Data([FromBody] CreateDATAModel CreateDATAModel)
        {

            try
            {
                CultureInfo cultureinfo = new CultureInfo("en-US");

                HrRepository HrRepository = new HrRepository();

                List<CreateDATAModel> Hr_Update_Data = HrRepository.Hr_Update_Data(CreateDATAModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = Hr_Update_Data;
                _ResponseModel.length = Hr_Update_Data.Count();
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

        #region Hr_Delete_Data
        [Route("api/Hr_Delete_Data")]
        [HttpDelete]
        public ResponseModel Hr_Delete_Data([FromBody] CreateDATAModel CreateDATAModel)
        {

            try
            {
                CultureInfo cultureinfo = new CultureInfo("en-US");

                HrRepository HrRepository = new HrRepository();

                List<CreateDATAModel> Hr_Delete_Data = HrRepository.Hr_Delete_Data(CreateDATAModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = Hr_Delete_Data;
                _ResponseModel.length = Hr_Delete_Data.Count();
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

        #region Hr_Employee_Import_Create
        [Route("api/Hr_Employee_Import_Create")]
        [HttpPost]
        public ResponseModel Hr_Employee_Import_Create(List<EmployeeModel> EmployeeModel)
        {
            try
            {
                HrRepository HrRepository = new HrRepository();

                List<EmployeeModel> Employee_List = new List<EmployeeModel>();

                foreach (var Employee_Data in EmployeeModel)
                {
                    EmployeeModel TIME_JOBModel_data = new EmployeeModel();

                    TIME_JOBModel_data.temp_id = Employee_Data.temp_id;
                    TIME_JOBModel_data.action_type = Employee_Data.action_type;
                    TIME_JOBModel_data.employee_code = Employee_Data.employee_code;
                    TIME_JOBModel_data.employee_sec = Employee_Data.employee_sec;
                    TIME_JOBModel_data.employee_dept = Employee_Data.employee_dept;
                    TIME_JOBModel_data.employee_pos = Employee_Data.employee_pos;
                    TIME_JOBModel_data.employee_job_startdate = Employee_Data.employee_job_startdate;
                    TIME_JOBModel_data.employee_leader_asses1 = Employee_Data.employee_leader_asses1;
                    TIME_JOBModel_data.employee_leader_asses2 = Employee_Data.employee_leader_asses2;
                    TIME_JOBModel_data.employee_leader_asses3 = Employee_Data.employee_leader_asses3;
                    TIME_JOBModel_data.employee_form = Employee_Data.employee_form;
                    TIME_JOBModel_data.created_by = Employee_Data.created_by;
                    TIME_JOBModel_data.employee_prefix_th = Employee_Data.employee_prefix_th;
                    TIME_JOBModel_data.employee_first_name_th = Employee_Data.employee_first_name_th;
                    TIME_JOBModel_data.employee_last_name_th = Employee_Data.employee_last_name_th;
                    TIME_JOBModel_data.employee_nickname_th = Employee_Data.employee_nickname_th;
                    TIME_JOBModel_data.employee_prefix_en = Employee_Data.employee_prefix_en;
                    TIME_JOBModel_data.employee_first_name_en = Employee_Data.employee_first_name_en;
                    TIME_JOBModel_data.employee_last_name_en = Employee_Data.employee_last_name_en;
                    TIME_JOBModel_data.employee_nickname_en = Employee_Data.employee_nickname_en;
                    TIME_JOBModel_data.employee_level = Employee_Data.employee_level;
                    Employee_List.Add(TIME_JOBModel_data);

                }

                HrRepository.Hr_Employee_Import_Create(Employee_List);

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

        #region Hr_Employee_Import_Verify
        [Route("api/Hr_Employee_Import_Verify")]
        [HttpGet]
        public ResponseModel Hr_Employee_Import_Verify([FromUri] EmployeeModel EmployeeModel)
        {

            try
            {
                CultureInfo cultureinfo = new CultureInfo("en-US");

                HrRepository HrRepository = new HrRepository();

                List<EmployeeModel> Hr_Employee_Import_Verify = HrRepository.Hr_Employee_Import_Verify(EmployeeModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = Hr_Employee_Import_Verify;
                _ResponseModel.length = Hr_Employee_Import_Verify.Count();
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

        #region Hr_Employee_Import_Upload
        [Route("api/Hr_Employee_Import_Upload")]
        [HttpGet]
        public ResponseModel Hr_Employee_Import_Upload([FromUri] EmployeeModel EmployeeModel)
        {

            try
            {
                CultureInfo cultureinfo = new CultureInfo("en-US");

                HrRepository HrRepository = new HrRepository();

                List<EmployeeModel> Hr_Employee_Import_Upload = HrRepository.Hr_Employee_Import_Upload(EmployeeModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = Hr_Employee_Import_Upload;
                _ResponseModel.length = Hr_Employee_Import_Upload.Count();
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

        #region Hr_Employee_Create
        [Route("api/Hr_Employee_Create")]
        [HttpPost]
        public ResponseModel Hr_Employee_Create([FromBody] EmployeeModel EmployeeModel)
        {

            try
            {
                CultureInfo cultureinfo = new CultureInfo("en-US");

                HrRepository HrRepository = new HrRepository();

                List<EmployeeModel> Hr_Employee_Create = HrRepository.Hr_Employee_Create(EmployeeModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = Hr_Employee_Create;
                _ResponseModel.length = Hr_Employee_Create.Count();
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

        #region Hr_Employee_Update
        [Route("api/Hr_Employee_Update")]
        [HttpPut]
        public ResponseModel Hr_Employee_Update([FromBody] EmployeeModel EmployeeModel)
        {

            try
            {
                CultureInfo cultureinfo = new CultureInfo("en-US");

                HrRepository HrRepository = new HrRepository();

                List<EmployeeModel> Hr_Employee_Update = HrRepository.Hr_Employee_Update(EmployeeModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = Hr_Employee_Update;
                _ResponseModel.length = Hr_Employee_Update.Count();
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

        #region Hr_Employee_Get
        [Route("api/Hr_Employee_Get")]
        [HttpGet]
        public ResponseModel Hr_Employee_Get([FromUri] EmployeeModel EmployeeModel)
        {

            try
            {
                CultureInfo cultureinfo = new CultureInfo("en-US");

                HrRepository HrRepository = new HrRepository();

                List<EmployeeModel> Hr_Employee_Get = HrRepository.Hr_Employee_Get(EmployeeModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = Hr_Employee_Get;
                _ResponseModel.length = Hr_Employee_Get.Count();
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

        #region Hr_Employee_Delete
        [Route("api/Hr_Employee_Delete")]
        [HttpDelete]
        public ResponseModel Hr_Employee_Delete([FromBody] EmployeeModel EmployeeModel)
        {

            try
            {
                CultureInfo cultureinfo = new CultureInfo("en-US");

                HrRepository HrRepository = new HrRepository();

                List<EmployeeModel> Hr_Employee_Delete = HrRepository.Hr_Employee_Delete(EmployeeModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = Hr_Employee_Delete;
                _ResponseModel.length = Hr_Employee_Delete.Count();
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

        #region Hr_Time_Get
        [Route("api/Hr_Time_Get")]
        [HttpGet]
        public ResponseModel Hr_Time_Get([FromUri] TimeModel TimeModel)
        {

            try
            {
                CultureInfo cultureinfo = new CultureInfo("en-US");

                HrRepository HrRepository = new HrRepository();

                List<TimeModel> Hr_Time_Get = HrRepository.Hr_Time_Get(TimeModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = Hr_Time_Get;
                _ResponseModel.length = Hr_Time_Get.Count();
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

        #region Hr_Time_Create
        [Route("api/Hr_Time_Create")]
        [HttpPost]
        public ResponseModel Hr_Time_Create(List<TimeModel> TimeModel)
        {
            try
            {
                HrRepository HrRepository = new HrRepository();

                //HrRepository.TRP_TMS_Sync_Delete();

                List<TimeModel> TIME_JOBModelList = new List<TimeModel>();

                foreach (var TMS_JOBItem in TimeModel)
                {
                    TimeModel TIME_JOBModel_data = new TimeModel();

                    TIME_JOBModel_data.time_employee_code = TMS_JOBItem.time_employee_code;
                    TIME_JOBModel_data.time_employee_name = TMS_JOBItem.time_employee_name;
                    TIME_JOBModel_data.time_employee_pos = TMS_JOBItem.time_employee_pos;
                    TIME_JOBModel_data.time_late_count = TMS_JOBItem.time_late_count;
                    TIME_JOBModel_data.time_late_time = TMS_JOBItem.time_late_time;
                    TIME_JOBModel_data.time_absent_count = TMS_JOBItem.time_absent_count;
                    TIME_JOBModel_data.time_absent_time = TMS_JOBItem.time_absent_time;
                    TIME_JOBModel_data.time_sick_leave = TMS_JOBItem.time_sick_leave;
                    TIME_JOBModel_data.time_personal_leave = TMS_JOBItem.time_personal_leave;
                    TIME_JOBModel_data.time_maternity_leave = TMS_JOBItem.time_maternity_leave;
                    TIME_JOBModel_data.time_ordination_leave = TMS_JOBItem.time_ordination_leave;
                    TIME_JOBModel_data.time_wage_leave = TMS_JOBItem.time_wage_leave;
                    TIME_JOBModel_data.time_funeral_wedding_leave = TMS_JOBItem.time_funeral_wedding_leave;
                    TIME_JOBModel_data.time_warning_leave = TMS_JOBItem.time_warning_leave;
                    TIME_JOBModel_data.time_probate_leave = TMS_JOBItem.time_probate_leave;
                    TIME_JOBModel_data.time_data_quarter = TMS_JOBItem.time_data_quarter;
                    TIME_JOBModel_data.created_by = TMS_JOBItem.created_by;


                    TIME_JOBModelList.Add(TIME_JOBModel_data);

                }

                HrRepository.Hr_Time_Create(TIME_JOBModelList);

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

        #region Hr_Check_Data
        [Route("api/Hr_Check_Data")]
        [HttpGet]
        public ResponseModel Hr_Check_Data([FromUri] ChackDataModel ChackDataModel)
        {

            try
            {
                CultureInfo cultureinfo = new CultureInfo("en-US");

                HrRepository HrRepository = new HrRepository();

                List<ChackDataModel> Hr_Check_Data = HrRepository.Hr_Check_Data(ChackDataModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = Hr_Check_Data;
                _ResponseModel.length = Hr_Check_Data.Count();
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

        #region Hr_Results_Admin_Get
        [Route("api/Hr_Results_Admin_Get")]
        [HttpGet]
        public ResponseModel Hr_Results_Admin_Get([FromUri] ResultsModel ResultsModel)
        {

            try
            {
                CultureInfo cultureinfo = new CultureInfo("en-US");

                HrRepository HrRepository = new HrRepository();

                List<ResultsModel> Hr_Results_Admin_Get = HrRepository.Hr_Results_Admin_Get(ResultsModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = Hr_Results_Admin_Get;
                _ResponseModel.length = Hr_Results_Admin_Get.Count();
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

        #region Hr_Results_Manage_Get
        [Route("api/Hr_Results_Manage_Get")]
        [HttpGet]
        public ResponseModel Hr_Results_Manage_Get([FromUri] ResultsModel ResultsModel)
        {

            try
            {
                CultureInfo cultureinfo = new CultureInfo("en-US");

                HrRepository HrRepository = new HrRepository();

                List<ResultsModel> Hr_Results_Manage_Get = HrRepository.Hr_Results_Manage_Get(ResultsModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = Hr_Results_Manage_Get;
                _ResponseModel.length = Hr_Results_Manage_Get.Count();
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

        #region Hr_Report_Pms
        [Route("api/Hr_Report_Pms")]
        [HttpGet]
        public ResponseModel Hr_Report_Pms([FromUri] ReportPmsModel ReportPmsModel)
        {

            try
            {
                CultureInfo cultureinfo = new CultureInfo("en-US");

                HrRepository HrRepository = new HrRepository();

                List<ReportPmsModel> Hr_Report_Pms = HrRepository.Hr_Report_Pms(ReportPmsModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = Hr_Report_Pms;
                _ResponseModel.length = Hr_Report_Pms.Count();
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

        #region Hr_Form_Get
        [Route("api/Hr_Form_Get")]
        [HttpGet]
        public ResponseModel Hr_Form_Get([FromUri] FormModel FormModel)
        {

            try
            {
                CultureInfo cultureinfo = new CultureInfo("en-US");

                HrRepository HrRepository = new HrRepository();

                List<FormModel> Hr_Form_Get = HrRepository.Hr_Form_Get(FormModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = Hr_Form_Get;
                _ResponseModel.length = Hr_Form_Get.Count();
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

        #region Hr_Form_More_Get
        [Route("api/Hr_Form_More_Get")]
        [HttpGet]
        public ResponseModel Hr_Form_More_Get([FromUri] FormModel FormModel)
        {

            try
            {
                CultureInfo cultureinfo = new CultureInfo("en-US");

                HrRepository HrRepository = new HrRepository();

                List<FormModel> Hr_Form_More_Get = HrRepository.Hr_Form_More_Get(FormModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = Hr_Form_More_Get;
                _ResponseModel.length = Hr_Form_More_Get.Count();
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

        #region Hr_Verify_Employee
        [Route("api/Hr_Verify_Employee")]
        [HttpGet]
        public ResponseModel Hr_Verify_Employee([FromUri] DetailModel DetailModel)
        {

            try
            {
                CultureInfo cultureinfo = new CultureInfo("en-US");

                HrRepository HrRepository = new HrRepository();

                List<DetailModel> Hr_Verify_Employee = HrRepository.Hr_Verify_Employee(DetailModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = Hr_Verify_Employee;
                _ResponseModel.length = Hr_Verify_Employee.Count();
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

        #region Hr_Result_Assess_Get
        [Route("api/Hr_Result_Assess_Get")]
        [HttpGet]
        public ResponseModel Hr_Result_Assess_Get([FromUri] Result_Assess_Model Result_Assess_Model)
        {

            try
            {
                CultureInfo cultureinfo = new CultureInfo("en-US");

                HrRepository HrRepository = new HrRepository();

                List<Result_Assess_Model> Hr_Result_Assess_Get = HrRepository.Hr_Result_Assess_Get(Result_Assess_Model);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = Hr_Result_Assess_Get;
                _ResponseModel.length = Hr_Result_Assess_Get.Count();
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

        #region Hr_Master_Get
        [Route("api/Hr_Master_Get")]
        [HttpGet]
        public ResponseModel Hr_Master_Get([FromUri] Master_Model Master_Model)
        {

            try
            {
                CultureInfo cultureinfo = new CultureInfo("en-US");

                HrRepository HrRepository = new HrRepository();

                List<Master_Model> Hr_Master_Get = HrRepository.Hr_Master_Get(Master_Model);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = Hr_Master_Get;
                _ResponseModel.length = Hr_Master_Get.Count();
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

        #region Hr_Verify_Assess_Get
        [Route("api/Hr_Verify_Assess_Get")]
        [HttpGet]
        public ResponseModel Hr_Verify_Assess_Get([FromUri] EmployeeModel EmployeeModel)
        {

            try
            {
                CultureInfo cultureinfo = new CultureInfo("en-US");

                HrRepository HrRepository = new HrRepository();

                List<EmployeeModel> Hr_Verify_Assess_Get = HrRepository.Hr_Verify_Assess_Get(EmployeeModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = Hr_Verify_Assess_Get;
                _ResponseModel.length = Hr_Verify_Assess_Get.Count();
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

        #region Hr_Assess_Confirm
        [Route("api/Hr_Assess_Confirm")]
        [HttpGet]
        public ResponseModel Hr_Assess_Confirm([FromUri] Confirm_Model Confirm_Model)
        {

            try
            {
                CultureInfo cultureinfo = new CultureInfo("en-US");

                HrRepository HrRepository = new HrRepository();

                List<Confirm_Model> Hr_Assess_Confirm = HrRepository.Hr_Assess_Confirm(Confirm_Model);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = Hr_Assess_Confirm;
                _ResponseModel.length = Hr_Assess_Confirm.Count();
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
