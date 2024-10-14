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
            VSK_TRP = new SqlConnection(ConfigurationManager.ConnectionStrings["VSK_TRP_187"].ToString());
        }
        //-------------------End Connection_SQL ------------------------//
        #endregion

        public IList<MM_ShippingNoteBookingModel> MM_ShippingNoteBookingBike_Get(string NUMBER, string ROUTE, string DRIVER, string VEHICLE, string CREATE_BY)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@NUMBER", NUMBER);
                objParam.Add("@ROUTE", ROUTE);
                objParam.Add("@Driver", DRIVER);
                objParam.Add("@VEHICLE", VEHICLE);
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

        public void MM_ManifestNoteJob_Create(List<MM_ManifestNoteJobModel> MM_ManifestNoteJobModel)
        {
            try
            {

                Connection();

                VSK_TRP.Open();

                foreach (var ImportDataArrayData in MM_ManifestNoteJobModel)
                {
                    DynamicParameters objParam = new DynamicParameters();

                    objParam.Add("@mm_manifestNoteId", ImportDataArrayData.mm_manifestNoteId);
                    objParam.Add("@mm_manifestNoteNumber", ImportDataArrayData.mm_manifestNoteNumber);
                    objParam.Add("@mm_shippingNoteResId", ImportDataArrayData.mm_shippingNoteResId);
                    objParam.Add("@mm_shippingNoteResCode", ImportDataArrayData.mm_shippingNoteResCode);
                    objParam.Add("@ref_id", ImportDataArrayData.ref_id);
                    objParam.Add("@job_type", ImportDataArrayData.job_type);
                    objParam.Add("@endRouteLineName", ImportDataArrayData.endRouteLineName);
                    objParam.Add("@driverName", ImportDataArrayData.driverName);

                    VSK_TRP.Execute("SP_MM_ManifestNoteJob_Create", objParam, commandTimeout: 600, commandType: CommandType.StoredProcedure);

                }

                VSK_TRP.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<MM_ManifestNoteJobModel> MM_ManifestNoteJob_Delete (MM_ManifestNoteJobModel MM_ManifestNoteJobModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@mm_shippingNoteResCode", MM_ManifestNoteJobModel.mm_shippingNoteResCode);
                objParam.Add("@updated_by", MM_ManifestNoteJobModel.updated_by);

                Connection();
                VSK_TRP.Open();
                List<MM_ManifestNoteJobModel> PckList = SqlMapper.Query<MM_ManifestNoteJobModel>(VSK_TRP, "SP_MM_ManifestNoteJob_Delete", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();
                VSK_TRP.Close();
                return PckList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public List<MM_ManifestNoteModel> MM_ManifestNote_List(MM_ManifestNoteModel MM_ManifestNoteModel)
        {
            try
            {
                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@job_start_date", MM_ManifestNoteModel.job_start_date);
                objParam.Add("@job_end_date", MM_ManifestNoteModel.job_end_date);
                objParam.Add("@p_code", MM_ManifestNoteModel.p_code);
                objParam.Add("@f_endRouteLineCode", MM_ManifestNoteModel.f_endRouteLineCode);
                objParam.Add("@f_driverCode", MM_ManifestNoteModel.f_driverCode);
                objParam.Add("@f_vehicleCode", MM_ManifestNoteModel.f_vehicleCode);
                objParam.Add("@f_receiver_code", MM_ManifestNoteModel.f_receiver_code);
                objParam.Add("@manifestNoteNumber", MM_ManifestNoteModel.manifestNoteNumber);
                objParam.Add("@shippingNoteNumber", MM_ManifestNoteModel.shippingNoteNumber);
                objParam.Add("@currentStatus", MM_ManifestNoteModel.currentStatus);
                objParam.Add("@p_orderNo", MM_ManifestNoteModel.p_orderNo);
                objParam.Add("@p_packageNo", MM_ManifestNoteModel.p_packageNo);
                objParam.Add("@job_type", MM_ManifestNoteModel.job_type);
                //objParam.Add("@job_invoice_no", MM_ManifestNoteModel.job_invoice_no);

                Connection();
                VSK_TRP.Open();
                List<MM_ManifestNoteModel> MM_LIST = SqlMapper.Query<MM_ManifestNoteModel>(VSK_TRP, "SP_MM_ManifestNote_List", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();
                VSK_TRP.Close();

                return MM_LIST.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<MM_ManifestNoteModel> MM_ManiFestNoteRoute_List(MM_ManifestNoteModel MM_ManifestNoteModel)
        {
            try
            {
                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@job_start_date", MM_ManifestNoteModel.job_start_date);
                objParam.Add("@job_end_date", MM_ManifestNoteModel.job_end_date);
                objParam.Add("@endRouteLineCode", MM_ManifestNoteModel.endRouteLineCode);
                objParam.Add("@driverCode", MM_ManifestNoteModel.driverCode);
                objParam.Add("@vehicleCode", MM_ManifestNoteModel.vehicleCode);

                Connection();
                VSK_TRP.Open();
                List<MM_ManifestNoteModel> MM_LIST = SqlMapper.Query<MM_ManifestNoteModel>(VSK_TRP, "SP_MM_ManiFestNoteRoute_LIST", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();
                VSK_TRP.Close();

                return MM_LIST.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<MM_ProductListModel> MM_ProductMulit_Create(string BRANCH, string NUMBER, string REF_ID, string CREATE_BY)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@BRANCH", BRANCH);
                objParam.Add("@NUMBER", NUMBER);
                objParam.Add("@REF_ID", REF_ID);
                objParam.Add("@CREATE_BY", CREATE_BY);

                Connection();
                VSK_TRP.Open();
                IList<MM_ProductListModel> MM_ProductList_List = VSK_TRP.Query<MM_ProductListModel>("SP_MM_ProductMulit_Create", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();
                VSK_TRP.Close();
                return MM_ProductList_List.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<MM_ProductListModel> MM_ProductMulit_Get(string NUMBER, string REF_ID, string CREATE_BY)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@NUMBER", NUMBER);
                objParam.Add("@REF_ID", REF_ID);
                objParam.Add("@CREATE_BY", CREATE_BY);

                Connection();
                VSK_TRP.Open();
                IList<MM_ProductListModel> MM_ProductList_List = VSK_TRP.Query<MM_ProductListModel>("SP_MM_ProductMulit_Get", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();
                VSK_TRP.Close();
                return MM_ProductList_List.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<MM_ProductListModel> MM_ProductMulit_Delete(string NUMBER, string REF_ID, string CREATE_BY)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@NUMBER", NUMBER);
                objParam.Add("@REF_ID", REF_ID);
                objParam.Add("@CREATE_BY", CREATE_BY);

                Connection();
                VSK_TRP.Open();

                List<MM_ProductListModel> MM_ProductList_List = SqlMapper.Query<MM_ProductListModel>(VSK_TRP, "SP_MM_ProductMulit_Delete", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();

                VSK_TRP.Close();
                return MM_ProductList_List.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public List<MM_ShippingNoteBookingModel> MM_ShippingNoteBookingMulit_Get(string REF_ID, string ROUTE, string DRIVER, string VEHICLE, DateTime JOBDATE, string CREATE_BY)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@REF_ID", REF_ID);
                objParam.Add("@ROUTE", ROUTE);
                objParam.Add("@DRIVER", DRIVER);
                objParam.Add("@VEHICLE", VEHICLE);
                objParam.Add("@JOBDATE", JOBDATE);
                objParam.Add("@CREATE_BY", CREATE_BY);

                Connection();
                VSK_TRP.Open();
                IList<MM_ShippingNoteBookingModel> MM_ShippingNoteBooking_List = VSK_TRP.Query<MM_ShippingNoteBookingModel>("SP_MM_ShippingNoteBookingMulit_Get", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();
                VSK_TRP.Close();
                return MM_ShippingNoteBooking_List.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<MM_ProductListModel> MM_ManiFestNote_Create(string REF_ID)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@REF_ID", REF_ID);

                Connection();
                VSK_TRP.Open();
                IList<MM_ProductListModel> MM_ProductList_List = VSK_TRP.Query<MM_ProductListModel>("SP_MM_ManiFestNote_Create", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();
                VSK_TRP.Close();
                return MM_ProductList_List.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<MM_ProductListModel> MM_ProductPck_Get(string REF_ID)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@REF_ID", REF_ID);

                Connection();
                VSK_TRP.Open();
                IList<MM_ProductListModel> MM_ProductList_List = VSK_TRP.Query<MM_ProductListModel>("SP_MM_ProductPck_Get", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();
                VSK_TRP.Close();
                return MM_ProductList_List.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<MM_ShippingNoteBookingModel> MM_ShippingNoteBookingPck_Get(string REF_ID, string ROUTE, string DRIVER, string VEHICLE, DateTime JOBDATE, string CREATE_BY)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@REF_ID", REF_ID);
                objParam.Add("@ROUTE", ROUTE);
                objParam.Add("@DRIVER", DRIVER);
                objParam.Add("@VEHICLE", VEHICLE);
                objParam.Add("@JOBDATE", JOBDATE);
                objParam.Add("@CREATE_BY", CREATE_BY);

                Connection();
                VSK_TRP.Open();
                IList<MM_ShippingNoteBookingModel> MM_ShippingNoteBooking_List = VSK_TRP.Query<MM_ShippingNoteBookingModel>("SP_MM_ShippingNoteBookingPck_Get", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();
                VSK_TRP.Close();
                return MM_ShippingNoteBooking_List.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void MM_ProductPck_Create(List<MM_ProductListModel> MM_ProductListModel)
        {
            try
            {

                Connection();

                VSK_TRP.Open();

                foreach (var ImportDataArrayData in MM_ProductListModel)
                {
                    DynamicParameters objParam = new DynamicParameters();

                    objParam.Add("@NUMBER", ImportDataArrayData.NUMBER);
                    objParam.Add("@JOBDATE", ImportDataArrayData.JOBDATE);
                    objParam.Add("@REF_ID", ImportDataArrayData.REF_ID);
                    objParam.Add("@CREATE_BY", ImportDataArrayData.CREATE_BY);

                    VSK_TRP.Execute("SP_MM_ProductPck_Create", objParam, commandTimeout: 600, commandType: CommandType.StoredProcedure);

                }

                VSK_TRP.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void MM_ShipmentDaily_Create(List<MM_ShipmentDailyModel> MM_ShipmentDailyModel)
        {
            try
            {

                Connection();

                VSK_TRP.Open();

                foreach (var ImportDataArrayData in MM_ShipmentDailyModel)
                {
                    DynamicParameters objParam = new DynamicParameters();

                    objParam.Add("@cod", ImportDataArrayData.cod);
                    objParam.Add("@currentStatus", ImportDataArrayData.currentStatus);
                    objParam.Add("@currentStatusDate", ImportDataArrayData.currentStatusDate);
                    objParam.Add("@currentStatusDateText", ImportDataArrayData.currentStatusDateText);
                    objParam.Add("@currentStatusText", ImportDataArrayData.currentStatusText);
                    objParam.Add("@currentStatusTimeText", ImportDataArrayData.currentStatusTimeText);
                    objParam.Add("@deliveryPrice", ImportDataArrayData.deliveryPrice);
                    objParam.Add("@deliveryProjectId", ImportDataArrayData.deliveryProjectId);
                    objParam.Add("@deliveryProjectName", ImportDataArrayData.deliveryProjectName);
                    objParam.Add("@driverName", ImportDataArrayData.driverName);
                    objParam.Add("@endDeliveryDate", ImportDataArrayData.endDeliveryDate);
                    objParam.Add("@endDeliveryDateText", ImportDataArrayData.endDeliveryDateText);
                    objParam.Add("@endRouteLineId", ImportDataArrayData.endRouteLineId);
                    objParam.Add("@id", ImportDataArrayData.id);
                    objParam.Add("@manifestNoteDocumentDate", ImportDataArrayData.manifestNoteDocumentDate);
                    objParam.Add("@manifestNoteDocumentDateText", ImportDataArrayData.manifestNoteDocumentDateText);
                    objParam.Add("@manifestNoteNumber", ImportDataArrayData.manifestNoteNumber);
                    objParam.Add("@manifestNoteTypeName", ImportDataArrayData.manifestNoteTypeName);
                    objParam.Add("@manifestNoteUnderDcName", ImportDataArrayData.manifestNoteUnderDcName);
                    objParam.Add("@merchantName", ImportDataArrayData.merchantName);
                    objParam.Add("@paymentTypeName", ImportDataArrayData.paymentTypeName);
                    objParam.Add("@pointAddress", ImportDataArrayData.pointAddress);
                    objParam.Add("@pointCode", ImportDataArrayData.pointCode);
                    objParam.Add("@pointName", ImportDataArrayData.pointName);
                    objParam.Add("@productName", ImportDataArrayData.productName);
                    objParam.Add("@qty", ImportDataArrayData.qty);
                    objParam.Add("@qtyPics", ImportDataArrayData.qtyPics);
                    objParam.Add("@receiverAddress", ImportDataArrayData.receiverAddress);
                    objParam.Add("@receiverName", ImportDataArrayData.receiverName);
                    objParam.Add("@routeLineName", ImportDataArrayData.routeLineName);
                    objParam.Add("@senderAddress", ImportDataArrayData.senderAddress);
                    objParam.Add("@senderName", ImportDataArrayData.senderName);
                    objParam.Add("@shippingNoteDate", ImportDataArrayData.shippingNoteDate);
                    objParam.Add("@shippingNoteDateText", ImportDataArrayData.shippingNoteDateText);
                    objParam.Add("@shippingNoteNumber", ImportDataArrayData.shippingNoteNumber);
                    objParam.Add("@startDeliveryDate", ImportDataArrayData.startDeliveryDate);
                    objParam.Add("@startDeliveryDateText", ImportDataArrayData.startDeliveryDateText);
                    objParam.Add("@underDistributionCenterId", ImportDataArrayData.underDistributionCenterId);
                    objParam.Add("@vehicleLicensePlate", ImportDataArrayData.vehicleLicensePlate);
                    objParam.Add("@volume", ImportDataArrayData.volume);
                    objParam.Add("@weight", ImportDataArrayData.weight);
                    objParam.Add("@ref_id", ImportDataArrayData.ref_id);
                    objParam.Add("@last_updatetime", ImportDataArrayData.last_updatetime);
                    objParam.Add("closeJobDate", ImportDataArrayData.closeJobDate);
                    objParam.Add("closeJobDateText", ImportDataArrayData.closeJobDateText);
                    objParam.Add("latitudeEndMile", ImportDataArrayData.latitudeEndMile);
                    objParam.Add("latitudeStartMile", ImportDataArrayData.latitudeStartMile);
                    objParam.Add("longitudeEndMile", ImportDataArrayData.longitudeEndMile);
                    objParam.Add("longitudeStartMile", ImportDataArrayData.longitudeStartMile);
                    objParam.Add("openJobDate", ImportDataArrayData.openJobDate);
                    objParam.Add("openJobDateText", ImportDataArrayData.openJobDateText);


                    VSK_TRP.Execute("SP_MM_Shipmentdaily_Sync", objParam, commandTimeout: 600, commandType: CommandType.StoredProcedure);

                }

                VSK_TRP.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<MM_ShipmentDailyModel> MM_Shipmentdaily_Sync_Get(MM_ShipmentDailyModel MM_ShipmentDailyModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@job_date", MM_ShipmentDailyModel.job_date);

                Connection();
                VSK_TRP.Open();
                List<MM_ShipmentDailyModel> PckList = SqlMapper.Query<MM_ShipmentDailyModel>(VSK_TRP, "SP_MM_Shipmentdaily_Sync_Get", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();
                VSK_TRP.Close();
                return PckList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }


        //public IList<MM_ShippingNoteBookingModel> MM_ShippingNoteBR_Get(string NUMBER, string ROUTE, string DRIVER, string CREATE_BY)
        //{
        //    try
        //    {

        //        DynamicParameters objParam = new DynamicParameters();

        //        objParam.Add("@NUMBER", NUMBER);
        //        objParam.Add("@ROUTE", ROUTE);
        //        objParam.Add("@Driver", DRIVER);
        //        objParam.Add("@CREATE_BY", CREATE_BY);

        //        Connection();
        //        VSK_TRP.Open();
        //        IList<MM_ShippingNoteBookingModel> MM_ShippingNoteBooking_List = VSK_TRP.Query<MM_ShippingNoteBookingModel>("SP_MM_ShippingNoteBookingBike_Get", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();
        //        VSK_TRP.Close();
        //        return MM_ShippingNoteBooking_List.ToList();

        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //}

        public IList<MM_ProductListModel> MM_ProductBR_Get(string NUMBER, string shippingNoteResCode, string CREATE_BY)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@NUMBER", NUMBER);
                objParam.Add("@shippingNoteResCode", shippingNoteResCode);
                objParam.Add("@CREATE_BY", CREATE_BY);

                Connection();
                VSK_TRP.Open();
                IList<MM_ProductListModel> MM_ProductList_List = VSK_TRP.Query<MM_ProductListModel>("SP_MM_ProductBR_Get", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();
                VSK_TRP.Close();
                return MM_ProductList_List.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<MM_ProductListModel> MM_ProductBRMulit_Get(string NUMBER, string REF_ID, string CREATE_BY)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@NUMBER", NUMBER);
                objParam.Add("@REF_ID", REF_ID);
                objParam.Add("@CREATE_BY", CREATE_BY);

                Connection();
                VSK_TRP.Open();
                IList<MM_ProductListModel> MM_ProductList_List = VSK_TRP.Query<MM_ProductListModel>("SP_MM_ProductBR_Mulit_Get", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();
                VSK_TRP.Close();
                return MM_ProductList_List.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IList<MM_ShippingNoteBookingModel> MM_ShippingNoteBR_Get(string REF_ID, string NUMBER, string ROUTE, string DRIVER, string CREATE_BY)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@REF_ID", REF_ID);
                objParam.Add("@NUMBER", NUMBER);
                objParam.Add("@ROUTE", ROUTE);
                objParam.Add("@Driver", DRIVER);
                objParam.Add("@CREATE_BY", CREATE_BY);

                Connection();
                VSK_TRP.Open();
                IList<MM_ShippingNoteBookingModel> MM_ShippingNoteBooking_List = VSK_TRP.Query<MM_ShippingNoteBookingModel>("SP_MM_ShippingNoteBR_Get", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();
                VSK_TRP.Close();
                return MM_ShippingNoteBooking_List.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public IList<MM_ProductListModel> MM_ProductP_Get(string NUMBER, string shippingNoteResCode, string CREATE_BY)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@NUMBER", NUMBER);
                objParam.Add("@shippingNoteResCode", shippingNoteResCode);
                objParam.Add("@CREATE_BY", CREATE_BY);

                Connection();
                VSK_TRP.Open();
                IList<MM_ProductListModel> MM_ProductList_List = VSK_TRP.Query<MM_ProductListModel>("SP_MM_ProductP_Get", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();
                VSK_TRP.Close();
                return MM_ProductList_List.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IList<MM_ShippingNoteBookingModel> MM_ShippingNoteP_Get(string REF_ID, string NUMBER, string ROUTE, string DRIVER, string CREATE_BY)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@REF_ID", REF_ID);
                objParam.Add("@NUMBER", NUMBER);
                objParam.Add("@ROUTE", ROUTE);
                objParam.Add("@Driver", DRIVER);
                objParam.Add("@CREATE_BY", CREATE_BY);

                Connection();
                VSK_TRP.Open();
                IList<MM_ShippingNoteBookingModel> MM_ShippingNoteBooking_List = VSK_TRP.Query<MM_ShippingNoteBookingModel>("SP_MM_ShippingNoteP_Get", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();
                VSK_TRP.Close();
                return MM_ShippingNoteBooking_List.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<MM_ProductListModel> MM_ProductPMulit_Get(string NUMBER, string REF_ID, string CREATE_BY)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@NUMBER", NUMBER);
                objParam.Add("@REF_ID", REF_ID);
                objParam.Add("@CREATE_BY", CREATE_BY);

                Connection();
                VSK_TRP.Open();
                IList<MM_ProductListModel> MM_ProductList_List = VSK_TRP.Query<MM_ProductListModel>("SP_MM_ProductP_Mulit_Get", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();
                VSK_TRP.Close();
                return MM_ProductList_List.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public List<MM_ProductListModel> MM_ProductRefMulit_Get(string NUMBER, string REF_ID, string CREATE_BY)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@NUMBER", NUMBER);
                objParam.Add("@REF_ID", REF_ID);
                objParam.Add("@CREATE_BY", CREATE_BY);

                Connection();
                VSK_TRP.Open();
                IList<MM_ProductListModel> MM_ProductList_List = VSK_TRP.Query<MM_ProductListModel>("SP_MM_ProductRef_Mulit_Get", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();
                VSK_TRP.Close();
                return MM_ProductList_List.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IList<MM_ProductListModel> MM_ProductRef_Get(string NUMBER, string shippingNoteResCode, string CREATE_BY)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@NUMBER", NUMBER);
                objParam.Add("@shippingNoteResCode", shippingNoteResCode);
                objParam.Add("@CREATE_BY", CREATE_BY);

                Connection();
                VSK_TRP.Open();
                IList<MM_ProductListModel> MM_ProductList_List = VSK_TRP.Query<MM_ProductListModel>("SP_MM_ProductRef_Get", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();
                VSK_TRP.Close();
                return MM_ProductList_List.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IList<MM_ShippingNoteBookingModel> MM_ShippingNoteRef_Get(string REF_ID, string NUMBER, string ROUTE, string DRIVER, string CREATE_BY)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@REF_ID", REF_ID);
                objParam.Add("@NUMBER", NUMBER);
                objParam.Add("@ROUTE", ROUTE);
                objParam.Add("@Driver", DRIVER);
                objParam.Add("@CREATE_BY", CREATE_BY);

                Connection();
                VSK_TRP.Open();
                IList<MM_ShippingNoteBookingModel> MM_ShippingNoteBooking_List = VSK_TRP.Query<MM_ShippingNoteBookingModel>("SP_MM_ShippingNoteRef_Get", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();
                VSK_TRP.Close();
                return MM_ShippingNoteBooking_List.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public List<MXInvModel> MX_DOCUMENT_CREATE(MXInvModel MXInvModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@ref_id", MXInvModel.ref_id);
                objParam.Add("@job_no", MXInvModel.job_no);
                objParam.Add("@inv_number", MXInvModel.inv_number);
                objParam.Add("@inv_date", MXInvModel.inv_date);
                objParam.Add("@inv_po", MXInvModel.inv_po);
                objParam.Add("@inv_code", MXInvModel.inv_code);
                objParam.Add("@inv_name", MXInvModel.inv_name);
                objParam.Add("@inv_item", MXInvModel.inv_item);
                objParam.Add("@inv_trans", MXInvModel.inv_trans);
                objParam.Add("@inv_due", MXInvModel.inv_due);
                objParam.Add("@inv_paycash", MXInvModel.inv_paycash);
                objParam.Add("@inv_paytran", MXInvModel.inv_paytran);
                objParam.Add("@inv_paycard", MXInvModel.inv_paycard);
                objParam.Add("@inv_payoth", MXInvModel.inv_payoth);
                objParam.Add("@inv_cod", MXInvModel.inv_cod);
                objParam.Add("@inv_sumtt", MXInvModel.inv_sumtt);
                objParam.Add("@inv_toption", MXInvModel.inv_toption);
                objParam.Add("@inv_descript", MXInvModel.inv_descript);
                objParam.Add("@inv_startdate", MXInvModel.inv_startdate);
                objParam.Add("@inv_kline", MXInvModel.inv_kline);
                objParam.Add("@inv_branch", MXInvModel.inv_branch);
                objParam.Add("@inv_custpo", MXInvModel.inv_custpo);
                objParam.Add("@inv_userid", MXInvModel.inv_userid);
                objParam.Add("@inv_pkuser", MXInvModel.inv_pkuser);
                objParam.Add("@created_by", MXInvModel.created_by);

                objParam.Add("@inv_address_name", MXInvModel.inv_address_name);
                objParam.Add("@inv_delivery_address", MXInvModel.inv_delivery_address);
                objParam.Add("@inv_delivery_evcode", MXInvModel.inv_delivery_evcode);
                objParam.Add("@inv_delivery_evname", MXInvModel.inv_delivery_evname);
                objParam.Add("@inv_delivery_evadd", MXInvModel.inv_delivery_evadd);
                objParam.Add("@inv_delivery_evtel", MXInvModel.inv_delivery_evtel);
                objParam.Add("@inv_eaddress", MXInvModel.inv_eaddress);
                objParam.Add("@inv_elocation", MXInvModel.inv_elocation);
                objParam.Add("@location_branch", MXInvModel.location_branch);
                objParam.Add("@job_type", MXInvModel.job_type);

                Connection();
                VSK_TRP.Open();
                List<MXInvModel> PckList = SqlMapper.Query<MXInvModel>(VSK_TRP, "SP_MX_DOCUMENT_CREATE", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();
                VSK_TRP.Close();
                return PckList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public List<MXInvModel> MX_DOCUMENT_DELETE(MXInvModel MXInvModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@ref_id", MXInvModel.ref_id);
                objParam.Add("@inv_number", MXInvModel.inv_number);
                objParam.Add("@updated_by", MXInvModel.updated_by);

                Connection();
                VSK_TRP.Open();
                List<MXInvModel> PckList = SqlMapper.Query<MXInvModel>(VSK_TRP, "SP_MX_DOCUMENT_DELETE", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();
                VSK_TRP.Close();
                return PckList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public List<MXInvModel> MX_DOCUMENT_LIST(MXInvModel MXInvModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@ref_id", MXInvModel.ref_id);

                Connection();
                VSK_TRP.Open();
                List<MXInvModel> PckList = SqlMapper.Query<MXInvModel>(VSK_TRP, "SP_MX_DOCUMENT_LIST", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();
                VSK_TRP.Close();
                return PckList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public List<MXTimeModel> MX_DELIVERY_TIME_TACKING(MXTimeModel MXTimeModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@mode", MXTimeModel.mode);
                objParam.Add("@job_date", MXTimeModel.job_date);
                objParam.Add("@ref_id", MXTimeModel.ref_id);
                objParam.Add("@driver_id", MXTimeModel.driver_id);
                objParam.Add("@delivery_status", MXTimeModel.delivery_status);

                Connection();
                VSK_TRP.Open();
                List<MXTimeModel> PckList = SqlMapper.Query<MXTimeModel>(VSK_TRP, "SP_MX_DELIVERY_TIME_TACKING", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();
                VSK_TRP.Close();
                return PckList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public List<MM_ManifestNoteModel> MX_DELIVERY_TIME_TACKING_JOB(MM_ManifestNoteModel MM_ManifestNoteModel)
        {
            try
            {
                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@driver_id", MM_ManifestNoteModel.driver_id);
                objParam.Add("@job_date", MM_ManifestNoteModel.job_date);

                Connection();
                VSK_TRP.Open();
                List<MM_ManifestNoteModel> MM_LIST = SqlMapper.Query<MM_ManifestNoteModel>(VSK_TRP, "SP_MX_DELIVERY_TIME_TACKING_JOB", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();
                VSK_TRP.Close();

                return MM_LIST.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void MX_DOCUMENT_CREATE_LIST(List<MXInvModel> MXInvModel)
        {
            try
            {

                Connection();

                VSK_TRP.Open();

                foreach (var ImportDataArrayData in MXInvModel)
                {
                    DynamicParameters objParam = new DynamicParameters();

                    objParam.Add("@ref_id", ImportDataArrayData.ref_id);
                    objParam.Add("@job_no", ImportDataArrayData.job_no);
                    objParam.Add("@inv_number", ImportDataArrayData.inv_number);
                    objParam.Add("@inv_date", ImportDataArrayData.inv_date);
                    objParam.Add("@inv_po", ImportDataArrayData.inv_po);
                    objParam.Add("@inv_code", ImportDataArrayData.inv_code);
                    objParam.Add("@inv_name", ImportDataArrayData.inv_name);
                    objParam.Add("@inv_item", ImportDataArrayData.inv_item);
                    objParam.Add("@inv_trans", ImportDataArrayData.inv_trans);
                    objParam.Add("@inv_due", ImportDataArrayData.inv_due);
                    objParam.Add("@inv_paycash", ImportDataArrayData.inv_paycash);
                    objParam.Add("@inv_paytran", ImportDataArrayData.inv_paytran);
                    objParam.Add("@inv_paycard", ImportDataArrayData.inv_paycard);
                    objParam.Add("@inv_payoth", ImportDataArrayData.inv_payoth);
                    objParam.Add("@inv_cod", ImportDataArrayData.inv_cod);
                    objParam.Add("@inv_sumtt", ImportDataArrayData.inv_sumtt);
                    objParam.Add("@inv_toption", ImportDataArrayData.inv_toption);
                    objParam.Add("@inv_descript", ImportDataArrayData.inv_descript);
                    objParam.Add("@inv_startdate", ImportDataArrayData.inv_startdate);
                    objParam.Add("@inv_kline", ImportDataArrayData.inv_kline);
                    objParam.Add("@inv_branch", ImportDataArrayData.inv_branch);
                    objParam.Add("@inv_custpo", ImportDataArrayData.inv_custpo);
                    objParam.Add("@inv_userid", ImportDataArrayData.inv_userid);
                    objParam.Add("@inv_pkuser", ImportDataArrayData.inv_pkuser);
                    objParam.Add("@created_by", ImportDataArrayData.created_by);
                    objParam.Add("@inv_address_name", ImportDataArrayData.inv_address_name);
                    objParam.Add("@inv_delivery_address", ImportDataArrayData.inv_delivery_address);
                    objParam.Add("@inv_delivery_evcode", ImportDataArrayData.inv_delivery_evcode);
                    objParam.Add("@inv_delivery_evname", ImportDataArrayData.inv_delivery_evname);
                    objParam.Add("@inv_delivery_evadd", ImportDataArrayData.inv_delivery_evadd);
                    objParam.Add("@inv_delivery_evtel", ImportDataArrayData.inv_delivery_evtel);
                    objParam.Add("@inv_eaddress", ImportDataArrayData.inv_eaddress);
                    objParam.Add("@inv_elocation", ImportDataArrayData.inv_elocation);
                    objParam.Add("@location_branch", ImportDataArrayData.location_branch);
                    objParam.Add("@job_type", ImportDataArrayData.job_type);

                    VSK_TRP.Execute("SP_MX_DOCUMENT_CREATE_LIST", objParam, commandTimeout: 600, commandType: CommandType.StoredProcedure);

                }

                VSK_TRP.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<MM_ManifestNoteJobModel> MX_JOB_GET(MM_ManifestNoteJobModel MM_ManifestNoteJobModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@ref_id", MM_ManifestNoteJobModel.ref_id);

                Connection();
                VSK_TRP.Open();
                List<MM_ManifestNoteJobModel> PckList = SqlMapper.Query<MM_ManifestNoteJobModel>(VSK_TRP, "SP_MX_JOB_GET", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();
                VSK_TRP.Close();
                return PckList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public List<TackingDeliveryModel> PK_TO_DELIVERY_TACKING_MX(TackingDeliveryModel TackingDeliveryModel)
        {
            try
            {
                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@startdate", TackingDeliveryModel.startdate);
                objParam.Add("@enddate", TackingDeliveryModel.enddate);
                objParam.Add("@mode", TackingDeliveryModel.mode);
                objParam.Add("@em_number", TackingDeliveryModel.em_number);
                objParam.Add("@pk_number", TackingDeliveryModel.pk_number);
                objParam.Add("@iv_number", TackingDeliveryModel.iv_number);
                objParam.Add("@routeline", TackingDeliveryModel.routeline);
                objParam.Add("@vehicle", TackingDeliveryModel.vehicle);
                objParam.Add("@status", TackingDeliveryModel.status);
                objParam.Add("@driver", TackingDeliveryModel.driver);
                objParam.Add("@manifestNoteNumber", TackingDeliveryModel.manifestNoteNumber);
                objParam.Add("@shippingNoteNumber", TackingDeliveryModel.shippingNoteNumber);
                objParam.Add("@job_type", TackingDeliveryModel.job_type);

                Connection();
                VSK_TRP.Open();
                List<TackingDeliveryModel> MM_LIST = SqlMapper.Query<TackingDeliveryModel>(VSK_TRP, "RPT_PK_TO_DELIVERY_TACKING_MX", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();
                VSK_TRP.Close();

                return MM_LIST.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<MM_ManifestNoteModel> MX_DELIVERY_TRACKING_ONL(MM_ManifestNoteModel MM_ManifestNoteModel)
        {
            try
            {
                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@job_start_date", MM_ManifestNoteModel.job_start_date);
                objParam.Add("@job_end_date", MM_ManifestNoteModel.job_end_date);
                objParam.Add("@p_code", MM_ManifestNoteModel.p_code);
                objParam.Add("@f_endRouteLineCode", MM_ManifestNoteModel.f_endRouteLineCode);
                objParam.Add("@f_driverCode", MM_ManifestNoteModel.f_driverCode);
                objParam.Add("@f_vehicleCode", MM_ManifestNoteModel.f_vehicleCode);
                objParam.Add("@f_receiver_code", MM_ManifestNoteModel.f_receiver_code);
                objParam.Add("@manifestNoteNumber", MM_ManifestNoteModel.manifestNoteNumber);
                objParam.Add("@shippingNoteNumber", MM_ManifestNoteModel.shippingNoteNumber);
                objParam.Add("@currentStatus", MM_ManifestNoteModel.currentStatus);
                objParam.Add("@p_orderNo", MM_ManifestNoteModel.p_orderNo);
                objParam.Add("@p_packageNo", MM_ManifestNoteModel.p_packageNo);
                objParam.Add("@job_type", MM_ManifestNoteModel.job_type);

                Connection();
                VSK_TRP.Open();
                List<MM_ManifestNoteModel> MM_LIST = SqlMapper.Query<MM_ManifestNoteModel>(VSK_TRP, "SP_MX_DELIVERY_TRACKING_ONL", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();
                VSK_TRP.Close();

                return MM_LIST.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}