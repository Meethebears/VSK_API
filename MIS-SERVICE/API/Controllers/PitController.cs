﻿using REPO.Models;
using REPO.Controllers;
using System.Web.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;

namespace API.Controllers
{
    public class PitController : ApiController
    {

        //private string Path;
        //private string savePath;

        #region Vehicle_Brand_Search
        [Route("api/Vehicle_Brand_Search")]
        [HttpGet]
        public ResponseModel Vehicle_Brand_Search([FromUri] Carmodel_MasterModel Carmodel_MasterModel)
        {
            try
            {
                CultureInfo cultureinfo = new CultureInfo("en-US");

                PitRepository PitRepository = new PitRepository();

                List<Carmodel_MasterModel> Vehicle_Brand_Search = PitRepository.Vehicle_Brand_Search(Carmodel_MasterModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = Vehicle_Brand_Search;
                _ResponseModel.length = Vehicle_Brand_Search.Count();
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

        #region Vehicle_Model_Search
        [Route("api/Vehicle_Model_Search")]
        [HttpGet]
        public ResponseModel Vehicle_Model_Search([FromUri] string id, string text, string keywords)
        {
            try
            {

                CultureInfo cultureinfo = new CultureInfo("en-US");

                PitRepository PitRepository = new PitRepository();

                List<Carmodel_MasterModel> Vehicle_Model_Search = PitRepository.Vehicle_Model_Search(id, text, keywords);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = Vehicle_Model_Search;
                _ResponseModel.length = Vehicle_Model_Search.Count();
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

        #region Vehicle_Minor_Search
        [Route("api/Vehicle_Minor_Search")]
        [HttpGet]
        public ResponseModel Vehicle_Minor_Search([FromUri] string id, string text, string keywords)
        {
            try
            {

                CultureInfo cultureinfo = new CultureInfo("en-US");

                PitRepository PitRepository = new PitRepository();

                List<Carmodel_MasterModel> Vehicle_Minor_Search = PitRepository.Vehicle_Minor_Search(id, text, keywords);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = Vehicle_Minor_Search;
                _ResponseModel.length = Vehicle_Minor_Search.Count();
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

        #region Lov_Data_Search
        [Route("api/Lov_Data_Search")]
        [HttpGet]
        public ResponseModel Lov_Data_Search([FromUri] string id, string text, string type, string keywords)
        {
            try
            {

                CultureInfo cultureinfo = new CultureInfo("en-US");

                PitRepository PitRepository = new PitRepository();

                List<Carmodel_MasterModel> Lov_Data_Search = PitRepository.Lov_Data_Search(id, text, type, keywords);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = Lov_Data_Search;
                _ResponseModel.length = Lov_Data_Search.Count();
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

        #region Gcode_Get
        [Route("api/Gcode_Get")]
        [HttpGet]
        public ResponseModel Gcode_Get([FromUri] string ctype)
        {
            try
            {

                CultureInfo cultureinfo = new CultureInfo("en-US");

                PitRepository PitRepository = new PitRepository();

                List<Item_masterModel> Gcode_Get = PitRepository.Gcode_Get(ctype);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = Gcode_Get;
                _ResponseModel.length = Gcode_Get.Count();
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

        #region CarModelMix_Master_Get
        [Route("api/CarModelMix_Master_Get")]
        [HttpGet]
        public ResponseModel CarModelMix_Master_Get([FromUri] Carmodel_MasterModel Carmodel_MasterModel)
        {

            try
            {
                CultureInfo cultureinfo = new CultureInfo("en-US");

                PitRepository PitRepository = new PitRepository();

                List<Carmodel_MasterModel> CarModelMix_Master_Get = PitRepository.CarModelMix_Master_Get(Carmodel_MasterModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = CarModelMix_Master_Get;
                _ResponseModel.length = CarModelMix_Master_Get.Count();
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

        #region ImportData_CarModelMix_Tmp
        [Route("api/ImportData_CarModelMix_Tmp")]
        [HttpGet]
        public ResponseModel ImportData_CarModelMix_Tmp([FromUri] Carmodel_tmp_Model Carmodel_tmp_Model)
        {

            try
            {
                CultureInfo cultureinfo = new CultureInfo("en-US");

                PitRepository PitRepository = new PitRepository();

                List<Carmodel_tmp_Model> ImportData_CarModelMix_Tmp = PitRepository.ImportData_CarModelMix_Tmp(Carmodel_tmp_Model);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = ImportData_CarModelMix_Tmp;
                _ResponseModel.length = ImportData_CarModelMix_Tmp.Count();
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

        #region  ImportData_CarModelMix_TmpTran
        [Route("api/ImportData_CarModelMix_TmpTran")]
        [HttpPost]
        public ResponseModel ImportData_CarModelMix_TmpTran([FromBody] IEnumerable<Carmodel_tmptran_Model> Carmodel_tmptran_Model)
        {
            try
            {
                ResponseModel _ResponseModel = new ResponseModel();
               // ResponseModel _ResponseModelList = new ResponseModel();


                PitRepository PitRepository = new PitRepository();

                List<Carmodel_tmptran_Model> ImportDataArrayData = new List<Carmodel_tmptran_Model>();

                int i = 1;

                foreach (var ImportUpdateDataItem in Carmodel_tmptran_Model)
                {
                    Carmodel_tmptran_Model ImportDataArrayModel_data = new Carmodel_tmptran_Model();
                    ImportDataArrayModel_data.temp_id = ImportUpdateDataItem.temp_id;
                    ImportDataArrayModel_data.model_id = ImportUpdateDataItem.model_id;
                    ImportDataArrayModel_data.modelmixed = ImportUpdateDataItem.modelmixed;
                    ImportDataArrayModel_data.vehicle_brand = ImportUpdateDataItem.vehicle_brand;
                    ImportDataArrayModel_data.vehicle_model = ImportUpdateDataItem.vehicle_model;
                    ImportDataArrayModel_data.cartype = ImportUpdateDataItem.cartype;
                    ImportDataArrayModel_data.model_change = ImportUpdateDataItem.model_change;
                    ImportDataArrayModel_data.minor_change = ImportUpdateDataItem.minor_change;
                    ImportDataArrayModel_data.fuel_type = ImportUpdateDataItem.fuel_type;
                    ImportDataArrayModel_data.engine_displacement = ImportUpdateDataItem.engine_displacement;
                    ImportDataArrayModel_data.engine_code = ImportUpdateDataItem.engine_code;
                    ImportDataArrayModel_data.transmission_type = ImportUpdateDataItem.transmission_type;
                    ImportDataArrayModel_data.body_type = ImportUpdateDataItem.body_type;
                    ImportDataArrayModel_data.hign_stant = ImportUpdateDataItem.hign_stant;
                    ImportDataArrayModel_data.wheel_drive = ImportUpdateDataItem.wheel_drive;
                    ImportDataArrayModel_data.street_name = ImportUpdateDataItem.street_name;
                    ImportDataArrayModel_data.model_code = ImportUpdateDataItem.model_code;
                    ImportDataArrayModel_data.remarks = ImportUpdateDataItem.remarks;
                    ImportDataArrayModel_data.action = ImportUpdateDataItem.action;
                    ImportDataArrayModel_data.created_by = ImportUpdateDataItem.created_by;
                   // ImportDataArrayModel_data.car_models = ImportUpdateDataItem.car_models;
                    ImportDataArrayData.Add(ImportDataArrayModel_data);

                    i++;
                }

                //List<Carmodel_tmptran_Model> ImportData_CarModelMix_Tmp = PitRepository.ImportData_CarModelMix_TmpTran(ImportDataArrayData);
                
                PitRepository.ImportData_CarModelMix_TmpTran(ImportDataArrayData);

               

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                //_ResponseModel.data = ImportData_CarModelMix_Tmp;
                //_ResponseModel.length = ImportData_CarModelMix_Tmp.Count();
                _ResponseModel.status = "Success";

                return _ResponseModel;
            }
            catch (Exception ex)
            {
                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.status = "Error";
                _ResponseModel.status = ex.ToString();

                return _ResponseModel;
            }
        }
        #endregion

        #region ImportData_CarModelMix_Verify
        [Route("api/ImportData_CarModelMix_Verify")]
        [HttpGet]
        public ResponseModel ImportData_CarModelMix_Verify([FromUri] Carmodel_tmptran_Model Carmodel_tmptran_Model)
        {

            try
            {
                CultureInfo cultureinfo = new CultureInfo("en-US");

                PitRepository PitRepository = new PitRepository();

                List<Carmodel_tmptran_Model> ImportData_CarModelMix_Verify = PitRepository.ImportData_CarModelMix_Verify(Carmodel_tmptran_Model);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = ImportData_CarModelMix_Verify;
                _ResponseModel.length = ImportData_CarModelMix_Verify.Count();
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

        #region ImportData_CarModelMix_Upload
        [Route("api/ImportData_CarModelMix_Upload")]
        [HttpGet]
        public ResponseModel ImportData_CarModelMix_Upload([FromUri] Carmodel_tmptran_Model Carmodel_tmptran_Model)
        {

            try
            {
                CultureInfo cultureinfo = new CultureInfo("en-US");

                PitRepository PitRepository = new PitRepository();

                List<Carmodel_tmptran_Model> ImportData_CarModelMix_Upload = PitRepository.ImportData_CarModelMix_Upload(Carmodel_tmptran_Model);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = ImportData_CarModelMix_Upload;
                _ResponseModel.length = ImportData_CarModelMix_Upload.Count();
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

        #region ImportData_CarModelMix_Get
        [Route("api/ImportData_CarModelMix_Get")]
        [HttpGet]
        public ResponseModel ImportData_CarModelMix_Get([FromUri] Carmodel_tmptran_Model Carmodel_tmptran_Model)
        {

            try
            {
                CultureInfo cultureinfo = new CultureInfo("en-US");

                PitRepository PitRepository = new PitRepository();

                List<Carmodel_tmptran_Model> ImportData_CarModelMix_Get = PitRepository.ImportData_CarModelMix_Get(Carmodel_tmptran_Model);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = ImportData_CarModelMix_Get;
                _ResponseModel.length = ImportData_CarModelMix_Get.Count();
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

        #region ImportData_CarModelMix_Action
        [Route("api/ImportData_CarModelMix_Action")]
        [HttpGet]
        public ResponseModel ImportData_CarModelMix_Action([FromUri] Carmodel_tmptran_Model Carmodel_tmptran_Model)
        {

            try
            {
                CultureInfo cultureinfo = new CultureInfo("en-US");

                PitRepository PitRepository = new PitRepository();

                List<Carmodel_tmptran_Model> ImportData_CarModelMix_Action = PitRepository.ImportData_CarModelMix_Action(Carmodel_tmptran_Model);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = ImportData_CarModelMix_Action;
                _ResponseModel.length = ImportData_CarModelMix_Action.Count();
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

        #region CarModelMix_Master_Checked
        [Route("api/CarModelMix_Master_Checked")]
        [HttpGet]
        public ResponseModel CarModelMix_Master_Checked([FromUri] Carmodel_Check_Model Carmodel_Check_Model)
        {

            try
            {
                CultureInfo cultureinfo = new CultureInfo("en-US");

                PitRepository PitRepository = new PitRepository();

                List<Carmodel_Check_Model> CarModelMix_Master_Checked = PitRepository.CarModelMix_Master_Checked(Carmodel_Check_Model);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = CarModelMix_Master_Checked;
                _ResponseModel.length = CarModelMix_Master_Checked.Count();
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

        #region CarModelMix_Master_Upload_Photo_V1
        [Route("api/CarModelMix_Master_Upload_Photo_V1")]
        [HttpPost]
        public ResponseModel CarModelMix_Master_Upload_Photo_V1([FromBody] Carmodel_Photo_Model Carmodel_Photo_Model)
        {

            try
            {
                CultureInfo cultureinfo = new CultureInfo("en-US");

                PitRepository PitRepository = new PitRepository();

                List<Carmodel_Photo_Model> CarModelMix_Master_Upload_Photo = PitRepository.CarModelMix_Master_Upload_Photo_V1(Carmodel_Photo_Model);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = CarModelMix_Master_Upload_Photo;
                _ResponseModel.length = CarModelMix_Master_Upload_Photo.Count();
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

        #region CarModelMix_Master_Photo_Delete
        [Route("api/CarModelMix_Master_Photo_Delete")]
        [HttpDelete]
        public ResponseModel CarModelMix_Master_Photo_Delete([FromBody] Carmodel_Photo_Model Carmodel_Photo_Model)
        {

            try
            {
                CultureInfo cultureinfo = new CultureInfo("en-US");

                PitRepository PitRepository = new PitRepository();

                List<Carmodel_Photo_Model> CarModelMix_Master_Photo_Delete = PitRepository.CarModelMix_Master_Photo_Delete(Carmodel_Photo_Model);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = CarModelMix_Master_Photo_Delete;
                _ResponseModel.length = CarModelMix_Master_Photo_Delete.Count();
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

        #region CarModelMix_Master_Photo_Delete_Modelmix
        [Route("api/CarModelMix_Master_Photo_Delete_Modelmix")]
        [HttpDelete]
        public ResponseModel CarModelMix_Master_Photo_Delete_Modelmix([FromBody] Carmodel_Photo_Model Carmodel_Photo_Model)
        {

            try
            {
                CultureInfo cultureinfo = new CultureInfo("en-US");

                PitRepository PitRepository = new PitRepository();

                List<Carmodel_Photo_Model> CarModelMix_Master_Photo_Delete = PitRepository.CarModelMix_Master_Photo_Delete_Modelmix(Carmodel_Photo_Model);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = CarModelMix_Master_Photo_Delete;
                _ResponseModel.length = CarModelMix_Master_Photo_Delete.Count();
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

        #region CarModelMix_Master_Photo_Delete_Sub
        [Route("api/CarModelMix_Master_Photo_Delete_Sub")]
        [HttpDelete]
        public ResponseModel CarModelMix_Master_Photo_Delete_Sub([FromBody] Carmodel_Photo_Model Carmodel_Photo_Model)
        {

            try
            {
                CultureInfo cultureinfo = new CultureInfo("en-US");

                PitRepository PitRepository = new PitRepository();

                List<Carmodel_Photo_Model> CarModelMix_Master_Photo_Delete_Sub = PitRepository.CarModelMix_Master_Photo_Delete_Sub(Carmodel_Photo_Model);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = CarModelMix_Master_Photo_Delete_Sub;
                _ResponseModel.length = CarModelMix_Master_Photo_Delete_Sub.Count();
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

        #region  CarModelMix_Master_Upload_Photo
        [Route("api/CarModelMix_Master_Upload_Photo")]
        [HttpPost]
        public ResponseModel CarModelMix_Master_Upload_Photo([FromBody] IEnumerable<Carmodel_Photo_Model> Carmodel_Photo_Model)
        {
            try
            {
                ResponseModel _ResponseModel = new ResponseModel();
                // ResponseModel _ResponseModelList = new ResponseModel();


                PitRepository PitRepository = new PitRepository();

                List<Carmodel_Photo_Model> ImportDataArrayData = new List<Carmodel_Photo_Model>();

                int i = 1;

                foreach (var ImportUpdateDataItem in Carmodel_Photo_Model)
                {
                    Carmodel_Photo_Model ImportDataArrayModel_data = new Carmodel_Photo_Model();
                    ImportDataArrayModel_data.model_id = ImportUpdateDataItem.model_id;
                    ImportDataArrayModel_data.temp_id = ImportUpdateDataItem.temp_id;
                    ImportDataArrayModel_data.modelmix = ImportUpdateDataItem.modelmix;
                    ImportDataArrayModel_data.photo_name = ImportUpdateDataItem.photo_name;
                    ImportDataArrayModel_data.photo_folder = ImportUpdateDataItem.photo_folder;
                    ImportDataArrayModel_data.photo_url = ImportUpdateDataItem.photo_url;
                    ImportDataArrayModel_data.photo_type = ImportUpdateDataItem.photo_type;
                    ImportDataArrayModel_data.photo_no = ImportUpdateDataItem.photo_no;
                    ImportDataArrayModel_data.vehicle_model = ImportUpdateDataItem.vehicle_model;
                    ImportDataArrayModel_data.minor_change = ImportUpdateDataItem.minor_change;
                    ImportDataArrayModel_data.body_type = ImportUpdateDataItem.body_type;
                    ImportDataArrayModel_data.hign_stant = ImportUpdateDataItem.hign_stant;
                    ImportDataArrayModel_data.street_name = ImportUpdateDataItem.street_name;
                    ImportDataArrayModel_data.created_by = ImportUpdateDataItem.created_by;
                    ImportDataArrayModel_data.pMessage = ImportUpdateDataItem.pMessage;
                    ImportDataArrayData.Add(ImportDataArrayModel_data);

                    i++;
                }

                //List<Carmodel_tmptran_Model> ImportData_CarModelMix_Tmp = PitRepository.ImportData_CarModelMix_TmpTran(ImportDataArrayData);

                PitRepository.CarModelMix_Master_Upload_Photo(ImportDataArrayData);



                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                //_ResponseModel.data = ImportData_CarModelMix_Tmp;
                //_ResponseModel.length = ImportData_CarModelMix_Tmp.Count();
                _ResponseModel.status = "Success";

                return _ResponseModel;
            }
            catch (Exception ex)
            {
                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.status = "Error";
                _ResponseModel.status = ex.ToString();

                return _ResponseModel;
            }
        }
        #endregion

        #region ImportData_CarModelMix_Item_Get
        [Route("api/ImportData_CarModelMix_Item_Get")]
        [HttpGet]
        public ResponseModel ImportData_CarModelMix_Item_Get([FromUri] Carmodel_MasterModel Carmodel_MasterModel)
        {

            try
            {
                CultureInfo cultureinfo = new CultureInfo("en-US");

                PitRepository PitRepository = new PitRepository();

                List<Carmodel_MasterModel> ImportData_CarModelMix_Item_Get = PitRepository.ImportData_CarModelMix_Item_Get(Carmodel_MasterModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = ImportData_CarModelMix_Item_Get;
                _ResponseModel.length = ImportData_CarModelMix_Item_Get.Count();
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
