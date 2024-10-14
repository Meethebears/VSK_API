using REPO.Controllers;
using REPO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace API.Controllers
{
    public class SlipBillController : ApiController
    {
        [Route("v1/Slip_List")]
        [HttpGet]
        public ResponseModel Slip_List([FromUri] SlipAllModel SlipAllModel)
        {
            try
            {
                SlipBillRepository SlipBillRepository = new SlipBillRepository();

                List<SlipAllModel> Slip_List = SlipBillRepository.Slip_List(SlipAllModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = Slip_List;
                _ResponseModel.length = Slip_List.Count();
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

        [Route("v1/Slip_Create")]
        [HttpPost]
        public ResponseModel Slip_Create(SlipModel SlipModel)
        {
            try
            {
                SlipBillRepository SlipBillRepository = new SlipBillRepository();

                List<SlipModel> Slip_Create = SlipBillRepository.Slip_Create(SlipModel);

                ResponseModel _ResponseModel = new ResponseModel();
                
                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = Slip_Create;
                _ResponseModel.length = Slip_Create.Count();
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

        [Route("v1/Slip_Update")]
        [HttpPut]
        public ResponseModel Slip_Update(SlipModel SlipModel)
        {
            try
            {
                SlipBillRepository SlipBillRepository = new SlipBillRepository();

                List<SlipModel> Slip_Update = SlipBillRepository.Slip_Update(SlipModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = Slip_Update;
                _ResponseModel.length = Slip_Update.Count();
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

        [Route("v1/Slip_Delete")]
        [HttpDelete]
        public ResponseModel Slip_Delete(SlipBillModel SlipBillModel)
        {
            try
            {
                SlipBillRepository SlipBillRepository = new SlipBillRepository();

                List<SlipBillModel> Slip_Delete = SlipBillRepository.Slip_Delete(SlipBillModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = Slip_Delete;
                _ResponseModel.length = Slip_Delete.Count();
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

        [Route("v1/Slip_Upload")]
        [HttpPost]
        public ResponseModel Slip_Upload(SlipImageModel SlipImageModel)
        {
            try
            {
                SlipBillRepository SlipBillRepository = new SlipBillRepository();

                List<SlipImageModel> Slip_Upload = SlipBillRepository.Slip_Upload(SlipImageModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = Slip_Upload;
                _ResponseModel.length = Slip_Upload.Count();
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

        [Route("v1/Slip_Detail")]
        [HttpGet]
        public ResponseModel Slip_Detail([FromUri] SlipAllModel SlipAllModel)
        {
            try
            {
                SlipBillRepository SlipBillRepository = new SlipBillRepository();

                List<SlipAllModel> Slip_Detail = SlipBillRepository.Slip_Detail(SlipAllModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = Slip_Detail;
                _ResponseModel.length = Slip_Detail.Count();
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

        [Route("v1/Slip_Bill_Create")]
        [HttpPost]
        public ResponseModel Slip_Bill_Create(SlipBillModel SlipBillModel)
        {
            try
            {

                SlipBillRepository SlipBillRepository = new SlipBillRepository();

                List<SlipBillModel> SlipBillItem = SlipBillRepository.BILL_BRANCH_GET(SlipBillModel);

                List<SlipBillModel> SlipBillList = SlipBillRepository.Slip_Bill_Create(SlipBillItem, SlipBillModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = SlipBillList;
                _ResponseModel.length = SlipBillList.Count();
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

        [Route("v1/Slip_Bill_List")]
        [HttpGet]
        public ResponseModel Slip_Bill_List([FromUri] SlipBillModel SlipBillModel)
        {
            try
            {
                SlipBillRepository SlipBillRepository = new SlipBillRepository();

                List<SlipBillModel> Slip_Bill_List = SlipBillRepository.Slip_Bill_List(SlipBillModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = Slip_Bill_List;
                _ResponseModel.length = Slip_Bill_List.Count();
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

        [Route("v1/Slip_Bill_Delete")]
        [HttpDelete]
        public ResponseModel Slip_Bill_Delete(SlipBillModel SlipBillModel)
        {
            try
            {
                SlipBillRepository SlipBillRepository = new SlipBillRepository();

                List<SlipBillModel> Slip_Bill_Delete = SlipBillRepository.Slip_Bill_Delete(SlipBillModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = Slip_Bill_Delete;
                _ResponseModel.length = Slip_Bill_Delete.Count();
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

        [Route("v1/Slip_Master")]
        [HttpGet]
        public ResponseModel Slip_Master([FromUri] Master_Model Master_Model)
        {
            try
            {
                SlipBillRepository SlipBillRepository = new SlipBillRepository();

                List<Master_Model> Slip_Master = SlipBillRepository.Slip_Master(Master_Model);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = Slip_Master;
                _ResponseModel.length = Slip_Master.Count();
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

        [Route("v1/Slip_Bill_Get")]
        [HttpGet]
        public ResponseModel Slip_Bill_Get([FromUri] SlipBillModel SlipBillModel)
        {
            try
            {
                SlipBillRepository SlipBillRepository = new SlipBillRepository();

                List<SlipBillModel> Slip_Bill_Get = SlipBillRepository.Slip_Bill_Get(SlipBillModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = Slip_Bill_Get;
                _ResponseModel.length = Slip_Bill_Get.Count();
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


        //[Route("v1/BILL_BRANCH_GET")]
        //[HttpGet]
        //public ResponseModel BILL_BRANCH_GET([FromUri] string bill_no, string branch)
        //{
        //    try
        //    {
        //        SlipBillRepository SlipBillRepository = new SlipBillRepository();
        //        ResponseModel _ResponseModel = new ResponseModel();

        //        List<SlipBillModel> BILL_BRANCH_GET = SlipBillRepository.BILL_BRANCH_GET(bill_no, branch);

        //        _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
        //        _ResponseModel.data = BILL_BRANCH_GET;
        //        _ResponseModel.length = BILL_BRANCH_GET.Count();
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

        [Route("v1/BILL_BRANCH_GET")]
        [HttpGet]
        public ResponseModel BILL_BRANCH_GET([FromUri] SlipBillModel SlipBillModel)
        {
            try
            {
                SlipBillRepository SlipBillRepository = new SlipBillRepository();

                List<SlipBillModel> BILL_BRANCH_GET = SlipBillRepository.BILL_BRANCH_GET(SlipBillModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = BILL_BRANCH_GET;
                _ResponseModel.length = BILL_BRANCH_GET.Count();
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

        //[Route("v1/Slip_Bill_CreateV1")]
        //[HttpPost]
        //public ResponseModel Slip_Bill_CreateV1(SlipBillModel SlipBillModel)
        //{
        //    try
        //    {

        //        SlipBillRepository SlipBillRepository = new SlipBillRepository();

        //        List<SlipBillModel> SlipBillItem = SlipBillRepository.Slip_Bill_Get(SlipBillModel);

        //        List<SlipBillModel> SlipBillList = SlipBillRepository.Slip_Bill_Create(SlipBillItem, SlipBillModel);

        //        ResponseModel _ResponseModel = new ResponseModel();

        //        _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
        //        _ResponseModel.data = SlipBillList;
        //        _ResponseModel.length = SlipBillList.Count();
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
