using REPO.Models;
using REPO.Controllers;
using System.Web.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;

namespace API.Controllers
{

    public class RtController : ApiController
    {

        #region Return_Get
        [Route("api/Return_Get")]
        [HttpGet]
        public ResponseModel Return_Get([FromUri] ReturnModel ReturnModel)
        {

            try
            {
                CultureInfo cultureinfo = new CultureInfo("en-US");

                RtRepository RtRepository = new RtRepository();

                List<ReturnModel> Return_Get = RtRepository.Return_Get(ReturnModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = Return_Get;
                _ResponseModel.length = Return_Get.Count();
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

        #region Return_Create
        [Route("api/Return_Create")]
        [HttpGet]
        public ResponseModel Return_Create([FromUri] ReturnModel ReturnModel)
        {

            try
            {
                CultureInfo cultureinfo = new CultureInfo("en-US");

                RtRepository RtRepository = new RtRepository();

                List<ReturnModel> Return_Create = RtRepository.Return_Create(ReturnModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = Return_Create;
                _ResponseModel.length = Return_Create.Count();
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

        #region  Rt_Create_Tran
        [Route("api/Rt_Create_Tran")]
        [HttpPost]
        public ResponseModel Rt_Create_Tran(List<ReturnModel> ReturnModel)
        {

            try
            {
                RtRepository RtRepository = new RtRepository();

                List<ReturnModel> Rt_Create_Tran_List = new List<ReturnModel>();

                //int i = 1;

                foreach (var ReturnData in ReturnModel)
                {
                    ReturnModel ImportDataArrayModel_data = new ReturnModel();
                    ImportDataArrayModel_data.mode = ReturnData.mode;
                    ImportDataArrayModel_data.temp_id = ReturnData.temp_id;
                    ImportDataArrayModel_data.ref_id = ReturnData.ref_id;
                    ImportDataArrayModel_data.return_no = ReturnData.return_no;
                    ImportDataArrayModel_data.rttra_item_code = ReturnData.rttra_item_code;
                    ImportDataArrayModel_data.rttra_item_name = ReturnData.rttra_item_name;
                    ImportDataArrayModel_data.rttra_uom = ReturnData.rttra_uom;
                    ImportDataArrayModel_data.rttra_qty = ReturnData.rttra_qty;
                    ImportDataArrayModel_data.rttra_price = ReturnData.rttra_price;
                    ImportDataArrayModel_data.rttra_location = ReturnData.rttra_location;
                    ImportDataArrayModel_data.rttra_zone = ReturnData.rttra_zone;
                    ImportDataArrayModel_data.rttra_branch = ReturnData.rttra_branch;
                    ImportDataArrayModel_data.created_by = ReturnData.created_by;

                    Rt_Create_Tran_List.Add(ImportDataArrayModel_data);

                    //i++;
                }

                List<ReturnModel> Rt_Create_Tran_list = RtRepository.Rt_Create_Tran(Rt_Create_Tran_List);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = Rt_Create_Tran_list;
                _ResponseModel.length = Rt_Create_Tran_list.Count();
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

        #region Return_Update
        [Route("api/Return_Update")]
        [HttpGet]
        public ResponseModel Return_Update([FromUri] ReturnModel ReturnModel)
        {

            try
            {
                CultureInfo cultureinfo = new CultureInfo("en-US");

                RtRepository RtRepository = new RtRepository();

                List<ReturnModel> Return_Update = RtRepository.Return_Update(ReturnModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = Return_Update;
                _ResponseModel.length = Return_Update.Count();
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
