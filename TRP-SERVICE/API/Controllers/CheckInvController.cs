using REPO.Controllers;
using REPO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Globalization;

namespace API.Controllers
{
    public class CheckInvController : ApiController
    {

        [Route("v1/Trp_Ck_Inv_List")]
        [HttpGet]
        public ResponseModel Trp_Ck_Inv_List([FromUri] CheckInvModel CheckInvModel)
        {
            try
            {
                CheckInvRepository CheckInvRepository = new CheckInvRepository();

                List<CheckInvModel> Trp_Ck_Inv_List = CheckInvRepository.Trp_Ck_Inv_List(CheckInvModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = Trp_Ck_Inv_List;
                _ResponseModel.length = Trp_Ck_Inv_List.Count();
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

        [Route("v1/Trp_Ck_Inv_Create")]
        [HttpGet]
        public ResponseModel Trp_Ck_Inv_Create([FromUri] CheckInvModel CheckInvModel)
        {
            try
            {
                CheckInvRepository CheckInvRepository = new CheckInvRepository();

                List<CheckInvModel> Trp_Ck_Inv_Create = CheckInvRepository.Trp_Ck_Inv_Create(CheckInvModel);

                ResponseModel _ResponseModel = new ResponseModel();
                
                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = Trp_Ck_Inv_Create;
                _ResponseModel.length = Trp_Ck_Inv_Create.Count();
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

        [Route("v1/Trp_Ck_Inv_Update")]
        [HttpPut]
        public ResponseModel Trp_Ck_Inv_Update(CheckInvModel CheckInvModel)
        {
            try
            {
                CheckInvRepository CheckInvRepository = new CheckInvRepository();

                List<CheckInvModel> Trp_Ck_Inv_Update = CheckInvRepository.Trp_Ck_Inv_Update(CheckInvModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = Trp_Ck_Inv_Update;
                _ResponseModel.length = Trp_Ck_Inv_Update.Count();
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

        [Route("v1/Trp_Ck_Inv_Detail")]
        [HttpGet]
        public ResponseModel Trp_Ck_Inv_Detail([FromUri] CheckInvModel CheckInvModel)
        {
            try
            {
                CheckInvRepository CheckInvRepository = new CheckInvRepository();

                List<CheckInvModel> Trp_Ck_Inv_Detail = CheckInvRepository.Trp_Ck_Inv_Detail(CheckInvModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = Trp_Ck_Inv_Detail;
                _ResponseModel.length = Trp_Ck_Inv_Detail.Count();
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

        [Route("v1/Master_Selete2")]
        [HttpGet]
        public ResponseModel Master_Selete2([FromUri] ResponseSelect2Model ResponseSelect2Model)
        {
            try
            {
                CheckInvRepository CheckInvRepository = new CheckInvRepository();

                List<ResponseSelect2Model> Master_Selete2 = CheckInvRepository.Master_Selete2(ResponseSelect2Model);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = Master_Selete2;
                _ResponseModel.length = Master_Selete2.Count();
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


        #region CK_INV_CREATE_OUT
        [Route("api/CK_INV_CREATE_OUT")]
        [HttpPost]
        public ResponseModel CK_INV_CREATE_OUT([FromBody] CheckInvInputModel CheckInvInputModel)
        {

            try
            {
                CultureInfo cultureinfo = new CultureInfo("en-US");

                CheckInvRepository CheckInvRepository = new CheckInvRepository();

                List<CheckInvDataModel> CK_INV_CREATE_OUT = CheckInvRepository.CK_INV_CREATE_OUT(CheckInvInputModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = CK_INV_CREATE_OUT;
                _ResponseModel.length = CK_INV_CREATE_OUT.Count();
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
        #region CK_INV_UPDATE_OUT
        [Route("api/CK_INV_UPDATE_OUT")]
        [HttpPut]
        public ResponseModel CK_INV_UPDATE_OUT([FromBody] CheckInvInputModel CheckInvInputModel)
        {

            try
            {
                CultureInfo cultureinfo = new CultureInfo("en-US");

                CheckInvRepository CheckInvRepository = new CheckInvRepository();

                List<CheckInvDataModel> CK_INV_UPDATE_OUT = CheckInvRepository.CK_INV_UPDATE_OUT(CheckInvInputModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = CK_INV_UPDATE_OUT;
                _ResponseModel.length = CK_INV_UPDATE_OUT.Count();
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
        #region CK_INV_VERIFY_OUT
        [Route("api/CK_INV_VERIFY_OUT")]
        [HttpPut]
        public ResponseModel CK_INV_VERIFY_OUT([FromBody] CheckInvInputModel CheckInvInputModel)
        {

            try
            {
                CultureInfo cultureinfo = new CultureInfo("en-US");

                CheckInvRepository CheckInvRepository = new CheckInvRepository();

                List<CheckInvDataModel> CK_INV_VERIFY_OUT = CheckInvRepository.CK_INV_VERIFY_OUT(CheckInvInputModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = CK_INV_VERIFY_OUT;
                _ResponseModel.length = CK_INV_VERIFY_OUT.Count();
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
        #region CK_INV_QTY_OUT
        [Route("api/CK_INV_QTY_OUT")]
        [HttpPut]
        public ResponseModel CK_INV_QTY_OUT([FromBody] CheckInvInputModel CheckInvInputModel)
        {

            try
            {
                CultureInfo cultureinfo = new CultureInfo("en-US");

                CheckInvRepository CheckInvRepository = new CheckInvRepository();

                List<CheckInvDataModel> CK_INV_QTY_OUT = CheckInvRepository.CK_INV_QTY_OUT(CheckInvInputModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = CK_INV_QTY_OUT;
                _ResponseModel.length = CK_INV_QTY_OUT.Count();
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
        #region CK_INV_GET_OUT
        [Route("api/CK_INV_GET_OUT")]
        [HttpGet]
        public ResponseModel CK_INV_GET_OUT([FromUri] CheckInvInputModel CheckInvInputModel)
        {

            try
            {
                CultureInfo cultureinfo = new CultureInfo("en-US");

                CheckInvRepository CheckInvRepository = new CheckInvRepository();

                List<CheckInvDataModel> CK_INV_GET_OUT = CheckInvRepository.CK_INV_GET_OUT(CheckInvInputModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = CK_INV_GET_OUT;
                _ResponseModel.length = CK_INV_GET_OUT.Count();
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
        #region CK_INV_COUNT_OUT
        [Route("api/CK_INV_COUNT_OUT")]
        [HttpGet]
        public ResponseModel CK_INV_COUNT_OUT([FromUri] CheckInvInputModel CheckInvInputModel)
        {

            try
            {
                CultureInfo cultureinfo = new CultureInfo("en-US");

                CheckInvRepository CheckInvRepository = new CheckInvRepository();

                List<CheckInvCountModel> CK_INV_COUNT_OUT = CheckInvRepository.CK_INV_COUNT_OUT(CheckInvInputModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = CK_INV_COUNT_OUT;
                _ResponseModel.length = CK_INV_COUNT_OUT.Count();
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
        #region CK_INV_SUCCESS_OUT
        [Route("api/CK_INV_SUCCESS_OUT")]
        [HttpPut]
        public ResponseModel CK_INV_SUCCESS_OUT([FromBody] CheckInvInputModel CheckInvInputModel)
        {

            try
            {
                CultureInfo cultureinfo = new CultureInfo("en-US");

                CheckInvRepository CheckInvRepository = new CheckInvRepository();

                List<CheckInvDataModel> CK_INV_SUCCESS_OUT = CheckInvRepository.CK_INV_SUCCESS_OUT(CheckInvInputModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = CK_INV_SUCCESS_OUT;
                _ResponseModel.length = CK_INV_SUCCESS_OUT.Count();
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
        #region CK_INV_LIST
        [Route("api/CK_INV_LIST")]
        [HttpGet]
        public ResponseModel CK_INV_LIST([FromUri] CheckListInputModel CheckListInputModel)
        {

            try
            {
                CultureInfo cultureinfo = new CultureInfo("en-US");

                CheckInvRepository CheckInvRepository = new CheckInvRepository();

                List<CheckInvDataModel> CK_INV_LIST = CheckInvRepository.CK_INV_LIST(CheckListInputModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = CK_INV_LIST;
                _ResponseModel.length = CK_INV_LIST.Count();
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
        #region CK_INV_MASTER
        [Route("api/CK_INV_MASTER")]
        [HttpGet]
        public ResponseModel CK_INV_MASTER([FromUri] ResponseSelect2Model ResponseSelect2Model)
        {

            try
            {
                CultureInfo cultureinfo = new CultureInfo("en-US");

                CheckInvRepository CheckInvRepository = new CheckInvRepository();

                List<ResponseSelect2Model> CK_INV_MASTER = CheckInvRepository.CK_INV_MASTER(ResponseSelect2Model);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = CK_INV_MASTER;
                _ResponseModel.length = CK_INV_MASTER.Count();
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
