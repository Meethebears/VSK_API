using Dapper;
using REPO.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace REPO.Controllers
{
    public class CheckInvRepository : Controller
    {

        #region Connection_SQL Server
        //-------------------Start Connection_SQL ------------------------//
        public SqlConnection VSK_TRP;

        private void Connection()
        {
            VSK_TRP = new SqlConnection(ConfigurationManager.ConnectionStrings["VSK_TRP_187"].ToString());
        }
        //-------------------End Connection_SQL ------------------------//
        #endregion

        public List<CheckInvModel> Trp_Ck_Inv_Create(CheckInvModel CheckInvModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@inv_number", CheckInvModel.inv_number);
                objParam.Add("@created_by", CheckInvModel.created_by);

                Connection();
                VSK_TRP.Open();

                List<CheckInvModel> TrpList = SqlMapper.Query<CheckInvModel>(VSK_TRP, "SP_TRP_CK_INV_CREATE", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();

                VSK_TRP.Close();
                return TrpList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public List<CheckInvModel> Trp_Ck_Inv_Update(CheckInvModel CheckInvModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@job_detail_qty", CheckInvModel.job_detail_qty);
                objParam.Add("@keyword", CheckInvModel.keyword);
                objParam.Add("@inv_number", CheckInvModel.inv_number);
                objParam.Add("@updated_by", CheckInvModel.updated_by);
                objParam.Add("@pMessage", CheckInvModel.pMessage);

                Connection();
                VSK_TRP.Open();

                List<CheckInvModel> TrpList = SqlMapper.Query<CheckInvModel>(VSK_TRP, "SP_TRP_CK_INV_UPDATE", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();

                VSK_TRP.Close();
                return TrpList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public List<CheckInvModel> Trp_Ck_Inv_List(CheckInvModel CheckInvModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@jobdate_start", CheckInvModel.jobdate_start);
                objParam.Add("@jobdate_end", CheckInvModel.jobdate_end);
                objParam.Add("@job_number", CheckInvModel.job_number);
                objParam.Add("@job_pk_number", CheckInvModel.job_pk_number);
                objParam.Add("@job_inv_number", CheckInvModel.job_inv_number);
                objParam.Add("@job_inv_emmas", CheckInvModel.job_inv_emmas);
                objParam.Add("@job_item_code", CheckInvModel.job_item_code);
                objParam.Add("@check_status", CheckInvModel.check_status);
                objParam.Add("@created_by", CheckInvModel.created_by);

                Connection();
                VSK_TRP.Open();

                List<CheckInvModel> TrpList = SqlMapper.Query<CheckInvModel>(VSK_TRP, "SP_TRP_CK_INV_LIST", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();

                VSK_TRP.Close();
                return TrpList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public List<CheckInvModel> Trp_Ck_Inv_Detail(CheckInvModel CheckInvModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@inv_number", CheckInvModel.inv_number);

                Connection();
                VSK_TRP.Open();

                List<CheckInvModel> TrpList = SqlMapper.Query<CheckInvModel>(VSK_TRP, "SP_TRP_CK_INV_DETAIL", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();

                VSK_TRP.Close();
                return TrpList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public List<ResponseSelect2Model> Master_Selete2(ResponseSelect2Model ResponseSelect2Model)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@mode", ResponseSelect2Model.mode);
                objParam.Add("@keywords", ResponseSelect2Model.keywords);
                objParam.Add("@keywords1", ResponseSelect2Model.keywords1);
                objParam.Add("@keywords2", ResponseSelect2Model.keywords2);
                objParam.Add("@keywords3", ResponseSelect2Model.keywords3);

                Connection();
                VSK_TRP.Open();

                List<ResponseSelect2Model> TrpList = SqlMapper.Query<ResponseSelect2Model>(VSK_TRP, "SP_TRP_CK_INV_MASTER", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();

                VSK_TRP.Close();
                return TrpList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }


        #region CK_INV_CREATE_OUT
        public List<CheckInvDataModel> CK_INV_CREATE_OUT(CheckInvInputModel CheckInvInputModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@ref_id", CheckInvInputModel.ref_id);
                objParam.Add("@location_branch", CheckInvInputModel.location_branch);
                objParam.Add("@job_branch", CheckInvInputModel.job_branch);
                objParam.Add("@job_number", CheckInvInputModel.job_number);
                objParam.Add("@created_by", CheckInvInputModel.created_by);

                Connection();
                VSK_TRP.Open();
                List<CheckInvDataModel> DataList = SqlMapper.Query<CheckInvDataModel>(VSK_TRP, "SP_CK_INV_CREATE_OUT", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();
                VSK_TRP.Close();
                return DataList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion
        #region CK_INV_UPDATE_OUT
        public List<CheckInvDataModel> CK_INV_UPDATE_OUT(CheckInvInputModel CheckInvInputModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@job_number", CheckInvInputModel.job_number);
                objParam.Add("@job_scan", CheckInvInputModel.job_scan);
                objParam.Add("@job_qty", CheckInvInputModel.job_qty);
                objParam.Add("@ref_id", CheckInvInputModel.ref_id);
                objParam.Add("@updated_by", CheckInvInputModel.updated_by);
                objParam.Add("@pMessage", CheckInvInputModel.pMessage);

                Connection();
                VSK_TRP.Open();
                List<CheckInvDataModel> DataList = SqlMapper.Query<CheckInvDataModel>(VSK_TRP, "SP_CK_INV_UPDATE_OUT", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();
                VSK_TRP.Close();
                return DataList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion
        #region CK_INV_QTY_OUT
        public List<CheckInvDataModel> CK_INV_QTY_OUT(CheckInvInputModel CheckInvInputModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@job_number", CheckInvInputModel.job_number);
                objParam.Add("@job_scan", CheckInvInputModel.job_scan);
                objParam.Add("@job_qty", CheckInvInputModel.job_qty);
                objParam.Add("@ref_id", CheckInvInputModel.ref_id);
                objParam.Add("@updated_by", CheckInvInputModel.updated_by);

                Connection();
                VSK_TRP.Open();
                List<CheckInvDataModel> DataList = SqlMapper.Query<CheckInvDataModel>(VSK_TRP, "SP_CK_INV_QTY_OUT", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();
                VSK_TRP.Close();
                return DataList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion
        #region CK_INV_GET_OUT
        public List<CheckInvDataModel> CK_INV_GET_OUT(CheckInvInputModel CheckInvInputModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@job_number", CheckInvInputModel.job_number);
                objParam.Add("@job_status", CheckInvInputModel.job_status);
                objParam.Add("@keywords", CheckInvInputModel.keywords);
                objParam.Add("@ref_id", CheckInvInputModel.ref_id);
                objParam.Add("@pages", CheckInvInputModel.pages);
                objParam.Add("@show", CheckInvInputModel.show);

                Connection();
                VSK_TRP.Open();
                List<CheckInvDataModel> DataList = SqlMapper.Query<CheckInvDataModel>(VSK_TRP, "SP_CK_INV_GET_OUT", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();
                VSK_TRP.Close();
                return DataList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion
        #region CK_INV_COUNT_OUT
        public List<CheckInvCountModel> CK_INV_COUNT_OUT(CheckInvInputModel CheckInvInputModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@job_number", CheckInvInputModel.job_number);
                objParam.Add("@job_branch", CheckInvInputModel.job_branch);
                objParam.Add("@ref_id", CheckInvInputModel.ref_id);

                Connection();
                VSK_TRP.Open();
                List<CheckInvCountModel> DataList = SqlMapper.Query<CheckInvCountModel>(VSK_TRP, "SP_CK_INV_COUNT_OUT", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();
                VSK_TRP.Close();
                return DataList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion
        #region CK_INV_SUCCESS_OUT
        public List<CheckInvDataModel> CK_INV_SUCCESS_OUT(CheckInvInputModel CheckInvInputModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@job_number", CheckInvInputModel.job_number);
                objParam.Add("@ref_id", CheckInvInputModel.ref_id);
                objParam.Add("@updated_by", CheckInvInputModel.updated_by);

                Connection();
                VSK_TRP.Open();
                List<CheckInvDataModel> DataList = SqlMapper.Query<CheckInvDataModel>(VSK_TRP, "SP_CK_INV_SUCCESS_OUT", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();
                VSK_TRP.Close();
                return DataList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion
        #region CK_INV_LIST
        public List<CheckInvDataModel> CK_INV_LIST(CheckListInputModel CheckListInputModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@mode", CheckListInputModel.mode);
                objParam.Add("@trndate_start", CheckListInputModel.trndate_start);
                objParam.Add("@trndate_end", CheckListInputModel.trndate_end);
                objParam.Add("@job_no", CheckListInputModel.job_no);
                objParam.Add("@job_number", CheckListInputModel.job_number);
                objParam.Add("@job_status", CheckListInputModel.job_status);
                objParam.Add("@location_branch", CheckListInputModel.location_branch);
                objParam.Add("@job_branch", CheckListInputModel.job_branch);
                objParam.Add("@created_by", CheckListInputModel.created_by);
                objParam.Add("@pages", CheckListInputModel.pages);
                objParam.Add("@show", CheckListInputModel.show);

                Connection();
                VSK_TRP.Open();
                List<CheckInvDataModel> DataList = SqlMapper.Query<CheckInvDataModel>(VSK_TRP, "SP_CK_INV_LIST", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();
                VSK_TRP.Close();
                return DataList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion
        #region CK_INV_VERIFY_OUT
        public List<CheckInvDataModel> CK_INV_VERIFY_OUT(CheckInvInputModel CheckInvInputModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@job_number", CheckInvInputModel.job_number);
                objParam.Add("@job_scan", CheckInvInputModel.job_scan);
                objParam.Add("@ref_id", CheckInvInputModel.ref_id);
                objParam.Add("@updated_by", CheckInvInputModel.updated_by);
                objParam.Add("@pMessage", CheckInvInputModel.pMessage);

                Connection();
                VSK_TRP.Open();
                List<CheckInvDataModel> DataList = SqlMapper.Query<CheckInvDataModel>(VSK_TRP, "SP_CK_INV_VERIFY_OUT", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();
                VSK_TRP.Close();
                return DataList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion
        #region CK_INV_MASTER
        public List<ResponseSelect2Model> CK_INV_MASTER(ResponseSelect2Model ResponseSelect2Model)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@mode", ResponseSelect2Model.mode);
                objParam.Add("@keywords", ResponseSelect2Model.keywords);
                objParam.Add("@keywords1", ResponseSelect2Model.keywords1);
                objParam.Add("@keywords2", ResponseSelect2Model.keywords2);
                objParam.Add("@keywords3", ResponseSelect2Model.keywords3);

                Connection();
                VSK_TRP.Open();
                List<ResponseSelect2Model> DataList = SqlMapper.Query<ResponseSelect2Model>(VSK_TRP, "SP_CK_INV_MASTER", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();
                VSK_TRP.Close();
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