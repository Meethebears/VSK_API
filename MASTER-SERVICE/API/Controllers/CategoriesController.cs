using REPO.Models;
using REPO.Controllers;
using System.Web.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;

namespace API.Controllers
{
    public class CategoriesController : ApiController
    {

        #region Categories_Get
        [Route("v1/Categories_Get")]
        [HttpGet]
        public ResponseModel Categories_Get([FromUri] CategoriesGetModel CategoriesGetModel)
        {

            try
            {
                CultureInfo cultureinfo = new CultureInfo("en-US");

                CategoriesRepository CategoriesRepository = new CategoriesRepository();

                List<CategoriesGetModel> Categories_Get = CategoriesRepository.Categories_Get(CategoriesGetModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = Categories_Get;
                _ResponseModel.length = Categories_Get.Count();
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
