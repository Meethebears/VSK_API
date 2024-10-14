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
    public class CnReqRepository
    {

        #region Connection_SQL Server
        //-------------------Start Connection_SQL ------------------------//
        public SqlConnection mscon;

        public SqlConnection VSK_CN_247;
        public SqlConnection VSK_CN_187;
        public SqlConnection VSK_DATA;
        public SqlConnection VSK_DATA_249;
        public SqlConnection VSM_DATA;
        public SqlConnection VSM_DATA_249;
        public SqlConnection VSF_DATA;
        public SqlConnection KLH_DATA;
        public SqlConnection LKS_DATA;
        public SqlConnection LLK_DATA;
        public SqlConnection NWM_DATA;
        public SqlConnection SNK_DATA;
        public SqlConnection EBB_DATA;
        public SqlConnection RTB_DATA;
        public SqlConnection STP_DATA;
        // Open Branch New //
             //public SqlConnection ???_DATA;
        // End Branch New //

        private void Connection()
        {

            mscon = new SqlConnection(ConfigurationManager.ConnectionStrings["VSK_CN_187"].ToString());

            VSK_CN_247 = new SqlConnection(ConfigurationManager.ConnectionStrings["VSK_CN_247"].ToString());
            VSK_CN_187 = new SqlConnection(ConfigurationManager.ConnectionStrings["VSK_CN_187"].ToString());
            VSK_DATA = new SqlConnection(ConfigurationManager.ConnectionStrings["VSK_DATA"].ToString());
            VSK_DATA_249 = new SqlConnection(ConfigurationManager.ConnectionStrings["VSK_DATA_249"].ToString());
            VSM_DATA = new SqlConnection(ConfigurationManager.ConnectionStrings["VSM_DATA"].ToString());
            VSM_DATA_249 = new SqlConnection(ConfigurationManager.ConnectionStrings["VSM_DATA_249"].ToString());
            VSF_DATA = new SqlConnection(ConfigurationManager.ConnectionStrings["VSF_DATA"].ToString());
            KLH_DATA = new SqlConnection(ConfigurationManager.ConnectionStrings["KLH_DATA"].ToString());
            LKS_DATA = new SqlConnection(ConfigurationManager.ConnectionStrings["LKS_DATA"].ToString());
            LLK_DATA = new SqlConnection(ConfigurationManager.ConnectionStrings["LLK_DATA"].ToString());
            NWM_DATA = new SqlConnection(ConfigurationManager.ConnectionStrings["NWM_DATA"].ToString());
            SNK_DATA = new SqlConnection(ConfigurationManager.ConnectionStrings["SNK_DATA"].ToString());
            EBB_DATA = new SqlConnection(ConfigurationManager.ConnectionStrings["EBB_DATA"].ToString());
            RTB_DATA = new SqlConnection(ConfigurationManager.ConnectionStrings["RTB_DATA"].ToString());
            STP_DATA = new SqlConnection(ConfigurationManager.ConnectionStrings["STP_DATA"].ToString());
            // Open Branch New //
                // ???_DATA = new SqlConnection(ConfigurationManager.ConnectionStrings["???_DATA"].ToString());
            // End Branch New //
        }

        //-------------------End Connection_SQL ------------------------//
        #endregion


        #region Cn_Req_Saletra_Get
        public List<CnReqSaletraModel> Cn_Req_Saletra_Get(string cn_req_salefile_number)
        {

            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@cn_req_salefile_number", cn_req_salefile_number);

                Connection();
                mscon.Open();
                List<CnReqSaletraModel> CnReqList = SqlMapper.Query<CnReqSaletraModel>(mscon, "SP_v2_CN_REQ_GET", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();

                mscon.Close();
                return CnReqList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        #endregion

        #region Cn_Req_Cause_Master_Get
        public List<CnReqLOVModel> Cn_Req_Cause_Master_Get()
        {

            try
            {

                DynamicParameters objParam = new DynamicParameters();

                Connection();
                mscon.Open();
                List<CnReqLOVModel> CnReqList = SqlMapper.Query<CnReqLOVModel>(mscon, "SP_v2_CN_REQ_CAUSE_MASTER_GET", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();

                mscon.Close();
                return CnReqList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        #endregion

        #region Cn_Req_Assige_Master_Get
        public List<CnReqLOVModel> Cn_Req_Assige_Master_Get()
        {

            try
            {

                DynamicParameters objParam = new DynamicParameters();

                Connection();
                mscon.Open();
                List<CnReqLOVModel> CnReqList = SqlMapper.Query<CnReqLOVModel>(mscon, "SP_v2_CN_REQ_ASSIGE_MASTER_GET", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();

                mscon.Close();
                return CnReqList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        #endregion

        #region Cn_Req_Source_Master_Get
        public List<CnReqLOVModel> Cn_Req_Source_Master_Get()
        {

            try
            {

                DynamicParameters objParam = new DynamicParameters();

                Connection();
                mscon.Open();
                List<CnReqLOVModel> CnReqList = SqlMapper.Query<CnReqLOVModel>(mscon, "SP_v2_CN_REQ_SOURCE_MASTER_GET", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();

                mscon.Close();
                return CnReqList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        #endregion

        #region Cn_Req_Status_Master_Get
        public List<CnReqLOVModel> Cn_Req_Status_Master_Get()
        {

            try
            {

                DynamicParameters objParam = new DynamicParameters();

                Connection();
                mscon.Open();
                List<CnReqLOVModel> CnReqList = SqlMapper.Query<CnReqLOVModel>(mscon, "SP_v2_CN_REQ_STATUS_MASTER_GET", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();

                mscon.Close();
                return CnReqList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        #endregion

        #region Cn_Req_Job_Daily_Get
        public List<CnReqModel> Cn_Req_Job_Daily_Get()
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                Connection();
                mscon.Open();
                List<CnReqModel> CnVList = SqlMapper.Query<CnReqModel>(mscon, "SP_v2_CN_REQ_DAILY_GET", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();

                mscon.Close();
                return CnVList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Cn_Req_Job_Create
        public List<CnReqModel> Cn_Req_Job_Create(CnReqModel CnReqModel)
        {
            try
            {
                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@cn_req_salefile_number", CnReqModel.cn_req_salefile_number);
                objParam.Add("@cn_req_salefile_branch", CnReqModel.cn_req_salefile_branch);
                objParam.Add("@cn_req_salefile_stkcod", CnReqModel.cn_req_salefile_stkcod);
                objParam.Add("@cn_req_job_qty", CnReqModel.cn_req_job_qty);
                objParam.Add("@cn_req_job_cause", CnReqModel.cn_req_job_cause);
                objParam.Add("@cn_req_job_assige", CnReqModel.cn_req_job_assige);
                objParam.Add("@cn_req_job_source", CnReqModel.cn_req_job_source);
                objParam.Add("@cn_req_job_note", CnReqModel.cn_req_job_note);
                objParam.Add("@created_by", CnReqModel.created_by);
                objParam.Add("@record_status", CnReqModel.record_status);

                Connection();
                mscon.Open();
                List<CnReqModel> DTList = SqlMapper.Query<CnReqModel>(mscon, "SP_v2_CN_REQ_CREATE", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();
                mscon.Close();
                return DTList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Cn_Req_Job_Search_Get
        public List<CnReqModel> Cn_Req_Job_Search_Get(CnReqModel CnReqModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();
                objParam.Add("@cn_req_job_startdate", CnReqModel.cn_req_job_startdate);
                objParam.Add("@cn_req_job_enddate", CnReqModel.cn_req_job_enddate);
                objParam.Add("@cn_req_job_jobno", CnReqModel.cn_req_job_jobno);
                objParam.Add("@cn_req_salefile_branch", CnReqModel.cn_req_salefile_branch);
                objParam.Add("@number", CnReqModel.number);
                objParam.Add("@invpo", CnReqModel.invpo);
                objParam.Add("@empcod", CnReqModel.empcod);
                objParam.Add("@empname", CnReqModel.empname);
                objParam.Add("@gbarcode", CnReqModel.gbarcode);
                objParam.Add("@PKuser", CnReqModel.PKuser);
                objParam.Add("@cn_req_job_cause", CnReqModel.cn_req_job_cause);
                objParam.Add("@cn_req_job_lastassige", CnReqModel.cn_req_job_lastassige);
                objParam.Add("@created_by", CnReqModel.created_by);
                objParam.Add("@saleperson", CnReqModel.saleperson);
                objParam.Add("@record_status", CnReqModel.record_status);

                Connection();
                mscon.Open();
                List<CnReqModel> CnVList = SqlMapper.Query<CnReqModel>(mscon, "SP_v2_CN_REQ_SEARCH_GET", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();

                mscon.Close();
                return CnVList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Cn_Req_Source_Update
        public void Cn_Req_Source_Update(CnReqSourceModel CnReqSourceModel)
        {
            try
            {
                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@cn_req_job_jobno", CnReqSourceModel.cn_req_job_jobno);
                objParam.Add("@cn_req_job_source", CnReqSourceModel.cn_req_job_source);
                objParam.Add("@cn_req_job_note", CnReqSourceModel.cn_req_job_note);
                objParam.Add("@created_by", CnReqSourceModel.created_by);

                Connection();
                mscon.Open();
                mscon.Execute("SP_v2_CN_REQ_SOURCE", objParam, commandType: CommandType.StoredProcedure);
                mscon.Close();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Cn_Req_Assige_Update
        public void Cn_Req_Assige_Update(CnReqAssigeModel CnReqAssigeModel)
        {
            try
            {
                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@cn_req_job_no", CnReqAssigeModel.cn_req_job_jobno);
                objParam.Add("@cn_req_job_assige", CnReqAssigeModel.cn_req_job_assige);
                objParam.Add("@cn_req_job_note", CnReqAssigeModel.cn_req_job_note);
                objParam.Add("@created_by", CnReqAssigeModel.created_by);
                objParam.Add("@record_status", CnReqAssigeModel.record_status);

                Connection();
                mscon.Open();
                mscon.Execute("SP_v2_CN_REQ_ASSIGE", objParam, commandType: CommandType.StoredProcedure);
                mscon.Close();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Cn_Req_Driver_Update
        public void Cn_Req_Driver_Update(CnReqDriverModel CnReqDriverModel)
        {
            try
            {
                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@cn_req_job_no", CnReqDriverModel.cn_req_job_jobno);
                objParam.Add("@cn_req_job_lastdriver", CnReqDriverModel.cn_req_job_lastdriver);
                objParam.Add("@cn_req_job_driver_code", CnReqDriverModel.cn_req_job_driver_code);
                objParam.Add("@cn_req_job_driver_name", CnReqDriverModel.cn_req_job_driver_name);
                objParam.Add("@cn_req_job_driver_tel", CnReqDriverModel.cn_req_job_driver_tel);
                objParam.Add("@cn_req_job_received_date", CnReqDriverModel.cn_req_job_received_date);
                objParam.Add("@cn_req_job_note", CnReqDriverModel.cn_req_job_note);
                objParam.Add("@created_by", CnReqDriverModel.created_by);
                objParam.Add("@record_status", CnReqDriverModel.record_status);

                Connection();
                mscon.Open();
                mscon.Execute("SP_v2_CN_REQ_DRIVER", objParam, commandType: CommandType.StoredProcedure);
                mscon.Close();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Cn_Req_Condition_Update
        public void Cn_Req_Condition_Update(CnReqConditionModel CnReqConditionModel)
        {
            try
            {
                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@cn_req_job_no", CnReqConditionModel.cn_req_job_jobno);
                objParam.Add("@cn_req_job_item_condition", CnReqConditionModel.cn_req_job_item_condition);
                objParam.Add("@cn_req_job_note", CnReqConditionModel.cn_req_job_note);
                objParam.Add("@created_by", CnReqConditionModel.created_by);
                objParam.Add("@record_status", CnReqConditionModel.record_status);

                Connection();
                mscon.Open();
                mscon.Execute("SP_v2_CN_REQ_CONDITION", objParam, commandType: CommandType.StoredProcedure);
                mscon.Close();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Cn_Req_Status_Update
        public void Cn_Req_Status_Update(CnReqStatusModel CnReqStatusModel)
        {
            try
            {
                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@cn_req_job_no", CnReqStatusModel.cn_req_job_jobno);
                objParam.Add("@cn_req_job_note", CnReqStatusModel.cn_req_job_note);
                objParam.Add("@created_by", CnReqStatusModel.created_by);
                objParam.Add("@record_status", CnReqStatusModel.record_status);

                Connection();
                mscon.Open();
                mscon.Execute("SP_v2_CN_REQ_STATUS", objParam, commandType: CommandType.StoredProcedure);
                mscon.Close();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Cn_Req_Source_Get
        public List<CnReqSourceModel> Cn_Req_Source_Get(CnReqSourceModel CnReqSourceModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@cn_req_job_jobno", CnReqSourceModel.cn_req_job_jobno);

                Connection();
                mscon.Open();
                List<CnReqSourceModel> CnVList = SqlMapper.Query<CnReqSourceModel>(mscon, "SP_v2_CN_REQ_SOURCE_GET", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();

                mscon.Close();
                return CnVList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Cn_Req_Status_Get
        public List<CnReqStatusModel> Cn_Req_Status_Get(CnReqStatusModel CnReqStatusModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@cn_req_job_jobno", CnReqStatusModel.cn_req_job_jobno);

                Connection();
                mscon.Open();
                List<CnReqStatusModel> CnVList = SqlMapper.Query<CnReqStatusModel>(mscon, "SP_v2_CN_REQ_STATUS_GET", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();

                mscon.Close();
                return CnVList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Cn_Req_Driver_Get
        public List<CnReqDriverModel> Cn_Req_Driver_Get(CnReqDriverModel CnReqDriverModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@cn_req_job_jobno", CnReqDriverModel.cn_req_job_jobno);

                Connection();
                mscon.Open();
                List<CnReqDriverModel> CnVList = SqlMapper.Query<CnReqDriverModel>(mscon, "SP_v2_CN_REQ_DRIVER_GET", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();

                mscon.Close();
                return CnVList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Cn_Req_Condition_Get
        public List<CnReqConditionModel> Cn_Req_Condition_Get(CnReqConditionModel CnReqConditionModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@cn_req_job_jobno", CnReqConditionModel.cn_req_job_jobno);

                Connection();
                mscon.Open();
                List<CnReqConditionModel> CnVList = SqlMapper.Query<CnReqConditionModel>(mscon, "SP_v2_CN_REQ_CONDITION_GET", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();

                mscon.Close();
                return CnVList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Cn_Req_Assige_Get
        public List<CnReqAssigeModel> Cn_Req_Assige_Get(CnReqAssigeModel CnReqAssigeModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@cn_req_job_jobno", CnReqAssigeModel.cn_req_job_jobno);

                Connection();
                mscon.Open();
                List<CnReqAssigeModel> CnVList = SqlMapper.Query<CnReqAssigeModel>(mscon, "SP_v2_CN_REQ_ASSIGE_GET", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();

                mscon.Close();
                return CnVList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Cn_Req_Remark_Get
        public List<CnReqRemarkModel> Cn_Req_Remark_Get(CnReqRemarkModel CnReqRemarkModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@cn_req_job_jobno", CnReqRemarkModel.cn_req_job_jobno);

                Connection();
                mscon.Open();
                List<CnReqRemarkModel> CnVList = SqlMapper.Query<CnReqRemarkModel>(mscon, "SP_v2_CN_REQ_REMARK_GET", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();

                mscon.Close();
                return CnVList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Cn_Req_Remark_Update
        public void Cn_Req_Remark_Update(CnReqRemarkModel CnReqRemarkModel)
        {
            try
            {
                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@cn_req_job_jobno", CnReqRemarkModel.cn_req_job_jobno);
                objParam.Add("@cn_req_job_note", CnReqRemarkModel.cn_req_job_note);
                objParam.Add("@created_by", CnReqRemarkModel.created_by);

                Connection();
                mscon.Open();
                mscon.Execute("SP_v2_CN_REQ_REMARK", objParam, commandType: CommandType.StoredProcedure);
                mscon.Close();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion


        #region Cn_Req_Cause_Get
        public List<CnReqCauseModel> Cn_Req_Cause_Get(CnReqCauseModel CnReqCauseModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@cn_req_job_jobno", CnReqCauseModel.cn_req_job_jobno);

                Connection();
                mscon.Open();
                List<CnReqCauseModel> CnVList = SqlMapper.Query<CnReqCauseModel>(mscon, "SP_v2_CN_REQ_CAUSE_GET", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();

                mscon.Close();
                return CnVList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Cn_Req_Cause_Update
        public void Cn_Req_Cause_Update(CnReqCauseModel CnReqCauseModel)
        {
            try
            {
                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@cn_req_job_jobno", CnReqCauseModel.cn_req_job_jobno);
                objParam.Add("@cn_req_job_cause", CnReqCauseModel.cn_req_job_cause);
                objParam.Add("@cn_req_job_note", CnReqCauseModel.cn_req_job_note);
                objParam.Add("@created_by", CnReqCauseModel.created_by);

                Connection();
                mscon.Open();
                mscon.Execute("SP_v2_CN_REQ_CAUSE", objParam, commandType: CommandType.StoredProcedure);
                mscon.Close();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Cn_Req_Job_Update
        public void Cn_Req_Job_Update(CnReqModel CnReqModel)
        {
            try
            {
                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@cn_req_job_jobno", CnReqModel.cn_req_job_jobno);
                objParam.Add("@cn_req_job_assige", CnReqModel.cn_req_job_assige);
                objParam.Add("@cn_req_job_cause", CnReqModel.cn_req_job_cause);
                objParam.Add("@cn_req_job_note", CnReqModel.cn_req_job_note);
                objParam.Add("@cn_req_job_last_item_condition", CnReqModel.cn_req_job_last_item_condition);
                objParam.Add("@cn_req_job_driver_code", CnReqModel.cn_req_job_driver_code);
                objParam.Add("@cn_req_job_driver_name", CnReqModel.cn_req_job_driver_name);
                objParam.Add("@cn_req_job_driver_tel", CnReqModel.cn_req_job_driver_tel);
                objParam.Add("@cn_req_job_received_date", CnReqModel.cn_req_job_received_date);
                objParam.Add("@cn_req_job_source", CnReqModel.cn_req_job_source);
                objParam.Add("@created_by", CnReqModel.created_by);
                objParam.Add("@record_status", CnReqModel.record_status);

                Connection();
                mscon.Open();
                mscon.Execute("SP_v2_CN_REQ_UPDATE", objParam, commandType: CommandType.StoredProcedure);
                mscon.Close();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion



        // Tan Cr 2023-08-07 STRAT

        #region Cn_Req_Saletra_Branch_Get
        public List<CnReqSaletraModel> Cn_Req_Saletra_Branch_Get(string branch, string number)
        {
            try
            {

                List<CnReqSaletraModel> _ResponseData;

                string dbstr;
                string SQLQuery = "";

                SQLQuery = "SELECT" +
                            " trndate AS trndate, RTRIM( number ) AS number, RTRIM( invpo ) AS invpo, RTRIM( empcod ) AS empcod, RTRIM( empname ) AS empname, RTRIM( stkcod ) AS stkcod, RTRIM( gbarcode ) AS gbarcode, RTRIM( spcodes ) AS spcodes, RTRIM( stkname ) AS stkname, RTRIM( stkunit ) AS stkunit, RTRIM( whdiscode ) AS whdiscode, RTRIM( userid ) AS userid, RTRIM( salegroup_uptodate ) AS salegroup_uptodate, RTRIM( named ) AS named, RTRIM( customerGrade ) AS customerGrade, RTRIM( PKuser ) AS PKuser, RTRIM( saleperson ) AS saleperson, trnqty AS item,trnprnet AS trnprnet " +
                            " FROM saletra t" +
                            " WHERE RTRIM(t.number) = '" + number + "' ";

                if (branch == "VSK" || branch == "VSM")
                {
                    dbstr = ConfigurationManager.ConnectionStrings["VSK_DATA_249"].ToString();

                } 
                else if (branch == "VSF")
                {
                    dbstr = ConfigurationManager.ConnectionStrings["VSF_DATA"].ToString();

                }
                else if (branch == "KLH")
                {
                    dbstr = ConfigurationManager.ConnectionStrings["KLH_DATA"].ToString();

                } 
                else if (branch == "LLK")
                {
                    dbstr = ConfigurationManager.ConnectionStrings["LLK_DATA"].ToString();

                }   
                else if (branch == "NWM")
                {
                    dbstr = ConfigurationManager.ConnectionStrings["NWM_DATA"].ToString();

                }   
                else if (branch == "LKS" || branch == "KSW")
                {
                    dbstr = ConfigurationManager.ConnectionStrings["LKS_DATA"].ToString();

                } 
                else if (branch == "SNK")
                {
                    dbstr = ConfigurationManager.ConnectionStrings["SNK_DATA"].ToString();

                }
                else if (branch == "EBB")
                {
                    dbstr = ConfigurationManager.ConnectionStrings["EBB_DATA"].ToString();

                } 
                else if (branch == "RTB")
                {
                    dbstr = ConfigurationManager.ConnectionStrings["RTB_DATA"].ToString();

                }
                else if (branch == "STP")
                {
                    dbstr = ConfigurationManager.ConnectionStrings["STP_DATA"].ToString();

                }
                // Open Branch New //
                    //else if (branch == "???")
                    //{
                    //    dbstr = ConfigurationManager.ConnectionStrings["???_DATA"].ToString();

                    //}
                // End Branch New //
                else
                {
                    dbstr = ConfigurationManager.ConnectionStrings[""].ToString();

                }
                mscon = new SqlConnection(dbstr);
                mscon.Open();
                _ResponseData = mscon.Query<CnReqSaletraModel>(SQLQuery).ToList();
                mscon.Close();
                return _ResponseData.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        #endregion

        #region Cn_Req_Tmp_Saletra_Create
        public List<CnReqModel> Cn_Req_Tmp_Saletra_Create (CnReqModel CnReqModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@ref_id", CnReqModel.ref_id);
                objParam.Add("@trndate", CnReqModel.trndate);
                objParam.Add("@number", CnReqModel.number);
                objParam.Add("@invpo", CnReqModel.invpo);
                objParam.Add("@empcod", CnReqModel.empcod);
                objParam.Add("@empname", CnReqModel.empname);
                objParam.Add("@stkcod", CnReqModel.stkcod);
                objParam.Add("@gbarcode", CnReqModel.gbarcode);
                objParam.Add("@spcodes", CnReqModel.spcodes);
                objParam.Add("@stkname", CnReqModel.stkname);
                objParam.Add("@item", CnReqModel.item);
                objParam.Add("@stkunit", CnReqModel.stkunit);
                objParam.Add("@whdiscode", CnReqModel.whdiscode);
                objParam.Add("@userid", CnReqModel.userid);
                objParam.Add("@salegroup_uptodate", CnReqModel.salegroup_uptodate);
                objParam.Add("@named", CnReqModel.named);
                objParam.Add("@customerGrade", CnReqModel.customerGrade);
                objParam.Add("@PKuser", CnReqModel.PKuser);
                objParam.Add("@saleperson", CnReqModel.saleperson);
                objParam.Add("@trnprnet", CnReqModel.trnprnet);
                objParam.Add("@branch", CnReqModel.branch);

                objParam.Add("@startdate", CnReqModel.startdate);
                objParam.Add("@invdue", CnReqModel.invdue);
                objParam.Add("@invkline", CnReqModel.invkline);
                objParam.Add("@descript", CnReqModel.descript);
                objParam.Add("@invcustpo", CnReqModel.invcustpo);
                objParam.Add("@address_delivery", CnReqModel.address_delivery);
              

                Connection();
                mscon.Open();
                List<CnReqModel> DList = SqlMapper.Query<CnReqModel>(mscon, "SP_v2_CN_REQ_TMP_SALETRA_CREATE", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();
                mscon.Close();
                return DList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        #endregion


        // Tan Cr 2023-08-07 END


    }

}