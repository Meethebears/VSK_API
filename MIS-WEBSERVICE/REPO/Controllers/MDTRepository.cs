using Dapper;
using REPO.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace REPO.Controllers
{
    public class MDTRepository : Controller
    {
        //-------------------Start Connection_SQL ------------------------//

        public SqlConnection SPP_MDT;

        private void Connection()
        {
            SPP_MDT = new SqlConnection(ConfigurationManager.ConnectionStrings["SPP_MDT"].ToString());
        }
        //-------------------End Connection_SQL ------------------------//

        public List<MDTModel> SNK_INV_DAILY_GET(DateTime ORDER_DATE, string ORDER_TYPE)
        {
            try
            {
                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@ORDER_DATE", ORDER_DATE);
                objParam.Add("@ORDER_TYPE", ORDER_TYPE);

                Connection();
                SPP_MDT.Open();
                List<MDTModel> SNK_INV_DAILY_LIST = SqlMapper.Query<MDTModel>(SPP_MDT, "SP_SNK_INV_DAILY_GET", objParam, commandTimeout: 60, commandType: CommandType.StoredProcedure).ToList();

                SPP_MDT.Close();
                return SNK_INV_DAILY_LIST.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

    }
}