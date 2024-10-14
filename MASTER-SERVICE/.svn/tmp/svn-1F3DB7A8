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
    public class ReportRepository
    {

        #region Connection_SQL Server
        //-------------------Start Connection_SQL ------------------------//

        public SqlConnection VSK_DEV;
        public SqlConnection MIS_SERVICE;

        private void Connection()
        {
            VSK_DEV = new SqlConnection(ConfigurationManager.ConnectionStrings["VSK_DEV"].ToString());
            MIS_SERVICE = new SqlConnection(ConfigurationManager.ConnectionStrings["MIS_SERVICE"].ToString());
      
        }

        //-------------------End Connection_SQL ------------------------//
        #endregion

        #region Report_Get
        public List<ReportModel> Report_Get(ReportModel ReportModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@report_app", ReportModel.report_app);
                objParam.Add("@report_branch", ReportModel.report_branch);

                Connection();
                MIS_SERVICE.Open();
                List<ReportModel> List = SqlMapper.Query<ReportModel>(MIS_SERVICE, "SP_Report_Get", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();

                MIS_SERVICE.Close();
                return List.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

    }
}