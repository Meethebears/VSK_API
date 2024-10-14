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
    public class TRPRepository : Controller
    {


        //-------------------Start Connection_SQL ------------------------//
        public SqlConnection VSK_TRP;
        public SqlConnection VSK_ACC;
        public SqlConnection VSK_TMS;
        public SqlConnection VSK_CN;

        public SqlConnection VSK_CA_VSK;
        public SqlConnection VSK_CA_VSM;
        public SqlConnection VSK_CA_VSF;
        public SqlConnection VSK_CA_KLH;
        public SqlConnection VSK_CA_LKS;
        public SqlConnection VSK_CA_LLK;
        public SqlConnection VSK_CA_NWM;
        public SqlConnection VSK_CA_SNK;
        public SqlConnection VSK_CA_EBB;
        public SqlConnection VSK_CA_RTB;
        public SqlConnection VSK_CA_STP;

        private void Connection()
        {
            VSK_TRP = new SqlConnection(ConfigurationManager.ConnectionStrings["VSK_TRP"].ToString());
            VSK_ACC = new SqlConnection(ConfigurationManager.ConnectionStrings["VSK_ACC"].ToString());
            //VSK_TMS = new SqlConnection(ConfigurationManager.ConnectionStrings["VSK_TMS"].ToString());
            VSK_TMS = new SqlConnection(ConfigurationManager.ConnectionStrings["VSK_TRP_187"].ToString());
            VSK_CN = new SqlConnection(ConfigurationManager.ConnectionStrings["VSK_CN"].ToString());

            VSK_CA_VSK = new SqlConnection(ConfigurationManager.ConnectionStrings["VSK_CA_VSM"].ToString());
            VSK_CA_VSM = new SqlConnection(ConfigurationManager.ConnectionStrings["VSK_CA_VSM"].ToString());
            VSK_CA_VSF = new SqlConnection(ConfigurationManager.ConnectionStrings["VSK_CA_VSF"].ToString());
            VSK_CA_KLH = new SqlConnection(ConfigurationManager.ConnectionStrings["VSK_CA_KLH"].ToString());
            VSK_CA_LKS = new SqlConnection(ConfigurationManager.ConnectionStrings["VSK_CA_LKS"].ToString());
            VSK_CA_LLK = new SqlConnection(ConfigurationManager.ConnectionStrings["VSK_CA_LLK"].ToString());
            VSK_CA_NWM = new SqlConnection(ConfigurationManager.ConnectionStrings["VSK_CA_NWM"].ToString());
            VSK_CA_SNK = new SqlConnection(ConfigurationManager.ConnectionStrings["VSK_CA_SNK"].ToString());
            VSK_CA_EBB = new SqlConnection(ConfigurationManager.ConnectionStrings["VSK_CA_EBB"].ToString());
            VSK_CA_RTB = new SqlConnection(ConfigurationManager.ConnectionStrings["VSK_CA_RTB"].ToString());
            VSK_CA_STP = new SqlConnection(ConfigurationManager.ConnectionStrings["VSK_CA_STP"].ToString());
        }
        //-------------------End Connection_SQL ------------------------//

        public void TRP_TMS_Sync_Add(List<TMS_JOBModel> TMS_JOBModel)
        {
            try
            {
                foreach (var TMS_JOBData in TMS_JOBModel)
                {
                    DynamicParameters objParam = new DynamicParameters();
                    objParam.Add("@tms_job_date", TMS_JOBData.tms_job_date);
                    objParam.Add("@tms_job_route", TMS_JOBData.tms_job_route);
                    objParam.Add("@tms_job_plate", TMS_JOBData.tms_job_plate);
                    objParam.Add("@tms_job_name", TMS_JOBData.tms_job_name);
                    objParam.Add("@tms_job_no", TMS_JOBData.tms_job_no);
                    objParam.Add("@tms_job_cus_name", TMS_JOBData.tms_job_cus_name);
                    objParam.Add("@tms_job_created_date", TMS_JOBData.tms_job_created_date);
                    objParam.Add("@tms_job_delivery_date", TMS_JOBData.tms_job_delivery_date);

                    Connection();
                    VSK_TMS.Open();
                    VSK_TMS.Execute("SP_TRP_TMS_Sync_Add", objParam, commandType: CommandType.StoredProcedure);
                    VSK_TMS.Close();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void TRP_TMS_Sync_Delete()
        {
            try
            {
                DynamicParameters objParam = new DynamicParameters();
                Connection();
                VSK_TMS.Open();
                VSK_TMS.Execute("SP_TRP_TMS_Sync_Delete", objParam, commandType: CommandType.StoredProcedure);
                VSK_TMS.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public List<SalefileModel> TRP_Salefile_GET(string number)
        {
            try
            {
                string SQLQuery = "SELECT TOP 1 * FROM salefile WHERE number = '" + number + "' ";
                Connection();
                VSK_ACC.Open();
                List<SalefileModel> _ResponseData = VSK_ACC.Query<SalefileModel>(SQLQuery).ToList();
                VSK_ACC.Close();
                return _ResponseData.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public List<SalefileModel> TRP_SALEFILE_BRANCH_GET(string branch, string number)
        {
            try
            {
                Connection();

                List<SalefileModel> _ResponseData;

                string SQLQuery = "";
                string str_number = number.Substring(0, 2);

                if (branch == "VSK")
                {
                    VSK_CA_VSM.Open();

                    if (str_number == "IV")
                    {
                        SQLQuery = "SELECT TOP 1 s.* ," +
                           " CASE " +
                           " WHEN s.evcode != '' THEN RTRIM(s.evname) + ' ' + RTRIM(s.evadd) + ' ' + RTRIM(s.evtel) " +
                           " WHEN s.emlocation != '' THEN RTRIM(s.emlocation) " +
                           " ELSE ISNULL(NULLIF(RTRIM( CONCAT( RTRIM(e.eaddress),' ',RTRIM(e.etumbol),' ',RTRIM(e.eamphur),' ',RTRIM(e.eprovinc) , ' ' , RTRIM(e.ezip)  ) ),' '), '87/18-21 หมู่ 13 ถนนสุวินทวงศ์ แขวง มีนบุรี เขต มีนบุรี กรุงเทพมหานคร 10510') " +
                           " END AS 'e_delivery_address'" +
                           " ,RTRIM( CONCAT( RTRIM(e.eaddress),' ',RTRIM(e.etumbol),' ',RTRIM(e.eamphur),' ',RTRIM(e.eprovinc) , ' ' , RTRIM(e.ezip) ) ) AS emmas_addres" +
                           " FROM salefile s" +
                           " LEFT JOIN emmas e ON RTRIM(s.invcode) = RTRIM(e.code)" +
                           " WHERE RTRIM(s.number) = '" + number + "' ";
                    }
                    else if (str_number == "RD")
                    {
                        SQLQuery = "SELECT TOP 1 s.* ," +
                           " CASE " +
                           " WHEN s.evcode != '' THEN RTRIM(s.evname) + ' ' + RTRIM(s.evadd) + ' ' + RTRIM(s.evtel)" +
                           " WHEN s.emlocation != '' THEN RTRIM(s.emlocation)" +
                           " ELSE ISNULL(NULLIF(RTRIM( CONCAT( RTRIM(e.eaddress),' ',RTRIM(e.etumbol),' ',RTRIM(e.eamphur),' ',RTRIM(e.eprovinc) , ' ' , RTRIM(e.ezip) ) ),' '), '87/18-21 หมู่ 13 ถนนสุวินทวงศ์ แขวง มีนบุรี เขต มีนบุรี กรุงเทพมหานคร 10510')" +
                           " END AS 'e_delivery_address'" +
                           " ,RTRIM( CONCAT( RTRIM(e.eaddress),' ',RTRIM(e.etumbol),' ',RTRIM(e.eamphur),' ',RTRIM(e.eprovinc) , ' ' , RTRIM(e.ezip) ) ) AS emmas_addres" +
                           " FROM rdfile s" +
                           " WHERE RTRIM(s.number) = '" + number + "' ";
                    }
                    else
                    {
                        SQLQuery = "SELECT TOP 1 s.* ," +
                           " CASE " +
                           " WHEN s.evcode != '' THEN RTRIM(s.evname) + ' ' + RTRIM(s.evadd) + ' ' + RTRIM(s.evtel)" +
                           " WHEN s.emlocation != '' THEN RTRIM(s.emlocation)" +
                           " ELSE ISNULL(NULLIF(RTRIM( CONCAT( RTRIM(e.eaddress),' ',RTRIM(e.etumbol),' ',RTRIM(e.eamphur),' ',RTRIM(e.eprovinc) , ' ' , RTRIM(e.ezip) ) ),' '), '87/18-21 หมู่ 13 ถนนสุวินทวงศ์ แขวง มีนบุรี เขต มีนบุรี กรุงเทพมหานคร 10510')" +
                           " END AS 'e_delivery_address'" +
                           " ,RTRIM( CONCAT( RTRIM(e.eaddress),' ',RTRIM(e.etumbol),' ',RTRIM(e.eamphur),' ',RTRIM(e.eprovinc) , ' ' , RTRIM(e.ezip) ) ) AS emmas_addres" +
                           " FROM salefile s" +
                           " WHERE RTRIM(s.number) = '" + number + "' ";
                    }

                    _ResponseData = VSK_CA_VSM.Query<SalefileModel>(SQLQuery).ToList();
                    VSK_CA_VSM.Close();
                    return _ResponseData.ToList();
                }
                else if (branch == "VSF")
                {
                    VSK_CA_VSF.Open();

                    if (str_number == "IV")
                    {
                        SQLQuery = "SELECT TOP 1 s.* ," +
                            " CASE " +
                            " WHEN s.evcode != '' THEN RTRIM(s.evname) + ' ' + RTRIM(s.evadd) + ' ' + RTRIM(s.evtel)" +
                           " WHEN s.emlocation != '' THEN RTRIM(s.emlocation)" +
                           " ELSE ISNULL(NULLIF(RTRIM( CONCAT( RTRIM(e.eaddress),' ',RTRIM(e.etumbol),' ',RTRIM(e.eamphur),' ',RTRIM(e.eprovinc) , ' ' , RTRIM(e.ezip)  ) ),' '), '87/18-21 หมู่ 13 ถนนสุวินทวงศ์ แขวง มีนบุรี เขต มีนบุรี กรุงเทพมหานคร 10510')" +
                           " END AS 'e_delivery_address'" +
                           " ,RTRIM( CONCAT( RTRIM(e.eaddress),' ',RTRIM(e.etumbol),' ',RTRIM(e.eamphur),' ',RTRIM(e.eprovinc) , ' ' , RTRIM(e.ezip) ) ) AS emmas_addres" +
                           " FROM salefile s" +
                           " LEFT JOIN emmas e ON RTRIM(s.invcode) = RTRIM(e.code)" +
                           " WHERE RTRIM(s.number) = '" + number + "' ";
                    }
                    else if (str_number == "RD")
                    {
                        SQLQuery = "SELECT TOP 1 s.* ," +
                           " CASE " +
                           " WHEN s.evcode != '' THEN RTRIM(s.evname) + ' ' + RTRIM(s.evadd) + ' ' + RTRIM(s.evtel)" +
                           " WHEN s.emlocation != '' THEN RTRIM(s.emlocation)" +
                           " ELSE ISNULL(NULLIF(RTRIM( CONCAT( RTRIM(e.eaddress),' ',RTRIM(e.etumbol),' ',RTRIM(e.eamphur),' ',RTRIM(e.eprovinc) , ' ' , RTRIM(e.ezip) ) ),' '), '87/18-21 หมู่ 13 ถนนสุวินทวงศ์ แขวง มีนบุรี เขต มีนบุรี กรุงเทพมหานคร 10510')" +
                           " END AS 'e_delivery_address'" +
                           " ,RTRIM( CONCAT( RTRIM(e.eaddress),' ',RTRIM(e.etumbol),' ',RTRIM(e.eamphur),' ',RTRIM(e.eprovinc) , ' ' , RTRIM(e.ezip) ) ) AS emmas_addres" +
                           " FROM rdfile s" +
                           " WHERE RTRIM(s.number) = '" + number + "' ";
                    }
                    else
                    {
                        SQLQuery = "SELECT TOP 1 s.* ," +
                           " CASE " +
                           " WHEN s.evcode != '' THEN RTRIM(s.evname) + ' ' + RTRIM(s.evadd) + ' ' + RTRIM(s.evtel)" +
                           " WHEN s.emlocation != '' THEN RTRIM(s.emlocation)" +
                           " ELSE ISNULL(NULLIF(RTRIM( CONCAT( RTRIM(e.eaddress),' ',RTRIM(e.etumbol),' ',RTRIM(e.eamphur),' ',RTRIM(e.eprovinc) , ' ' , RTRIM(e.ezip) ) ),' '), '87/18-21 หมู่ 13 ถนนสุวินทวงศ์ แขวง มีนบุรี เขต มีนบุรี กรุงเทพมหานคร 10510')" +
                           " END AS 'e_delivery_address'" +
                           " ,RTRIM( CONCAT( RTRIM(e.eaddress),' ',RTRIM(e.etumbol),' ',RTRIM(e.eamphur),' ',RTRIM(e.eprovinc) , ' ' , RTRIM(e.ezip) ) ) AS emmas_addres" +
                           " FROM salefile s" +
                           " WHERE RTRIM(s.number) = '" + number + "' ";
                    }


                    //if (str_number == "IV")
                    //{
                    //    SQLQuery = "SELECT TOP 1 s.* ," +
                    //       " CASE " +
                    //       " WHEN s.evcode != '' THEN RTRIM(s.evname) + ' ' + RTRIM(s.evadd) + ' ' + RTRIM(s.evtel)" +
                    //       " WHEN s.emlocation != '' THEN RTRIM(s.emlocation)" +
                    //       " ELSE ISNULL(NULLIF(RTRIM( CONCAT( RTRIM(e.eaddress),' ',RTRIM(e.etumbol),' ',RTRIM(e.eamphur),' ',RTRIM(e.eprovinc) , ' ' , RTRIM(e.ezip) ) ),' '), '87/18-21 หมู่ 13 ถนนสุวินทวงศ์ แขวง มีนบุรี เขต มีนบุรี กรุงเทพมหานคร 10510')" +
                    //       " END AS 'e_delivery_address'" +
                    //       " ,RTRIM( CONCAT( RTRIM(e.eaddress),' ',RTRIM(e.etumbol),' ',RTRIM(e.eamphur),' ',RTRIM(e.eprovinc) , ' ' , RTRIM(e.ezip) ) ) AS emmas_addres" +
                    //       " FROM salefile s" +
                    //       " WHERE RTRIM(s.number) = '" + number + "' ";
                    //}
                    //else if (str_number == "RD")
                    //{
                    //    SQLQuery = "SELECT TOP 1 s.* ," +
                    //    " CASE " +
                    //    " WHEN s.evcode != '' THEN RTRIM(s.evname) + ' ' + RTRIM(s.evadd) + ' ' + RTRIM(s.evtel)" +
                    //       " WHEN s.emlocation != '' THEN RTRIM(s.emlocation)" +
                    //       " ELSE ISNULL(NULLIF(RTRIM( CONCAT( RTRIM(e.eaddress),' ',RTRIM(e.etumbol),' ',RTRIM(e.eamphur),' ',RTRIM(e.eprovinc) , ' ' , RTRIM(e.ezip) ) ),' '), '87/18-21 หมู่ 13 ถนนสุวินทวงศ์ แขวง มีนบุรี เขต มีนบุรี กรุงเทพมหานคร 10510')" +
                    //       " END AS 'e_delivery_address'" +
                    //       " ,RTRIM( CONCAT( RTRIM(e.eaddress),' ',RTRIM(e.etumbol),' ',RTRIM(e.eamphur),' ',RTRIM(e.eprovinc) , ' ' , RTRIM(e.ezip) ) ) AS emmas_addres" +
                    //    " FROM rdfile s" +
                    //    " WHERE RTRIM(s.number) = '" + number + "' ";
                    //}
                    //else
                    //{
                    //    SQLQuery = "SELECT TOP 1 s.* ," +
                    //       " CASE " +
                    //       " WHEN s.evcode != '' THEN RTRIM(s.evname) + ' ' + RTRIM(s.evadd) + ' ' + RTRIM(s.evtel)" +
                    //       " WHEN s.emlocation != '' THEN RTRIM(s.emlocation)" +
                    //       " ELSE ISNULL(NULLIF(RTRIM( CONCAT( RTRIM(e.eaddress),' ',RTRIM(e.etumbol),' ',RTRIM(e.eamphur),' ',RTRIM(e.eprovinc) , ' ' , RTRIM(e.ezip) ) ),' '), '87/18-21 หมู่ 13 ถนนสุวินทวงศ์ แขวง มีนบุรี เขต มีนบุรี กรุงเทพมหานคร 10510')" +
                    //       " END AS 'e_delivery_address'" +
                    //       " ,RTRIM( CONCAT( RTRIM(e.eaddress),' ',RTRIM(e.etumbol),' ',RTRIM(e.eamphur),' ',RTRIM(e.eprovinc) , ' ' , RTRIM(e.ezip) ) ) AS emmas_addres" +
                    //       " FROM salefile s" +
                    //       " WHERE RTRIM(s.number) = '" + number + "' ";
                    //}

                    _ResponseData = VSK_CA_VSF.Query<SalefileModel>(SQLQuery).ToList();
                    VSK_CA_VSF.Close();
                    return _ResponseData.ToList();
                }
                else if (branch == "KLH")
                {
                    VSK_CA_KLH.Open();

                    if (str_number == "IV")
                    {
                        SQLQuery = "SELECT TOP 1 s.* ," +
                            " CASE " +
                            " WHEN s.evcode != '' THEN RTRIM(s.evname) + ' ' + RTRIM(s.evadd) + ' ' + RTRIM(s.evtel)" +
                           " WHEN s.emlocation != '' THEN RTRIM(s.emlocation)" +
                           " ELSE ISNULL(NULLIF(RTRIM( CONCAT( RTRIM(e.eaddress),' ',RTRIM(e.etumbol),' ',RTRIM(e.eamphur),' ',RTRIM(e.eprovinc) , ' ' , RTRIM(e.ezip)  ) ),' '), '87/18-21 หมู่ 13 ถนนสุวินทวงศ์ แขวง มีนบุรี เขต มีนบุรี กรุงเทพมหานคร 10510')" +
                           " END AS 'e_delivery_address'" +
                           " ,RTRIM( CONCAT( RTRIM(e.eaddress),' ',RTRIM(e.etumbol),' ',RTRIM(e.eamphur),' ',RTRIM(e.eprovinc) , ' ' , RTRIM(e.ezip) ) ) AS emmas_addres" +
                           " FROM salefile s" +
                           " LEFT JOIN emmas e ON RTRIM(s.invcode) = RTRIM(e.code)" +
                           " WHERE RTRIM(s.number) = '" + number + "' ";
                    }
                    else if (str_number == "RD")
                    {
                        SQLQuery = "SELECT TOP 1 s.* ," +
                           " CASE " +
                           " WHEN s.evcode != '' THEN RTRIM(s.evname) + ' ' + RTRIM(s.evadd) + ' ' + RTRIM(s.evtel)" +
                           " WHEN s.emlocation != '' THEN RTRIM(s.emlocation)" +
                           " ELSE ISNULL(NULLIF(RTRIM( CONCAT( RTRIM(e.eaddress),' ',RTRIM(e.etumbol),' ',RTRIM(e.eamphur),' ',RTRIM(e.eprovinc) , ' ' , RTRIM(e.ezip) ) ),' '), '87/18-21 หมู่ 13 ถนนสุวินทวงศ์ แขวง มีนบุรี เขต มีนบุรี กรุงเทพมหานคร 10510')" +
                           " END AS 'e_delivery_address'" +
                           " ,RTRIM( CONCAT( RTRIM(e.eaddress),' ',RTRIM(e.etumbol),' ',RTRIM(e.eamphur),' ',RTRIM(e.eprovinc) , ' ' , RTRIM(e.ezip) ) ) AS emmas_addres" +
                           " FROM rdfile s" +
                           " WHERE RTRIM(s.number) = '" + number + "' ";
                    }
                    else
                    {
                        SQLQuery = "SELECT TOP 1 s.* ," +
                           " CASE " +
                           " WHEN s.evcode != '' THEN RTRIM(s.evname) + ' ' + RTRIM(s.evadd) + ' ' + RTRIM(s.evtel)" +
                           " WHEN s.emlocation != '' THEN RTRIM(s.emlocation)" +
                           " ELSE ISNULL(NULLIF(RTRIM( CONCAT( RTRIM(e.eaddress),' ',RTRIM(e.etumbol),' ',RTRIM(e.eamphur),' ',RTRIM(e.eprovinc) , ' ' , RTRIM(e.ezip) ) ),' '), '87/18-21 หมู่ 13 ถนนสุวินทวงศ์ แขวง มีนบุรี เขต มีนบุรี กรุงเทพมหานคร 10510')" +
                           " END AS 'e_delivery_address'" +
                           " ,RTRIM( CONCAT( RTRIM(e.eaddress),' ',RTRIM(e.etumbol),' ',RTRIM(e.eamphur),' ',RTRIM(e.eprovinc) , ' ' , RTRIM(e.ezip) ) ) AS emmas_addres" +
                           " FROM salefile s" +
                           " WHERE RTRIM(s.number) = '" + number + "' ";
                    }

                    _ResponseData = VSK_CA_KLH.Query<SalefileModel>(SQLQuery).ToList();
                    VSK_CA_KLH.Close();
                    return _ResponseData.ToList();
                }
                else if (branch == "LLK")
                {
                    VSK_CA_LLK.Open();

                    if (str_number == "IV")
                    {
                        SQLQuery = "SELECT TOP 1 s.* ," +
                            " CASE " +
                            " WHEN s.evcode != '' THEN RTRIM(s.evname) + ' ' + RTRIM(s.evadd) + ' ' + RTRIM(s.evtel)" +
                           " WHEN s.emlocation != '' THEN RTRIM(s.emlocation)" +
                           " ELSE ISNULL(NULLIF(RTRIM( CONCAT( RTRIM(e.eaddress),' ',RTRIM(e.etumbol),' ',RTRIM(e.eamphur),' ',RTRIM(e.eprovinc) , ' ' , RTRIM(e.ezip)  ) ),' '), '87/18-21 หมู่ 13 ถนนสุวินทวงศ์ แขวง มีนบุรี เขต มีนบุรี กรุงเทพมหานคร 10510')" +
                           " END AS 'e_delivery_address'" +
                           " ,RTRIM( CONCAT( RTRIM(e.eaddress),' ',RTRIM(e.etumbol),' ',RTRIM(e.eamphur),' ',RTRIM(e.eprovinc) , ' ' , RTRIM(e.ezip) ) ) AS emmas_addres" +
                           " FROM salefile s" +
                           " LEFT JOIN emmas e ON RTRIM(s.invcode) = RTRIM(e.code)" +
                           " WHERE RTRIM(s.number) = '" + number + "' ";
                    }
                    else if (str_number == "RD")
                    {
                        SQLQuery = "SELECT TOP 1 s.* ," +
                           " CASE " +
                           " WHEN s.evcode != '' THEN RTRIM(s.evname) + ' ' + RTRIM(s.evadd) + ' ' + RTRIM(s.evtel)" +
                           " WHEN s.emlocation != '' THEN RTRIM(s.emlocation)" +
                           " ELSE ISNULL(NULLIF(RTRIM( CONCAT( RTRIM(e.eaddress),' ',RTRIM(e.etumbol),' ',RTRIM(e.eamphur),' ',RTRIM(e.eprovinc) , ' ' , RTRIM(e.ezip) ) ),' '), '87/18-21 หมู่ 13 ถนนสุวินทวงศ์ แขวง มีนบุรี เขต มีนบุรี กรุงเทพมหานคร 10510')" +
                           " END AS 'e_delivery_address'" +
                           " ,RTRIM( CONCAT( RTRIM(e.eaddress),' ',RTRIM(e.etumbol),' ',RTRIM(e.eamphur),' ',RTRIM(e.eprovinc) , ' ' , RTRIM(e.ezip) ) ) AS emmas_addres" +
                           " FROM rdfile s" +
                           " WHERE RTRIM(s.number) = '" + number + "' ";
                    }
                    else
                    {
                        SQLQuery = "SELECT TOP 1 s.* ," +
                           " CASE " +
                           " WHEN s.evcode != '' THEN RTRIM(s.evname) + ' ' + RTRIM(s.evadd) + ' ' + RTRIM(s.evtel)" +
                           " WHEN s.emlocation != '' THEN RTRIM(s.emlocation)" +
                           " ELSE ISNULL(NULLIF(RTRIM( CONCAT( RTRIM(e.eaddress),' ',RTRIM(e.etumbol),' ',RTRIM(e.eamphur),' ',RTRIM(e.eprovinc) , ' ' , RTRIM(e.ezip) ) ),' '), '87/18-21 หมู่ 13 ถนนสุวินทวงศ์ แขวง มีนบุรี เขต มีนบุรี กรุงเทพมหานคร 10510')" +
                           " END AS 'e_delivery_address'" +
                           " ,RTRIM( CONCAT( RTRIM(e.eaddress),' ',RTRIM(e.etumbol),' ',RTRIM(e.eamphur),' ',RTRIM(e.eprovinc) , ' ' , RTRIM(e.ezip) ) ) AS emmas_addres" +
                           " FROM salefile s" +
                           " WHERE RTRIM(s.number) = '" + number + "' ";
                    }

                    _ResponseData = VSK_CA_LLK.Query<SalefileModel>(SQLQuery).ToList();
                    VSK_CA_LLK.Close();
                    return _ResponseData.ToList();
                }
                else if (branch == "NWM")
                {
                    VSK_CA_NWM.Open();

                    if (str_number == "IV")
                    {
                        SQLQuery = "SELECT TOP 1 s.* ," +
                            " CASE " +
                            " WHEN s.evcode != '' THEN RTRIM(s.evname) + ' ' + RTRIM(s.evadd) + ' ' + RTRIM(s.evtel)" +
                           " WHEN s.emlocation != '' THEN RTRIM(s.emlocation)" +
                           " ELSE ISNULL(NULLIF(RTRIM( CONCAT( RTRIM(e.eaddress),' ',RTRIM(e.etumbol),' ',RTRIM(e.eamphur),' ',RTRIM(e.eprovinc) , ' ' , RTRIM(e.ezip)  ) ),' '), '87/18-21 หมู่ 13 ถนนสุวินทวงศ์ แขวง มีนบุรี เขต มีนบุรี กรุงเทพมหานคร 10510')" +
                           " END AS 'e_delivery_address'" +
                           " ,RTRIM( CONCAT( RTRIM(e.eaddress),' ',RTRIM(e.etumbol),' ',RTRIM(e.eamphur),' ',RTRIM(e.eprovinc) , ' ' , RTRIM(e.ezip) ) ) AS emmas_addres" +
                           " FROM salefile s" +
                           " LEFT JOIN emmas e ON RTRIM(s.invcode) = RTRIM(e.code)" +
                           " WHERE RTRIM(s.number) = '" + number + "' ";
                    }
                    else if (str_number == "RD")
                    {
                        SQLQuery = "SELECT TOP 1 s.* ," +
                           " CASE " +
                           " WHEN s.evcode != '' THEN RTRIM(s.evname) + ' ' + RTRIM(s.evadd) + ' ' + RTRIM(s.evtel)" +
                           " WHEN s.emlocation != '' THEN RTRIM(s.emlocation)" +
                           " ELSE ISNULL(NULLIF(RTRIM( CONCAT( RTRIM(e.eaddress),' ',RTRIM(e.etumbol),' ',RTRIM(e.eamphur),' ',RTRIM(e.eprovinc) , ' ' , RTRIM(e.ezip) ) ),' '), '87/18-21 หมู่ 13 ถนนสุวินทวงศ์ แขวง มีนบุรี เขต มีนบุรี กรุงเทพมหานคร 10510')" +
                           " END AS 'e_delivery_address'" +
                           " ,RTRIM( CONCAT( RTRIM(e.eaddress),' ',RTRIM(e.etumbol),' ',RTRIM(e.eamphur),' ',RTRIM(e.eprovinc) , ' ' , RTRIM(e.ezip) ) ) AS emmas_addres" +
                           " FROM rdfile s" +
                           " WHERE RTRIM(s.number) = '" + number + "' ";
                    }
                    else
                    {
                        SQLQuery = "SELECT TOP 1 s.* ," +
                           " CASE " +
                           " WHEN s.evcode != '' THEN RTRIM(s.evname) + ' ' + RTRIM(s.evadd) + ' ' + RTRIM(s.evtel)" +
                           " WHEN s.emlocation != '' THEN RTRIM(s.emlocation)" +
                           " ELSE ISNULL(NULLIF(RTRIM( CONCAT( RTRIM(e.eaddress),' ',RTRIM(e.etumbol),' ',RTRIM(e.eamphur),' ',RTRIM(e.eprovinc) , ' ' , RTRIM(e.ezip) ) ),' '), '87/18-21 หมู่ 13 ถนนสุวินทวงศ์ แขวง มีนบุรี เขต มีนบุรี กรุงเทพมหานคร 10510')" +
                           " END AS 'e_delivery_address'" +
                           " ,RTRIM( CONCAT( RTRIM(e.eaddress),' ',RTRIM(e.etumbol),' ',RTRIM(e.eamphur),' ',RTRIM(e.eprovinc) , ' ' , RTRIM(e.ezip) ) ) AS emmas_addres" +
                           " FROM salefile s" +
                           " WHERE RTRIM(s.number) = '" + number + "' ";
                    }

                    _ResponseData = VSK_CA_NWM.Query<SalefileModel>(SQLQuery).ToList();
                    VSK_CA_NWM.Close();
                    return _ResponseData.ToList();
                }
                else if (branch == "LKS")
                {
                    VSK_CA_LKS.Open();

                    if (str_number == "IV")
                    {
                        SQLQuery = "SELECT TOP 1 s.* ," +
                            " CASE " +
                            " WHEN s.evcode != '' THEN RTRIM(s.evname) + ' ' + RTRIM(s.evadd) + ' ' + RTRIM(s.evtel)" +
                           " WHEN s.emlocation != '' THEN RTRIM(s.emlocation)" +
                           " ELSE ISNULL(NULLIF(RTRIM( CONCAT( RTRIM(e.eaddress),' ',RTRIM(e.etumbol),' ',RTRIM(e.eamphur),' ',RTRIM(e.eprovinc) , ' ' , RTRIM(e.ezip)  ) ),' '), '87/18-21 หมู่ 13 ถนนสุวินทวงศ์ แขวง มีนบุรี เขต มีนบุรี กรุงเทพมหานคร 10510')" +
                           " END AS 'e_delivery_address'" +
                           " ,RTRIM( CONCAT( RTRIM(e.eaddress),' ',RTRIM(e.etumbol),' ',RTRIM(e.eamphur),' ',RTRIM(e.eprovinc) , ' ' , RTRIM(e.ezip) ) ) AS emmas_addres" +
                           " FROM salefile s" +
                           " LEFT JOIN emmas e ON RTRIM(s.invcode) = RTRIM(e.code)" +
                           " WHERE RTRIM(s.number) = '" + number + "' ";
                    }
                    else if (str_number == "RD")
                    {
                        SQLQuery = "SELECT TOP 1 s.* ," +
                           " CASE " +
                           " WHEN s.evcode != '' THEN RTRIM(s.evname) + ' ' + RTRIM(s.evadd) + ' ' + RTRIM(s.evtel)" +
                           " WHEN s.emlocation != '' THEN RTRIM(s.emlocation)" +
                           " ELSE ISNULL(NULLIF(RTRIM( CONCAT( RTRIM(e.eaddress),' ',RTRIM(e.etumbol),' ',RTRIM(e.eamphur),' ',RTRIM(e.eprovinc) , ' ' , RTRIM(e.ezip) ) ),' '), '87/18-21 หมู่ 13 ถนนสุวินทวงศ์ แขวง มีนบุรี เขต มีนบุรี กรุงเทพมหานคร 10510')" +
                           " END AS 'e_delivery_address'" +
                           " ,RTRIM( CONCAT( RTRIM(e.eaddress),' ',RTRIM(e.etumbol),' ',RTRIM(e.eamphur),' ',RTRIM(e.eprovinc) , ' ' , RTRIM(e.ezip) ) ) AS emmas_addres" +
                           " FROM rdfile s" +
                           " WHERE RTRIM(s.number) = '" + number + "' ";
                    }
                    else
                    {
                        SQLQuery = "SELECT TOP 1 s.* ," +
                           " CASE " +
                           " WHEN s.evcode != '' THEN RTRIM(s.evname) + ' ' + RTRIM(s.evadd) + ' ' + RTRIM(s.evtel)" +
                           " WHEN s.emlocation != '' THEN RTRIM(s.emlocation)" +
                           " ELSE ISNULL(NULLIF(RTRIM( CONCAT( RTRIM(e.eaddress),' ',RTRIM(e.etumbol),' ',RTRIM(e.eamphur),' ',RTRIM(e.eprovinc) , ' ' , RTRIM(e.ezip) ) ),' '), '87/18-21 หมู่ 13 ถนนสุวินทวงศ์ แขวง มีนบุรี เขต มีนบุรี กรุงเทพมหานคร 10510')" +
                           " END AS 'e_delivery_address'" +
                           " ,RTRIM( CONCAT( RTRIM(e.eaddress),' ',RTRIM(e.etumbol),' ',RTRIM(e.eamphur),' ',RTRIM(e.eprovinc) , ' ' , RTRIM(e.ezip) ) ) AS emmas_addres" +
                           " FROM salefile s" +
                           " WHERE RTRIM(s.number) = '" + number + "' ";
                    }

                    _ResponseData = VSK_CA_LKS.Query<SalefileModel>(SQLQuery).ToList();
                    VSK_CA_LKS.Close();
                    return _ResponseData.ToList();
                }
                else if (branch == "SNK")
                {
                    VSK_CA_SNK.Open();

                    if (str_number == "IV")
                    {
                        SQLQuery = "SELECT TOP 1 s.* ," +
                            " CASE " +
                            " WHEN s.evcode != '' THEN RTRIM(s.evname) + ' ' + RTRIM(s.evadd) + ' ' + RTRIM(s.evtel)" +
                           " WHEN s.emlocation != '' THEN RTRIM(s.emlocation)" +
                           " ELSE ISNULL(NULLIF(RTRIM( CONCAT( RTRIM(e.eaddress),' ',RTRIM(e.etumbol),' ',RTRIM(e.eamphur),' ',RTRIM(e.eprovinc) , ' ' , RTRIM(e.ezip)  ) ),' '), '87/18-21 หมู่ 13 ถนนสุวินทวงศ์ แขวง มีนบุรี เขต มีนบุรี กรุงเทพมหานคร 10510')" +
                           " END AS 'e_delivery_address'" +
                           " ,RTRIM( CONCAT( RTRIM(e.eaddress),' ',RTRIM(e.etumbol),' ',RTRIM(e.eamphur),' ',RTRIM(e.eprovinc) , ' ' , RTRIM(e.ezip) ) ) AS emmas_addres" +
                           " FROM salefile s" +
                           " LEFT JOIN emmas e ON RTRIM(s.invcode) = RTRIM(e.code)" +
                           " WHERE RTRIM(s.number) = '" + number + "' ";
                    }
                    else if (str_number == "RD")
                    {
                        SQLQuery = "SELECT TOP 1 s.* ," +
                           " CASE " +
                           " WHEN s.evcode != '' THEN RTRIM(s.evname) + ' ' + RTRIM(s.evadd) + ' ' + RTRIM(s.evtel)" +
                           " WHEN s.emlocation != '' THEN RTRIM(s.emlocation)" +
                           " ELSE ISNULL(NULLIF(RTRIM( CONCAT( RTRIM(e.eaddress),' ',RTRIM(e.etumbol),' ',RTRIM(e.eamphur),' ',RTRIM(e.eprovinc) , ' ' , RTRIM(e.ezip) ) ),' '), '87/18-21 หมู่ 13 ถนนสุวินทวงศ์ แขวง มีนบุรี เขต มีนบุรี กรุงเทพมหานคร 10510')" +
                           " END AS 'e_delivery_address'" +
                           " ,RTRIM( CONCAT( RTRIM(e.eaddress),' ',RTRIM(e.etumbol),' ',RTRIM(e.eamphur),' ',RTRIM(e.eprovinc) , ' ' , RTRIM(e.ezip) ) ) AS emmas_addres" +
                           " FROM rdfile s" +
                           " WHERE RTRIM(s.number) = '" + number + "' ";
                    }
                    else
                    {
                        SQLQuery = "SELECT TOP 1 s.* ," +
                           " CASE " +
                           " WHEN s.evcode != '' THEN RTRIM(s.evname) + ' ' + RTRIM(s.evadd) + ' ' + RTRIM(s.evtel)" +
                           " WHEN s.emlocation != '' THEN RTRIM(s.emlocation)" +
                           " ELSE ISNULL(NULLIF(RTRIM( CONCAT( RTRIM(e.eaddress),' ',RTRIM(e.etumbol),' ',RTRIM(e.eamphur),' ',RTRIM(e.eprovinc) , ' ' , RTRIM(e.ezip) ) ),' '), '87/18-21 หมู่ 13 ถนนสุวินทวงศ์ แขวง มีนบุรี เขต มีนบุรี กรุงเทพมหานคร 10510')" +
                           " END AS 'e_delivery_address'" +
                           " ,RTRIM( CONCAT( RTRIM(e.eaddress),' ',RTRIM(e.etumbol),' ',RTRIM(e.eamphur),' ',RTRIM(e.eprovinc) , ' ' , RTRIM(e.ezip) ) ) AS emmas_addres" +
                           " FROM salefile s" +
                           " WHERE RTRIM(s.number) = '" + number + "' ";
                    }

                    _ResponseData = VSK_CA_SNK.Query<SalefileModel>(SQLQuery).ToList();
                    VSK_CA_SNK.Close();
                    return _ResponseData.ToList();
                }
                else if (branch == "EBB")
                {
                    VSK_CA_EBB.Open();

                    if (str_number == "IV")
                    {
                        SQLQuery = "SELECT TOP 1 s.* ," +
                            " CASE " +
                            " WHEN s.evcode != '' THEN RTRIM(s.evname) + ' ' + RTRIM(s.evadd) + ' ' + RTRIM(s.evtel)" +
                           " WHEN s.emlocation != '' THEN RTRIM(s.emlocation)" +
                           " ELSE ISNULL(NULLIF(RTRIM( CONCAT( RTRIM(e.eaddress),' ',RTRIM(e.etumbol),' ',RTRIM(e.eamphur),' ',RTRIM(e.eprovinc) , ' ' , RTRIM(e.ezip)  ) ),' '), '87/18-21 หมู่ 13 ถนนสุวินทวงศ์ แขวง มีนบุรี เขต มีนบุรี กรุงเทพมหานคร 10510')" +
                           " END AS 'e_delivery_address'" +
                           " ,RTRIM( CONCAT( RTRIM(e.eaddress),' ',RTRIM(e.etumbol),' ',RTRIM(e.eamphur),' ',RTRIM(e.eprovinc) , ' ' , RTRIM(e.ezip) ) ) AS emmas_addres" +
                           " FROM salefile s" +
                           " LEFT JOIN emmas e ON RTRIM(s.invcode) = RTRIM(e.code)" +
                           " WHERE RTRIM(s.number) = '" + number + "' ";
                    }
                    else if (str_number == "RD")
                    {
                        SQLQuery = "SELECT TOP 1 s.* ," +
                           " CASE " +
                           " WHEN s.evcode != '' THEN RTRIM(s.evname) + ' ' + RTRIM(s.evadd) + ' ' + RTRIM(s.evtel)" +
                           " WHEN s.emlocation != '' THEN RTRIM(s.emlocation)" +
                           " ELSE ISNULL(NULLIF(RTRIM( CONCAT( RTRIM(e.eaddress),' ',RTRIM(e.etumbol),' ',RTRIM(e.eamphur),' ',RTRIM(e.eprovinc) , ' ' , RTRIM(e.ezip) ) ),' '), '87/18-21 หมู่ 13 ถนนสุวินทวงศ์ แขวง มีนบุรี เขต มีนบุรี กรุงเทพมหานคร 10510')" +
                           " END AS 'e_delivery_address'" +
                           " ,RTRIM( CONCAT( RTRIM(e.eaddress),' ',RTRIM(e.etumbol),' ',RTRIM(e.eamphur),' ',RTRIM(e.eprovinc) , ' ' , RTRIM(e.ezip) ) ) AS emmas_addres" +
                           " FROM rdfile s" +
                           " WHERE RTRIM(s.number) = '" + number + "' ";
                    }
                    else
                    {
                        SQLQuery = "SELECT TOP 1 s.* ," +
                           " CASE " +
                           " WHEN s.evcode != '' THEN RTRIM(s.evname) + ' ' + RTRIM(s.evadd) + ' ' + RTRIM(s.evtel)" +
                           " WHEN s.emlocation != '' THEN RTRIM(s.emlocation)" +
                           " ELSE ISNULL(NULLIF(RTRIM( CONCAT( RTRIM(e.eaddress),' ',RTRIM(e.etumbol),' ',RTRIM(e.eamphur),' ',RTRIM(e.eprovinc) , ' ' , RTRIM(e.ezip) ) ),' '), '87/18-21 หมู่ 13 ถนนสุวินทวงศ์ แขวง มีนบุรี เขต มีนบุรี กรุงเทพมหานคร 10510')" +
                           " END AS 'e_delivery_address'" +
                           " ,RTRIM( CONCAT( RTRIM(e.eaddress),' ',RTRIM(e.etumbol),' ',RTRIM(e.eamphur),' ',RTRIM(e.eprovinc) , ' ' , RTRIM(e.ezip) ) ) AS emmas_addres" +
                           " FROM salefile s" +
                           " WHERE RTRIM(s.number) = '" + number + "' ";
                    }

                    _ResponseData = VSK_CA_EBB.Query<SalefileModel>(SQLQuery).ToList();
                    VSK_CA_EBB.Close();
                    return _ResponseData.ToList();
                } 
                else if (branch == "RTB")
                {
                    VSK_CA_RTB.Open();

                    if (str_number == "IV")
                    {
                        SQLQuery = "SELECT TOP 1 s.* ," +
                            " CASE " +
                            " WHEN s.evcode != '' THEN RTRIM(s.evname) + ' ' + RTRIM(s.evadd) + ' ' + RTRIM(s.evtel)" +
                           " WHEN s.emlocation != '' THEN RTRIM(s.emlocation)" +
                           " ELSE ISNULL(NULLIF(RTRIM( CONCAT( RTRIM(e.eaddress),' ',RTRIM(e.etumbol),' ',RTRIM(e.eamphur),' ',RTRIM(e.eprovinc) , ' ' , RTRIM(e.ezip)  ) ),' '), '87/18-21 หมู่ 13 ถนนสุวินทวงศ์ แขวง มีนบุรี เขต มีนบุรี กรุงเทพมหานคร 10510')" +
                           " END AS 'e_delivery_address'" +
                           " ,RTRIM( CONCAT( RTRIM(e.eaddress),' ',RTRIM(e.etumbol),' ',RTRIM(e.eamphur),' ',RTRIM(e.eprovinc) , ' ' , RTRIM(e.ezip) ) ) AS emmas_addres" +
                           " FROM salefile s" +
                           " LEFT JOIN emmas e ON RTRIM(s.invcode) = RTRIM(e.code)" +
                           " WHERE RTRIM(s.number) = '" + number + "' ";
                    }
                    else if (str_number == "RD")
                    {
                        SQLQuery = "SELECT TOP 1 s.* ," +
                           " CASE " +
                           " WHEN s.evcode != '' THEN RTRIM(s.evname) + ' ' + RTRIM(s.evadd) + ' ' + RTRIM(s.evtel)" +
                           " WHEN s.emlocation != '' THEN RTRIM(s.emlocation)" +
                           " ELSE ISNULL(NULLIF(RTRIM( CONCAT( RTRIM(e.eaddress),' ',RTRIM(e.etumbol),' ',RTRIM(e.eamphur),' ',RTRIM(e.eprovinc) , ' ' , RTRIM(e.ezip) ) ),' '), '87/18-21 หมู่ 13 ถนนสุวินทวงศ์ แขวง มีนบุรี เขต มีนบุรี กรุงเทพมหานคร 10510')" +
                           " END AS 'e_delivery_address'" +
                           " ,RTRIM( CONCAT( RTRIM(e.eaddress),' ',RTRIM(e.etumbol),' ',RTRIM(e.eamphur),' ',RTRIM(e.eprovinc) , ' ' , RTRIM(e.ezip) ) ) AS emmas_addres" +
                           " FROM rdfile s" +
                           " WHERE RTRIM(s.number) = '" + number + "' ";
                    }
                    else
                    {
                        SQLQuery = "SELECT TOP 1 s.* ," +
                           " CASE " +
                           " WHEN s.evcode != '' THEN RTRIM(s.evname) + ' ' + RTRIM(s.evadd) + ' ' + RTRIM(s.evtel)" +
                           " WHEN s.emlocation != '' THEN RTRIM(s.emlocation)" +
                           " ELSE ISNULL(NULLIF(RTRIM( CONCAT( RTRIM(e.eaddress),' ',RTRIM(e.etumbol),' ',RTRIM(e.eamphur),' ',RTRIM(e.eprovinc) , ' ' , RTRIM(e.ezip) ) ),' '), '87/18-21 หมู่ 13 ถนนสุวินทวงศ์ แขวง มีนบุรี เขต มีนบุรี กรุงเทพมหานคร 10510')" +
                           " END AS 'e_delivery_address'" +
                           " ,RTRIM( CONCAT( RTRIM(e.eaddress),' ',RTRIM(e.etumbol),' ',RTRIM(e.eamphur),' ',RTRIM(e.eprovinc) , ' ' , RTRIM(e.ezip) ) ) AS emmas_addres" +
                           " FROM salefile s" +
                           " WHERE RTRIM(s.number) = '" + number + "' ";
                    }

                    _ResponseData = VSK_CA_RTB.Query<SalefileModel>(SQLQuery).ToList();
                    VSK_CA_RTB.Close();
                    return _ResponseData.ToList();
                }
                else if (branch == "STP")
                {
                    VSK_CA_STP.Open();

                    if (str_number == "IV")
                    {
                        SQLQuery = "SELECT TOP 1 s.* ," +
                            " CASE " +
                            " WHEN s.evcode != '' THEN RTRIM(s.evname) + ' ' + RTRIM(s.evadd) + ' ' + RTRIM(s.evtel)" +
                           " WHEN s.emlocation != '' THEN RTRIM(s.emlocation)" +
                           " ELSE ISNULL(NULLIF(RTRIM( CONCAT( RTRIM(e.eaddress),' ',RTRIM(e.etumbol),' ',RTRIM(e.eamphur),' ',RTRIM(e.eprovinc) , ' ' , RTRIM(e.ezip)  ) ),' '), '87/18-21 หมู่ 13 ถนนสุวินทวงศ์ แขวง มีนบุรี เขต มีนบุรี กรุงเทพมหานคร 10510')" +
                           " END AS 'e_delivery_address'" +
                           " ,RTRIM( CONCAT( RTRIM(e.eaddress),' ',RTRIM(e.etumbol),' ',RTRIM(e.eamphur),' ',RTRIM(e.eprovinc) , ' ' , RTRIM(e.ezip) ) ) AS emmas_addres" +
                           " FROM salefile s" +
                           " LEFT JOIN emmas e ON RTRIM(s.invcode) = RTRIM(e.code)" +
                           " WHERE RTRIM(s.number) = '" + number + "' ";
                    }
                    else if (str_number == "RD")
                    {
                        SQLQuery = "SELECT TOP 1 s.* ," +
                           " CASE " +
                           " WHEN s.evcode != '' THEN RTRIM(s.evname) + ' ' + RTRIM(s.evadd) + ' ' + RTRIM(s.evtel)" +
                           " WHEN s.emlocation != '' THEN RTRIM(s.emlocation)" +
                           " ELSE ISNULL(NULLIF(RTRIM( CONCAT( RTRIM(e.eaddress),' ',RTRIM(e.etumbol),' ',RTRIM(e.eamphur),' ',RTRIM(e.eprovinc) , ' ' , RTRIM(e.ezip) ) ),' '), '87/18-21 หมู่ 13 ถนนสุวินทวงศ์ แขวง มีนบุรี เขต มีนบุรี กรุงเทพมหานคร 10510')" +
                           " END AS 'e_delivery_address'" +
                           " ,RTRIM( CONCAT( RTRIM(e.eaddress),' ',RTRIM(e.etumbol),' ',RTRIM(e.eamphur),' ',RTRIM(e.eprovinc) , ' ' , RTRIM(e.ezip) ) ) AS emmas_addres" +
                           " FROM rdfile s" +
                           " WHERE RTRIM(s.number) = '" + number + "' ";
                    }
                    else
                    {
                        SQLQuery = "SELECT TOP 1 s.* ," +
                           " CASE " +
                           " WHEN s.evcode != '' THEN RTRIM(s.evname) + ' ' + RTRIM(s.evadd) + ' ' + RTRIM(s.evtel)" +
                           " WHEN s.emlocation != '' THEN RTRIM(s.emlocation)" +
                           " ELSE ISNULL(NULLIF(RTRIM( CONCAT( RTRIM(e.eaddress),' ',RTRIM(e.etumbol),' ',RTRIM(e.eamphur),' ',RTRIM(e.eprovinc) , ' ' , RTRIM(e.ezip) ) ),' '), '87/18-21 หมู่ 13 ถนนสุวินทวงศ์ แขวง มีนบุรี เขต มีนบุรี กรุงเทพมหานคร 10510')" +
                           " END AS 'e_delivery_address'" +
                           " ,RTRIM( CONCAT( RTRIM(e.eaddress),' ',RTRIM(e.etumbol),' ',RTRIM(e.eamphur),' ',RTRIM(e.eprovinc) , ' ' , RTRIM(e.ezip) ) ) AS emmas_addres" +
                           " FROM salefile s" +
                           " WHERE RTRIM(s.number) = '" + number + "' ";
                    }

                    _ResponseData = VSK_CA_STP.Query<SalefileModel>(SQLQuery).ToList();
                    VSK_CA_STP.Close();
                    return _ResponseData.ToList();
                }
                // Open New Branch
                //else if (branch == "???")
                //{
                //    VSK_CA_STP.Open(); // Change

                //    if (str_number == "IV")
                //    {
                //        SQLQuery = "SELECT TOP 1 s.* ," +
                //            " CASE " +
                //            " WHEN s.evcode != '' THEN RTRIM(s.evname) + ' ' + RTRIM(s.evadd) + ' ' + RTRIM(s.evtel)" +
                //           " WHEN s.emlocation != '' THEN RTRIM(s.emlocation)" +
                //           " ELSE ISNULL(NULLIF(RTRIM( CONCAT( RTRIM(e.eaddress),' ',RTRIM(e.etumbol),' ',RTRIM(e.eamphur),' ',RTRIM(e.eprovinc) , ' ' , RTRIM(e.ezip)  ) ),' '), '87/18-21 หมู่ 13 ถนนสุวินทวงศ์ แขวง มีนบุรี เขต มีนบุรี กรุงเทพมหานคร 10510')" +
                //           " END AS 'e_delivery_address'" +
                //           " ,RTRIM( CONCAT( RTRIM(e.eaddress),' ',RTRIM(e.etumbol),' ',RTRIM(e.eamphur),' ',RTRIM(e.eprovinc) , ' ' , RTRIM(e.ezip) ) ) AS emmas_addres" +
                //           " FROM salefile s" +
                //           " LEFT JOIN emmas e ON RTRIM(s.invcode) = RTRIM(e.code)" +
                //           " WHERE RTRIM(s.number) = '" + number + "' ";
                //    }
                //    else if (str_number == "RD")
                //    {
                //        SQLQuery = "SELECT TOP 1 s.* ," +
                //           " CASE " +
                //           " WHEN s.evcode != '' THEN RTRIM(s.evname) + ' ' + RTRIM(s.evadd) + ' ' + RTRIM(s.evtel)" +
                //           " WHEN s.emlocation != '' THEN RTRIM(s.emlocation)" +
                //           " ELSE ISNULL(NULLIF(RTRIM( CONCAT( RTRIM(e.eaddress),' ',RTRIM(e.etumbol),' ',RTRIM(e.eamphur),' ',RTRIM(e.eprovinc) , ' ' , RTRIM(e.ezip) ) ),' '), '87/18-21 หมู่ 13 ถนนสุวินทวงศ์ แขวง มีนบุรี เขต มีนบุรี กรุงเทพมหานคร 10510')" +
                //           " END AS 'e_delivery_address'" +
                //           " ,RTRIM( CONCAT( RTRIM(e.eaddress),' ',RTRIM(e.etumbol),' ',RTRIM(e.eamphur),' ',RTRIM(e.eprovinc) , ' ' , RTRIM(e.ezip) ) ) AS emmas_addres" +
                //           " FROM rdfile s" +
                //           " WHERE RTRIM(s.number) = '" + number + "' ";
                //    }
                //    else
                //    {
                //        SQLQuery = "SELECT TOP 1 s.* ," +
                //           " CASE " +
                //           " WHEN s.evcode != '' THEN RTRIM(s.evname) + ' ' + RTRIM(s.evadd) + ' ' + RTRIM(s.evtel)" +
                //           " WHEN s.emlocation != '' THEN RTRIM(s.emlocation)" +
                //           " ELSE ISNULL(NULLIF(RTRIM( CONCAT( RTRIM(e.eaddress),' ',RTRIM(e.etumbol),' ',RTRIM(e.eamphur),' ',RTRIM(e.eprovinc) , ' ' , RTRIM(e.ezip) ) ),' '), '87/18-21 หมู่ 13 ถนนสุวินทวงศ์ แขวง มีนบุรี เขต มีนบุรี กรุงเทพมหานคร 10510')" +
                //           " END AS 'e_delivery_address'" +
                //           " ,RTRIM( CONCAT( RTRIM(e.eaddress),' ',RTRIM(e.etumbol),' ',RTRIM(e.eamphur),' ',RTRIM(e.eprovinc) , ' ' , RTRIM(e.ezip) ) ) AS emmas_addres" +
                //           " FROM salefile s" +
                //           " WHERE RTRIM(s.number) = '" + number + "' ";
                //    }

                //    _ResponseData = VSK_CA_STP.Query<SalefileModel>(SQLQuery).ToList(); // Change
                //    VSK_CA_STP.Close(); // Change
                //    return _ResponseData.ToList();
                //}
                // End New Branch
                else
                {
                    VSK_ACC.Open();

                    if (str_number == "IV")
                    {
                        SQLQuery = "SELECT TOP 1 s.* ," +
                            " CASE " +
                            " WHEN s.evcode != '' THEN RTRIM(s.evname) + ' ' + RTRIM(s.evadd) + ' ' + RTRIM(s.evtel)" +
                           " WHEN s.emlocation != '' THEN RTRIM(s.emlocation)" +
                           " ELSE ISNULL(NULLIF(RTRIM( CONCAT( RTRIM(e.eaddress),' ',RTRIM(e.etumbol),' ',RTRIM(e.eamphur),' ',RTRIM(e.eprovinc) , ' ' , RTRIM(e.ezip)  ) ),' '), '87/18-21 หมู่ 13 ถนนสุวินทวงศ์ แขวง มีนบุรี เขต มีนบุรี กรุงเทพมหานคร 10510')" +
                           " END AS 'e_delivery_address'" +
                           " ,RTRIM( CONCAT( RTRIM(e.eaddress),' ',RTRIM(e.etumbol),' ',RTRIM(e.eamphur),' ',RTRIM(e.eprovinc) , ' ' , RTRIM(e.ezip) ) ) AS emmas_addres" +
                           " FROM salefile s" +
                           " LEFT JOIN emmas e ON RTRIM(s.invcode) = RTRIM(e.code)" +
                           " WHERE RTRIM(s.number) = '" + number + "' ";
                    }
                    else if (str_number == "RD")
                    {
                        SQLQuery = "SELECT TOP 1 s.* ," +
                           " CASE " +
                           " WHEN s.evcode != '' THEN RTRIM(s.evname) + ' ' + RTRIM(s.evadd) + ' ' + RTRIM(s.evtel)" +
                           " WHEN s.emlocation != '' THEN RTRIM(s.emlocation)" +
                           " ELSE ISNULL(NULLIF(RTRIM( CONCAT( RTRIM(e.eaddress),' ',RTRIM(e.etumbol),' ',RTRIM(e.eamphur),' ',RTRIM(e.eprovinc) , ' ' , RTRIM(e.ezip) ) ),' '), '87/18-21 หมู่ 13 ถนนสุวินทวงศ์ แขวง มีนบุรี เขต มีนบุรี กรุงเทพมหานคร 10510')" +
                           " END AS 'e_delivery_address'" +
                           " ,RTRIM( CONCAT( RTRIM(e.eaddress),' ',RTRIM(e.etumbol),' ',RTRIM(e.eamphur),' ',RTRIM(e.eprovinc) , ' ' , RTRIM(e.ezip) ) ) AS emmas_addres" +
                           " FROM rdfile s" +
                           " WHERE RTRIM(s.number) = '" + number + "' ";
                    }
                    else
                    {
                        SQLQuery = "SELECT TOP 1 s.* ," +
                           " CASE " +
                           " WHEN s.evcode != '' THEN RTRIM(s.evname) + ' ' + RTRIM(s.evadd) + ' ' + RTRIM(s.evtel)" +
                           " WHEN s.emlocation != '' THEN RTRIM(s.emlocation)" +
                           " ELSE ISNULL(NULLIF(RTRIM( CONCAT( RTRIM(e.eaddress),' ',RTRIM(e.etumbol),' ',RTRIM(e.eamphur),' ',RTRIM(e.eprovinc) , ' ' , RTRIM(e.ezip) ) ),' '), '87/18-21 หมู่ 13 ถนนสุวินทวงศ์ แขวง มีนบุรี เขต มีนบุรี กรุงเทพมหานคร 10510')" +
                           " END AS 'e_delivery_address'" +
                           " ,RTRIM( CONCAT( RTRIM(e.eaddress),' ',RTRIM(e.etumbol),' ',RTRIM(e.eamphur),' ',RTRIM(e.eprovinc) , ' ' , RTRIM(e.ezip) ) ) AS emmas_addres" +
                           " FROM salefile s" +
                           " WHERE RTRIM(s.number) = '" + number + "' ";
                    }

                    _ResponseData = VSK_ACC.Query<SalefileModel>(SQLQuery).ToList();
                    VSK_ACC.Close();
                    return _ResponseData.ToList();
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public List<SalefileModel> TRP_INVCFILE_BRANCH_GET(string branch, string number)
        {
            try
            {
                Connection();

                List<SalefileModel> _ResponseData;

                string SQLQuery = "";
                string str_number = number.Substring(0, 3);

                if (branch == "VSK")
                {
                    VSK_CA_VSM.Open();

                    SQLQuery = "SELECT TOP 1 invcfile.* " +
                               " FROM invcfile invcfile" +
                               " WHERE RTRIM(invcfile.number) = '" + number + "' ";

                    _ResponseData = VSK_CA_VSM.Query<SalefileModel>(SQLQuery).ToList();
                    VSK_CA_VSM.Close();
                    return _ResponseData.ToList();
                }
                else if (branch == "VSF")
                {
                    VSK_CA_VSF.Open();

                    SQLQuery = "SELECT TOP 1 invcfile.* " +
                               " FROM invcfile invcfile" +
                               " WHERE RTRIM(invcfile.number) = '" + number + "' ";

                    _ResponseData = VSK_CA_VSF.Query<SalefileModel>(SQLQuery).ToList();
                    VSK_CA_VSF.Close();
                    return _ResponseData.ToList();
                }
                else if (branch == "KLH")
                {
                    VSK_CA_KLH.Open();

                    SQLQuery = "SELECT TOP 1 invcfile.* " +
                               " FROM invcfile invcfile" +
                               " WHERE RTRIM(invcfile.number) = '" + number + "' ";

                    _ResponseData = VSK_CA_KLH.Query<SalefileModel>(SQLQuery).ToList();
                    VSK_CA_KLH.Close();
                    return _ResponseData.ToList();
                }
                else if (branch == "LLK")
                {
                    VSK_CA_LLK.Open();

                    SQLQuery = "SELECT TOP 1 invcfile.* " +
                               " FROM invcfile invcfile" +
                               " WHERE RTRIM(invcfile.number) = '" + number + "' ";

                    _ResponseData = VSK_CA_LLK.Query<SalefileModel>(SQLQuery).ToList();
                    VSK_CA_LLK.Close();
                    return _ResponseData.ToList();
                }
                else if (branch == "NWM")
                {
                    VSK_CA_NWM.Open();

                    SQLQuery = "SELECT TOP 1 invcfile.* " +
                               " FROM invcfile invcfile" +
                               " WHERE RTRIM(invcfile.number) = '" + number + "' ";

                    _ResponseData = VSK_CA_NWM.Query<SalefileModel>(SQLQuery).ToList();
                    VSK_CA_NWM.Close();
                    return _ResponseData.ToList();
                }
                else if (branch == "LKS")
                {
                    VSK_CA_LKS.Open();

                    SQLQuery = "SELECT TOP 1 invcfile.* " +
                               " FROM invcfile invcfile" +
                               " WHERE RTRIM(invcfile.number) = '" + number + "' ";

                    _ResponseData = VSK_CA_LKS.Query<SalefileModel>(SQLQuery).ToList();
                    VSK_CA_LKS.Close();
                    return _ResponseData.ToList();
                }
                else if (branch == "SNK")
                {
                    VSK_CA_SNK.Open();

                    SQLQuery = "SELECT TOP 1 invcfile.* " +
                               " FROM invcfile invcfile" +
                               " WHERE RTRIM(invcfile.number) = '" + number + "' ";

                    _ResponseData = VSK_CA_SNK.Query<SalefileModel>(SQLQuery).ToList();
                    VSK_CA_SNK.Close();
                    return _ResponseData.ToList();
                }
                else
                {
                    VSK_ACC.Open();

                    SQLQuery = "SELECT TOP 1 invcfile.* " +
                               " FROM invcfile invcfile" +
                               " WHERE RTRIM(invcfile.number) = '" + number + "' ";

                    _ResponseData = VSK_ACC.Query<SalefileModel>(SQLQuery).ToList();
                    VSK_ACC.Close();
                    return _ResponseData.ToList();
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public List<APmasModel> TRP_APMAS_GET(string number)
        {
            try
            {
                string SQLQuery = "SELECT * FROM apmas WHERE (('" + number + "' IS NULL OR '" + number + "' = '' ) OR RTRIM(code) = '" + number + "') ";
                Connection();
                VSK_CA_VSM.Open();
                List<APmasModel> _ResponseData = VSK_CA_VSM.Query<APmasModel>(SQLQuery).ToList();
                VSK_CA_VSM.Close();
                return _ResponseData.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public List<BRModel> TRP_BR_GET(string number)
        {
            try
            {
                string SQLQuery = "SELECT * FROM brfile WHERE RTRIM(number) = '" + number + "' ";
                Connection();
                VSK_CA_VSM.Open();
                List<BRModel> _ResponseData = VSK_CA_VSM.Query<BRModel>(SQLQuery).ToList();
                VSK_CA_VSM.Close();
                return _ResponseData.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public List<CnReqModel> TMS_CN_REQ_GET(CnReqModel CnReqModel)
        {
            try
            {
                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@cn_req_job_jobno", CnReqModel.cn_req_job_jobno);

                Connection();
                VSK_TMS.Open();
                List<CnReqModel> DATA_LIST = SqlMapper.Query<CnReqModel>(VSK_TMS, "SP_TMS_CN_REQ_GET", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();
                VSK_TMS.Close();

                return DATA_LIST.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //public List<TMS_JOB_ITEMModel> TRP_JOB_CN_GET(string number)
        //{
        //    try
        //    {
        //        string SQLQuery = "SELECT c.* FROM cn_pre_job c WHERE c.record_status = 1 AND c.cn_pre_job_assige = 'TRP' AND c.cn_pre_job_jobno =  '" + number + "'";
        //        Connection();
        //        VSK_CN.Open();
        //        List<TMS_JOB_ITEMModel> _ResponseData = VSK_CN.Query<TMS_JOB_ITEMModel>(SQLQuery).ToList();
        //        VSK_CN.Close();
        //        return _ResponseData.ToList();
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }

        //}

        public List<TMS_JOB_ITEMModel> TMS_JOB_MO_ADD(TMS_JOB_ITEMModel TMS_JOB_ITEMModel)
        {
            try
            {
                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@job_date", TMS_JOB_ITEMModel.job_date);
                objParam.Add("@job_invoice_no", TMS_JOB_ITEMModel.job_invoice_no);
                objParam.Add("@job_invoice_date", TMS_JOB_ITEMModel.job_invoice_date);
                objParam.Add("@job_pk_no", TMS_JOB_ITEMModel.job_pk_no);
                objParam.Add("@job_qty", TMS_JOB_ITEMModel.job_qty);
                objParam.Add("@invnet", TMS_JOB_ITEMModel.invnet);
                objParam.Add("@invcode", TMS_JOB_ITEMModel.invcode);
                objParam.Add("@job_delivery_name", TMS_JOB_ITEMModel.job_delivery_name);
                objParam.Add("@job_delivery_addr", TMS_JOB_ITEMModel.job_delivery_addr);
                objParam.Add("@job_emmas_addres", TMS_JOB_ITEMModel.job_emmas_addres);
                objParam.Add("@route_no", TMS_JOB_ITEMModel.route_no);
                objParam.Add("@route_name", TMS_JOB_ITEMModel.route_name);
                objParam.Add("@HHID", TMS_JOB_ITEMModel.HHID);
                objParam.Add("@driver_id", TMS_JOB_ITEMModel.driver_id);
                objParam.Add("@driver_fullname", TMS_JOB_ITEMModel.driver_fullname);
                objParam.Add("@job_status", TMS_JOB_ITEMModel.job_status);
                objParam.Add("@job_plate", TMS_JOB_ITEMModel.job_plate);
                objParam.Add("@plate_name", TMS_JOB_ITEMModel.plate_name);
                objParam.Add("@cod_price", TMS_JOB_ITEMModel.cod_price);
                objParam.Add("@delivery_type", TMS_JOB_ITEMModel.delivery_type);
                objParam.Add("@batch_no", TMS_JOB_ITEMModel.batch_no);
                objParam.Add("@ref_id", TMS_JOB_ITEMModel.ref_id);
                objParam.Add("@created_by", TMS_JOB_ITEMModel.created_by);
                objParam.Add("@inv_description", TMS_JOB_ITEMModel.inv_description);
                objParam.Add("@location_branch", TMS_JOB_ITEMModel.location_branch);

                Connection();
                VSK_TMS.Open();
                List<TMS_JOB_ITEMModel> TRP_TMS_JOB_EXPRESS_LIST = SqlMapper.Query<TMS_JOB_ITEMModel>(VSK_TMS, "SP_TMS_JOB_MO_ADD", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();
                VSK_TMS.Close();

                return TRP_TMS_JOB_EXPRESS_LIST.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<TMS_JOB_ITEMModel> TMS_JOB_MO_UPDATE(TMS_JOB_ITEMModel TMS_JOB_ITEMModel)
        {
            try
            {
                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@mode", TMS_JOB_ITEMModel.mode);
                objParam.Add("@ref_id", TMS_JOB_ITEMModel.ref_id);
                objParam.Add("@updated_by", TMS_JOB_ITEMModel.updated_by);

                Connection();
                VSK_TMS.Open();
                List<TMS_JOB_ITEMModel> TRP_TMS_JOB_EXPRESS_LIST = SqlMapper.Query<TMS_JOB_ITEMModel>(VSK_TMS, "SP_TMS_JOB_MO_UPDATE", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();
                VSK_TMS.Close();

                return TRP_TMS_JOB_EXPRESS_LIST.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<TMS_JOB_ITEMModel> TMS_JOB_MO_CHECK(TMS_JOB_ITEMModel TMS_JOB_ITEMModel)
        {
            try
            {
                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@job_date", TMS_JOB_ITEMModel.job_date);
                objParam.Add("@job_invoice_no", TMS_JOB_ITEMModel.job_invoice_no);
                objParam.Add("@job_pk_no", TMS_JOB_ITEMModel.job_pk_no);
                objParam.Add("@route_no", TMS_JOB_ITEMModel.route_no);
                objParam.Add("@driver_id", TMS_JOB_ITEMModel.driver_id);
                objParam.Add("@ref_id", TMS_JOB_ITEMModel.ref_id);

                Connection();
                VSK_TMS.Open();
                List<TMS_JOB_ITEMModel> TRP_TMS_JOB_EXPRESS_LIST = SqlMapper.Query<TMS_JOB_ITEMModel>(VSK_TMS, "SP_TMS_JOB_MO_CHECK", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();
                VSK_TMS.Close();

                return TRP_TMS_JOB_EXPRESS_LIST.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<TMS_JOB_ITEMModel> TMS_JOB_MO_LIST(TMS_JOB_ITEMModel TMS_JOB_ITEMModel)
        {
            try
            {
                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@job_date", TMS_JOB_ITEMModel.job_date);
                objParam.Add("@invcode", TMS_JOB_ITEMModel.invcode);
                objParam.Add("@derivery_status", TMS_JOB_ITEMModel.derivery_status);
                objParam.Add("@driver_id", TMS_JOB_ITEMModel.driver_id);
                Connection();
                VSK_TMS.Open();
                List<TMS_JOB_ITEMModel> TRP_TMS_JOB_EXPRESS_LIST = SqlMapper.Query<TMS_JOB_ITEMModel>(VSK_TMS, "SP_TMS_JOB_MO_LIST", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();
                VSK_TMS.Close();

                return TRP_TMS_JOB_EXPRESS_LIST.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<TMS_JOB_ITEMModel> TMS_JOB_MO_DRIVER_DASHBOARD(TMS_JOB_ITEMModel TMS_JOB_ITEMModel)
        {
            try
            {
                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@job_date", TMS_JOB_ITEMModel.job_date);
                objParam.Add("@mode", TMS_JOB_ITEMModel.mode);
                objParam.Add("@ref_id", TMS_JOB_ITEMModel.ref_id);

                Connection();
                VSK_TMS.Open();
                List<TMS_JOB_ITEMModel> TRP_TMS_JOB_EXPRESS_LIST = SqlMapper.Query<TMS_JOB_ITEMModel>(VSK_TMS, "SP_TMS_JOB_MO_DRIVER_DASHBOARD", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();
                VSK_TMS.Close();

                return TRP_TMS_JOB_EXPRESS_LIST.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<TMS_JOB_ITEMModel> TMS_JOB_MO_DRIVER_TIME_LIST(TMS_JOB_ITEMModel TMS_JOB_ITEMModel)
        {
            try
            {
                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@job_date", TMS_JOB_ITEMModel.job_date);
                objParam.Add("@mode", TMS_JOB_ITEMModel.mode);
                objParam.Add("@ref_id", TMS_JOB_ITEMModel.ref_id);
                objParam.Add("@driver_id", TMS_JOB_ITEMModel.driver_id);
                objParam.Add("@derivery_status", TMS_JOB_ITEMModel.derivery_status);

                Connection();
                VSK_TMS.Open();
                List<TMS_JOB_ITEMModel> TRP_TMS_JOB_EXPRESS_LIST = SqlMapper.Query<TMS_JOB_ITEMModel>(VSK_TMS, "SP_TMS_JOB_MO_DRIVER_TIME_LIST", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();
                VSK_TMS.Close();

                return TRP_TMS_JOB_EXPRESS_LIST.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<TMS_JOB_ITEMModel> TMS_JOB_MO_DRIVER_TIME_DETAIL(TMS_JOB_ITEMModel TMS_JOB_ITEMModel)
        {
            try
            {
                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@job_date", TMS_JOB_ITEMModel.job_date);
                objParam.Add("@driver_id", TMS_JOB_ITEMModel.driver_id);
                objParam.Add("@ref_id", TMS_JOB_ITEMModel.ref_id);

                Connection();
                VSK_TMS.Open();
                List<TMS_JOB_ITEMModel> TRP_TMS_JOB_EXPRESS_LIST = SqlMapper.Query<TMS_JOB_ITEMModel>(VSK_TMS, "SP_TMS_JOB_MO_DRIVER_TIME_DETAIL", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();
                VSK_TMS.Close();

                return TRP_TMS_JOB_EXPRESS_LIST.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void TMS_JOB_TR_ADD(List<TMS_JOB_ITEMModel> TMS_JOB_ITEMModel)
        {

            try
            {

                Connection();

                VSK_TMS.Open();

                foreach (var ImportDataArrayData in TMS_JOB_ITEMModel)
                {
                    DynamicParameters objParam = new DynamicParameters();


                    objParam.Add("@job_date", ImportDataArrayData.job_date);
                    objParam.Add("@job_invoice_no", ImportDataArrayData.job_invoice_no);
                    objParam.Add("@job_invoice_date", ImportDataArrayData.job_invoice_date);
                    objParam.Add("@job_pk_no", ImportDataArrayData.job_pk_no);
                    objParam.Add("@job_qty", ImportDataArrayData.job_qty);
                    objParam.Add("@invnet", ImportDataArrayData.invnet);
                    objParam.Add("@invcode", ImportDataArrayData.invcode);
                    objParam.Add("@job_delivery_name", ImportDataArrayData.job_delivery_name);
                    objParam.Add("@job_delivery_addr", ImportDataArrayData.job_delivery_addr);
                    objParam.Add("@job_emmas_addres", ImportDataArrayData.job_emmas_addres);
                    objParam.Add("@route_no", ImportDataArrayData.route_no);
                    objParam.Add("@route_name", ImportDataArrayData.route_name);
                    objParam.Add("@HHID", ImportDataArrayData.HHID);
                    objParam.Add("@driver_id", ImportDataArrayData.driver_id);
                    objParam.Add("@driver_fullname", ImportDataArrayData.driver_fullname);
                    objParam.Add("@job_status", ImportDataArrayData.job_status);
                    objParam.Add("@job_plate", ImportDataArrayData.job_plate);
                    objParam.Add("@plate_name", ImportDataArrayData.plate_name);
                    objParam.Add("@cod_price", ImportDataArrayData.cod_price);
                    objParam.Add("@delivery_type", ImportDataArrayData.delivery_type);
                    objParam.Add("@batch_no", ImportDataArrayData.batch_no);
                    objParam.Add("@ref_id", ImportDataArrayData.ref_id);
                    objParam.Add("@created_by", ImportDataArrayData.created_by);
                    objParam.Add("@inv_description", ImportDataArrayData.inv_description);
                    objParam.Add("@location_branch", ImportDataArrayData.location_branch);


                    VSK_TMS.Execute("SP_TMS_JOB_TR_ADD", objParam, commandTimeout: 600, commandType: CommandType.StoredProcedure);

                }

                VSK_TMS.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<TMS_JOB_ITEMModel> TMS_JOB_TR_JOBNO_GET(TMS_JOB_ITEMModel TMS_JOB_ITEMModel)
        {
            try
            {
                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@mode", TMS_JOB_ITEMModel.mode);
                objParam.Add("@ref_id", TMS_JOB_ITEMModel.ref_id);

                Connection();
                VSK_TMS.Open();
                List<TMS_JOB_ITEMModel> TRP_TMS_JOB_EXPRESS_LIST = SqlMapper.Query<TMS_JOB_ITEMModel>(VSK_TMS, "SP_TMS_JOB_TR_JOBNO_GET", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();
                VSK_TMS.Close();

                return TRP_TMS_JOB_EXPRESS_LIST.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<TMS_JOB_ITEMModel> TMS_JOB_DELIVERY_DAILY_LIST(TMS_JOB_ITEMModel TMS_JOB_ITEMModel)
        {
            try
            {
                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@mode", TMS_JOB_ITEMModel.mode);
                objParam.Add("@job_start_date", TMS_JOB_ITEMModel.job_start_date);
                objParam.Add("@job_end_date", TMS_JOB_ITEMModel.job_end_date);
                objParam.Add("@route_no", TMS_JOB_ITEMModel.route_no);
                objParam.Add("@driver_id", TMS_JOB_ITEMModel.driver_id);
                objParam.Add("@job_plate", TMS_JOB_ITEMModel.job_plate);
                objParam.Add("@job_no", TMS_JOB_ITEMModel.job_no);
                objParam.Add("@job_number", TMS_JOB_ITEMModel.job_number);
                objParam.Add("@delivery_type", TMS_JOB_ITEMModel.delivery_type);
                objParam.Add("@payment_type", TMS_JOB_ITEMModel.payment_type);
                objParam.Add("@location_branch", TMS_JOB_ITEMModel.location_branch);
                objParam.Add("@ref_id", TMS_JOB_ITEMModel.ref_id);

                Connection();
                VSK_TMS.Open();
                List<TMS_JOB_ITEMModel> TMS_Job_Item_List = SqlMapper.Query<TMS_JOB_ITEMModel>(VSK_TMS, "SP_TMS_JOB_DELIVERY_DAILY_LIST", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();

                VSK_TMS.Close();
                return TMS_Job_Item_List.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public List<TMS_JOB_ITEMModel> TMS_JOB_ROUTE_LIST(TMS_JOB_ITEMModel TMS_JOB_ITEMModel)
        {
            try
            {
                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@job_start_date", TMS_JOB_ITEMModel.job_start_date);
                objParam.Add("@job_end_date", TMS_JOB_ITEMModel.job_end_date);
                objParam.Add("@route_no", TMS_JOB_ITEMModel.route_no);
                objParam.Add("@driver_id", TMS_JOB_ITEMModel.driver_id);
                objParam.Add("@job_plate", TMS_JOB_ITEMModel.job_plate);
                objParam.Add("@location_branch", TMS_JOB_ITEMModel.location_branch);

                Connection();
                VSK_TMS.Open();
                List<TMS_JOB_ITEMModel> TMS_Job_Item_List = SqlMapper.Query<TMS_JOB_ITEMModel>(VSK_TMS, "SP_TMS_JOB_ROUTE_LIST", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();

                VSK_TMS.Close();
                return TMS_Job_Item_List.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }


        public void TRP_TMS_JOB_Add(List<TMS_JOB_ITEMModel> TMS_JOB_ITEMModel)
        {

            try
            {

                Connection();
                VSK_TMS.Open();

                foreach (var ImportDataArrayData in TMS_JOB_ITEMModel)
                {
                    DynamicParameters objParam = new DynamicParameters();

                    objParam.Add("@tran_id", ImportDataArrayData.tran_id);
                    objParam.Add("@job_date", ImportDataArrayData.job_date);
                    objParam.Add("@job_invoice_no", ImportDataArrayData.job_invoice_no);
                    objParam.Add("@job_invoice_date", ImportDataArrayData.job_invoice_date);
                    objParam.Add("@job_pk_no", ImportDataArrayData.job_pk_no);
                    objParam.Add("@job_qty", ImportDataArrayData.job_qty);
                    objParam.Add("@invnet", ImportDataArrayData.invnet);
                    objParam.Add("@invcode", ImportDataArrayData.invcode);
                    objParam.Add("@job_delivery_name", ImportDataArrayData.job_delivery_name);
                    objParam.Add("@job_delivery_addr", ImportDataArrayData.job_delivery_addr);
                    objParam.Add("@route_no", ImportDataArrayData.route_no);
                    objParam.Add("@route_name", ImportDataArrayData.route_name);
                    objParam.Add("@driver_id", ImportDataArrayData.driver_id);
                    objParam.Add("@driver_fullname", ImportDataArrayData.driver_fullname);
                    objParam.Add("@job_plate", ImportDataArrayData.job_plate);
                    objParam.Add("@plate_name", ImportDataArrayData.plate_name);
                    objParam.Add("@created_by", ImportDataArrayData.created_by);
                    objParam.Add("@ref_id", ImportDataArrayData.ref_id);
                    objParam.Add("@delivery_type", ImportDataArrayData.delivery_type);
                    objParam.Add("@delivery_status", ImportDataArrayData.delivery_status);
                    objParam.Add("@cod_price", ImportDataArrayData.cod_price);
                    objParam.Add("@created_timestamp", ImportDataArrayData.created_timestamp);
                    objParam.Add("@batch_no", ImportDataArrayData.batch_no);

                    VSK_TMS.Execute("SP_TMS_Job_Item_Add", objParam, commandTimeout: 600, commandType: CommandType.StoredProcedure);

                }

                VSK_TMS.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void TRP_TMS_JOB_Upload_Add(TMS_JOB_ITEMModel TMS_JOB_ITEMModel)
        {
            try
            {
                DynamicParameters objParam = new DynamicParameters();
                objParam.Add("@ref_id", TMS_JOB_ITEMModel.ref_id);

                Connection();
                VSK_TMS.Open();
                VSK_TMS.Execute("SP_TMS_Job_Item_Upload_Add", objParam, commandType: CommandType.StoredProcedure);
                VSK_TMS.Close();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<TMSModelClose> TRP_TMS_JOB_Close(TMSModelClose TMSModelClose)
        {
            try
            {
                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@job_no", TMSModelClose.job_no);
                objParam.Add("@job_invoice_no", TMSModelClose.job_invoice_no);
                objParam.Add("@description", TMSModelClose.description);
                objParam.Add("@created_by", TMSModelClose.created_by);

                Connection();
                VSK_TMS.Open();
                List<TMSModelClose> TRP_TMS_JOB_EXPRESS_LIST = SqlMapper.Query<TMSModelClose>(VSK_TMS, "SP_TMS_Job_Item_Close", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();
                VSK_TMS.Close();

                return TRP_TMS_JOB_EXPRESS_LIST.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<TMS_JOB_ITEMModel> TRP_TMS_JOB_EXPRESS_Check(TMS_JOB_ITEMModel TMS_JOB_ITEMModel)
        {
            try
            {
                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@job_date", TMS_JOB_ITEMModel.job_date);
                objParam.Add("@job_invoice_no", TMS_JOB_ITEMModel.job_invoice_no);
                objParam.Add("@job_pk_no", TMS_JOB_ITEMModel.job_pk_no);
                objParam.Add("@route_no", TMS_JOB_ITEMModel.route_no);
                objParam.Add("@driver_id", TMS_JOB_ITEMModel.driver_id);
                objParam.Add("@job_plate", TMS_JOB_ITEMModel.job_plate);

                Connection();
                VSK_TMS.Open();
                List<TMS_JOB_ITEMModel> TRP_TMS_JOB_EXPRESS_LIST = SqlMapper.Query<TMS_JOB_ITEMModel>(VSK_TMS, "SP_TMS_Job_Express_Item_Check", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();
                VSK_TMS.Close();

                return TRP_TMS_JOB_EXPRESS_LIST.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<TMS_JOB_EXPORTModel> TRP_TMS_JOB_EXPRESS_Add(TMS_JOB_ITEMModel TMS_JOB_ITEMModel)
        {
            try
            {
                DynamicParameters objParam = new DynamicParameters();
                objParam.Add("@ref_id", TMS_JOB_ITEMModel.ref_id);
                objParam.Add("@job_date", TMS_JOB_ITEMModel.job_date);
                objParam.Add("@job_status", TMS_JOB_ITEMModel.job_status);
                objParam.Add("@job_invoice_no", TMS_JOB_ITEMModel.job_invoice_no);
                objParam.Add("@job_invoice_date", TMS_JOB_ITEMModel.job_invoice_date);
                objParam.Add("@job_pk_no", TMS_JOB_ITEMModel.job_pk_no);
                objParam.Add("@job_qty", TMS_JOB_ITEMModel.job_qty);
                objParam.Add("@invnet", TMS_JOB_ITEMModel.invnet);
                objParam.Add("@invcode", TMS_JOB_ITEMModel.invcode);
                objParam.Add("@job_delivery_name", TMS_JOB_ITEMModel.job_delivery_name);
                objParam.Add("@job_delivery_addr", TMS_JOB_ITEMModel.job_delivery_addr);
                objParam.Add("@route_no", TMS_JOB_ITEMModel.route_no);
                objParam.Add("@route_name", TMS_JOB_ITEMModel.route_name);
                objParam.Add("@driver_id", TMS_JOB_ITEMModel.driver_id);
                objParam.Add("@driver_fullname", TMS_JOB_ITEMModel.driver_fullname);
                objParam.Add("@job_plate", TMS_JOB_ITEMModel.job_plate);
                objParam.Add("@plate_name", TMS_JOB_ITEMModel.plate_name);
                objParam.Add("@created_by", TMS_JOB_ITEMModel.created_by);
                objParam.Add("@cod_price", TMS_JOB_ITEMModel.cod_price);
                objParam.Add("@delivery_type", TMS_JOB_ITEMModel.delivery_type);
                objParam.Add("@location_branch", TMS_JOB_ITEMModel.location_branch);

                Connection();
                VSK_TMS.Open();
                List<TMS_JOB_EXPORTModel> TRP_TMS_JOB_EXPRESS_LIST = SqlMapper.Query<TMS_JOB_EXPORTModel>(VSK_TMS, "SP_TMS_Job_Express_Item_Add", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();
                VSK_TMS.Close();

                return TRP_TMS_JOB_EXPRESS_LIST.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<TMS_JOB_ITEMModel> TMS_Job_Item_Get(TMS_JOB_ITEMModel TMS_JOB_ITEMModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@ref_id", TMS_JOB_ITEMModel.ref_id);

                Connection();
                VSK_TMS.Open();
                List<TMS_JOB_ITEMModel> TMS_JOB_ITEMList = SqlMapper.Query<TMS_JOB_ITEMModel>(VSK_TMS, "SP_TMS_Job_Item_Get", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();

                VSK_TMS.Close();
                return TMS_JOB_ITEMList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<TMS_JOB_ITEMModel> TMS_Job_Item_List(TMS_JOB_ITEMModel TMS_JOB_ITEMModel)
        {
            try
            {
                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@job_date", TMS_JOB_ITEMModel.job_date);
                objParam.Add("@route_no", TMS_JOB_ITEMModel.route_no);
                objParam.Add("@driver_id", TMS_JOB_ITEMModel.driver_id);
                objParam.Add("@job_plate", TMS_JOB_ITEMModel.job_plate);
                objParam.Add("@ref_id", TMS_JOB_ITEMModel.ref_id);

                Connection();
                VSK_TMS.Open();
                List<TMS_JOB_ITEMModel> TMS_Job_Item_List = SqlMapper.Query<TMS_JOB_ITEMModel>(VSK_TMS, "SP_TMS_Job_Item_List", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();

                VSK_TMS.Close();
                return TMS_Job_Item_List.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public List<TMS_JOB_ITEMModel> TMS_Job_Express_Item_List(TMS_JOB_ITEMModel TMS_JOB_ITEMModel)
        {
            try
            {
                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@job_date", TMS_JOB_ITEMModel.job_date);

                Connection();
                VSK_TMS.Open();
                List<TMS_JOB_ITEMModel> TMS_Job_Item_List = SqlMapper.Query<TMS_JOB_ITEMModel>(VSK_TMS, "SP_TMS_Job_Express_Item_List", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();

                VSK_TMS.Close();
                return TMS_Job_Item_List.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public List<TMS_JOB_ITEMModel> TMS_Job_Route_Search(TMS_JOB_ITEMModel TMS_JOB_ITEMModel)
        {
            try
            {
                DynamicParameters objParam = new DynamicParameters();


                // objParam.Add("@job_start_date", TMS_JOB_ITEMModel.job_start_date == DateTime.MinValue ? null : TMS_JOB_ITEMModel.job_start_date.ToString());
                // objParam.Add("@job_end_date", TMS_JOB_ITEMModel.job_end_date == DateTime.MinValue ? null : TMS_JOB_ITEMModel.job_end_date.ToString());

                objParam.Add("@job_start_date", TMS_JOB_ITEMModel.job_start_date);
                objParam.Add("@job_end_date", TMS_JOB_ITEMModel.job_end_date);
                objParam.Add("@route_no", TMS_JOB_ITEMModel.route_no);
                objParam.Add("@driver_id", TMS_JOB_ITEMModel.driver_id);
                objParam.Add("@job_plate", TMS_JOB_ITEMModel.job_plate);
                objParam.Add("@mode", TMS_JOB_ITEMModel.mode);

                Connection();
                VSK_TMS.Open();
                List<TMS_JOB_ITEMModel> TMS_Job_Route_Search = SqlMapper.Query<TMS_JOB_ITEMModel>(VSK_TMS, "SP_TMS_Job_Route_Search", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();

                VSK_TMS.Close();
                return TMS_Job_Route_Search.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public List<TMS_JOB_ITEMModel> TMS_Job_Search(TMS_JOB_ITEMModel TMS_JOB_ITEMModel)
        {
            try
            {
                DynamicParameters objParam = new DynamicParameters();


                //objParam.Add("@job_start_date", TMS_JOB_ITEMModel.job_start_date == DateTime.MinValue ? null : TMS_JOB_ITEMModel.job_start_date.ToString());
                //objParam.Add("@job_end_date", TMS_JOB_ITEMModel.job_end_date == DateTime.MinValue ? null : TMS_JOB_ITEMModel.job_end_date.ToString());

                objParam.Add("@job_start_date", TMS_JOB_ITEMModel.job_start_date);
                objParam.Add("@job_end_date", TMS_JOB_ITEMModel.job_end_date);
                objParam.Add("@route_no", TMS_JOB_ITEMModel.route_no);
                objParam.Add("@driver_id", TMS_JOB_ITEMModel.driver_id);
                objParam.Add("@job_plate", TMS_JOB_ITEMModel.job_plate);
                objParam.Add("@payment_type", TMS_JOB_ITEMModel.payment_type);
                objParam.Add("@delivery_type", TMS_JOB_ITEMModel.delivery_type);
                objParam.Add("@mode", TMS_JOB_ITEMModel.mode);

                Connection();
                VSK_TMS.Open();
                List<TMS_JOB_ITEMModel> SP_TMS_Job_Search = SqlMapper.Query<TMS_JOB_ITEMModel>(VSK_TMS, "SP_TMS_Job_Search", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();

                VSK_TMS.Close();
                return SP_TMS_Job_Search.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public List<TMS_JOB_ITEMModel> TMS_Job_Express_Item_Sync_Get()
        {
            try
            {
                DynamicParameters objParam = new DynamicParameters();

                Connection();
                VSK_TMS.Open();
                List<TMS_JOB_ITEMModel> SP_TMS_Job_Search = SqlMapper.Query<TMS_JOB_ITEMModel>(VSK_TMS, "SP_TMS_Job_Express_Item_Sync_Get", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();

                VSK_TMS.Close();
                return SP_TMS_Job_Search.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public void TMS_Job_Express_Item_Sync_Add(List<TMS_JOB_IMPORTModel> TMS_JOB_IMPORTModel)
        {
            try
            {
                foreach (var TMS_JOB_IMPORTData in TMS_JOB_IMPORTModel)
                {
                    DynamicParameters objParam = new DynamicParameters();
                    objParam.Add("@createDate", TMS_JOB_IMPORTData.createDate);
                    objParam.Add("@currentStatusDate", TMS_JOB_IMPORTData.currentStatusDate);
                    objParam.Add("@description", TMS_JOB_IMPORTData.description);
                    objParam.Add("@dimension", TMS_JOB_IMPORTData.dimension);
                    objParam.Add("@distributionCenter", TMS_JOB_IMPORTData.distributionCenter);
                    objParam.Add("@driver", TMS_JOB_IMPORTData.driver);
                    objParam.Add("@endMile", TMS_JOB_IMPORTData.endMile);
                    objParam.Add("@expDeliveryDate", TMS_JOB_IMPORTData.expDeliveryDate);
                    objParam.Add("@manifestCode", TMS_JOB_IMPORTData.manifestCode);
                    objParam.Add("@manifestType", TMS_JOB_IMPORTData.manifestType);
                    objParam.Add("@merchantName", TMS_JOB_IMPORTData.merchantName);
                    objParam.Add("@phoneNumber", TMS_JOB_IMPORTData.phoneNumber);
                    objParam.Add("@projectName", TMS_JOB_IMPORTData.projectName);
                    objParam.Add("@qty", TMS_JOB_IMPORTData.qty);
                    objParam.Add("@recipientAddress", TMS_JOB_IMPORTData.recipientAddress);
                    objParam.Add("@recipientName", TMS_JOB_IMPORTData.recipientName);
                    objParam.Add("@recipientPostalCode", TMS_JOB_IMPORTData.recipientPostalCode);
                    objParam.Add("@recipientProvince", TMS_JOB_IMPORTData.recipientProvince);
                    objParam.Add("@routeLineName", TMS_JOB_IMPORTData.routeLineName);
                    objParam.Add("@shippingDate", TMS_JOB_IMPORTData.shippingDate);
                    objParam.Add("@shippingNoteNumber", TMS_JOB_IMPORTData.shippingNoteNumber);
                    objParam.Add("@startMile", TMS_JOB_IMPORTData.startMile);
                    objParam.Add("@status", TMS_JOB_IMPORTData.status);
                    objParam.Add("@statusId", TMS_JOB_IMPORTData.statusId);
                    objParam.Add("@totalDeliveryAttempts", TMS_JOB_IMPORTData.totalDeliveryAttempts);
                    objParam.Add("@totalDistance", TMS_JOB_IMPORTData.totalDistance);
                    objParam.Add("@totalMile", TMS_JOB_IMPORTData.totalMile);
                    objParam.Add("@vehicle", TMS_JOB_IMPORTData.vehicle);
                    objParam.Add("@vehicleAddOn", TMS_JOB_IMPORTData.vehicleAddOn);
                    objParam.Add("@weight", TMS_JOB_IMPORTData.weight);

                    Connection();
                    VSK_TMS.Open();
                    VSK_TMS.Execute("SP_TMS_Job_Express_Item_Sync_Add", objParam, commandType: CommandType.StoredProcedure);
                    VSK_TMS.Close();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void TMS_Job_Express_PPT_Sync_Add(List<TMS_JOB_IMPORTModel> TMS_JOB_IMPORTModel)
        {
            try
            {
                foreach (var TMS_JOB_IMPORTData in TMS_JOB_IMPORTModel)
                {
                    DynamicParameters objParam = new DynamicParameters();
                    objParam.Add("@createDate", TMS_JOB_IMPORTData.createDate);
                    objParam.Add("@currentStatusDate", TMS_JOB_IMPORTData.currentStatusDate);
                    objParam.Add("@description", TMS_JOB_IMPORTData.description);
                    objParam.Add("@dimension", TMS_JOB_IMPORTData.dimension);
                    objParam.Add("@distributionCenter", TMS_JOB_IMPORTData.distributionCenter);
                    objParam.Add("@driver", TMS_JOB_IMPORTData.driver);
                    objParam.Add("@endMile", TMS_JOB_IMPORTData.endMile);
                    objParam.Add("@expDeliveryDate", TMS_JOB_IMPORTData.expDeliveryDate);
                    objParam.Add("@manifestCode", TMS_JOB_IMPORTData.manifestCode);
                    objParam.Add("@manifestType", TMS_JOB_IMPORTData.manifestType);
                    objParam.Add("@merchantName", TMS_JOB_IMPORTData.merchantName);
                    objParam.Add("@phoneNumber", TMS_JOB_IMPORTData.phoneNumber);
                    objParam.Add("@projectName", TMS_JOB_IMPORTData.projectName);
                    objParam.Add("@qty", TMS_JOB_IMPORTData.qty);
                    objParam.Add("@recipientAddress", TMS_JOB_IMPORTData.recipientAddress);
                    objParam.Add("@recipientName", TMS_JOB_IMPORTData.recipientName);
                    objParam.Add("@recipientPostalCode", TMS_JOB_IMPORTData.recipientPostalCode);
                    objParam.Add("@recipientProvince", TMS_JOB_IMPORTData.recipientProvince);
                    objParam.Add("@routeLineName", TMS_JOB_IMPORTData.routeLineName);
                    objParam.Add("@shippingDate", TMS_JOB_IMPORTData.shippingDate);
                    objParam.Add("@shippingNoteNumber", TMS_JOB_IMPORTData.shippingNoteNumber);
                    objParam.Add("@startMile", TMS_JOB_IMPORTData.startMile);
                    objParam.Add("@status", TMS_JOB_IMPORTData.status);
                    objParam.Add("@statusId", TMS_JOB_IMPORTData.statusId);
                    objParam.Add("@totalDeliveryAttempts", TMS_JOB_IMPORTData.totalDeliveryAttempts);
                    objParam.Add("@totalDistance", TMS_JOB_IMPORTData.totalDistance);
                    objParam.Add("@totalMile", TMS_JOB_IMPORTData.totalMile);
                    objParam.Add("@vehicle", TMS_JOB_IMPORTData.vehicle);
                    objParam.Add("@vehicleAddOn", TMS_JOB_IMPORTData.vehicleAddOn);
                    objParam.Add("@weight", TMS_JOB_IMPORTData.weight);

                    Connection();
                    VSK_TMS.Open();
                    VSK_TMS.Execute("SP_TMS_Job_Express_PPT_Sync_Add", objParam, commandType: CommandType.StoredProcedure);
                    VSK_TMS.Close();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<PKToTMSModel> TMS_Job_PKToTMS_Search(string job_start_date, string job_end_date, double toption, string mode)
        {
            try
            {
                DynamicParameters objParam = new DynamicParameters();

                /*
                objParam.Add("@job_start_date", job_start_date == DateTime.MinValue ? null : job_start_date.ToString());
                objParam.Add("@job_end_date", job_end_date == DateTime.MinValue ? null : job_end_date.ToString());
                */
                objParam.Add("@job_start_date", job_start_date);
                objParam.Add("@job_end_date", job_end_date);
                objParam.Add("@toption", toption);
                objParam.Add("@mode", mode);

                Connection();
                VSK_TMS.Open();
                List<PKToTMSModel> SP_TMS_Job_Search = SqlMapper.Query<PKToTMSModel>(VSK_TMS, "SP_TMS_Job_PKToTMS_Search", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();

                VSK_TMS.Close();
                return SP_TMS_Job_Search.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        //public void TRP_TMS_JOB_Add(TMS_JOB_ITEMModel TMS_JOB_ITEMModel)
        //{
        //    try
        //    {
        //        DynamicParameters objParam = new DynamicParameters();
        //        objParam.Add("@tran_id", TMS_JOB_ITEMModel.tran_id);
        //        objParam.Add("@job_date", TMS_JOB_ITEMModel.job_date);
        //        objParam.Add("@job_invoice_no", TMS_JOB_ITEMModel.job_invoice_no);
        //        objParam.Add("@job_invoice_date", TMS_JOB_ITEMModel.job_invoice_date);
        //        objParam.Add("@job_pk_no", TMS_JOB_ITEMModel.job_pk_no);
        //        objParam.Add("@job_qty", TMS_JOB_ITEMModel.job_qty);
        //        objParam.Add("@invnet", TMS_JOB_ITEMModel.invnet);
        //        objParam.Add("@invcode", TMS_JOB_ITEMModel.invcode);
        //        objParam.Add("@job_delivery_name", TMS_JOB_ITEMModel.job_delivery_name);
        //        objParam.Add("@job_delivery_addr", TMS_JOB_ITEMModel.job_delivery_addr);
        //        objParam.Add("@route_no", TMS_JOB_ITEMModel.route_no);
        //        objParam.Add("@route_name", TMS_JOB_ITEMModel.route_name);
        //        objParam.Add("@driver_id", TMS_JOB_ITEMModel.driver_id);
        //        objParam.Add("@driver_fullname", TMS_JOB_ITEMModel.driver_fullname);
        //        objParam.Add("@job_plate", TMS_JOB_ITEMModel.job_plate);
        //        objParam.Add("@plate_name", TMS_JOB_ITEMModel.plate_name);
        //        objParam.Add("@created_by", TMS_JOB_ITEMModel.created_by);
        //        objParam.Add("@ref_id", TMS_JOB_ITEMModel.ref_id);
        //        objParam.Add("@delivery_type", TMS_JOB_ITEMModel.delivery_type);
        //        objParam.Add("@delivery_status", TMS_JOB_ITEMModel.delivery_status);
        //        objParam.Add("@cod_price", TMS_JOB_ITEMModel.cod_price);

        //        Connection();
        //        VSK_TMS.Open();
        //        VSK_TMS.Execute("SP_TMS_Job_Item_Add", objParam, commandType: CommandType.StoredProcedure);
        //        VSK_TMS.Close();

        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //}


        //public List<TMS_JOB_EXPORTModel> TMS_Job_Item_Get(TMS_JOB_ITEMModel TMS_JOB_ITEMModel)
        //{
        //    try
        //    {

        //        DynamicParameters objParam = new DynamicParameters();

        //        objParam.Add("@job_date", TMS_JOB_ITEMModel.job_date);
        //        objParam.Add("@job_invoice_no", TMS_JOB_ITEMModel.job_invoice_no);
        //        objParam.Add("@job_invoice_date", TMS_JOB_ITEMModel.job_invoice_date);
        //        objParam.Add("@job_pk_no", TMS_JOB_ITEMModel.job_pk_no);
        //        objParam.Add("@job_qty", TMS_JOB_ITEMModel.job_qty);
        //        objParam.Add("@invnet", TMS_JOB_ITEMModel.invnet);
        //        objParam.Add("@invcode", TMS_JOB_ITEMModel.invcode);
        //        objParam.Add("@job_delivery_name", TMS_JOB_ITEMModel.job_delivery_name);
        //        objParam.Add("@job_delivery_addr", TMS_JOB_ITEMModel.job_delivery_addr);
        //        objParam.Add("@route_no", TMS_JOB_ITEMModel.route_no);
        //        objParam.Add("@route_name", TMS_JOB_ITEMModel.route_name);
        //        objParam.Add("@driver_id", TMS_JOB_ITEMModel.driver_id);
        //        objParam.Add("@driver_fullname", TMS_JOB_ITEMModel.driver_fullname);
        //        objParam.Add("@job_plate", TMS_JOB_ITEMModel.job_plate);
        //        objParam.Add("@plate_name", TMS_JOB_ITEMModel.plate_name);
        //        objParam.Add("@ref_id", TMS_JOB_ITEMModel.ref_id);
        //        objParam.Add("@cod_price", TMS_JOB_ITEMModel.cod_price);

        //        Connection();
        //        VSK_TMS.Open();
        //        List<TMS_JOB_EXPORTModel> TMS_JOB_ITEMList = SqlMapper.Query<TMS_JOB_EXPORTModel>(VSK_TMS, "SP_TMS_Job_Item_Get", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();

        //        VSK_TMS.Close();
        //        return TMS_JOB_ITEMList.ToList();

        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //}

        public List<TMS_JOB_ITEMModel> TMS_JOB_TR_GET(TMS_JOB_ITEMModel TMS_JOB_ITEMModel)
        {
            try
            {
                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@ref_id", TMS_JOB_ITEMModel.ref_id);
                objParam.Add("@mode", TMS_JOB_ITEMModel.mode);

                Connection();
                VSK_TMS.Open();
                List<TMS_JOB_ITEMModel> SP_TMS_Job_Search = SqlMapper.Query<TMS_JOB_ITEMModel>(VSK_TMS, "SP_TMS_JOB_TR_GET", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();

                VSK_TMS.Close();
                return SP_TMS_Job_Search.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
}