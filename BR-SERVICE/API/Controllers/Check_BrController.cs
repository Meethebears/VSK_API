using REPO.Models;
using REPO.Controllers;
using System.Web.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;

namespace API.Controllers
{
    public class Check_BrController : ApiController
    {
        #region Br_Master_Data
        [Route("api/Br_Master_Data")]
        [HttpGet]
        public ResponseModel Br_Master_Data([FromUri] CheckBrModel CheckBrModel)
        {

            try
            {
                CultureInfo cultureinfo = new CultureInfo("en-US");

                Check_BrRepository TrpRepository = new Check_BrRepository();

                List<CheckBrModel> Br_Master_Data = TrpRepository.Br_Master_Data(CheckBrModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = Br_Master_Data;
                _ResponseModel.length = Br_Master_Data.Count();
                _ResponseModel.status = "Success";

                return _ResponseModel;

            }
            catch (Exception ex)
            {

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

        #region Check_Br_Get_Nubmer
        [Route("api/Check_Br_Get_Nubmer")]
        [HttpGet]
        public ResponseModel Check_Br_Get_Nubmer([FromUri] CheckBrModel CheckBrModel)
        {

            try
            {
                CultureInfo cultureinfo = new CultureInfo("en-US");

                Check_BrRepository TrpRepository = new Check_BrRepository();

                List<CheckBrModel> Check_Br_Get_Nubmer = TrpRepository.Check_Br_Get_Nubmer(CheckBrModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = Check_Br_Get_Nubmer;
                _ResponseModel.length = Check_Br_Get_Nubmer.Count();
                _ResponseModel.status = "Success";

                return _ResponseModel;

            }
            catch (Exception ex)
            {

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

        #region Check_Br_List_Mcenter
        [Route("api/Check_Br_List_Mcenter")]
        [HttpGet]
        public ResponseModel Check_Br_List_Mcenter([FromUri] CheckBrModel CheckBrModel)
        {

            try
            {
                CultureInfo cultureinfo = new CultureInfo("en-US");

                Check_BrRepository TrpRepository = new Check_BrRepository();

                List<CheckBrModel> Check_Br_List_Mcenter = TrpRepository.Check_Br_List_Mcenter(CheckBrModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = Check_Br_List_Mcenter;
                _ResponseModel.length = Check_Br_List_Mcenter.Count();
                _ResponseModel.status = "Success";

                return _ResponseModel;

            }
            catch (Exception ex)
            {

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

        #region Check_Br_List
        [Route("api/Check_Br_List")]
        [HttpGet]
        public ResponseModel Check_Br_List([FromUri] CheckBrModel CheckBrModel)
        {

            try
            {
                CultureInfo cultureinfo = new CultureInfo("en-US");

                Check_BrRepository TrpRepository = new Check_BrRepository();

                List<CheckBrModel> Check_Br_List = TrpRepository.Check_Br_List(CheckBrModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = Check_Br_List;
                _ResponseModel.length = Check_Br_List.Count();
                _ResponseModel.status = "Success";

                return _ResponseModel;

            }
            catch (Exception ex)
            {

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

        #region Check_Br_Detail
        [Route("api/Check_Br_Detail")]
        [HttpGet]
        public ResponseModel Check_Br_Detail([FromUri] CheckBrModel CheckBrModel)
        {

            try
            {
                CultureInfo cultureinfo = new CultureInfo("en-US");

                Check_BrRepository TrpRepository = new Check_BrRepository();

                List<CheckBrModel> Check_Br_Detail = TrpRepository.Check_Br_Detail(CheckBrModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = Check_Br_Detail;
                _ResponseModel.length = Check_Br_Detail.Count();
                _ResponseModel.status = "Success";

                return _ResponseModel;

            }
            catch (Exception ex)
            {

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

        #region Check_Br_Create
        [Route("api/Check_Br_Create")]
        [HttpPost]
        public ResponseModel Check_Br_Create([FromBody] CheckBrModel CheckBrModel)
        {

            try
            {
                CultureInfo cultureinfo = new CultureInfo("en-US");

                Check_BrRepository TrpRepository = new Check_BrRepository();

                List<CheckBrModel> Check_Br_Create = TrpRepository.Check_Br_Create(CheckBrModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = Check_Br_Create;
                _ResponseModel.length = Check_Br_Create.Count();
                _ResponseModel.status = "Success";

                return _ResponseModel;

            }
            catch (Exception ex)
            {

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

        #region Check_Br_Update
        [Route("api/Check_Br_Update")]
        [HttpPut]
        public ResponseModel Check_Br_Update([FromBody] CheckBrModel CheckBrModel)
        {

            try
            {
                CultureInfo cultureinfo = new CultureInfo("en-US");

                Check_BrRepository TrpRepository = new Check_BrRepository();

                List<CheckBrModel> Check_Br_Update = TrpRepository.Check_Br_Update(CheckBrModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = Check_Br_Update;
                _ResponseModel.length = Check_Br_Update.Count();
                _ResponseModel.status = "Success";

                return _ResponseModel;

            }
            catch (Exception ex)
            {

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

        #region Check_Br_Edit
        [Route("api/Check_Br_Edit")]
        [HttpPut]
        public ResponseModel Check_Br_Edit([FromBody] CheckBrModel CheckBrModel)
        {

            try
            {
                CultureInfo cultureinfo = new CultureInfo("en-US");

                Check_BrRepository TrpRepository = new Check_BrRepository();

                List<CheckBrModel> Check_Br_Edit = TrpRepository.Check_Br_Edit(CheckBrModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = Check_Br_Edit;
                _ResponseModel.length = Check_Br_Edit.Count();
                _ResponseModel.status = "Success";

                return _ResponseModel;

            }
            catch (Exception ex)
            {

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

        #region Check_Br_Success
        [Route("api/Check_Br_Success")]
        [HttpPut]
        public ResponseModel Check_Br_Success([FromBody] CheckBrModel CheckBrModel)
        {

            try
            {
                CultureInfo cultureinfo = new CultureInfo("en-US");

                Check_BrRepository TrpRepository = new Check_BrRepository();

                List<CheckBrModel> Check_Br_Success = TrpRepository.Check_Br_Success(CheckBrModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = Check_Br_Success;
                _ResponseModel.length = Check_Br_Success.Count();
                _ResponseModel.status = "Success";

                return _ResponseModel;

            }
            catch (Exception ex)
            {

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

        #region Check_Br_Get
        [Route("api/Check_Br_Get")]
        [HttpGet]
        public ResponseModel Check_Br_Get([FromUri] CheckBrModel CheckBrModel)
        {

            try
            {
                CultureInfo cultureinfo = new CultureInfo("en-US");

                Check_BrRepository TrpRepository = new Check_BrRepository();

                List<CheckBrModel> Check_Br_Get = TrpRepository.Check_Br_Get(CheckBrModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = Check_Br_Get;
                _ResponseModel.length = Check_Br_Get.Count();
                _ResponseModel.status = "Success";

                return _ResponseModel;

            }
            catch (Exception ex)
            {

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


        // NEW OUT START //

        #region Check_Br_Create_Out
        [Route("api/Check_Br_Create_Out")]
        [HttpPost]
        public ResponseModel Check_Br_Create_Out([FromBody] CheckBrModel CheckBrModel)
        {

            try
            {
                CultureInfo cultureinfo = new CultureInfo("en-US");

                Check_BrRepository TrpRepository = new Check_BrRepository();

                List<CheckBrModel> Check_Br_Create_Out = TrpRepository.Check_Br_Create_Out(CheckBrModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = Check_Br_Create_Out;
                _ResponseModel.length = Check_Br_Create_Out.Count();
                _ResponseModel.status = "Success";

                return _ResponseModel;

            }
            catch (Exception ex)
            {

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

        #region Check_Br_Update_Out
        [Route("api/Check_Br_Update_Out")]
        [HttpPut]
        public ResponseModel Check_Br_Update_Out([FromBody] CheckBrModel CheckBrModel)
        {

            try
            {
                CultureInfo cultureinfo = new CultureInfo("en-US");

                Check_BrRepository TrpRepository = new Check_BrRepository();

                List<CheckBrModel> Check_Br_Update_Out = TrpRepository.Check_Br_Update_Out(CheckBrModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = Check_Br_Update_Out;
                _ResponseModel.length = Check_Br_Update_Out.Count();
                _ResponseModel.status = "Success";

                return _ResponseModel;

            }
            catch (Exception ex)
            {

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

        #region Check_Br_Get_Out
        [Route("api/Check_Br_Get_Out")]
        [HttpGet]
        public ResponseModel Check_Br_Get_Out([FromUri] CheckBrModel CheckBrModel)
        {

            try
            {
                CultureInfo cultureinfo = new CultureInfo("en-US");

                Check_BrRepository TrpRepository = new Check_BrRepository();

                List<CheckBrModel> Check_Br_Get_Out = TrpRepository.Check_Br_Get_Out(CheckBrModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = Check_Br_Get_Out;
                _ResponseModel.length = Check_Br_Get_Out.Count();
                _ResponseModel.status = "Success";

                return _ResponseModel;

            }
            catch (Exception ex)
            {

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

        #region Check_Br_Count_Out
        [Route("api/Check_Br_Count_Out")]
        [HttpGet]
        public ResponseModel Check_Br_Count_Out([FromUri] CheckBrModel CheckBrModel)
        {

            try
            {
                CultureInfo cultureinfo = new CultureInfo("en-US");

                Check_BrRepository TrpRepository = new Check_BrRepository();

                List<CheckBrModel> Check_Br_Count_Out = TrpRepository.Check_Br_Count_Out(CheckBrModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = Check_Br_Count_Out;
                _ResponseModel.length = Check_Br_Count_Out.Count();
                _ResponseModel.status = "Success";

                return _ResponseModel;

            }
            catch (Exception ex)
            {

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

        #region Check_Br_Success_Out
        [Route("api/Check_Br_Success_Out")]
        [HttpPut]
        public ResponseModel Check_Br_Success_Out([FromBody] CheckBrModel CheckBrModel)
        {

            try
            {
                CultureInfo cultureinfo = new CultureInfo("en-US");

                Check_BrRepository TrpRepository = new Check_BrRepository();

                List<CheckBrModel> Check_Br_Success_Out = TrpRepository.Check_Br_Success_Out(CheckBrModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = Check_Br_Success_Out;
                _ResponseModel.length = Check_Br_Success_Out.Count();
                _ResponseModel.status = "Success";

                return _ResponseModel;

            }
            catch (Exception ex)
            {

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

        #region Check_Br_Remark_Create_Out
        [Route("api/Check_Br_Remark_Create_Out")]
        [HttpPost]
        public ResponseModel Check_Br_Remark_Create_Out([FromBody] CheckBrModel CheckBrModel)
        {

            try
            {
                CultureInfo cultureinfo = new CultureInfo("en-US");

                Check_BrRepository TrpRepository = new Check_BrRepository();

                List<CheckBrModel> Check_Br_Remark_Create_Out = TrpRepository.Check_Br_Remark_Create_Out(CheckBrModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = Check_Br_Remark_Create_Out;
                _ResponseModel.length = Check_Br_Remark_Create_Out.Count();
                _ResponseModel.status = "Success";

                return _ResponseModel;

            }
            catch (Exception ex)
            {

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

        #region Check_Br_Remark_Delete_Out
        [Route("api/Check_Br_Remark_Delete_Out")]
        [HttpDelete]
        public ResponseModel Check_Br_Remark_Delete_Out([FromBody] CheckBrModel CheckBrModel)
        {

            try
            {
                CultureInfo cultureinfo = new CultureInfo("en-US");

                Check_BrRepository TrpRepository = new Check_BrRepository();

                List<CheckBrModel> Check_Br_Remark_Delete_Out = TrpRepository.Check_Br_Remark_Delete_Out(CheckBrModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = Check_Br_Remark_Delete_Out;
                _ResponseModel.length = Check_Br_Remark_Delete_Out.Count();
                _ResponseModel.status = "Success";

                return _ResponseModel;

            }
            catch (Exception ex)
            {

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

        #region Check_Br_Qty_Out
        [Route("api/Check_Br_Qty_Out")]
        [HttpPut]
        public ResponseModel Check_Br_Qty_Out([FromBody] CheckBrModel CheckBrModel)
        {

            try
            {
                CultureInfo cultureinfo = new CultureInfo("en-US");

                Check_BrRepository TrpRepository = new Check_BrRepository();

                List<CheckBrModel> Check_Br_Qty_Out = TrpRepository.Check_Br_Qty_Out(CheckBrModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = Check_Br_Qty_Out;
                _ResponseModel.length = Check_Br_Qty_Out.Count();
                _ResponseModel.status = "Success";

                return _ResponseModel;

            }
            catch (Exception ex)
            {

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

        // NEW OUT END //

        // NEW IN START //

        #region Check_Br_Create_In
        [Route("api/Check_Br_Create_In")]
        [HttpPost]
        public ResponseModel Check_Br_Create_In([FromBody] CheckBrModel CheckBrModel)
        {

            try
            {
                CultureInfo cultureinfo = new CultureInfo("en-US");

                Check_BrRepository TrpRepository = new Check_BrRepository();

                List<CheckBrModel> Check_Br_Create_In = TrpRepository.Check_Br_Create_In(CheckBrModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = Check_Br_Create_In;
                _ResponseModel.length = Check_Br_Create_In.Count();
                _ResponseModel.status = "Success";

                return _ResponseModel;

            }
            catch (Exception ex)
            {

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

        #region Check_Br_Update_In
        [Route("api/Check_Br_Update_In")]
        [HttpPut]
        public ResponseModel Check_Br_Update_In([FromBody] CheckBrModel CheckBrModel)
        {

            try
            {
                CultureInfo cultureinfo = new CultureInfo("en-US");

                Check_BrRepository TrpRepository = new Check_BrRepository();

                List<CheckBrModel> Check_Br_Update_In = TrpRepository.Check_Br_Update_In(CheckBrModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = Check_Br_Update_In;
                _ResponseModel.length = Check_Br_Update_In.Count();
                _ResponseModel.status = "Success";

                return _ResponseModel;

            }
            catch (Exception ex)
            {

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

        #region Check_Br_Get_In
        [Route("api/Check_Br_Get_In")]
        [HttpGet]
        public ResponseModel Check_Br_Get_In([FromUri] CheckBrModel CheckBrModel)
        {

            try
            {
                CultureInfo cultureinfo = new CultureInfo("en-US");

                Check_BrRepository TrpRepository = new Check_BrRepository();

                List<CheckBrModel> Check_Br_Get_In = TrpRepository.Check_Br_Get_In(CheckBrModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = Check_Br_Get_In;
                _ResponseModel.length = Check_Br_Get_In.Count();
                _ResponseModel.status = "Success";

                return _ResponseModel;

            }
            catch (Exception ex)
            {

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

        #region Check_Br_Count_In
        [Route("api/Check_Br_Count_In")]
        [HttpGet]
        public ResponseModel Check_Br_Count_In([FromUri] CheckBrModel CheckBrModel)
        {

            try
            {
                CultureInfo cultureinfo = new CultureInfo("en-US");

                Check_BrRepository TrpRepository = new Check_BrRepository();

                List<CheckBrModel> Check_Br_Count_In = TrpRepository.Check_Br_Count_In(CheckBrModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = Check_Br_Count_In;
                _ResponseModel.length = Check_Br_Count_In.Count();
                _ResponseModel.status = "Success";

                return _ResponseModel;

            }
            catch (Exception ex)
            {

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

        #region Check_Br_Success_In
        [Route("api/Check_Br_Success_In")]
        [HttpPut]
        public ResponseModel Check_Br_Success_In([FromBody] CheckBrModel CheckBrModel)
        {

            try
            {
                CultureInfo cultureinfo = new CultureInfo("en-US");

                Check_BrRepository TrpRepository = new Check_BrRepository();

                List<CheckBrModel> Check_Br_Success_In = TrpRepository.Check_Br_Success_In(CheckBrModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = Check_Br_Success_In;
                _ResponseModel.length = Check_Br_Success_In.Count();
                _ResponseModel.status = "Success";

                return _ResponseModel;

            }
            catch (Exception ex)
            {

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

        #region Check_Br_Remark_Create_In
        [Route("api/Check_Br_Remark_Create_In")]
        [HttpPost]
        public ResponseModel Check_Br_Remark_Create_In([FromBody] CheckBrModel CheckBrModel)
        {

            try
            {
                CultureInfo cultureinfo = new CultureInfo("en-US");

                Check_BrRepository TrpRepository = new Check_BrRepository();

                List<CheckBrModel> Check_Br_Remark_Create_In = TrpRepository.Check_Br_Remark_Create_In(CheckBrModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = Check_Br_Remark_Create_In;
                _ResponseModel.length = Check_Br_Remark_Create_In.Count();
                _ResponseModel.status = "Success";

                return _ResponseModel;

            }
            catch (Exception ex)
            {

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

        #region Check_Br_Remark_Delete_In
        [Route("api/Check_Br_Remark_Delete_In")]
        [HttpDelete]
        public ResponseModel Check_Br_Remark_Delete_In([FromBody] CheckBrModel CheckBrModel)
        {

            try
            {
                CultureInfo cultureinfo = new CultureInfo("en-US");

                Check_BrRepository TrpRepository = new Check_BrRepository();

                List<CheckBrModel> Check_Br_Remark_Delete_In = TrpRepository.Check_Br_Remark_Delete_In(CheckBrModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = Check_Br_Remark_Delete_In;
                _ResponseModel.length = Check_Br_Remark_Delete_In.Count();
                _ResponseModel.status = "Success";

                return _ResponseModel;

            }
            catch (Exception ex)
            {

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

        #region Check_Br_Qty_In
        [Route("api/Check_Br_Qty_In")]
        [HttpPut]
        public ResponseModel Check_Br_Qty_In([FromBody] CheckBrModel CheckBrModel)
        {

            try
            {
                CultureInfo cultureinfo = new CultureInfo("en-US");

                Check_BrRepository TrpRepository = new Check_BrRepository();

                List<CheckBrModel> Check_Br_Qty_In = TrpRepository.Check_Br_Qty_In(CheckBrModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = Check_Br_Qty_In;
                _ResponseModel.length = Check_Br_Qty_In.Count();
                _ResponseModel.status = "Success";

                return _ResponseModel;

            }
            catch (Exception ex)
            {

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


        #region Check_Br_Template_Create
        [Route("api/Check_Br_Template_Create")]
        [HttpPost]
        public ResponseModel Check_Br_Template_Create([FromBody] CheckBrModel CheckBrModel)
        {

            try
            {
                CultureInfo cultureinfo = new CultureInfo("en-US");

                Check_BrRepository TrpRepository = new Check_BrRepository();

                List<CheckBrModel> Check_Br_Template_Create = TrpRepository.Check_Br_Template_Create(CheckBrModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = Check_Br_Template_Create;
                _ResponseModel.length = Check_Br_Template_Create.Count();
                _ResponseModel.status = "Success";

                return _ResponseModel;

            }
            catch (Exception ex)
            {

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

        #region Check_Br_Template_List
        [Route("api/Check_Br_Template_List")]
        [HttpGet]
        public ResponseModel Check_Br_Template_List([FromUri] CheckBrModel CheckBrModel)
        {

            try
            {
                CultureInfo cultureinfo = new CultureInfo("en-US");

                Check_BrRepository TrpRepository = new Check_BrRepository();

                List<CheckBrModel> Check_Br_Template_List = TrpRepository.Check_Br_Template_List(CheckBrModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = Check_Br_Template_List;
                _ResponseModel.length = Check_Br_Template_List.Count();
                _ResponseModel.status = "Success";

                return _ResponseModel;

            }
            catch (Exception ex)
            {

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



        #region Check_Br_Multiple_Get_In
        [Route("api/Check_Br_Multiple_Get_In")]
        [HttpGet]
        public ResponseModel Check_Br_Multiple_Get_In([FromUri] CheckBrParamGModel CheckBrParamGModel)
        {

            try
            {
                CultureInfo cultureinfo = new CultureInfo("en-US");

                Check_BrRepository TrpRepository = new Check_BrRepository();

                List<CheckBrDataModel> Check_Br_Multiple_Get_In = TrpRepository.Check_Br_Multiple_Get_In(CheckBrParamGModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = Check_Br_Multiple_Get_In;
                _ResponseModel.length = Check_Br_Multiple_Get_In.Count();
                _ResponseModel.status = "Success";

                return _ResponseModel;

            }
            catch (Exception ex)
            {

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

        #region Check_Br_Multiple_Create_In
        [Route("api/Check_Br_Multiple_Create_In")]
        [HttpPost]
        public ResponseModel Check_Br_Multiple_Create_In([FromBody] CheckBrParamCModel CheckBrParamCModel)
        {

            try
            {
                CultureInfo cultureinfo = new CultureInfo("en-US");

                Check_BrRepository TrpRepository = new Check_BrRepository();

                List<CheckBrDataModel> Check_Br_Multiple_Create_In = TrpRepository.Check_Br_Multiple_Create_In(CheckBrParamCModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = Check_Br_Multiple_Create_In;
                _ResponseModel.length = Check_Br_Multiple_Create_In.Count();
                _ResponseModel.status = "Success";

                return _ResponseModel;

            }
            catch (Exception ex)
            {

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

        // NEW IN END //

    }
}
