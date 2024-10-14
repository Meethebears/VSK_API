using REPO.Models;
using REPO.Controllers;
using System.Web.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;

namespace API.Controllers
{
    public class Check_AdController : ApiController
    {
        #region Check_Ad_List
        [Route("api/Check_Ad_List")]
        [HttpGet]
        public ResponseModel Check_Ad_List([FromUri] CheckAdInputModel CheckAdInputModel)
        {

            try
            {
                CultureInfo cultureinfo = new CultureInfo("en-US");

                Check_AdRepository Check_AdRepository = new Check_AdRepository();

                List<CheckAdGetModel> Check_Ad_List = Check_AdRepository.Check_Ad_List(CheckAdInputModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = Check_Ad_List;
                _ResponseModel.length = Check_Ad_List.Count();
                _ResponseModel.status = "Success";

                return _ResponseModel;

            }
            catch (Exception ex)
            {

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

        #region Check_Ad_Master_Data
        [Route("api/Check_Ad_Master_Data")]
        [HttpGet]
        public ResponseModel Check_Ad_Master_Data([FromUri] CheckMasterDataModel CheckMasterDataModel)
        {

            try
            {
                CultureInfo cultureinfo = new CultureInfo("en-US");

                Check_AdRepository Check_AdRepository = new Check_AdRepository();

                List<CheckMasterDataModel> Check_Ad_Master_Data = Check_AdRepository.Check_Ad_Master_Data(CheckMasterDataModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = Check_Ad_Master_Data;
                _ResponseModel.length = Check_Ad_Master_Data.Count();
                _ResponseModel.status = "Success";

                return _ResponseModel;

            }
            catch (Exception ex)
            {

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

        #region Check_Ad_Create_Out
        [Route("api/Check_Ad_Create_Out")]
        [HttpPost]
        public ResponseModel Check_Br_Create_Out([FromBody] CheckAdInputModel CheckAdInputModel)
        {

            try
            {
                CultureInfo cultureinfo = new CultureInfo("en-US");

                Check_AdRepository Check_AdRepository = new Check_AdRepository();

                List<CheckAdGetModel> Check_Ad_Create_Out = Check_AdRepository.Check_Ad_Create_Out(CheckAdInputModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = Check_Ad_Create_Out;
                _ResponseModel.length = Check_Ad_Create_Out.Count();
                _ResponseModel.status = "Success";

                return _ResponseModel;

            }
            catch (Exception ex)
            {

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

        #region Check_Ad_Update_Out
        [Route("api/Check_Ad_Update_Out")]
        [HttpPut]
        public ResponseModel Check_Ad_Update_Out([FromBody] CheckAdInputModel CheckAdInputModel)
        {

            try
            {
                CultureInfo cultureinfo = new CultureInfo("en-US");

                Check_AdRepository Check_AdRepository = new Check_AdRepository();

                List<CheckAdGetModel> Check_Ad_Update_Out = Check_AdRepository.Check_Ad_Update_Out(CheckAdInputModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = Check_Ad_Update_Out;
                _ResponseModel.length = Check_Ad_Update_Out.Count();
                _ResponseModel.status = "Success";

                return _ResponseModel;

            }
            catch (Exception ex)
            {

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

        #region Check_Ad_Get_Out
        [Route("api/Check_Ad_Get_Out")]
        [HttpGet]
        public ResponseModel Check_Ad_Get_Out([FromUri] CheckAdInputModel CheckAdInputModel)
        {

            try
            {
                CultureInfo cultureinfo = new CultureInfo("en-US");

                Check_AdRepository Check_AdRepository = new Check_AdRepository();

                List<CheckAdGetModel> Check_Ad_Get_Out = Check_AdRepository.Check_Ad_Get_Out(CheckAdInputModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = Check_Ad_Get_Out;
                _ResponseModel.length = Check_Ad_Get_Out.Count();
                _ResponseModel.status = "Success";

                return _ResponseModel;

            }
            catch (Exception ex)
            {

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

        #region Check_Ad_Count_Out
        [Route("api/Check_Ad_Count_Out")]
        [HttpGet]
        public ResponseModel Check_Ad_Count_Out([FromUri] CheckAdInputModel CheckAdInputModel)
        {

            try
            {
                CultureInfo cultureinfo = new CultureInfo("en-US");

                Check_AdRepository Check_AdRepository = new Check_AdRepository();

                List<CheckAdCountModel> Check_Ad_Count_Out = Check_AdRepository.Check_Ad_Count_Out(CheckAdInputModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = Check_Ad_Count_Out;
                _ResponseModel.length = Check_Ad_Count_Out.Count();
                _ResponseModel.status = "Success";

                return _ResponseModel;

            }
            catch (Exception ex)
            {

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

        #region Check_Ad_Success_Out
        [Route("api/Check_Ad_Success_Out")]
        [HttpPut]
        public ResponseModel Check_Ad_Success_Out([FromBody] CheckAdInputModel CheckAdInputModel)
        {

            try
            {
                CultureInfo cultureinfo = new CultureInfo("en-US");

                Check_AdRepository Check_AdRepository = new Check_AdRepository();

                List<CheckAdGetModel> Check_Ad_Success_Out = Check_AdRepository.Check_Ad_Success_Out(CheckAdInputModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = Check_Ad_Success_Out;
                _ResponseModel.length = Check_Ad_Success_Out.Count();
                _ResponseModel.status = "Success";

                return _ResponseModel;

            }
            catch (Exception ex)
            {

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

        #region Check_Ad_Qty_Out
        [Route("api/Check_Ad_Qty_Out")]
        [HttpPut]
        public ResponseModel Check_Ad_Qty_Out([FromBody] CheckAdInputModel CheckAdInputModel)
        {

            try
            {
                CultureInfo cultureinfo = new CultureInfo("en-US");

                Check_AdRepository Check_AdRepository = new Check_AdRepository();

                List<CheckAdGetModel> Check_Ad_Qty_Out = Check_AdRepository.Check_Ad_Qty_Out(CheckAdInputModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = Check_Ad_Qty_Out;
                _ResponseModel.length = Check_Ad_Qty_Out.Count();
                _ResponseModel.status = "Success";

                return _ResponseModel;

            }
            catch (Exception ex)
            {

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

        #region Check_Ad_Remark_Create_Out
        [Route("api/Check_Ad_Remark_Create_Out")]
        [HttpPost]
        public ResponseModel Check_Ad_Remark_Create_Out([FromBody] CheckAdInputModel CheckAdInputModel)
        {

            try
            {
                CultureInfo cultureinfo = new CultureInfo("en-US");

                Check_AdRepository Check_AdRepository = new Check_AdRepository();

                List<CheckAdGetModel> Check_Ad_Remark_Create_Out = Check_AdRepository.Check_Ad_Remark_Create_Out(CheckAdInputModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = Check_Ad_Remark_Create_Out;
                _ResponseModel.length = Check_Ad_Remark_Create_Out.Count();
                _ResponseModel.status = "Success";

                return _ResponseModel;

            }
            catch (Exception ex)
            {

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

        #region Check_Ad_Remark_Delete_Out
        [Route("api/Check_Ad_Remark_Delete_Out")]
        [HttpDelete]
        public ResponseModel Check_Ad_Remark_Delete_Out([FromBody] CheckAdInputModel CheckAdInputModel)
        {

            try
            {
                CultureInfo cultureinfo = new CultureInfo("en-US");

                Check_AdRepository Check_AdRepository = new Check_AdRepository();

                List<CheckAdGetModel> Check_Ad_Remark_Delete_Out = Check_AdRepository.Check_Ad_Remark_Delete_Out(CheckAdInputModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = Check_Ad_Remark_Delete_Out;
                _ResponseModel.length = Check_Ad_Remark_Delete_Out.Count();
                _ResponseModel.status = "Success";

                return _ResponseModel;

            }
            catch (Exception ex)
            {

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


        #region Check_Ad_Create_In
        [Route("api/Check_Ad_Create_In")]
        [HttpPost]
        public ResponseModel Check_Br_Create_In([FromBody] CheckAdInputModel CheckAdInputModel)
        {

            try
            {
                CultureInfo cultureinfo = new CultureInfo("en-US");

                Check_AdRepository Check_AdRepository = new Check_AdRepository();

                List<CheckAdGetModel> Check_Ad_Create_In = Check_AdRepository.Check_Ad_Create_In(CheckAdInputModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = Check_Ad_Create_In;
                _ResponseModel.length = Check_Ad_Create_In.Count();
                _ResponseModel.status = "Success";

                return _ResponseModel;

            }
            catch (Exception ex)
            {

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

        #region Check_Ad_Update_In
        [Route("api/Check_Ad_Update_In")]
        [HttpPut]
        public ResponseModel Check_Ad_Update_In([FromBody] CheckAdInputModel CheckAdInputModel)
        {

            try
            {
                CultureInfo cultureinfo = new CultureInfo("en-US");

                Check_AdRepository Check_AdRepository = new Check_AdRepository();

                List<CheckAdGetModel> Check_Ad_Update_In = Check_AdRepository.Check_Ad_Update_In(CheckAdInputModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = Check_Ad_Update_In;
                _ResponseModel.length = Check_Ad_Update_In.Count();
                _ResponseModel.status = "Success";

                return _ResponseModel;

            }
            catch (Exception ex)
            {

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

        #region Check_Ad_Get_In
        [Route("api/Check_Ad_Get_In")]
        [HttpGet]
        public ResponseModel Check_Ad_Get_In([FromUri] CheckAdInputModel CheckAdInputModel)
        {

            try
            {
                CultureInfo cultureinfo = new CultureInfo("en-US");

                Check_AdRepository Check_AdRepository = new Check_AdRepository();

                List<CheckAdGetModel> Check_Ad_Get_In = Check_AdRepository.Check_Ad_Get_In(CheckAdInputModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = Check_Ad_Get_In;
                _ResponseModel.length = Check_Ad_Get_In.Count();
                _ResponseModel.status = "Success";

                return _ResponseModel;

            }
            catch (Exception ex)
            {

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

        #region Check_Ad_Count_In
        [Route("api/Check_Ad_Count_In")]
        [HttpGet]
        public ResponseModel Check_Ad_Count_In([FromUri] CheckAdInputModel CheckAdInputModel)
        {

            try
            {
                CultureInfo cultureinfo = new CultureInfo("en-US");

                Check_AdRepository Check_AdRepository = new Check_AdRepository();

                List<CheckAdCountModel> Check_Ad_Count_In = Check_AdRepository.Check_Ad_Count_In(CheckAdInputModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = Check_Ad_Count_In;
                _ResponseModel.length = Check_Ad_Count_In.Count();
                _ResponseModel.status = "Success";

                return _ResponseModel;

            }
            catch (Exception ex)
            {

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

        #region Check_Ad_Success_In
        [Route("api/Check_Ad_Success_In")]
        [HttpPut]
        public ResponseModel Check_Ad_Success_In([FromBody] CheckAdInputModel CheckAdInputModel)
        {

            try
            {
                CultureInfo cultureinfo = new CultureInfo("en-US");

                Check_AdRepository Check_AdRepository = new Check_AdRepository();

                List<CheckAdGetModel> Check_Ad_Success_In = Check_AdRepository.Check_Ad_Success_In(CheckAdInputModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = Check_Ad_Success_In;
                _ResponseModel.length = Check_Ad_Success_In.Count();
                _ResponseModel.status = "Success";

                return _ResponseModel;

            }
            catch (Exception ex)
            {

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

        #region Check_Ad_Qty_In
        [Route("api/Check_Ad_Qty_In")]
        [HttpPut]
        public ResponseModel Check_Ad_Qty_In([FromBody] CheckAdInputModel CheckAdInputModel)
        {

            try
            {
                CultureInfo cultureinfo = new CultureInfo("en-US");

                Check_AdRepository Check_AdRepository = new Check_AdRepository();

                List<CheckAdGetModel> Check_Ad_Qty_In = Check_AdRepository.Check_Ad_Qty_In(CheckAdInputModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = Check_Ad_Qty_In;
                _ResponseModel.length = Check_Ad_Qty_In.Count();
                _ResponseModel.status = "Success";

                return _ResponseModel;

            }
            catch (Exception ex)
            {

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

        #region Check_Ad_Remark_Create_In
        [Route("api/Check_Ad_Remark_Create_In")]
        [HttpPost]
        public ResponseModel Check_Ad_Remark_Create_In([FromBody] CheckAdInputModel CheckAdInputModel)
        {

            try
            {
                CultureInfo cultureinfo = new CultureInfo("en-US");

                Check_AdRepository Check_AdRepository = new Check_AdRepository();

                List<CheckAdGetModel> Check_Ad_Remark_Create_In = Check_AdRepository.Check_Ad_Remark_Create_In(CheckAdInputModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = Check_Ad_Remark_Create_In;
                _ResponseModel.length = Check_Ad_Remark_Create_In.Count();
                _ResponseModel.status = "Success";

                return _ResponseModel;

            }
            catch (Exception ex)
            {

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

        #region Check_Ad_Remark_Delete_In
        [Route("api/Check_Ad_Remark_Delete_In")]
        [HttpDelete]
        public ResponseModel Check_Ad_Remark_Delete_In([FromBody] CheckAdInputModel CheckAdInputModel)
        {

            try
            {
                CultureInfo cultureinfo = new CultureInfo("en-US");

                Check_AdRepository Check_AdRepository = new Check_AdRepository();

                List<CheckAdGetModel> Check_Ad_Remark_Delete_In = Check_AdRepository.Check_Ad_Remark_Delete_In(CheckAdInputModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = Check_Ad_Remark_Delete_In;
                _ResponseModel.length = Check_Ad_Remark_Delete_In.Count();
                _ResponseModel.status = "Success";

                return _ResponseModel;

            }
            catch (Exception ex)
            {

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

        //#region Check_Br_Update_Out
        //[Route("api/Check_Br_Update_Out")]
        //[HttpPut]
        //public ResponseModel Check_Br_Update_Out([FromBody] CheckBrModel CheckBrModel)
        //{

        //    try
        //    {
        //        CultureInfo cultureinfo = new CultureInfo("en-US");

        //        Check_BrRepository TrpRepository = new Check_BrRepository();

        //        List<CheckBrModel> Check_Br_Update_Out = TrpRepository.Check_Br_Update_Out(CheckBrModel);

        //        ResponseModel _ResponseModel = new ResponseModel();

        //        _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
        //        _ResponseModel.data = Check_Br_Update_Out;
        //        _ResponseModel.length = Check_Br_Update_Out.Count();
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
        //#endregion

        //#region Check_Br_Get_Out
        //[Route("api/Check_Br_Get_Out")]
        //[HttpGet]
        //public ResponseModel Check_Br_Get_Out([FromUri] CheckBrModel CheckBrModel)
        //{

        //    try
        //    {
        //        CultureInfo cultureinfo = new CultureInfo("en-US");

        //        Check_BrRepository TrpRepository = new Check_BrRepository();

        //        List<CheckBrModel> Check_Br_Get_Out = TrpRepository.Check_Br_Get_Out(CheckBrModel);

        //        ResponseModel _ResponseModel = new ResponseModel();

        //        _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
        //        _ResponseModel.data = Check_Br_Get_Out;
        //        _ResponseModel.length = Check_Br_Get_Out.Count();
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
        //#endregion

        //#region Check_Br_Count_Out
        //[Route("api/Check_Br_Count_Out")]
        //[HttpGet]
        //public ResponseModel Check_Br_Count_Out([FromUri] CheckBrModel CheckBrModel)
        //{

        //    try
        //    {
        //        CultureInfo cultureinfo = new CultureInfo("en-US");

        //        Check_BrRepository TrpRepository = new Check_BrRepository();

        //        List<CheckBrModel> Check_Br_Count_Out = TrpRepository.Check_Br_Count_Out(CheckBrModel);

        //        ResponseModel _ResponseModel = new ResponseModel();

        //        _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
        //        _ResponseModel.data = Check_Br_Count_Out;
        //        _ResponseModel.length = Check_Br_Count_Out.Count();
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
        //#endregion

        //#region Check_Br_Success_Out
        //[Route("api/Check_Br_Success_Out")]
        //[HttpPut]
        //public ResponseModel Check_Br_Success_Out([FromBody] CheckBrModel CheckBrModel)
        //{

        //    try
        //    {
        //        CultureInfo cultureinfo = new CultureInfo("en-US");

        //        Check_BrRepository TrpRepository = new Check_BrRepository();

        //        List<CheckBrModel> Check_Br_Success_Out = TrpRepository.Check_Br_Success_Out(CheckBrModel);

        //        ResponseModel _ResponseModel = new ResponseModel();

        //        _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
        //        _ResponseModel.data = Check_Br_Success_Out;
        //        _ResponseModel.length = Check_Br_Success_Out.Count();
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
        //#endregion

        //#region Check_Br_Remark_Create_Out
        //[Route("api/Check_Br_Remark_Create_Out")]
        //[HttpPost]
        //public ResponseModel Check_Br_Remark_Create_Out([FromBody] CheckBrModel CheckBrModel)
        //{

        //    try
        //    {
        //        CultureInfo cultureinfo = new CultureInfo("en-US");

        //        Check_BrRepository TrpRepository = new Check_BrRepository();

        //        List<CheckBrModel> Check_Br_Remark_Create_Out = TrpRepository.Check_Br_Remark_Create_Out(CheckBrModel);

        //        ResponseModel _ResponseModel = new ResponseModel();

        //        _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
        //        _ResponseModel.data = Check_Br_Remark_Create_Out;
        //        _ResponseModel.length = Check_Br_Remark_Create_Out.Count();
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
        //#endregion

        //#region Check_Ad_Remark_Create_Out
        //[Route("api/Check_Ad_Remark_Create_Out")]
        //[HttpDelete]
        //public ResponseModel Check_Ad_Remark_Create_Out([FromBody] CheckBrModel CheckBrModel)
        //{

        //    try
        //    {
        //        CultureInfo cultureinfo = new CultureInfo("en-US");

        //        Check_BrRepository TrpRepository = new Check_BrRepository();

        //        List<CheckBrModel> Check_Ad_Remark_Create_Out = TrpRepository.Check_Ad_Remark_Create_Out(CheckBrModel);

        //        ResponseModel _ResponseModel = new ResponseModel();

        //        _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
        //        _ResponseModel.data = Check_Ad_Remark_Create_Out;
        //        _ResponseModel.length = Check_Ad_Remark_Create_Out.Count();
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
        //#endregion

        //#region Check_Br_Qty_Out
        //[Route("api/Check_Br_Qty_Out")]
        //[HttpPut]
        //public ResponseModel Check_Br_Qty_Out([FromBody] CheckBrModel CheckBrModel)
        //{

        //    try
        //    {
        //        CultureInfo cultureinfo = new CultureInfo("en-US");

        //        Check_BrRepository TrpRepository = new Check_BrRepository();

        //        List<CheckBrModel> Check_Br_Qty_Out = TrpRepository.Check_Br_Qty_Out(CheckBrModel);

        //        ResponseModel _ResponseModel = new ResponseModel();

        //        _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
        //        _ResponseModel.data = Check_Br_Qty_Out;
        //        _ResponseModel.length = Check_Br_Qty_Out.Count();
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
        //#endregion

    }
}
