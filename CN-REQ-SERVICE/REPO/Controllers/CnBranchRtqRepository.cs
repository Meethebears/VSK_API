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
    public class CnBranchRtqRepository
    {

        #region Connection_SQL Server
        //-------------------Start Connection_SQL ------------------------//
        public SqlConnection mscon;

        private void Connection()
        {
            string msconstr = ConfigurationManager.ConnectionStrings["VSK_CN"].ToString();
            mscon = new SqlConnection(msconstr);
        }

        //-------------------End Connection_SQL ------------------------//
        #endregion


        #region Cn_Branch_Rtq_Job_Create
        public void Cn_Branch_Rtq_Job_Create(CnBranchRtqModel CnBranchRtqModel)
        {
            try
            {
                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@cn_rtq_branch", CnBranchRtqModel.cn_rtq_branch);
                objParam.Add("@cn_branch_rtq_stkcod", CnBranchRtqModel.cn_branch_rtq_stkcod);
                objParam.Add("@cn_branch_rtq_spcode", CnBranchRtqModel.cn_branch_rtq_spcode);
                objParam.Add("@cn_branch_rtq_item_barcode", CnBranchRtqModel.cn_branch_rtq_item_barcode);
                objParam.Add("@cn_branch_rtq_item_name", CnBranchRtqModel.cn_branch_rtq_item_name);
                objParam.Add("@cn_branch_rtq_salefile_number", CnBranchRtqModel.cn_branch_rtq_salefile_number);
                objParam.Add("@cn_branch_rtq_salefile_invcode", CnBranchRtqModel.cn_branch_rtq_salefile_invcode);
                objParam.Add("@cn_branch_rtq_salefile_datetime", CnBranchRtqModel.cn_branch_rtq_salefile_datetime);
                objParam.Add("@cn_branch_rtq_job_qty", CnBranchRtqModel.cn_branch_rtq_job_qty);
                objParam.Add("@cn_branch_rtq_job_cause", CnBranchRtqModel.cn_branch_rtq_job_cause);
                objParam.Add("@cn_branch_rtq_job_source", CnBranchRtqModel.cn_branch_rtq_job_source);
                objParam.Add("@cn_branch_rtq_job_note", CnBranchRtqModel.cn_branch_rtq_job_note);
                objParam.Add("@created_by", CnBranchRtqModel.created_by);
                objParam.Add("@record_status", CnBranchRtqModel.record_status);

                Connection();
                mscon.Open();
                mscon.Execute("SP_v2_CN_BRANCH_RTQ_CREATE", objParam, commandType: CommandType.StoredProcedure);
                mscon.Close();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Cn_Branch_Rtq_Job_Get
        public List<CnBranchRtqModel> Cn_Branch_Rtq_Job_Get(CnBranchRtqModel CnBranchRtqModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();
                objParam.Add("@cn_branch_rtq_job_startdate", CnBranchRtqModel.cn_branch_rtq_job_startdate);
                objParam.Add("@cn_branch_rtq_job_enddate", CnBranchRtqModel.cn_branch_rtq_job_enddate);
                objParam.Add("@cn_branch_rtq_job_jobno", CnBranchRtqModel.cn_branch_rtq_job_jobno);
                objParam.Add("@cn_branch_rtq_salefile_invcode", CnBranchRtqModel.cn_branch_rtq_salefile_invcode);
                objParam.Add("@cn_rtq_branch", CnBranchRtqModel.cn_rtq_branch);
                objParam.Add("@cn_branch_rtq_salefile_number", CnBranchRtqModel.cn_branch_rtq_salefile_number);
                objParam.Add("@cn_branch_rtq_item_barcode", CnBranchRtqModel.cn_branch_rtq_item_barcode);
                objParam.Add("@cn_branch_rtq_job_cause", CnBranchRtqModel.cn_branch_rtq_job_cause);
                objParam.Add("@created_by", CnBranchRtqModel.created_by);
                objParam.Add("@record_status", CnBranchRtqModel.record_status);
                objParam.Add("@cn_branch_rtq_job_assige", CnBranchRtqModel.cn_branch_rtq_job_lastassige);

                Connection();
                mscon.Open();
                List<CnBranchRtqModel> CnVList = SqlMapper.Query<CnBranchRtqModel>(mscon, "SP_v2_CN_BRANCH_RTQ_GET", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();

                mscon.Close();
                return CnVList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Cn_Branch_Rtq_Item_Get
        public List<CnBranchRtqItemMasterModel> Cn_Branch_Rtq_Item_Get(CnBranchRtqItemMasterModel CnBranchRtqItemMasterModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();
                objParam.Add("@item_master", CnBranchRtqItemMasterModel.item_master);

                Connection();
                mscon.Open();
                List<CnBranchRtqItemMasterModel> CnVList = SqlMapper.Query<CnBranchRtqItemMasterModel>(mscon, "SP_v2_CN_BRANCH_ITEM_GET", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();

                mscon.Close();
                return CnVList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion


        #region Cn_Branch_Rtq_Job_Source_Update
        public void Cn_Branch_Rtq_Job_Source_Update(CnBranchRtqSourceModel CnBranchRtqSourceModel)
        {
            try
            {
                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@cn_branch_rtq_job_jobno", CnBranchRtqSourceModel.cn_branch_rtq_job_jobno);
                objParam.Add("@cn_branch_rtq_job_source", CnBranchRtqSourceModel.cn_branch_rtq_job_source);
                objParam.Add("@cn_branch_rtq_job_note", CnBranchRtqSourceModel.cn_branch_rtq_job_note);
                objParam.Add("@created_by", CnBranchRtqSourceModel.created_by);

                Connection();
                mscon.Open();
                mscon.Execute("SP_v2_CN_BRANCH_RTQ_SOURCE", objParam, commandType: CommandType.StoredProcedure);
                mscon.Close();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion


        #region Cn_Branch_Rtq_Job_Assige_Update
        public void Cn_Branch_Rtq_Job_Assige_Update(CnBranchRtqAssigeModel CnBranchRtqAssigeModel)
        {
            try
            {
                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@cn_branch_rtq_job_jobno", CnBranchRtqAssigeModel.cn_branch_rtq_job_jobno);
                objParam.Add("@cn_branch_rtq_job_assige", CnBranchRtqAssigeModel.cn_branch_rtq_job_assige);
                objParam.Add("@cn_branch_rtq_job_note", CnBranchRtqAssigeModel.cn_branch_rtq_job_note);
                objParam.Add("@created_by", CnBranchRtqAssigeModel.created_by);

                Connection();
                mscon.Open();
                mscon.Execute("SP_v2_CN_BRANCH_RTQ_ASSIGE", objParam, commandType: CommandType.StoredProcedure);
                mscon.Close();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Cn_Branch_Rtq_Job_Driver_Update
        public void Cn_Branch_Rtq_Job_Driver_Update(CnBranchRtqDriverModel CnBranchRtqDriverModel)
        {
            try
            {
                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@cn_branch_rtq_job_jobno", CnBranchRtqDriverModel.cn_branch_rtq_job_jobno);
                objParam.Add("@cn_branch_rtq_job_driver_code", CnBranchRtqDriverModel.cn_branch_rtq_job_driver_code);
                objParam.Add("@cn_branch_rtq_job_driver_name", CnBranchRtqDriverModel.cn_branch_rtq_job_driver_name);
                objParam.Add("@cn_branch_rtq_job_driver_tel", CnBranchRtqDriverModel.cn_branch_rtq_job_driver_tel);
                objParam.Add("@cn_branch_rtq_job_received_date", CnBranchRtqDriverModel.cn_branch_rtq_job_received_date);
                objParam.Add("@cn_branch_rtq_job_note", CnBranchRtqDriverModel.cn_branch_rtq_job_note);
                objParam.Add("@created_by", CnBranchRtqDriverModel.created_by);

                Connection();
                mscon.Open();
                mscon.Execute("SP_v2_CN_BRANCH_RTQ_DRIVER", objParam, commandType: CommandType.StoredProcedure);
                mscon.Close();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Cn_Branch_Rtq_Job_Condition_Update
        public void Cn_Branch_Rtq_Job_Condition_Update(CnBranchRtqConditionModel CnBranchRtqConditionModel)
        {
            try
            {
                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@cn_branch_rtq_job_jobno", CnBranchRtqConditionModel.cn_branch_rtq_job_jobno);
                objParam.Add("@cn_branch_rtq_job_item_condition", CnBranchRtqConditionModel.cn_branch_rtq_job_item_condition);
                objParam.Add("@cn_branch_rtq_job_note", CnBranchRtqConditionModel.cn_branch_rtq_job_note);
                objParam.Add("@created_by", CnBranchRtqConditionModel.created_by);

                Connection();
                mscon.Open();
                mscon.Execute("SP_v2_CN_BRANCH_RTQ_CONDITION", objParam, commandType: CommandType.StoredProcedure);
                mscon.Close();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Cn_Branch_Rtq_Job_Remark_Update
        public void Cn_Branch_Rtq_Job_Remark_Update(CnBranchRtqRemarkModel CnBranchRtqRemarkModel)
        {
            try
            {
                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@cn_branch_rtq_job_jobno", CnBranchRtqRemarkModel.cn_branch_rtq_job_jobno);
                objParam.Add("@cn_branch_rtq_job_note", CnBranchRtqRemarkModel.cn_branch_rtq_job_note);
                objParam.Add("@created_by", CnBranchRtqRemarkModel.created_by);

                Connection();
                mscon.Open();
                mscon.Execute("SP_v2_CN_BRANCH_RTQ_REMARK", objParam, commandType: CommandType.StoredProcedure);
                mscon.Close();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Cn_Branch_Rtq_Job_Cause_Update
        public void Cn_Branch_Rtq_Job_Cause_Update(CnBranchRtqCauseModel CnBranchRtqCauseModel)
        {
            try
            {
                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@cn_branch_rtq_job_jobno", CnBranchRtqCauseModel.cn_branch_rtq_job_jobno);
                objParam.Add("@cn_branch_rtq_job_cause", CnBranchRtqCauseModel.cn_branch_rtq_job_cause);
                objParam.Add("@cn_branch_rtq_job_note", CnBranchRtqCauseModel.cn_branch_rtq_job_note);
                objParam.Add("@created_by", CnBranchRtqCauseModel.created_by);

                Connection();
                mscon.Open();
                mscon.Execute("SP_v2_CN_BRANCH_RTQ_CAUSE", objParam, commandType: CommandType.StoredProcedure);
                mscon.Close();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion


        #region Cn_Branch_Rtq_Job_Status_Update
        public void Cn_Branch_Rtq_Job_Status_Update(CnBranchRtqStatusModel CnBranchRtqStatusModel)
        {
            try
            {
                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@cn_branch_rtq_job_jobno", CnBranchRtqStatusModel.cn_branch_rtq_job_jobno);
                objParam.Add("@cn_branch_rtq_job_note", CnBranchRtqStatusModel.cn_branch_rtq_job_note);
                objParam.Add("@created_by", CnBranchRtqStatusModel.created_by);
                objParam.Add("@record_status", CnBranchRtqStatusModel.record_status);

                Connection();
                mscon.Open();
                mscon.Execute("SP_v2_CN_BRANCH_RTQ_STATUS", objParam, commandType: CommandType.StoredProcedure);
                mscon.Close();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Cn_Branch_Rtq_Source_Get
        public List<CnBranchRtqSourceModel> Cn_Branch_Rtq_Source_Get(CnBranchRtqSourceModel CnBranchRtqSourceModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();
                objParam.Add("@cn_branch_rtq_job_jobno", CnBranchRtqSourceModel.cn_branch_rtq_job_jobno);

                Connection();
                mscon.Open();
                List<CnBranchRtqSourceModel> CnVList = SqlMapper.Query<CnBranchRtqSourceModel>(mscon, "SP_v2_CN_BRANCH_RTQ_SOURCE_GET", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();

                mscon.Close();
                return CnVList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Cn_Branch_Rtq_Source_Get
        public List<CnBranchRtqStatusModel> Cn_Branch_Rtq_Status_Get(CnBranchRtqStatusModel CnBranchRtqStatusModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();
                objParam.Add("@cn_branch_rtq_job_jobno", CnBranchRtqStatusModel.cn_branch_rtq_job_jobno);

                Connection();
                mscon.Open();
                List<CnBranchRtqStatusModel> CnVList = SqlMapper.Query<CnBranchRtqStatusModel>(mscon, "SP_v2_CN_BRANCH_RTQ_STATUS_GET", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();

                mscon.Close();
                return CnVList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Cn_Branch_Rtq_Driver_Get
        public List<CnBranchRtqDriverModel> Cn_Branch_Rtq_Driver_Get(CnBranchRtqDriverModel CnBranchRtqDriverModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();
                objParam.Add("@cn_branch_rtq_job_jobno", CnBranchRtqDriverModel.cn_branch_rtq_job_jobno);

                Connection();
                mscon.Open();
                List<CnBranchRtqDriverModel> CnVList = SqlMapper.Query<CnBranchRtqDriverModel>(mscon, "SP_v2_CN_BRANCH_RTQ_DRIVER_GET", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();

                mscon.Close();
                return CnVList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Cn_Branch_Rtq_Assige_Get
        public List<CnBranchRtqAssigeModel> Cn_Branch_Rtq_Assige_Get(CnBranchRtqAssigeModel CnBranchRtqAssigeModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();
                objParam.Add("@cn_branch_rtq_job_jobno", CnBranchRtqAssigeModel.cn_branch_rtq_job_jobno);

                Connection();
                mscon.Open();
                List<CnBranchRtqAssigeModel> CnVList = SqlMapper.Query<CnBranchRtqAssigeModel>(mscon, "SP_v2_CN_BRANCH_RTQ_ASSIGE_GET", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();

                mscon.Close();
                return CnVList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Cn_Branch_Rtq_Remark_Get
        public List<CnBranchRtqRemarkModel> Cn_Branch_Rtq_Remark_Get(CnBranchRtqRemarkModel CnBranchRtqRemarkModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();
                objParam.Add("@cn_branch_rtq_job_jobno", CnBranchRtqRemarkModel.cn_branch_rtq_job_jobno);

                Connection();
                mscon.Open();
                List<CnBranchRtqRemarkModel> CnVList = SqlMapper.Query<CnBranchRtqRemarkModel>(mscon, "SP_v2_CN_BRANCH_RTQ_REMARK_GET", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();

                mscon.Close();
                return CnVList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Cn_Branch_Rtq_Cause_Get
        public List<CnBranchRtqCauseModel> Cn_Branch_Rtq_Cause_Get(CnBranchRtqCauseModel CnBranchRtqCauseModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();
                objParam.Add("@cn_branch_rtq_job_jobno", CnBranchRtqCauseModel.cn_branch_rtq_job_jobno);

                Connection();
                mscon.Open();
                List<CnBranchRtqCauseModel> CnVList = SqlMapper.Query<CnBranchRtqCauseModel>(mscon, "SP_v2_CN_BRANCH_RTQ_CAUSE_GET", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();

                mscon.Close();
                return CnVList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Cn_Branch_Rtq_Condition_Get
        public List<CnBranchRtqConditionModel> Cn_Branch_Rtq_Condition_Get(CnBranchRtqConditionModel CnBranchRtqConditionModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();
                objParam.Add("@cn_branch_rtq_job_jobno", CnBranchRtqConditionModel.cn_branch_rtq_job_jobno);

                Connection();
                mscon.Open();
                List<CnBranchRtqConditionModel> CnVList = SqlMapper.Query<CnBranchRtqConditionModel>(mscon, "SP_v2_CN_BRANCH_RTQ_CONDITION_GET", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();

                mscon.Close();
                return CnVList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion


    }

}