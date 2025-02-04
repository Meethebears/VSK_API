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
    public class ItemMasterRepository
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

        public List<StmasModel> Stmas_Get(string item_code)
        {
            try
            {
                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@item_code", item_code);
                
                Connection();
                MIS_SERVICE.Open();
                List<StmasModel> RequestModelList = SqlMapper.Query<StmasModel>(MIS_SERVICE, "SP_Stmas_Get", objParam, commandType: CommandType.StoredProcedure).ToList();
                MIS_SERVICE.Close();
                return RequestModelList.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<StmasModel> Stmas_Search(string item_code, string item_name, string item_CHRCODE, string item_SPCODES, string item_gbarcode, string mode)
        {
            try
            {
                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@item_code", item_code);
                objParam.Add("@item_name", item_name);
                objParam.Add("@item_CHRCODE", item_CHRCODE);
                objParam.Add("@item_SPCODES", item_SPCODES);
                objParam.Add("@item_gbarcode", item_gbarcode);
                objParam.Add("@mode", mode);

                Connection();
                MIS_SERVICE.Open();
                List<StmasModel> RequestModelList = SqlMapper.Query<StmasModel>(MIS_SERVICE, "SP_Stmas_Search", objParam, commandType: CommandType.StoredProcedure).ToList();
                MIS_SERVICE.Close();
                return RequestModelList.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<GcodeModel> Gcode_Get(GcodeModel GcodeModel) {

            try
            {
                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@code", GcodeModel.code);
                objParam.Add("@gname", GcodeModel.gname);
                objParam.Add("@codechr", GcodeModel.codechr);
                objParam.Add("@ctype", GcodeModel.ctype);

                Connection();
                MIS_SERVICE.Open();
                List<GcodeModel> RequestModelList = SqlMapper.Query<GcodeModel>(MIS_SERVICE, "SP_Gcode_Get", objParam, commandType: CommandType.StoredProcedure).ToList();
                MIS_SERVICE.Close();
                return RequestModelList.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public List<Product_PurPlan_Stock_FactorModel> Product_PurPlan_Stock_Factor_Get(string item_code) {

            try
            {

                string SQLQuery = "SELECT TOP 1 * FROM Product_PurPlan_Stock_Factor$ WHERE code = '"+item_code+"'";

                Connection();
                VSK_Data.Open();
                List<Product_PurPlan_Stock_FactorModel> RequestModelList = VSK_Data.Query<Product_PurPlan_Stock_FactorModel>(SQLQuery).ToList();
                VSK_Data.Close();
                return RequestModelList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public List<Product_PurPlan_Stock_FactorModel_v2> Product_PurPlan_Stock_Factor_Get_v2(string item_code)
        {

            try
            {

                string SQLQuery = "SELECT TOP 1 * FROM Product_PurPlan_Stock_Factor$ WHERE code = '" + item_code + "'";

                Connection();
                VSK_Data.Open();
                List<Product_PurPlan_Stock_FactorModel_v2> RequestModelList = VSK_Data.Query<Product_PurPlan_Stock_FactorModel_v2>(SQLQuery).ToList();
                VSK_Data.Close();
                return RequestModelList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public List<GoodpriceModel> Goodprice_Get(string item_code, string item_gbarcode)
        {
            try
            {
                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@item_code", item_code);
                objParam.Add("@item_gbarcode", item_gbarcode);

                Connection();
                MIS_SERVICE.Open();
                List<GoodpriceModel> RequestModelList = SqlMapper.Query<GoodpriceModel>(MIS_SERVICE, "SP_Goodprice_Get", objParam, commandType: CommandType.StoredProcedure).ToList();
                MIS_SERVICE.Close();
                return RequestModelList.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<GlocatModel> Glocat_get(string wh_code)
        {
            try
            {
                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@wh_code", wh_code);

                Connection();
                MIS_SERVICE.Open();
                List<GlocatModel> RequestModelList = SqlMapper.Query<GlocatModel>(MIS_SERVICE, "SP_Glocat_Get", objParam, commandType: CommandType.StoredProcedure).ToList();
                MIS_SERVICE.Close();
                return RequestModelList.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<UomModel> Uom_get(string uom_code)
        {
            try
            {
                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@uom_code", uom_code);

                Connection();
                MIS_SERVICE.Open();
                List<UomModel> RequestModelList = SqlMapper.Query<UomModel>(MIS_SERVICE, "SP_Uom_Get", objParam, commandType: CommandType.StoredProcedure).ToList();
                MIS_SERVICE.Close();
                return RequestModelList.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<ResponseSelect2Model> Gcode_Select2_Get(GcodeModel GcodeModel)
        {

            try
            {
                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@code", GcodeModel.code);
                objParam.Add("@gname", GcodeModel.gname);
                objParam.Add("@codechr", GcodeModel.codechr);
                objParam.Add("@ctype", GcodeModel.ctype);

                Connection();
                MIS_SERVICE.Open();
                List<ResponseSelect2Model> RequestModelList = SqlMapper.Query<ResponseSelect2Model>(MIS_SERVICE, "SP_Gcode_Select2_Get", objParam, commandType: CommandType.StoredProcedure).ToList();
                MIS_SERVICE.Close();
                return RequestModelList.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

    }
}