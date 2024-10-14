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
    public class Check_BrRepository
    {

        #region Connection_SQL Server
        //-------------------Start Connection_SQL ------------------------//
        public SqlConnection VSK_BR;

        private void Connection()
        {

            //VSK_BR = new SqlConnection(ConfigurationManager.ConnectionStrings["VSK_DEV"].ToString());
            //VSK_BR = new SqlConnection(ConfigurationManager.ConnectionStrings["VSK_BR_187"].ToString());
            VSK_BR = new SqlConnection(ConfigurationManager.ConnectionStrings["VSK_BR_187"].ToString());

        }

        //-------------------End Connection_SQL ------------------------//
        #endregion

        #region Br_Master_Data
        public List<CheckBrModel> Br_Master_Data(CheckBrModel CheckBrModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@mode", CheckBrModel.mode);
                objParam.Add("@p1", CheckBrModel.p1);
                objParam.Add("@p2", CheckBrModel.p2);
                objParam.Add("@p3", CheckBrModel.p3);
                objParam.Add("@p4", CheckBrModel.p4);
                objParam.Add("@p5", CheckBrModel.p5);

                Connection();
                VSK_BR.Open();
                List<CheckBrModel> DataList = SqlMapper.Query<CheckBrModel>(VSK_BR, "SP_BR_MASTER_DATA", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();
                VSK_BR.Close();
                return DataList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Check_Br_Get_Nubmer
        public List<CheckBrModel> Check_Br_Get_Nubmer(CheckBrModel CheckBrModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@mode", CheckBrModel.mode);
                objParam.Add("@trndate_start", CheckBrModel.trndate_start);
                objParam.Add("@trndate_end", CheckBrModel.trndate_end);
                objParam.Add("@number", CheckBrModel.number);
                objParam.Add("@invcode", CheckBrModel.invcode);
                objParam.Add("@pages", CheckBrModel.pages);
                objParam.Add("@show", CheckBrModel.show);

                Connection();
                VSK_BR.Open();
                List<CheckBrModel> DataList = SqlMapper.Query<CheckBrModel>(VSK_BR, "SP_CK_BR_GET_NUMBER", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();
                VSK_BR.Close();
                return DataList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Check_Br_List_Mcenter
        public List<CheckBrModel> Check_Br_List_Mcenter(CheckBrModel CheckBrModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@mode", CheckBrModel.mode);
                objParam.Add("@trndate_start", CheckBrModel.trndate_start);
                objParam.Add("@trndate_end", CheckBrModel.trndate_end);
                objParam.Add("@number", CheckBrModel.number);
                objParam.Add("@invcode", CheckBrModel.invcode);
                objParam.Add("@pages", CheckBrModel.pages);
                objParam.Add("@show", CheckBrModel.show);

                Connection();
                VSK_BR.Open();
                List<CheckBrModel> DataList = SqlMapper.Query<CheckBrModel>(VSK_BR, "SP_CK_BR_LIST_MCENTER", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();
                VSK_BR.Close();
                return DataList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Check_Br_List
        public List<CheckBrModel> Check_Br_List(CheckBrModel CheckBrModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@trndate_start", CheckBrModel.trndate_start);
                objParam.Add("@trndate_end", CheckBrModel.trndate_end);
                objParam.Add("@action_type", CheckBrModel.action_type);
                objParam.Add("@job_no", CheckBrModel.job_no);
                objParam.Add("@job_status", CheckBrModel.job_status);
                objParam.Add("@job_branch", CheckBrModel.job_branch);
                objParam.Add("@location_branch", CheckBrModel.location_branch);
                objParam.Add("@created_by", CheckBrModel.created_by);
                objParam.Add("@pages", CheckBrModel.pages);
                objParam.Add("@show", CheckBrModel.show);

                Connection();
                VSK_BR.Open();
                List<CheckBrModel> DataList = SqlMapper.Query<CheckBrModel>(VSK_BR, "SP_CK_BR_LIST", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();
                VSK_BR.Close();
                return DataList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Check_Br_Detail
        public List<CheckBrModel> Check_Br_Detail(CheckBrModel CheckBrModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@job_no", CheckBrModel.job_no);

                Connection();
                VSK_BR.Open();
                List<CheckBrModel> DataList = SqlMapper.Query<CheckBrModel>(VSK_BR, "SP_CK_BR_DETAIL", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();
                VSK_BR.Close();
                return DataList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Check_Br_Create
        public List<CheckBrModel> Check_Br_Create(CheckBrModel CheckBrModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@job_branch", CheckBrModel.job_branch);
                objParam.Add("@job_no", CheckBrModel.job_no);
                objParam.Add("@created_by", CheckBrModel.created_by);

                Connection();
                VSK_BR.Open();
                List<CheckBrModel> DataList = SqlMapper.Query<CheckBrModel>(VSK_BR, "SP_CK_BR_CREATE", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();
                VSK_BR.Close();
                return DataList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Check_Br_Update
        public List<CheckBrModel> Check_Br_Update(CheckBrModel CheckBrModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@job_no", CheckBrModel.job_no);
                objParam.Add("@job_scan", CheckBrModel.job_scan);
                objParam.Add("@job_qty", CheckBrModel.job_qty);
                objParam.Add("@updated_by", CheckBrModel.updated_by);
                objParam.Add("@pMessage", CheckBrModel.pMessage);

                Connection();
                VSK_BR.Open();
                List<CheckBrModel> DataList = SqlMapper.Query<CheckBrModel>(VSK_BR, "SP_CK_BR_UPDATE", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();
                VSK_BR.Close();
                return DataList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Check_Br_Edit
        public List<CheckBrModel> Check_Br_Edit(CheckBrModel CheckBrModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@job_no", CheckBrModel.job_no);
                objParam.Add("@job_scan", CheckBrModel.job_scan);
                objParam.Add("@job_qty", CheckBrModel.job_qty);
                objParam.Add("@updated_by", CheckBrModel.updated_by);

                Connection();
                VSK_BR.Open();
                List<CheckBrModel> DataList = SqlMapper.Query<CheckBrModel>(VSK_BR, "SP_CK_BR_EDIT", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();
                VSK_BR.Close();
                return DataList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Check_Br_Success
        public List<CheckBrModel> Check_Br_Success(CheckBrModel CheckBrModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@job_no", CheckBrModel.job_no);
                objParam.Add("@updated_by", CheckBrModel.updated_by);

                Connection();
                VSK_BR.Open();
                List<CheckBrModel> DataList = SqlMapper.Query<CheckBrModel>(VSK_BR, "SP_CK_BR_SUCCESS", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();
                VSK_BR.Close();
                return DataList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Check_Br_Get
        public List<CheckBrModel> Check_Br_Get(CheckBrModel CheckBrModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@job_no", CheckBrModel.job_no);
                objParam.Add("@pages", CheckBrModel.pages);
                objParam.Add("@show", CheckBrModel.show);

                Connection();
                VSK_BR.Open();
                List<CheckBrModel> DataList = SqlMapper.Query<CheckBrModel>(VSK_BR, "SP_CK_BR_GET", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();
                VSK_BR.Close();
                return DataList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion


        // NEW OUT START //

        #region Check_Br_Create_Out
        public List<CheckBrModel> Check_Br_Create_Out(CheckBrModel CheckBrModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@ref_id", CheckBrModel.ref_id);
                objParam.Add("@action_type", CheckBrModel.action_type);
                objParam.Add("@job_branch", CheckBrModel.job_branch);
                objParam.Add("@job_no", CheckBrModel.job_no);
                objParam.Add("@created_by", CheckBrModel.created_by);
                //objParam.Add("@pMessage", CheckBrModel.pMessage);

                Connection();
                VSK_BR.Open();
                List<CheckBrModel> DataList = SqlMapper.Query<CheckBrModel>(VSK_BR, "SP_CK_BR_CREATE_OUT", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();
                VSK_BR.Close();
                return DataList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Check_Br_Update_Out
        public List<CheckBrModel> Check_Br_Update_Out(CheckBrModel CheckBrModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@ref_id", CheckBrModel.ref_id);
                objParam.Add("@job_no", CheckBrModel.job_no);
                objParam.Add("@job_scan", CheckBrModel.job_scan);
                objParam.Add("@job_qty", CheckBrModel.job_qty);
                objParam.Add("@updated_by", CheckBrModel.updated_by);
                objParam.Add("@pMessage", CheckBrModel.pMessage);

                Connection();
                VSK_BR.Open();
                List<CheckBrModel> DataList = SqlMapper.Query<CheckBrModel>(VSK_BR, "SP_CK_BR_UPDATE_OUT", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();
                VSK_BR.Close();
                return DataList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Check_Br_Get_Out
        public List<CheckBrModel> Check_Br_Get_Out(CheckBrModel CheckBrModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@job_no", CheckBrModel.job_no);
                objParam.Add("@ref_id", CheckBrModel.ref_id);
                objParam.Add("@job_status", CheckBrModel.job_status);
                objParam.Add("@keywords", CheckBrModel.keywords);
                objParam.Add("@pages", CheckBrModel.pages);
                objParam.Add("@show", CheckBrModel.show);

                Connection();
                VSK_BR.Open();
                List<CheckBrModel> DataList = SqlMapper.Query<CheckBrModel>(VSK_BR, "SP_CK_BR_GET_OUT", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();
                VSK_BR.Close();
                return DataList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Check_Br_Count_Out
        public List<CheckBrModel> Check_Br_Count_Out(CheckBrModel CheckBrModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@job_no", CheckBrModel.job_no);
                objParam.Add("@ref_id", CheckBrModel.ref_id);
                objParam.Add("@job_branch", CheckBrModel.job_branch);

                Connection();
                VSK_BR.Open();
                List<CheckBrModel> DataList = SqlMapper.Query<CheckBrModel>(VSK_BR, "SP_CK_BR_COUNT_OUT", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();
                VSK_BR.Close();
                return DataList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Check_Br_Success_Out
        public List<CheckBrModel> Check_Br_Success_Out(CheckBrModel CheckBrModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@job_no", CheckBrModel.job_no);
                objParam.Add("@ref_id", CheckBrModel.ref_id);
                objParam.Add("@updated_by", CheckBrModel.updated_by);

                Connection();
                VSK_BR.Open();
                List<CheckBrModel> DataList = SqlMapper.Query<CheckBrModel>(VSK_BR, "SP_CK_BR_SUCCESS_OUT", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();
                VSK_BR.Close();
                return DataList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Check_Br_Remark_Create_Out
        public List<CheckBrModel> Check_Br_Remark_Create_Out(CheckBrModel CheckBrModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@ref_id", CheckBrModel.ref_id);
                objParam.Add("@job_no", CheckBrModel.job_no);
                objParam.Add("@job_scan", CheckBrModel.job_scan);
                objParam.Add("@job_qty", CheckBrModel.job_qty);
                objParam.Add("@job_remark", CheckBrModel.job_remark);
                objParam.Add("@created_by", CheckBrModel.created_by);
                objParam.Add("@pMessage", CheckBrModel.pMessage);

                Connection();
                VSK_BR.Open();
                List<CheckBrModel> DataList = SqlMapper.Query<CheckBrModel>(VSK_BR, "SP_CK_BR_REMARK_CREATE_OUT", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();
                VSK_BR.Close();
                return DataList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Check_Br_Remark_Delete_Out
        public List<CheckBrModel> Check_Br_Remark_Delete_Out(CheckBrModel CheckBrModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@ref_id", CheckBrModel.ref_id);
                objParam.Add("@job_no", CheckBrModel.job_no);
                objParam.Add("@job_scan", CheckBrModel.job_scan);
                objParam.Add("@created_by", CheckBrModel.created_by);

                Connection();
                VSK_BR.Open();
                List<CheckBrModel> DataList = SqlMapper.Query<CheckBrModel>(VSK_BR, "SP_CK_BR_REMARK_DELETE_OUT", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();
                VSK_BR.Close();
                return DataList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Check_Br_Qty_Out
        public List<CheckBrModel> Check_Br_Qty_Out(CheckBrModel CheckBrModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@ref_id", CheckBrModel.ref_id);
                objParam.Add("@job_no", CheckBrModel.job_no);
                objParam.Add("@job_scan", CheckBrModel.job_scan);
                objParam.Add("@job_qty", CheckBrModel.job_qty);
                objParam.Add("@updated_by", CheckBrModel.updated_by);

                Connection();
                VSK_BR.Open();
                List<CheckBrModel> DataList = SqlMapper.Query<CheckBrModel>(VSK_BR, "SP_CK_BR_QTY_OUT", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();
                VSK_BR.Close();
                return DataList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        // NEW OUT END //

        // NEW IN START //

        #region Check_Br_Create_In
        public List<CheckBrModel> Check_Br_Create_In(CheckBrModel CheckBrModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@ref_id", CheckBrModel.ref_id);
                objParam.Add("@action_type", CheckBrModel.action_type);
                objParam.Add("@job_branch", CheckBrModel.job_branch);
                objParam.Add("@job_no", CheckBrModel.job_no);
                objParam.Add("@created_by", CheckBrModel.created_by);
                //objParam.Add("@pMessage", CheckBrModel.pMessage);

                Connection();
                VSK_BR.Open();
                List<CheckBrModel> DataList = SqlMapper.Query<CheckBrModel>(VSK_BR, "SP_CK_BR_CREATE_IN", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();
                VSK_BR.Close();
                return DataList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Check_Br_Update_In
        public List<CheckBrModel> Check_Br_Update_In(CheckBrModel CheckBrModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@ref_id", CheckBrModel.ref_id);
                objParam.Add("@job_no", CheckBrModel.job_no);
                objParam.Add("@job_scan", CheckBrModel.job_scan);
                objParam.Add("@job_qty", CheckBrModel.job_qty);
                objParam.Add("@updated_by", CheckBrModel.updated_by);
                objParam.Add("@pMessage", CheckBrModel.pMessage);

                Connection();
                VSK_BR.Open();
                List<CheckBrModel> DataList = SqlMapper.Query<CheckBrModel>(VSK_BR, "SP_CK_BR_UPDATE_IN", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();
                VSK_BR.Close();
                return DataList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Check_Br_Get_In
        public List<CheckBrModel> Check_Br_Get_In(CheckBrModel CheckBrModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@job_no", CheckBrModel.job_no);
                objParam.Add("@ref_id", CheckBrModel.ref_id);
                objParam.Add("@job_status", CheckBrModel.job_status);
                objParam.Add("@keywords", CheckBrModel.keywords);
                objParam.Add("@pages", CheckBrModel.pages);
                objParam.Add("@show", CheckBrModel.show);

                Connection();
                VSK_BR.Open();
                List<CheckBrModel> DataList = SqlMapper.Query<CheckBrModel>(VSK_BR, "SP_CK_BR_GET_IN", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();
                VSK_BR.Close();
                return DataList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Check_Br_Count_In
        public List<CheckBrModel> Check_Br_Count_In(CheckBrModel CheckBrModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@job_no", CheckBrModel.job_no);
                objParam.Add("@ref_id", CheckBrModel.ref_id);
                objParam.Add("@job_branch", CheckBrModel.job_branch);

                Connection();
                VSK_BR.Open();
                List<CheckBrModel> DataList = SqlMapper.Query<CheckBrModel>(VSK_BR, "SP_CK_BR_COUNT_IN", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();
                VSK_BR.Close();
                return DataList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Check_Br_Success_In
        public List<CheckBrModel> Check_Br_Success_In(CheckBrModel CheckBrModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@job_no", CheckBrModel.job_no);
                objParam.Add("@ref_id", CheckBrModel.ref_id);
                objParam.Add("@updated_by", CheckBrModel.updated_by);

                Connection();
                VSK_BR.Open();
                List<CheckBrModel> DataList = SqlMapper.Query<CheckBrModel>(VSK_BR, "SP_CK_BR_SUCCESS_IN", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();
                VSK_BR.Close();
                return DataList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Check_Br_Remark_Create_In
        public List<CheckBrModel> Check_Br_Remark_Create_In(CheckBrModel CheckBrModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@ref_id", CheckBrModel.ref_id);
                objParam.Add("@job_no", CheckBrModel.job_no);
                objParam.Add("@job_scan", CheckBrModel.job_scan);
                objParam.Add("@job_qty", CheckBrModel.job_qty);
                objParam.Add("@job_remark", CheckBrModel.job_remark);
                objParam.Add("@created_by", CheckBrModel.created_by);
                objParam.Add("@pMessage", CheckBrModel.pMessage);

                Connection();
                VSK_BR.Open();
                List<CheckBrModel> DataList = SqlMapper.Query<CheckBrModel>(VSK_BR, "SP_CK_BR_REMARK_CREATE_IN", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();
                VSK_BR.Close();
                return DataList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Check_Br_Remark_Delete_In
        public List<CheckBrModel> Check_Br_Remark_Delete_In(CheckBrModel CheckBrModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@ref_id", CheckBrModel.ref_id);
                objParam.Add("@job_no", CheckBrModel.job_no);
                objParam.Add("@job_scan", CheckBrModel.job_scan);
                objParam.Add("@created_by", CheckBrModel.created_by);

                Connection();
                VSK_BR.Open();
                List<CheckBrModel> DataList = SqlMapper.Query<CheckBrModel>(VSK_BR, "SP_CK_BR_REMARK_DELETE_IN", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();
                VSK_BR.Close();
                return DataList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Check_Br_Qty_In
        public List<CheckBrModel> Check_Br_Qty_In(CheckBrModel CheckBrModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@ref_id", CheckBrModel.ref_id);
                objParam.Add("@job_no", CheckBrModel.job_no);
                objParam.Add("@job_scan", CheckBrModel.job_scan);
                objParam.Add("@job_qty", CheckBrModel.job_qty);
                objParam.Add("@updated_by", CheckBrModel.updated_by);

                Connection();
                VSK_BR.Open();
                List<CheckBrModel> DataList = SqlMapper.Query<CheckBrModel>(VSK_BR, "SP_CK_BR_QTY_IN", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();
                VSK_BR.Close();
                return DataList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion


        #region Check_Br_Template_Create
        public List<CheckBrModel> Check_Br_Template_Create(CheckBrModel CheckBrModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@ref_id", CheckBrModel.ref_id);
                objParam.Add("@job_date", CheckBrModel.job_date);
                objParam.Add("@job_remark", CheckBrModel.job_remark);
                objParam.Add("@created_by", CheckBrModel.created_by);

                Connection();
                VSK_BR.Open();
                List<CheckBrModel> DataList = SqlMapper.Query<CheckBrModel>(VSK_BR, "SP_CK_BR_TEMPLATE_CREATE", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();
                VSK_BR.Close();
                return DataList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Check_Br_Template_List
        public List<CheckBrModel> Check_Br_Template_List(CheckBrModel CheckBrModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@ref_id", CheckBrModel.ref_id);

                Connection();
                VSK_BR.Open();
                List<CheckBrModel> DataList = SqlMapper.Query<CheckBrModel>(VSK_BR, "SP_CK_BR_TEMPLATE_LIST", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();
                VSK_BR.Close();
                return DataList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion


        #region Check_Br_Multiple_Get_In
        public List<CheckBrDataModel> Check_Br_Multiple_Get_In(CheckBrParamGModel CheckBrParamGModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@job_round", CheckBrParamGModel.job_round);
                objParam.Add("@job_date", CheckBrParamGModel.job_date);

                Connection();
                VSK_BR.Open();
                List<CheckBrDataModel> DataList = SqlMapper.Query<CheckBrDataModel>(VSK_BR, "SP_CK_BR_MULTIPLE_GET_IN", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();
                VSK_BR.Close();
                return DataList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Check_Br_Multiple_Create_In
        public List<CheckBrDataModel> Check_Br_Multiple_Create_In(CheckBrParamCModel CheckBrParamCModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@ref_id", CheckBrParamCModel.ref_id);
                objParam.Add("@job_no", CheckBrParamCModel.job_no);
                objParam.Add("@job_round", CheckBrParamCModel.job_round);
                objParam.Add("@job_date", CheckBrParamCModel.job_date);
                objParam.Add("@job_code", CheckBrParamCModel.job_code);
                objParam.Add("@job_branch", CheckBrParamCModel.job_branch);
                objParam.Add("@job_qty", CheckBrParamCModel.job_qty);
                objParam.Add("@location_branch", CheckBrParamCModel.location_branch);
                objParam.Add("@created_by", CheckBrParamCModel.created_by);

                objParam.Add("@job_invdate", CheckBrParamCModel.job_invdate);
                objParam.Add("@job_invpo", CheckBrParamCModel.job_invpo);
                objParam.Add("@job_startdate", CheckBrParamCModel.job_startdate);
                objParam.Add("@job_invsumtt", CheckBrParamCModel.job_invsumtt);
                objParam.Add("@job_invdue", CheckBrParamCModel.job_invdue);

                Connection();
                VSK_BR.Open();
                List<CheckBrDataModel> DataList = SqlMapper.Query<CheckBrDataModel>(VSK_BR, "SP_CK_BR_MULTIPLE_CREATE_IN", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();
                VSK_BR.Close();
                return DataList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion


        // NEW IN END //

    }
}