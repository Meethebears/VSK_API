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
    public class LogEventRepository : Controller
    {

        #region Connection_SQL Server
        //-------------------Start Connection_SQL ------------------------//
        public SqlConnection VSK_DATA_187;

        private void Connection()
        {
            VSK_DATA_187 = new SqlConnection(ConfigurationManager.ConnectionStrings["VSK_DATA_187"].ToString());
        }
        //-------------------End Connection_SQL ------------------------//
        #endregion

        public void LogEventCreate(LogEventModel LogEventModel)
        {
            try
            {
                Connection();

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@event_id", LogEventModel.event_id);
                objParam.Add("@app_name", LogEventModel.app_name);
                objParam.Add("@user_id", LogEventModel.user_id);
                objParam.Add("@screen_name", LogEventModel.screen_name);
                objParam.Add("@event_name", LogEventModel.event_name);
                objParam.Add("@event_status", LogEventModel.event_status);
                objParam.Add("@event_data", LogEventModel.event_data);
                objParam.Add("@event_number", LogEventModel.event_number);
                objParam.Add("@error_message", LogEventModel.error_message);
                objParam.Add("@error_stacktrace", LogEventModel.error_stacktrace);
                objParam.Add("@error_source", LogEventModel.error_source);
                objParam.Add("@ref_id", LogEventModel.ref_id);

                VSK_DATA_187.Open();
                SqlMapper.Query<LogEventModel>(VSK_DATA_187, "LogEventCreate", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();
                VSK_DATA_187.Close();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<LogEventModel> LogEventGet(LogEventModel LogEventModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@event_id", LogEventModel.event_id);
                objParam.Add("@app_name", LogEventModel.app_name);
                objParam.Add("@user_id", LogEventModel.user_id);
                objParam.Add("@screen_name", LogEventModel.screen_name);
                objParam.Add("@event_name", LogEventModel.event_name);
                objParam.Add("@ref_id", LogEventModel.ref_id);
                objParam.Add("@event_number", LogEventModel.event_number);
                objParam.Add("@event_status", LogEventModel.event_status);
                
                Connection();
                VSK_DATA_187.Open();
                List<LogEventModel> PckList = SqlMapper.Query<LogEventModel>(VSK_DATA_187, "LogEventGet", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();
                VSK_DATA_187.Close();
                return PckList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }

}