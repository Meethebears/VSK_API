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
    public class Stock_RequestRepository
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

        #region STOCK_REQUEST_DATA_DETAIL
        public List<StockRequestModel> STOCK_REQUEST_DATA_DETAIL(StockRequestModel StockRequestModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@job_no", StockRequestModel.job_no);

                Connection();
                VSK_IVC.Open();
                List<StockRequestModel> SrList = SqlMapper.Query<StockRequestModel>(VSK_IVC, "SP_STOCK_REQUEST_DATA_DETAIL", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();
                VSK_IVC.Close();
                return SrList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region STOCK_REQUEST_DATA_CREATE
        public List<StockRequestModel> STOCK_REQUEST_DATA_CREATE(StockRequestModel StockRequestModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@job_date", StockRequestModel.job_date);
                objParam.Add("@job_branch_start", StockRequestModel.job_branch_start);
                objParam.Add("@job_branch_end", StockRequestModel.job_branch_end);
                objParam.Add("@job_user_start", StockRequestModel.job_user_start);
                objParam.Add("@job_user_end", StockRequestModel.job_user_end);
                objParam.Add("@job_status", StockRequestModel.job_status);
                objParam.Add("@created_by", StockRequestModel.created_by);
                objParam.Add("@job_remark", StockRequestModel.job_remark);
                objParam.Add("@job_type", StockRequestModel.job_type);
                objParam.Add("@job_cause", StockRequestModel.job_cause);

                Connection();
                VSK_IVC.Open();
                List<StockRequestModel> SrList = SqlMapper.Query<StockRequestModel>(VSK_IVC, "SP_STOCK_REQUEST_DATA_CREATE", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();
                VSK_IVC.Close();
                return SrList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region STOCK_REQUEST_DATA_DELETE
        public List<StockRequestModel> STOCK_REQUEST_DATA_DELETE(StockRequestModel StockRequestModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@job_no", StockRequestModel.job_no);
                objParam.Add("@job_status", StockRequestModel.job_status);
                objParam.Add("@updated_by", StockRequestModel.updated_by);

                Connection();
                VSK_IVC.Open();
                List<StockRequestModel> SrList = SqlMapper.Query<StockRequestModel>(VSK_IVC, "SP_STOCK_REQUEST_DATA_DELETE", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();
                VSK_IVC.Close();
                return SrList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region STOCK_REQUEST_DATA_UPDATE
        public List<StockRequestModel> STOCK_REQUEST_DATA_UPDATE(StockRequestModel StockRequestModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@job_no", StockRequestModel.job_no);
                objParam.Add("@job_date", StockRequestModel.job_date);
                objParam.Add("@job_branch_start", StockRequestModel.job_branch_start);
                objParam.Add("@job_branch_end", StockRequestModel.job_branch_end);
                objParam.Add("@job_user_start", StockRequestModel.job_user_start);
                objParam.Add("@job_user_end", StockRequestModel.job_user_end);
                objParam.Add("@job_user_approval", StockRequestModel.job_user_approval);
                objParam.Add("@job_status", StockRequestModel.job_status);
                objParam.Add("@updated_by", StockRequestModel.updated_by);
                objParam.Add("@job_cause", StockRequestModel.job_cause);
                objParam.Add("@job_remark", StockRequestModel.job_remark);
                objParam.Add("@job_type", StockRequestModel.job_type);

                Connection();
                VSK_IVC.Open();
                List<StockRequestModel> SrList = SqlMapper.Query<StockRequestModel>(VSK_IVC, "SP_STOCK_REQUEST_DATA_UPDATE", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();
                VSK_IVC.Close();
                return SrList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region STOCK_REQUEST_ITEM_CREATE
        public List<StockRequestModel> STOCK_REQUEST_ITEM_CREATE(StockRequestModel StockRequestModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@job_type", StockRequestModel.job_type);
                objParam.Add("@detail_ref_id", StockRequestModel.detail_ref_id);
                objParam.Add("@detail_job_no", StockRequestModel.detail_job_no);
                objParam.Add("@detail_item_code", StockRequestModel.detail_item_code);
                objParam.Add("@detail_item_name", StockRequestModel.detail_item_name);
                objParam.Add("@detail_unit", StockRequestModel.detail_unit);
                objParam.Add("@detail_qty", StockRequestModel.detail_qty);
                objParam.Add("@created_by", StockRequestModel.created_by);

                Connection();
                VSK_IVC.Open();
                List<StockRequestModel> SrList = SqlMapper.Query<StockRequestModel>(VSK_IVC, "SP_STOCK_REQUEST_ITEM_CREATE", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();
                VSK_IVC.Close();
                return SrList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region STOCK_REQUEST_ITEM_DELETE
        public List<StockRequestModel> STOCK_REQUEST_ITEM_DELETE(StockRequestModel StockRequestModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@detail_job_no", StockRequestModel.detail_job_no);
                objParam.Add("@detail_item_code", StockRequestModel.detail_item_code);
                objParam.Add("@updated_by", StockRequestModel.updated_by);

                Connection();
                VSK_IVC.Open();
                List<StockRequestModel> SrList = SqlMapper.Query<StockRequestModel>(VSK_IVC, "SP_STOCK_REQUEST_ITEM_DELETE", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();
                VSK_IVC.Close();
                return SrList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region STOCK_REQUEST_ITEM_UPDATE
        public List<StockRequestModel> STOCK_REQUEST_ITEM_UPDATE(StockRequestModel StockRequestModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@detail_job_no", StockRequestModel.detail_job_no);
                objParam.Add("@detail_item_code", StockRequestModel.detail_item_code);
                objParam.Add("@detail_incomplete_qty", StockRequestModel.detail_incomplete_qty);
                objParam.Add("@detail_incomplete_remark", StockRequestModel.detail_incomplete_remark);
                objParam.Add("@updated_by", StockRequestModel.updated_by);

                Connection();
                VSK_IVC.Open();
                List<StockRequestModel> SrList = SqlMapper.Query<StockRequestModel>(VSK_IVC, "SP_STOCK_REQUEST_ITEM_UPDATE", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();
                VSK_IVC.Close();
                return SrList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region STOCK_REQUEST_LIST
        public List<StockRequestModel> STOCK_REQUEST_LIST(StockRequestModel StockRequestModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@job_no", StockRequestModel.job_no);
                objParam.Add("@job_status", StockRequestModel.job_status);
                objParam.Add("@trndate_start", StockRequestModel.trndate_start);
                objParam.Add("@trndate_end", StockRequestModel.trndate_end);

                Connection();
                VSK_IVC.Open();
                List<StockRequestModel> SrList = SqlMapper.Query<StockRequestModel>(VSK_IVC, "SP_STOCK_REQUEST_LIST", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();
                VSK_IVC.Close();
                return SrList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region STOCK_REQUEST_LOG_LIST
        public List<StockRequestModel> STOCK_REQUEST_LOG_LIST(StockRequestModel StockRequestModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@job_no", StockRequestModel.job_no);

                Connection();
                VSK_IVC.Open();
                List<StockRequestModel> SrList = SqlMapper.Query<StockRequestModel>(VSK_IVC, "SP_STOCK_REQUEST_LOG_LIST", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();
                VSK_IVC.Close();
                return SrList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion
    }
}