using REPO.Models;
using REPO.Controllers;
using System.Web.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;

namespace API.Controllers
{
    public class ManualController : ApiController
    {

        #region Manual_Get
        [Route("v1/Manual_Get")]
        [HttpGet]
        public ResponseModel Manual_Get([FromUri] string category_id, string category_name)
        {

            try
            {
                CultureInfo cultureinfo = new CultureInfo("en-US");

                ManualRepository ManualRepository = new ManualRepository();

                List<ManualGetModel> Manual_Get = ManualRepository.Manual_Get(category_id, category_name);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = Manual_Get;
                _ResponseModel.length = Manual_Get.Count();
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
