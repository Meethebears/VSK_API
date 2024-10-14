using REPO.Models;
using REPO.Controllers;
using System.Web.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;

namespace API.Controllers
{
    public class ReportController : ApiController
    {

        #region Report_Get
        [Route("api/Report_Get")]
        [HttpGet]
        public ResponseModel Report_Get([FromUri] ReportModel ReportModel)
        {

            try
            {
                CultureInfo cultureinfo = new CultureInfo("en-US");

                ReportRepository ReportRepository = new ReportRepository();

                List<ReportModel> Report_Get = ReportRepository.Report_Get(ReportModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = Report_Get;
                _ResponseModel.length = Report_Get.Count();
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
