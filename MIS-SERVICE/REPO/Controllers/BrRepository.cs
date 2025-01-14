﻿using System;
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
    public class BrRepository
    {

        #region Connection_SQL Server
        //-------------------Start Connection_SQL ------------------------//

        public SqlConnection mscon;

        private void Connection()
        {

            string msconstr = ConfigurationManager.ConnectionStrings["VSK_BR"].ToString();
            mscon = new SqlConnection(msconstr);
        }

        //-------------------End Connection_SQL ------------------------//
        #endregion

        #region Br_Brtra_Job
        public List<BrModel> Br_Brtra_Job(BrModel BrModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                //string cn_pre_job_datetime_start = BrModel.cn_pre_job_datetime_start == DateTime.MinValue ? null : BrModel.cn_pre_job_datetime_start.ToString("yyyy-MM-dd HH:mm");
                //string cn_pre_job_datetime_end = BrModel.cn_pre_job_datetime_end == DateTime.MinValue ? null : BrModel.cn_pre_job_datetime_end.ToString("yyyy-MM-dd HH:mm");


                objParam.Add("@brtra_number", BrModel.brtra_number);
                objParam.Add("@created_by", BrModel.created_by);


                Connection();
                mscon.Open();
                List<BrModel> BrVList = SqlMapper.Query<BrModel>(mscon, "SP_Brtra_Job", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();

                mscon.Close();
                return BrVList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Br_Brtra_Get
        public List<BrModel> Br_Brtra_Get(BrModel BrModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                string trndate_start = BrModel.trndate_start == DateTime.MinValue ? null : BrModel.trndate_start.ToString("yyyy-MM-dd HH:mm");
                string trndate_end = BrModel.trndate_end == DateTime.MinValue ? null : BrModel.trndate_end.ToString("yyyy-MM-dd HH:mm");

                objParam.Add("@job_no", BrModel.job_no);
                objParam.Add("@created_by", BrModel.created_by);
                objParam.Add("@invname", BrModel.invname);
                objParam.Add("@record_status", BrModel.record_status);
                objParam.Add("@trndate_start", BrModel.trndate_start);
                objParam.Add("@trndate_end", BrModel.trndate_end);
                objParam.Add("@status_qty", BrModel.status_qty);
                objParam.Add("@action_type", BrModel.action_type);

                Connection();
                mscon.Open();
                List<BrModel> BrVList = SqlMapper.Query<BrModel>(mscon, "SP_Brtra_Get", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();

                mscon.Close();
                return BrVList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Br_Brtra_Update
        public List<BrModel> Br_Brtra_Update(BrModel BrModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@job_detail_qty", BrModel.job_detail_qty);
                objParam.Add("@gbarcode", BrModel.gbarcode);
                objParam.Add("@br_job_no", BrModel.br_job_no);
                objParam.Add("@pMessage", BrModel.pMessage);
                objParam.Add("@updated_by", BrModel.updated_by);

                Connection();
                mscon.Open();
                List<BrModel> BrVList = SqlMapper.Query<BrModel>(mscon, "SP_Brtra_Update", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();

                mscon.Close();
                return BrVList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Br_Brtra_History
        public List<BrModel> Br_Brtra_History(BrModel BrModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@br_job_no", BrModel.br_job_no);
                objParam.Add("@record_status", BrModel.created_by);

                Connection();
                mscon.Open();
                List<BrModel> BrVList = SqlMapper.Query<BrModel>(mscon, "SP_Brtra_History", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();

                mscon.Close();
                return BrVList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Br_Brtra_Lov
        public List<LovModel> Br_Brtra_Lov(LovModel LovModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@lov_code", LovModel.lov_code);

                Connection();
                mscon.Open();
                List<LovModel> BrVList = SqlMapper.Query<LovModel>(mscon, "SP_Brtra_Lov", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();

                mscon.Close();
                return BrVList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Br_Lov_Route_Get
        public List<LovModel> Br_Lov_Route_Get(LovModel LovModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@lov_type", LovModel.lov_type);
                objParam.Add("@parent_lov_id", LovModel.parent_lov_id);

                Connection();
                mscon.Open();
                List<LovModel> BrVList = SqlMapper.Query<LovModel>(mscon, "SP_TRP_Lov_Get", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();

                mscon.Close();
                return BrVList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Br_Deliver_Job
        public List<BrDeliverModel> Br_Deliver_Job(BrDeliverModel BrDeliverModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                //string cn_pre_job_datetime_start = BrModel.cn_pre_job_datetime_start == DateTime.MinValue ? null : BrModel.cn_pre_job_datetime_start.ToString("yyyy-MM-dd HH:mm");
                //string cn_pre_job_datetime_end = BrModel.cn_pre_job_datetime_end == DateTime.MinValue ? null : BrModel.cn_pre_job_datetime_end.ToString("yyyy-MM-dd HH:mm");


                objParam.Add("@brtra_number", BrDeliverModel.brtra_number);
                objParam.Add("@deliver_br_job", BrDeliverModel.deliver_br_job);
                objParam.Add("@deliver_driver", BrDeliverModel.deliver_driver);
                objParam.Add("@deliver_route", BrDeliverModel.deliver_route);
                objParam.Add("@deliver_remark", BrDeliverModel.deliver_remark);
                objParam.Add("@created_by", BrDeliverModel.created_by);

                //objParam.Add("@deliver_status", BrDeliverModel.deliver_status);


                Connection();
                mscon.Open();
                List<BrDeliverModel> BrVList = SqlMapper.Query<BrDeliverModel>(mscon, "SP_Brtra_Deliver_Job", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();

                mscon.Close();
                return BrVList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Br_Lov_Driver_Get
        public List<DriverModel> Br_Lov_Driver_Get(DriverModel DriverModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();


                objParam.Add("@driver_code", DriverModel.driver_code);

                Connection();
                mscon.Open();
                List<DriverModel> BrVList = SqlMapper.Query<DriverModel>(mscon, "SP_TRP_Driver_Get_ByCode", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();

                mscon.Close();
                return BrVList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Br_Brtra_History_Deliver
        public List<DriverModel> Br_Brtra_History_Deliver(DriverModel DriverModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@br_job_no", DriverModel.br_job_no);
                objParam.Add("@record_status", DriverModel.created_by);

                Connection();
                mscon.Open();
                List<DriverModel> BrVList = SqlMapper.Query<DriverModel>(mscon, "SP_Brtra_History_Deliver", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();

                mscon.Close();
                return BrVList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Br_Brtra_Get_v1
        public List<BrModel> Br_Brtra_Get_v1(BrModel BrModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@job_no", BrModel.job_no);

                Connection();
                mscon.Open();
                List<BrModel> BrVList = SqlMapper.Query<BrModel>(mscon, "SP_Brtra_Get_v1", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();

                mscon.Close();
                return BrVList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Br_Report_Get
        public List<BrReportModel> Br_Report_Get(BrReportModel BrReportModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@report_app", BrReportModel.report_app);
                objParam.Add("@report_pos", BrReportModel.report_pos);

                Connection();
                mscon.Open();
                List<BrReportModel> BrVList = SqlMapper.Query<BrReportModel>(mscon, "SP_Report_Get", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();

                mscon.Close();
                return BrVList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Tr_Job
        public List<TranferModel> Tr_Job(TranferModel TranferModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@tranfer_number", TranferModel.tranfer_number);
                objParam.Add("@created_by", TranferModel.created_by);


                Connection();
                mscon.Open();
                List<TranferModel> TrVList = SqlMapper.Query<TranferModel>(mscon, "SP_Tranfer_Job", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();

                mscon.Close();
                return TrVList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Tr_Update
        public List<TranferModel> Tr_Update(TranferModel TranferModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@tr_detail_qty", TranferModel.tr_detail_qty);
                objParam.Add("@gbarcode", TranferModel.gbarcode);
                objParam.Add("@tr_job_no", TranferModel.tr_job_no);
                objParam.Add("@updated_by", TranferModel.updated_by);
                objParam.Add("@pMessage", TranferModel.pMessage);


                Connection();
                mscon.Open();
                List<TranferModel> TrVList = SqlMapper.Query<TranferModel>(mscon, "SP_Tranfer_Update", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();

                mscon.Close();
                return TrVList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Tr_History
        public List<TranHistoryModel> Tr_History(TranHistoryModel TranHistoryModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@tr_job_no", TranHistoryModel.tr_job_no);
                objParam.Add("@record_status", TranHistoryModel.created_by);

                Connection();
                mscon.Open();
                List<TranHistoryModel> TrList = SqlMapper.Query<TranHistoryModel>(mscon, "SP_Tranfer_History", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();

                mscon.Close();
                return TrList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Tr_Item
        public List<TranHistoryModel> Tr_Item(TranHistoryModel TranHistoryModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@tr_job_no", TranHistoryModel.tr_job_no);
                objParam.Add("@tr_detail_id", TranHistoryModel.tr_detail_id);
                objParam.Add("@record_status", TranHistoryModel.created_by);

                Connection();
                mscon.Open();
                List<TranHistoryModel> TrList = SqlMapper.Query<TranHistoryModel>(mscon, "SP_Tranfer_Item", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();

                mscon.Close();
                return TrList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Tr_Get
        public List<TranGetModel> Tr_Get(TranGetModel TranGetModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                string trndate_start = TranGetModel.trndate_start == DateTime.MinValue ? null : TranGetModel.trndate_start.ToString("yyyy-MM-dd HH:mm");
                string trndate_end = TranGetModel.trndate_end == DateTime.MinValue ? null : TranGetModel.trndate_end.ToString("yyyy-MM-dd HH:mm");

                objParam.Add("@created_by", TranGetModel.created_by);
                objParam.Add("@tranfer_number", TranGetModel.tranfer_number);
                objParam.Add("@trndate_start", TranGetModel.trndate_start);
                objParam.Add("@trndate_end", TranGetModel.trndate_end);
                objParam.Add("@tr_status_qty", TranGetModel.tr_status_qty);

                Connection();
                mscon.Open();
                List<TranGetModel> TrList = SqlMapper.Query<TranGetModel>(mscon, "SP_Tranfer_Get", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();

                mscon.Close();
                return TrList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Tr_Remark
        public List<TranRemarkModel> Tr_Remark(TranRemarkModel TranRemarkModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@tranfer_no", TranRemarkModel.tranfer_no);
                objParam.Add("@tr_detail_id", TranRemarkModel.tr_detail_id);
                objParam.Add("@r_remark", TranRemarkModel.r_remark);
                objParam.Add("@r_qty", TranRemarkModel.r_qty);
                // objParam.Add("@r_status", TranRemarkModel.r_status);
                objParam.Add("@created_by", TranRemarkModel.updated_by);

                Connection();
                mscon.Open();
                List<TranRemarkModel> TrVList = SqlMapper.Query<TranRemarkModel>(mscon, "SP_Tranfer_Remark", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();

                mscon.Close();
                return TrVList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

    }
}