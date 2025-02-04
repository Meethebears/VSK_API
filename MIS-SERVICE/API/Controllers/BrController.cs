﻿using REPO.Models;
using REPO.Controllers;
using System.Web.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;

namespace API.Controllers
{
    public class BrController : ApiController
    {

        #region Br_Brtra_Job
        [Route("api/Br_Brtra_Job")]
        [HttpGet]
        public ResponseModel Br_Brtra_Job([FromUri] BrModel BrModel)
        {

            try
            {
                CultureInfo cultureinfo = new CultureInfo("en-US");

                BrRepository BrRepository = new BrRepository();

                List<BrModel> Br_Brtra_Job = BrRepository.Br_Brtra_Job(BrModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = Br_Brtra_Job;
                _ResponseModel.length = Br_Brtra_Job.Count();
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

        #region Br_Brtra_Get
        [Route("api/Br_Brtra_Get")]
        [HttpGet]
        public ResponseModel Br_Brtra_Get([FromUri] BrModel BrModel)
        {

            try
            {
                CultureInfo cultureinfo = new CultureInfo("en-US");

                BrRepository BrRepository = new BrRepository();

                List<BrModel> Br_Brtra_Get = BrRepository.Br_Brtra_Get(BrModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = Br_Brtra_Get;
                _ResponseModel.length = Br_Brtra_Get.Count();
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

        #region Br_Brtra_Update
        [Route("api/Br_Brtra_Update")]
        [HttpPut]
        public ResponseModel Br_Brtra_Update([FromBody] BrModel BrModel)
        {

            try
            {
                CultureInfo cultureinfo = new CultureInfo("en-US");

                BrRepository BrRepository = new BrRepository();

                List<BrModel> Br_Brtra_Update = BrRepository.Br_Brtra_Update(BrModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = Br_Brtra_Update;
                _ResponseModel.length = Br_Brtra_Update.Count();
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

        #region Br_Brtra_History
        [Route("api/Br_Brtra_History")]
        [HttpGet]
        public ResponseModel Br_Brtra_History([FromUri] BrModel BrModel)
        {

            try
            {
                CultureInfo cultureinfo = new CultureInfo("en-US");

                BrRepository BrRepository = new BrRepository();

                List<BrModel> Br_Brtra_History = BrRepository.Br_Brtra_History(BrModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = Br_Brtra_History;
                _ResponseModel.length = Br_Brtra_History.Count();
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

        #region Br_Brtra_Lov
        [Route("api/Br_Brtra_Lov")]
        [HttpGet]
        public ResponseModel Br_Brtra_Lov([FromUri] LovModel LovModel)
        {

            try
            {
                CultureInfo cultureinfo = new CultureInfo("en-US");

                BrRepository BrRepository = new BrRepository();

                List<LovModel> Br_Brtra_Lov = BrRepository.Br_Brtra_Lov(LovModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = Br_Brtra_Lov;
                _ResponseModel.length = Br_Brtra_Lov.Count();
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

        #region Br_Lov_Route_Get
        [Route("api/Br_Lov_Route_Get")]
        [HttpGet]
        public ResponseModel Br_Lov_Route_Get([FromUri] LovModel LovModel)
        {

            try
            {
                CultureInfo cultureinfo = new CultureInfo("en-US");

                BrRepository BrRepository = new BrRepository();

                List<LovModel> Br_Lov_Route_Get = BrRepository.Br_Lov_Route_Get(LovModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = Br_Lov_Route_Get;
                _ResponseModel.length = Br_Lov_Route_Get.Count();
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

        #region Br_Deliver_Job
        [Route("api/Br_Deliver_Job")]
        [HttpPost]
        public ResponseModel Br_Deliver_Job([FromBody] BrDeliverModel BrDeliverModel)
        {

            try
            {
                CultureInfo cultureinfo = new CultureInfo("en-US");

                BrRepository BrRepository = new BrRepository();

                List<BrDeliverModel> Br_Deliver_Job = BrRepository.Br_Deliver_Job(BrDeliverModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = Br_Deliver_Job;
                _ResponseModel.length = Br_Deliver_Job.Count();
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

        #region Br_Lov_Driver_Get
        [Route("api/Br_Lov_Driver_Get")]
        [HttpGet]
        public ResponseModel Br_Lov_Driver_Get([FromUri] DriverModel DriverModel)
        {

            try
            {
                CultureInfo cultureinfo = new CultureInfo("en-US");

                BrRepository BrRepository = new BrRepository();

                List<DriverModel> Br_Lov_Driver_Get = BrRepository.Br_Lov_Driver_Get(DriverModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = Br_Lov_Driver_Get;
                _ResponseModel.length = Br_Lov_Driver_Get.Count();
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

        #region Br_Brtra_History_Deliver
        [Route("api/Br_Brtra_History_Deliver")]
        [HttpGet]
        public ResponseModel Br_Brtra_History_Deliver([FromUri] DriverModel DriverModel)
        {

            try
            {
                CultureInfo cultureinfo = new CultureInfo("en-US");

                BrRepository BrRepository = new BrRepository();

                List<DriverModel> Br_Brtra_History_Deliver = BrRepository.Br_Brtra_History_Deliver(DriverModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = Br_Brtra_History_Deliver;
                _ResponseModel.length = Br_Brtra_History_Deliver.Count();
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

        #region Br_Brtra_Get_v1
        [Route("api/Br_Brtra_Get_v1")]
        [HttpGet]
        public ResponseModel Br_Brtra_Get_v1([FromUri] BrModel BrModel)
        {

            try
            {
                CultureInfo cultureinfo = new CultureInfo("en-US");

                BrRepository BrRepository = new BrRepository();

                List<BrModel> Br_Brtra_Get_v1 = BrRepository.Br_Brtra_Get_v1(BrModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = Br_Brtra_Get_v1;
                _ResponseModel.length = Br_Brtra_Get_v1.Count();
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

        #region Tr_Job
        [Route("api/Tr_Job")]
        [HttpGet]
        public ResponseModel Tr_Job([FromUri] TranferModel TranferModel)
        {

            try
            {
                CultureInfo cultureinfo = new CultureInfo("en-US");

                BrRepository BrRepository = new BrRepository();

                List<TranferModel> Tr_Job = BrRepository.Tr_Job(TranferModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = Tr_Job;
                _ResponseModel.length = Tr_Job.Count();
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

        #region Tr_Update
        [Route("api/Tr_Update")]
        [HttpPut]
        public ResponseModel Tr_Update([FromBody] TranferModel TranferModel)
        {

            try
            {
                CultureInfo cultureinfo = new CultureInfo("en-US");

                BrRepository BrRepository = new BrRepository();

                List<TranferModel> Tr_Update = BrRepository.Tr_Update(TranferModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = Tr_Update;
                _ResponseModel.length = Tr_Update.Count();
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

        #region Tr_Get
        [Route("api/Tr_Get")]
        [HttpGet]
        public ResponseModel Tr_Get([FromUri] TranGetModel TranGetModel)
        {

            try
            {
                CultureInfo cultureinfo = new CultureInfo("en-US");

                BrRepository BrRepository = new BrRepository();

                List<TranGetModel> Tr_Get = BrRepository.Tr_Get(TranGetModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = Tr_Get;
                _ResponseModel.length = Tr_Get.Count();
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

        #region Tr_History
        [Route("api/Tr_History")]
        [HttpGet]
        public ResponseModel Tr_History([FromUri] TranHistoryModel TranHistoryModel)
        {

            try
            {
                CultureInfo cultureinfo = new CultureInfo("en-US");

                BrRepository BrRepository = new BrRepository();

                List<TranHistoryModel> Tr_History = BrRepository.Tr_History(TranHistoryModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = Tr_History;
                _ResponseModel.length = Tr_History.Count();
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

        #region Tr_Item
        [Route("api/Tr_Item")]
        [HttpGet]
        public ResponseModel Tr_Item([FromUri] TranHistoryModel TranHistoryModel)
        {

            try
            {
                CultureInfo cultureinfo = new CultureInfo("en-US");

                BrRepository BrRepository = new BrRepository();

                List<TranHistoryModel> Tr_Item = BrRepository.Tr_Item(TranHistoryModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = Tr_Item;
                _ResponseModel.length = Tr_Item.Count();
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

        #region Tr_Remark
        [Route("api/Tr_Remark")]
        [HttpPost]
        public ResponseModel Tr_Remark([FromBody] TranRemarkModel TranRemarkModel)
        {

            try
            {
                CultureInfo cultureinfo = new CultureInfo("en-US");

                BrRepository BrRepository = new BrRepository();

                List<TranRemarkModel> Tr_Remark = BrRepository.Tr_Remark(TranRemarkModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = Tr_Remark;
                _ResponseModel.length = Tr_Remark.Count();
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

        #region Br_Report_Get
        [Route("api/Br_Report_Get")]
        [HttpGet]
        public ResponseModel Br_Report_Get([FromUri] BrReportModel BrReportModel)
        {

            try
            {
                CultureInfo cultureinfo = new CultureInfo("en-US");

                BrRepository BrRepository = new BrRepository();

                List<BrReportModel> Br_Report_Get = BrRepository.Br_Report_Get(BrReportModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = Br_Report_Get;
                _ResponseModel.length = Br_Report_Get.Count();
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
