using REPO.Models;
using REPO.Controllers;
using System.Web.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;

namespace API.Controllers
{
    public class CnBranchRtqController : ApiController
    {

        #region Cn_Branch_Rtq_Job_Create
        [Route("api/Cn_Branch_Rtq_Job_Create")]
        [HttpPut]
        public ResponseModel Cn_Branch_Rtq_Job_Create([FromBody] CnBranchRtqModel CnBranchRtqModel)
        {

            try
            {
                //  CultureInfo cultureinfo = new CultureInfo(" en-US");

                CnBranchRtqRepository CnBranchRtqRepository = new CnBranchRtqRepository();

                CnBranchRtqRepository.Cn_Branch_Rtq_Job_Create(CnBranchRtqModel);

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

        #region Cn_Branch_Rtq_Job_Get
        [Route("api/Cn_Branch_Rtq_Job_Get")]
        [HttpGet]
        public ResponseModel Cn_Branch_Rtq_Job_Get([FromUri] CnBranchRtqModel CnBranchRtqModel)
        {

            try
            {
                CultureInfo cultureinfo = new CultureInfo("en-US");

                CnBranchRtqRepository CnBranchRtqRepository = new CnBranchRtqRepository();

                List<CnBranchRtqModel> Cn_Branch_Rtq_Job_Get = CnBranchRtqRepository.Cn_Branch_Rtq_Job_Get(CnBranchRtqModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = Cn_Branch_Rtq_Job_Get;
                _ResponseModel.length = Cn_Branch_Rtq_Job_Get.Count();
                _ResponseModel.status = "Success";

                return _ResponseModel;

            }
            catch (Exception ex)
            {

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

        #region Cn_Branch_Rtq_Item_Get
        [Route("api/Cn_Branch_Rtq_Item_Get")]
        [HttpGet]
        public ResponseModel Cn_Branch_Rtq_Item_Get([FromUri] CnBranchRtqItemMasterModel CnBranchRtqItemMasterModel)
        {

            try
            {
                CultureInfo cultureinfo = new CultureInfo("en-US");

                CnBranchRtqRepository CnBranchRtqRepository = new CnBranchRtqRepository();

                List<CnBranchRtqItemMasterModel> Cn_Branch_Rtq_Item_Get = CnBranchRtqRepository.Cn_Branch_Rtq_Item_Get(CnBranchRtqItemMasterModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = Cn_Branch_Rtq_Item_Get;
                _ResponseModel.length = Cn_Branch_Rtq_Item_Get.Count();
                _ResponseModel.status = "Success";

                return _ResponseModel;

            }
            catch (Exception ex)
            {

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

        #region Cn_Branch_Rtq_Job_Source_Update
        [Route("api/Cn_Branch_Rtq_Job_Source_Update")]
        [HttpPut]
        public ResponseModel Cn_Branch_Rtq_Job_Source_Update([FromBody] CnBranchRtqSourceModel CnBranchRtqSourceModel)
        {

            try
            {
                //  CultureInfo cultureinfo = new CultureInfo(" en-US");

                CnBranchRtqRepository CnBranchRtqRepository = new CnBranchRtqRepository();

                CnBranchRtqRepository.Cn_Branch_Rtq_Job_Source_Update(CnBranchRtqSourceModel);

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

        #region Cn_Branch_Rtq_Job_Assige_Update
        [Route("api/Cn_Branch_Rtq_Job_Assige_Update")]
        [HttpPut]
        public ResponseModel Cn_Branch_Rtq_Job_Assige_Update([FromBody] CnBranchRtqAssigeModel CnBranchRtqAssigeModel)
        {

            try
            {
                //  CultureInfo cultureinfo = new CultureInfo(" en-US");

                CnBranchRtqRepository CnBranchRtqRepository = new CnBranchRtqRepository();

                CnBranchRtqRepository.Cn_Branch_Rtq_Job_Assige_Update(CnBranchRtqAssigeModel);

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

        #region Cn_Branch_Rtq_Job_Driver_Update
        [Route("api/Cn_Branch_Rtq_Job_Driver_Update")]
        [HttpPut]
        public ResponseModel Cn_Branch_Rtq_Job_Driver_Update([FromBody] CnBranchRtqDriverModel CnBranchRtqDriverModel)
        {

            try
            {
                //  CultureInfo cultureinfo = new CultureInfo(" en-US");

                CnBranchRtqRepository CnBranchRtqRepository = new CnBranchRtqRepository();

                CnBranchRtqRepository.Cn_Branch_Rtq_Job_Driver_Update(CnBranchRtqDriverModel);

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

        #region Cn_Branch_Rtq_Job_Condition_Update
        [Route("api/Cn_Branch_Rtq_Job_Condition_Update")]
        [HttpPut]
        public ResponseModel Cn_Branch_Rtq_Job_Condition_Update([FromBody] CnBranchRtqConditionModel CnBranchRtqConditionModel)
        {

            try
            {
                //  CultureInfo cultureinfo = new CultureInfo(" en-US");

                CnBranchRtqRepository CnBranchRtqRepository = new CnBranchRtqRepository();

                CnBranchRtqRepository.Cn_Branch_Rtq_Job_Condition_Update(CnBranchRtqConditionModel);

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

        #region Cn_Branch_Rtq_Job_Remark_Update
        [Route("api/Cn_Branch_Rtq_Job_Remark_Update")]
        [HttpPut]
        public ResponseModel Cn_Branch_Rtq_Job_Remark_Update([FromBody] CnBranchRtqRemarkModel CnBranchRtqRemarkModel)
        {

            try
            {
                //  CultureInfo cultureinfo = new CultureInfo(" en-US");

                CnBranchRtqRepository CnBranchRtqRepository = new CnBranchRtqRepository();

                CnBranchRtqRepository.Cn_Branch_Rtq_Job_Remark_Update(CnBranchRtqRemarkModel);

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

        #region Cn_Branch_Rtq_Job_Cause_Update
        [Route("api/Cn_Branch_Rtq_Job_Cause_Update")]
        [HttpPut]
        public ResponseModel Cn_Branch_Rtq_Job_Cause_Update([FromBody] CnBranchRtqCauseModel CnBranchRtqCauseModel)
        {

            try
            {
                //  CultureInfo cultureinfo = new CultureInfo(" en-US");

                CnBranchRtqRepository CnBranchRtqRepository = new CnBranchRtqRepository();

                CnBranchRtqRepository.Cn_Branch_Rtq_Job_Cause_Update(CnBranchRtqCauseModel);

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

        #region Cn_Branch_Rtq_Job_Status_Update
        [Route("api/Cn_Branch_Rtq_Job_Status_Update")]
        [HttpPut]
        public ResponseModel Cn_Branch_Rtq_Job_Status_Update([FromBody] CnBranchRtqStatusModel CnBranchRtqStatusModel)
        {

            try
            {
                //  CultureInfo cultureinfo = new CultureInfo(" en-US");

                CnBranchRtqRepository CnBranchRtqRepository = new CnBranchRtqRepository();

                CnBranchRtqRepository.Cn_Branch_Rtq_Job_Status_Update(CnBranchRtqStatusModel);

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

        #region Cn_Branch_Rtq_Source_Get
        [Route("api/Cn_Branch_Rtq_Source_Get")]
        [HttpGet]
        public ResponseModel Cn_Branch_Rtq_Source_Get([FromUri] CnBranchRtqSourceModel CnBranchRtqSourceModel)
        {

            try
            {
                CultureInfo cultureinfo = new CultureInfo("en-US");

                CnBranchRtqRepository CnBranchRtqRepository = new CnBranchRtqRepository();

                List<CnBranchRtqSourceModel> Cn_Branch_Rtq_Source_Get = CnBranchRtqRepository.Cn_Branch_Rtq_Source_Get(CnBranchRtqSourceModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = Cn_Branch_Rtq_Source_Get;
                _ResponseModel.length = Cn_Branch_Rtq_Source_Get.Count();
                _ResponseModel.status = "Success";

                return _ResponseModel;

            }
            catch (Exception ex)
            {

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

        #region Cn_Branch_Rtq_Status_Get
        [Route("api/Cn_Branch_Rtq_Status_Get")]
        [HttpGet]
        public ResponseModel Cn_Branch_Rtq_Status_Get([FromUri] CnBranchRtqStatusModel CnBranchRtqStatusModel)
        {

            try
            {
                CultureInfo cultureinfo = new CultureInfo("en-US");

                CnBranchRtqRepository CnBranchRtqRepository = new CnBranchRtqRepository();

                List<CnBranchRtqStatusModel> Cn_Branch_Rtq_Status_Get = CnBranchRtqRepository.Cn_Branch_Rtq_Status_Get(CnBranchRtqStatusModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = Cn_Branch_Rtq_Status_Get;
                _ResponseModel.length = Cn_Branch_Rtq_Status_Get.Count();
                _ResponseModel.status = "Success";

                return _ResponseModel;

            }
            catch (Exception ex)
            {

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

        #region Cn_Branch_Rtq_Driver_Get
        [Route("api/Cn_Branch_Rtq_Driver_Get")]
        [HttpGet]
        public ResponseModel Cn_Branch_Rtq_Driver_Get([FromUri] CnBranchRtqDriverModel CnBranchRtqDriverModel)
        {

            try
            {
                CultureInfo cultureinfo = new CultureInfo("en-US");

                CnBranchRtqRepository CnBranchRtqRepository = new CnBranchRtqRepository();

                List<CnBranchRtqDriverModel> Cn_Branch_Rtq_Driver_Get = CnBranchRtqRepository.Cn_Branch_Rtq_Driver_Get(CnBranchRtqDriverModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = Cn_Branch_Rtq_Driver_Get;
                _ResponseModel.length = Cn_Branch_Rtq_Driver_Get.Count();
                _ResponseModel.status = "Success";

                return _ResponseModel;

            }
            catch (Exception ex)
            {

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

        #region Cn_Branch_Rtq_Assige_Get
        [Route("api/Cn_Branch_Rtq_Assige_Get")]
        [HttpGet]
        public ResponseModel Cn_Branch_Rtq_Assige_Get([FromUri] CnBranchRtqAssigeModel CnBranchRtqAssigeModel)
        {

            try
            {
                CultureInfo cultureinfo = new CultureInfo("en-US");

                CnBranchRtqRepository CnBranchRtqRepository = new CnBranchRtqRepository();

                List<CnBranchRtqAssigeModel> Cn_Branch_Rtq_Assige_Get = CnBranchRtqRepository.Cn_Branch_Rtq_Assige_Get(CnBranchRtqAssigeModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = Cn_Branch_Rtq_Assige_Get;
                _ResponseModel.length = Cn_Branch_Rtq_Assige_Get.Count();
                _ResponseModel.status = "Success";

                return _ResponseModel;

            }
            catch (Exception ex)
            {

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

        #region Cn_Branch_Rtq_Remark_Get
        [Route("api/Cn_Branch_Rtq_Remark_Get")]
        [HttpGet]
        public ResponseModel Cn_Branch_Rtq_Remark_Get([FromUri] CnBranchRtqRemarkModel CnBranchRtqRemarkModel)
        {

            try
            {
                CultureInfo cultureinfo = new CultureInfo("en-US");

                CnBranchRtqRepository CnBranchRtqRepository = new CnBranchRtqRepository();

                List<CnBranchRtqRemarkModel> Cn_Branch_Rtq_Remark_Get = CnBranchRtqRepository.Cn_Branch_Rtq_Remark_Get(CnBranchRtqRemarkModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = Cn_Branch_Rtq_Remark_Get;
                _ResponseModel.length = Cn_Branch_Rtq_Remark_Get.Count();
                _ResponseModel.status = "Success";

                return _ResponseModel;

            }
            catch (Exception ex)
            {

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


        #region Cn_Branch_Rtq_Cause_Get
        [Route("api/Cn_Branch_Rtq_Cause_Get")]
        [HttpGet]
        public ResponseModel Cn_Branch_Rtq_Cause_Get([FromUri] CnBranchRtqCauseModel CnBranchRtqCauseModel)
        {

            try
            {
                CultureInfo cultureinfo = new CultureInfo("en-US");

                CnBranchRtqRepository CnBranchRtqRepository = new CnBranchRtqRepository();

                List<CnBranchRtqCauseModel> Cn_Branch_Rtq_Cause_Get = CnBranchRtqRepository.Cn_Branch_Rtq_Cause_Get(CnBranchRtqCauseModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = Cn_Branch_Rtq_Cause_Get;
                _ResponseModel.length = Cn_Branch_Rtq_Cause_Get.Count();
                _ResponseModel.status = "Success";

                return _ResponseModel;

            }
            catch (Exception ex)
            {

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

        #region Cn_Branch_Rtq_Condition_Get
        [Route("api/Cn_Branch_Rtq_Condition_Get")]
        [HttpGet]
        public ResponseModel Cn_Branch_Rtq_Condition_Get([FromUri] CnBranchRtqConditionModel CnBranchRtqConditionModel)
        {

            try
            {
                CultureInfo cultureinfo = new CultureInfo("en-US");

                CnBranchRtqRepository CnBranchRtqRepository = new CnBranchRtqRepository();

                List<CnBranchRtqConditionModel> Cn_Branch_Rtq_Condition_Get = CnBranchRtqRepository.Cn_Branch_Rtq_Condition_Get(CnBranchRtqConditionModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = Cn_Branch_Rtq_Condition_Get;
                _ResponseModel.length = Cn_Branch_Rtq_Condition_Get.Count();
                _ResponseModel.status = "Success";

                return _ResponseModel;

            }
            catch (Exception ex)
            {

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
