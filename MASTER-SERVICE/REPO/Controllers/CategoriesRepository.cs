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
    public class CategoriesRepository
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

        #region Categories_Get
        public List<CategoriesGetModel> Categories_Get(CategoriesGetModel CategoriesGetModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@category_id", CategoriesGetModel.category_id);

                Connection();
                MIS_SERVICE.Open();
                List<CategoriesGetModel> List = SqlMapper.Query<CategoriesGetModel>(MIS_SERVICE, "SP_CATEGORIES_GET", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();
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