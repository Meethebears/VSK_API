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
        public SqlConnection VSK_DEV;

        private void Connection()
        {
            VSK_DEV = new SqlConnection(ConfigurationManager.ConnectionStrings["VSK_DEV"].ToString());
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
                VSK_DEV.Open();

                List<CheckInvModel> TrpList = SqlMapper.Query<CheckInvModel>(VSK_DEV, "SP_TRP_CK_INV_CREATE", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();

                VSK_DEV.Close();
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
                VSK_DEV.Open();

                List<CheckInvModel> TrpList = SqlMapper.Query<CheckInvModel>(VSK_DEV, "SP_TRP_CK_INV_UPDATE", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();

                VSK_DEV.Close();
                return TrpList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        //public List<SlipBillModel> Slip_Delete(SlipBillModel SlipBillModel)
        //{
        //    try
        //    {

        //        DynamicParameters objParam = new DynamicParameters();

        //        objParam.Add("@ref_id", SlipBillModel.ref_id);
        //        objParam.Add("@trans_id", SlipBillModel.trans_id);
        //        objParam.Add("@updated_by", SlipBillModel.updated_by);

        //        Connection();
        //        VSK_DEV.Open();

        //        List<SlipBillModel> TrpList = SqlMapper.Query<SlipBillModel>(VSK_DEV, "SP_CA_SLIP_DELETE", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();

        //        VSK_DEV.Close();
        //        return TrpList.ToList();

        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }

        //}

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
                VSK_DEV.Open();

                List<CheckInvModel> TrpList = SqlMapper.Query<CheckInvModel>(VSK_DEV, "SP_TRP_CK_INV_LIST", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();

                VSK_DEV.Close();
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
                VSK_DEV.Open();

                List<CheckInvModel> TrpList = SqlMapper.Query<CheckInvModel>(VSK_DEV, "SP_TRP_CK_INV_DETAIL", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();

                VSK_DEV.Close();
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
                VSK_DEV.Open();

                List<ResponseSelect2Model> TrpList = SqlMapper.Query<ResponseSelect2Model>(VSK_DEV, "SP_TRP_CK_INV_MASTER", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();

                VSK_DEV.Close();
                return TrpList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
}