using REPO.Models;
using REPO.Controllers;
using System.Web.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;

namespace API.Controllers
{
    public class Check_TrController : ApiController
    {
        #region Check_Tr_List
        [Route("api/Check_Tr_List")]
        [HttpGet]
        public ResponseModel Check_Tr_List([FromUri] CheckTrModel CheckTrModel)
        {

            try
            {
                CultureInfo cultureinfo = new CultureInfo("en-US");

                Check_TrRepository IvcRepository = new Check_TrRepository();

                List<CheckTrModel> Check_Tr_List = IvcRepository.Check_Tr_List(CheckTrModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = Check_Tr_List;
                _ResponseModel.length = Check_Tr_List.Count();
                _ResponseModel.status = "Success";

                return _ResponseModel;

            }
            catch (Exception ex)
            {

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

        #region Check_Tr_View
        [Route("api/Check_Tr_View")]
        [HttpGet]
        public ResponseModel Check_Tr_View([FromUri] CheckTrModel CheckTrModel)
        {

            try
            {
                CultureInfo cultureinfo = new CultureInfo("en-US");

                Check_TrRepository IvcRepository = new Check_TrRepository();

                List<CheckTrModel> Check_Tr_View = IvcRepository.Check_Tr_View(CheckTrModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = Check_Tr_View;
                _ResponseModel.length = Check_Tr_View.Count();
                _ResponseModel.status = "Success";

                return _ResponseModel;

            }
            catch (Exception ex)
            {

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

        #region Check_Tr_Create
        [Route("api/Check_Tr_Create")]
        [HttpPost]
        public ResponseModel Check_Tr_Create([FromBody] CheckTrModel CheckTrModel)
        {

            try
            {
                CultureInfo cultureinfo = new CultureInfo("en-US");

                Check_TrRepository IvcRepository = new Check_TrRepository();

                List<CheckTrModel> Check_Tr_Create = IvcRepository.Check_Tr_Create(CheckTrModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = Check_Tr_Create;
                _ResponseModel.length = Check_Tr_Create.Count();
                _ResponseModel.status = "Success";

                return _ResponseModel;

            }
            catch (Exception ex)
            {

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

        #region Check_Tr_Update
        [Route("api/Check_Tr_Update")]
        [HttpPut]
        public ResponseModel Check_Tr_Update([FromBody] CheckTrModel CheckTrModel)
        {

            try
            {
                CultureInfo cultureinfo = new CultureInfo("en-US");

                Check_TrRepository IvcRepository = new Check_TrRepository();

                List<CheckTrModel> Check_Tr_Update = IvcRepository.Check_Tr_Update(CheckTrModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = Check_Tr_Update;
                _ResponseModel.length = Check_Tr_Update.Count();
                _ResponseModel.status = "Success";

                return _ResponseModel;

            }
            catch (Exception ex)
            {

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

        #region Check_Tr_Edit
        [Route("api/Check_Tr_Edit")]
        [HttpPut]
        public ResponseModel Check_Tr_Edit([FromBody] CheckTrModel CheckTrModel)
        {

            try
            {
                CultureInfo cultureinfo = new CultureInfo("en-US");

                Check_TrRepository IvcRepository = new Check_TrRepository();

                List<CheckTrModel> Check_Tr_Edit = IvcRepository.Check_Tr_Edit(CheckTrModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = Check_Tr_Edit;
                _ResponseModel.length = Check_Tr_Edit.Count();
                _ResponseModel.status = "Success";

                return _ResponseModel;

            }
            catch (Exception ex)
            {

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

        #region Check_Tr_Remark_List
        [Route("api/Check_Tr_Remark_List")]
        [HttpGet]
        public ResponseModel Check_Tr_Remark_List([FromUri] CheckTrModel CheckTrModel)
        {

            try
            {
                CultureInfo cultureinfo = new CultureInfo("en-US");

                Check_TrRepository IvcRepository = new Check_TrRepository();

                List<CheckTrModel> Check_Tr_Remark_List = IvcRepository.Check_Tr_Remark_List(CheckTrModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = Check_Tr_Remark_List;
                _ResponseModel.length = Check_Tr_Remark_List.Count();
                _ResponseModel.status = "Success";

                return _ResponseModel;

            }
            catch (Exception ex)
            {

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

        #region Check_Tr_Remark_Create
        [Route("api/Check_Tr_Remark_Create")]
        [HttpPost]
        public ResponseModel Check_Tr_Remark_Create([FromBody] CheckTrModel CheckTrModel)
        {

            try
            {
                CultureInfo cultureinfo = new CultureInfo("en-US");

                Check_TrRepository IvcRepository = new Check_TrRepository();

                List<CheckTrModel> Check_Tr_Remark_Create = IvcRepository.Check_Tr_Remark_Create(CheckTrModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = Check_Tr_Remark_Create;
                _ResponseModel.length = Check_Tr_Remark_Create.Count();
                _ResponseModel.status = "Success";

                return _ResponseModel;

            }
            catch (Exception ex)
            {

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

        #region Check_Tr_Remark_Delete
        [Route("api/Check_Tr_Remark_Delete")]
        [HttpDelete]
        public ResponseModel Check_Tr_Remark_Delete([FromBody] CheckTrModel CheckTrModel)
        {

            try
            {
                CultureInfo cultureinfo = new CultureInfo("en-US");

                Check_TrRepository IvcRepository = new Check_TrRepository();

                List<CheckTrModel> Check_Tr_Remark_Delete = IvcRepository.Check_Tr_Remark_Delete(CheckTrModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = Check_Tr_Remark_Delete;
                _ResponseModel.length = Check_Tr_Remark_Delete.Count();
                _ResponseModel.status = "Success";

                return _ResponseModel;

            }
            catch (Exception ex)
            {

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
