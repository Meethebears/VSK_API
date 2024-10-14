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
    public class DailyCasherRepository : Controller
    {
        #region Connection_SQL Server
        //-------------------Start Connection_SQL ------------------------//
        public SqlConnection VSK_CA;
        public SqlConnection VSK_CA_VSK;
        public SqlConnection VSK_CA_VSM;
        public SqlConnection VSK_CA_VSF;
        public SqlConnection VSK_CA_KLH;
        public SqlConnection VSK_CA_LKS;
        public SqlConnection VSK_CA_LLK;
        public SqlConnection VSK_CA_NWM;
        public SqlConnection VSK_CA_SNK;
        public SqlConnection VSK_CA_EBB;
        public SqlConnection VSK_CA_RTB;
        public SqlConnection VSK_CA_STP;
        // Open Branch New //
        //public SqlConnection ???_DATA;
        // End Branch New //

        private void Connection()
        {
            VSK_CA = new SqlConnection(ConfigurationManager.ConnectionStrings["VSK_CA_187"].ToString());
            VSK_CA_VSK = new SqlConnection(ConfigurationManager.ConnectionStrings["VSK_CA_VSK"].ToString());
            VSK_CA_VSM = new SqlConnection(ConfigurationManager.ConnectionStrings["VSK_CA_VSM"].ToString());
            //VSK_CA_VSK = new SqlConnection(ConfigurationManager.ConnectionStrings["VSK_CA_VSK"].ToString());
            VSK_CA_VSF = new SqlConnection(ConfigurationManager.ConnectionStrings["VSK_CA_VSF"].ToString());
            VSK_CA_KLH = new SqlConnection(ConfigurationManager.ConnectionStrings["VSK_CA_KLH"].ToString());
            VSK_CA_LKS = new SqlConnection(ConfigurationManager.ConnectionStrings["VSK_CA_LKS"].ToString());
            VSK_CA_LLK = new SqlConnection(ConfigurationManager.ConnectionStrings["VSK_CA_LLK"].ToString());
            VSK_CA_NWM = new SqlConnection(ConfigurationManager.ConnectionStrings["VSK_CA_NWM"].ToString());
            VSK_CA_SNK = new SqlConnection(ConfigurationManager.ConnectionStrings["VSK_CA_SNK"].ToString());
            VSK_CA_EBB = new SqlConnection(ConfigurationManager.ConnectionStrings["VSK_CA_EBB"].ToString());
            VSK_CA_RTB = new SqlConnection(ConfigurationManager.ConnectionStrings["VSK_CA_RTB"].ToString());
            VSK_CA_STP = new SqlConnection(ConfigurationManager.ConnectionStrings["VSK_CA_STP"].ToString());
            // Open Branch New //
            // ???_DATA = new SqlConnection(ConfigurationManager.ConnectionStrings["???_DATA"].ToString());
            // End Branch New //
        }
        //-------------------End Connection_SQL ------------------------//
        #endregion

        public List<InvoiceModel> INVOICE_GET(InvoiceModel InvoiceModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@number", InvoiceModel.number);
                objParam.Add("@branch", InvoiceModel.branch);

                Connection();

                List<InvoiceModel> SlipList;

                if (InvoiceModel.branch == "VSK" || InvoiceModel.branch == "VSM")
                {
                    VSK_CA_VSK.Open();
                    SlipList = SqlMapper.Query<InvoiceModel>(VSK_CA_VSK, "SP_INVOICE_GET", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();
                    VSK_CA_VSK.Close();
                }
                else if (InvoiceModel.branch == "VSF")
                {
                    VSK_CA_VSF.Open();
                    SlipList = SqlMapper.Query<InvoiceModel>(VSK_CA_VSF, "SP_INVOICE_GET", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();
                    VSK_CA_VSF.Close();
                }
                else if (InvoiceModel.branch == "KLH")
                {
                    VSK_CA_KLH.Open();
                    SlipList = SqlMapper.Query<InvoiceModel>(VSK_CA_KLH, "SP_INVOICE_GET", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();
                    VSK_CA_KLH.Close();
                }
                else if (InvoiceModel.branch == "LKS" || InvoiceModel.branch == "KSW")
                {
                    VSK_CA_LKS.Open();
                    SlipList = SqlMapper.Query<InvoiceModel>(VSK_CA_LKS, "SP_INVOICE_GET", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();
                    VSK_CA_LKS.Close();
                }
                else if (InvoiceModel.branch == "LLK")
                {
                    VSK_CA_LLK.Open();
                    SlipList = SqlMapper.Query<InvoiceModel>(VSK_CA_LLK, "SP_INVOICE_GET", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();
                    VSK_CA_LLK.Close();
                }
                else if (InvoiceModel.branch == "NWM")
                {
                    VSK_CA_NWM.Open();
                    SlipList = SqlMapper.Query<InvoiceModel>(VSK_CA_NWM, "SP_INVOICE_GET", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();
                    VSK_CA_NWM.Close();
                }
                else if (InvoiceModel.branch == "SNK")
                {
                    VSK_CA_SNK.Open();
                    SlipList = SqlMapper.Query<InvoiceModel>(VSK_CA_SNK, "SP_INVOICE_GET", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();
                    VSK_CA_SNK.Close();
                }
                else if (InvoiceModel.branch == "PYS")
                {
                    VSK_CA_VSK.Open();
                    SlipList = SqlMapper.Query<InvoiceModel>(VSK_CA_VSK, "SP_INVOICE_GET", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();
                    VSK_CA_VSK.Close();
                }
                else if (InvoiceModel.branch == "EBB")
                {
                    VSK_CA_EBB.Open();
                    SlipList = SqlMapper.Query<InvoiceModel>(VSK_CA_EBB, "SP_INVOICE_GET", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();
                    VSK_CA_EBB.Close();
                }  
                else if (InvoiceModel.branch == "RTB")
                {
                    VSK_CA_RTB.Open();
                    SlipList = SqlMapper.Query<InvoiceModel>(VSK_CA_RTB, "SP_INVOICE_GET", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();
                    VSK_CA_RTB.Close();
                }
                else if (InvoiceModel.branch == "STP")
                {
                    VSK_CA_STP.Open();
                    SlipList = SqlMapper.Query<InvoiceModel>(VSK_CA_STP, "SP_INVOICE_GET", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();
                    VSK_CA_STP.Close();
                }
                // Open Branch New * ไม่ต้องไปเพิ่ม SP นะ *
                //else if (InvoiceModel.branch == "???")
                //{
                //    VSK_CA_???.Open();
                //    SlipList = SqlMapper.Query<InvoiceModel>(VSK_CA_???, "SP_INVOICE_GET", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();
                //    VSK_CA_???.Close();
                //}
                // End Branch New
                else
                {
                    VSK_CA.Open();
                    SlipList = SqlMapper.Query<InvoiceModel>(VSK_CA, "SP_INVOICE_GET", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();
                    VSK_CA.Close();
                }

                return SlipList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public List<InvoiceModel> INVOICE_VSK_GET(InvoiceModel InvoiceModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@number", InvoiceModel.number);
                objParam.Add("@branch", InvoiceModel.branch);

                Connection();

                List<InvoiceModel> SlipList;

                if (InvoiceModel.branch == "VSK" || InvoiceModel.branch == "VSM")
                {
                    VSK_CA_VSM.Open();
                    SlipList = SqlMapper.Query<InvoiceModel>(VSK_CA_VSM, "SP_INVOICE_GET_NEW", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();
                    VSK_CA_VSM.Close(); //VSK_CA_VSK
                }
                else if (InvoiceModel.branch == "VSF")
                {
                    VSK_CA_VSF.Open();
                    SlipList = SqlMapper.Query<InvoiceModel>(VSK_CA_VSF, "SP_INVOICE_GET_NEW", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();
                    VSK_CA_VSF.Close();
                }
                else if (InvoiceModel.branch == "KLH")
                {
                    VSK_CA_KLH.Open();
                    SlipList = SqlMapper.Query<InvoiceModel>(VSK_CA_KLH, "SP_INVOICE_GET_NEW", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();
                    VSK_CA_KLH.Close();
                }
                else if (InvoiceModel.branch == "LKS" || InvoiceModel.branch == "KSW")
                {
                    VSK_CA_LKS.Open();
                    SlipList = SqlMapper.Query<InvoiceModel>(VSK_CA_LKS, "SP_INVOICE_GET_NEW", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();
                    VSK_CA_LKS.Close();
                }
                else if (InvoiceModel.branch == "LLK")
                {
                    VSK_CA_LLK.Open();
                    SlipList = SqlMapper.Query<InvoiceModel>(VSK_CA_LLK, "SP_INVOICE_GET_NEW", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();
                    VSK_CA_LLK.Close();
                }
                else if (InvoiceModel.branch == "NWM")
                {
                    VSK_CA_NWM.Open();
                    SlipList = SqlMapper.Query<InvoiceModel>(VSK_CA_NWM, "SP_INVOICE_GET_NEW", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();
                    VSK_CA_NWM.Close();
                }
                else if (InvoiceModel.branch == "SNK")
                {
                    VSK_CA_SNK.Open();
                    SlipList = SqlMapper.Query<InvoiceModel>(VSK_CA_SNK, "SP_INVOICE_GET_NEW", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();
                    VSK_CA_SNK.Close();
                }
                else if (InvoiceModel.branch == "PYS")
                {
                    VSK_CA_VSK.Open();
                    SlipList = SqlMapper.Query<InvoiceModel>(VSK_CA_VSK, "SP_INVOICE_GET_NEW", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();
                    VSK_CA_VSK.Close();
                }
                else if (InvoiceModel.branch == "EBB")
                {
                    VSK_CA_EBB.Open();
                    SlipList = SqlMapper.Query<InvoiceModel>(VSK_CA_EBB, "SP_INVOICE_GET_NEW", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();
                    VSK_CA_EBB.Close();
                }
                else if (InvoiceModel.branch == "RTB")
                {
                    VSK_CA_RTB.Open();
                    SlipList = SqlMapper.Query<InvoiceModel>(VSK_CA_RTB, "SP_INVOICE_GET_NEW", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();
                    VSK_CA_RTB.Close();
                }
                else if (InvoiceModel.branch == "STP")
                {
                    VSK_CA_STP.Open();
                    SlipList = SqlMapper.Query<InvoiceModel>(VSK_CA_STP, "SP_INVOICE_GET_NEW", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();
                    VSK_CA_STP.Close();
                }
                // Open Branch New * ไม่ต้องไปเพิ่ม SP นะ *
                //else if (InvoiceModel.branch == "???")
                //{
                //    VSK_CA_???.Open();
                //    SlipList = SqlMapper.Query<InvoiceModel>(VSK_CA_???, "SP_INVOICE_GET_NEW", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();
                //    VSK_CA_???.Close();
                //}
                // End Branch New
                else
                {
                    VSK_CA.Open();
                    SlipList = SqlMapper.Query<InvoiceModel>(VSK_CA, "SP_INVOICE_GET_NEW", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();
                    VSK_CA.Close();
                }

                return SlipList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public List<DailyCasherModel> CUSTOMER_GET(string mode, string ref_id, string invdate, string invdate_start, string invdate_end, string invcode, string branch)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@mode", mode);
                objParam.Add("@ref_id", ref_id);
                objParam.Add("@invdate", invdate);
                objParam.Add("@invdate_start", invdate_start);
                objParam.Add("@invdate_end", invdate_end);
                objParam.Add("@invcode", invcode);
                objParam.Add("@branch", branch);

                Connection();
                VSK_CA.Open();

                List<DailyCasherModel> DailyList = SqlMapper.Query<DailyCasherModel>(VSK_CA, "SP_CA_DAILY_CASHIER_CUSTOMER_LIST", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();

                VSK_CA.Close();
                return DailyList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public List<InvoiceModel> CUSTOMER_GET_V1(string branch, string invdate)
        {

            try
            {

                string SQLQuery = "SELECT invdate , RTRIM(invcode) , RTRIM(invname) FROM dbo.salefile WHERE rdeleted = '0' AND invdate = " + invdate + "";

                Connection();

                List<InvoiceModel> MasList;

                if (branch == "VSK" || branch == "VSM")
                {
                    VSK_CA_VSM.Open();
                    MasList = VSK_CA_VSM.Query<InvoiceModel>(SQLQuery).ToList();
                    VSK_CA_VSM.Close();
                }
                else
                {
                    VSK_CA.Open();
                    MasList = VSK_CA.Query<InvoiceModel>(SQLQuery).ToList();
                    VSK_CA.Close();

                }

                return MasList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public List<DailyCasherModel> DAILY_CASHIER_LIST(DailyCasherModel DailyCasherModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@mode", DailyCasherModel.mode);
                objParam.Add("@job_date_start", DailyCasherModel.job_date_start);
                objParam.Add("@job_date_end", DailyCasherModel.job_date_end);
                objParam.Add("@branch", DailyCasherModel.branch);
                objParam.Add("@confirm_status", DailyCasherModel.confirm_status);
                objParam.Add("@created_by", DailyCasherModel.created_by);

                Connection();
                VSK_CA.Open();

                List<DailyCasherModel> DailyList = SqlMapper.Query<DailyCasherModel>(VSK_CA, "SP_CA_DAILY_CASHIER_LIST", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();

                VSK_CA.Close();
                return DailyList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public List<DailyCasherModel> DAILY_CASHIER_CHECK(DailyCasherModel DailyCasherModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@job_date", DailyCasherModel.job_date);
                objParam.Add("@branch", DailyCasherModel.branch);
                objParam.Add("@created_by", DailyCasherModel.created_by);

                Connection();
                VSK_CA.Open();

                List<DailyCasherModel> DailyList = SqlMapper.Query<DailyCasherModel>(VSK_CA, "SP_CA_DAILY_CASHIER_CHECK", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();

                VSK_CA.Close();
                return DailyList.ToList();

            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
        public List<DailyCasherModel> DAILY_CASHIER_SYNC(DailyCasherModel DailyCasherModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@mode", DailyCasherModel.mode);
                objParam.Add("@job_date", DailyCasherModel.job_date);
                objParam.Add("@created_by", DailyCasherModel.created_by);
                objParam.Add("@branch", DailyCasherModel.branch);

                Connection();
                VSK_CA.Open();

                List<DailyCasherModel> DailyList = SqlMapper.Query<DailyCasherModel>(VSK_CA, "SP_CA_DAILY_CASHIER_SYNC", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();

                VSK_CA.Close();
                return DailyList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public List<DailyCasherModel> DAILY_CASHIER_JOB(DailyCasherModel DailyCasherModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@mode", DailyCasherModel.mode);
                objParam.Add("@ref_id", DailyCasherModel.ref_id);
                objParam.Add("@job_date", DailyCasherModel.job_date);
                objParam.Add("@branch", DailyCasherModel.branch);
                objParam.Add("@cash", DailyCasherModel.cash);
                objParam.Add("@accrued", DailyCasherModel.accrued);
                objParam.Add("@edc", DailyCasherModel.edc);
                objParam.Add("@accrued_receive", DailyCasherModel.accrued_receive);
                objParam.Add("@transfer_payment", DailyCasherModel.transfer_payment);
                objParam.Add("@coupons", DailyCasherModel.coupons);
                objParam.Add("@description", DailyCasherModel.description);
                objParam.Add("@confirm_status", DailyCasherModel.confirm_status);
                objParam.Add("@event_status", DailyCasherModel.event_status);
                objParam.Add("@text_status", DailyCasherModel.text_status);
                objParam.Add("@created_by", DailyCasherModel.created_by);

                Connection();
                VSK_CA.Open();

                List<DailyCasherModel> DailyList = SqlMapper.Query<DailyCasherModel>(VSK_CA, "SP_CA_DAILY_CASHIER_JOB", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();

                VSK_CA.Close();
                return DailyList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public List<DailyCasherModel> DAILY_CASHIER_DETAIL(DailyCasherModel DailyCasherModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@ref_id", DailyCasherModel.ref_id);
                objParam.Add("@job_date", DailyCasherModel.job_date);
                objParam.Add("@branch", DailyCasherModel.branch);
                objParam.Add("@created_by", DailyCasherModel.created_by);

                Connection();
                VSK_CA.Open();

                List<DailyCasherModel> DailyList = SqlMapper.Query<DailyCasherModel>(VSK_CA, "SP_CA_DAILY_CASHIER_DETAIL", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();

                VSK_CA.Close();
                return DailyList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public List<DailyCasherModel> DAILY_CASHIER_ACTION(DailyCasherModel DailyCasherModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@mode", DailyCasherModel.mode);
                objParam.Add("@ref_id", DailyCasherModel.ref_id);
                objParam.Add("@job_date", DailyCasherModel.job_date);
                objParam.Add("@cash_amount", DailyCasherModel.cash_amount);
                objParam.Add("@branch", DailyCasherModel.branch);
                objParam.Add("@created_by", DailyCasherModel.created_by);

                Connection();
                VSK_CA.Open();

                List<DailyCasherModel> DailyList = SqlMapper.Query<DailyCasherModel>(VSK_CA, "SP_CA_DAILY_CASHIER_ACTION", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();

                VSK_CA.Close();
                return DailyList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public List<DailyCasherModel> DAILY_CASHIER_HISTORY(DailyCasherModel DailyCasherModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@mode", DailyCasherModel.mode);
                objParam.Add("@ref_id", DailyCasherModel.ref_id);

                Connection();
                VSK_CA.Open();

                List<DailyCasherModel> DailyList = SqlMapper.Query<DailyCasherModel>(VSK_CA, "SP_CA_DAILY_CASHIER_HISTORY", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();

                VSK_CA.Close();
                return DailyList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public List<DailyCasherModel> DAILY_CASHIER_UPDATE_STATUS(DailyCasherModel DailyCasherModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@mode", DailyCasherModel.mode);
                objParam.Add("@job_date", DailyCasherModel.job_date);
                objParam.Add("@branch", DailyCasherModel.branch);
                objParam.Add("@ref_id", DailyCasherModel.ref_id);
                objParam.Add("@description", DailyCasherModel.description);
                objParam.Add("@transfer_payment", DailyCasherModel.transfer_payment);
                objParam.Add("@accrued", DailyCasherModel.accrued);
                objParam.Add("@accrued_receive", DailyCasherModel.accrued_receive);
                objParam.Add("@updated_by", DailyCasherModel.updated_by);

                Connection();
                VSK_CA.Open();

                List<DailyCasherModel> DailyList = SqlMapper.Query<DailyCasherModel>(VSK_CA, "SP_CA_DAILY_CASHIER_UPDATE_STATUS", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();

                VSK_CA.Close();
                return DailyList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public List<DailyCasherModel> DAILY_CASHIER_FILE_LIST(DailyCasherModel DailyCasherModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@ref_id", DailyCasherModel.ref_id);
                objParam.Add("@job_date", DailyCasherModel.job_date);
                objParam.Add("@branch", DailyCasherModel.branch);

                Connection();
                VSK_CA.Open();

                List<DailyCasherModel> DailyList = SqlMapper.Query<DailyCasherModel>(VSK_CA, "SP_CA_DAILY_CASHIER_FILE_LIST", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();

                VSK_CA.Close();
                return DailyList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public List<DailyCasherModel> DAILY_CASHIER_FILE_UPLOAD(DailyCasherModel DailyCasherModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@ref_id", DailyCasherModel.ref_id);
                objParam.Add("@job_date", DailyCasherModel.job_date);
                objParam.Add("@branch", DailyCasherModel.branch);
                objParam.Add("@file_date", DailyCasherModel.file_date);
                objParam.Add("@file_type", DailyCasherModel.file_type);
                objParam.Add("@file_remark", DailyCasherModel.file_remark);
                objParam.Add("@file_name", DailyCasherModel.file_name);
                objParam.Add("@file_folder", DailyCasherModel.file_folder);
                objParam.Add("@file_path", DailyCasherModel.file_path);
                objParam.Add("@created_by", DailyCasherModel.created_by);

                Connection();
                VSK_CA.Open();

                List<DailyCasherModel> DailyList = SqlMapper.Query<DailyCasherModel>(VSK_CA, "SP_CA_DAILY_CASHIER_FILE_UPLOAD", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();

                VSK_CA.Close();
                return DailyList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public List<DailyCasherModel> DAILY_CASHIER_FILE_DELETE(DailyCasherModel DailyCasherModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@trans_id", DailyCasherModel.trans_id);
                objParam.Add("@ref_id", DailyCasherModel.ref_id);
                objParam.Add("@updated_by", DailyCasherModel.updated_by);

                Connection();
                VSK_CA.Open();

                List<DailyCasherModel> DailyList = SqlMapper.Query<DailyCasherModel>(VSK_CA, "SP_CA_DAILY_CASHIER_FILE_DELETE", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();

                VSK_CA.Close();
                return DailyList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public List<DailyCasherModel> ACCRUED_CREATE(DailyCasherModel DailyCasherModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@ref_id", DailyCasherModel.ref_id);
                objParam.Add("@invdate", DailyCasherModel.invdate);
                objParam.Add("@invnumber", DailyCasherModel.invnumber);
                objParam.Add("@invpo", DailyCasherModel.invpo);
                objParam.Add("@invcode", DailyCasherModel.invcode);
                objParam.Add("@invname", DailyCasherModel.invname);
                objParam.Add("@invsumtt", DailyCasherModel.invsumtt);
                objParam.Add("@invpay", DailyCasherModel.invpay);
                objParam.Add("@invuserid", DailyCasherModel.invuserid);
                objParam.Add("@invbranch", DailyCasherModel.invbranch);
                objParam.Add("@created_by", DailyCasherModel.created_by);
                objParam.Add("@invpkuser", DailyCasherModel.invpkuser);

                Connection();
                VSK_CA.Open();

                List<DailyCasherModel> DailyList = SqlMapper.Query<DailyCasherModel>(VSK_CA, "SP_CA_ACCRUED_CREATE", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();

                VSK_CA.Close();
                return DailyList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public List<DailyCasherModel> ACCRUED_LIST(DailyCasherModel DailyCasherModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@mode", DailyCasherModel.mode);
                objParam.Add("@ref_id", DailyCasherModel.ref_id);
                objParam.Add("@job_date", DailyCasherModel.job_date);
                objParam.Add("@branch", DailyCasherModel.branch);
                objParam.Add("@created_by", DailyCasherModel.created_by);

                Connection();
                VSK_CA.Open();

                List<DailyCasherModel> DailyList = SqlMapper.Query<DailyCasherModel>(VSK_CA, "SP_CA_ACCRUED_LIST", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();

                VSK_CA.Close();
                return DailyList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public List<DailyCasherModel> ACCRUED_REMARK(DailyCasherModel DailyCasherModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@ref_id", DailyCasherModel.ref_id);
                objParam.Add("@invnumber", DailyCasherModel.invnumber);
                objParam.Add("@invremark", DailyCasherModel.invremark);
                objParam.Add("@invbranch", DailyCasherModel.invbranch);
                objParam.Add("@created_by", DailyCasherModel.created_by);

                Connection();
                VSK_CA.Open();

                List<DailyCasherModel> DailyList = SqlMapper.Query<DailyCasherModel>(VSK_CA, "SP_CA_ACCRUED_REMARK", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();

                VSK_CA.Close();
                return DailyList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public List<DailyCasherModel> ACCRUED_DELETE(DailyCasherModel DailyCasherModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@trans_id", DailyCasherModel.trans_id);
                objParam.Add("@ref_id", DailyCasherModel.ref_id);
                objParam.Add("@updated_by", DailyCasherModel.updated_by);

                Connection();
                VSK_CA.Open();

                List<DailyCasherModel> DailyList = SqlMapper.Query<DailyCasherModel>(VSK_CA, "SP_CA_ACCRUED_DELETE", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();

                VSK_CA.Close();
                return DailyList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public List<DailyCasherModel> ACCRUED_RECEIVE_CREATE(DailyCasherModel DailyCasherModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@ref_id", DailyCasherModel.ref_id);
                objParam.Add("@invnumber", DailyCasherModel.invnumber);
                objParam.Add("@invbranch", DailyCasherModel.invbranch);
                objParam.Add("@job_date", DailyCasherModel.job_date);
                objParam.Add("@created_by", DailyCasherModel.created_by);

                Connection();
                VSK_CA.Open();

                List<DailyCasherModel> DailyList = SqlMapper.Query<DailyCasherModel>(VSK_CA, "SP_CA_ACCRUED_RECEIVE_CREATE", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();

                VSK_CA.Close();
                return DailyList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public List<DailyCasherModel> ACCRUED_RECEIVE_LIST(DailyCasherModel DailyCasherModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@job_date", DailyCasherModel.job_date);
                objParam.Add("@branch", DailyCasherModel.branch);
                objParam.Add("@ref_id", DailyCasherModel.ref_id);
                objParam.Add("@pay_status", DailyCasherModel.pay_status);
                objParam.Add("@mode", DailyCasherModel.mode);
                objParam.Add("@created_by", DailyCasherModel.created_by);

                Connection();
                VSK_CA.Open();

                List<DailyCasherModel> DailyList = SqlMapper.Query<DailyCasherModel>(VSK_CA, "SP_CA_ACCRUED_RECEIVE_LIST", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();

                VSK_CA.Close();
                return DailyList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public List<DailyCasherModel> ACCRUED_RECEIVE_DELETE(DailyCasherModel DailyCasherModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@invnumber", DailyCasherModel.invnumber);
                objParam.Add("@ref_id", DailyCasherModel.ref_id);
                objParam.Add("@updated_by", DailyCasherModel.updated_by);

                Connection();
                VSK_CA.Open();

                List<DailyCasherModel> DailyList = SqlMapper.Query<DailyCasherModel>(VSK_CA, "SP_CA_ACCRUED_RECEIVE_DELETE", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();

                VSK_CA.Close();
                return DailyList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public List<DailyCasherModel> RECEIVE_BILL_CREATE(DailyCasherModel DailyCasherModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@ref_id", DailyCasherModel.ref_id);
                objParam.Add("@invdate", DailyCasherModel.invdate);
                objParam.Add("@invnumber", DailyCasherModel.invnumber);
                objParam.Add("@invpo", DailyCasherModel.invpo);
                objParam.Add("@invcode", DailyCasherModel.invcode);
                objParam.Add("@invname", DailyCasherModel.invname);
                objParam.Add("@invsumtt", DailyCasherModel.invsumtt);
                objParam.Add("@invpay", DailyCasherModel.invpay);
                objParam.Add("@invuserid", DailyCasherModel.invuserid);
                objParam.Add("@invbranch", DailyCasherModel.invbranch);
                objParam.Add("@created_by", DailyCasherModel.created_by);

                objParam.Add("@invpaych", DailyCasherModel.invpaych);
                objParam.Add("@invpaytr", DailyCasherModel.invpaytr);
                objParam.Add("@invpaycr", DailyCasherModel.invpaycr);
                objParam.Add("@invpayoth", DailyCasherModel.invpayoth);
                objParam.Add("@invtoption", DailyCasherModel.invtoption);
                objParam.Add("@invdue", DailyCasherModel.invdue);
                objParam.Add("@invtype", DailyCasherModel.invtype);
                objParam.Add("@invpkuser", DailyCasherModel.invpkuser);

                Connection();
                VSK_CA.Open();

                List<DailyCasherModel> DailyList = SqlMapper.Query<DailyCasherModel>(VSK_CA, "SP_CA_RECEIVE_BILL_CREATE", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();

                VSK_CA.Close();
                return DailyList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public List<DailyCasherModel> RECEIVE_BILL_LIST(DailyCasherModel DailyCasherModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@mode", DailyCasherModel.mode);
                objParam.Add("@ref_id", DailyCasherModel.ref_id);

                Connection();
                VSK_CA.Open();

                List<DailyCasherModel> DailyList = SqlMapper.Query<DailyCasherModel>(VSK_CA, "SP_CA_RECEIVE_BILL_LIST", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();

                VSK_CA.Close();
                return DailyList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public List<DailyCasherModel> RECEIVE_BILL_DELETE(DailyCasherModel DailyCasherModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@trans_id", DailyCasherModel.trans_id);
                objParam.Add("@ref_id", DailyCasherModel.ref_id);
                objParam.Add("@updated_by", DailyCasherModel.updated_by);

                Connection();
                VSK_CA.Open();

                List<DailyCasherModel> DailyList = SqlMapper.Query<DailyCasherModel>(VSK_CA, "SP_CA_RECEIVE_BILL_DELETE", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();

                VSK_CA.Close();
                return DailyList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public List<DailyCasherModel> RECEIVE_BILL_VERIFY_LIST(DailyCasherModel DailyCasherModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@job_date", DailyCasherModel.job_date);
                objParam.Add("@ref_id", DailyCasherModel.ref_id);
                objParam.Add("@created_by", DailyCasherModel.created_by);

                Connection();
                VSK_CA.Open();

                List<DailyCasherModel> DailyList = SqlMapper.Query<DailyCasherModel>(VSK_CA, "SP_CA_RECEIVE_BILL_VERIFY_LIST", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();

                VSK_CA.Close();
                return DailyList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public List<DailyCasherModel> RECEIVE_BILL_VERIFY_UPLOAD(DailyCasherModel DailyCasherModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@job_date", DailyCasherModel.job_date);
                objParam.Add("@ref_id", DailyCasherModel.ref_id);
                objParam.Add("@created_by", DailyCasherModel.created_by);

                Connection();
                VSK_CA.Open();

                List<DailyCasherModel> DailyList = SqlMapper.Query<DailyCasherModel>(VSK_CA, "SP_CA_RECEIVE_BILL_VERIFY_UPLOAD", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();

                VSK_CA.Close();
                return DailyList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public List<DailyCasherModel> RECEIVE_BILL_VERIFY_UPLOAD_CHECK(DailyCasherModel DailyCasherModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@job_date", DailyCasherModel.job_date);
                objParam.Add("@ref_id", DailyCasherModel.ref_id);
                objParam.Add("@created_by", DailyCasherModel.created_by);

                Connection();
                VSK_CA.Open();

                List<DailyCasherModel> DailyList = SqlMapper.Query<DailyCasherModel>(VSK_CA, "SP_CA_RECEIVE_BILL_VERIFY_UPLOAD_CHECK", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();

                VSK_CA.Close();
                return DailyList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }


        public List<ResponseSelect2Model> DAILY_CASHIER_MASTER(ResponseSelect2Model ResponseSelect2Model)
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
                VSK_CA.Open();

                List<ResponseSelect2Model> SlipList = SqlMapper.Query<ResponseSelect2Model>(VSK_CA, "SP_CA_DAILY_CASHIER_MASTER", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();

                VSK_CA.Close();
                return SlipList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
}