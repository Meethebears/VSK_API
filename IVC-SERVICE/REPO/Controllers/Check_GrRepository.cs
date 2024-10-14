using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using Dapper;
using REPO.Models;

namespace REPO.Controllers
{
    public class Check_GrRepository
    {

        #region Connection_SQL Server

        public SqlConnection VSK_IVC;

        private void Connection()
        {
            VSK_IVC = new SqlConnection(ConfigurationManager.ConnectionStrings["VSK_IVC_187"].ToString());
        }

        #endregion

        #region CK_GR_CREATE
        public List<CheckGrDataModel> CK_GR_CREATE(CheckGrParamCreateModel CheckGrParamCreateModel)
        {
            try
            {
                DynamicParameters objParam = new DynamicParameters();
                objParam.Add("@number", CheckGrParamCreateModel.number);
                objParam.Add("@created_by", CheckGrParamCreateModel.created_by);
                Connection();
                VSK_IVC.Open();
                List<CheckGrDataModel> DataList = SqlMapper.Query<CheckGrDataModel>(VSK_IVC, "SP_CK_GR_CREATE", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();
                VSK_IVC.Close();
                return DataList.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region CK_GR_FILE_GET
        public List<CheckGrFileModel> CK_GR_FILE_GET(CheckGrParamGetModel CheckGrParamGetModel)
        {
            try
            {
                DynamicParameters objParam = new DynamicParameters();
                objParam.Add("@number", CheckGrParamGetModel.number);
                Connection();
                VSK_IVC.Open();
                List<CheckGrFileModel> DataList = SqlMapper.Query<CheckGrFileModel>(VSK_IVC, "SP_CK_GR_FILE_GET", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();
                VSK_IVC.Close();
                return DataList.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region CK_GR_TRA_GET
        public List<CheckGrTraModel> CK_GR_TRA_GET(CheckGrParamGetModel CheckGrParamGetModel)
        {
            try
            {
                DynamicParameters objParam = new DynamicParameters();
                objParam.Add("@number", CheckGrParamGetModel.number);
                Connection();
                VSK_IVC.Open();
                List<CheckGrTraModel> DataList = SqlMapper.Query<CheckGrTraModel>(VSK_IVC, "SP_CK_GR_TRA_GET", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();
                VSK_IVC.Close();
                return DataList.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region CK_GR_VERIFY
        public List<CheckGrDataModel> CK_GR_VERIFY(CheckGrParamVerifyModel CheckGrParamVerifyModel)
        {
            try
            {
                DynamicParameters objParam = new DynamicParameters();
                objParam.Add("@number", CheckGrParamVerifyModel.number);
                objParam.Add("@barcode_vsk", CheckGrParamVerifyModel.barcode_vsk);
                objParam.Add("@barcode_package", CheckGrParamVerifyModel.barcode_package);
                objParam.Add("@qty", CheckGrParamVerifyModel.qty);
                objParam.Add("@created_by", CheckGrParamVerifyModel.created_by);
                Connection();
                VSK_IVC.Open();
                List<CheckGrDataModel> DataList = SqlMapper.Query<CheckGrDataModel>(VSK_IVC, "SP_CK_GR_VERIFY", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();
                VSK_IVC.Close();
                return DataList.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

    }
}

