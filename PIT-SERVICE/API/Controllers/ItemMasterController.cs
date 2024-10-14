using REPO.Models;
using REPO.Controllers;
using System.Web.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;

namespace API.Controllers
{
    public class ItemMasterController : ApiController
    {

        #region STMAS_GET
        [Route("api/STMAS_GET")]
        [HttpGet]
        public ResponseModel STMAS_GET([FromUri] string keywords)
        {
            try
            {

                CultureInfo cultureinfo = new CultureInfo("en-US");

                ItemMasterRepository ItemMasterRepository = new ItemMasterRepository();

                List<StmasModel> STMAS_GET = ItemMasterRepository.STMAS_GET(keywords);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = STMAS_GET;
                _ResponseModel.length = STMAS_GET.Count();
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

        #region GLB_VEHICLE_CODE5_GET
        [Route("api/GLB_VEHICLE_CODE5_GET")]
        [HttpGet]
        public ResponseModel GLB_VEHICLE_CODE5_GET([FromUri] string keywords)
        {
            try
            {

                CultureInfo cultureinfo = new CultureInfo("en-US");

                ItemMasterRepository ItemMasterRepository = new ItemMasterRepository();

                List<GLB_Vehicle_Code5Model> GLB_VEHICLE_CODE5_GET = ItemMasterRepository.GLB_VEHICLE_CODE5_GET(keywords);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = GLB_VEHICLE_CODE5_GET;
                _ResponseModel.length = GLB_VEHICLE_CODE5_GET.Count();
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

        #region GCODE_KEYWORDS_GET
        [Route("api/GCODE_KEYWORDS_GET")]
        [HttpGet]
        public ResponseModel GCODE_GET([FromUri] string ctype, string keywords)
        {
            try
            {

                CultureInfo cultureinfo = new CultureInfo("en-US");

                ItemMasterRepository ItemMasterRepository = new ItemMasterRepository();

                List<Item_masterModel> GCODE_KEYWORDS_GET = ItemMasterRepository.GCODE_KEYWORDS_GET(ctype,keywords);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = GCODE_KEYWORDS_GET;
                _ResponseModel.length = GCODE_KEYWORDS_GET.Count();
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

        #region ITEMMASTER_SREARCH
        [Route("api/ITEMMASTER_SREARCH")]
        [HttpGet]
        public ResponseModel ITEMMASTER_SREARCH([FromUri] string id, string text, string keywords)
        {
            try
            {

                CultureInfo cultureinfo = new CultureInfo("en-US");

                ItemMasterRepository ItemMasterRepository = new ItemMasterRepository();

                List<Item_masterModel> ITEMMASTER_SREARCH = ItemMasterRepository.ITEMMASTER_SREARCH(id, text, keywords);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = ITEMMASTER_SREARCH;
                _ResponseModel.length = ITEMMASTER_SREARCH.Count();
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

        #region STMAS_EXP_LIST
        [Route("api/STMAS_EXP_LIST")]
        [HttpGet]
        public ResponseModel STMAS_EXP_LIST([FromUri] StmasModel StmasModel)
        {

            try
            {
                CultureInfo cultureinfo = new CultureInfo("en-US");

                ItemMasterRepository ItemMasterRepository = new ItemMasterRepository();

                List<StmasModel> STMAS_EXP_LIST = ItemMasterRepository.STMAS_EXP_LIST(StmasModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = STMAS_EXP_LIST;
                _ResponseModel.length = STMAS_EXP_LIST.Count();
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

        #region  STMAS_EXP_IMPORT_CREATE
        [Route("api/STMAS_EXP_IMPORT_CREATE")]
        [HttpPost]
        public ResponseModel STMAS_EXP_IMPORT_CREATE([FromBody] IEnumerable<Temp_Stmas_ExpModel> Temp_Stmas_ExpModel)
        {
            try
            {
                ResponseModel _ResponseModel = new ResponseModel();

                ItemMasterRepository ItemMasterRepository = new ItemMasterRepository();

                List<Temp_Stmas_ExpModel> ImportDataArrayData = new List<Temp_Stmas_ExpModel>();

                int i = 1;

                foreach (var ImportUpdateDataItem in Temp_Stmas_ExpModel)
                {
                    Temp_Stmas_ExpModel ImportDataArrayModel_data = new Temp_Stmas_ExpModel();

                    ImportDataArrayModel_data.ref_id = ImportUpdateDataItem.ref_id;
                    ImportDataArrayModel_data.code_sm = ImportUpdateDataItem.code_sm;
                    //ImportDataArrayModel_data.name_sm = ImportUpdateDataItem.name_sm;
                    ImportDataArrayModel_data.code_sm_e = ImportUpdateDataItem.code_sm_e;
                    //ImportDataArrayModel_data.name_sm_e = ImportUpdateDataItem.name_sm_e;
                    ImportDataArrayModel_data.code_a = ImportUpdateDataItem.code_a;
                    ImportDataArrayModel_data.code_e = ImportUpdateDataItem.code_e;
                    ImportDataArrayModel_data.code_c = ImportUpdateDataItem.code_c;
                    ImportDataArrayModel_data.code_b = ImportUpdateDataItem.code_b;
                    ImportDataArrayModel_data.code_d = ImportUpdateDataItem.code_d;
                    ImportDataArrayModel_data.name_sm_compare = ImportUpdateDataItem.name_sm_compare;
                    ImportDataArrayModel_data.name_sm_e_compare = ImportUpdateDataItem.name_sm_e_compare;
                    //ImportDataArrayModel_data.carbrand = ImportUpdateDataItem.carbrand;
                    //ImportDataArrayModel_data.carmodel = ImportUpdateDataItem.carmodel;
                    ImportDataArrayModel_data.cartype = ImportUpdateDataItem.cartype;
                    //ImportDataArrayModel_data.carFmyear = ImportUpdateDataItem.carFmyear;
                    //ImportDataArrayModel_data.carToyear = ImportUpdateDataItem.carToyear;
                    //ImportDataArrayModel_data.carGeneration = ImportUpdateDataItem.carGeneration;
                    ImportDataArrayModel_data.UsagePerCar = ImportUpdateDataItem.UsagePerCar;
                    ImportDataArrayModel_data.gdescript = ImportUpdateDataItem.gdescript;
                    ImportDataArrayModel_data.action_type = ImportUpdateDataItem.action_type;
                    ImportDataArrayModel_data.created_by = ImportUpdateDataItem.created_by;

                    ImportDataArrayData.Add(ImportDataArrayModel_data);

                    i++;
                }

                ItemMasterRepository.STMAS_EXP_IMPORT_CREATE(ImportDataArrayData);

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

        #region STMAS_EXP_IMPORT_VERIFY
        [Route("api/STMAS_EXP_IMPORT_VERIFY")]
        [HttpGet]
        public ResponseModel STMAS_EXP_IMPORT_VERIFY([FromUri] Temp_Stmas_ExpModel Temp_Stmas_ExpModel)
        {

            try
            {
                CultureInfo cultureinfo = new CultureInfo("en-US");

                ItemMasterRepository ItemMasterRepository = new ItemMasterRepository();

                List<Temp_Stmas_ExpModel> STMAS_EXP_IMPORT_VERIFY = ItemMasterRepository.STMAS_EXP_IMPORT_VERIFY(Temp_Stmas_ExpModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = STMAS_EXP_IMPORT_VERIFY;
                _ResponseModel.length = STMAS_EXP_IMPORT_VERIFY.Count();
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

        #region STMAS_EXP_IMPORT_GET
        [Route("api/STMAS_EXP_IMPORT_GET")]
        [HttpGet]
        public ResponseModel STMAS_EXP_IMPORT_GET([FromUri] Temp_Stmas_ExpModel Temp_Stmas_ExpModel)
        {

            try
            {
                CultureInfo cultureinfo = new CultureInfo("en-US");

                ItemMasterRepository ItemMasterRepository = new ItemMasterRepository();

                List<Temp_Stmas_ExpModel> STMAS_EXP_IMPORT_GET = ItemMasterRepository.STMAS_EXP_IMPORT_GET(Temp_Stmas_ExpModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = STMAS_EXP_IMPORT_GET;
                _ResponseModel.length = STMAS_EXP_IMPORT_GET.Count();
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

        #region STMAS_EXP_IMPORT_UPDATE
        [Route("api/STMAS_EXP_IMPORT_UPDATE")]
        [HttpGet]
        public ResponseModel STMAS_EXP_IMPORT_UPDATE([FromUri] Temp_Stmas_ExpModel Temp_Stmas_ExpModel)
        {

            try
            {
                CultureInfo cultureinfo = new CultureInfo("en-US");

                ItemMasterRepository ItemMasterRepository = new ItemMasterRepository();

                List<Temp_Stmas_ExpModel> STMAS_EXP_IMPORT_UPDATE = ItemMasterRepository.STMAS_EXP_IMPORT_UPDATE(Temp_Stmas_ExpModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = STMAS_EXP_IMPORT_UPDATE;
                _ResponseModel.length = STMAS_EXP_IMPORT_UPDATE.Count();
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

        #region STMAS_EXP_IMPORT_UPLOAD
        [Route("api/STMAS_EXP_IMPORT_UPLOAD")]
        [HttpGet]
        public ResponseModel STMAS_EXP_IMPORT_UPLOAD([FromUri] Temp_Stmas_ExpModel Temp_Stmas_ExpModel)
        {

            try
            {
                CultureInfo cultureinfo = new CultureInfo("en-US");

                ItemMasterRepository ItemMasterRepository = new ItemMasterRepository();

                List<Temp_Stmas_ExpModel> STMAS_EXP_IMPORT_UPLOAD = ItemMasterRepository.STMAS_EXP_IMPORT_UPLOAD(Temp_Stmas_ExpModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = STMAS_EXP_IMPORT_UPLOAD;
                _ResponseModel.length = STMAS_EXP_IMPORT_UPLOAD.Count();
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



        #region  STMAS_IMPORT_CREATE
        [Route("api/STMAS_IMPORT_CREATE")]
        [HttpPost]
        public ResponseModel STMAS_IMPORT_CREATE([FromBody] IEnumerable<Temp_Stmas_Model> Temp_Stmas_Model)
        {
            try
            {
                ResponseModel _ResponseModel = new ResponseModel();

                ItemMasterRepository ItemMasterRepository = new ItemMasterRepository();

                List<Temp_Stmas_Model> ImportDataArrayData = new List<Temp_Stmas_Model>();

                int i = 1;

                foreach (var ImportUpdateDataItem in Temp_Stmas_Model)
                {
                    Temp_Stmas_Model ImportDataArrayModel_data = new Temp_Stmas_Model();

                    ImportDataArrayModel_data.ref_id = ImportUpdateDataItem.ref_id;
                    ImportDataArrayModel_data.item_no = ImportUpdateDataItem.item_no;
                    ImportDataArrayModel_data.item_barcode = ImportUpdateDataItem.item_barcode;
                    ImportDataArrayModel_data.item_spcodes = ImportUpdateDataItem.item_spcodes;
                    ImportDataArrayModel_data.code_a_name = ImportUpdateDataItem.code_a_name;
                    ImportDataArrayModel_data.code_e_name = ImportUpdateDataItem.code_e_name;
                    ImportDataArrayModel_data.code_c_name = ImportUpdateDataItem.code_c_name;
                    ImportDataArrayModel_data.code_b_name = ImportUpdateDataItem.code_b_name;
                    ImportDataArrayModel_data.code_d_name = ImportUpdateDataItem.code_d_name;
                    ImportDataArrayModel_data.item_name_new = ImportUpdateDataItem.item_name_new;
                    ImportDataArrayModel_data.item_note = ImportUpdateDataItem.item_note;
                    ImportDataArrayModel_data.item_oem = ImportUpdateDataItem.item_oem;
                    ImportDataArrayModel_data.item_price = ImportUpdateDataItem.item_price;
                    ImportDataArrayModel_data.gpricepur = ImportUpdateDataItem.gpricepur;
                    ImportDataArrayModel_data.action_type = ImportUpdateDataItem.action_type;
                    ImportDataArrayModel_data.created_by = ImportUpdateDataItem.created_by;

                    ImportDataArrayData.Add(ImportDataArrayModel_data);

                    i++;
                }

                ItemMasterRepository.STMAS_IMPORT_CREATE(ImportDataArrayData);

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = ImportDataArrayData;
                _ResponseModel.length = ImportDataArrayData.Count();
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

        #region STMAS_IMPORT_VERIFY
        [Route("api/STMAS_IMPORT_VERIFY")]
        [HttpGet]
        public ResponseModel STMAS_IMPORT_VERIFY([FromUri] string ref_id )
        {

            try
            {
                CultureInfo cultureinfo = new CultureInfo("en-US");

                ItemMasterRepository ItemMasterRepository = new ItemMasterRepository();

                List<Temp_Stmas_Verify_Model> STMAS_IMPORT_VERIFY = ItemMasterRepository.STMAS_IMPORT_VERIFY(ref_id);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = STMAS_IMPORT_VERIFY;
                _ResponseModel.length = STMAS_IMPORT_VERIFY.Count();
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
