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
    public class DashboardRepository
    {

        #region Connection_SQL Server
        //-------------------Start Connection_SQL ------------------------//

        public SqlConnection mscon;

        private void Connection()
        {

            string msconstr = ConfigurationManager.ConnectionStrings["MIS_SERVICE"].ToString();
            mscon = new SqlConnection(msconstr);
        }

        //-------------------End Connection_SQL ------------------------//
        #endregion

        #region Dashboard_Create
        public List<DashboardModel> Dashboard_Create(DashboardModel DashboardModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();


                objParam.Add("@pk_date", DashboardModel.pk_date);
                objParam.Add("@last_updated_time", DashboardModel.last_updated_time);

                Connection();
                mscon.Open();
                List<DashboardModel> DBList = SqlMapper.Query<DashboardModel>(mscon, "SP_INV_Dashboard_Packing_Exec", objParam, commandTimeout: 280, commandType: CommandType.StoredProcedure).ToList();

                mscon.Close();
                return DBList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Dashboard_Total
        public List<DashboardModel> Dashboard_Total(DashboardModel DashboardModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();


                objParam.Add("@pk_date", DashboardModel.pk_date);

                Connection();
                mscon.Open();
                List<DashboardModel> DBList = SqlMapper.Query<DashboardModel>(mscon, "SP_INV_Dashboard_Packing_Total", objParam, commandTimeout: 280, commandType: CommandType.StoredProcedure).ToList();

                mscon.Close();
                return DBList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Dashboard_Get
        public List<DashboardModel> Dashboard_Get(DashboardModel DashboardModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@pk_date", DashboardModel.pk_date);
                objParam.Add("@last_updated_time", DashboardModel.last_updated_time);
                objParam.Add("@std_name", DashboardModel.std_name);
                objParam.Add("@on_time", DashboardModel.on_time);
                objParam.Add("@pk_type", DashboardModel.pk_type);
                objParam.Add("@WH", DashboardModel.WH);

                Connection();
                mscon.Open();
                List<DashboardModel> DBList = SqlMapper.Query<DashboardModel>(mscon, "SP_INV_Dashboard_Packing_Get", objParam, commandTimeout: 280, commandType: CommandType.StoredProcedure).ToList();

                mscon.Close();
                return DBList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Dashboard_Invoice_Create
        public List<InvoiceModel> Dashboard_Invoice_Create(InvoiceModel InvoiceModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();


                objParam.Add("@pk_date", InvoiceModel.pk_date);
                objParam.Add("@last_updated_time", InvoiceModel.last_updated_time);

                Connection();
                mscon.Open();
                List<InvoiceModel> DBList = SqlMapper.Query<InvoiceModel>(mscon, "SP_INV_Dashboard_Invoice_Exec", objParam, commandTimeout: 300, commandType: CommandType.StoredProcedure).ToList();

                mscon.Close();
                return DBList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Dashboard_Invoice_Get
        public List<InvoiceModel> Dashboard_Invoice_Get(InvoiceModel InvoiceModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@pk_date", InvoiceModel.pk_date);
                objParam.Add("@last_updated_time", InvoiceModel.last_updated_time);
                objParam.Add("@invoice_on_time", InvoiceModel.invoice_on_time);
                objParam.Add("@invoice_name", InvoiceModel.invoice_name);
                objParam.Add("@invoice_order_type", InvoiceModel.invoice_order_type);


                Connection();
                mscon.Open();
                List<InvoiceModel> DBList = SqlMapper.Query<InvoiceModel>(mscon, "SP_INV_Dashboard_Invoice_Get", objParam, commandTimeout: 280, commandType: CommandType.StoredProcedure).ToList();

                mscon.Close();
                return DBList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Dashboard_Invoice_Total
        public List<InvoiceModel> Dashboard_Invoice_Total(InvoiceModel InvoiceModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@pk_date", InvoiceModel.pk_date);
                objParam.Add("@last_updated_time", InvoiceModel.last_updated_time);
                objParam.Add("@inv_total_name", InvoiceModel.inv_total_name);



                Connection();
                mscon.Open();
                List<InvoiceModel> DBList = SqlMapper.Query<InvoiceModel>(mscon, "SP_INV_Dashboard_Invoice_Total_Get", objParam, commandTimeout: 280, commandType: CommandType.StoredProcedure).ToList();

                mscon.Close();
                return DBList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Dashboard_Invoice_Backlog
        public List<InvoiceModel> Dashboard_Invoice_Backlog(InvoiceModel InvoiceModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@pk_date", InvoiceModel.pk_date);
                objParam.Add("@last_updated_time", InvoiceModel.last_updated_time);

                Connection();
                mscon.Open();
                List<InvoiceModel> DBList = SqlMapper.Query<InvoiceModel>(mscon, "SP_INV_Dashboard_Invoice_Backlog", objParam, commandTimeout: 280, commandType: CommandType.StoredProcedure).ToList();

                mscon.Close();
                return DBList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region TRP_TMS_Sync_Add

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
                    objParam.Add("@tms_job_status", TMS_JOBData.tms_job_status);

                    Connection();
                    mscon.Open();
                    mscon.Execute("SP_TRP_TMS_Sync_Add", objParam, commandTimeout: 280, commandType: CommandType.StoredProcedure);
                    mscon.Close();
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region TRP_TMS_Sync_Delete
        public void TRP_TMS_Sync_Delete()
        {
            try
            {
                DynamicParameters objParam = new DynamicParameters();

                Connection();
                mscon.Open();
                mscon.Execute("SP_TRP_TMS_Sync_Delete", objParam, commandType: CommandType.StoredProcedure);
                mscon.Close();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion
    }
}