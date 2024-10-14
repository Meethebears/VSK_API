using REPO.Models;
using REPO.Controllers;
using System.Web.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;
using System.Data;
using System.Configuration;
using System.IO;
using System.Data.OleDb;
using System.Text.RegularExpressions;

namespace API.Controllers
{
    public class MRP_ItemSetupController : ApiController
    {

        private string Path;
        private string savePath;

        #region MRP_Item_Setup_Import
        [Route("api/MRP_Item_Setup_Import")]
        [HttpGet]
        public ResponseModel MRP_Item_Setup_Import(string ImportFilename, string ImportPathname, string created_by)
        {
            try
            {

                DataSet ds = new DataSet();

                this.savePath = ConfigurationManager.AppSettings["FileUpload"] + "\\" + ImportPathname + "\\";
                this.Path = this.savePath;

                DirectoryInfo directoryInfo = new DirectoryInfo(Regex.Replace(this.Path, "\\\\", "\\"));
                FileInfo[] files = directoryInfo.GetFiles(ImportFilename);
                FileInfo fileInfo = files[0];
                string text = directoryInfo + fileInfo.ToString();
                FileInfo fileInfo2 = new FileInfo(text);

                string excelConnectionString = @"Provider='Microsoft.ACE.OLEDB.12.0';Data Source='" + text + "';Extended Properties='Excel 12.0 Xml;IMEX=1'";
                OleDbConnection excelConnection = new OleDbConnection(excelConnectionString);
                excelConnection.Open();
                DataTable dt = new DataTable();

                dt = excelConnection.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);
                if (dt == null)
                {
                    return null;
                }
                String[] excelSheets = new String[dt.Rows.Count];
                int t = 0;

                foreach (DataRow row in dt.Rows)
                {
                    excelSheets[t] = row["TABLE_NAME"].ToString();
                    t++;
                }
                OleDbConnection excelConnection1 = new OleDbConnection(excelConnectionString);

                string query = string.Format("Select * from [{0}]", excelSheets[0]);
                using (OleDbDataAdapter dataAdapter = new OleDbDataAdapter(query, excelConnection1))
                {
                    dataAdapter.Fill(ds);
                }

                MRP_ItemSetupRepository MRPRepository = new MRP_ItemSetupRepository();

                List<MRPItemImportModel> MRPItemImportModel = new List<MRPItemImportModel>();

                for (int i = 1; i < ds.Tables[0].Rows.Count; i++)
                {
                    MRPItemImportModel MRPItemImportData = new MRPItemImportModel();

                    MRPItemImportData.Destination_Site = ds.Tables[0].Rows[i][0].ToString();
                    MRPItemImportData.Item_Code = ds.Tables[0].Rows[i][1].ToString();
                    MRPItemImportData.Remark = ds.Tables[0].Rows[i][2].ToString();
                    MRPItemImportData.MAX = ds.Tables[0].Rows[i][3].ToString();
                    MRPItemImportData.MIN = ds.Tables[0].Rows[i][4].ToString();
                    MRPItemImportData.Replenish_Status = ds.Tables[0].Rows[i][5].ToString();
                    MRPItemImportData.Action = ds.Tables[0].Rows[i][6].ToString();
                    MRPItemImportData.created_by = created_by;
                    MRPItemImportData.ImportFilename = ImportFilename;
                    MRPItemImportData.ImportPathname = ImportPathname;


                    MRPItemImportModel.Add(MRPItemImportData);
                }

                MRPRepository.MRP_Item_Setup_Import(MRPItemImportModel);

                ResponseModel _ResponseModel = new ResponseModel();
                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = MRPItemImportModel;
                _ResponseModel.length = MRPItemImportModel.Count();
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

        #region MRP_Item_Setup_List
        [Route("api/MRP_Item_Setup_List")]
        [HttpGet]
        public ResponseModel MRP_Item_Setup_List([FromUri] ItemSetupModel ItemSetupModel)
        {

            try
            {
                CultureInfo cultureinfo = new CultureInfo("en-US");

                MRP_ItemSetupRepository MrpRepository = new MRP_ItemSetupRepository();

                IList<ItemSetupModel> MRP_Item_Setup_List = MrpRepository.MRP_Item_Setup_List(ItemSetupModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = MRP_Item_Setup_List;
                _ResponseModel.length = MRP_Item_Setup_List.Count();
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

        #region MRP_Item_Setup_Verify
        [Route("api/MRP_Item_Setup_Verify")]
        [HttpGet]
        public ResponseModel MRP_Item_Setup_Verify([FromUri] MRPItemImportModel MRPItemImportModel)
        {

            try
            {
                CultureInfo cultureinfo = new CultureInfo("en-US");

                MRP_ItemSetupRepository MrpRepository = new MRP_ItemSetupRepository();

                IList<MRPItemImportModel> MRP_Item_Setup_Verify = MrpRepository.MRP_Item_Setup_Verify(MRPItemImportModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = MRP_Item_Setup_Verify;
                _ResponseModel.length = MRP_Item_Setup_Verify.Count();
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

        #region MRP_Item_Setup_Upload
        [Route("api/MRP_Item_Setup_Upload")]
        [HttpGet]
        public ResponseModel MRP_Item_Setup_Upload([FromUri] MRPItemImportModel MRPItemImportModel)
        {

            try
            {
                CultureInfo cultureinfo = new CultureInfo("en-US");

                MRP_ItemSetupRepository MrpRepository = new MRP_ItemSetupRepository();

                IList<MRPItemImportModel> MRP_Item_Setup_Upload = MrpRepository.MRP_Item_Setup_Upload(MRPItemImportModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = MRP_Item_Setup_Upload;
                _ResponseModel.length = MRP_Item_Setup_Upload.Count();
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

        #region MRP_Item_Setup_Refresh_All
        [Route("api/MRP_Item_Setup_Refresh_All")]
        [HttpGet]
        public ResponseModel MRP_Item_Setup_Refresh_All([FromUri] ItemSetupModel ItemSetupModel)
        {

            try
            {
                CultureInfo cultureinfo = new CultureInfo("en-US");

                MRP_ItemSetupRepository MrpRepository = new MRP_ItemSetupRepository();

                IList<ItemSetupModel> MRP_Item_Setup_Refresh_All = MrpRepository.MRP_Item_Setup_Refresh_All(ItemSetupModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = MRP_Item_Setup_Refresh_All;
                _ResponseModel.length = MRP_Item_Setup_Refresh_All.Count();
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
