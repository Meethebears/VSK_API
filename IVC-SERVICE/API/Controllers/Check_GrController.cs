using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using REPO.Models;
using REPO.Controllers;
using System.Web.Http;
using System.Globalization;

namespace API.Controllers
{
    public class Check_GrController : ApiController
    {

        #region CK_GR_CREATE
        [Route("api/CK_GR_CREATE")]
        [HttpPost]
        public ResponseModel CK_GR_CREATE([FromBody] CheckGrParamCreateModel CheckGrParamCreateModel)
        {
            try
            {

                Check_GrRepository Check_GrRepository = new Check_GrRepository();

                List<CheckGrDataModel> CK_GR_CREATE = Check_GrRepository.CK_GR_CREATE(CheckGrParamCreateModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = CK_GR_CREATE;
                _ResponseModel.length = CK_GR_CREATE.Count();
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

        #region CK_GR_FILE_GET
        [Route("api/CK_GR_FILE_GET")]
        [HttpGet]
        public ResponseModel CK_GR_FILE_GET([FromUri] CheckGrParamGetModel CheckGrParamGetModel)
        {
            try
            {

                Check_GrRepository Check_GrRepository = new Check_GrRepository();

                List<CheckGrFileModel> CK_GR_FILE_GET = Check_GrRepository.CK_GR_FILE_GET(CheckGrParamGetModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = CK_GR_FILE_GET;
                _ResponseModel.length = CK_GR_FILE_GET.Count();
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

        #region CK_GR_TRA_GET
        [Route("api/CK_GR_TRA_GET")]
        [HttpGet]
        public ResponseModel CK_GR_TRA_GET([FromUri] CheckGrParamGetModel CheckGrParamGetModel)
        {
            try
            {

                Check_GrRepository Check_GrRepository = new Check_GrRepository();

                List<CheckGrTraModel> CK_GR_TRA_GET = Check_GrRepository.CK_GR_TRA_GET(CheckGrParamGetModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = CK_GR_TRA_GET;
                _ResponseModel.length = CK_GR_TRA_GET.Count();
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

        #region CK_GR_VERIFY
        [Route("api/CK_GR_VERIFY")]
        [HttpPost]
        public ResponseModel CK_GR_VERIFY([FromBody] CheckGrParamVerifyModel CheckGrParamVerifyModel)
        {
            try
            {

                Check_GrRepository Check_GrRepository = new Check_GrRepository();

                List<CheckGrDataModel> CK_GR_VERIFY = Check_GrRepository.CK_GR_VERIFY(CheckGrParamVerifyModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = CK_GR_VERIFY;
                _ResponseModel.length = CK_GR_VERIFY.Count();
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