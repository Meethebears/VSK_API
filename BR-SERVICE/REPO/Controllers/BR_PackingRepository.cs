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
    public class BR_PackingRepository : Controller
    {

        #region Connection_SQL Server
        //-------------------Start Connection_SQL ------------------------//
        public SqlConnection VSK_DATA_187;
        public SqlConnection VSK_PACKING;

        private void Connection()
        {
            VSK_DATA_187 = new SqlConnection(ConfigurationManager.ConnectionStrings["VSK_DATA_187"].ToString());
            VSK_PACKING = new SqlConnection(ConfigurationManager.ConnectionStrings["VSK_BR_187"].ToString());
            //VSK_PACKING = new SqlConnection(ConfigurationManager.ConnectionStrings["VSK_PACKING_187"].ToString());
        }
        //-------------------End Connection_SQL ------------------------//
        #endregion

        public List<PbrGetModel> PACKING_LIST_DC(PbrGetModel PbrGetModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@mode", PbrGetModel.mode);
                objParam.Add("@job_date_start", PbrGetModel.job_date_start);
                objParam.Add("@job_date_end", PbrGetModel.job_date_end);
                objParam.Add("@job_no", PbrGetModel.job_no);
                objParam.Add("@inv_number", PbrGetModel.inv_number);
                objParam.Add("@sender_company_id", PbrGetModel.sender_company_id);
                objParam.Add("@receiver_code", PbrGetModel.receiver_code);
                objParam.Add("@transport_company_id", PbrGetModel.transport_company_id);
                objParam.Add("@event_status", PbrGetModel.event_status);
                objParam.Add("@location_branch", PbrGetModel.location_branch);
                objParam.Add("@receiver_custpo", PbrGetModel.receiver_custpo);
                objParam.Add("@created_by", PbrGetModel.created_by);
                objParam.Add("@pages", PbrGetModel.pages);
                objParam.Add("@show", PbrGetModel.show);

                Connection();
                VSK_PACKING.Open();
                List<PbrGetModel> PbrList = SqlMapper.Query<PbrGetModel>(VSK_PACKING, "SP_PACKING_LIST_DC", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();
                VSK_PACKING.Close();
                return PbrList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public List<PbrGetModel> PACKING_TACKING_DC(PbrGetModel PbrGetModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@job_no", PbrGetModel.job_no);

                Connection();
                VSK_PACKING.Open();
                List<PbrGetModel> PbrList = SqlMapper.Query<PbrGetModel>(VSK_PACKING, "SP_PACKING_TACKING_DC", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();
                VSK_PACKING.Close();
                return PbrList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }


        public List<PbrGetModel> PACKING_LIST_BR(PbrGetModel PbrGetModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@mode", PbrGetModel.mode);
                objParam.Add("@job_date_start", PbrGetModel.job_date_start);
                objParam.Add("@job_date_end", PbrGetModel.job_date_end);
                objParam.Add("@job_no", PbrGetModel.job_no);
                objParam.Add("@inv_number", PbrGetModel.inv_number);
                objParam.Add("@sender_company_id", PbrGetModel.sender_company_id);
                objParam.Add("@receiver_code", PbrGetModel.receiver_code);
                objParam.Add("@transport_company_id", PbrGetModel.transport_company_id);
                objParam.Add("@event_status", PbrGetModel.event_status);
                objParam.Add("@location_branch", PbrGetModel.location_branch);
                objParam.Add("@receiver_custpo", PbrGetModel.receiver_custpo);
                objParam.Add("@created_by", PbrGetModel.created_by);
                objParam.Add("@pages", PbrGetModel.pages);
                objParam.Add("@show", PbrGetModel.show);

                Connection();
                VSK_PACKING.Open();
                List<PbrGetModel> PbrList = SqlMapper.Query<PbrGetModel>(VSK_PACKING, "SP_PACKING_LIST_BR", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();
                VSK_PACKING.Close();
                return PbrList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public List<PbrGetModel> PACKING_TACKING_BR(PbrGetModel PbrGetModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@job_no", PbrGetModel.job_no);

                Connection();
                VSK_PACKING.Open();
                List<PbrGetModel> PbrList = SqlMapper.Query<PbrGetModel>(VSK_PACKING, "SP_PACKING_TACKING_BR", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();
                VSK_PACKING.Close();
                return PbrList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }


        public List<PbrCheckAddrModel> PACKING_CHECK_ADDRESS_BR(PbrInputModel PbrInputModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@receiver_code", PbrInputModel.receiver_code);
                objParam.Add("@receiver_delivery_address", PbrInputModel.receiver_delivery_address);

                Connection();
                VSK_PACKING.Open();
                List<PbrCheckAddrModel> PbrList = SqlMapper.Query<PbrCheckAddrModel>(VSK_PACKING, "SP_PACKING_CHECK_ADDRESS_BR", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();
                VSK_PACKING.Close();
                return PbrList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public List<PbrGetModel> PACKING_INVOICE_DELIVERY_ADDRESS_GET_BR(PbrInputModel PbrInputModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@receiver_code", PbrInputModel.receiver_code);

                Connection();
                VSK_PACKING.Open();
                List<PbrGetModel> PbrList = SqlMapper.Query<PbrGetModel>(VSK_PACKING, "SP_PACKING_INVOICE_DELIVERY_ADDRESS_GET_BR", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();
                VSK_PACKING.Close();
                return PbrList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public List<PbrGetModel> PACKING_TRP_VENDOR_GET_BR(PbrInputModel PbrInputModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@mode", PbrInputModel.mode);

                Connection();
                VSK_PACKING.Open();
                List<PbrGetModel> PbrList = SqlMapper.Query<PbrGetModel>(VSK_PACKING, "SP_PACKING_TRP_VENDOR_GET_BR", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();
                VSK_PACKING.Close();
                return PbrList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }


        public List<PbrGetModel> PACKING_CHECK_JOB_BR(PbrInputModel PbrInputModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@job_no", PbrInputModel.job_no);
                objParam.Add("@job_date", PbrInputModel.job_date);
                objParam.Add("@receiver_code", PbrInputModel.receiver_code);
                objParam.Add("@receiver_type", PbrInputModel.receiver_type);
                objParam.Add("@location_branch", PbrInputModel.location_branch);

                Connection();
                VSK_PACKING.Open();
                List<PbrGetModel> PbrList = SqlMapper.Query<PbrGetModel>(VSK_PACKING, "SP_PACKING_CHECK_JOB_BR", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();
                VSK_PACKING.Close();
                return PbrList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public List<PbrGetModel> PACKING_CHECK_INVOICE_BR(PbrInputModel PbrInputModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@inv_number", PbrInputModel.inv_number);
                objParam.Add("@location_branch", PbrInputModel.location_branch);

                Connection();
                VSK_PACKING.Open();
                List<PbrGetModel> PbrList = SqlMapper.Query<PbrGetModel>(VSK_PACKING, "SP_PACKING_CHECK_INVOICE_BR", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();
                VSK_PACKING.Close();
                return PbrList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public List<PbrDataModel> PACKING_JOB_CREATE_BR(PbrDataModel PbrDataModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@ref_id", PbrDataModel.ref_id);
                objParam.Add("@job_date", PbrDataModel.job_date);
                objParam.Add("@job_round", PbrDataModel.job_round);
                objParam.Add("@sender_company_id", PbrDataModel.sender_company_id);
                objParam.Add("@sender_company_code", PbrDataModel.sender_company_code);
                objParam.Add("@sender_company_name", PbrDataModel.sender_company_name);
                objParam.Add("@receiver_addr_id", PbrDataModel.receiver_addr_id);
                objParam.Add("@receiver_id", PbrDataModel.receiver_id);
                objParam.Add("@receiver_code", PbrDataModel.receiver_code);
                objParam.Add("@receiver_name", PbrDataModel.receiver_name);
                objParam.Add("@receiver_address_name", PbrDataModel.receiver_address_name);
                objParam.Add("@receiver_delivery_address", PbrDataModel.receiver_delivery_address);
                objParam.Add("@receiver_delivery_evcode", PbrDataModel.receiver_delivery_evcode);
                objParam.Add("@receiver_delivery_evname", PbrDataModel.receiver_delivery_evname);
                objParam.Add("@receiver_delivery_tsno", PbrDataModel.receiver_delivery_tsno);
                objParam.Add("@receiver_type", PbrDataModel.receiver_type);
                objParam.Add("@transport_company_id", PbrDataModel.transport_company_id);
                objParam.Add("@payment_type_id", PbrDataModel.payment_type_id);
                objParam.Add("@receiver_delivery_tumbol", PbrDataModel.receiver_delivery_tumbol);
                objParam.Add("@receiver_delivery_amphur", PbrDataModel.receiver_delivery_amphur);
                objParam.Add("@receiver_delivery_provinc", PbrDataModel.receiver_delivery_provinc);
                objParam.Add("@receiver_delivery_zip", PbrDataModel.receiver_delivery_zip);
                objParam.Add("@created_by", PbrDataModel.created_by);
                objParam.Add("@location_branch", PbrDataModel.location_branch);
                objParam.Add("@receiver_custpo", PbrDataModel.receiver_custpo);
                objParam.Add("@inv_number", PbrDataModel.inv_number);

                Connection();
                VSK_PACKING.Open();
                List<PbrDataModel> PbrList = SqlMapper.Query<PbrDataModel>(VSK_PACKING, "SP_PACKING_JOB_CREATE_BR", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();
                VSK_PACKING.Close();
                return PbrList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public List<PbrDataModel> PACKING_JOB_SUCCESS_BR(PbrDataModel PbrDataModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@ref_id", PbrDataModel.ref_id);
                objParam.Add("@job_no", PbrDataModel.job_no);
                objParam.Add("@updated_by", PbrDataModel.updated_by);

                Connection();
                VSK_PACKING.Open();
                List<PbrDataModel> PbrList = SqlMapper.Query<PbrDataModel>(VSK_PACKING, "SP_PACKING_JOB_SUCCESS_BR", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();
                VSK_PACKING.Close();
                return PbrList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }


        public List<PbrGetModel> PACKING_JOB_DETAIL_BR(PbrInputModel PbrInputModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@ref_id", PbrInputModel.ref_id);

                Connection();
                VSK_PACKING.Open();
                List<PbrGetModel> PbrList = SqlMapper.Query<PbrGetModel>(VSK_PACKING, "SP_PACKING_JOB_DETAIL_BR", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();
                VSK_PACKING.Close();
                return PbrList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public List<PbrDataModel> PACKING_JOB_PAYMENT_TYPE_UPDATE_BR(PbrDataModel PbrDataModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@ref_id", PbrDataModel.ref_id);
                objParam.Add("@payment_type_id", PbrDataModel.payment_type_id);

                Connection();
                VSK_PACKING.Open();
                List<PbrDataModel> PbrList = SqlMapper.Query<PbrDataModel>(VSK_PACKING, "SP_PACKING_JOB_PAYMENT_TYPE_UPDATE_BR", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();
                VSK_PACKING.Close();
                return PbrList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public List<PbrDataModel> PACKING_JOB_TRANSPORT_COMPANY_UPDATE_BR(PbrDataModel PbrDataModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@ref_id", PbrDataModel.ref_id);
                objParam.Add("@transport_company_id", PbrDataModel.transport_company_id);

                Connection();
                VSK_PACKING.Open();
                List<PbrDataModel> PbrList = SqlMapper.Query<PbrDataModel>(VSK_PACKING, "SP_PACKING_JOB_TRANSPORT_COMPANY_UPDATE_BR", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();
                VSK_PACKING.Close();
                return PbrList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public List<PbrDataModel> PACKING_JOB_INFORMATION_STATUS_UPDATE_BR(PbrDataModel PbrDataModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@ref_id", PbrDataModel.ref_id);

                Connection();
                VSK_PACKING.Open();
                List<PbrDataModel> PbrList = SqlMapper.Query<PbrDataModel>(VSK_PACKING, "SP_PACKING_JOB_INFORMATION_STATUS_UPDATE_BR", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();
                VSK_PACKING.Close();
                return PbrList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public List<PbrGetModel> PACKING_JOB_DELETE_BR(PbrGetModel PbrGetModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@ref_id", PbrGetModel.ref_id);
                objParam.Add("@job_remark", PbrGetModel.job_remark);
                objParam.Add("@deleted_by", PbrGetModel.deleted_by);

                Connection();
                VSK_PACKING.Open();
                List<PbrGetModel> PbrList = SqlMapper.Query<PbrGetModel>(VSK_PACKING, "SP_PACKING_JOB_DELETE_BR", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();
                VSK_PACKING.Close();
                return PbrList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }


        public List<PbrInvModel> PACKING_INVOICE_CREATE_BR(PbrInvModel PbrInvModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@ref_id", PbrInvModel.ref_id);
                objParam.Add("@job_no", PbrInvModel.job_no);
                objParam.Add("@job_date", PbrInvModel.job_date);
                objParam.Add("@inv_number", PbrInvModel.inv_number);
                objParam.Add("@inv_date", PbrInvModel.inv_date);
                objParam.Add("@inv_po", PbrInvModel.inv_po);
                objParam.Add("@inv_code", PbrInvModel.inv_code);
                objParam.Add("@inv_name", PbrInvModel.inv_name);
                objParam.Add("@inv_item", PbrInvModel.inv_item);
                objParam.Add("@inv_trans", PbrInvModel.inv_trans);
                objParam.Add("@inv_due", PbrInvModel.inv_due);
                objParam.Add("@inv_paycash", PbrInvModel.inv_paycash);
                objParam.Add("@inv_paytran", PbrInvModel.inv_paytran);
                objParam.Add("@inv_paycard", PbrInvModel.inv_paycard);
                objParam.Add("@inv_payoth", PbrInvModel.inv_payoth);
                objParam.Add("@inv_sumtt", PbrInvModel.inv_sumtt);
                objParam.Add("@inv_toption", PbrInvModel.inv_toption);
                objParam.Add("@inv_descript", PbrInvModel.inv_descript);
                objParam.Add("@inv_startdate", PbrInvModel.inv_startdate);
                objParam.Add("@inv_kline", PbrInvModel.inv_kline);
                objParam.Add("@inv_branch", PbrInvModel.inv_branch);
                objParam.Add("@inv_custpo", PbrInvModel.inv_custpo);
                objParam.Add("@inv_userid", PbrInvModel.inv_userid);
                objParam.Add("@inv_pkuser", PbrInvModel.inv_pkuser);
                objParam.Add("@inv_type", PbrInvModel.inv_type);
                objParam.Add("@created_by", PbrInvModel.created_by);

                Connection();
                VSK_PACKING.Open();
                List<PbrInvModel> PbrList = SqlMapper.Query<PbrInvModel>(VSK_PACKING, "SP_PACKING_INVOICE_CREATE_BR", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();
                VSK_PACKING.Close();
                return PbrList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public List<PbrInvModel> PACKING_INVOICE_LIST_BR(PbrInvModel PbrInvModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@ref_id", PbrInvModel.ref_id);

                Connection();
                VSK_PACKING.Open();
                List<PbrInvModel> PbrList = SqlMapper.Query<PbrInvModel>(VSK_PACKING, "SP_PACKING_INVOICE_LIST_BR", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();
                VSK_PACKING.Close();
                return PbrList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public List<PbrInvModel> PACKING_INVOICE_VERIFY_BR(PbrInvModel PbrInvModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@ref_id", PbrInvModel.ref_id);
                objParam.Add("@job_scan", PbrInvModel.job_scan);
                objParam.Add("@job_number", PbrInvModel.job_number);
                objParam.Add("@updated_by", PbrInvModel.updated_by);
                objParam.Add("@pMessage", PbrInvModel.pMessage);

                Connection();
                VSK_PACKING.Open();
                List<PbrInvModel> PbrList = SqlMapper.Query<PbrInvModel>(VSK_PACKING, "SP_PACKING_INVOICE_VERIFY_BR", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();
                VSK_PACKING.Close();
                return PbrList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public List<PbrInvModel> PACKING_INVOICE_DELETE_BR(PbrInvModel PbrInvModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@ref_id", PbrInvModel.ref_id);
                objParam.Add("@inv_number", PbrInvModel.inv_number);
                objParam.Add("@updated_by", PbrInvModel.updated_by);

                Connection();
                VSK_PACKING.Open();
                List<PbrInvModel> PbrList = SqlMapper.Query<PbrInvModel>(VSK_PACKING, "SP_PACKING_INVOICE_DELETE_BR", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();
                VSK_PACKING.Close();
                return PbrList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public List<PbrInvModel> PACKING_INVOICE_CHANGE_BR(PbrInvModel PbrInvModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@ref_id", PbrInvModel.ref_id);
                objParam.Add("@job_no", PbrInvModel.job_no);
                objParam.Add("@inv_number", PbrInvModel.inv_number);
                objParam.Add("@job_scan", PbrInvModel.job_scan);
                objParam.Add("@updated_by", PbrInvModel.updated_by);

                Connection();
                VSK_PACKING.Open();
                List<PbrInvModel> PbrList = SqlMapper.Query<PbrInvModel>(VSK_PACKING, "SP_PACKING_INVOICE_CHANGE_BR", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();
                VSK_PACKING.Close();
                return PbrList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }


        public List<PbrItemModel> PACKING_ITEM_CREATE_BR(PbrItemModel PbrItemModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@ref_id", PbrItemModel.ref_id);
                objParam.Add("@job_no", PbrItemModel.job_no);
                objParam.Add("@inv_number", PbrItemModel.inv_number);
                objParam.Add("@created_by", PbrItemModel.created_by);

                Connection();
                VSK_PACKING.Open();
                List<PbrItemModel> PbrList = SqlMapper.Query<PbrItemModel>(VSK_PACKING, "SP_PACKING_ITEM_CREATE_BR", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();
                VSK_PACKING.Close();
                return PbrList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public List<PbrItemModel> PACKING_ITEM_GET_BR(PbrItemModel PbrItemModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@ref_id", PbrItemModel.ref_id);
                objParam.Add("@job_no", PbrItemModel.job_no);
                objParam.Add("@job_status", PbrItemModel.job_status);
                objParam.Add("@keywords", PbrItemModel.keywords);
                objParam.Add("@pages", PbrItemModel.pages);
                objParam.Add("@show", PbrItemModel.show);

                Connection();
                VSK_PACKING.Open();
                List<PbrItemModel> PbrList = SqlMapper.Query<PbrItemModel>(VSK_PACKING, "SP_PACKING_ITEM_GET_BR", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();
                VSK_PACKING.Close();
                return PbrList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public List<PbrItemModel> PACKING_ITEM_DETAIL_BR(PbrItemModel PbrItemModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@ref_id", PbrItemModel.ref_id);
                objParam.Add("@item_barcode", PbrItemModel.item_barcode);

                Connection();
                VSK_PACKING.Open();
                List<PbrItemModel> PbrList = SqlMapper.Query<PbrItemModel>(VSK_PACKING, "SP_PACKING_ITEM_DETAIL_BR", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();
                VSK_PACKING.Close();
                return PbrList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }


        public List<PbrItemModel> PACKING_ITEM_COUNT_BR(PbrItemModel PbrItemModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@ref_id", PbrItemModel.ref_id);
                objParam.Add("@job_no", PbrItemModel.job_no);

                Connection();
                VSK_PACKING.Open();
                List<PbrItemModel> PbrList = SqlMapper.Query<PbrItemModel>(VSK_PACKING, "SP_PACKING_ITEM_COUNT_BR", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();
                VSK_PACKING.Close();
                return PbrList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public List<PbrItemModel> PACKING_ITEM_UPDATE_BR(PbrItemModel PbrItemModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@ref_id", PbrItemModel.ref_id);
                objParam.Add("@job_no", PbrItemModel.job_no);
                objParam.Add("@inv_number", PbrItemModel.inv_number);
                objParam.Add("@job_qty", PbrItemModel.job_qty);
                objParam.Add("@job_scan", PbrItemModel.job_scan);
                objParam.Add("@updated_by", PbrItemModel.updated_by);
                objParam.Add("@pMessage", PbrItemModel.pMessage);

                Connection();
                VSK_PACKING.Open();
                List<PbrItemModel> PbrList = SqlMapper.Query<PbrItemModel>(VSK_PACKING, "SP_PACKING_ITEM_UPDATE_BR", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();
                VSK_PACKING.Close();
                return PbrList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public List<PbrItemModel> PACKING_ITEM_SUCCESS_BR(PbrItemModel PbrItemModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@ref_id", PbrItemModel.ref_id);
                objParam.Add("@job_no", PbrItemModel.job_no);
                objParam.Add("@updated_by", PbrItemModel.updated_by);

                Connection();
                VSK_PACKING.Open();
                List<PbrItemModel> PbrList = SqlMapper.Query<PbrItemModel>(VSK_PACKING, "SP_PACKING_ITEM_SUCCESS_BR", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();
                VSK_PACKING.Close();
                return PbrList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }


        public List<PbrMasterModel> PACKING_BOX_GET_BR(PbrMasterModel PbrMasterModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@mode", PbrMasterModel.mode);
                objParam.Add("@keywords", PbrMasterModel.keywords);

                Connection();
                VSK_PACKING.Open();
                List<PbrMasterModel> PbrList = SqlMapper.Query<PbrMasterModel>(VSK_PACKING, "SP_PACKING_BOX_GET_BR", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();
                VSK_PACKING.Close();
                return PbrList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public List<PbrBoxModel> PACKING_BOX_CREATE_BR_V1(PbrBoxModel PbrBoxModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@ref_id", PbrBoxModel.ref_id);
                objParam.Add("@job_no", PbrBoxModel.job_no);
                objParam.Add("@created_by", PbrBoxModel.created_by);

                Connection();
                VSK_PACKING.Open();
                List<PbrBoxModel> PbrList = SqlMapper.Query<PbrBoxModel>(VSK_PACKING, "SP_PACKING_BOX_CREATE_BR", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();
                VSK_PACKING.Close();
                return PbrList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public void PACKING_BOX_CREATE_BR(List<PbrBoxModel> PbrBoxModel)
        {

            try
            {

                Connection();

                VSK_PACKING.Open();

                foreach (var ImportDataArrayData in PbrBoxModel)
                {
                    DynamicParameters objParam = new DynamicParameters();


                    objParam.Add("@ref_id", ImportDataArrayData.ref_id);
                    objParam.Add("@job_no", ImportDataArrayData.job_no);
                    objParam.Add("@box_id", ImportDataArrayData.box_id);
                    objParam.Add("@box_qty", ImportDataArrayData.box_qty);
                    objParam.Add("@created_by", ImportDataArrayData.created_by);
                    //objParam.Add("@share_box_trans_id", ImportDataArrayData.share_box_trans_id);
                    //objParam.Add("@share_ref_box_ref_id", ImportDataArrayData.share_ref_box_ref_id);

                    VSK_PACKING.Execute("SP_PACKING_BOX_CREATE_BR", objParam, commandTimeout: 600, commandType: CommandType.StoredProcedure);

                }

                VSK_PACKING.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<PbrBoxModel> PACKING_BOX_DETAIL_BR(PbrBoxModel PbrBoxModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@ref_id", PbrBoxModel.ref_id);
                objParam.Add("@job_no", PbrBoxModel.job_no);
                Connection();
                VSK_PACKING.Open();
                List<PbrBoxModel> PbrList = SqlMapper.Query<PbrBoxModel>(VSK_PACKING, "SP_PACKING_BOX_DETAIL_BR", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();
                VSK_PACKING.Close();
                return PbrList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public void PACKING_BOX_UPDATE_BR(List<PbrBoxModel> PbrBoxModel)
        {

            try
            {

                Connection();

                VSK_PACKING.Open();

                foreach (var ImportDataArrayData in PbrBoxModel)
                {
                    DynamicParameters objParam = new DynamicParameters();


                    objParam.Add("@ref_id", ImportDataArrayData.ref_id);
                    objParam.Add("@job_no", ImportDataArrayData.job_no);
                    objParam.Add("@box_id", ImportDataArrayData.box_id);
                    objParam.Add("@box_qty", ImportDataArrayData.box_qty);
                    objParam.Add("@updated_by", ImportDataArrayData.updated_by);

                    VSK_PACKING.Execute("SP_PACKING_BOX_UPDATE_BR", objParam, commandTimeout: 600, commandType: CommandType.StoredProcedure);

                }

                VSK_PACKING.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<PbrBoxModel> PACKING_BOX_SUCCESS_BR(PbrBoxModel PbrBoxModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@ref_id", PbrBoxModel.ref_id);
                objParam.Add("@job_no", PbrBoxModel.job_no);
                objParam.Add("@updated_by", PbrBoxModel.updated_by);

                Connection();
                VSK_PACKING.Open();
                List<PbrBoxModel> PbrList = SqlMapper.Query<PbrBoxModel>(VSK_PACKING, "SP_PACKING_BOX_SUCCESS_BR", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();
                VSK_PACKING.Close();
                return PbrList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public List<PbrBoxModel> PACKING_BOX_DELETE_BR(PbrBoxModel PbrBoxModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@ref_id", PbrBoxModel.ref_id);
                objParam.Add("@job_no", PbrBoxModel.job_no);
                objParam.Add("@updated_by", PbrBoxModel.updated_by);

                Connection();
                VSK_PACKING.Open();
                List<PbrBoxModel> PbrList = SqlMapper.Query<PbrBoxModel>(VSK_PACKING, "SP_PACKING_BOX_DELETE_BR", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();
                VSK_PACKING.Close();
                return PbrList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }


        public List<PbrGetModel> PACKING_BOX_SHARE_GET_BR(PbrGetModel PbrGetModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@receiver_code", PbrGetModel.receiver_code);
                objParam.Add("@receiver_delivery_address", PbrGetModel.receiver_delivery_address);

                Connection();
                VSK_PACKING.Open();
                List<PbrGetModel> PbrList = SqlMapper.Query<PbrGetModel>(VSK_PACKING, "SP_PACKING_BOX_SHARE_GET_BR", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();
                VSK_PACKING.Close();
                return PbrList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public void PACKING_BOX_SHARE_CREATE_BR(List<PbrBoxModel> PbrBoxModel)
        {

            try
            {

                Connection();

                VSK_PACKING.Open();

                foreach (var ImportDataArrayData in PbrBoxModel)
                {
                    DynamicParameters objParam = new DynamicParameters();


                    objParam.Add("@ref_id", ImportDataArrayData.ref_id);
                    objParam.Add("@job_no", ImportDataArrayData.job_no);
                    objParam.Add("@box_id", ImportDataArrayData.box_id);
                    objParam.Add("@box_qty", ImportDataArrayData.box_qty);
                    objParam.Add("@created_by", ImportDataArrayData.created_by);
                    objParam.Add("@share_box_trans_id", ImportDataArrayData.share_box_trans_id);
                    objParam.Add("@share_ref_box_ref_id", ImportDataArrayData.share_ref_box_ref_id);

                    VSK_PACKING.Execute("SP_PACKING_BOX_SHARE_CREATE_BR", objParam, commandTimeout: 600, commandType: CommandType.StoredProcedure);

                }

                VSK_PACKING.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public List<PbrBatchModel> PACKING_BATCH_NO_GET_BR(PbrBatchModel PbrBatchModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@ref_id", PbrBatchModel.ref_id);
                objParam.Add("@mode", PbrBatchModel.mode);
                objParam.Add("@created_by", PbrBatchModel.created_by);

                Connection();
                VSK_PACKING.Open();
                List<PbrBatchModel> PbrList = SqlMapper.Query<PbrBatchModel>(VSK_PACKING, "SP_PACKING_BATCH_NO_GET_BR", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();
                VSK_PACKING.Close();
                return PbrList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public List<PbrBatchModel> PACKING_BATCH_UPDATE_BR(PbrBatchModel PbrBatchModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@ref_id", PbrBatchModel.ref_id);
                objParam.Add("@job_no", PbrBatchModel.job_no);
                objParam.Add("@box_id", PbrBatchModel.box_id);
                objParam.Add("@batch_qty", PbrBatchModel.batch_qty);
                objParam.Add("@created_by", PbrBatchModel.created_by);

                Connection();
                VSK_PACKING.Open();
                List<PbrBatchModel> PbrList = SqlMapper.Query<PbrBatchModel>(VSK_PACKING, "SP_PACKING_BATCH_UPDATE_BR", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();
                VSK_PACKING.Close();
                return PbrList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public List<PbrBatchModel> PACKING_BATCH_LIST_BR(PbrBatchModel PbrBatchModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@ref_id", PbrBatchModel.ref_id);
                objParam.Add("@mode", PbrBatchModel.mode);
                objParam.Add("@job_batchno", PbrBatchModel.job_batchno);
                objParam.Add("@search_item", PbrBatchModel.search_item);

                Connection();
                VSK_PACKING.Open();
                List<PbrBatchModel> PbrList = SqlMapper.Query<PbrBatchModel>(VSK_PACKING, "SP_PACKING_BATCH_LIST_BR", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();
                VSK_PACKING.Close();
                return PbrList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public List<PbrBatchModel> PACKING_BATCH_DELETE_BR(PbrBatchModel PbrBatchModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@mode", PbrBatchModel.mode);
                objParam.Add("@ref_id", PbrBatchModel.ref_id);
                objParam.Add("@barcode", PbrBatchModel.barcode);
                objParam.Add("@job_batchno", PbrBatchModel.job_batchno);
                objParam.Add("@updated_by", PbrBatchModel.updated_by);

                Connection();
                VSK_PACKING.Open();
                List<PbrBatchModel> PbrList = SqlMapper.Query<PbrBatchModel>(VSK_PACKING, "SP_PACKING_BATCH_DELETE_BR", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();
                VSK_PACKING.Close();
                return PbrList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }



        public List<PbrGetModel> PACKING_SHIPPING_NOTE_BR(PbrInputModel PbrInputModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@mode", PbrInputModel.mode);
                objParam.Add("@ref_id", PbrInputModel.ref_id);
                objParam.Add("@job_batchno", PbrInputModel.job_batchno);

                Connection();
                VSK_PACKING.Open();
                List<PbrGetModel> PbrList = SqlMapper.Query<PbrGetModel>(VSK_PACKING, "SP_PACKING_SHIPPING_NOTE_BR", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();
                VSK_PACKING.Close();
                return PbrList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }


        public List<PbrRemarkModel> PACKING_REMARK_LIST_BR(PbrRemarkModel PbrRemarkModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@ref_id", PbrRemarkModel.ref_id);
                objParam.Add("@job_no", PbrRemarkModel.job_no);
                objParam.Add("@remark_type", PbrRemarkModel.remark_type);

                Connection();
                VSK_PACKING.Open();
                List<PbrRemarkModel> PbrList = SqlMapper.Query<PbrRemarkModel>(VSK_PACKING, "SP_PACKING_REMARK_LIST_BR", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();
                VSK_PACKING.Close();
                return PbrList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<PbrRemarkModel> PACKING_REMARK_CREATE_BR(PbrRemarkModel PbrRemarkModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@ref_id", PbrRemarkModel.ref_id);
                objParam.Add("@job_no", PbrRemarkModel.job_no);
                objParam.Add("@remark_type", PbrRemarkModel.remark_type);
                objParam.Add("@remark_text", PbrRemarkModel.remark_text);
                objParam.Add("@created_by", PbrRemarkModel.created_by);

                Connection();
                VSK_PACKING.Open();
                List<PbrRemarkModel> PbrList = SqlMapper.Query<PbrRemarkModel>(VSK_PACKING, "SP_PACKING_REMARK_CREATE_BR", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();
                VSK_PACKING.Close();
                return PbrList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public List<PbrRemarkModel> PACKING_REMARK_DELETE_BR(PbrRemarkModel PbrRemarkModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@trans_id", PbrRemarkModel.trans_id);
                objParam.Add("@updated_by", PbrRemarkModel.updated_by);

                Connection();
                VSK_PACKING.Open();
                List<PbrRemarkModel> PbrList = SqlMapper.Query<PbrRemarkModel>(VSK_PACKING, "SP_PACKING_REMARK_DELETE_BR", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();
                VSK_PACKING.Close();
                return PbrList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }


        public List<PbrLoadingModel> PACKING_LOADING_CHECK_BR(PbrLoadingModel PbrLoadingModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@job_round", PbrLoadingModel.job_round);
                objParam.Add("@job_date", PbrLoadingModel.job_date);
                objParam.Add("@job_branch", PbrLoadingModel.job_branch);

                Connection();
                VSK_PACKING.Open();
                List<PbrLoadingModel> PbrList = SqlMapper.Query<PbrLoadingModel>(VSK_PACKING, "SP_PACKING_LOADING_CHECK_BR", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();
                VSK_PACKING.Close();
                return PbrList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public List<PbrLoadingModel> PACKING_LOADING_GET_BR(PbrLoadingModel PbrLoadingModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();


                string col_settle_date;

                if (PbrLoadingModel.job_date == DateTime.MinValue)
                {
                    col_settle_date = null;
                }
                else
                {
                    col_settle_date = PbrLoadingModel.job_date.ToString("yyyy/MM/dd");
                }


                objParam.Add("@mode", PbrLoadingModel.mode);
                objParam.Add("@ref_id", PbrLoadingModel.ref_id);
                objParam.Add("@job_no", PbrLoadingModel.job_no);

                objParam.Add("@job_round", PbrLoadingModel.job_round);
                objParam.Add("@job_date", col_settle_date);
                objParam.Add("@job_branch", PbrLoadingModel.job_branch);
                objParam.Add("@@location_branch", PbrLoadingModel.@location_branch);

                Connection();
                VSK_PACKING.Open();
                List<PbrLoadingModel> PbrList = SqlMapper.Query<PbrLoadingModel>(VSK_PACKING, "SP_PACKING_LOADING_GET_BR", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();
                VSK_PACKING.Close();
                return PbrList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public List<PbrLoadingModel> PACKING_LOADING_CREATE_BR(PbrLoadingModel PbrLoadingModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@job_branch", PbrLoadingModel.job_branch);
                objParam.Add("@job_scan", PbrLoadingModel.job_scan);
                objParam.Add("@job_round", PbrLoadingModel.job_round);
                objParam.Add("@job_date", PbrLoadingModel.job_date);
                objParam.Add("@ref_id", PbrLoadingModel.ref_id);
                objParam.Add("@created_by", PbrLoadingModel.created_by);
                objParam.Add("@pMessage", PbrLoadingModel.pMessage);

                Connection();
                VSK_PACKING.Open();
                List<PbrLoadingModel> PbrList = SqlMapper.Query<PbrLoadingModel>(VSK_PACKING, "SP_PACKING_LOADING_CREATE_BR", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();
                VSK_PACKING.Close();
                return PbrList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public List<PbrLoadingModel> PACKING_LOADING_TMS_LIST_BR(PbrLoadingModel PbrLoadingModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@ref_id", PbrLoadingModel.ref_id);

                Connection();
                VSK_PACKING.Open();
                List<PbrLoadingModel> PbrList = SqlMapper.Query<PbrLoadingModel>(VSK_PACKING, "SP_PACKING_LOADING_TMS_LIST_BR", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();
                VSK_PACKING.Close();
                return PbrList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public List<PbrLoadingModel> PACKING_LOADING_UPDATE_BR(PbrLoadingModel PbrLoadingModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@ref_id", PbrLoadingModel.ref_id);
                objParam.Add("@job_date", PbrLoadingModel.job_date);
                objParam.Add("@job_round", PbrLoadingModel.job_round);
                objParam.Add("@delivery_ref_id", PbrLoadingModel.delivery_ref_id);
                objParam.Add("@mode", PbrLoadingModel.mode);
                objParam.Add("@updated_by", PbrLoadingModel.updated_by);

                Connection();
                VSK_PACKING.Open();
                List<PbrLoadingModel> PbrList = SqlMapper.Query<PbrLoadingModel>(VSK_PACKING, "SP_PACKING_LOADING_UPDATE_BR", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();
                VSK_PACKING.Close();
                return PbrList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public List<PbrLoadingModel> PACKING_LOADING_DELETE_BR(PbrLoadingModel PbrLoadingModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@ref_id", PbrLoadingModel.ref_id);
                objParam.Add("@trans_id", PbrLoadingModel.trans_id);
                objParam.Add("@updated_by", PbrLoadingModel.updated_by);

                Connection();
                VSK_PACKING.Open();
                List<PbrLoadingModel> PbrList = SqlMapper.Query<PbrLoadingModel>(VSK_PACKING, "SP_PACKING_LOADING_DELETE_BR", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();
                VSK_PACKING.Close();
                return PbrList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public List<PbrLoadingModel> PACKING_LOADING_LIST_BR(PbrLoadingModel PbrLoadingModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@job_date_start", PbrLoadingModel.job_date_start);
                objParam.Add("@job_date_end", PbrLoadingModel.job_date_end);
                objParam.Add("@job_round", PbrLoadingModel.job_round);
                objParam.Add("@event_status", PbrLoadingModel.event_status);

                Connection();
                VSK_PACKING.Open();
                List<PbrLoadingModel> PbrList = SqlMapper.Query<PbrLoadingModel>(VSK_PACKING, "SP_PACKING_LOADING_LIST_BR", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();
                VSK_PACKING.Close();
                return PbrList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public List<PbrGetModel> PACKING_LOADING_COVER_SHEET_BR(PbrGetModel PbrGetModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@job_no", PbrGetModel.job_no);

                Connection();
                VSK_PACKING.Open();
                List<PbrGetModel> PbrList = SqlMapper.Query<PbrGetModel>(VSK_PACKING, "SP_PACKING_LOADING_COVER_SHEET_BR", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();
                VSK_PACKING.Close();
                return PbrList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public List<PbrLoadingModel> PACKING_LOADING_DELIVERY_LIST_BR(PbrLoadingModel PbrLoadingModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@ref_id", PbrLoadingModel.ref_id);
                objParam.Add("@job_date", PbrLoadingModel.job_date);
                objParam.Add("@job_round", PbrLoadingModel.job_round);
                objParam.Add("@job_branch", PbrLoadingModel.job_branch);

                Connection();
                VSK_PACKING.Open();
                List<PbrLoadingModel> PbrList = SqlMapper.Query<PbrLoadingModel>(VSK_PACKING, "SP_PACKING_LOADING_DELIVERY_LIST_BR", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();
                VSK_PACKING.Close();
                return PbrList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }


        public List<PbrReceiveBoxModel> PACKING_RECEIVE_BOX_CHECK_BR(PbrReceiveBoxModel PbrReceiveBoxModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@location_branch", PbrReceiveBoxModel.location_branch);
                objParam.Add("@job_round", PbrReceiveBoxModel.job_round);
                objParam.Add("@job_date", PbrReceiveBoxModel.job_date);

                Connection();
                VSK_PACKING.Open();
                List<PbrReceiveBoxModel> PbrList = SqlMapper.Query<PbrReceiveBoxModel>(VSK_PACKING, "SP_PACKING_RECEIVE_BOX_CHECK_BR", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();
                VSK_PACKING.Close();
                return PbrList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public List<PbrReceiveBoxModel> PACKING_RECEIVE_BOX_JOB_BR(PbrReceiveBoxModel PbrReceiveBoxModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@job_scan", PbrReceiveBoxModel.job_scan);
                objParam.Add("@location_branch", PbrReceiveBoxModel.location_branch);
                objParam.Add("@job_round", PbrReceiveBoxModel.job_round);
                objParam.Add("@job_date", PbrReceiveBoxModel.job_date);

                Connection();
                VSK_PACKING.Open();
                List<PbrReceiveBoxModel> PbrList = SqlMapper.Query<PbrReceiveBoxModel>(VSK_PACKING, "SP_PACKING_RECEIVE_BOX_JOB_BR", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();
                VSK_PACKING.Close();
                return PbrList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public List<PbrReceiveBoxModel> PACKING_RECEIVE_BOX_GET_BR(PbrReceiveBoxModel PbrReceiveBoxModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@mode", PbrReceiveBoxModel.mode);
                objParam.Add("@ref_id", PbrReceiveBoxModel.ref_id);
                objParam.Add("@job_round", PbrReceiveBoxModel.job_round);
                objParam.Add("@job_date", PbrReceiveBoxModel.job_date);
                objParam.Add("@job_branch", PbrReceiveBoxModel.job_branch);
                objParam.Add("@job_no", PbrReceiveBoxModel.job_no);
                objParam.Add("@job_status", PbrReceiveBoxModel.job_status);

                Connection();
                VSK_PACKING.Open();
                List<PbrReceiveBoxModel> PbrList = SqlMapper.Query<PbrReceiveBoxModel>(VSK_PACKING, "SP_PACKING_RECEIVE_BOX_GET_BR", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();
                VSK_PACKING.Close();
                return PbrList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public List<PbrReceiveBoxModel> PACKING_RECEIVE_BOX_LIST_BR(PbrReceiveBoxModel PbrReceiveBoxModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@mode", PbrReceiveBoxModel.mode);
                objParam.Add("@ref_id", PbrReceiveBoxModel.ref_id);
                objParam.Add("@job_round", PbrReceiveBoxModel.job_round);
                objParam.Add("@job_date", PbrReceiveBoxModel.job_date);
                objParam.Add("@job_branch", PbrReceiveBoxModel.job_branch);
                objParam.Add("@job_no", PbrReceiveBoxModel.job_no);
                objParam.Add("@job_status", PbrReceiveBoxModel.job_status);
                objParam.Add("@search_box_status", PbrReceiveBoxModel.search_box_status);
                objParam.Add("@search_item", PbrReceiveBoxModel.search_item);

                Connection();
                VSK_PACKING.Open();
                List<PbrReceiveBoxModel> PbrList = SqlMapper.Query<PbrReceiveBoxModel>(VSK_PACKING, "SP_PACKING_RECEIVE_BOX_LIST_BR", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();
                VSK_PACKING.Close();
                return PbrList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public List<PbrReceiveBoxModel> PACKING_RECEIVE_BOX_DATA_BR(PbrReceiveBoxModel PbrReceiveBoxModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@ref_id", PbrReceiveBoxModel.ref_id);

                Connection();
                VSK_PACKING.Open();
                List<PbrReceiveBoxModel> PbrList = SqlMapper.Query<PbrReceiveBoxModel>(VSK_PACKING, "SP_PACKING_RECEIVE_BOX_DATA_BR", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();
                VSK_PACKING.Close();
                return PbrList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public List<PbrReceiveBoxModel> PACKING_RECEIVE_BOX_CREATE_BR(PbrReceiveBoxModel PbrReceiveBoxModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@job_loading", PbrReceiveBoxModel.job_loading);
                objParam.Add("@job_scan", PbrReceiveBoxModel.job_scan);
                objParam.Add("@job_round", PbrReceiveBoxModel.job_round);
                objParam.Add("@job_date", PbrReceiveBoxModel.job_date);
                objParam.Add("@ref_id", PbrReceiveBoxModel.ref_id);
                objParam.Add("@created_by", PbrReceiveBoxModel.created_by);
                objParam.Add("@job_branch", PbrReceiveBoxModel.job_branch);
                objParam.Add("@location_branch", PbrReceiveBoxModel.location_branch);
                objParam.Add("@pMessage", PbrReceiveBoxModel.pMessage);

                Connection();
                VSK_PACKING.Open();
                List<PbrReceiveBoxModel> PbrList = SqlMapper.Query<PbrReceiveBoxModel>(VSK_PACKING, "SP_PACKING_RECEIVE_BOX_CREATE_BR", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();
                VSK_PACKING.Close();
                return PbrList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public List<PbrReceiveBoxModel> PACKING_RECEIVE_BOX_UPDATE_BR(PbrReceiveBoxModel PbrReceiveBoxModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@ref_id", PbrReceiveBoxModel.ref_id);
                objParam.Add("@job_round", PbrReceiveBoxModel.job_round);
                objParam.Add("@job_date", PbrReceiveBoxModel.job_date);
                objParam.Add("@job_branch", PbrReceiveBoxModel.job_branch);
                objParam.Add("@updated_by", PbrReceiveBoxModel.updated_by);

                Connection();
                VSK_PACKING.Open();
                List<PbrReceiveBoxModel> PbrList = SqlMapper.Query<PbrReceiveBoxModel>(VSK_PACKING, "SP_PACKING_RECEIVE_BOX_UPDATE_BR", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();
                VSK_PACKING.Close();
                return PbrList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }


        public List<PbrReceiveItemModel> PACKING_RECEIVE_ITEM_DETAIL_BR(PbrReceiveItemModel PbrReceiveItemModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@ref_id", PbrReceiveItemModel.ref_id);
                objParam.Add("@job_no", PbrReceiveItemModel.job_no);
                objParam.Add("@item_name", PbrReceiveItemModel.item_name);
                objParam.Add("@item_unit", PbrReceiveItemModel.item_unit);
                objParam.Add("@gnamechr", PbrReceiveItemModel.gnamechr);
                objParam.Add("@product_division", PbrReceiveItemModel.product_division);
                objParam.Add("@main_category", PbrReceiveItemModel.main_category);
                objParam.Add("@sub_category", PbrReceiveItemModel.sub_category);

                Connection();
                VSK_PACKING.Open();
                List<PbrReceiveItemModel> PbrList = SqlMapper.Query<PbrReceiveItemModel>(VSK_PACKING, "SP_PACKING_RECEIVE_ITEM_DETAIL_BR", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();
                VSK_PACKING.Close();
                return PbrList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public List<PbrReceiveItemModel> PACKING_RECEIVE_ITEM_LIST_BR(PbrReceiveItemModel PbrReceiveItemModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@ref_id", PbrReceiveItemModel.ref_id);
                objParam.Add("@job_no", PbrReceiveItemModel.job_no);
                objParam.Add("@job_batno", PbrReceiveItemModel.job_batno);

                Connection();
                VSK_PACKING.Open();
                List<PbrReceiveItemModel> PbrList = SqlMapper.Query<PbrReceiveItemModel>(VSK_PACKING, "SP_PACKING_RECEIVE_ITEM_LIST_BR", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();
                VSK_PACKING.Close();
                return PbrList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public List<PbrReceiveItemModel> PACKING_RECEIVE_ITEM_CREATE_BR(PbrReceiveItemModel PbrReceiveItemModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@ref_id", PbrReceiveItemModel.ref_id);
                objParam.Add("@job_no", PbrReceiveItemModel.job_no);
                objParam.Add("@job_batno", PbrReceiveItemModel.job_batno);
                objParam.Add("@item_code", PbrReceiveItemModel.item_code);
                objParam.Add("@item_name", PbrReceiveItemModel.item_name);
                objParam.Add("@item_barcode", PbrReceiveItemModel.item_barcode);
                objParam.Add("@item_spcodes", PbrReceiveItemModel.item_spcodes);
                objParam.Add("@item_qty", PbrReceiveItemModel.item_qty);
                objParam.Add("@item_unit", PbrReceiveItemModel.item_unit);
                objParam.Add("@item_glocat", PbrReceiveItemModel.item_glocat);
                objParam.Add("@created_by", PbrReceiveItemModel.created_by);
                objParam.Add("@pMessage", PbrReceiveItemModel.pMessage);

                Connection();
                VSK_PACKING.Open();
                List<PbrReceiveItemModel> PbrList = SqlMapper.Query<PbrReceiveItemModel>(VSK_PACKING, "SP_PACKING_RECEIVE_ITEM_CREATE_BR", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();
                VSK_PACKING.Close();
                return PbrList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public List<PbrReceiveItemModel> PACKING_RECEIVE_ITEM_DELETE_BR(PbrReceiveItemModel PbrReceiveItemModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@ref_id", PbrReceiveItemModel.ref_id);
                objParam.Add("@job_no", PbrReceiveItemModel.job_no);
                objParam.Add("@job_batno", PbrReceiveItemModel.job_batno);
                objParam.Add("@item_barcode", PbrReceiveItemModel.item_barcode);
                objParam.Add("@item_qty", PbrReceiveItemModel.item_qty);
                objParam.Add("@updated_by", PbrReceiveItemModel.updated_by);
                objParam.Add("@pMessage", PbrReceiveItemModel.pMessage);

                Connection();
                VSK_PACKING.Open();
                List<PbrReceiveItemModel> PbrList = SqlMapper.Query<PbrReceiveItemModel>(VSK_PACKING, "SP_PACKING_RECEIVE_ITEM_DELETE_BR", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();
                VSK_PACKING.Close();
                return PbrList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public List<PbrReceiveItemModel> PACKING_RECEIVE_ITEM_VERIFY_BR(string ref_id , string item_barcode, int item_qty)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@ref_id", ref_id);
                objParam.Add("@item_barcode", item_barcode);
                objParam.Add("@item_qty", item_qty);

                Connection();
                VSK_PACKING.Open();
                List<PbrReceiveItemModel> PbrList = SqlMapper.Query<PbrReceiveItemModel>(VSK_PACKING, "SP_PACKING_RECEIVE_ITEM_VERIFY_BR", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();
                VSK_PACKING.Close();
                return PbrList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public List<PbrReceiveItemModel> PACKING_RECEIVE_JOB_VERIFY_BR(PbrReceiveItemModel PbrReceiveItemModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@ref_id", PbrReceiveItemModel.ref_id);
                objParam.Add("@updated_by", PbrReceiveItemModel.updated_by);

                Connection();
                VSK_PACKING.Open();
                List<PbrReceiveItemModel> PbrList = SqlMapper.Query<PbrReceiveItemModel>(VSK_PACKING, "SP_PACKING_RECEIVE_JOB_VERIFY_BR", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();
                VSK_PACKING.Close();
                return PbrList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public List<PbrReceiveItemModel> PACKING_RECEIVE_JOB_VERIFY_ALERT_BR(string ref_id)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@ref_id", ref_id);

                Connection();
                VSK_PACKING.Open();
                List<PbrReceiveItemModel> PbrList = SqlMapper.Query<PbrReceiveItemModel>(VSK_PACKING, "SP_PACKING_RECEIVE_JOB_VERIFY_ALERT_BR", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();
                VSK_PACKING.Close();
                return PbrList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }


        public List<PbrReceiveGetModel> PACKING_RECEIVE_LIST_BR(PbrReceiveGetModel PbrReceiveGetModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@mode", PbrReceiveGetModel.mode);
                objParam.Add("@job_date_start", PbrReceiveGetModel.job_date_start);
                objParam.Add("@job_date_end", PbrReceiveGetModel.job_date_end);
                objParam.Add("@job_loading", PbrReceiveGetModel.job_loading);
                objParam.Add("@job_status", PbrReceiveGetModel.job_status);
                objParam.Add("@location_branch", PbrReceiveGetModel.location_branch);
                objParam.Add("@created_by", PbrReceiveGetModel.created_by);
                objParam.Add("@pages", PbrReceiveGetModel.pages);
                objParam.Add("@show", PbrReceiveGetModel.show);

                Connection();
                VSK_PACKING.Open();
                List<PbrReceiveGetModel> PbrList = SqlMapper.Query<PbrReceiveGetModel>(VSK_PACKING, "SP_PACKING_RECEIVE_LIST_BR", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();
                VSK_PACKING.Close();
                return PbrList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }


        public List<PbrTemplateGetModel> PACKING_TEMPLATE_CREATE_BR(PbrTemplateGetModel PbrTemplateGetModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@ref_id", PbrTemplateGetModel.ref_id);
                objParam.Add("@job_date", PbrTemplateGetModel.job_date);
                objParam.Add("@job_remark", PbrTemplateGetModel.job_remark);
                objParam.Add("@created_by", PbrTemplateGetModel.created_by);

                Connection();
                VSK_PACKING.Open();
                List<PbrTemplateGetModel> PbrList = SqlMapper.Query<PbrTemplateGetModel>(VSK_PACKING, "SP_PACKING_TEMPLATE_CREATE_BR", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();
                VSK_PACKING.Close();
                return PbrList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public List<PbrTemplateGetModel> PACKING_TEMPLATE_LIST_BR(PbrTemplateGetModel PbrTemplateGetModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@ref_id", PbrTemplateGetModel.ref_id);

                Connection();
                VSK_PACKING.Open();
                List<PbrTemplateGetModel> PbrList = SqlMapper.Query<PbrTemplateGetModel>(VSK_PACKING, "SP_PACKING_TEMPLATE_LIST_BR", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();
                VSK_PACKING.Close();
                return PbrList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public List<PbrTemplateGetModel> PACKING_TEMPLATE_GET_BR(PbrTemplateGetModel PbrTemplateGetModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@ref_id", PbrTemplateGetModel.ref_id);
                objParam.Add("@mode", PbrTemplateGetModel.mode);

                Connection();
                VSK_PACKING.Open();
                List<PbrTemplateGetModel> PbrList = SqlMapper.Query<PbrTemplateGetModel>(VSK_PACKING, "SP_PACKING_TEMPLATE_GET_BR", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();
                VSK_PACKING.Close();
                return PbrList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }



        public List<PbrCaseGetModel> PACKING_CASE_CREATE_BR(PbrCaseGetModel PbrCaseGetModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@job_case", PbrCaseGetModel.job_case);
                objParam.Add("@job_scan", PbrCaseGetModel.job_scan);
                objParam.Add("@job_round", PbrCaseGetModel.job_round);
                objParam.Add("@job_date", PbrCaseGetModel.job_date);
                objParam.Add("@ref_id", PbrCaseGetModel.ref_id);
                objParam.Add("@created_by", PbrCaseGetModel.created_by);
                objParam.Add("@job_branch", PbrCaseGetModel.job_branch);
                objParam.Add("@location_branch", PbrCaseGetModel.location_branch);
                objParam.Add("@pMessage", PbrCaseGetModel.pMessage);

                Connection();
                VSK_PACKING.Open();
                List<PbrCaseGetModel> PbrList = SqlMapper.Query<PbrCaseGetModel>(VSK_PACKING, "SP_PACKING_CASE_CREATE_BR", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();
                VSK_PACKING.Close();
                return PbrList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public List<PbrCaseGetModel> PACKING_CASE_LIST_BR(PbrCaseGetModel PbrCaseGetModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@mode", PbrCaseGetModel.mode);
                objParam.Add("@job_date_start", PbrCaseGetModel.job_date_start);
                objParam.Add("@job_date_end", PbrCaseGetModel.job_date_end);
                objParam.Add("@job_status", PbrCaseGetModel.job_status);
                objParam.Add("@job_loading", PbrCaseGetModel.job_loading);
                objParam.Add("@job_no", PbrCaseGetModel.job_no);
                objParam.Add("@job_ref", PbrCaseGetModel.job_ref);
                objParam.Add("@job_case", PbrCaseGetModel.job_case);
                objParam.Add("@item_barcode", PbrCaseGetModel.item_barcode);
                objParam.Add("@job_branch", PbrCaseGetModel.job_branch);
                objParam.Add("@event_status", PbrCaseGetModel.event_status);
                objParam.Add("@location_branch", PbrCaseGetModel.location_branch);
                objParam.Add("@pages", PbrCaseGetModel.pages);
                objParam.Add("@show", PbrCaseGetModel.show);

                Connection();
                VSK_PACKING.Open();
                List<PbrCaseGetModel> PbrList = SqlMapper.Query<PbrCaseGetModel>(VSK_PACKING, "SP_PACKING_CASE_LIST_BR", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();
                VSK_PACKING.Close();
                return PbrList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public List<PbrCaseGetModel> PACKING_CASE_UPDATE_BR(PbrCaseGetModel PbrCaseGetModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@ref_id", PbrCaseGetModel.ref_id);
                objParam.Add("@job_no", PbrCaseGetModel.job_no);
                objParam.Add("@job_assige", PbrCaseGetModel.job_assige);
                objParam.Add("@job_status", PbrCaseGetModel.job_status);
                objParam.Add("@job_description", PbrCaseGetModel.job_description);
                objParam.Add("@created_by", PbrCaseGetModel.created_by);

                Connection();
                VSK_PACKING.Open();
                List<PbrCaseGetModel> PbrList = SqlMapper.Query<PbrCaseGetModel>(VSK_PACKING, "SP_PACKING_CASE_UPDATE_BR", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();
                VSK_PACKING.Close();
                return PbrList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public List<PbrCaseGetModel> PACKING_CASE_HISTORY_BR(PbrCaseGetModel PbrCaseGetModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@mode", PbrCaseGetModel.mode);
                objParam.Add("@ref_id", PbrCaseGetModel.ref_id);
                objParam.Add("@job_no", PbrCaseGetModel.job_no);

                Connection();
                VSK_PACKING.Open();
                List<PbrCaseGetModel> PbrList = SqlMapper.Query<PbrCaseGetModel>(VSK_PACKING, "SP_PACKING_CASE_HISTORY_BR", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();
                VSK_PACKING.Close();
                return PbrList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public List<PbrCaseGetModel> PACKING_CASE_SCAN_CREATE_BR(PbrCaseGetModel PbrCaseGetModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@job_qty", PbrCaseGetModel.job_qty);
                objParam.Add("@job_scan", PbrCaseGetModel.job_scan);
                objParam.Add("@job_no", PbrCaseGetModel.job_no);
                objParam.Add("@ref_id", PbrCaseGetModel.ref_id);
                objParam.Add("@created_by", PbrCaseGetModel.created_by);
                objParam.Add("@pMessage", PbrCaseGetModel.pMessage);

                Connection();
                VSK_PACKING.Open();
                List<PbrCaseGetModel> PbrList = SqlMapper.Query<PbrCaseGetModel>(VSK_PACKING, "SP_PACKING_CASE_SCAN_CREATE_BR", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();
                VSK_PACKING.Close();
                return PbrList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public List<PbrCaseGetModel> PACKING_CASE_SCAN_LIST_BR(PbrCaseGetModel PbrCaseGetModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@mode", PbrCaseGetModel.mode);
                objParam.Add("@ref_id", PbrCaseGetModel.ref_id);
                objParam.Add("@job_no", PbrCaseGetModel.job_no);

                Connection();
                VSK_PACKING.Open();
                List<PbrCaseGetModel> PbrList = SqlMapper.Query<PbrCaseGetModel>(VSK_PACKING, "SP_PACKING_CASE_SCAN_LIST_BR", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();
                VSK_PACKING.Close();
                return PbrList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }



        public List<PbrLoadingModel> PACKING_TMS_GET_BR(PbrLoadingModel PbrLoadingModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@ref_id", PbrLoadingModel.ref_id);

                Connection();
                VSK_PACKING.Open();
                List<PbrLoadingModel> PbrList = SqlMapper.Query<PbrLoadingModel>(VSK_PACKING, "SP_PACKING_TMS_GET_BR", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();
                VSK_PACKING.Close();
                return PbrList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public List<ResponseSelect2Model> PACKING_MASTER_BR(ResponseSelect2Model ResponseSelect2Model)
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

                List<ResponseSelect2Model> PbrList = SqlMapper.Query<ResponseSelect2Model>(VSK_PACKING, "SP_PACKING_MASTER_BR", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();

                VSK_PACKING.Close();
                return PbrList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }


        public List<PbrItemModel> PACKING_ITEM_UPDATE_BR_V2(PbrItemModel PbrItemModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@ref_id", PbrItemModel.ref_id);
                objParam.Add("@job_no", PbrItemModel.job_no);
                objParam.Add("@inv_number", PbrItemModel.inv_number);
                objParam.Add("@job_qty", PbrItemModel.job_qty);
                objParam.Add("@job_scan", PbrItemModel.job_scan);
                objParam.Add("@updated_by", PbrItemModel.updated_by);
                objParam.Add("@pMessage", PbrItemModel.pMessage);

                Connection();
                VSK_PACKING.Open();
                List<PbrItemModel> PbrList = SqlMapper.Query<PbrItemModel>(VSK_PACKING, "SP_PACKING_ITEM_UPDATE_BR", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();
                VSK_PACKING.Close();
                return PbrList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }


        public List<string> PACKING_ITEM_FIND_BARCODE(string ref_id, string job_scan)
        {
            try
            {

                string SQLQuery = "";
                SQLQuery += "SELECT RTRIM(t.item_barcode) AS check_barcode ";
                SQLQuery += "FROM packing_item t WHERE t.record_status = 1 AND t.ref_id = '" + ref_id + "' ";
                SQLQuery += "AND ( t.item_spcodes = '" + job_scan + "' OR RTRIM(t.item_barcode) = RTRIM('" + job_scan + "') OR RTRIM(t.item_ean13) = RTRIM('" + job_scan + "') ) ";
                Connection();
                VSK_PACKING.Open();
                List<string> _ResponseData = VSK_PACKING.Query<string>(SQLQuery).ToList();
                VSK_PACKING.Close();
                return _ResponseData.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public List<PbrItemBatchScanModel> PACKING_SCAN_CREATE(PbrItemBatchScanModel PbrItemBatchScanModel)
        {
            try
            {

                string SQLQuery = "";
                SQLQuery += "INSERT INTO packing_scan ";
                SQLQuery += "VALUES ( NEWID() ,'" + PbrItemBatchScanModel.ref_id + "' ";
                SQLQuery += ",'" + PbrItemBatchScanModel.job_no + "' ,'" + PbrItemBatchScanModel.job_scan + "' ,'" + PbrItemBatchScanModel.job_qty + "' ";
                SQLQuery += ",'" + PbrItemBatchScanModel.updated_by + "' ,GETDATE() ,'PENDING' ";
                SQLQuery += ",'" + PbrItemBatchScanModel.pMessage + "' ,'OUT' , 1 )";

                Connection();
                VSK_PACKING.Open();
                List<PbrItemBatchScanModel> _ResponseData = VSK_PACKING.Query<PbrItemBatchScanModel>(SQLQuery).ToList();
                VSK_PACKING.Close();
                return _ResponseData.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public void InsertPackingScan(string ref_id, string job_no, string job_scan, int job_qty, int updated_by, string pMessage)
        {
            
            string sqlQuery = @"
                                INSERT INTO packing_scan    
                                VALUES (
                                    NEWID(),
                                    @ref_id,
                                    @job_no,
                                    @job_scan,
                                    @job_qty,
                                    @updated_by,
                                    GETDATE(),
                                    'PENDING',
                                    @pMessage,
                                    'OUT',
                                    1
                                )";

            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["VSK_BR_247"].ToString()))
            {
                using (SqlCommand command = new SqlCommand(sqlQuery, connection))
                {
                    command.Parameters.AddWithValue("@ref_id", ref_id);
                    command.Parameters.AddWithValue("@job_no", job_no);
                    command.Parameters.AddWithValue("@job_scan", job_scan);
                    command.Parameters.AddWithValue("@job_qty", job_qty);
                    command.Parameters.AddWithValue("@updated_by", updated_by);
                    command.Parameters.AddWithValue("@pMessage", pMessage);

                    try
                    {
                        connection.Open();
                        command.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        // จัดการกับข้อผิดพลาดตามความเหมาะสม
                        throw ex;
                    }
                }
            }
        }

    }

}