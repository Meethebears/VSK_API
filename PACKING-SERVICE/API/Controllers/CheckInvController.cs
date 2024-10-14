using REPO.Controllers;
using REPO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

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

        //[Route("v1/Slip_Delete")]
        //[HttpDelete]
        //public ResponseModel Slip_Delete(SlipBillModel SlipBillModel)
        //{
        //    try
        //    {
        //        CheckInvRepository CheckInvRepository = new CheckInvRepository();

        //        List<SlipBillModel> Slip_Delete = CheckInvRepository.Slip_Delete(SlipBillModel);

        //        ResponseModel _ResponseModel = new ResponseModel();

        //        _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
        //        _ResponseModel.data = Slip_Delete;
        //        _ResponseModel.length = Slip_Delete.Count();
        //        _ResponseModel.status = "Success";

        //        return _ResponseModel;
        //    }
        //    catch (Exception ex)
        //    {
        //        ResponseModel _ResponseModel = new ResponseModel();
        //        _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
        //        _ResponseModel.status = "Error";
        //        _ResponseModel.error_message = ex.Message.ToString();
        //        _ResponseModel.error_stacktrace = ex.StackTrace.ToString();
        //        _ResponseModel.error_source = ex.Source.ToString();

        //        return _ResponseModel;
        //    }

        //}

    }
}
