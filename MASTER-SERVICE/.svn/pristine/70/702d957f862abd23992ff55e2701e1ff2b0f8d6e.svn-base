using REPO.Models;
using REPO.Controllers;
using System.Web.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;

namespace API.Controllers
{
    public class PurController : ApiController
    {
        // GET: api/PurPod_Get
        [Route("api/PR_POD_IV_GR_bySale")]
        [HttpGet]
        public ResponseModel PR_POD_IV_GR_bySale([FromUri] PkPoIVModel PkPoIVModel)
        {

            try
            {
                CultureInfo cultureinfo = new CultureInfo("en-US");

                PurRepository PurRepository = new PurRepository();

                List<PkPoIVModel> PR_POD_IV_GR_bySale = PurRepository.PR_POD_IV_GR_bySale(PkPoIVModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = PR_POD_IV_GR_bySale;
                _ResponseModel.length = PR_POD_IV_GR_bySale.Count();
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

        // GET: api/PurPoe_Get
        [Route("api/PR_POE_IV_GR_bySale")]
        [HttpGet]
        public ResponseModel PR_POE_IV_GR_bySale([FromUri] PkPoIVModel PkPoIVModel)
        {

            try
            {
                CultureInfo cultureinfo = new CultureInfo("en-US");

                PurRepository PurRepository = new PurRepository();

                List<PkPoIVModel> PR_POE_IV_GR_bySale = PurRepository.PR_POE_IV_GR_bySale(PkPoIVModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = PR_POE_IV_GR_bySale;
                _ResponseModel.length = PR_POE_IV_GR_bySale.Count();
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

        [Route("api/PK_PO_IV_bySale_Update")]
        [HttpPut]
        public ResponseModel PK_PO_IV_bySale_Update([FromBody] PkPoIVModel PkPoIVModel)
        {

            try
            {
               //  CultureInfo cultureinfo = new CultureInfo("en-US");

                PurRepository PurRepository = new PurRepository();

                PurRepository.PK_PO_IV_bySale_Update(PkPoIVModel);

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

        // GET: api/PurPod_Get
        [Route("api/Custome_PR_Get")]
        [HttpGet]
        public ResponseModel Custome_PR_Get([FromUri] string  pono_e, [FromUri] string stkcod)
        {

            try
            {
                CultureInfo cultureinfo = new CultureInfo("en-US");

                PurRepository PurRepository = new PurRepository();

                List<CustomePRModel> Custome_PR_Get = PurRepository.Custome_PR_Get(pono_e, stkcod);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = Custome_PR_Get;
                _ResponseModel.length = Custome_PR_Get.Count();
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

        // GET: api/PurPoe_Get
        [Route("api/PR_POE_IV_GR_bySale_Close")]
        [HttpGet]
        public ResponseModel PR_POE_IV_GR_bySale_Close([FromUri] PkPoIVModel PkPoIVModel)
        {

            try
            {
                CultureInfo cultureinfo = new CultureInfo("en-US");

                PurRepository PurRepository = new PurRepository();

                List<PkPoIVModel> PR_POE_IV_GR_bySale_Close  = PurRepository.PR_POE_IV_GR_bySale_Close(PkPoIVModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = PR_POE_IV_GR_bySale_Close;
                _ResponseModel.length = PR_POE_IV_GR_bySale_Close.Count();
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
