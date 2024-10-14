using Newtonsoft.Json;
using REPO.Controllers;
using REPO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web.Http;

namespace API.Controllers
{
    public class HDWController : ApiController
    {

        [Route("v4/HDW_DailyDeliveryGet")]
        [HttpGet]
        public ResponseModel HDW_DailyDeliveryGet()
        {
            try
            {

                HttpClient _httpClient = new HttpClient();

                string uri = "https://vsk.tms-vcargo.com/api/tms/v1/public/dailydelivery/report";
                var _http_response = _httpClient.GetAsync(uri);
                _http_response.Wait();
                var _read_response = _http_response.Result.Content.ReadAsStringAsync();
                _read_response.Wait();
                if (_read_response.Result.Contains("No Data Found!"))
                {
                    // Your Logic what you would like to do when no response
                }

                var data = JsonConvert.DeserializeObject<HDW_DailyDeliveryModel>(_read_response.Result);

                ResponseModel _ResponseModel = new ResponseModel();
                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = data;
              //  _ResponseModel.length = data.Count();
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
