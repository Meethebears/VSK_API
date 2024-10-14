using Dapper;
using REPO.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace REPO.Controllers
{
    public class DashbordRepository : Controller
    {

        #region Connection_SQL Server
        //-------------------Start Connection_SQL ------------------------//
        public SqlConnection VSK_DASHBOARD;

        private void Connection()
        {
            VSK_DASHBOARD = new SqlConnection(ConfigurationManager.ConnectionStrings["VSK_DASHBOARD"].ToString());
        }
        //-------------------End Connection_SQL ------------------------//
        #endregion

        public void DashboardWH_Create(string STKZONE, string INVDATE)
        {
            try
            {
                DynamicParameters objParam = new DynamicParameters();
                objParam.Add("@STKZONE", STKZONE);
                objParam.Add("@INVDATE", INVDATE);

                Connection();
                VSK_DASHBOARD.Open();
                SqlMapper.Query(VSK_DASHBOARD, "SP_DASHBOARD_WH_CREATE", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();
                VSK_DASHBOARD.Close();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IList<DashboardWHOrdertypeModel> DashboardWH_GET(string STKZONE, string INVDATE)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@STKZONE", @STKZONE);
                objParam.Add("@INVDATE", INVDATE);

                Connection();
                VSK_DASHBOARD.Open();

                IList<DashboardWHOrdertypeModel> DashboardWHOrdertype_List = VSK_DASHBOARD.Query<DashboardWHOrdertypeModel>("SP_DASHBOARD_WH_GET", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();

                VSK_DASHBOARD.Close();
                return DashboardWHOrdertype_List.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IList<DashboardWHDetailModel> DashboardWHDetail_GET(string STKZONE, string INVDATE, string ORDERTYPE)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@STKZONE", @STKZONE);
                objParam.Add("@INVDATE", INVDATE);
                objParam.Add("@ORDERTYPE", ORDERTYPE);

                Connection();
                VSK_DASHBOARD.Open();

                IList<DashboardWHDetailModel> DashboardWHDetail_List = VSK_DASHBOARD.Query<DashboardWHDetailModel>("SP_DASHBOARD_WH_DETAIL_GET", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();

                VSK_DASHBOARD.Close();
                return DashboardWHDetail_List.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void DashboardIVOrdertype_Create(string INVDATE)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();
                objParam.Add("@INVDATE", INVDATE);

                Connection();
                VSK_DASHBOARD.Open();
                SqlMapper.Query(VSK_DASHBOARD, "SP_DASHBOARD_IV_CREATE", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();
                VSK_DASHBOARD.Close();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public IList<DashboardIVOrderypeModel> DashboardIVOrdertype_Get(string INVDATE)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@INVDATE", INVDATE);

                Connection();
                VSK_DASHBOARD.Open();

                IList<DashboardIVOrderypeModel> DashboardIVOrdertype_List = VSK_DASHBOARD.Query<DashboardIVOrderypeModel>("SP_DASHBOARD_IV_ORDERTYPE_GET", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();

                VSK_DASHBOARD.Close();
                return DashboardIVOrdertype_List.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IList<DashboardPKNotIVDetailModel> DashboardPKNotIVDetail_GET(string INVDATE, string ORDERTYPE)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@INVDATE", INVDATE);
                objParam.Add("@ORDERTYPE", ORDERTYPE);

                Connection();
                VSK_DASHBOARD.Open();

                IList<DashboardPKNotIVDetailModel> DashboardPKNotIVDetail_List = VSK_DASHBOARD.Query<DashboardPKNotIVDetailModel>("SP_PK_NOT_IV_DETAIL_GET", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();

                VSK_DASHBOARD.Close();
                return DashboardPKNotIVDetail_List.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IList<DashboardPKWITHTRPDetailModel> DashboardPKWITHIVDetail_GET(string INVDATE, string ORDERTYPE)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@INVDATE", INVDATE);
                objParam.Add("@ORDERTYPE", ORDERTYPE);

                Connection();
                VSK_DASHBOARD.Open();

                IList<DashboardPKWITHTRPDetailModel> DashboardPKWITHTRPDetail_List = VSK_DASHBOARD.Query<DashboardPKWITHTRPDetailModel>("SP_PK_WITH_TRP_DETAIL_GET", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();

                VSK_DASHBOARD.Close();
                return DashboardPKWITHTRPDetail_List.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IList<DashboardPKWITHTRPDetailModel> DashboardPKWITHIVDetailPeriod_GET(string INVDATE, string ORDERTYPE, string STARTTIME, string ENDTIME)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@INVDATE", INVDATE);
                objParam.Add("@ORDERTYPE", ORDERTYPE);
                objParam.Add("@STARTTIME", STARTTIME);
                objParam.Add("@ENDTIME", ENDTIME);

                Connection();
                VSK_DASHBOARD.Open();

                IList<DashboardPKWITHTRPDetailModel> DashboardPKWITHTRPDetail_List = VSK_DASHBOARD.Query<DashboardPKWITHTRPDetailModel>("SP_PK_WITH_TRP_DETAILBYPERIOD_GET", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();

                VSK_DASHBOARD.Close();
                return DashboardPKWITHTRPDetail_List.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IList<DashboardIVNotTRPDetailPeriodModel> DashboardIVNotTRPDetailPeriod_GET(string INVDATE, string ORDERTYPE, string STARTTIME, string ENDTIME)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@INVDATE", INVDATE);
                objParam.Add("@ORDERTYPE", ORDERTYPE);
                objParam.Add("@STARTTIME", STARTTIME);
                objParam.Add("@ENDTIME", ENDTIME);

                Connection();
                VSK_DASHBOARD.Open();

                IList<DashboardIVNotTRPDetailPeriodModel> DashboardIVNotTRPDetailPeriod_List = VSK_DASHBOARD.Query<DashboardIVNotTRPDetailPeriodModel>("SP_IV_NOT_TRP_DETAILBYPERIOD_GET", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();

                VSK_DASHBOARD.Close();
                return DashboardIVNotTRPDetailPeriod_List.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IList<DashboardIVWITHTRPDetailModel> DashboardIVWITHTRPDetailPeriod_GET(string INVDATE, string ORDERTYPE, string STARTTIME, string ENDTIME)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@INVDATE", INVDATE);
                objParam.Add("@ORDERTYPE", ORDERTYPE);
                objParam.Add("@STARTTIME", STARTTIME);
                objParam.Add("@ENDTIME", ENDTIME);

                Connection();
                VSK_DASHBOARD.Open();

                IList<DashboardIVWITHTRPDetailModel> DashboardIVWITHTRPDetailPeriod_List = VSK_DASHBOARD.Query<DashboardIVWITHTRPDetailModel>("SP_IV_WITH_TRP_DETAILBYPERIOD_GET", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();

                VSK_DASHBOARD.Close();
                return DashboardIVWITHTRPDetailPeriod_List.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}