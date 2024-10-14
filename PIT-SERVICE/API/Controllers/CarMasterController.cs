using REPO.Models;
using REPO.Controllers;
using System.Web.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;

namespace API.Controllers
{
    public class CarMasterController : ApiController
    {

        #region CarMasterData_Get
        [Route("api/CarMasterData_Get")]
        [HttpGet]
        public ResponseModel CarMasterData_Get([FromUri] CarMasterPmtModel CarMasterPmtModel)
        {

            try
            {
                CultureInfo cultureinfo = new CultureInfo("en-US");

                CarMasterRepository CarMasterRepository = new CarMasterRepository();

                List<ResponseSelect2Model> CarMasterData_Get = CarMasterRepository.CarMasterData_Get(CarMasterPmtModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = CarMasterData_Get;
                _ResponseModel.length = CarMasterData_Get.Count();
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

        #region CarMasterData_List
        [Route("api/CarMasterData_List")]
        [HttpGet]
        public ResponseModel CarMasterData_List([FromUri] CarMasterPmtModel CarMasterPmtModel)
        {

            try
            {
                CultureInfo cultureinfo = new CultureInfo("en-US");

                CarMasterRepository CarMasterRepository = new CarMasterRepository();

                List<LovDataModel> CarMasterData_List = CarMasterRepository.CarMasterData_List(CarMasterPmtModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = CarMasterData_List;
                _ResponseModel.length = CarMasterData_List.Count();
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


        #region CarModelMix_CarShapeData_List
        [Route("api/CarModelMix_CarShapeData_List")]
        [HttpGet]
        public ResponseModel CarModelMix_CarShapeData_List([FromUri] Carmodel_MasterModel Carmodel_MasterModel)
        {

            try
            {
                CultureInfo cultureinfo = new CultureInfo("en-US");

                CarMasterRepository CarMasterRepository = new CarMasterRepository();

                List<Carmodel_MasterModel> CarModelMix_CarShapeData_List = CarMasterRepository.CarModelMix_CarShapeData_List(Carmodel_MasterModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = CarModelMix_CarShapeData_List;
                _ResponseModel.length = CarModelMix_CarShapeData_List.Count();
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

        #region CarModelMix_CarShapeData_Create
        [Route("api/CarModelMix_CarShapeData_Create")]
        [HttpPost]
        public ResponseModel CarModelMix_CarShapeData_Create([FromBody] Carmodel_MasterModel Carmodel_MasterModel)
        {

            try
            {
                CultureInfo cultureinfo = new CultureInfo("en-US");

                CarMasterRepository CarMasterRepository = new CarMasterRepository();

                List<Carmodel_MasterModel> CarModelMix_CarShapeData_Create = CarMasterRepository.CarModelMix_CarShapeData_Create(Carmodel_MasterModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = CarModelMix_CarShapeData_Create;
                _ResponseModel.length = CarModelMix_CarShapeData_Create.Count();
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

        #region CarModelMix_CarShapeData_Update
        [Route("api/CarModelMix_CarShapeData_Update")]
        [HttpPut]
        public ResponseModel CarModelMix_CarShapeData_Update([FromBody] Carmodel_MasterModel Carmodel_MasterModel)
        {

            try
            {
                CultureInfo cultureinfo = new CultureInfo("en-US");

                CarMasterRepository CarMasterRepository = new CarMasterRepository();

                List<Carmodel_MasterModel> CarModelMix_CarShapeData_Update = CarMasterRepository.CarModelMix_CarShapeData_Update(Carmodel_MasterModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = CarModelMix_CarShapeData_Update;
                _ResponseModel.length = CarModelMix_CarShapeData_Update.Count();
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

        #region CarModelMix_CarShapeData_Delete
        [Route("api/CarModelMix_CarShapeData_Delete")]
        [HttpDelete]
        public ResponseModel CarModelMix_CarShapeData_Delete([FromBody] Carmodel_MasterModel Carmodel_MasterModel)
        {

            try
            {
                CultureInfo cultureinfo = new CultureInfo("en-US");

                CarMasterRepository CarMasterRepository = new CarMasterRepository();

                List<Carmodel_MasterModel> CarModelMix_CarShapeData_Delete = CarMasterRepository.CarModelMix_CarShapeData_Delete(Carmodel_MasterModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = CarModelMix_CarShapeData_Delete;
                _ResponseModel.length = CarModelMix_CarShapeData_Delete.Count();
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

        #region CarModelMix_CarShapePicture_List
        [Route("api/CarModelMix_CarShapePicture_List")]
        [HttpGet]
        public ResponseModel CarModelMix_CarShapePicture_List([FromUri] Carmodel_MasterModel Carmodel_MasterModel)
        {

            try
            {
                CultureInfo cultureinfo = new CultureInfo("en-US");

                CarMasterRepository CarMasterRepository = new CarMasterRepository();

                List<Carmodel_MasterModel> CarModelMix_CarShapePicture_List = CarMasterRepository.CarModelMix_CarShapePicture_List(Carmodel_MasterModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = CarModelMix_CarShapePicture_List;
                _ResponseModel.length = CarModelMix_CarShapePicture_List.Count();
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

        #region CarModelMix_CarPicture_Code
        [Route("api/CarModelMix_CarPicture_Code")]
        [HttpGet]
        public ResponseModel CarModelMix_CarPicture_Code([FromUri] Carmodel_MasterModel Carmodel_MasterModel)
        {

            try
            {
                CultureInfo cultureinfo = new CultureInfo("en-US");

                CarMasterRepository CarMasterRepository = new CarMasterRepository();

                List<Carmodel_MasterModel> CarModelMix_CarPicture_Code = CarMasterRepository.CarModelMix_CarPicture_Code(Carmodel_MasterModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = CarModelMix_CarPicture_Code;
                _ResponseModel.length = CarModelMix_CarPicture_Code.Count();
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

        #region CarModel_CarPicture_Create
        [Route("api/CarModel_CarPicture_Create")]
        [HttpPost]
        public ResponseModel CarModel_CarPicture_Create([FromBody] Carmodel_MasterModel Carmodel_MasterModel)
        {

            try
            {
                CultureInfo cultureinfo = new CultureInfo("en-US");

                CarMasterRepository CarMasterRepository = new CarMasterRepository();

                List<Carmodel_MasterModel> CarModel_CarPicture_Create = CarMasterRepository.CarModel_CarPicture_Create(Carmodel_MasterModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = CarModel_CarPicture_Create;
                _ResponseModel.length = CarModel_CarPicture_Create.Count();
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

        #region CarModel_CarPicture_SetOrder
        [Route("api/CarModel_CarPicture_SetOrder")]
        [HttpPut]
        public ResponseModel CarModel_CarPicture_SetOrder([FromBody] Carmodel_MasterModel Carmodel_MasterModel)
        {

            try
            {
                CultureInfo cultureinfo = new CultureInfo("en-US");

                CarMasterRepository CarMasterRepository = new CarMasterRepository();

                List<Carmodel_MasterModel> CarModel_CarPicture_SetOrder = CarMasterRepository.CarModel_CarPicture_SetOrder(Carmodel_MasterModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = CarModel_CarPicture_SetOrder;
                _ResponseModel.length = CarModel_CarPicture_SetOrder.Count();
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

        #region CarModel_CarPicture_Delete
        [Route("api/CarModel_CarPicture_Delete")]
        [HttpDelete]
        public ResponseModel CarModel_CarPicture_Delete([FromBody] Carmodel_MasterModel Carmodel_MasterModel)
        {

            try
            {
                CultureInfo cultureinfo = new CultureInfo("en-US");

                CarMasterRepository CarMasterRepository = new CarMasterRepository();

                List<Carmodel_MasterModel> CarModel_CarPicture_Delete = CarMasterRepository.CarModel_CarPicture_Delete(Carmodel_MasterModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = CarModel_CarPicture_Delete;
                _ResponseModel.length = CarModel_CarPicture_Delete.Count();
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
