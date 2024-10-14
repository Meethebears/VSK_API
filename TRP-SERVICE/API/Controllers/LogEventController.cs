using REPO.Controllers;
using REPO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace API.Controllers
{
    public class LogEventController : ApiController
    {

        [Route("api/LogEventCreate")]
        [HttpPost]
        public ResponseModel LogEventCreate(LogEventModel LogEventModel)
        {
            try
            {
                LogEventRepository LogEventRepository = new LogEventRepository();

                LogEventRepository.LogEventCreate(LogEventModel);

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

        [Route("api/LogEventGet")]
        [HttpGet]
        public ResponseModel LogEventGet([FromUri] LogEventModel LogEventModel)
        {
            try
            {
                LogEventRepository LogEventRepository = new LogEventRepository();

                List<LogEventModel> LogEventGet = LogEventRepository.LogEventGet(LogEventModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = LogEventGet;
                _ResponseModel.length = LogEventGet.Count();
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
