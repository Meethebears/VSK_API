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
    public class ItemMasterRepository
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

        #region STMAS_GET
        public List<StmasModel> STMAS_GET(string keywords)
        {
            try
            {
                Connection();

                List<StmasModel> _ResponseData;

                string SQLQuery = "";

                VSK_VORSWIN.Open();

                SQLQuery = "SELECT TOP 10 * FROM dbo.stmas WHERE '" + keywords + "' != '' AND  (RTRIM(gbarcode) LIKE '%" + keywords + "%' OR RTRIM(name) LIKE '%" + keywords + "%' OR RTRIM(code) LIKE '%" + keywords + "%' OR RTRIM(SPCODES) LIKE '%" + keywords + "%' OR RTRIM(CHRCODE) LIKE '%" + keywords + "%')";

                _ResponseData = VSK_VORSWIN.Query<StmasModel>(SQLQuery).ToList();
                VSK_VORSWIN.Close();
                return _ResponseData.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        #endregion

        #region GLB_VEHICLE_CODE5_GET
        public List<GLB_Vehicle_Code5Model> GLB_VEHICLE_CODE5_GET(string keywords)
        {
            try
            {
                Connection();

                List<GLB_Vehicle_Code5Model> _ResponseData;

                string SQLQuery = "";

                VSK_DATA.Open();

                SQLQuery = "SELECT TOP 1 * FROM dbo.glb_vehicle_code5 WHERE RTRIM(c5_code) = RTRIM('" + keywords+"')";

                _ResponseData = VSK_DATA.Query<GLB_Vehicle_Code5Model>(SQLQuery).ToList();
                VSK_DATA.Close();
                return _ResponseData.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        #endregion

        #region GCODE_GET
        public List<Item_masterModel> GCODE_KEYWORDS_GET(string ctype, string keywords)
        {
            try
            {
                string SQLQuery ;

                if (ctype == "gcode_a")
                {
                    SQLQuery = "SELECT TOP 10 * FROM dbo." + ctype + " WHERE '" + keywords + "' != ''  AND (RTRIM(code) LIKE '%" + keywords + "%' OR RTRIM(codechr) LIKE '%" + keywords + "%' OR RTRIM(gname) LIKE '%" + keywords + "%')";
                }
                else
                {
                    SQLQuery = "SELECT TOP 10 * FROM dbo." + ctype + " WHERE '" + keywords + "' != ''  AND (RTRIM(code) LIKE '%" + keywords + "%' OR RTRIM(gname) LIKE '%" + keywords + "%')";
                }

                Connection();
                VSK_VORSWIN.Open();
                List<Item_masterModel> MasList = VSK_VORSWIN.Query<Item_masterModel>(SQLQuery).ToList();
                VSK_VORSWIN.Close();
                return MasList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        #endregion

        #region ITEMMASTER_SREARCH
        public List<Item_masterModel> ITEMMASTER_SREARCH(string id, string text, string keywords)
        {
            try
            {

                List<Item_masterModel> MasListData = new List<Item_masterModel>();
                List<Item_masterModel> MasList;

                string SQLQuery1 = "SELECT TOP 10 " + id + " AS id, " + text + " as text FROM dbo.stmas WHERE '" + keywords + "' != '' AND  (RTRIM(gbarcode) LIKE '%" + keywords + "%' OR RTRIM(name) LIKE '%" + keywords + "%' OR RTRIM(code) LIKE '%" + keywords + "%' OR RTRIM(SPCODES) LIKE '%" + keywords + "%' OR RTRIM(CHRCODE) LIKE '%" + keywords + "%')";
                string SQLQuery2 = "SELECT TOP 10 " + id + " AS id, " + text + " as text FROM dbo.stmas_exp WHERE '" + keywords + "' != '' AND  (RTRIM(gbarcode) LIKE '%" + keywords + "%' OR RTRIM(name) LIKE '%" + keywords + "%' OR RTRIM(code) LIKE '%" + keywords + "%' OR RTRIM(SPCODES) LIKE '%" + keywords + "%' OR RTRIM(CHRCODE) LIKE '%" + keywords + "%')";

                Connection();
                VSK_VORSWIN.Open();

                MasList = VSK_VORSWIN.Query<Item_masterModel>(SQLQuery1).ToList();
                MasListData.AddRange(MasList);

                MasList = VSK_VORSWIN.Query<Item_masterModel>(SQLQuery2).ToList();
                MasListData.AddRange(MasList);

                VSK_VORSWIN.Close();
                return MasListData.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        #endregion

        #region STMAS_EXP_LIST
        public List<StmasModel> STMAS_EXP_LIST(StmasModel StmasModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@code", StmasModel.code);

                Connection();
                VSK_PIT.Open();
                List<StmasModel> mas_list = SqlMapper.Query<StmasModel>(VSK_PIT, "SP_STMAS_EXP_LIST", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();
                VSK_PIT.Close();

                return mas_list.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        #endregion

        #region STMAS_EXP_IMPORT_CREATE
        public void STMAS_EXP_IMPORT_CREATE(List<Temp_Stmas_ExpModel> Temp_Stmas_ExpModel)
        {
            try
            {

                Connection();

                VSK_PIT.Open();

                foreach (var ImportDataArrayData in Temp_Stmas_ExpModel)
                {
                    DynamicParameters objParam = new DynamicParameters();

                    objParam.Add("ref_id", ImportDataArrayData.ref_id);
                    objParam.Add("code_sm", ImportDataArrayData.code_sm);
                    //objParam.Add("name_sm", ImportDataArrayData.name_sm);
                    objParam.Add("code_sm_e", ImportDataArrayData.code_sm_e);
                    //objParam.Add("name_sm_e", ImportDataArrayData.name_sm_e);
                    objParam.Add("code_a", ImportDataArrayData.code_a);
                    objParam.Add("code_e", ImportDataArrayData.code_e);
                    objParam.Add("code_c", ImportDataArrayData.code_c);
                    objParam.Add("code_b", ImportDataArrayData.code_b);
                    objParam.Add("code_d", ImportDataArrayData.code_d);
                    objParam.Add("name_sm_compare", ImportDataArrayData.name_sm_compare);
                    objParam.Add("name_sm_e_compare", ImportDataArrayData.name_sm_e_compare);
                    //objParam.Add("carbrand", ImportDataArrayData.carbrand);
                    //objParam.Add("carmodel", ImportDataArrayData.carmodel);
                    objParam.Add("cartype", ImportDataArrayData.cartype);
                    //objParam.Add("carFmyear", ImportDataArrayData.carFmyear);
                    //objParam.Add("carToyear", ImportDataArrayData.carToyear);
                    //objParam.Add("carGeneration", ImportDataArrayData.carGeneration);
                    objParam.Add("UsagePerCar", ImportDataArrayData.UsagePerCar);
                    objParam.Add("gdescript", ImportDataArrayData.gdescript);
                    objParam.Add("action_type", ImportDataArrayData.action_type);
                    objParam.Add("created_by", ImportDataArrayData.created_by);

                    VSK_PIT.Execute("SP_STMAS_EXP_IMPORT_CREATE", objParam, commandTimeout: 600, commandType: CommandType.StoredProcedure);

                }

                VSK_PIT.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region STMAS_EXP_IMPORT_VERIFY
        public List<Temp_Stmas_ExpModel> STMAS_EXP_IMPORT_VERIFY(Temp_Stmas_ExpModel Temp_Stmas_ExpModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@ref_id", Temp_Stmas_ExpModel.ref_id);

                Connection();
                VSK_PIT.Open();
                List<Temp_Stmas_ExpModel> mas_list = SqlMapper.Query<Temp_Stmas_ExpModel>(VSK_PIT, "SP_STMAS_EXP_IMPORT_VERIFY", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();
                VSK_PIT.Close();

                return mas_list.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region STMAS_EXP_IMPORT_GET
        public List<Temp_Stmas_ExpModel> STMAS_EXP_IMPORT_GET(Temp_Stmas_ExpModel Temp_Stmas_ExpModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@ref_id", Temp_Stmas_ExpModel.ref_id);

                Connection();
                VSK_PIT.Open();
                List<Temp_Stmas_ExpModel> mas_list = SqlMapper.Query<Temp_Stmas_ExpModel>(VSK_PIT, "SP_STMAS_EXP_IMPORT_GET", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();
                VSK_PIT.Close();

                return mas_list.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region STMAS_EXP_IMPORT_UPDATE
        public List<Temp_Stmas_ExpModel> STMAS_EXP_IMPORT_UPDATE(Temp_Stmas_ExpModel Temp_Stmas_ExpModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@ref_id", Temp_Stmas_ExpModel.ref_id);
                objParam.Add("@updated_by", Temp_Stmas_ExpModel.updated_by);

                Connection();
                VSK_PIT.Open();
                List<Temp_Stmas_ExpModel> mas_list = SqlMapper.Query<Temp_Stmas_ExpModel>(VSK_PIT, "SP_STMAS_EXP_IMPORT_UPDATE", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();
                VSK_PIT.Close();

                return mas_list.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region STMAS_EXP_IMPORT_UPLOAD
        public List<Temp_Stmas_ExpModel> STMAS_EXP_IMPORT_UPLOAD(Temp_Stmas_ExpModel Temp_Stmas_ExpModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@ref_id", Temp_Stmas_ExpModel.ref_id);
                objParam.Add("@updated_by", Temp_Stmas_ExpModel.updated_by);

                Connection();
                VSK_VSKMIS.Open();
                List<Temp_Stmas_ExpModel> mas_list = SqlMapper.Query<Temp_Stmas_ExpModel>(VSK_VSKMIS, "SP_STMAS_EXP_IMPORT_UPLOAD", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();
                VSK_VSKMIS.Close();

                return mas_list.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion


        #region STMAS_IMPORT_CREATE
        public void STMAS_IMPORT_CREATE(List<Temp_Stmas_Model> Temp_Stmas_Model)
        {
            try
            {

                Connection();

                VSK_PIT.Open();

                foreach (var ImportDataArrayData in Temp_Stmas_Model)
                {
                    DynamicParameters objParam = new DynamicParameters();

                    objParam.Add("ref_id", ImportDataArrayData.ref_id);
                    objParam.Add("item_no", ImportDataArrayData.item_no);
                    objParam.Add("item_barcode", ImportDataArrayData.item_barcode);
                    objParam.Add("item_spcodes", ImportDataArrayData.item_spcodes);
                    objParam.Add("code_a_name", ImportDataArrayData.code_a_name);
                    objParam.Add("code_e_name", ImportDataArrayData.code_e_name);
                    objParam.Add("code_c_name", ImportDataArrayData.code_c_name);
                    objParam.Add("code_b_name", ImportDataArrayData.code_b_name);
                    objParam.Add("code_d_name", ImportDataArrayData.code_d_name);
                    objParam.Add("item_name_new", ImportDataArrayData.item_name_new);
                    objParam.Add("item_note", ImportDataArrayData.item_note);
                    objParam.Add("item_oem", ImportDataArrayData.item_oem);
                    objParam.Add("item_price", ImportDataArrayData.item_price);
                    objParam.Add("gpricepur", ImportDataArrayData.gpricepur);
                    objParam.Add("action_type", ImportDataArrayData.action_type);
                    objParam.Add("created_by", ImportDataArrayData.created_by);

                    VSK_PIT.Execute("SP_STMAS_IMPORT_CREATE", objParam, commandTimeout: 600, commandType: CommandType.StoredProcedure);

                }

                VSK_PIT.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region STMAS_IMPORT_VERIFY
        public List<Temp_Stmas_Verify_Model> STMAS_IMPORT_VERIFY(string ref_id)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@ref_id", ref_id);

                Connection();
                VSK_PIT.Open();
                List<Temp_Stmas_Verify_Model> mas_list = SqlMapper.Query<Temp_Stmas_Verify_Model>(VSK_PIT, "SP_STMAS_IMPORT_VERIFY", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();
                VSK_PIT.Close();

                return mas_list.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion
    }
}