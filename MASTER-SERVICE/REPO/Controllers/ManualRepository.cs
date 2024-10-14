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
    public class ManualRepository
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

        #region Manual_Get
        public List<ManualGetModel> Manual_Get(string category_id , string category_name)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@category_id", category_id);
                objParam.Add("@category_name", category_name);

                Connection();
                MIS_SERVICE.Open();
                List<ManualGetModel> List = SqlMapper.Query<ManualGetModel>(MIS_SERVICE, "SP_MANUALS_GET", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();
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