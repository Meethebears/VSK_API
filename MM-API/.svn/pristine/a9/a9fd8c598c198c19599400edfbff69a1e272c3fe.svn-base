using Newtonsoft.Json;
using REPO.Controllers;
using REPO.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.OleDb;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text.RegularExpressions;
using System.Web.Http;

namespace API.Controllers
{
   
    public class MRPController : ApiController
    {
        private string Path;
        private string savePath;

        [Route("api/MRPItemImport")]
        [HttpGet]
        public ResponseModel MRPItemImport(string ImportFilename, string created_by)
        {
            try
            {
                DataSet ds = new DataSet();

                this.savePath = "C:\\uploads\\";
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

                MRPRepository MRPRepository = new MRPRepository();

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
                    MRPItemImportData.ImportFilename = ImportFilename;
                    MRPItemImportData.Created_by = created_by;
                  
                    MRPItemImportModel.Add(MRPItemImportData);
                }

                MRPRepository.MRPItemImport(MRPItemImportModel);

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

    }
}
