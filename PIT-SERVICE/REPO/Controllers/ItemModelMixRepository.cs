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
    public class ItemModelMixRepository
    {

        #region Connection_SQL Server
        //-------------------Start Connection_SQL ------------------------//

        public SqlConnection VSK_PIT;
        public SqlConnection VSK_DATA;
        public SqlConnection VSK_VORSWIN;
        public SqlConnection VSK_VSKMIS;

        private void Connection()
        {

            VSK_PIT = new SqlConnection(ConfigurationManager.ConnectionStrings["VSK_PIT_187"].ToString());
            VSK_DATA = new SqlConnection(ConfigurationManager.ConnectionStrings["VSK_DATA_186"].ToString());
            VSK_VORSWIN = new SqlConnection(ConfigurationManager.ConnectionStrings["VSK_VORSWIN_249"].ToString());
            VSK_VSKMIS = new SqlConnection(ConfigurationManager.ConnectionStrings["VSK_VSKMIS_249"].ToString());

        }

        //-------------------End Connection_SQL ------------------------//
        #endregion


        #region Item_ModelMix_ItemLastUpdatetime_Get
        public List<TempItemModelMixModel> Item_ModelMix_ItemLastUpdatetime_Get(TempItemModelMixModel TempItemModelMixModelv)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                Connection();
                VSK_PIT.Open();
                List<TempItemModelMixModel> datalist = SqlMapper.Query<TempItemModelMixModel>(VSK_PIT, "SP_Item_ModelMix_ItemLastUpdatetime_Get", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();
                VSK_PIT.Close();

                return datalist.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        #endregion

        #region Item_ModelMix_ProductGroupSales_Get
        public List<TempItemModelMixModel> Item_ModelMix_ProductGroupSales_Get(TempItemModelMixModel TempItemModelMixModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                Connection();
                VSK_PIT.Open();
                List<TempItemModelMixModel> datalist = SqlMapper.Query<TempItemModelMixModel>(VSK_PIT, "SP_Item_ModelMix_ProductGroupSales_Get", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();
                VSK_PIT.Close();

                return datalist.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        #endregion

        #region Item_ModelMix_KeywordsSearchItem_Get
        public List<ItemModelMixModel> Item_ModelMix_KeywordsSearchItem_Get(ItemModelMixModel ItemModelMixModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@keywords", ItemModelMixModel.keywords);
                objParam.Add("@vehicle_brand", ItemModelMixModel.vehicle_brand);
                objParam.Add("@vehicle_segments", ItemModelMixModel.vehicle_segments);
                objParam.Add("@vehicle_model", ItemModelMixModel.vehicle_model);
                objParam.Add("@minor_change", ItemModelMixModel.minor_change);
                objParam.Add("@model_change", ItemModelMixModel.model_change);
                objParam.Add("@fuel_type", ItemModelMixModel.fuel_type);
                objParam.Add("@engine_displacement", ItemModelMixModel.engine_displacement);
                objParam.Add("@engine_code", ItemModelMixModel.engine_code);
                objParam.Add("@transmission_type", ItemModelMixModel.transmission_type);
                objParam.Add("@body_type", ItemModelMixModel.body_type);
                objParam.Add("@hign_stant", ItemModelMixModel.hign_stant);
                objParam.Add("@wheel_drive", ItemModelMixModel.wheel_drive);
                objParam.Add("@street_name", ItemModelMixModel.street_name);
               
                objParam.Add("@product_division", ItemModelMixModel.product_division);
                objParam.Add("@main_category", ItemModelMixModel.main_category);
                objParam.Add("@sub_category", ItemModelMixModel.sub_category);

                objParam.Add("@wheel", ItemModelMixModel.wheel);
                objParam.Add("@chassis_model", ItemModelMixModel.chassis_model);
                objParam.Add("@horsepower", ItemModelMixModel.horsepower);

                Connection();
                VSK_PIT.Open();
                List<ItemModelMixModel> datalist = SqlMapper.Query<ItemModelMixModel>(VSK_PIT, "SP_Item_ModelMix_KeywordsSearchItem_Get", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();
                VSK_PIT.Close();

                return datalist.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        #endregion

        #region Item_ModelMix_KeywordsSearchItem_Muti_Get
        public List<ItemModelMixModel> Item_ModelMix_KeywordsSearchItem_Muti_Get(ItemModelMixModel ItemModelMixModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@keywords", ItemModelMixModel.keywords);
                objParam.Add("@mode", ItemModelMixModel.keywords);
                objParam.Add("@vehicle_brand", ItemModelMixModel.vehicle_brand);
                objParam.Add("@vehicle_segments", ItemModelMixModel.vehicle_segments);
                objParam.Add("@vehicle_model", ItemModelMixModel.vehicle_model);
                objParam.Add("@minor_change", ItemModelMixModel.minor_change);
                objParam.Add("@model_change", ItemModelMixModel.model_change);
                objParam.Add("@fuel_type", ItemModelMixModel.fuel_type);
                objParam.Add("@engine_displacement", ItemModelMixModel.engine_displacement);
                objParam.Add("@engine_code", ItemModelMixModel.engine_code);
                objParam.Add("@transmission_type", ItemModelMixModel.transmission_type);
                objParam.Add("@body_type", ItemModelMixModel.body_type);
                objParam.Add("@hign_stant", ItemModelMixModel.hign_stant);
                objParam.Add("@wheel_drive", ItemModelMixModel.wheel_drive);
                objParam.Add("@street_name", ItemModelMixModel.street_name);

                objParam.Add("@product_division", ItemModelMixModel.product_division);
                objParam.Add("@main_category", ItemModelMixModel.main_category);
                objParam.Add("@sub_category", ItemModelMixModel.sub_category);

                objParam.Add("@wheel", ItemModelMixModel.wheel);
                objParam.Add("@chassis_model", ItemModelMixModel.chassis_model);
                objParam.Add("@horsepower", ItemModelMixModel.horsepower);

                objParam.Add("@gnamechr", ItemModelMixModel.gnamechr);
                objParam.Add("@goem", ItemModelMixModel.goem);
                objParam.Add("@type", ItemModelMixModel.type);
                objParam.Add("@gmodel", ItemModelMixModel.gmodel);
                objParam.Add("@gused", ItemModelMixModel.gused);

                objParam.Add("@pages", ItemModelMixModel.pages);
                objParam.Add("@show", ItemModelMixModel.show);

                Connection();
                VSK_PIT.Open();
                List<ItemModelMixModel> datalist = SqlMapper.Query<ItemModelMixModel>(VSK_PIT, "SP_Item_ModelMix_KeywordsSearchItem_Muti_Get", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();
                VSK_PIT.Close();

                return datalist.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        #endregion

    }
}