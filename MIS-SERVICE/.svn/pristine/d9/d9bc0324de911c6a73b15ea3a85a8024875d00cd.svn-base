using REPO.Controllers;
using REPO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Globalization;

namespace API.Controllers
{
    public class CustomerMasterController : ApiController
    {

        [Route("api/MasterDataCustomer")]
        [HttpGet]
        public ResponseModel MasterDataCustomer([FromUri] string mode)
        {
            try
            {
                CustomerMasterRepository CustomerMasterRepository = new CustomerMasterRepository();

                List<MasterDataCustomerModel> MasterDataCustomer = CustomerMasterRepository.MasterDataCustomer(mode);

                ResponseModel _ResponseModel = new ResponseModel();
                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = MasterDataCustomer;
                _ResponseModel.length = MasterDataCustomer.Count();
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

        [Route("api/CustomerMaster_List")]
        [HttpGet]
        public ResponseModel CustomerMaster_List([FromUri] CustomerModel CustomerModel)
        {
            try
            {
                CultureInfo cultureinfo = new CultureInfo("en-US");

                CustomerMasterRepository CustomerMasterRepository = new CustomerMasterRepository();

                List<CustomerModel> CustomerMaster_List = CustomerMasterRepository.CustomerMaster_List(CustomerModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = CustomerMaster_List;
                _ResponseModel.length = CustomerMaster_List.Count();
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

        [Route("api/CustomerMaster_Detail")]
        [HttpGet]
        public ResponseModel CustomerMaster_Detail([FromUri] string code)
        {
            try
            {
                CustomerMasterRepository CustomerMasterRepository = new CustomerMasterRepository();
                List<CustomerModel> CustomerMaster_Detail = CustomerMasterRepository.CustomerMaster_Detail(code);
                ResponseModel _ResponseModel = new ResponseModel();
                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = CustomerMaster_Detail;
                _ResponseModel.length = CustomerMaster_Detail.Count();
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

        [Route("api/CustomerMaster_Update")]
        [HttpPut]
        public ResponseModel CustomerMaster_Update([FromBody] CustomerModel CustomerModel)
        {

            try
            {
                //CultureInfo cultureinfo = new CultureInfo("en-US");

                CustomerMasterRepository CustomerMasterRepository = new CustomerMasterRepository();

                List<CustomerModel> CustomerMaster_Update = CustomerMasterRepository.CustomerMaster_Update(CustomerModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = CustomerMaster_Update;
                _ResponseModel.length = CustomerMaster_Update.Count();
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
