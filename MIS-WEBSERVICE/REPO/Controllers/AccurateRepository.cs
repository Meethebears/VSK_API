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
    public class AccurateRepository : Controller
    {
        //-------------------Start Connection_SQL ------------------------//

        public SqlConnection VSK_DATA;
        public SqlConnection VSM_DATA;
        public SqlConnection VSF_DATA;
        public SqlConnection KLH_DATA;
        public SqlConnection KSW_DATA;
        public SqlConnection LLK_DATA;
        public SqlConnection NWM_DATA;
        public SqlConnection SNK_DATA;
        public SqlConnection EBB_DATA;
        public SqlConnection RTB_DATA;

        private void Connection()
        {
            VSK_DATA = new SqlConnection(ConfigurationManager.ConnectionStrings["VSK_DATA"].ToString());
            VSM_DATA = new SqlConnection(ConfigurationManager.ConnectionStrings["VSM_DATA"].ToString());
            VSF_DATA = new SqlConnection(ConfigurationManager.ConnectionStrings["VSF_DATA"].ToString());
            KLH_DATA = new SqlConnection(ConfigurationManager.ConnectionStrings["KLH_DATA"].ToString());
            KSW_DATA = new SqlConnection(ConfigurationManager.ConnectionStrings["KSW_DATA"].ToString());
            LLK_DATA = new SqlConnection(ConfigurationManager.ConnectionStrings["LLK_DATA"].ToString());
            NWM_DATA = new SqlConnection(ConfigurationManager.ConnectionStrings["NWM_DATA"].ToString());
            SNK_DATA = new SqlConnection(ConfigurationManager.ConnectionStrings["SNK_DATA"].ToString());
            EBB_DATA = new SqlConnection(ConfigurationManager.ConnectionStrings["EBB_DATA"].ToString());
            RTB_DATA = new SqlConnection(ConfigurationManager.ConnectionStrings["RTB_DATA"].ToString());
        }
        //-------------------End Connection_SQL ------------------------//

        public List<InvfileModel> TRP_INVCFILE_BRANCH_GET(string branch, string number)
        {
            try
            {
                Connection();

                List<InvfileModel> _ResponseData;

                string SQLQuery = "";
                string str_number = number.Substring(0, 3);

                if (branch == "VSK")
                {
                    VSM_DATA.Open();

                    SQLQuery = "SELECT TOP 1 invcfile.* " +
                               " FROM invcfile invcfile" +
                               " WHERE RTRIM(invcfile.number) = '" + number + "' ";

                    _ResponseData = VSM_DATA.Query<InvfileModel>(SQLQuery).ToList();
                    VSM_DATA.Close();
                    return _ResponseData.ToList();
                }
                else if (branch == "VSF")
                {
                    VSF_DATA.Open();

                    SQLQuery = "SELECT TOP 1 invcfile.* " +
                               " FROM invcfile invcfile" +
                               " WHERE RTRIM(invcfile.number) = '" + number + "' ";

                    _ResponseData = VSF_DATA.Query<InvfileModel>(SQLQuery).ToList();
                    VSF_DATA.Close();
                    return _ResponseData.ToList();
                }
                else if (branch == "KLH")
                {
                    KLH_DATA.Open();

                    SQLQuery = "SELECT TOP 1 invcfile.* " +
                               " FROM invcfile invcfile" +
                               " WHERE RTRIM(invcfile.number) = '" + number + "' ";

                    _ResponseData = KLH_DATA.Query<InvfileModel>(SQLQuery).ToList();
                    KLH_DATA.Close();
                    return _ResponseData.ToList();
                }
                else if (branch == "LLK")
                {
                    LLK_DATA.Open();

                    SQLQuery = "SELECT TOP 1 invcfile.* " +
                               " FROM invcfile invcfile" +
                               " WHERE RTRIM(invcfile.number) = '" + number + "' ";

                    _ResponseData = LLK_DATA.Query<InvfileModel>(SQLQuery).ToList();
                    LLK_DATA.Close();
                    return _ResponseData.ToList();
                }
                else if (branch == "NWM")
                {
                    NWM_DATA.Open();

                    SQLQuery = "SELECT TOP 1 invcfile.* " +
                               " FROM invcfile invcfile" +
                               " WHERE RTRIM(invcfile.number) = '" + number + "' ";

                    _ResponseData = NWM_DATA.Query<InvfileModel>(SQLQuery).ToList();
                    NWM_DATA.Close();
                    return _ResponseData.ToList();
                }
                else if (branch == "LKS")
                {
                    KSW_DATA.Open();

                    SQLQuery = "SELECT TOP 1 invcfile.* " +
                               " FROM invcfile invcfile" +
                               " WHERE RTRIM(invcfile.number) = '" + number + "' ";

                    _ResponseData = KSW_DATA.Query<InvfileModel>(SQLQuery).ToList();
                    KSW_DATA.Close();
                    return _ResponseData.ToList();
                }
                else if (branch == "SNK")
                {
                    SNK_DATA.Open();

                    SQLQuery = "SELECT TOP 1 invcfile.* " +
                               " FROM invcfile invcfile" +
                               " WHERE RTRIM(invcfile.number) = '" + number + "' ";

                    _ResponseData = SNK_DATA.Query<InvfileModel>(SQLQuery).ToList();
                    SNK_DATA.Close();
                    return _ResponseData.ToList();
                }
                else
                {
                    VSK_DATA.Open();

                    SQLQuery = "SELECT TOP 1 invcfile.* " +
                               " FROM invcfile invcfile" +
                               " WHERE RTRIM(invcfile.number) = '" + number + "' ";

                    _ResponseData = VSK_DATA.Query<InvfileModel>(SQLQuery).ToList();
                    VSK_DATA.Close();
                    return _ResponseData.ToList();
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

    }
}