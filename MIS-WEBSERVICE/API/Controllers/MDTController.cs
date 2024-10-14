using REPO.Controllers;
using REPO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web.Http;

namespace API.Controllers
{
    public class MDTController : ApiController
    {
        [Route("api/snk_inv_daily_get")]
        [HttpGet]
        public ResponseModel SNK_INV_DAILY_GET([FromUri] DateTime ORDER_DATE, string ORDER_TYPE)
        {
            try
            {
                MDTRepository MDTRepository = new MDTRepository();
                ResponseModel _ResponseModel = new ResponseModel();

                List<MDTModel> SNK_INV_DAILY_LIST = MDTRepository.SNK_INV_DAILY_GET(ORDER_DATE, ORDER_TYPE);

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = SNK_INV_DAILY_LIST;
                _ResponseModel.length = SNK_INV_DAILY_LIST.Count();
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
