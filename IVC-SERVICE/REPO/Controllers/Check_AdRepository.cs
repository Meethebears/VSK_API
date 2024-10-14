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
    public class Check_AdRepository
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

        #region Check_Ad_MasterData_Out
        public List<CheckMasterDataModel> Check_Ad_Master_Data(CheckMasterDataModel CheckMasterDataModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@mode", CheckMasterDataModel.mode);
                objParam.Add("@p1", CheckMasterDataModel.p1);
                objParam.Add("@p2", CheckMasterDataModel.p2);
                objParam.Add("@p3", CheckMasterDataModel.p3);
                objParam.Add("@p4", CheckMasterDataModel.p4);
                objParam.Add("@p5", CheckMasterDataModel.p5);

                Connection();
                VSK_IVC.Open();
                List<CheckMasterDataModel> DataList = SqlMapper.Query<CheckMasterDataModel>(VSK_IVC, "SP_AD_MASTER_DATA", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();
                VSK_IVC.Close();
                return DataList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Check_Ad_List
        public List<CheckAdGetModel> Check_Ad_List(CheckAdInputModel CheckAdInputModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@trndate_start", CheckAdInputModel.trndate_start);
                objParam.Add("@trndate_end", CheckAdInputModel.trndate_end);
                objParam.Add("@action_type", CheckAdInputModel.action_type);
                objParam.Add("@job_no", CheckAdInputModel.job_no);
                objParam.Add("@job_status", CheckAdInputModel.job_status);
                objParam.Add("@job_branch", CheckAdInputModel.job_branch);
                objParam.Add("@location_branch", CheckAdInputModel.location_branch);
                objParam.Add("@created_by", CheckAdInputModel.created_by);
                objParam.Add("@pages", CheckAdInputModel.pages);
                objParam.Add("@show", CheckAdInputModel.show);

                Connection();
                VSK_IVC.Open();
                List<CheckAdGetModel> DataList = SqlMapper.Query<CheckAdGetModel>(VSK_IVC, "SP_CK_AD_LIST", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();
                VSK_IVC.Close();
                return DataList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Check_Ad_Create_Out
        public List<CheckAdGetModel> Check_Ad_Create_Out(CheckAdInputModel CheckAdInputModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@ref_id", CheckAdInputModel.ref_id);
                objParam.Add("@action_type", CheckAdInputModel.action_type);
                objParam.Add("@job_no", CheckAdInputModel.job_no);
                objParam.Add("@job_type", CheckAdInputModel.job_type);
                objParam.Add("@location_branch", CheckAdInputModel.location_branch);
                objParam.Add("@created_by", CheckAdInputModel.created_by);

                Connection();
                VSK_IVC.Open();
                List<CheckAdGetModel> DataList = SqlMapper.Query<CheckAdGetModel>(VSK_IVC, "SP_CK_AD_CREATE_OUT", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();
                VSK_IVC.Close();
                return DataList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Check_Ad_Update_Out
        public List<CheckAdGetModel> Check_Ad_Update_Out(CheckAdInputModel CheckAdInputModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@ref_id", CheckAdInputModel.ref_id);
                objParam.Add("@job_no", CheckAdInputModel.job_no);
                objParam.Add("@job_scan", CheckAdInputModel.job_scan);
                objParam.Add("@job_qty", CheckAdInputModel.job_qty);
                objParam.Add("@updated_by", CheckAdInputModel.updated_by);
                objParam.Add("@pMessage", CheckAdInputModel.pMessage);

                Connection();
                VSK_IVC.Open();
                List<CheckAdGetModel> DataList = SqlMapper.Query<CheckAdGetModel>(VSK_IVC, "SP_CK_AD_UPDATE_OUT", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();
                VSK_IVC.Close();
                return DataList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Check_Ad_Get_Out
        public List<CheckAdGetModel> Check_Ad_Get_Out(CheckAdInputModel CheckAdInputModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@job_no", CheckAdInputModel.job_no);
                objParam.Add("@ref_id", CheckAdInputModel.ref_id);
                objParam.Add("@job_status", CheckAdInputModel.job_status);
                objParam.Add("@keywords", CheckAdInputModel.keywords);
                objParam.Add("@pages", CheckAdInputModel.pages);
                objParam.Add("@show", CheckAdInputModel.show);

                Connection();
                VSK_IVC.Open();
                List<CheckAdGetModel> DataList = SqlMapper.Query<CheckAdGetModel>(VSK_IVC, "SP_CK_AD_GET_OUT", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();
                VSK_IVC.Close();
                return DataList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Check_Ad_Count_Out
        public List<CheckAdCountModel> Check_Ad_Count_Out(CheckAdInputModel CheckAdInputModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@job_no", CheckAdInputModel.job_no);
                objParam.Add("@ref_id", CheckAdInputModel.ref_id);
                objParam.Add("@job_branch", CheckAdInputModel.job_branch);

                Connection();
                VSK_IVC.Open();
                List<CheckAdCountModel> DataList = SqlMapper.Query<CheckAdCountModel>(VSK_IVC, "SP_CK_AD_COUNT_OUT", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();
                VSK_IVC.Close();
                return DataList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Check_Ad_Success_Out
        public List<CheckAdGetModel> Check_Ad_Success_Out(CheckAdInputModel CheckAdInputModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@job_no", CheckAdInputModel.job_no);
                objParam.Add("@ref_id", CheckAdInputModel.ref_id);
                objParam.Add("@updated_by", CheckAdInputModel.updated_by);


                Connection();
                VSK_IVC.Open();
                List<CheckAdGetModel> DataList = SqlMapper.Query<CheckAdGetModel>(VSK_IVC, "SP_CK_AD_SUCCESS_OUT", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();
                VSK_IVC.Close();
                return DataList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Check_Ad_Qty_Out
        public List<CheckAdGetModel> Check_Ad_Qty_Out(CheckAdInputModel CheckAdInputModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@ref_id", CheckAdInputModel.ref_id);
                objParam.Add("@job_no", CheckAdInputModel.job_no);
                objParam.Add("@job_scan", CheckAdInputModel.job_scan);
                objParam.Add("@job_qty", CheckAdInputModel.job_qty);
                objParam.Add("@updated_by", CheckAdInputModel.updated_by);

                Connection();
                VSK_IVC.Open();
                List<CheckAdGetModel> DataList = SqlMapper.Query<CheckAdGetModel>(VSK_IVC, "SP_CK_AD_QTY_OUT", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();
                VSK_IVC.Close();
                return DataList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Check_Ad_Remark_Create_Out
        public List<CheckAdGetModel> Check_Ad_Remark_Create_Out(CheckAdInputModel CheckAdInputModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@ref_id", CheckAdInputModel.ref_id);
                objParam.Add("@job_no", CheckAdInputModel.job_no);
                objParam.Add("@job_scan", CheckAdInputModel.job_scan);
                objParam.Add("@job_qty", CheckAdInputModel.job_qty);
                objParam.Add("@job_remark", CheckAdInputModel.job_remark);
                objParam.Add("@created_by", CheckAdInputModel.created_by);
                objParam.Add("@pMessage", CheckAdInputModel.pMessage);

                Connection();
                VSK_IVC.Open();
                List<CheckAdGetModel> DataList = SqlMapper.Query<CheckAdGetModel>(VSK_IVC, "SP_CK_AD_REMARK_CREATE_OUT", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();
                VSK_IVC.Close();
                return DataList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Check_Ad_Remark_Delete_Out
        public List<CheckAdGetModel> Check_Ad_Remark_Delete_Out(CheckAdInputModel CheckAdInputModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@ref_id", CheckAdInputModel.ref_id);
                objParam.Add("@job_no", CheckAdInputModel.job_no);
                objParam.Add("@job_scan", CheckAdInputModel.job_scan);
                objParam.Add("@created_by", CheckAdInputModel.created_by);

                Connection();
                VSK_IVC.Open();
                List<CheckAdGetModel> DataList = SqlMapper.Query<CheckAdGetModel>(VSK_IVC, "SP_CK_AD_REMARK_DELETE_OUT", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();
                VSK_IVC.Close();
                return DataList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion


        #region Check_Ad_Create_In
        public List<CheckAdGetModel> Check_Ad_Create_In(CheckAdInputModel CheckAdInputModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@ref_id", CheckAdInputModel.ref_id);
                objParam.Add("@action_type", CheckAdInputModel.action_type);
                objParam.Add("@job_no", CheckAdInputModel.job_no);
                objParam.Add("@job_type", CheckAdInputModel.job_type);
                objParam.Add("@location_branch", CheckAdInputModel.location_branch);
                objParam.Add("@created_by", CheckAdInputModel.created_by);

                Connection();
                VSK_IVC.Open();
                List<CheckAdGetModel> DataList = SqlMapper.Query<CheckAdGetModel>(VSK_IVC, "SP_CK_AD_CREATE_IN", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();
                VSK_IVC.Close();
                return DataList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Check_Ad_Update_In
        public List<CheckAdGetModel> Check_Ad_Update_In(CheckAdInputModel CheckAdInputModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@ref_id", CheckAdInputModel.ref_id);
                objParam.Add("@job_no", CheckAdInputModel.job_no);
                objParam.Add("@job_scan", CheckAdInputModel.job_scan);
                objParam.Add("@job_qty", CheckAdInputModel.job_qty);
                objParam.Add("@updated_by", CheckAdInputModel.updated_by);
                objParam.Add("@pMessage", CheckAdInputModel.pMessage);

                Connection();
                VSK_IVC.Open();
                List<CheckAdGetModel> DataList = SqlMapper.Query<CheckAdGetModel>(VSK_IVC, "SP_CK_AD_UPDATE_IN", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();
                VSK_IVC.Close();
                return DataList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Check_Ad_Get_In
        public List<CheckAdGetModel> Check_Ad_Get_In(CheckAdInputModel CheckAdInputModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@job_no", CheckAdInputModel.job_no);
                objParam.Add("@ref_id", CheckAdInputModel.ref_id);
                objParam.Add("@job_status", CheckAdInputModel.job_status);
                objParam.Add("@keywords", CheckAdInputModel.keywords);
                objParam.Add("@pages", CheckAdInputModel.pages);
                objParam.Add("@show", CheckAdInputModel.show);

                Connection();
                VSK_IVC.Open();
                List<CheckAdGetModel> DataList = SqlMapper.Query<CheckAdGetModel>(VSK_IVC, "SP_CK_AD_GET_IN", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();
                VSK_IVC.Close();
                return DataList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Check_Ad_Count_In
        public List<CheckAdCountModel> Check_Ad_Count_In(CheckAdInputModel CheckAdInputModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@job_no", CheckAdInputModel.job_no);
                objParam.Add("@ref_id", CheckAdInputModel.ref_id);
                objParam.Add("@job_branch", CheckAdInputModel.job_branch);

                Connection();
                VSK_IVC.Open();
                List<CheckAdCountModel> DataList = SqlMapper.Query<CheckAdCountModel>(VSK_IVC, "SP_CK_AD_COUNT_IN", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();
                VSK_IVC.Close();
                return DataList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Check_Ad_Success_In
        public List<CheckAdGetModel> Check_Ad_Success_In(CheckAdInputModel CheckAdInputModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@job_no", CheckAdInputModel.job_no);
                objParam.Add("@ref_id", CheckAdInputModel.ref_id);
                objParam.Add("@updated_by", CheckAdInputModel.updated_by);


                Connection();
                VSK_IVC.Open();
                List<CheckAdGetModel> DataList = SqlMapper.Query<CheckAdGetModel>(VSK_IVC, "SP_CK_AD_SUCCESS_IN", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();
                VSK_IVC.Close();
                return DataList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Check_Ad_Qty_In
        public List<CheckAdGetModel> Check_Ad_Qty_In(CheckAdInputModel CheckAdInputModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@ref_id", CheckAdInputModel.ref_id);
                objParam.Add("@job_no", CheckAdInputModel.job_no);
                objParam.Add("@job_scan", CheckAdInputModel.job_scan);
                objParam.Add("@job_qty", CheckAdInputModel.job_qty);
                objParam.Add("@updated_by", CheckAdInputModel.updated_by);

                Connection();
                VSK_IVC.Open();
                List<CheckAdGetModel> DataList = SqlMapper.Query<CheckAdGetModel>(VSK_IVC, "SP_CK_AD_QTY_IN", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();
                VSK_IVC.Close();
                return DataList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Check_Ad_Remark_Create_In
        public List<CheckAdGetModel> Check_Ad_Remark_Create_In(CheckAdInputModel CheckAdInputModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@ref_id", CheckAdInputModel.ref_id);
                objParam.Add("@job_no", CheckAdInputModel.job_no);
                objParam.Add("@job_scan", CheckAdInputModel.job_scan);
                objParam.Add("@job_qty", CheckAdInputModel.job_qty);
                objParam.Add("@job_remark", CheckAdInputModel.job_remark);
                objParam.Add("@created_by", CheckAdInputModel.created_by);
                objParam.Add("@pMessage", CheckAdInputModel.pMessage);

                Connection();
                VSK_IVC.Open();
                List<CheckAdGetModel> DataList = SqlMapper.Query<CheckAdGetModel>(VSK_IVC, "SP_CK_AD_REMARK_CREATE_IN", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();
                VSK_IVC.Close();
                return DataList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Check_Ad_Remark_Delete_In
        public List<CheckAdGetModel> Check_Ad_Remark_Delete_In(CheckAdInputModel CheckAdInputModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@ref_id", CheckAdInputModel.ref_id);
                objParam.Add("@job_no", CheckAdInputModel.job_no);
                objParam.Add("@job_scan", CheckAdInputModel.job_scan);
                objParam.Add("@created_by", CheckAdInputModel.created_by);

                Connection();
                VSK_IVC.Open();
                List<CheckAdGetModel> DataList = SqlMapper.Query<CheckAdGetModel>(VSK_IVC, "SP_CK_AD_REMARK_DELETE_IN", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();
                VSK_IVC.Close();
                return DataList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion


        //#region Check_Br_Create_Out
        //public List<CheckBrModel> Check_Br_Create_Out(CheckBrModel CheckBrModel)
        //{
        //    try
        //    {

        //        DynamicParameters objParam = new DynamicParameters();

        //        objParam.Add("@ref_id", CheckBrModel.ref_id);
        //        objParam.Add("@action_type", CheckBrModel.action_type);
        //        objParam.Add("@job_branch", CheckBrModel.job_branch);
        //        objParam.Add("@job_no", CheckBrModel.job_no);
        //        objParam.Add("@created_by", CheckBrModel.created_by);
        //        //objParam.Add("@pMessage", CheckBrModel.pMessage);

        //        Connection();
        //        VSK_BR.Open();
        //        List<CheckBrModel> DataList = SqlMapper.Query<CheckBrModel>(VSK_BR, "SP_CK_BR_CREATE_OUT", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();
        //        VSK_BR.Close();
        //        return DataList.ToList();

        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //}
        //#endregion

        //#region Check_Br_Update_Out
        //public List<CheckBrModel> Check_Br_Update_Out(CheckBrModel CheckBrModel)
        //{
        //    try
        //    {

        //        DynamicParameters objParam = new DynamicParameters();

        //        objParam.Add("@ref_id", CheckBrModel.ref_id);
        //        objParam.Add("@job_no", CheckBrModel.job_no);
        //        objParam.Add("@job_scan", CheckBrModel.job_scan);
        //        objParam.Add("@job_qty", CheckBrModel.job_qty);
        //        objParam.Add("@updated_by", CheckBrModel.updated_by);
        //        objParam.Add("@pMessage", CheckBrModel.pMessage);

        //        Connection();
        //        VSK_IVC.Open();
        //        List<CheckBrModel> DataList = SqlMapper.Query<CheckBrModel>(VSK_IVC, "SP_CK_BR_UPDATE_OUT", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();
        //        VSK_IVC.Close();
        //        return DataList.ToList();

        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //}
        //#endregion

        //#region Check_Br_Get_Out
        //public List<CheckBrModel> Check_Br_Get_Out(CheckBrModel CheckBrModel)
        //{
        //    try
        //    {

        //        DynamicParameters objParam = new DynamicParameters();

        //        objParam.Add("@job_no", CheckBrModel.job_no);
        //        objParam.Add("@ref_id", CheckBrModel.ref_id);
        //        objParam.Add("@job_status", CheckBrModel.job_status);
        //        objParam.Add("@keywords", CheckBrModel.keywords);
        //        objParam.Add("@pages", CheckBrModel.pages);
        //        objParam.Add("@show", CheckBrModel.show);

        //        Connection();
        //        VSK_IVC.Open();
        //        List<CheckBrModel> DataList = SqlMapper.Query<CheckBrModel>(VSK_IVC, "SP_CK_BR_GET_OUT", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();
        //        VSK_IVC.Close();
        //        return DataList.ToList();

        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //}
        //#endregion

        //#region Check_Br_Count_Out
        //public List<CheckBrModel> Check_Br_Count_Out(CheckBrModel CheckBrModel)
        //{
        //    try
        //    {

        //        DynamicParameters objParam = new DynamicParameters();

        //        objParam.Add("@job_no", CheckBrModel.job_no);
        //        objParam.Add("@ref_id", CheckBrModel.ref_id);
        //        objParam.Add("@job_branch", CheckBrModel.job_branch);

        //        Connection();
        //        VSK_IVC.Open();
        //        List<CheckBrModel> DataList = SqlMapper.Query<CheckBrModel>(VSK_IVC, "SP_CK_BR_COUNT_OUT", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();
        //        VSK_IVC.Close();
        //        return DataList.ToList();

        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //}
        //#endregion

        //#region Check_Br_Success_Out
        //public List<CheckBrModel> Check_Br_Success_Out(CheckBrModel CheckBrModel)
        //{
        //    try
        //    {

        //        DynamicParameters objParam = new DynamicParameters();

        //        objParam.Add("@job_no", CheckBrModel.job_no);
        //        objParam.Add("@ref_id", CheckBrModel.ref_id);
        //        objParam.Add("@updated_by", CheckBrModel.updated_by);

        //        Connection();
        //        VSK_IVC.Open();
        //        List<CheckBrModel> DataList = SqlMapper.Query<CheckBrModel>(VSK_IVC, "SP_CK_BR_SUCCESS_OUT", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();
        //        VSK_IVC.Close();
        //        return DataList.ToList();

        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //}
        //#endregion

        //#region Check_Br_Remark_Create_Out
        //public List<CheckBrModel> Check_Br_Remark_Create_Out(CheckBrModel CheckBrModel)
        //{
        //    try
        //    {

        //        DynamicParameters objParam = new DynamicParameters();

        //        objParam.Add("@ref_id", CheckBrModel.ref_id);
        //        objParam.Add("@job_no", CheckBrModel.job_no);
        //        objParam.Add("@job_scan", CheckBrModel.job_scan);
        //        objParam.Add("@job_qty", CheckBrModel.job_qty);
        //        objParam.Add("@job_remark", CheckBrModel.job_remark);
        //        objParam.Add("@created_by", CheckBrModel.created_by);
        //        objParam.Add("@pMessage", CheckBrModel.pMessage);

        //        Connection();
        //        VSK_IVC.Open();
        //        List<CheckBrModel> DataList = SqlMapper.Query<CheckBrModel>(VSK_IVC, "SP_CK_BR_REMARK_CREATE_OUT", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();
        //        VSK_IVC.Close();
        //        return DataList.ToList();

        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //}
        //#endregion

        //#region Check_Br_Remark_Delete_Out
        //public List<CheckBrModel> Check_Br_Remark_Delete_Out(CheckBrModel CheckBrModel)
        //{
        //    try
        //    {

        //        DynamicParameters objParam = new DynamicParameters();

        //        objParam.Add("@ref_id", CheckBrModel.ref_id);
        //        objParam.Add("@job_no", CheckBrModel.job_no);
        //        objParam.Add("@job_scan", CheckBrModel.job_scan);
        //        objParam.Add("@created_by", CheckBrModel.created_by);

        //        Connection();
        //        VSK_IVC.Open();
        //        List<CheckBrModel> DataList = SqlMapper.Query<CheckBrModel>(VSK_IVC, "SP_CK_BR_REMARK_DELETE_OUT", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();
        //        VSK_IVC.Close();
        //        return DataList.ToList();

        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //}
        //#endregion

        //#region Check_Br_Qty_Out
        //public List<CheckBrModel> Check_Br_Qty_Out(CheckBrModel CheckBrModel)
        //{
        //    try
        //    {

        //        DynamicParameters objParam = new DynamicParameters();

        //        objParam.Add("@ref_id", CheckBrModel.ref_id);
        //        objParam.Add("@job_no", CheckBrModel.job_no);
        //        objParam.Add("@job_scan", CheckBrModel.job_scan);
        //        objParam.Add("@job_qty", CheckBrModel.job_qty);
        //        objParam.Add("@updated_by", CheckBrModel.updated_by);

        //        Connection();
        //        VSK_IVC.Open();
        //        List<CheckBrModel> DataList = SqlMapper.Query<CheckBrModel>(VSK_IVC, "SP_CK_BR_QTY_OUT", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();
        //        VSK_IVC.Close();
        //        return DataList.ToList();

        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //}
        //#endregion

    }
}