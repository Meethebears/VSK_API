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
    public class MasterRepository
    {

        #region Connection_SQL Server

        public SqlConnection mscon;
        public SqlConnection Vskmis;

        private void Connection()
        {

           
            mscon = new SqlConnection(ConfigurationManager.ConnectionStrings["VSK_Data"].ToString());
            //mscon = new SqlConnection(ConfigurationManager.ConnectionStrings["VSK_Data_Dev"].ToString());
            Vskmis = new SqlConnection(ConfigurationManager.ConnectionStrings["Vskmis"].ToString());
            //string msconstr = ConfigurationManager.ConnectionStrings["VSK_Data_Dev"].ToString();
      
        }

        //-------------------End Connection_SQL ------------------------//
        #endregion


        #region Mas_gcode_get
        public List<MasterModel> Mas_gcode_get(MasterModel MasterModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@code", MasterModel.code);
                objParam.Add("@gname", MasterModel.gname);
                objParam.Add("@codechr", MasterModel.codechr);
                objParam.Add("@ctype", MasterModel.ctype);

                Connection();
                mscon.Open();
                List<MasterModel> MasList = SqlMapper.Query<MasterModel>(mscon, "SP_Gcode_Get", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();

                mscon.Close();
                return MasList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Mas_gcode_action
        public List<MasterModel> Mas_gcode_action(MasterModel MasterModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();
                objParam.Add("@code", MasterModel.code);
                objParam.Add("@gname", MasterModel.gname);
                objParam.Add("@codechr", MasterModel.codechr);
                objParam.Add("@ctype", MasterModel.ctype);
                objParam.Add("@userid", MasterModel.userid);
                objParam.Add("@function_type", MasterModel.function_type);


                Connection();
                mscon.Open();
                List<MasterModel> MasList = SqlMapper.Query<MasterModel>(mscon, "SP_Gcode_Action", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();

                mscon.Close();
                return MasList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Mas_gcode_chk
        public List<MasterModel> Mas_gcode_chk(MasterModel MasterModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@code", MasterModel.code);
                objParam.Add("@gname", MasterModel.gname);
                objParam.Add("@codechr", MasterModel.codechr);
                objParam.Add("@ctype", MasterModel.ctype);

                Connection();
                mscon.Open();
                List<MasterModel> MasList = SqlMapper.Query<MasterModel>(mscon, "SP_Gcode_Chk", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();

                mscon.Close();
                return MasList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Master_stmas_exp_get
        public List<Stmas_ExpModel> Master_stmas_exp_get(Stmas_ExpModel Stmas_ExpModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@code", Stmas_ExpModel.code);
                objParam.Add("@name", Stmas_ExpModel.name);
                objParam.Add("@part_number", Stmas_ExpModel.part_number);
                objParam.Add("@gbarcode", Stmas_ExpModel.gbarcode);
                objParam.Add("@Mode", Stmas_ExpModel.Mode);

                Connection();
                mscon.Open();
                List<Stmas_ExpModel> MasList = SqlMapper.Query<Stmas_ExpModel>(mscon, "SP_Stmas_Exp_Get", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();

                mscon.Close();
                return MasList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region ItemMaster_Search
        public List<Item_masterModel> ItemMaster_Search(string id, string text, string keywords)
        {
            try
            {

                List<Item_masterModel> MasListData = new List<Item_masterModel>();
                List<Item_masterModel> MasList;

                string SQLQuery1 = "SELECT TOP 10 " + id + " AS id, " + text + " as text FROM [SRVHQDB02].vorswin.dbo.stmas WHERE '" + keywords + "' != '' AND  (RTRIM(gbarcode) LIKE '%" + keywords + "%' OR RTRIM(name) LIKE '%" + keywords + "%' OR RTRIM(code) LIKE '%" + keywords + "%' OR RTRIM(SPCODES) LIKE '%" + keywords + "%' OR RTRIM(CHRCODE) LIKE '%" + keywords + "%')";
                string SQLQuery2 = "SELECT TOP 10 " + id + " AS id, " + text + " as text FROM [SRVHQDB02].vorswin.dbo.stmas_exp WHERE '" + keywords + "' != '' AND  (RTRIM(gbarcode) LIKE '%" + keywords + "%' OR RTRIM(name) LIKE '%" + keywords + "%' OR RTRIM(code) LIKE '%" + keywords + "%' OR RTRIM(SPCODES) LIKE '%" + keywords + "%' OR RTRIM(CHRCODE) LIKE '%" + keywords + "%')";

                Connection();
                mscon.Open();

                MasList = mscon.Query<Item_masterModel>(SQLQuery1).ToList();
                MasListData.AddRange(MasList);

                MasList = mscon.Query<Item_masterModel>(SQLQuery2).ToList();
                MasListData.AddRange(MasList);

                mscon.Close();
                return MasListData.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        #endregion

        #region Product_Main_Search
        public List<Item_masterModel> Product_Main_Search(string id, string text, string keywords)
        {
            try
            {

                string SQLQuery = "SELECT TOP 10 " + id + " AS id, " + text + " as text FROM [SRVHQDB02].vorswin.dbo.stmas WHERE '" + keywords + "' != '' AND  (RTRIM(gbarcode) LIKE '%" + keywords + "%' OR RTRIM(name) LIKE '%" + keywords + "%' OR RTRIM(code) LIKE '%" + keywords + "%' OR RTRIM(SPCODES) LIKE '%" + keywords + "%' OR RTRIM(CHRCODE) LIKE '%" + keywords + "%')";

                Connection();
                mscon.Open();
                List<Item_masterModel> MasList = mscon.Query<Item_masterModel>(SQLQuery).ToList();
                mscon.Close();
                return MasList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }


        }
        #endregion

        #region Gcode_Get_Select2
        public List<Item_masterModel> Gcode_Get_Select2(string ctype, string keywords)
        {
            try
            {

                string SQLQuery = "SELECT TOP 100 * FROM [SRVHQDB02].vorswin.dbo." + ctype + " WHERE '" + keywords + "' != '' AND startdate is not null AND  (RTRIM(code) LIKE '%" + keywords + "%' OR RTRIM(gname) LIKE '%" + keywords + "%')";

                Connection();
                mscon.Open();
                List<Item_masterModel> MasList = mscon.Query<Item_masterModel>(SQLQuery).ToList();
                mscon.Close();
                return MasList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        #endregion

        #region Mas_stmas_action
        public List<Action_stmasModel> Mas_stmas_action(Action_stmasModel Action_stmasModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@temp_id", Action_stmasModel.temp_id);
                objParam.Add("@coderef", Action_stmasModel.coderef);
                objParam.Add("@code", Action_stmasModel.code);
                objParam.Add("@name", Action_stmasModel.name);
                objParam.Add("@codeoem", Action_stmasModel.codeoem);
                objParam.Add("@car_brand", Action_stmasModel.car_brand);
                objParam.Add("@car_model", Action_stmasModel.car_model);
                objParam.Add("@g_model", Action_stmasModel.g_model);
                objParam.Add("@car_fm", Action_stmasModel.car_fm);
                objParam.Add("@car_to", Action_stmasModel.car_to);
                objParam.Add("@car_generation", Action_stmasModel.car_generation);
                objParam.Add("@car_engine", Action_stmasModel.car_engine);
                objParam.Add("@car_body", Action_stmasModel.car_body);
                objParam.Add("@code_a", Action_stmasModel.code_a);
                objParam.Add("@code_b", Action_stmasModel.code_b);
                objParam.Add("@code_c", Action_stmasModel.code_c);
                objParam.Add("@code_d", Action_stmasModel.code_d);
                objParam.Add("@code_e", Action_stmasModel.code_e);
                objParam.Add("@gremark", Action_stmasModel.gremark);
                objParam.Add("@created_by", Action_stmasModel.created_by);
                objParam.Add("@created_by2", Action_stmasModel.created_by2);

                objParam.Add("@Mode", Action_stmasModel.Mode);
                objParam.Add("@pMessage", Action_stmasModel.pMessage);

                Connection();
                mscon.Open();
                List<Action_stmasModel> MasList = SqlMapper.Query<Action_stmasModel>(mscon, "SP_Stmas_Exp_Action", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();

                mscon.Close();
                return MasList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Master_Stams_Exp_Chk
        public List<Chk_Stmas_ExpModel> Master_Stams_Exp_Chk(Chk_Stmas_ExpModel Chk_Stmas_ExpModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@code", Chk_Stmas_ExpModel.code);
                objParam.Add("@name", Chk_Stmas_ExpModel.name);

                Connection();
                mscon.Open();
                List<Chk_Stmas_ExpModel> MasList = SqlMapper.Query<Chk_Stmas_ExpModel>(mscon, "SP_Stmas_Exp_Chk", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();

                mscon.Close();
                return MasList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Stmas_Exp_Update
        public List<ImportDataModel> Stmas_Exp_Update(ImportDataModel ImportDataModel)
        {
            try
            {
                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@temp_id", ImportDataModel.temp_id);
                objParam.Add("@updated_by", ImportDataModel.updated_by);
                objParam.Add("@updated_by2", ImportDataModel.updated_by2);

                Connection();
                mscon.Open();
                List<ImportDataModel> ImportUpdateData_Create = SqlMapper.Query<ImportDataModel>(mscon, "SP_Stmas_Exp_Update_DEV", objParam, commandTimeout: 600, commandType: CommandType.StoredProcedure).ToList();
                mscon.Close();
                return ImportUpdateData_Create.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region ImportData_Tran_Create
        public void ImportData_Tran_Create(List<Action_stmasModel> Action_stmasModel)
        {
            try
            {

                Connection();
                mscon.Open();

                foreach (var ImportDataArrayData in Action_stmasModel)
                {
                    DynamicParameters objParam = new DynamicParameters();

                    objParam.Add("@coderef", ImportDataArrayData.coderef);
                    objParam.Add("@codeexp", ImportDataArrayData.codeexp);
                    objParam.Add("@code_a_name", ImportDataArrayData.code_a_name);
                    objParam.Add("@code_b_name", ImportDataArrayData.code_b_name);
                    objParam.Add("@code_c_name", ImportDataArrayData.code_c_name);
                    objParam.Add("@code_d_name", ImportDataArrayData.code_d_name);
                    objParam.Add("@code_e_name", ImportDataArrayData.code_e_name);
                    objParam.Add("@stmas_code_compare", ImportDataArrayData.stmas_code_compare);
                    objParam.Add("@stmas_name_compare", ImportDataArrayData.stmas_name_compare);
                    objParam.Add("@stmas_exp_name_compare", ImportDataArrayData.stmas_exp_name_compare);
                    objParam.Add("@code_a_compare", ImportDataArrayData.code_a_compare);
                    objParam.Add("@code_b_compare", ImportDataArrayData.code_b_compare);
                    objParam.Add("@code_c_compare", ImportDataArrayData.code_c_compare);
                    objParam.Add("@code_d_compare", ImportDataArrayData.code_d_compare);
                    objParam.Add("@code_e_compare", ImportDataArrayData.code_e_compare);
                    objParam.Add("@gdescript", ImportDataArrayData.gdescript);
                    objParam.Add("@action_type", ImportDataArrayData.action_type);
                    objParam.Add("@created_by", ImportDataArrayData.created_by);
                    objParam.Add("@created_by2", ImportDataArrayData.created_by2);
                    objParam.Add("@temp_id", ImportDataArrayData.temp_id);
                   

                    mscon.Execute("SP_Stmas_Exp_ImportData_CreateTran_DEV", objParam, commandTimeout: 600, commandType: CommandType.StoredProcedure);
                 
                }

                mscon.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region ImportData_Create
        public List<ImportDataModel> ImportData_Create(ImportDataModel ImportDataModel)
        {
            try
            {
                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@temp_id", ImportDataModel.temp_id);
                objParam.Add("@countitem_all", ImportDataModel.countitem_all);
                objParam.Add("@created_by", ImportDataModel.created_by);
                objParam.Add("@created_by2", ImportDataModel.created_by2);

                Connection();
                mscon.Open();
                List<ImportDataModel> ImportUpdateData_Create = SqlMapper.Query<ImportDataModel>(mscon, "SP_Stmas_Exp_ImportData_Create_DEV", objParam, commandTimeout: 600, commandType: CommandType.StoredProcedure).ToList();
                mscon.Close();
                return ImportUpdateData_Create.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region ImportData_Update
        public List<ImportDataModel> ImportData_Update(ImportDataModel ImportDataModel)
        {
            try
            {
                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@temp_id", ImportDataModel.temp_id);
                objParam.Add("@updated_by", ImportDataModel.updated_by);
                objParam.Add("@updated_by2", ImportDataModel.updated_by2);

                Connection();
                mscon.Open();
                List<ImportDataModel> ImportUpdateData_Create = SqlMapper.Query<ImportDataModel>(mscon, "SP_Stmas_Exp_ImportData_CalcStatus_DEV", objParam, commandTimeout: 600, commandType: CommandType.StoredProcedure).ToList();
                mscon.Close();
                return ImportUpdateData_Create.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region ImportData_TemplateGet
        public List<Stmas_ExpModel> ImportData_TemplateGet(Stmas_ExpModel Stmas_ExpModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@temp_id", Stmas_ExpModel.temp_id);
                objParam.Add("@created_by", Stmas_ExpModel.created_by);
                objParam.Add("@created_by2", Stmas_ExpModel.created_by2);

                Connection();
                mscon.Open();
                //List<Stmas_ExpModel> MasList = SqlMapper.Query<Stmas_ExpModel>(mscon, "SP_Stmas_Exp_ImportData_Template_Get_DEV", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();
                List<Stmas_ExpModel> MasList = SqlMapper.Query<Stmas_ExpModel>(mscon, "SP_Stmas_Exp_ImportData_Template_Get_copy2", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();

                mscon.Close();
                return MasList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region ImportData_Update_Data
        public List<ImportDataModel> ImportData_Update_Data(ImportDataModel ImportDataModel)
        {
            try
            {
                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@temp_id", ImportDataModel.temp_id);
                objParam.Add("@updated_by", ImportDataModel.updated_by);
                objParam.Add("@updated_by2", ImportDataModel.updated_by2);

                Connection();
                mscon.Open();
                List<ImportDataModel> ImportUpdateData_Create = SqlMapper.Query<ImportDataModel>(mscon, "SP_Stmas_Exp_ImportData_Update_DEV", objParam, commandTimeout: 600, commandType: CommandType.StoredProcedure).ToList();
                mscon.Close();
                return ImportUpdateData_Create.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region ImportData_Update_Data_VSK_MIS
        public List<ImportDataModel> ImportData_Update_Data_VSK_MIS(ImportDataModel ImportDataModel)
        {
            try
            {
                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@temp_id", ImportDataModel.temp_id);
                objParam.Add("@updated_by", ImportDataModel.updated_by);
                objParam.Add("@updated_by2", ImportDataModel.updated_by2);

                Connection();
                Vskmis.Open();
                List<ImportDataModel> ImportUpdateData = SqlMapper.Query<ImportDataModel>(Vskmis, "SP_Stmas_Exp_ImportData_Update_Production_", objParam, commandTimeout: 600, commandType: CommandType.StoredProcedure).ToList();
                Vskmis.Close();
                return ImportUpdateData.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion
    }
}