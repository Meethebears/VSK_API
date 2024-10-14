using REPO.Models;
using REPO.Controllers;
using System.Web.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;

namespace API.Controllers
{
    public class MasterDataController : ApiController
    {
        #region MasterData_Get
        [Route("api/MasterData_Get")]
        [HttpGet]
        public ResponseModel MasterData_Get([FromUri] MasterDataModel MasterDataModel)
        {

            try
            {
                CultureInfo cultureinfo = new CultureInfo("en-US");

                MasterDataRepository MasterDataRepository = new MasterDataRepository();

                List<MasterDataModel> MasterData_Get = MasterDataRepository.MasterData_Get(MasterDataModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = MasterData_Get;
                _ResponseModel.length = MasterData_Get.Count();
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

        [Route("api/MasterBR_Get")]
        [HttpGet]
        public ResponseModel MasterBR_Get([FromUri] string number)
        {
            try
            {
                CultureInfo cultureinfo = new CultureInfo("en-US");

                MasterDataRepository MasterDataRepository = new MasterDataRepository();

                List<BRModel> MasterBR_Get = MasterDataRepository.MasterBR_Get(number);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = MasterBR_Get;
                _ResponseModel.length = MasterBR_Get.Count();
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

        [Route("api/MasterSTMAS_Get")]
        [HttpGet]
        public ResponseModel MasterStmas_Get([FromUri] StmasModel StmasModel)
        {
            try
            {
                MasterDataRepository MasterDataRepository = new MasterDataRepository();

                List<StmasModel> MasterStmas_Get = MasterDataRepository.MasterStmas_Get(StmasModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = MasterStmas_Get;
                _ResponseModel.length = MasterStmas_Get.Count();
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

        [Route("api/MasterStmas_213_Get")]
        [HttpGet]
        public ResponseModel MasterStmas_213_Get([FromUri] StmasModel StmasModel)
        {
            try
            {
                MasterDataRepository MasterDataRepository = new MasterDataRepository();

                List<StmasModel> MasterStmas_213_Get = MasterDataRepository.MasterStmas_213_Get(StmasModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = MasterStmas_213_Get;
                _ResponseModel.length = MasterStmas_213_Get.Count();
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

        [Route("api/MasterStmas_187_Get")]
        [HttpGet]
        public ResponseModel MasterStmas_187_Get([FromUri] StmasModel StmasModel)
        {
            try
            {
                MasterDataRepository MasterDataRepository = new MasterDataRepository();

                List<StmasModel> MasterStmas_187_Get = MasterDataRepository.MasterStmas_187_Get(StmasModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = MasterStmas_187_Get;
                _ResponseModel.length = MasterStmas_187_Get.Count();
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

        [Route("api/MasterEan13_Get")]
        [HttpGet]
        public ResponseModel MasterEan13_Get([FromUri] MasterEan13Model MasterEan13Model)
        {
            try
            {
                MasterDataRepository MasterDataRepository = new MasterDataRepository();

                List<MasterEan13Model> MasterEan13_Get = MasterDataRepository.MasterEan13_Get(MasterEan13Model);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = MasterEan13_Get;
                _ResponseModel.length = MasterEan13_Get.Count();
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
