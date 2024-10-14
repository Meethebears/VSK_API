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
    public class PackingRepository : Controller
    {

        #region Connection_SQL Server
        //-------------------Start Connection_SQL ------------------------//
        public SqlConnection VSK_PACKING;

        private void Connection()
        {
            //VSK_PACKING = new SqlConnection(ConfigurationManager.ConnectionStrings["VSK_PACKING"].ToString());
            //VSK_PACKING = new SqlConnection(ConfigurationManager.ConnectionStrings["VSK_TRP"].ToString());
            VSK_PACKING = new SqlConnection(ConfigurationManager.ConnectionStrings["VSK_TRP_187"].ToString());
        }
        //-------------------End Connection_SQL ------------------------//
        #endregion

        public List<TempModel> Trp_Packing_Check_Drop(TempModel TempModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@emmas_code", TempModel.emmas_code);
                objParam.Add("@packing_delivery_addr", TempModel.packing_delivery_addr);
                objParam.Add("@packing_round", TempModel.packing_round);
                objParam.Add("@packing_job_date", TempModel.packing_job_date);

                Connection();
                VSK_PACKING.Open();

                List<TempModel> TrpList = SqlMapper.Query<TempModel>(VSK_PACKING, "SP_PACKING_CHECK_DROP", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();

                VSK_PACKING.Close();
                return TrpList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public List<TempModel> Trp_Packing_Job(TempModel TempModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@temp_id", TempModel.temp_id);
                objParam.Add("@packing_job_date", TempModel.packing_job_date);
                objParam.Add("@packing_round", TempModel.packing_round);
                objParam.Add("@packing_type", TempModel.packing_type);
                objParam.Add("@packing_evcode", TempModel.packing_evcode);
                objParam.Add("@packing_evname", TempModel.packing_evname);
                objParam.Add("@packing_tsno", TempModel.packing_tsno);
                objParam.Add("@vendor_id", TempModel.vendor_id);
                objParam.Add("@lov_deliverycost_code", TempModel.lov_deliverycost_code);
                objParam.Add("@emmas_code", TempModel.emmas_code);
                objParam.Add("@packing_delivery_name", TempModel.packing_delivery_name);
                objParam.Add("@packing_delivery_addr", TempModel.packing_delivery_addr);
                objParam.Add("@packing_delivery_emlocation", TempModel.packing_delivery_emlocation);
                objParam.Add("@emmas_sender_name", TempModel.emmas_sender_name);
                objParam.Add("@emmas_addr_id", TempModel.emmas_addr_id);
                objParam.Add("@packing_delivery_tumbol", TempModel.packing_delivery_tumbol);
                objParam.Add("@packing_delivery_amphur", TempModel.packing_delivery_amphur);
                objParam.Add("@packing_delivery_provinc", TempModel.packing_delivery_provinc);
                objParam.Add("@packing_delivery_zip", TempModel.packing_delivery_zip);
                objParam.Add("@created_by", TempModel.created_by);
                objParam.Add("@updated_by", TempModel.updated_by);
                objParam.Add("@mode", TempModel.mode);

                Connection();
                VSK_PACKING.Open();

                List<TempModel> TrpList = SqlMapper.Query<TempModel>(VSK_PACKING, "SP_PACKING_JOB_ACTION", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();

                VSK_PACKING.Close();
                return TrpList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public List<TempModel> Trp_Packing_Job_Detail(TempModel TempModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@packing_job_no", TempModel.packing_job_no);

                Connection();
                VSK_PACKING.Open();

                List<TempModel> TrpList = SqlMapper.Query<TempModel>(VSK_PACKING, "SP_PACKING_JOB_DETAIL", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();

                VSK_PACKING.Close();
                return TrpList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public List<PackingModel> Trp_Packing_Invoice(PackingModel PackingModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@keywords", PackingModel.keywords);

                Connection();
                VSK_PACKING.Open();

                List<PackingModel> TrpList = SqlMapper.Query<PackingModel>(VSK_PACKING, "SP_PACKING_INVOICE_DETAIL", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();

                VSK_PACKING.Close();
                return TrpList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public List<TempModel> Trp_Packing_Box_Detail(TempModel TempModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@packing_job_no", TempModel.packing_job_no);

                Connection();
                VSK_PACKING.Open();

                List<TempModel> TrpList = SqlMapper.Query<TempModel>(VSK_PACKING, "SP_PACKING_BOX_DETAIL", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();

                VSK_PACKING.Close();
                return TrpList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public List<TempModel> Trp_Packing_Box_Update(TempModel TempModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@packing_job_id", TempModel.packing_job_id);
                objParam.Add("@packing_job_no", TempModel.packing_job_no);
                objParam.Add("@packing_box_qty", TempModel.packing_box_qty);
                objParam.Add("@packing_box_a", TempModel.packing_box_a);
                objParam.Add("@packing_box_b", TempModel.packing_box_b);
                objParam.Add("@packing_box_c", TempModel.packing_box_c);
                objParam.Add("@packing_box_d", TempModel.packing_box_d);
                objParam.Add("@packing_box_e", TempModel.packing_box_e);
                objParam.Add("@packing_box_f", TempModel.packing_box_f);
                objParam.Add("@packing_box_z", TempModel.packing_box_z);
                objParam.Add("@temp_id", TempModel.temp_id);
                objParam.Add("@created_by", TempModel.created_by);

                Connection();
                VSK_PACKING.Open();

                List<TempModel> TrpList = SqlMapper.Query<TempModel>(VSK_PACKING, "SP_PACKING_BOX_UPDATE", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();

                VSK_PACKING.Close();
                return TrpList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public List<TempModel> Trp_Packing_Box_Check(TempModel TempModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@packing_job_date", TempModel.packing_job_date);
                objParam.Add("@emmas_code", TempModel.emmas_code);
                objParam.Add("@packing_delivery_emlocation", TempModel.packing_delivery_emlocation);

                Connection();
                VSK_PACKING.Open();

                List<TempModel> TrpList = SqlMapper.Query<TempModel>(VSK_PACKING, "SP_PACKING_BOX_CHECK", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();

                VSK_PACKING.Close();
                return TrpList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public List<TempModel> Trp_Packing_Share_Box_Create(TempModel TempModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@packing_job_id", TempModel.packing_job_id);
                objParam.Add("@packing_job_no", TempModel.packing_job_no);
                objParam.Add("@packing_share_job_id", TempModel.packing_share_job_id);
                objParam.Add("@packing_share_job_no", TempModel.packing_share_job_no);
                objParam.Add("@packing_share_box_id", TempModel.packing_share_box_id);
                objParam.Add("@packing_share_box_name", TempModel.packing_share_box_name);
                objParam.Add("@packing_share_box_qty", TempModel.packing_share_box_qty);
                objParam.Add("@temp_id", TempModel.temp_id);
                objParam.Add("@created_by", TempModel.created_by);
                objParam.Add("@packing_share_desrcipt", TempModel.packing_share_desrcipt);

                Connection();
                VSK_PACKING.Open();

                List<TempModel> TrpList = SqlMapper.Query<TempModel>(VSK_PACKING, "SP_PACKING_SHARE_BOX_CREATE", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();

                VSK_PACKING.Close();
                return TrpList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public List<TempModel> Trp_Packing_Share_Box_Detail(TempModel TempModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@packing_job_no", TempModel.packing_job_no);

                Connection();
                VSK_PACKING.Open();

                List<TempModel> TrpList = SqlMapper.Query<TempModel>(VSK_PACKING, "SP_PACKING_SHARE_BOX_DETAIL", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();

                VSK_PACKING.Close();
                return TrpList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public List<TempModel> Trp_Packing_Share_Box_Verify(TempModel TempModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@packing_job_no", TempModel.packing_job_no);

                Connection();
                VSK_PACKING.Open();

                List<TempModel> TrpList = SqlMapper.Query<TempModel>(VSK_PACKING, "SP_PACKING_SHARE_BOX_VERIFY", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();

                VSK_PACKING.Close();
                return TrpList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public List<TempModel> Trp_Packing_Share_Box_Delete(TempModel TempModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@packing_job_no", TempModel.packing_job_no);
                objParam.Add("@updated_by", TempModel.updated_by);

                Connection();
                VSK_PACKING.Open();

                List<TempModel> TrpList = SqlMapper.Query<TempModel>(VSK_PACKING, "SP_PACKING_SHARE_BOX_DELETE", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();

                VSK_PACKING.Close();
                return TrpList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public List<TempModel> Trp_Packing_Invoice_List(TempModel TempModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@packing_job_no", TempModel.packing_job_no);

                Connection();
                VSK_PACKING.Open();

                List<TempModel> TrpList = SqlMapper.Query<TempModel>(VSK_PACKING, "SP_PACKING_INVOICE_LIST", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();

                VSK_PACKING.Close();
                return TrpList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public List<TempModel> Trp_Packing_Invoice_Create(TempModel TempModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@keywords", TempModel.keywords);
                objParam.Add("@temp_id", TempModel.temp_id);
                objParam.Add("@packing_job_id", TempModel.packing_job_id);
                objParam.Add("@packing_job_no", TempModel.packing_job_no);
                objParam.Add("@salefile_evadd", TempModel.salefile_evadd);
                //objParam.Add("@packing_box", TempModel.packing_box);
                objParam.Add("@created_by", TempModel.created_by);

                Connection();
                VSK_PACKING.Open();

                List<TempModel> TrpList = SqlMapper.Query<TempModel>(VSK_PACKING, "SP_PACKING_INVOICE_CREATE", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();

                VSK_PACKING.Close();
                return TrpList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public List<TempModel> Trp_Packing_Invoice_Delete(TempModel TempModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@trans_id", TempModel.trans_id);
                objParam.Add("@temp_id", TempModel.temp_id);

                Connection();
                VSK_PACKING.Open();

                List<TempModel> TrpList = SqlMapper.Query<TempModel>(VSK_PACKING, "SP_PACKING_INVOICE_DELETE", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();

                VSK_PACKING.Close();
                return TrpList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public List<TempModel> Trp_Packing_Job_Temp_Create(TempModel TempModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@temp_id", TempModel.temp_id);
                objParam.Add("@vendor_id", TempModel.vendor_id);
                objParam.Add("@lov_deliverycost_code", TempModel.lov_deliverycost_code);
                objParam.Add("@emmas_code", TempModel.emmas_code);
                objParam.Add("@packing_delivery_name", TempModel.packing_delivery_name);
                objParam.Add("@packing_delivery_addr", TempModel.packing_delivery_addr);
                objParam.Add("@emmas_sender_name", TempModel.emmas_sender_name);
                objParam.Add("@temp_id", TempModel.temp_id);
                objParam.Add("@created_by", TempModel.created_by);

                Connection();
                VSK_PACKING.Open();

                List<TempModel> TrpList = SqlMapper.Query<TempModel>(VSK_PACKING, "SP_PACKING_JOB_CREATE", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();

                VSK_PACKING.Close();
                return TrpList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public List<TempModel> Trp_Packing_Job_Temp_Delete(TempModel TempModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@packing_job_no", TempModel.packing_job_no);
                objParam.Add("@updated_by", TempModel.updated_by);

                Connection();
                VSK_PACKING.Open();

                List<TempModel> TrpList = SqlMapper.Query<TempModel>(VSK_PACKING, "SP_PACKING_JOB_DELETE", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();

                VSK_PACKING.Close();
                return TrpList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public List<TempModel> Trp_Packing_List(TempModel TempModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@packing_jobdate_start", TempModel.packing_jobdate_start);
                objParam.Add("@packing_jobdate_end", TempModel.packing_jobdate_end);
                objParam.Add("@packing_job_no", TempModel.packing_job_no);
                objParam.Add("@emmas_code", TempModel.emmas_code);
                objParam.Add("@packing_delivery_name", TempModel.packing_delivery_name);
                objParam.Add("@lov_deliverycost_code", TempModel.lov_deliverycost_code);
                objParam.Add("@created_by", TempModel.created_by);

                Connection();
                VSK_PACKING.Open();

                List<TempModel> TrpList = SqlMapper.Query<TempModel>(VSK_PACKING, "SP_PACKING_LIST", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();

                VSK_PACKING.Close();
                return TrpList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public List<TempModel> Trp_Packing_Detail(TempModel TempModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@packing_job_no", TempModel.packing_job_no);

                Connection();
                VSK_PACKING.Open();

                List<TempModel> TrpList = SqlMapper.Query<TempModel>(VSK_PACKING, "SP_PACKING_DETAIL", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();

                VSK_PACKING.Close();
                return TrpList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public List<TempModel> Trp_Packing_Item_Job(TempModel TempModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@job_no", TempModel.job_no);
                objParam.Add("@temp_id", TempModel.temp_id);
                objParam.Add("@created_by", TempModel.created_by);

                Connection();
                VSK_PACKING.Open();

                List<TempModel> TrpList = SqlMapper.Query<TempModel>(VSK_PACKING, "SP_PACKING_ITEM_JOB", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();

                VSK_PACKING.Close();
                return TrpList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public List<TempModel> Trp_Packing_Item_Update(TempModel TempModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@job_detail_qty", TempModel.job_detail_qty);
                objParam.Add("@keywords", TempModel.keywords);
                objParam.Add("@job_no", TempModel.job_no);
                objParam.Add("@updated_by", TempModel.updated_by);
                objParam.Add("@temp_id", TempModel.temp_id);
                objParam.Add("@pMessage", TempModel.pMessage);

                Connection();
                VSK_PACKING.Open();

                List<TempModel> TrpList = SqlMapper.Query<TempModel>(VSK_PACKING, "SP_PACKING_ITEM_UPDATE", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();

                VSK_PACKING.Close();
                return TrpList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public List<TempModel> Trp_Packing_Item_Status(TempModel TempModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@job_no", TempModel.job_no);
                objParam.Add("@temp_id", TempModel.temp_id);
                objParam.Add("@created_by", TempModel.created_by);

                Connection();
                VSK_PACKING.Open();

                List<TempModel> TrpList = SqlMapper.Query<TempModel>(VSK_PACKING, "SP_PACKING_ITEM_STATUS", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();

                VSK_PACKING.Close();
                return TrpList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public List<ResponseSelect2Model> Trp_Packing_Master(ResponseSelect2Model ResponseSelect2Model)
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

                List<ResponseSelect2Model> TrpList = SqlMapper.Query<ResponseSelect2Model>(VSK_PACKING, "SP_PACKING_MASTER", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();

                VSK_PACKING.Close();
                return TrpList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public List<TempModel> Trp_Packing_Cover_Sheet(TempModel TempModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@packing_job_no", TempModel.packing_job_no);

                Connection();
                VSK_PACKING.Open();

                List<TempModel> TrpList = SqlMapper.Query<TempModel>(VSK_PACKING, "RPT_PACKING_PRODUCT_COVER_SHEET", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();

                VSK_PACKING.Close();
                return TrpList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public List<TempModel> Trp_Packing_Check_Box_Create(TempModel TempModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@number", TempModel.number);
                objParam.Add("@delivery_cycle", TempModel.delivery_cycle);
                objParam.Add("@job_date", TempModel.job_date);
                objParam.Add("@temp_id", TempModel.temp_id);
                objParam.Add("@created_by", TempModel.created_by);
                objParam.Add("@pMessage", TempModel.pMessage);

                Connection();
                VSK_PACKING.Open();

                List<TempModel> TrpList = SqlMapper.Query<TempModel>(VSK_PACKING, "SP_PACKING_CHECK_BOX_CREATE", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();

                VSK_PACKING.Close();
                return TrpList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public List<TempModel> Trp_Packing_Check_Box_List(TempModel TempModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@mode", TempModel.mode);
                objParam.Add("@packing_job_no", TempModel.packing_job_no);
                objParam.Add("@delivery_cycle", TempModel.delivery_cycle);
                objParam.Add("@job_date", TempModel.job_date);
                objParam.Add("@temp_id", TempModel.temp_id);

                Connection();
                VSK_PACKING.Open();

                List<TempModel> TrpList = SqlMapper.Query<TempModel>(VSK_PACKING, "SP_PACKING_CHECK_BOX_LIST", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();

                VSK_PACKING.Close();
                return TrpList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public List<TempModel> Trp_Packing_Check_Box_Delete(TempModel TempModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@packing_job_no_bat", TempModel.packing_job_no_bat);
                objParam.Add("@updated_by", TempModel.updated_by);

                Connection();
                VSK_PACKING.Open();

                List<TempModel> TrpList = SqlMapper.Query<TempModel>(VSK_PACKING, "SP_PACKING_CHECK_BOX_DELETE", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();

                VSK_PACKING.Close();
                return TrpList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public List<TempModel> Trp_Packing_Check_Box_Update(TempModel TempModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@delivery_cycle", TempModel.delivery_cycle);
                objParam.Add("@job_date", TempModel.job_date);
                objParam.Add("@temp_id", TempModel.temp_id);
                objParam.Add("@updated_by", TempModel.updated_by);

                Connection();
                VSK_PACKING.Open();

                List<TempModel> TrpList = SqlMapper.Query<TempModel>(VSK_PACKING, "SP_PACKING_CHECK_BOX_UPDATE", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();

                VSK_PACKING.Close();
                return TrpList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public List<TempModel> Trp_Packing_Check_Box_Remark(TempModel TempModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@packing_share_desrcipt", TempModel.packing_share_desrcipt);
                objParam.Add("@delivery_cycle", TempModel.delivery_cycle);
                objParam.Add("@job_date", TempModel.job_date);
                objParam.Add("@temp_id", TempModel.temp_id);
                objParam.Add("@created_by", TempModel.created_by);

                Connection();
                VSK_PACKING.Open();

                List<TempModel> TrpList = SqlMapper.Query<TempModel>(VSK_PACKING, "SP_PACKING_CHECK_BOX_REMARK", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();

                VSK_PACKING.Close();
                return TrpList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public List<TempModel> Trp_Packing_Check_Box_Search(TempModel TempModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@mode", TempModel.mode);
                objParam.Add("@delivery_cycle", TempModel.delivery_cycle);
                objParam.Add("@packing_jobdate_start", TempModel.packing_jobdate_start);
                objParam.Add("@packing_jobdate_end", TempModel.packing_jobdate_end);
                objParam.Add("@event_status", TempModel.event_status);

                Connection();
                VSK_PACKING.Open();

                List<TempModel> TrpList = SqlMapper.Query<TempModel>(VSK_PACKING, "SP_PACKING_CHECK_BOX_SEARCH", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();

                VSK_PACKING.Close();
                return TrpList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public List<TempModel> Trp_Packing_List_Mobile(TempModel TempModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@packing_jobdate_start", TempModel.packing_jobdate_start);
                objParam.Add("@packing_jobdate_end", TempModel.packing_jobdate_end);
                objParam.Add("@packing_job_no", TempModel.packing_job_no);
                objParam.Add("@emmas_code", TempModel.emmas_code);
                objParam.Add("@packing_delivery_name", TempModel.packing_delivery_name);
                objParam.Add("@lov_deliverycost_code", TempModel.lov_deliverycost_code);
                objParam.Add("@created_by", TempModel.created_by);
                objParam.Add("@keywords", TempModel.keywords);
                objParam.Add("@pages", TempModel.pages);
                objParam.Add("@show", TempModel.show);

                Connection();
                VSK_PACKING.Open();

                List<TempModel> TrpList = SqlMapper.Query<TempModel>(VSK_PACKING, "SP_PACKING_LIST_MOBILE", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();

                VSK_PACKING.Close();
                return TrpList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public List<TempModel> Trp_Packing_Check_Address(TempModel TempModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@emmas_code", TempModel.emmas_code);
                objParam.Add("@invemlocation", TempModel.invemlocation);

                Connection();
                VSK_PACKING.Open();

                List<TempModel> TrpList = SqlMapper.Query<TempModel>(VSK_PACKING, "SP_PACKING_CHECK_ADDRESS", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();

                VSK_PACKING.Close();
                return TrpList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public List<TempModel> Trp_Packing_Check_Box_Tms_List(TempModel TempModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@job_date", TempModel.job_date);
                objParam.Add("@delivery_cycle", TempModel.delivery_cycle);

                Connection();
                VSK_PACKING.Open();

                List<TempModel> TrpList = SqlMapper.Query<TempModel>(VSK_PACKING, "SP_PACKING_CHECK_BOX_TMS_LIST", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();

                VSK_PACKING.Close();
                return TrpList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

      
        public List<TempModel> Trp_Packing_Remark_Create(TempModel TempModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@temp_id", TempModel.temp_id);
                objParam.Add("@job_no", TempModel.job_no);
                objParam.Add("@job_date", TempModel.job_date);
                objParam.Add("@round", TempModel.round);
                objParam.Add("@remark_date", TempModel.remark_date);
                objParam.Add("@remark_type", TempModel.remark_type);
                objParam.Add("@remark_text", TempModel.remark_text);
                objParam.Add("@created_by", TempModel.created_by);

                Connection();
                VSK_PACKING.Open();

                List<TempModel> TrpList = SqlMapper.Query<TempModel>(VSK_PACKING, "SP_PACKING_REMARK_CREATE", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();

                VSK_PACKING.Close();
                return TrpList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public List<TempModel> Trp_Packing_Remark_Delete(TempModel TempModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@trans_id", TempModel.trans_id);
                objParam.Add("@updated_by", TempModel.updated_by);

                Connection();
                VSK_PACKING.Open();

                List<TempModel> TrpList = SqlMapper.Query<TempModel>(VSK_PACKING, "SP_PACKING_REMARK_DELETE", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();

                VSK_PACKING.Close();
                return TrpList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public List<TempModel> Trp_Packing_Remark_List(TempModel TempModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@temp_id", TempModel.temp_id);
                objParam.Add("@remark_type", TempModel.remark_type);
                objParam.Add("@job_no", TempModel.job_no);

                Connection();
                VSK_PACKING.Open();

                List<TempModel> TrpList = SqlMapper.Query<TempModel>(VSK_PACKING, "SP_PACKING_REMARK_LIST", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();

                VSK_PACKING.Close();
                return TrpList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public List<TempModel> Trp_Packing_Job_Tms_Get(TempModel TempModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@temp_id", TempModel.temp_id);

                Connection();
                VSK_PACKING.Open();

                List<TempModel> TrpList = SqlMapper.Query<TempModel>(VSK_PACKING, "SP_PACKING_JOB_TMS_GET", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();

                VSK_PACKING.Close();
                return TrpList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }


        public List<TempModel> Trp_Packing_Item_List(TempModel TempModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@job_no", TempModel.job_no);
                objParam.Add("@pages", TempModel.pages);
                objParam.Add("@show", TempModel.show);

                Connection();
                VSK_PACKING.Open();

                List<TempModel> TrpList = SqlMapper.Query<TempModel>(VSK_PACKING, "SP_PACKING_ITEM_LIST", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();

                VSK_PACKING.Close();
                return TrpList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public List<TempModel> Trp_Packing_Item_Sum(TempModel TempModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@job_no", TempModel.job_no);

                Connection();
                VSK_PACKING.Open();

                List<TempModel> TrpList = SqlMapper.Query<TempModel>(VSK_PACKING, "SP_PACKING_ITEM_SUM", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();

                VSK_PACKING.Close();
                return TrpList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }


        public List<TempModel> Trp_Packing_Check_Box_Update_Mm(TempModel TempModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@delivery_cycle", TempModel.delivery_cycle);
                objParam.Add("@job_date", TempModel.job_date);
                objParam.Add("@mm_manifestNoteNumber", TempModel.mm_manifestNoteNumber);
                objParam.Add("@updated_by", TempModel.updated_by);

                Connection();
                VSK_PACKING.Open();

                List<TempModel> TrpList = SqlMapper.Query<TempModel>(VSK_PACKING, "SP_PACKING_CHECK_BOX_UPDATE_MM", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();

                VSK_PACKING.Close();
                return TrpList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public List<TempModel> Trp_Packing_Job_Mm_Get(TempModel TempModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@temp_id", TempModel.temp_id);
                objParam.Add("@delivery_cycle", TempModel.delivery_cycle);
                objParam.Add("@job_date", TempModel.job_date);

                Connection();

                VSK_PACKING.Open();

                List<TempModel> TrpList = SqlMapper.Query<TempModel>(VSK_PACKING, "SP_PACKING_JOB_MM_GET", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();

                VSK_PACKING.Close();

                return TrpList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }

}