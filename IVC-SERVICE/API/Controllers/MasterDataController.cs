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

    }
}
