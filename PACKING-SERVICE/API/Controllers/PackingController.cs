using REPO.Controllers;
using REPO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace API.Controllers
{
    public class PackingController : ApiController
    {

        [Route("v1/Trp_Packing_Check_Drop")]
        [HttpGet]
        public ResponseModel Trp_Packing_Check_Drop([FromUri] TempModel TempModel)
        {
            try
            {
                PackingRepository PackingRepository = new PackingRepository();

                List<TempModel> Trp_Packing_Check_Drop = PackingRepository.Trp_Packing_Check_Drop(TempModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = Trp_Packing_Check_Drop;
                _ResponseModel.length = Trp_Packing_Check_Drop.Count();
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

        [Route("v1/Trp_Packing_Job")]
        [HttpPost]
        public ResponseModel Trp_Packing_Job([FromBody] TempModel TempModel)
        {
            try
            {
                PackingRepository PackingRepository = new PackingRepository();

                List<TempModel> Trp_Packing_Job = PackingRepository.Trp_Packing_Job(TempModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = Trp_Packing_Job;
                _ResponseModel.length = Trp_Packing_Job.Count();
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

        [Route("v1/Trp_Packing_Job_Detail")]
        [HttpGet]
        public ResponseModel Trp_Packing_Job_Detail([FromUri] TempModel TempModel)
        {
            try
            {
                PackingRepository PackingRepository = new PackingRepository();

                List<TempModel> Trp_Packing_Job_Detail = PackingRepository.Trp_Packing_Job_Detail(TempModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = Trp_Packing_Job_Detail;
                _ResponseModel.length = Trp_Packing_Job_Detail.Count();
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

        [Route("v1/Trp_Packing_Master")]
        [HttpGet]
        public ResponseModel Trp_Packing_Master([FromUri] ResponseSelect2Model ResponseSelect2Model)
        {
            try
            {
                PackingRepository PackingRepository = new PackingRepository();

                List<ResponseSelect2Model> Trp_Packing_Master = PackingRepository.Trp_Packing_Master(ResponseSelect2Model);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = Trp_Packing_Master;
                _ResponseModel.length = Trp_Packing_Master.Count();
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

        [Route("v1/Trp_Packing_Invoice")]
        [HttpGet]
        public ResponseModel Trp_Packing_Invoice([FromUri] PackingModel PackingModel)
        {
            try
            {
                PackingRepository PackingRepository = new PackingRepository();

                List<PackingModel> Trp_Packing_Invoice = PackingRepository.Trp_Packing_Invoice(PackingModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = Trp_Packing_Invoice;
                _ResponseModel.length = Trp_Packing_Invoice.Count();
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

        [Route("v1/Trp_Packing_Box_Detail")]
        [HttpGet]
        public ResponseModel Trp_Packing_Box_Detail([FromUri] TempModel TempModel)
        {
            try
            {
                PackingRepository PackingRepository = new PackingRepository();

                List<TempModel> Trp_Packing_Box_Detail = PackingRepository.Trp_Packing_Box_Detail(TempModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = Trp_Packing_Box_Detail;
                _ResponseModel.length = Trp_Packing_Box_Detail.Count();
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

        [Route("v1/Trp_Packing_Box_Update")]
        [HttpGet]
        public ResponseModel Trp_Packing_Box_Update([FromUri] TempModel TempModel)
        {
            try
            {
                PackingRepository PackingRepository = new PackingRepository();

                List<TempModel> Trp_Packing_Box_Update = PackingRepository.Trp_Packing_Box_Update(TempModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = Trp_Packing_Box_Update;
                _ResponseModel.length = Trp_Packing_Box_Update.Count();
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

        [Route("v1/Trp_Packing_Box_Check")]
        [HttpGet]
        public ResponseModel Trp_Packing_Box_Check([FromUri] TempModel TempModel)
        {
            try
            {
                PackingRepository PackingRepository = new PackingRepository();

                List<TempModel> Trp_Packing_Box_Check = PackingRepository.Trp_Packing_Box_Check(TempModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = Trp_Packing_Box_Check;
                _ResponseModel.length = Trp_Packing_Box_Check.Count();
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

        [Route("v1/Trp_Packing_Share_Box_Create")]
        [HttpGet]
        public ResponseModel Trp_Packing_Share_Box_Create([FromUri] TempModel TempModel)
        {
            try
            {
                PackingRepository PackingRepository = new PackingRepository();

                List<TempModel> Trp_Packing_Share_Box_Create = PackingRepository.Trp_Packing_Share_Box_Create(TempModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = Trp_Packing_Share_Box_Create;
                _ResponseModel.length = Trp_Packing_Share_Box_Create.Count();
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

        [Route("v1/Trp_Packing_Share_Box_Detail")]
        [HttpGet]
        public ResponseModel Trp_Packing_Share_Box_Detail([FromUri] TempModel TempModel)
        {
            try
            {
                PackingRepository PackingRepository = new PackingRepository();

                List<TempModel> Trp_Packing_Share_Box_Detail = PackingRepository.Trp_Packing_Share_Box_Detail(TempModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = Trp_Packing_Share_Box_Detail;
                _ResponseModel.length = Trp_Packing_Share_Box_Detail.Count();
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

        [Route("v1/Trp_Packing_Share_Box_Verify")]
        [HttpGet]
        public ResponseModel Trp_Packing_Share_Box_Verify([FromUri] TempModel TempModel)
        {
            try
            {
                PackingRepository PackingRepository = new PackingRepository();

                List<TempModel> Trp_Packing_Share_Box_Verify = PackingRepository.Trp_Packing_Share_Box_Verify(TempModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = Trp_Packing_Share_Box_Verify;
                _ResponseModel.length = Trp_Packing_Share_Box_Verify.Count();
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


        [Route("v1/Trp_Packing_Share_Box_Delete")]
        [HttpDelete]
        public ResponseModel Trp_Packing_Share_Box_Delete(TempModel TempModel)
        {
            try
            {
                PackingRepository PackingRepository = new PackingRepository();

                List<TempModel> Trp_Packing_Share_Box_Delete = PackingRepository.Trp_Packing_Share_Box_Delete(TempModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = Trp_Packing_Share_Box_Delete;
                _ResponseModel.length = Trp_Packing_Share_Box_Delete.Count();
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


        [Route("v1/Trp_Packing_Invoice_Create")]
        [HttpGet]
        public ResponseModel Trp_Packing_Invoice_Create([FromUri] TempModel TempModel)
        {
            try
            {
                PackingRepository PackingRepository = new PackingRepository();

                List<TempModel> Trp_Packing_Invoice_Create = PackingRepository.Trp_Packing_Invoice_Create(TempModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = Trp_Packing_Invoice_Create;
                _ResponseModel.length = Trp_Packing_Invoice_Create.Count();
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

        [Route("v1/Trp_Packing_Invoice_Delete")]
        [HttpDelete]
        public ResponseModel Trp_Packing_Invoice_Delete(TempModel TempModel )
        {
            try
            {
                PackingRepository PackingRepository = new PackingRepository();

                List<TempModel> Trp_Packing_Invoice_Delete = PackingRepository.Trp_Packing_Invoice_Delete(TempModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = Trp_Packing_Invoice_Delete;
                _ResponseModel.length = Trp_Packing_Invoice_Delete.Count();
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


        [Route("v1/Trp_Packing_Invoice_List")]
        [HttpGet]
        public ResponseModel Trp_Packing_Invoice_List([FromUri] TempModel TempModel)
        {
            try
            {
                PackingRepository PackingRepository = new PackingRepository();

                List<TempModel> Trp_Packing_Invoice_List = PackingRepository.Trp_Packing_Invoice_List(TempModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = Trp_Packing_Invoice_List;
                _ResponseModel.length = Trp_Packing_Invoice_List.Count();
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


        [Route("v1/Trp_Packing_Job_Temp_Create")]
        [HttpGet]
        public ResponseModel Trp_Packing_Job_Temp_Create([FromUri] TempModel TempModel)
        {
            try
            {
                PackingRepository PackingRepository = new PackingRepository();

                List<TempModel> Trp_Packing_Job_Temp_Create = PackingRepository.Trp_Packing_Job_Temp_Create(TempModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = Trp_Packing_Job_Temp_Create;
                _ResponseModel.length = Trp_Packing_Job_Temp_Create.Count();
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

        [Route("v1/Trp_Packing_Job_Temp_Delete")]
        [HttpDelete]
        public ResponseModel Trp_Packing_Job_Temp_Delete(TempModel TempModel)
        {
            try
            {
                PackingRepository PackingRepository = new PackingRepository();

                List<TempModel> Trp_Packing_Job_Temp_Delete = PackingRepository.Trp_Packing_Job_Temp_Delete(TempModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = Trp_Packing_Job_Temp_Delete;
                _ResponseModel.length = Trp_Packing_Job_Temp_Delete.Count();
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

        [Route("v1/Trp_Packing_List")]
        [HttpGet]
        public ResponseModel Trp_Packing_List([FromUri] TempModel TempModel)
        {
            try
            {
                PackingRepository PackingRepository = new PackingRepository();

                List<TempModel> Trp_Packing_List = PackingRepository.Trp_Packing_List(TempModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = Trp_Packing_List;
                _ResponseModel.length = Trp_Packing_List.Count();
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

        [Route("v1/Trp_Packing_Detail")]
        [HttpGet]
        public ResponseModel Trp_Packing_Detail([FromUri] TempModel TempModel)
        {
            try
            {
                PackingRepository PackingRepository = new PackingRepository();

                List<TempModel> Trp_Packing_Detail = PackingRepository.Trp_Packing_Detail(TempModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = Trp_Packing_Detail;
                _ResponseModel.length = Trp_Packing_Detail.Count();
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

        [Route("v1/Trp_Packing_Item_Job")]
        [HttpGet]
        public ResponseModel Trp_Packing_Item_Job([FromUri] TempModel TempModel)
        {
            try
            {
                PackingRepository PackingRepository = new PackingRepository();

                List<TempModel> Trp_Packing_Item_Job = PackingRepository.Trp_Packing_Item_Job(TempModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = Trp_Packing_Item_Job;
                _ResponseModel.length = Trp_Packing_Item_Job.Count();
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

        [Route("v1/Trp_Packing_Item_Update")]
        [HttpPut]
        public ResponseModel Trp_Packing_Item_Update(TempModel TempModel)
        {
            try
            {
                PackingRepository PackingRepository = new PackingRepository();

                List<TempModel> Trp_Packing_Item_Update = PackingRepository.Trp_Packing_Item_Update(TempModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = Trp_Packing_Item_Update;
                _ResponseModel.length = Trp_Packing_Item_Update.Count();
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

        [Route("v1/Trp_Packing_Item_Status")]
        [HttpGet]
        public ResponseModel Trp_Packing_Item_Status([FromUri] TempModel TempModel)
        {
            try
            {
                PackingRepository PackingRepository = new PackingRepository();

                List<TempModel> Trp_Packing_Item_Status = PackingRepository.Trp_Packing_Item_Status(TempModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = Trp_Packing_Item_Status;
                _ResponseModel.length = Trp_Packing_Item_Status.Count();
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

        [Route("v1/Trp_Packing_Cover_Sheet")]
        [HttpGet]
        public ResponseModel Trp_Packing_Cover_Sheet([FromUri] TempModel TempModel)
        {
            try
            {
                PackingRepository PackingRepository = new PackingRepository();

                List<TempModel> Trp_Packing_Cover_Sheet = PackingRepository.Trp_Packing_Cover_Sheet(TempModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = Trp_Packing_Cover_Sheet;
                _ResponseModel.length = Trp_Packing_Cover_Sheet.Count();
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

        [Route("v1/Trp_Packing_Check_Box_Create")]
        [HttpGet]
        public ResponseModel Trp_Packing_Check_Box_Create([FromUri] TempModel TempModel)
        {
            try
            {
                PackingRepository PackingRepository = new PackingRepository();

                List<TempModel> Trp_Packing_Check_Box_Create = PackingRepository.Trp_Packing_Check_Box_Create(TempModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = Trp_Packing_Check_Box_Create;
                _ResponseModel.length = Trp_Packing_Check_Box_Create.Count();
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

        [Route("v1/Trp_Packing_Check_Box_List")]
        [HttpGet]
        public ResponseModel Trp_Packing_Check_Box_List([FromUri] TempModel TempModel)
        {
            try
            {
                PackingRepository PackingRepository = new PackingRepository();

                List<TempModel> Trp_Packing_Check_Box_List = PackingRepository.Trp_Packing_Check_Box_List(TempModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = Trp_Packing_Check_Box_List;
                _ResponseModel.length = Trp_Packing_Check_Box_List.Count();
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

        [Route("v1/Trp_Packing_Check_Box_Delete")]
        [HttpDelete]
        public ResponseModel Trp_Packing_Check_Box_Delete(TempModel TempModel)
        {
            try
            {
                PackingRepository PackingRepository = new PackingRepository();

                List<TempModel> Trp_Packing_Check_Box_Delete = PackingRepository.Trp_Packing_Check_Box_Delete(TempModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = Trp_Packing_Check_Box_Delete;
                _ResponseModel.length = Trp_Packing_Check_Box_Delete.Count();
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

        [Route("v1/Trp_Packing_Check_Box_Update")]
        [HttpPut]
        public ResponseModel Trp_Packing_Check_Box_Update(TempModel TempModel)
        {
            try
            {
                PackingRepository PackingRepository = new PackingRepository();

                List<TempModel> Trp_Packing_Check_Box_Update = PackingRepository.Trp_Packing_Check_Box_Update(TempModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = Trp_Packing_Check_Box_Update;
                _ResponseModel.length = Trp_Packing_Check_Box_Update.Count();
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

        [Route("v1/Trp_Packing_Check_Box_Remark")]
        [HttpPost]
        public ResponseModel Trp_Packing_Check_Box_Remark(TempModel TempModel)
        {
            try
            {
                PackingRepository PackingRepository = new PackingRepository();

                List<TempModel> Trp_Packing_Check_Box_Remark = PackingRepository.Trp_Packing_Check_Box_Remark(TempModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = Trp_Packing_Check_Box_Remark;
                _ResponseModel.length = Trp_Packing_Check_Box_Remark.Count();
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

        [Route("v1/Trp_Packing_Check_Box_Search")]
        [HttpGet]
        public ResponseModel Trp_Packing_Check_Box_Search([FromUri] TempModel TempModel)
        {
            try
            {
                PackingRepository PackingRepository = new PackingRepository();

                List<TempModel> Trp_Packing_Check_Box_Search = PackingRepository.Trp_Packing_Check_Box_Search(TempModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = Trp_Packing_Check_Box_Search;
                _ResponseModel.length = Trp_Packing_Check_Box_Search.Count();
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

        [Route("v1/Trp_Packing_List_Mobile")]
        [HttpGet]
        public ResponseModel Trp_Packing_List_Mobile([FromUri] TempModel TempModel)
        {
            try
            {
                PackingRepository PackingRepository = new PackingRepository();

                List<TempModel> Trp_Packing_List_Mobile = PackingRepository.Trp_Packing_List_Mobile(TempModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = Trp_Packing_List_Mobile;
                _ResponseModel.length = Trp_Packing_List_Mobile.Count();
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

        [Route("v1/Trp_Packing_Check_Address")]
        [HttpGet]
        public ResponseModel Trp_Packing_Check_Address([FromUri] TempModel TempModel)
        {
            try
            {
                PackingRepository PackingRepository = new PackingRepository();

                List<TempModel> Trp_Packing_Check_Address = PackingRepository.Trp_Packing_Check_Address(TempModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = Trp_Packing_Check_Address;
                _ResponseModel.length = Trp_Packing_Check_Address.Count();
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

        [Route("v1/Trp_Packing_Check_Box_Tms_List")]
        [HttpGet]
        public ResponseModel Trp_Packing_Check_Box_Tms_List([FromUri] TempModel TempModel)
        {
            try
            {
                PackingRepository PackingRepository = new PackingRepository();

                List<TempModel> Trp_Packing_Check_Box_Tms_List = PackingRepository.Trp_Packing_Check_Box_Tms_List(TempModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = Trp_Packing_Check_Box_Tms_List;
                _ResponseModel.length = Trp_Packing_Check_Box_Tms_List.Count();
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

        [Route("v1/Trp_Packing_Remark_Create")]
        [HttpPost]
        public ResponseModel Trp_Packing_Remark_Create([FromBody] TempModel TempModel)
        {
            try
            {
                PackingRepository PackingRepository = new PackingRepository();

                List<TempModel> Trp_Packing_Remark_Create = PackingRepository.Trp_Packing_Remark_Create(TempModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = Trp_Packing_Remark_Create;
                _ResponseModel.length = Trp_Packing_Remark_Create.Count();
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

        [Route("v1/Trp_Packing_Remark_Delete")]
        [HttpDelete]
        public ResponseModel Trp_Packing_Remark_Delete(TempModel TempModel)
        {
            try
            {
                PackingRepository PackingRepository = new PackingRepository();

                List<TempModel> Trp_Packing_Remark_Delete = PackingRepository.Trp_Packing_Remark_Delete(TempModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = Trp_Packing_Remark_Delete;
                _ResponseModel.length = Trp_Packing_Remark_Delete.Count();
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

        [Route("v1/Trp_Packing_Remark_List")]
        [HttpGet]
        public ResponseModel Trp_Packing_Remark_List([FromUri] TempModel TempModel)
        {
            try
            {
                PackingRepository PackingRepository = new PackingRepository();

                List<TempModel> Trp_Packing_Remark_List = PackingRepository.Trp_Packing_Remark_List(TempModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = Trp_Packing_Remark_List;
                _ResponseModel.length = Trp_Packing_Remark_List.Count();
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

        [Route("v1/Trp_Packing_Job_Tms_Get")]
        [HttpGet]
        public ResponseModel Trp_Packing_Job_Tms_Get([FromUri] TempModel TempModel)
        {
            try
            {
                PackingRepository PackingRepository = new PackingRepository();

                List<TempModel> Trp_Packing_Job_Tms_Get = PackingRepository.Trp_Packing_Job_Tms_Get(TempModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = Trp_Packing_Job_Tms_Get;
                _ResponseModel.length = Trp_Packing_Job_Tms_Get.Count();
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



        //[Route("v1/Trp_Packing_Item_List")]
        //[HttpGet]
        //public ResponseModel Trp_Packing_Item_List([FromUri] TempModel TempModel)
        //{
        //    try
        //    {
        //        PackingRepository PackingRepository = new PackingRepository();

        //        ResponseModel _ResponseModel = new ResponseModel();

        //        if ((TempModel.prepages != TempModel.pages) || TempModel.pages == 0)
        //        {

        //            List<TempModel> Trp_Packing_Item_List = PackingRepository.Trp_Packing_Item_List(TempModel);


        //            _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
        //            _ResponseModel.data = Trp_Packing_Item_List;
        //            _ResponseModel.length = Trp_Packing_Item_List.Count();
        //            _ResponseModel.pages = TempModel.pages;
        //            _ResponseModel.status = "Success";

        //        }
        //        else {

        //            _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
        //            _ResponseModel.data = "";
        //            _ResponseModel.length = 0;
        //            _ResponseModel.pages = TempModel.pages;
        //            _ResponseModel.status = "Success";
        //        }

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

        [Route("v1/Trp_Packing_Item_List")]
        [HttpGet]
        public ResponseModel Trp_Packing_Item_List([FromUri] TempModel TempModel)
        {
            try
            {
                PackingRepository PackingRepository = new PackingRepository();

                List<TempModel> Trp_Packing_Item_List = PackingRepository.Trp_Packing_Item_List(TempModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = Trp_Packing_Item_List;
                _ResponseModel.length = Trp_Packing_Item_List.Count();
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

        [Route("v1/Trp_Packing_Item_Sum")]
        [HttpGet]
        public ResponseModel Trp_Packing_Item_Sum([FromUri] TempModel TempModel)
        {
            try
            {
                PackingRepository PackingRepository = new PackingRepository();

                List<TempModel> Trp_Packing_Item_Sum = PackingRepository.Trp_Packing_Item_Sum(TempModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = Trp_Packing_Item_Sum;
                _ResponseModel.length = Trp_Packing_Item_Sum.Count();
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
