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
    public class CustomerMasterRepository
    {

        #region Connection_SQL Server
        //-------------------Start Connection_SQL ------------------------//
        public SqlConnection MIS_SERVICE;
        public SqlConnection VSK_Data;

        private void Connection()
        {
            string STR_MIS_SERVICE = ConfigurationManager.ConnectionStrings["MIS_SERVICE"].ToString();
            MIS_SERVICE = new SqlConnection(STR_MIS_SERVICE);

            string STR_VSK_Data = ConfigurationManager.ConnectionStrings["VSK_Data"].ToString();
            VSK_Data = new SqlConnection(STR_VSK_Data);
        }
        //-------------------End Connection_SQL ------------------------//
        #endregion

        public List<MasterDataCustomerModel> MasterDataCustomer(string mode)
        {
            try
            {
                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@mode", mode);

                Connection();
                VSK_Data.Open();
                List<MasterDataCustomerModel> List = SqlMapper.Query<MasterDataCustomerModel>(VSK_Data, "SP_MasterData_CustomerProfile", objParam, commandType: CommandType.StoredProcedure).ToList();
                VSK_Data.Close();
                return List.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<CustomerModel> CustomerMaster_List(CustomerModel CustomerModel)
        {

            try
            {
                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@salechannel", CustomerModel.salechannel);

                Connection();
                VSK_Data.Open();
                List<CustomerModel> CustomerMaster_List_Get = SqlMapper.Query<CustomerModel>(VSK_Data, "SP_Customer_Profile_List", objParam, commandType: CommandType.StoredProcedure).ToList();
                VSK_Data.Close();
                return CustomerMaster_List_Get.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public List<CustomerModel> CustomerMaster_Detail(string code)
        {
            try
            {
                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@code", code);

                Connection();
                VSK_Data.Open();
                List<CustomerModel> RequestModelList = SqlMapper.Query<CustomerModel>(VSK_Data, "SP_Customer_Profile_Detail", objParam, commandType: CommandType.StoredProcedure).ToList();
                VSK_Data.Close();
                return RequestModelList.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<CustomerModel> CustomerMaster_Update(CustomerModel CustomerModel)
        {
            try
            {
                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@temp_id", CustomerModel.temp_id);
                objParam.Add("@code", CustomerModel.code);
                objParam.Add("@year", CustomerModel.year);
                objParam.Add("@M01", CustomerModel.M01);
                objParam.Add("@M02", CustomerModel.M02);
                objParam.Add("@M03", CustomerModel.M03);
                objParam.Add("@M04", CustomerModel.M04);
                objParam.Add("@M05", CustomerModel.M05);
                objParam.Add("@M06", CustomerModel.M06);
                objParam.Add("@M07", CustomerModel.M07);
                objParam.Add("@M08", CustomerModel.M08);
                objParam.Add("@M09", CustomerModel.M09);
                objParam.Add("@M10", CustomerModel.M10);
                objParam.Add("@M11", CustomerModel.M11);
                objParam.Add("@M12", CustomerModel.M12);
                objParam.Add("@created_by", CustomerModel.created_by);

                Connection();
                VSK_Data.Open();
                List<CustomerModel> ImportUpdateData = SqlMapper.Query<CustomerModel>(VSK_Data, "SP_Customer_Profile_Update", objParam, commandTimeout: 600, commandType: CommandType.StoredProcedure).ToList();
                VSK_Data.Close();
                return ImportUpdateData.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}