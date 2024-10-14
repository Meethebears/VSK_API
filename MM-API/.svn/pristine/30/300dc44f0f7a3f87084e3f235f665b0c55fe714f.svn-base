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
    public class MoveMaxRepository : Controller
    {

        #region Connection_SQL Server
        //-------------------Start Connection_SQL ------------------------//
        public SqlConnection VSK_TRP;

        private void Connection()
        {
            VSK_TRP = new SqlConnection(ConfigurationManager.ConnectionStrings["VSK_TRP"].ToString());
        }
        //-------------------End Connection_SQL ------------------------//
        #endregion


        public IList<MM_ShippingNoteBookingModel> MM_ShippingNoteBookingBike_Get(string NUMBER,string ROUTE, string DRIVER, string CREATE_BY)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@NUMBER", NUMBER);
                objParam.Add("@ROUTE", ROUTE);
                objParam.Add("@Driver", DRIVER);
                objParam.Add("@CREATE_BY", CREATE_BY);

                Connection();
                VSK_TRP.Open();
                IList<MM_ShippingNoteBookingModel> MM_ShippingNoteBooking_List = VSK_TRP.Query<MM_ShippingNoteBookingModel>("SP_MM_ShippingNoteBookingBike_Get", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();
                VSK_TRP.Close();
                return MM_ShippingNoteBooking_List.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IList<MM_ProductListModel> MM_ProductBike_Get(string NUMBER, string shippingNoteResCode, string CREATE_BY)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@NUMBER", NUMBER);
                objParam.Add("@shippingNoteResCode", shippingNoteResCode);
                objParam.Add("@CREATE_BY", CREATE_BY);

                Connection();
                VSK_TRP.Open();
                IList<MM_ProductListModel> MM_ProductList_List = VSK_TRP.Query<MM_ProductListModel>("SP_MM_ProductBike_Get", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();
                VSK_TRP.Close();
                return MM_ProductList_List.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void MM_ManifestNoteJob_Create(MM_ManifestNoteJobModel MM_ManifestNoteJobModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();
                objParam.Add("@mm_manifestNoteId", MM_ManifestNoteJobModel.mm_manifestNoteId);
                objParam.Add("@mm_manifestNoteNumber", MM_ManifestNoteJobModel.mm_manifestNoteNumber);
                objParam.Add("@mm_shippingNoteResId", MM_ManifestNoteJobModel.mm_shippingNoteResId);
                objParam.Add("@mm_shippingNoteResCode", MM_ManifestNoteJobModel.mm_shippingNoteResCode);

                Connection();
                VSK_TRP.Open();
                SqlMapper.Query(VSK_TRP, "SP_MM_ManifestNoteJob_Create", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();
                VSK_TRP.Close();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}