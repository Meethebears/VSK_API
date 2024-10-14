using REPO.Models;
using REPO.Controllers;
using System.Web.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;

namespace API.Controllers
{
    public class Stock_RequestController : ApiController
    {
        #region STOCK_REQUEST_DATA_DETAIL
        [Route("api/STOCK_REQUEST_DATA_DETAIL")]
        [HttpGet]
        public ResponseModel STOCK_REQUEST_DATA_DETAIL([FromUri] StockRequestModel StockRequestModel)
        {

            try
            {
                CultureInfo cultureinfo = new CultureInfo("en-US");

                Stock_RequestRepository IvcRepository = new Stock_RequestRepository();

                List<StockRequestModel> STOCK_REQUEST_DATA_DETAIL = IvcRepository.STOCK_REQUEST_DATA_DETAIL(StockRequestModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = STOCK_REQUEST_DATA_DETAIL;
                _ResponseModel.length = STOCK_REQUEST_DATA_DETAIL.Count();
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

        #region STOCK_REQUEST_DATA_CREATE
        [Route("api/STOCK_REQUEST_DATA_CREATE")]
        [HttpPost]
        public ResponseModel STOCK_REQUEST_DATA_CREATE([FromBody] StockRequestModel StockRequestModel)
        {

            try
            {
                CultureInfo cultureinfo = new CultureInfo("en-US");

                Stock_RequestRepository IvcRepository = new Stock_RequestRepository();

                List<StockRequestModel> STOCK_REQUEST_DATA_CREATE = IvcRepository.STOCK_REQUEST_DATA_CREATE(StockRequestModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = STOCK_REQUEST_DATA_CREATE;
                _ResponseModel.length = STOCK_REQUEST_DATA_CREATE.Count();
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

        #region STOCK_REQUEST_DATA_DELETE
        [Route("api/STOCK_REQUEST_DATA_DELETE")]
        [HttpDelete]
        public ResponseModel STOCK_REQUEST_DATA_DELETE([FromBody] StockRequestModel StockRequestModel)
        {

            try
            {
                CultureInfo cultureinfo = new CultureInfo("en-US");

                Stock_RequestRepository IvcRepository = new Stock_RequestRepository();

                List<StockRequestModel> STOCK_REQUEST_DATA_DELETE = IvcRepository.STOCK_REQUEST_DATA_DELETE(StockRequestModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = STOCK_REQUEST_DATA_DELETE;
                _ResponseModel.length = STOCK_REQUEST_DATA_DELETE.Count();
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

        #region STOCK_REQUEST_DATA_UPDATE
        [Route("api/STOCK_REQUEST_DATA_UPDATE")]
        [HttpPut]
        public ResponseModel STOCK_REQUEST_DATA_UPDATE([FromBody] StockRequestModel StockRequestModel)
        {

            try
            {
                CultureInfo cultureinfo = new CultureInfo("en-US");

                Stock_RequestRepository IvcRepository = new Stock_RequestRepository();

                List<StockRequestModel> STOCK_REQUEST_DATA_UPDATE = IvcRepository.STOCK_REQUEST_DATA_UPDATE(StockRequestModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = STOCK_REQUEST_DATA_UPDATE;
                _ResponseModel.length = STOCK_REQUEST_DATA_UPDATE.Count();
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

        #region STOCK_REQUEST_ITEM_CREATE
        [Route("api/STOCK_REQUEST_ITEM_CREATE")]
        [HttpPost]
        public ResponseModel STOCK_REQUEST_ITEM_CREATE([FromBody] StockRequestModel StockRequestModel)
        {

            try
            {
                CultureInfo cultureinfo = new CultureInfo("en-US");

                Stock_RequestRepository IvcRepository = new Stock_RequestRepository();

                List<StockRequestModel> STOCK_REQUEST_ITEM_CREATE = IvcRepository.STOCK_REQUEST_ITEM_CREATE(StockRequestModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = STOCK_REQUEST_ITEM_CREATE;
                _ResponseModel.length = STOCK_REQUEST_ITEM_CREATE.Count();
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

        #region STOCK_REQUEST_ITEM_DELETE
        [Route("api/STOCK_REQUEST_ITEM_DELETE")]
        [HttpDelete]
        public ResponseModel STOCK_REQUEST_ITEM_DELETE([FromBody] StockRequestModel StockRequestModel)
        {

            try
            {
                CultureInfo cultureinfo = new CultureInfo("en-US");

                Stock_RequestRepository IvcRepository = new Stock_RequestRepository();

                List<StockRequestModel> STOCK_REQUEST_ITEM_DELETE = IvcRepository.STOCK_REQUEST_ITEM_DELETE(StockRequestModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = STOCK_REQUEST_ITEM_DELETE;
                _ResponseModel.length = STOCK_REQUEST_ITEM_DELETE.Count();
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

        #region STOCK_REQUEST_ITEM_UPDATE
        [Route("api/STOCK_REQUEST_ITEM_UPDATE")]
        [HttpPut]
        public ResponseModel STOCK_REQUEST_ITEM_UPDATE([FromBody] StockRequestModel StockRequestModel)
        {

            try
            {
                CultureInfo cultureinfo = new CultureInfo("en-US");

                Stock_RequestRepository IvcRepository = new Stock_RequestRepository();

                List<StockRequestModel> STOCK_REQUEST_ITEM_UPDATE = IvcRepository.STOCK_REQUEST_ITEM_UPDATE(StockRequestModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = STOCK_REQUEST_ITEM_UPDATE;
                _ResponseModel.length = STOCK_REQUEST_ITEM_UPDATE.Count();
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

        #region STOCK_REQUEST_LIST
        [Route("api/STOCK_REQUEST_LIST")]
        [HttpGet]
        public ResponseModel STOCK_REQUEST_LIST([FromUri] StockRequestModel StockRequestModel)
        {

            try
            {
                CultureInfo cultureinfo = new CultureInfo("en-US");

                Stock_RequestRepository IvcRepository = new Stock_RequestRepository();

                List<StockRequestModel> STOCK_REQUEST_LIST = IvcRepository.STOCK_REQUEST_LIST(StockRequestModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = STOCK_REQUEST_LIST;
                _ResponseModel.length = STOCK_REQUEST_LIST.Count();
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

        #region STOCK_REQUEST_LOG_LIST
        [Route("api/STOCK_REQUEST_LOG_LIST")]
        [HttpGet]
        public ResponseModel STOCK_REQUEST_LOG_LIST([FromUri] StockRequestModel StockRequestModel)
        {

            try
            {
                CultureInfo cultureinfo = new CultureInfo("en-US");

                Stock_RequestRepository IvcRepository = new Stock_RequestRepository();

                List<StockRequestModel> STOCK_REQUEST_LOG_LIST = IvcRepository.STOCK_REQUEST_LOG_LIST(StockRequestModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = STOCK_REQUEST_LOG_LIST;
                _ResponseModel.length = STOCK_REQUEST_LOG_LIST.Count();
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
