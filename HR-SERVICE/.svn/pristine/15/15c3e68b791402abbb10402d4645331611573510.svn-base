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
    public class KLH_BrRepository
    {

        #region Connection_SQL Server
        //-------------------Start Connection_SQL ------------------------//
 
        public SqlConnection mscon;

        private void Connection()
        {
           
            string msconstr = ConfigurationManager.ConnectionStrings["VSK_BR_KLH"].ToString();
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

               // string trndate_start = BrModel.trndate_start == DateTime.MinValue ? null : BrModel.trndate_start.ToString("yyyy-MM-dd HH:mm");
               // string trndate_end = BrModel.trndate_end == DateTime.MinValue ? null : BrModel.trndate_end.ToString("yyyy-MM-dd HH:mm");

                objParam.Add("@action_type", BrModel.action_type);
                objParam.Add("@job_no", BrModel.job_no);
                objParam.Add("@created_by", BrModel.created_by);
                objParam.Add("@invname", BrModel.invname);
                objParam.Add("@record_status", BrModel.record_status);
                objParam.Add("@trndate_start", BrModel.trndate_start);
                objParam.Add("@trndate_end", BrModel.trndate_end);
                objParam.Add("@status_qty", BrModel.status_qty);

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

    }
}