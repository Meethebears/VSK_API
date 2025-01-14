﻿using REPO.Models;
using REPO.Controllers;
using System.Web.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;

namespace API.Controllers
{
    public class MasterController : ApiController
    {
        #region Mas_gcode_get
        [Route("api/Mas_gcode_get")]
        [HttpGet]
        public ResponseModel Mas_gcode_get([FromUri] MasterModel MasterModel)
        {

            try
            {
                CultureInfo cultureinfo = new CultureInfo("en-US");

                MasterRepository MasterRepository = new MasterRepository();

                List<MasterModel> Mas_gcode_get = MasterRepository.Mas_gcode_get(MasterModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = Mas_gcode_get;
                _ResponseModel.length = Mas_gcode_get.Count();
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

        #region Mas_gcode_action
        [Route("api/Mas_gcode_action")]
        [HttpPost]
        public ResponseModel Mas_gcode_action([FromBody] MasterModel MasterModel)
        {

            try
            {
                CultureInfo cultureinfo = new CultureInfo("en-US");

                MasterRepository MasterRepository = new MasterRepository();

                List<MasterModel> Mas_gcode_action = MasterRepository.Mas_gcode_action(MasterModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = Mas_gcode_action;
                _ResponseModel.length = Mas_gcode_action.Count();
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

        #region Mas_gcode_chk
        [Route("api/Mas_gcode_chk")]
        [HttpGet]
        public ResponseModel Mas_gcode_chk([FromUri] MasterModel MasterModel)
        {

            try
            {
                CultureInfo cultureinfo = new CultureInfo("en-US");

                MasterRepository MasterRepository = new MasterRepository();

                List<MasterModel> Mas_gcode_chk = MasterRepository.Mas_gcode_chk(MasterModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = Mas_gcode_chk;
                _ResponseModel.length = Mas_gcode_chk.Count();
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

        #region Master_stmas_exp_get
        [Route("api/Master_stmas_exp_get")]
        [HttpGet]
        public ResponseModel Master_stmas_exp_get([FromUri] Stmas_ExpModel Stmas_ExpModel)
        {

            try
            {
                CultureInfo cultureinfo = new CultureInfo("en-US");

                MasterRepository MasterRepository = new MasterRepository();

                List<Stmas_ExpModel> Master_stmas_exp_get = MasterRepository.Master_stmas_exp_get(Stmas_ExpModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = Master_stmas_exp_get;
                _ResponseModel.length = Master_stmas_exp_get.Count();
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

        #region ItemMaster_Search
        [Route("api/ItemMaster_Search")]
        [HttpGet]
        public ResponseModel MRP_ItemMaster_Search_v2([FromUri] string id, string text, string keywords)
        {
            try
            {

                CultureInfo cultureinfo = new CultureInfo("en-US");

                MasterRepository MasterRepository = new MasterRepository();

                List<Item_masterModel> ItemMaster_Search = MasterRepository.ItemMaster_Search(id, text, keywords);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = ItemMaster_Search;
                _ResponseModel.length = ItemMaster_Search.Count();
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

        #region Product_Main_Search
        [Route("api/Product_Main_Search")]
        [HttpGet]
        public ResponseModel Product_Main_Search([FromUri] string id, string text, string keywords)
        {
            try
            {

                CultureInfo cultureinfo = new CultureInfo("en-US");

                MasterRepository MasterRepository = new MasterRepository();

                List<Item_masterModel> Product_Main_Search = MasterRepository.Product_Main_Search(id, text, keywords);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = Product_Main_Search;
                _ResponseModel.length = Product_Main_Search.Count();
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

        #region Gcode_Get_Select2
        [Route("api/Gcode_Get_Select2")]
        [HttpGet]
        public ResponseModel Gcode_Get_Select2([FromUri] string ctype, string keywords)
        {
            try
            {

                CultureInfo cultureinfo = new CultureInfo("en-US");

                MasterRepository MasterRepository = new MasterRepository();

                List<Item_masterModel> Gcode_Get_Select2 = MasterRepository.Gcode_Get_Select2(ctype, keywords);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = Gcode_Get_Select2;
                _ResponseModel.length = Gcode_Get_Select2.Count();
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

        #region Mas_stmas_action
        [Route("api/Mas_stmas_action")]
        [HttpPost]
        public ResponseModel Mas_stmas_action([FromBody] Action_stmasModel Action_stmasModel)
        {

            try
            {
                CultureInfo cultureinfo = new CultureInfo("en-US");

                MasterRepository MasterRepository = new MasterRepository();

                List<Action_stmasModel> Mas_stmas_action = MasterRepository.Mas_stmas_action(Action_stmasModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = Mas_stmas_action;
                _ResponseModel.length = Mas_stmas_action.Count();
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

        #region Master_Stams_Exp_Chk
        [Route("api/Master_Stams_Exp_Chk")]
        [HttpGet]
        public ResponseModel Master_Stams_Exp_Chk([FromUri] Chk_Stmas_ExpModel Chk_Stmas_ExpModel)
        {

            try
            {
                CultureInfo cultureinfo = new CultureInfo("en-US");

                MasterRepository MasterRepository = new MasterRepository();

                List<Chk_Stmas_ExpModel> Master_Stams_Exp_Chk = MasterRepository.Master_Stams_Exp_Chk(Chk_Stmas_ExpModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = Master_Stams_Exp_Chk;
                _ResponseModel.length = Master_Stams_Exp_Chk.Count();
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

        #region  ImportData_Tran_Create
        [Route("api/ImportData_Tran_Create")]
        [HttpPost]
        public ResponseModel ImportData_Tran_Create([FromBody] IEnumerable<Action_stmasModel> Action_stmasModel)
        {
            try
            {
                List<Action_stmasModel> ImportDataArrayData = new List<Action_stmasModel>();

                int i = 1;

                foreach (var ImportUpdateDataItem in Action_stmasModel)
                {
                    Action_stmasModel ImportDataArrayModel_data = new Action_stmasModel();
                    ImportDataArrayModel_data.coderef = ImportUpdateDataItem.coderef;
                    ImportDataArrayModel_data.codeexp = ImportUpdateDataItem.codeexp;
                    //ImportDataArrayModel_data.code_a = ImportUpdateDataItem.code_a;
                    //ImportDataArrayModel_data.code_b = ImportUpdateDataItem.code_b;
                    //ImportDataArrayModel_data.code_c = ImportUpdateDataItem.code_c;
                    //ImportDataArrayModel_data.code_d = ImportUpdateDataItem.code_d;
                    //ImportDataArrayModel_data.code_e = ImportUpdateDataItem.code_e;
                    ImportDataArrayModel_data.code_a_name = ImportUpdateDataItem.code_a_name;
                    ImportDataArrayModel_data.code_b_name = ImportUpdateDataItem.code_b_name;
                    ImportDataArrayModel_data.code_c_name = ImportUpdateDataItem.code_c_name;
                    ImportDataArrayModel_data.code_d_name = ImportUpdateDataItem.code_d_name;
                    ImportDataArrayModel_data.code_e_name = ImportUpdateDataItem.code_e_name;
                    ImportDataArrayModel_data.stmas_code_compare = ImportUpdateDataItem.stmas_code_compare;
                    ImportDataArrayModel_data.stmas_name_compare = ImportUpdateDataItem.stmas_name_compare;
                    ImportDataArrayModel_data.stmas_exp_name_compare = ImportUpdateDataItem.stmas_exp_name_compare;
                    ImportDataArrayModel_data.code_a_compare = ImportUpdateDataItem.code_a_compare;
                    ImportDataArrayModel_data.code_b_compare = ImportUpdateDataItem.code_b_compare;
                    ImportDataArrayModel_data.code_c_compare = ImportUpdateDataItem.code_c_compare;
                    ImportDataArrayModel_data.code_d_compare = ImportUpdateDataItem.code_d_compare;
                    ImportDataArrayModel_data.code_e_compare = ImportUpdateDataItem.code_e_compare;
                    ImportDataArrayModel_data.gdescript = ImportUpdateDataItem.gdescript;
                    //ImportDataArrayModel_data.gremark = ImportUpdateDataItem.gremark;
                    ImportDataArrayModel_data.action_type = ImportUpdateDataItem.action_type;
                    ImportDataArrayModel_data.created_by = ImportUpdateDataItem.created_by;
                    ImportDataArrayModel_data.created_by2 = ImportUpdateDataItem.created_by2;
                    ImportDataArrayModel_data.temp_id = ImportUpdateDataItem.temp_id;
                    ImportDataArrayData.Add(ImportDataArrayModel_data);

                    i++;
                }

                MasterRepository MasterRepository = new MasterRepository();
                MasterRepository.ImportData_Tran_Create(ImportDataArrayData);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.status = "Success";

                return _ResponseModel;
            }
            catch (Exception ex)
            {
                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                //_ResponseModel.status = "Error";
                _ResponseModel.status = ex.ToString();

                return _ResponseModel;
            }
        }
        #endregion

        #region ImportData_Create
        [Route("api/ImportData_Create")]
        [HttpPost]
        public ResponseModel ImportData_Create([FromBody] ImportDataModel ImportDataModel)
        {

            try
            {
                CultureInfo cultureinfo = new CultureInfo("en-US");

                MasterRepository MasterRepository = new MasterRepository();

                List<ImportDataModel> ImportData_Create = MasterRepository.ImportData_Create(ImportDataModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = ImportData_Create;
                _ResponseModel.length = ImportData_Create.Count();
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

        #region ImportData_Update
        [Route("api/ImportData_Update")]
        [HttpGet]
        public ResponseModel ImportData_Update([FromUri] ImportDataModel ImportDataModel)
        {

            try
            {
                CultureInfo cultureinfo = new CultureInfo("en-US");

                MasterRepository MasterRepository = new MasterRepository();

                List<ImportDataModel> ImportData_Update = MasterRepository.ImportData_Update(ImportDataModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = ImportData_Update;
                _ResponseModel.length = ImportData_Update.Count();
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

        #region ImportData_TemplateGet
        [Route("api/ImportData_TemplateGet")]
        [HttpGet]
        public ResponseModel ImportData_TemplateGet([FromUri] Stmas_ExpModel Stmas_ExpModel)
        {

            try
            {
                CultureInfo cultureinfo = new CultureInfo("en-US");

                MasterRepository MasterRepository = new MasterRepository();

                List<Stmas_ExpModel> ImportData_TemplateGet = MasterRepository.ImportData_TemplateGet(Stmas_ExpModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = ImportData_TemplateGet;
                _ResponseModel.length = ImportData_TemplateGet.Count();
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

        #region ImportData_Update_Data
        [Route("api/ImportData_Update_Data")]
        [HttpGet]
        public ResponseModel ImportData_Update_Data([FromUri] ImportDataModel ImportDataModel)
        {

            try
            {
                CultureInfo cultureinfo = new CultureInfo("en-US");

                MasterRepository MasterRepository = new MasterRepository();

                List<ImportDataModel> ImportData_Update_Data = MasterRepository.ImportData_Update_Data(ImportDataModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = ImportData_Update_Data;
                _ResponseModel.length = ImportData_Update_Data.Count();
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

        #region ImportData_Update_Data_VSK_MIS
        [Route("api/ImportData_Update_Data_VSK_MIS")]
        [HttpGet]
        public ResponseModel ImportData_Update_Data_VSK_MIS([FromUri] ImportDataModel ImportDataModel)
        {

            try
            {
                CultureInfo cultureinfo = new CultureInfo("en-US");

                MasterRepository MasterRepository = new MasterRepository();

                List<ImportDataModel> ImportData_Update_Data_VSK_MIS = MasterRepository.ImportData_Update_Data_VSK_MIS(ImportDataModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = ImportData_Update_Data_VSK_MIS;
                _ResponseModel.length = ImportData_Update_Data_VSK_MIS.Count();
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

        #region Stmas_Exp_Update
        [Route("api/Stmas_Exp_Update")]
        [HttpGet]
        public ResponseModel Stmas_Exp_Update([FromUri] ImportDataModel ImportDataModel)
        {

            try
            {
                CultureInfo cultureinfo = new CultureInfo("en-US");

                MasterRepository MasterRepository = new MasterRepository();

                List<ImportDataModel> Stmas_Exp_Update = MasterRepository.Stmas_Exp_Update(ImportDataModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = Stmas_Exp_Update;
                _ResponseModel.length = Stmas_Exp_Update.Count();
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
