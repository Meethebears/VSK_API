using REPO.Models;
using REPO.Controllers;
using System.Web.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;

namespace API.Controllers
{
    public class KLH_BrController : ApiController
    {

        #region Br_Brtra_Job
        [Route("api/KLH_Br_Brtra_Job")]
        [HttpGet]
        public ResponseModel Br_Brtra_Job([FromUri] BrModel BrModel)
        {

            try
            {
                CultureInfo cultureinfo = new CultureInfo("en-US");

                KLH_BrRepository KLH_BrRepository = new KLH_BrRepository();

                List<BrModel> Br_Brtra_Job = KLH_BrRepository.Br_Brtra_Job(BrModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = Br_Brtra_Job;
                _ResponseModel.length = Br_Brtra_Job.Count();
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

        #region Br_Brtra_Get
        [Route("api/KLH_Br_Brtra_Get")]
        [HttpGet]
        public ResponseModel Br_Brtra_Get([FromUri] BrModel BrModel)
        {

            try
            {
                CultureInfo cultureinfo = new CultureInfo("en-US");

                KLH_BrRepository KLH_BrRepository = new KLH_BrRepository();

                List<BrModel> Br_Brtra_Get = KLH_BrRepository.Br_Brtra_Get(BrModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = Br_Brtra_Get;
                _ResponseModel.length = Br_Brtra_Get.Count();
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

        #region Br_Brtra_Update
        [Route("api/KLH_Br_Brtra_Update")]
        [HttpPut]
        public ResponseModel Br_Brtra_Update([FromBody] BrModel BrModel)
        {

            try
            {
                CultureInfo cultureinfo = new CultureInfo("en-US");

                KLH_BrRepository KLH_BrRepository = new KLH_BrRepository();

                List<BrModel> Br_Brtra_Update = KLH_BrRepository.Br_Brtra_Update(BrModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = Br_Brtra_Update;
                _ResponseModel.length = Br_Brtra_Update.Count();
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

        #region Br_Brtra_History
        [Route("api/KLH_Br_Brtra_History")]
        [HttpGet]
        public ResponseModel Br_Brtra_History([FromUri] BrModel BrModel)
        {

            try
            {
                CultureInfo cultureinfo = new CultureInfo("en-US");

                KLH_BrRepository KLH_BrRepository = new KLH_BrRepository();

                List<BrModel> Br_Brtra_History = KLH_BrRepository.Br_Brtra_History(BrModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = Br_Brtra_History;
                _ResponseModel.length = Br_Brtra_History.Count();
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

        #region Br_Brtra_Lov
        [Route("api/KLH_Br_Brtra_Lov")]
        [HttpGet]
        public ResponseModel Br_Brtra_Lov([FromUri] LovModel LovModel)
        {

            try
            {
                CultureInfo cultureinfo = new CultureInfo("en-US");

                KLH_BrRepository KLH_BrRepository = new KLH_BrRepository();

                List<LovModel> Br_Brtra_Lov = KLH_BrRepository.Br_Brtra_Lov(LovModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = Br_Brtra_Lov;
                _ResponseModel.length = Br_Brtra_Lov.Count();
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

        #region Br_Lov_Route_Get
        [Route("api/KLH_Br_Lov_Route_Get")]
        [HttpGet]
        public ResponseModel Br_Lov_Route_Get([FromUri] LovModel LovModel)
        {

            try
            {
                CultureInfo cultureinfo = new CultureInfo("en-US");

                KLH_BrRepository KLH_BrRepository = new KLH_BrRepository();

                List<LovModel> Br_Lov_Route_Get = KLH_BrRepository.Br_Lov_Route_Get(LovModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = Br_Lov_Route_Get;
                _ResponseModel.length = Br_Lov_Route_Get.Count();
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
