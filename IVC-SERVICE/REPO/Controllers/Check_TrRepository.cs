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
    public class Check_TrRepository
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

        #region Check_Tr_List
        public List<CheckTrModel> Check_Tr_List(CheckTrModel CheckTrModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@tr_number", CheckTrModel.tr_number);
                objParam.Add("@tr_status", CheckTrModel.tr_status);
                objParam.Add("@trndate_start", CheckTrModel.trndate_start);
                objParam.Add("@trndate_end", CheckTrModel.trndate_end);
                objParam.Add("@created_by", CheckTrModel.created_by);

                Connection();
                VSK_IVC.Open();
                List<CheckTrModel> TrList = SqlMapper.Query<CheckTrModel>(VSK_IVC, "SP_CK_TR_LIST", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();
                VSK_IVC.Close();
                return TrList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Check_Tr_View
        public List<CheckTrModel> Check_Tr_View(CheckTrModel CheckTrModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@tr_number", CheckTrModel.tr_number);

                Connection();
                VSK_IVC.Open();
                List<CheckTrModel> TrList = SqlMapper.Query<CheckTrModel>(VSK_IVC, "SP_CK_TR_VIEW", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();
                VSK_IVC.Close();
                return TrList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Check_Tr_Create
        public List<CheckTrModel> Check_Tr_Create(CheckTrModel CheckTrModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@tr_number", CheckTrModel.tr_number);
                objParam.Add("@created_by", CheckTrModel.created_by);

                Connection();
                VSK_IVC.Open();
                List<CheckTrModel> TrList = SqlMapper.Query<CheckTrModel>(VSK_IVC, "SP_CK_TR_CREATE", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();
                VSK_IVC.Close();
                return TrList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Check_Tr_Update
        public List<CheckTrModel> Check_Tr_Update(CheckTrModel CheckTrModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@tr_number", CheckTrModel.tr_number);
                objParam.Add("@tr_scan", CheckTrModel.tr_scan);
                objParam.Add("@tr_qty", CheckTrModel.tr_qty);
                objParam.Add("@updated_by", CheckTrModel.updated_by);
                objParam.Add("@pMessage", CheckTrModel.pMessage);

                Connection();
                VSK_IVC.Open();
                List<CheckTrModel> TrList = SqlMapper.Query<CheckTrModel>(VSK_IVC, "SP_CK_TR_UPDATE", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();
                VSK_IVC.Close();
                return TrList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Check_Tr_Edit
        public List<CheckTrModel> Check_Tr_Edit(CheckTrModel CheckTrModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@tr_number", CheckTrModel.tr_number);
                objParam.Add("@tr_scan", CheckTrModel.tr_scan);
                objParam.Add("@tr_qty", CheckTrModel.tr_qty);
                objParam.Add("@updated_by", CheckTrModel.updated_by);

                Connection();
                VSK_IVC.Open();
                List<CheckTrModel> TrList = SqlMapper.Query<CheckTrModel>(VSK_IVC, "SP_CK_TR_EDIT", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();
                VSK_IVC.Close();
                return TrList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Check_Tr_Remark_List
        public List<CheckTrModel> Check_Tr_Remark_List(CheckTrModel CheckTrModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@tr_number", CheckTrModel.tr_number);
                objParam.Add("@tr_remark_gbarcode", CheckTrModel.tr_remark_gbarcode);

                Connection();
                VSK_IVC.Open();
                List<CheckTrModel> TrList = SqlMapper.Query<CheckTrModel>(VSK_IVC, "SP_CK_TR_REMARK_LIST", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();
                VSK_IVC.Close();
                return TrList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Check_Tr_Remark_Create
        public List<CheckTrModel> Check_Tr_Remark_Create(CheckTrModel CheckTrModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();


                objParam.Add("@tr_number", CheckTrModel.tr_number);
                objParam.Add("@tr_scan", CheckTrModel.tr_scan);
                objParam.Add("@r_qty", CheckTrModel.r_qty);
                objParam.Add("@r_remark", CheckTrModel.r_remark);
                objParam.Add("@created_by", CheckTrModel.created_by);

                Connection();
                VSK_IVC.Open();
                List<CheckTrModel> TrList = SqlMapper.Query<CheckTrModel>(VSK_IVC, "SP_CK_TR_REMARK_CREATE", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();
                VSK_IVC.Close();
                return TrList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Check_Tr_Remark_Delete
        public List<CheckTrModel> Check_Tr_Remark_Delete(CheckTrModel CheckTrModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@tr_number", CheckTrModel.tr_number);
                objParam.Add("@tr_scan", CheckTrModel.tr_scan);
                objParam.Add("@created_by", CheckTrModel.created_by);

                Connection();
                VSK_IVC.Open();
                List<CheckTrModel> TrList = SqlMapper.Query<CheckTrModel>(VSK_IVC, "SP_CK_TR_REMARK_DELETE", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();
                VSK_IVC.Close();
                return TrList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion
    }
}