using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

using Dapper;
using MySql.Data.MySqlClient;
using REPO.Models;

namespace REPO.Controllers
{
    public class Upload_LoscanRepository
    {

        #region Connection_SQL Server
        //-------------------Start Connection_SQL ------------------------//

        public SqlConnection VSK_IVC;

        private void Connection()
        {

            VSK_IVC = new SqlConnection(ConfigurationManager.ConnectionStrings["VSK_IVC_187"].ToString());

        }

        //-------------------End Connection_SQL ------------------------//
        #endregion

        #region Loscan_Import_Data_Tmp
        public List<LoscanModel> Loscan_Import_Data_Tmp(LoscanModel LoscanModel)
        {
            try
            {
                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@temp_id", LoscanModel.temp_id);
                objParam.Add("@countitem_all", LoscanModel.countitem_all);
                objParam.Add("@created_by", LoscanModel.created_by);

                Connection();
                VSK_IVC.Open();
                List<LoscanModel> master_date = SqlMapper.Query<LoscanModel>(VSK_IVC, "SP_LOSCAN_IMPORT_DATA_TMP", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();

                VSK_IVC.Close();
                return master_date.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Loscan_Import_Data_TmpTran
        public void Loscan_Import_Data_TmpTran(List<LoscanModel> LoscanModel)
        {
            try
            {
                Connection();
                VSK_IVC.Open();

                foreach (var ImportDataArrayData in LoscanModel)
                {
                    DynamicParameters objParam = new DynamicParameters();

                    objParam.Add("@temp_id", ImportDataArrayData.temp_id);
                    objParam.Add("@scan_date", ImportDataArrayData.scan_date);
                    objParam.Add("@user_scan", ImportDataArrayData.user_scan);
                    objParam.Add("@wh", ImportDataArrayData.wh);
                    objParam.Add("@location", ImportDataArrayData.location);
                    objParam.Add("@barcode", ImportDataArrayData.barcode);
                    objParam.Add("@remarks", ImportDataArrayData.remarks);
                    objParam.Add("@action_type", ImportDataArrayData.action_type);
                    objParam.Add("@created_by", ImportDataArrayData.created_by);

                    VSK_IVC.Execute("SP_LOSCAN_IMPORT_DATA_TMPTRAN", objParam, commandTimeout: 600, commandType: CommandType.StoredProcedure);

                }

                VSK_IVC.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Loscan_Import_Data_Check
        public List<LoscanModel> Loscan_Import_Data_Check(LoscanModel LoscanModel)
        {
            try
            {
                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@temp_id", LoscanModel.temp_id);
                objParam.Add("@scan_date", LoscanModel.scan_date);
                objParam.Add("@user_scan", LoscanModel.user_scan);

                Connection();
                VSK_IVC.Open();
                List<LoscanModel> master_date = SqlMapper.Query<LoscanModel>(VSK_IVC, "SP_LOSCAN_IMPORT_DATA_CHECK", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();

                VSK_IVC.Close();
                return master_date.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Loscan_Import_Data_TmpVerify
        public List<LoscanModel> Loscan_Import_Data_TmpVerify(LoscanModel LoscanModel)
        {
            try
            {
                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@temp_id", LoscanModel.temp_id);

                Connection();
                VSK_IVC.Open();
                List<LoscanModel> master_date = SqlMapper.Query<LoscanModel>(VSK_IVC, "SP_LOSCAN_IMPORT_DATA_TMPVERIFY", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();

                VSK_IVC.Close();
                return master_date.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Loscan_Import_Data_Upload
        public List<LoscanModel> Loscan_Import_Data_Upload(LoscanModel LoscanModel)
        {
            try
            {
                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@temp_id", LoscanModel.temp_id);
                objParam.Add("@countitem_incomplete", LoscanModel.countitem_incomplete);
                objParam.Add("@countitem_complete", LoscanModel.countitem_complete);
                objParam.Add("@countitem_updated", LoscanModel.countitem_updated);
                objParam.Add("@updated_by", LoscanModel.updated_by);

                Connection();
                VSK_IVC.Open();
                List<LoscanModel> master_date = SqlMapper.Query<LoscanModel>(VSK_IVC, "SP_LOSCAN_IMPORT_DATA_UPLOAD", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();

                VSK_IVC.Close();
                return master_date.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Loscan_List
        public List<LoscanModel> Loscan_List(LoscanModel LoscanModel)
        {
            try
            {
                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@user_scan", LoscanModel.user_scan);
                objParam.Add("@wh", LoscanModel.wh);
                objParam.Add("@job_date_start", LoscanModel.job_date_start);
                objParam.Add("@job_date_end", LoscanModel.job_date_end);

                Connection();
                VSK_IVC.Open();
                List<LoscanModel> master_date = SqlMapper.Query<LoscanModel>(VSK_IVC, "SP_LOSCAN_LIST", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();

                VSK_IVC.Close();
                return master_date.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Loscan_Detail
        public List<LoscanModel> Loscan_Detail(LoscanModel LoscanModel)
        {
            try
            {
                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@temp_id", LoscanModel.temp_id);
                objParam.Add("@scan_date", LoscanModel.scan_date);
                objParam.Add("@user_scan", LoscanModel.user_scan);

                Connection();
                VSK_IVC.Open();
                List<LoscanModel> master_date = SqlMapper.Query<LoscanModel>(VSK_IVC, "SP_LOSCAN_DETAIL", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();

                VSK_IVC.Close();
                return master_date.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Loscan_Detail
        public List<LoscanModel> Loscan_Delete(LoscanModel LoscanModel)
        {
            try
            {
                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@temp_id", LoscanModel.temp_id);
                objParam.Add("@scan_date", LoscanModel.scan_date);
                objParam.Add("@user_scan", LoscanModel.user_scan);

                Connection();
                VSK_IVC.Open();
                List<LoscanModel> master_date = SqlMapper.Query<LoscanModel>(VSK_IVC, "SP_LOSCAN_DELETE", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();

                VSK_IVC.Close();
                return master_date.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

    }
}