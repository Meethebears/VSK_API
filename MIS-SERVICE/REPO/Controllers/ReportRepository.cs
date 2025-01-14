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
    public class ReportRepository
    {

        #region Connection_SQL Server
        //-------------------Start Connection_SQL ------------------------//

        public SqlConnection mscon;

        private void Connection()
        {
            mscon = new SqlConnection(ConfigurationManager.ConnectionStrings["VSK_DEV"].ToString());
      
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
                objParam.Add("@report_pos", ReportModel.report_pos);

                Connection();
                mscon.Open();
                List<ReportModel> List = SqlMapper.Query<ReportModel>(mscon, "SP_Report_Get", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();

                mscon.Close();
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