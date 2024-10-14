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
    public class MB_PackingRepository : Controller
    {

        #region Connection_SQL Server
        //-------------------Start Connection_SQL ------------------------//
        public SqlConnection VSK_DATA_187;
        public SqlConnection VSK_PACKING;

        private void Connection()
        {
            VSK_DATA_187 = new SqlConnection(ConfigurationManager.ConnectionStrings["VSK_DATA_187"].ToString());
            VSK_PACKING = new SqlConnection(ConfigurationManager.ConnectionStrings["VSK_TRP_187"].ToString());
            //VSK_PACKING = new SqlConnection(ConfigurationManager.ConnectionStrings["VSK_PACKING_187"].ToString());
        }
        //-------------------End Connection_SQL ------------------------//
        #endregion

        public List<PckGetModel> PACKING_LIST_DC(PckGetModel PckGetModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@mode", PckGetModel.mode);
                objParam.Add("@job_date_start", PckGetModel.job_date_start);
                objParam.Add("@job_date_end", PckGetModel.job_date_end);
                objParam.Add("@job_no", PckGetModel.job_no);
                objParam.Add("@inv_number", PckGetModel.inv_number);
                objParam.Add("@sender_company_id", PckGetModel.sender_company_id);
                objParam.Add("@receiver_code", PckGetModel.receiver_code);
                objParam.Add("@transport_company_id", PckGetModel.transport_company_id);
                objParam.Add("@event_status", PckGetModel.event_status);
                objParam.Add("@location_branch", PckGetModel.location_branch);
                objParam.Add("@receiver_custpo", PckGetModel.receiver_custpo);
                objParam.Add("@created_by", PckGetModel.created_by);
                objParam.Add("@pages", PckGetModel.pages);
                objParam.Add("@show", PckGetModel.show);

                Connection();
                VSK_PACKING.Open();
                List<PckGetModel> PckList = SqlMapper.Query<PckGetModel>(VSK_PACKING, "SP_PACKING_LIST_DC", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();
                VSK_PACKING.Close();
                return PckList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public List<PckGetModel> PACKING_TACKING_DC(PckGetModel PckGetModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@job_no", PckGetModel.job_no);

                Connection();
                VSK_PACKING.Open();
                List<PckGetModel> PckList = SqlMapper.Query<PckGetModel>(VSK_PACKING, "SP_PACKING_TACKING_DC", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();
                VSK_PACKING.Close();
                return PckList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }


        public List<PckGetModel> PACKING_LIST_MB(PckGetModel PckGetModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@mode", PckGetModel.mode);
                objParam.Add("@job_date_start", PckGetModel.job_date_start);
                objParam.Add("@job_date_end", PckGetModel.job_date_end);
                objParam.Add("@job_no", PckGetModel.job_no);
                objParam.Add("@inv_number", PckGetModel.inv_number);
                objParam.Add("@sender_company_id", PckGetModel.sender_company_id);
                objParam.Add("@receiver_code", PckGetModel.receiver_code);
                objParam.Add("@transport_company_id", PckGetModel.transport_company_id);
                objParam.Add("@event_status", PckGetModel.event_status);
                objParam.Add("@location_branch", PckGetModel.location_branch);
                objParam.Add("@receiver_custpo", PckGetModel.receiver_custpo);
                objParam.Add("@created_by", PckGetModel.created_by);
                objParam.Add("@pages", PckGetModel.pages);
                objParam.Add("@show", PckGetModel.show);

                Connection();
                VSK_PACKING.Open();
                List<PckGetModel> PckList = SqlMapper.Query<PckGetModel>(VSK_PACKING, "SP_PACKING_LIST_MB", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();
                VSK_PACKING.Close();
                return PckList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
       
        public List<PckGetModel> PACKING_TACKING_MB(PckGetModel PckGetModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@job_no", PckGetModel.job_no);

                Connection();
                VSK_PACKING.Open();
                List<PckGetModel> PckList = SqlMapper.Query<PckGetModel>(VSK_PACKING, "SP_PACKING_TACKING_MB", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();
                VSK_PACKING.Close();
                return PckList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public List<PckGetModel> PACKING_CHECK_JOB_MB(PckInputModel PckInputModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();
                
                objParam.Add("@job_no", PckInputModel.job_no);
                //objParam.Add("@location_branch", PckInputModel.location_branch);
                objParam.Add("@job_date", PckInputModel.job_date);
                objParam.Add("@receiver_code", PckInputModel.receiver_code);
                objParam.Add("@receiver_delivery_address", PckInputModel.receiver_delivery_address);

                Connection();
                VSK_PACKING.Open();
                List<PckGetModel> PckList = SqlMapper.Query<PckGetModel>(VSK_PACKING, "SP_PACKING_CHECK_JOB_MB", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();
                VSK_PACKING.Close();
                return PckList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public List<PckCheckAddrModel> PACKING_CHECK_ADDRESS_MB(PckInputModel PckInputModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@receiver_code", PckInputModel.receiver_code);
                objParam.Add("@receiver_delivery_address", PckInputModel.receiver_delivery_address);

                Connection();
                VSK_PACKING.Open();
                List<PckCheckAddrModel> PckList = SqlMapper.Query<PckCheckAddrModel>(VSK_PACKING, "SP_PACKING_CHECK_ADDRESS_MB", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();
                VSK_PACKING.Close();
                return PckList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public List<PckGetModel> PACKING_INVOICE_DELIVERY_ADDRESS_GET_MB(PckInputModel PckInputModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@receiver_code", PckInputModel.receiver_code);

                Connection();
                VSK_PACKING.Open();
                List<PckGetModel> PckList = SqlMapper.Query<PckGetModel>(VSK_PACKING, "SP_PACKING_INVOICE_DELIVERY_ADDRESS_GET_MB", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();
                VSK_PACKING.Close();
                return PckList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public List<PckGetModel> PACKING_TRP_VENDOR_GET_MB(PckInputModel PckInputModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@mode", PckInputModel.mode);

                Connection();
                VSK_PACKING.Open();
                List<PckGetModel> PckList = SqlMapper.Query<PckGetModel>(VSK_PACKING, "SP_PACKING_TRP_VENDOR_GET_MB", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();
                VSK_PACKING.Close();
                return PckList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }


        public List<PckDataModel> PACKING_JOB_CREATE_DC(PckDataModel PckDataModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@ref_id", PckDataModel.ref_id);
                objParam.Add("@job_date", PckDataModel.job_date);
                objParam.Add("@job_round", PckDataModel.job_round);
                objParam.Add("@sender_company_id", PckDataModel.sender_company_id);
                objParam.Add("@sender_company_name", PckDataModel.sender_company_name);
                objParam.Add("@receiver_addr_id", PckDataModel.receiver_addr_id);
                objParam.Add("@receiver_code", PckDataModel.receiver_code);
                objParam.Add("@receiver_name", PckDataModel.receiver_name);
                objParam.Add("@receiver_address_name", PckDataModel.receiver_address_name);
                objParam.Add("@receiver_delivery_address", PckDataModel.receiver_delivery_address);
                objParam.Add("@receiver_delivery_evcode", PckDataModel.receiver_delivery_evcode);
                objParam.Add("@receiver_delivery_evname", PckDataModel.receiver_delivery_evname);
                objParam.Add("@receiver_delivery_tsno", PckDataModel.receiver_delivery_tsno);
                objParam.Add("@transport_company_id", PckDataModel.transport_company_id);
                objParam.Add("@payment_type_id", PckDataModel.payment_type_id);
                objParam.Add("@receiver_delivery_tumbol", PckDataModel.receiver_delivery_tumbol);
                objParam.Add("@receiver_delivery_amphur", PckDataModel.receiver_delivery_amphur);
                objParam.Add("@receiver_delivery_provinc", PckDataModel.receiver_delivery_provinc);
                objParam.Add("@receiver_delivery_zip", PckDataModel.receiver_delivery_zip);
                objParam.Add("@created_by", PckDataModel.created_by);
                objParam.Add("@location_branch", PckDataModel.location_branch);
                objParam.Add("@receiver_custpo", PckDataModel.receiver_custpo);
                objParam.Add("@inv_number", PckDataModel.inv_number);

                Connection();
                VSK_PACKING.Open();
                List<PckDataModel> PckList = SqlMapper.Query<PckDataModel>(VSK_PACKING, "SP_PACKING_JOB_CREATE_DC", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();
                VSK_PACKING.Close();
                return PckList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }


        public List<PckDataModel> PACKING_JOB_CREATE_MB(PckDataModel PckDataModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@ref_id", PckDataModel.ref_id);
                objParam.Add("@job_date", PckDataModel.job_date);
                objParam.Add("@job_round", PckDataModel.job_round);
                objParam.Add("@sender_company_id", PckDataModel.sender_company_id);
                objParam.Add("@sender_company_name", PckDataModel.sender_company_name);
                objParam.Add("@receiver_addr_id", PckDataModel.receiver_addr_id);
                objParam.Add("@receiver_code", PckDataModel.receiver_code);
                objParam.Add("@receiver_name", PckDataModel.receiver_name);
                objParam.Add("@receiver_address_name", PckDataModel.receiver_address_name);
                objParam.Add("@receiver_delivery_address", PckDataModel.receiver_delivery_address);
                objParam.Add("@receiver_delivery_evcode", PckDataModel.receiver_delivery_evcode);
                objParam.Add("@receiver_delivery_evname", PckDataModel.receiver_delivery_evname);
                objParam.Add("@receiver_delivery_tsno", PckDataModel.receiver_delivery_tsno);
                objParam.Add("@transport_company_id", PckDataModel.transport_company_id);
                objParam.Add("@payment_type_id", PckDataModel.payment_type_id);
                objParam.Add("@receiver_delivery_tumbol", PckDataModel.receiver_delivery_tumbol);
                objParam.Add("@receiver_delivery_amphur", PckDataModel.receiver_delivery_amphur);
                objParam.Add("@receiver_delivery_provinc", PckDataModel.receiver_delivery_provinc);
                objParam.Add("@receiver_delivery_zip", PckDataModel.receiver_delivery_zip);
                objParam.Add("@created_by", PckDataModel.created_by);
                objParam.Add("@location_branch", PckDataModel.location_branch);
                objParam.Add("@receiver_custpo", PckDataModel.receiver_custpo);
                objParam.Add("@inv_number", PckDataModel.inv_number);

                Connection();
                VSK_PACKING.Open();
                List<PckDataModel> PckList = SqlMapper.Query<PckDataModel>(VSK_PACKING, "SP_PACKING_JOB_CREATE_MB", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();
                VSK_PACKING.Close();
                return PckList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public List<PckGetModel> PACKING_JOB_DETAIL_MB(PckInputModel PckInputModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@ref_id", PckInputModel.ref_id);

                Connection();
                VSK_PACKING.Open();
                List<PckGetModel> PckList = SqlMapper.Query<PckGetModel>(VSK_PACKING, "SP_PACKING_JOB_DETAIL_MB", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();
                VSK_PACKING.Close();
                return PckList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public List<PckDataModel> PACKING_JOB_PAYMENT_TYPE_UPDATE_MB(PckDataModel PckDataModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@ref_id", PckDataModel.ref_id);
                objParam.Add("@payment_type_id", PckDataModel.payment_type_id);

                Connection();
                VSK_PACKING.Open();
                List<PckDataModel> PckList = SqlMapper.Query<PckDataModel>(VSK_PACKING, "SP_PACKING_JOB_PAYMENT_TYPE_UPDATE_MB", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();
                VSK_PACKING.Close();
                return PckList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public List<PckDataModel> PACKING_JOB_TRANSPORT_COMPANY_UPDATE_MB(PckDataModel PckDataModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@ref_id", PckDataModel.ref_id);
                objParam.Add("@transport_company_id", PckDataModel.transport_company_id);

                Connection();
                VSK_PACKING.Open();
                List<PckDataModel> PckList = SqlMapper.Query<PckDataModel>(VSK_PACKING, "SP_PACKING_JOB_TRANSPORT_COMPANY_UPDATE_MB", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();
                VSK_PACKING.Close();
                return PckList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public List<PckDataModel> PACKING_JOB_INFORMATION_STATUS_UPDATE_MB(PckDataModel PckDataModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@ref_id", PckDataModel.ref_id);

                Connection();
                VSK_PACKING.Open();
                List<PckDataModel> PckList = SqlMapper.Query<PckDataModel>(VSK_PACKING, "SP_PACKING_JOB_INFORMATION_STATUS_UPDATE_MB", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();
                VSK_PACKING.Close();
                return PckList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public List<PckGetModel> PACKING_JOB_DELETE_MB(PckGetModel PckGetModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@ref_id", PckGetModel.ref_id);
                objParam.Add("@job_remark", PckGetModel.job_remark);
                objParam.Add("@deleted_by", PckGetModel.deleted_by);

                Connection();
                VSK_PACKING.Open();
                List<PckGetModel> PckList = SqlMapper.Query<PckGetModel>(VSK_PACKING, "SP_PACKING_JOB_DELETE_MB", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();
                VSK_PACKING.Close();
                return PckList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }


        public List<PckInvModel> PACKING_INVOICE_CREATE_MB(PckInvModel PckInvModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@ref_id", PckInvModel.ref_id);
                objParam.Add("@job_no", PckInvModel.job_no);
                objParam.Add("@inv_number", PckInvModel.inv_number);
                objParam.Add("@inv_date", PckInvModel.inv_date);
                objParam.Add("@inv_po", PckInvModel.inv_po);
                objParam.Add("@inv_code", PckInvModel.inv_code);
                objParam.Add("@inv_name", PckInvModel.inv_name);
                objParam.Add("@inv_item", PckInvModel.inv_item);
                objParam.Add("@inv_trans", PckInvModel.inv_trans);
                objParam.Add("@inv_due", PckInvModel.inv_due);
                objParam.Add("@inv_paycash", PckInvModel.inv_paycash);
                objParam.Add("@inv_paytran", PckInvModel.inv_paytran);
                objParam.Add("@inv_paycard", PckInvModel.inv_paycard);
                objParam.Add("@inv_payoth", PckInvModel.inv_payoth);
                objParam.Add("@inv_sumtt", PckInvModel.inv_sumtt);
                objParam.Add("@inv_toption", PckInvModel.inv_toption);
                objParam.Add("@inv_descript", PckInvModel.inv_descript);
                objParam.Add("@inv_startdate", PckInvModel.inv_startdate);
                objParam.Add("@inv_kline", PckInvModel.inv_kline);
                objParam.Add("@inv_branch", PckInvModel.inv_branch);
                objParam.Add("@inv_custpo", PckInvModel.inv_custpo);
                objParam.Add("@inv_userid", PckInvModel.inv_userid);
                objParam.Add("@inv_pkuser", PckInvModel.inv_pkuser);
                objParam.Add("@created_by", PckInvModel.created_by);

                Connection();
                VSK_PACKING.Open();
                List<PckInvModel> PckList = SqlMapper.Query<PckInvModel>(VSK_PACKING, "SP_PACKING_INVOICE_CREATE_MB", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();
                VSK_PACKING.Close();
                return PckList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public List<PckInvModel> PACKING_INVOICE_LIST_MB(PckInvModel PckInvModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@ref_id", PckInvModel.ref_id);

                Connection();
                VSK_PACKING.Open();
                List<PckInvModel> PckList = SqlMapper.Query<PckInvModel>(VSK_PACKING, "SP_PACKING_INVOICE_LIST_MB", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();
                VSK_PACKING.Close();
                return PckList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public List<PckInvModel> PACKING_INVOICE_VERIFY_MB(PckInvModel PckInvModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@ref_id", PckInvModel.ref_id);
                objParam.Add("@job_scan", PckInvModel.job_scan);
                objParam.Add("@job_number", PckInvModel.job_number);
                objParam.Add("@updated_by", PckInvModel.updated_by);
                objParam.Add("@pMessage", PckInvModel.pMessage);

                Connection();
                VSK_PACKING.Open();
                List<PckInvModel> PckList = SqlMapper.Query<PckInvModel>(VSK_PACKING, "SP_PACKING_INVOICE_VERIFY_MB", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();
                VSK_PACKING.Close();
                return PckList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public List<PckInvModel> PACKING_INVOICE_DELETE_MB(PckInvModel PckInvModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@ref_id", PckInvModel.ref_id);
                objParam.Add("@inv_number", PckInvModel.inv_number);
                objParam.Add("@updated_by", PckInvModel.updated_by);

                Connection();
                VSK_PACKING.Open();
                List<PckInvModel> PckList = SqlMapper.Query<PckInvModel>(VSK_PACKING, "SP_PACKING_INVOICE_DELETE_MB", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();
                VSK_PACKING.Close();
                return PckList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }


        public List<PckItemModel> PACKING_ITEM_CREATE_MB(PckItemModel PckItemModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@ref_id", PckItemModel.ref_id);
                objParam.Add("@job_no", PckItemModel.job_no);
                objParam.Add("@created_by", PckItemModel.created_by);

                Connection();
                VSK_PACKING.Open();
                List<PckItemModel> PckList = SqlMapper.Query<PckItemModel>(VSK_PACKING, "SP_PACKING_ITEM_CREATE_MB", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();
                VSK_PACKING.Close();
                return PckList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public List<PckItemModel> PACKING_ITEM_GET_MB(PckItemModel PckItemModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@ref_id", PckItemModel.ref_id);
                objParam.Add("@job_no", PckItemModel.job_no);
                objParam.Add("@job_status", PckItemModel.job_status);
                objParam.Add("@keywords", PckItemModel.keywords);
                objParam.Add("@pages", PckItemModel.pages);
                objParam.Add("@show", PckItemModel.show);

                Connection();
                VSK_PACKING.Open();
                List<PckItemModel> PckList = SqlMapper.Query<PckItemModel>(VSK_PACKING, "SP_PACKING_ITEM_GET_MB", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();
                VSK_PACKING.Close();
                return PckList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public List<PckItemModel> PACKING_ITEM_COUNT_MB(PckItemModel PckItemModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@ref_id", PckItemModel.ref_id);
                objParam.Add("@job_no", PckItemModel.job_no);

                Connection();
                VSK_PACKING.Open();
                List<PckItemModel> PckList = SqlMapper.Query<PckItemModel>(VSK_PACKING, "SP_PACKING_ITEM_COUNT_MB", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();
                VSK_PACKING.Close();
                return PckList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public List<PckItemModel> PACKING_ITEM_UPDATE_MB(PckItemModel PckItemModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@ref_id", PckItemModel.ref_id);
                objParam.Add("@job_no", PckItemModel.job_no);
                objParam.Add("@job_qty", PckItemModel.job_qty);
                objParam.Add("@job_scan", PckItemModel.job_scan);
                objParam.Add("@updated_by", PckItemModel.updated_by);
                objParam.Add("@pMessage", PckItemModel.pMessage);

                Connection();
                VSK_PACKING.Open();
                List<PckItemModel> PckList = SqlMapper.Query<PckItemModel>(VSK_PACKING, "SP_PACKING_ITEM_UPDATE_MB", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();
                VSK_PACKING.Close();
                return PckList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public List<PckItemModel> PACKING_ITEM_SUCCESS_MB(PckItemModel PckItemModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@ref_id", PckItemModel.ref_id);
                objParam.Add("@job_no", PckItemModel.job_no);
                objParam.Add("@updated_by", PckItemModel.updated_by);

                Connection();
                VSK_PACKING.Open();
                List<PckItemModel> PckList = SqlMapper.Query<PckItemModel>(VSK_PACKING, "SP_PACKING_ITEM_SUCCESS_MB", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();
                VSK_PACKING.Close();
                return PckList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }


        public List<PckMasterModel> PACKING_BOX_GET_MB(PckMasterModel PckMasterModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@mode", PckMasterModel.mode);
                objParam.Add("@keywords", PckMasterModel.keywords);

                Connection();
                VSK_PACKING.Open();
                List<PckMasterModel> PckList = SqlMapper.Query<PckMasterModel>(VSK_PACKING, "SP_PACKING_BOX_GET_MB", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();
                VSK_PACKING.Close();
                return PckList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public List<PckBoxModel> PACKING_BOX_CREATE_MB_V1(PckBoxModel PckBoxModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@ref_id", PckBoxModel.ref_id);
                objParam.Add("@job_no", PckBoxModel.job_no);
                objParam.Add("@created_by", PckBoxModel.created_by);

                Connection();
                VSK_PACKING.Open();
                List<PckBoxModel> PckList = SqlMapper.Query<PckBoxModel>(VSK_PACKING, "SP_PACKING_BOX_CREATE_MB", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();
                VSK_PACKING.Close();
                return PckList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public void PACKING_BOX_CREATE_MB(List<PckBoxModel> PckBoxModel)
        {

            try
            {

                Connection();

                VSK_PACKING.Open();

                foreach (var ImportDataArrayData in PckBoxModel)
                {
                    DynamicParameters objParam = new DynamicParameters();


                    objParam.Add("@ref_id", ImportDataArrayData.ref_id);
                    objParam.Add("@job_no", ImportDataArrayData.job_no);
                    objParam.Add("@box_id", ImportDataArrayData.box_id);
                    objParam.Add("@box_qty", ImportDataArrayData.box_qty);
                    objParam.Add("@created_by", ImportDataArrayData.created_by);
                    //objParam.Add("@share_box_trans_id", ImportDataArrayData.share_box_trans_id);
                    //objParam.Add("@share_ref_box_ref_id", ImportDataArrayData.share_ref_box_ref_id);

                    VSK_PACKING.Execute("SP_PACKING_BOX_CREATE_MB", objParam, commandTimeout: 600, commandType: CommandType.StoredProcedure);

                }

                VSK_PACKING.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<PckBoxModel> PACKING_BOX_DETAIL_MB(PckBoxModel PckBoxModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@ref_id", PckBoxModel.ref_id);
                objParam.Add("@job_no", PckBoxModel.job_no);
                Connection();
                VSK_PACKING.Open();
                List<PckBoxModel> PckList = SqlMapper.Query<PckBoxModel>(VSK_PACKING, "SP_PACKING_BOX_DETAIL_MB", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();
                VSK_PACKING.Close();
                return PckList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public void PACKING_BOX_UPDATE_MB(List<PckBoxModel> PckBoxModel)
        {

            try
            {

                Connection();

                VSK_PACKING.Open();

                foreach (var ImportDataArrayData in PckBoxModel)
                {
                    DynamicParameters objParam = new DynamicParameters();


                    objParam.Add("@ref_id", ImportDataArrayData.ref_id);
                    objParam.Add("@job_no", ImportDataArrayData.job_no);
                    objParam.Add("@box_id", ImportDataArrayData.box_id);
                    objParam.Add("@box_qty", ImportDataArrayData.box_qty);
                    objParam.Add("@updated_by", ImportDataArrayData.updated_by);

                    VSK_PACKING.Execute("SP_PACKING_BOX_UPDATE_MB", objParam, commandTimeout: 600, commandType: CommandType.StoredProcedure);

                }

                VSK_PACKING.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<PckBoxModel> PACKING_BOX_SUCCESS_MB(PckBoxModel PckBoxModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@ref_id", PckBoxModel.ref_id);
                objParam.Add("@job_no", PckBoxModel.job_no);
                objParam.Add("@updated_by", PckBoxModel.updated_by);

                Connection();
                VSK_PACKING.Open();
                List<PckBoxModel> PckList = SqlMapper.Query<PckBoxModel>(VSK_PACKING, "SP_PACKING_BOX_SUCCESS_MB", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();
                VSK_PACKING.Close();
                return PckList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public List<PckBoxModel> PACKING_BOX_DELETE_MB(PckBoxModel PckBoxModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@ref_id", PckBoxModel.ref_id);
                objParam.Add("@job_no", PckBoxModel.job_no);
                objParam.Add("@updated_by", PckBoxModel.updated_by);

                Connection();
                VSK_PACKING.Open();
                List<PckBoxModel> PckList = SqlMapper.Query<PckBoxModel>(VSK_PACKING, "SP_PACKING_BOX_DELETE_MB", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();
                VSK_PACKING.Close();
                return PckList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }


        public List<PckGetModel> PACKING_BOX_SHARE_GET_MB(PckGetModel PckGetModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@receiver_code", PckGetModel.receiver_code);
                objParam.Add("@receiver_delivery_address", PckGetModel.receiver_delivery_address);

                Connection();
                VSK_PACKING.Open();
                List<PckGetModel> PckList = SqlMapper.Query<PckGetModel>(VSK_PACKING, "SP_PACKING_BOX_SHARE_GET_MB", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();
                VSK_PACKING.Close();
                return PckList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public void PACKING_BOX_SHARE_CREATE_MB(List<PckBoxModel> PckBoxModel)
        {

            try
            {

                Connection();

                VSK_PACKING.Open();

                foreach (var ImportDataArrayData in PckBoxModel)
                {
                    DynamicParameters objParam = new DynamicParameters();


                    objParam.Add("@ref_id", ImportDataArrayData.ref_id);
                    objParam.Add("@job_no", ImportDataArrayData.job_no);
                    objParam.Add("@box_id", ImportDataArrayData.box_id);
                    objParam.Add("@box_qty", ImportDataArrayData.box_qty);
                    objParam.Add("@created_by", ImportDataArrayData.created_by);
                    objParam.Add("@share_box_trans_id", ImportDataArrayData.share_box_trans_id);
                    objParam.Add("@share_ref_box_ref_id", ImportDataArrayData.share_ref_box_ref_id);

                    VSK_PACKING.Execute("SP_PACKING_BOX_SHARE_CREATE_MB", objParam, commandTimeout: 600, commandType: CommandType.StoredProcedure);

                }

                VSK_PACKING.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public List<PckRemarkModel> PACKING_REMARK_LIST_MB(PckRemarkModel PckRemarkModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@ref_id", PckRemarkModel.ref_id);
                objParam.Add("@job_no", PckRemarkModel.job_no);
                objParam.Add("@remark_type", PckRemarkModel.remark_type);

                Connection();
                VSK_PACKING.Open();
                List<PckRemarkModel> PckList = SqlMapper.Query<PckRemarkModel>(VSK_PACKING, "SP_PACKING_REMARK_LIST_MB", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();
                VSK_PACKING.Close();
                return PckList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<PckRemarkModel> PACKING_REMARK_CREATE_MB(PckRemarkModel PckRemarkModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@ref_id", PckRemarkModel.ref_id);
                objParam.Add("@job_no", PckRemarkModel.job_no);
                objParam.Add("@remark_type", PckRemarkModel.remark_type);
                objParam.Add("@remark_text", PckRemarkModel.remark_text);
                objParam.Add("@created_by", PckRemarkModel.created_by);

                Connection();
                VSK_PACKING.Open();
                List<PckRemarkModel> PckList = SqlMapper.Query<PckRemarkModel>(VSK_PACKING, "SP_PACKING_REMARK_CREATE_MB", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();
                VSK_PACKING.Close();
                return PckList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public List<PckRemarkModel> PACKING_REMARK_DELETE_MB(PckRemarkModel PckRemarkModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@trans_id", PckRemarkModel.trans_id);
                objParam.Add("@updated_by", PckRemarkModel.updated_by);

                Connection();
                VSK_PACKING.Open();
                List<PckRemarkModel> PckList = SqlMapper.Query<PckRemarkModel>(VSK_PACKING, "SP_PACKING_REMARK_DELETE_MB", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();
                VSK_PACKING.Close();
                return PckList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }


        public List<PckLoadingModel> PACKING_LOADING_CHECK_MB(PckLoadingModel PckLoadingModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@job_round", PckLoadingModel.job_round);
                objParam.Add("@job_date", PckLoadingModel.job_date);

                Connection();
                VSK_PACKING.Open();
                List<PckLoadingModel> PckList = SqlMapper.Query<PckLoadingModel>(VSK_PACKING, "SP_PACKING_LOADING_CHECK_MB", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();
                VSK_PACKING.Close();
                return PckList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public List<PckLoadingModel> PACKING_LOADING_GET_MB(PckLoadingModel PckLoadingModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@ref_id", PckLoadingModel.ref_id);
                objParam.Add("@job_no", PckLoadingModel.job_no);
                objParam.Add("@mode", PckLoadingModel.mode);

                Connection();
                VSK_PACKING.Open();
                List<PckLoadingModel> PckList = SqlMapper.Query<PckLoadingModel>(VSK_PACKING, "SP_PACKING_LOADING_GET_MB", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();
                VSK_PACKING.Close();
                return PckList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public List<PckLoadingModel> PACKING_LOADING_CREATE_MB(PckLoadingModel PckLoadingModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@job_scan", PckLoadingModel.job_scan);
                objParam.Add("@job_round", PckLoadingModel.job_round);
                objParam.Add("@job_date", PckLoadingModel.job_date);
                objParam.Add("@ref_id", PckLoadingModel.ref_id);
                objParam.Add("@created_by", PckLoadingModel.created_by);
                objParam.Add("@pMessage", PckLoadingModel.pMessage);

                Connection();
                VSK_PACKING.Open();
                List<PckLoadingModel> PckList = SqlMapper.Query<PckLoadingModel>(VSK_PACKING, "SP_PACKING_LOADING_CREATE_MB", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();
                VSK_PACKING.Close();
                return PckList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public List<PckLoadingModel> PACKING_LOADING_TMS_LIST_MB(PckLoadingModel PckLoadingModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@ref_id", PckLoadingModel.ref_id);

                Connection();
                VSK_PACKING.Open();
                List<PckLoadingModel> PckList = SqlMapper.Query<PckLoadingModel>(VSK_PACKING, "SP_PACKING_LOADING_TMS_LIST_MB", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();
                VSK_PACKING.Close();
                return PckList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public List<PckLoadingModel> PACKING_LOADING_UPDATE_MB(PckLoadingModel PckLoadingModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@ref_id", PckLoadingModel.ref_id);
                objParam.Add("@delivery_ref_id", PckLoadingModel.delivery_ref_id);
                objParam.Add("@mode", PckLoadingModel.mode);
                objParam.Add("@updated_by", PckLoadingModel.updated_by);

                Connection();
                VSK_PACKING.Open();
                List<PckLoadingModel> PckList = SqlMapper.Query<PckLoadingModel>(VSK_PACKING, "SP_PACKING_LOADING_UPDATE_MB", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();
                VSK_PACKING.Close();
                return PckList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public List<PckLoadingModel> PACKING_LOADING_DELETE_MB(PckLoadingModel PckLoadingModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@ref_id", PckLoadingModel.ref_id);
                objParam.Add("@trans_id", PckLoadingModel.trans_id);
                objParam.Add("@updated_by", PckLoadingModel.updated_by);

                Connection();
                VSK_PACKING.Open();
                List<PckLoadingModel> PckList = SqlMapper.Query<PckLoadingModel>(VSK_PACKING, "SP_PACKING_LOADING_DELETE_MB", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();
                VSK_PACKING.Close();
                return PckList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public List<PckLoadingModel> PACKING_LOADING_LIST_MB(PckLoadingModel PckLoadingModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@job_date_start", PckLoadingModel.job_date_start);
                objParam.Add("@job_date_end", PckLoadingModel.job_date_end);
                objParam.Add("@job_round", PckLoadingModel.job_round);
                objParam.Add("@event_status", PckLoadingModel.event_status);

                Connection();
                VSK_PACKING.Open();
                List<PckLoadingModel> PckList = SqlMapper.Query<PckLoadingModel>(VSK_PACKING, "SP_PACKING_LOADING_LIST_MB", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();
                VSK_PACKING.Close();
                return PckList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public List<PckGetModel> PACKING_LOADING_COVER_SHEET_MB(PckGetModel PckGetModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@job_no", PckGetModel.job_no);

                Connection();
                VSK_PACKING.Open();
                List<PckGetModel> PckList = SqlMapper.Query<PckGetModel>(VSK_PACKING, "SP_PACKING_LOADING_COVER_SHEET_MB", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();
                VSK_PACKING.Close();
                return PckList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public List<PckLoadingModel> PACKING_LOADING_DELIVERY_LIST_MB(PckLoadingModel PckLoadingModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@ref_id", PckLoadingModel.ref_id);

                Connection();
                VSK_PACKING.Open();
                List<PckLoadingModel> PckList = SqlMapper.Query<PckLoadingModel>(VSK_PACKING, "SP_PACKING_LOADING_DELIVERY_LIST_MB", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();
                VSK_PACKING.Close();
                return PckList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public List<PckLoadingModel> PACKING_TMS_GET_MB(PckLoadingModel PckLoadingModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@ref_id", PckLoadingModel.ref_id);

                Connection();
                VSK_PACKING.Open();
                List<PckLoadingModel> PckList = SqlMapper.Query<PckLoadingModel>(VSK_PACKING, "SP_PACKING_TMS_GET_MB", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();
                VSK_PACKING.Close();
                return PckList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

       
        public List<ResponseSelect2Model> PACKING_MASTER(ResponseSelect2Model ResponseSelect2Model)
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
                VSK_PACKING.Open();

                List<ResponseSelect2Model> PckList = SqlMapper.Query<ResponseSelect2Model>(VSK_PACKING, "SP_PACKING_MASTER", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();

                VSK_PACKING.Close();
                return PckList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

    }

}