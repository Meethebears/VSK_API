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
    public class PitRepository
    {

        #region Connection_SQL Server
        //-------------------Start Connection_SQL ------------------------//

        public SqlConnection mscon;
        public SqlConnection Vskmis;

        private void Connection()
        {


           // mscon = new SqlConnection(ConfigurationManager.ConnectionStrings["VSK_Data"].ToString());
            mscon = new SqlConnection(ConfigurationManager.ConnectionStrings["VSK_DEV"].ToString());
            Vskmis = new SqlConnection(ConfigurationManager.ConnectionStrings["Vskmis"].ToString());
            //string msconstr = ConfigurationManager.ConnectionStrings["VSK_Data_Dev"].ToString();

        }

        //-------------------End Connection_SQL ------------------------//
        #endregion


        #region Vehicle_Brand_Search
        public List<Carmodel_MasterModel> Vehicle_Brand_Search(Carmodel_MasterModel Carmodel_MasterModelอ)
        {
            try
            {

                string SQLQuery = "SELECT * FROM dbo.glb_vehicle_brand";

                Connection();
                mscon.Open();
                List<Carmodel_MasterModel> MasList = mscon.Query<Carmodel_MasterModel>(SQLQuery).ToList();
                mscon.Close();
                return MasList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        #endregion

        #region Vehicle_Model_Search
        public List<Carmodel_MasterModel> Vehicle_Model_Search(string id, string text, string keywords)
        {
            try
            {

                string SQLQuery = "SELECT * FROM dbo.glb_vehicle_model WHERE RTRIM(" + text + ") = '" + keywords + "'  ";

                Connection();
                mscon.Open();
                List<Carmodel_MasterModel> MasList = mscon.Query<Carmodel_MasterModel>(SQLQuery).ToList();
                mscon.Close();
                return MasList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }


        }
        #endregion

        #region Vehicle_Minor_Search
        public List<Carmodel_MasterModel> Vehicle_Minor_Search(string id, string text, string keywords)
        {
            try
            {

                string SQLQuery = "SELECT * FROM dbo.glb_vehicle_minor WHERE RTRIM(" + text + ") = '" + keywords + "' ";

                Connection();
                mscon.Open();
                List<Carmodel_MasterModel> MasList = mscon.Query<Carmodel_MasterModel>(SQLQuery).ToList();
                mscon.Close();
                return MasList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }


        }
        #endregion

        #region Lov_Data_Search
        public List<Carmodel_MasterModel> Lov_Data_Search(string id, string text, string type, string keywords)
        {
            try
            {
                string SQLQuery = "SELECT * FROM dbo.lov_data WHERE lov_group = 'CarModelMix' AND lov_type = '" + type + "' ";

                //string SQLQuery = "SELECT TOP 10 " + id + " AS id, " + text + " as text FROM dbo.lov_data WHERE lov_group = 'CarModelMix' " +
                //                  "AND lov_type = '" + type + "' ";

                Connection();
                mscon.Open();
                List<Carmodel_MasterModel> MasList = mscon.Query<Carmodel_MasterModel>(SQLQuery).ToList();
                mscon.Close();
                return MasList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }


        }
        #endregion

        #region Gcode_Get
        public List<Item_masterModel> Gcode_Get(string ctype)
        {
            try
            {

                string SQLQuery = "SELECT * FROM [SRVHQDB02].vorswin.dbo." + ctype + "";

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

        #region CarModelMix_Master_Get
        public List<Carmodel_MasterModel> CarModelMix_Master_Get(Carmodel_MasterModel Carmodel_MasterModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@mode", Carmodel_MasterModel.mode);
                objParam.Add("@keywords", Carmodel_MasterModel.keywords);
                objParam.Add("@keywords_1", Carmodel_MasterModel.keywords_1);

                Connection();
                mscon.Open();
                List<Carmodel_MasterModel> mas_list = SqlMapper.Query<Carmodel_MasterModel>(mscon, "SP_Carmodel_Master_Get", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();

                mscon.Close();
                return mas_list.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region ImportData_CarModelMix_Tmp
        public List<Carmodel_tmp_Model> ImportData_CarModelMix_Tmp(Carmodel_tmp_Model Carmodel_tmp_Model)
        {
            try
            {
                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@mode", Carmodel_tmp_Model.mode);
                objParam.Add("@temp_id", Carmodel_tmp_Model.temp_id);
                objParam.Add("@countitem_all", Carmodel_tmp_Model.countitem_all);
                objParam.Add("@created_by", Carmodel_tmp_Model.created_by);

                Connection();
                mscon.Open();
                List<Carmodel_tmp_Model> ImportUpdateData = SqlMapper.Query<Carmodel_tmp_Model>(mscon, "SP_CarModel_ImportData_Tmp", objParam, commandTimeout: 600, commandType: CommandType.StoredProcedure).ToList();
                mscon.Close();
                return ImportUpdateData.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region ImportData_CarModelMix_TmpTran
        public void ImportData_CarModelMix_TmpTran(List<Carmodel_tmptran_Model> Carmodel_tmptran_Model)
        {
            try
            {

                Connection();
                mscon.Open();

                foreach (var ImportDataArrayData in Carmodel_tmptran_Model)
                {
                    DynamicParameters objParam = new DynamicParameters();

                    objParam.Add("@temp_id", ImportDataArrayData.temp_id);
                    objParam.Add("@model_id", ImportDataArrayData.model_id);
                    objParam.Add("@modelmixed", ImportDataArrayData.modelmixed);
                    objParam.Add("@vehicle_brand", ImportDataArrayData.vehicle_brand);
                    objParam.Add("@vehicle_model", ImportDataArrayData.vehicle_model);
                    objParam.Add("@cartype", ImportDataArrayData.cartype);
                    objParam.Add("@model_change", ImportDataArrayData.model_change);
                    objParam.Add("@minor_change", ImportDataArrayData.minor_change);
                    objParam.Add("@fuel_type", ImportDataArrayData.fuel_type);
                    objParam.Add("@engine_displacement", ImportDataArrayData.engine_displacement);
                    objParam.Add("@engine_code", ImportDataArrayData.engine_code);
                    objParam.Add("@transmission_type", ImportDataArrayData.transmission_type);
                    objParam.Add("@body_type", ImportDataArrayData.body_type);
                    objParam.Add("@hign_stant", ImportDataArrayData.hign_stant);
                    objParam.Add("@wheel_drive", ImportDataArrayData.wheel_drive);
                    objParam.Add("@street_name", ImportDataArrayData.street_name);
                    objParam.Add("@model_code", ImportDataArrayData.model_code);
                    objParam.Add("@remarks", ImportDataArrayData.remarks);
                    objParam.Add("@action", ImportDataArrayData.action);
                    objParam.Add("@created_by", ImportDataArrayData.created_by);
                   // objParam.Add("@car_models", ImportDataArrayData.car_models);

                    mscon.Execute("SP_CarModel_ImportData_TmpTran", objParam, commandTimeout: 600, commandType: CommandType.StoredProcedure);

                }

                mscon.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region ImportData_CarModelMix_Verify
        public List<Carmodel_tmptran_Model> ImportData_CarModelMix_Verify(Carmodel_tmptran_Model Carmodel_tmptran_Model)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@temp_id", Carmodel_tmptran_Model.temp_id);
                objParam.Add("@updated_by", Carmodel_tmptran_Model.updated_by);

                Connection();
                mscon.Open();
                List<Carmodel_tmptran_Model> ImportUpdateData = SqlMapper.Query<Carmodel_tmptran_Model>(mscon, "SP_CarModel_ImportData_TmpVerify", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();

                mscon.Close();
                return ImportUpdateData.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region ImportData_CarModelMix_Upload
        public List<Carmodel_tmptran_Model> ImportData_CarModelMix_Upload(Carmodel_tmptran_Model Carmodel_tmptran_Model)
        {
            try
            {
                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@temp_id", Carmodel_tmptran_Model.temp_id);
                objParam.Add("@updated_by", Carmodel_tmptran_Model.updated_by);

                Connection();
                mscon.Open();
                List<Carmodel_tmptran_Model> ImportUpdateData = SqlMapper.Query<Carmodel_tmptran_Model>(mscon, "SP_CarModel_ImportData_Upload", objParam, commandTimeout: 600, commandType: CommandType.StoredProcedure).ToList();
                mscon.Close();
                return ImportUpdateData.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region ImportData_CarModelMix_Get
        public List<Carmodel_tmptran_Model> ImportData_CarModelMix_Get(Carmodel_tmptran_Model Carmodel_tmptran_Model)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@mode", Carmodel_tmptran_Model.mode);
                objParam.Add("@modelmix", Carmodel_tmptran_Model.modelmix);
                objParam.Add("@photo_no", Carmodel_tmptran_Model.photo_no);
                objParam.Add("@photo_name", Carmodel_tmptran_Model.photo_name);
                objParam.Add("@vehicle_brand", Carmodel_tmptran_Model.vehicle_brand);
                objParam.Add("@vehicle_model", Carmodel_tmptran_Model.vehicle_model);
                objParam.Add("@minor_change", Carmodel_tmptran_Model.minor_change);
                objParam.Add("@model_change", Carmodel_tmptran_Model.model_change);
                objParam.Add("@engine_displacement", Carmodel_tmptran_Model.engine_displacement);
                objParam.Add("@engine_code", Carmodel_tmptran_Model.engine_code);
                objParam.Add("@street_name", Carmodel_tmptran_Model.street_name);
                objParam.Add("@body_type", Carmodel_tmptran_Model.body_type);
                objParam.Add("@hign_stant", Carmodel_tmptran_Model.hign_stant);

                Connection();
                mscon.Open();
                List<Carmodel_tmptran_Model> car_verrify = SqlMapper.Query<Carmodel_tmptran_Model>(mscon, "SP_CarModel_Get", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();

                mscon.Close();
                return car_verrify.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region ImportData_CarModelMix_Action
        public List<Carmodel_tmptran_Model> ImportData_CarModelMix_Action(Carmodel_tmptran_Model Carmodel_tmptran_Model)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@mode", Carmodel_tmptran_Model.mode);
                objParam.Add("@temp_id", Carmodel_tmptran_Model.temp_id);
                objParam.Add("@model_id", Carmodel_tmptran_Model.model_id);
                objParam.Add("@modelmixed", Carmodel_tmptran_Model.modelmixed);
                objParam.Add("@cartype", Carmodel_tmptran_Model.cartype);
                objParam.Add("@vehicle_brand", Carmodel_tmptran_Model.vehicle_brand);
                objParam.Add("@vehicle_model", Carmodel_tmptran_Model.vehicle_model);
                objParam.Add("@model_change", Carmodel_tmptran_Model.model_change);
                objParam.Add("@minor_change", Carmodel_tmptran_Model.minor_change);
                objParam.Add("@fuel_type", Carmodel_tmptran_Model.fuel_type);
                objParam.Add("@engine_displacement", Carmodel_tmptran_Model.engine_displacement);
                objParam.Add("@engine_code", Carmodel_tmptran_Model.engine_code);
                objParam.Add("@transmission_type", Carmodel_tmptran_Model.transmission_type);
                objParam.Add("@body_type", Carmodel_tmptran_Model.body_type);
                objParam.Add("@hign_stant", Carmodel_tmptran_Model.hign_stant);
                objParam.Add("@wheel_drive", Carmodel_tmptran_Model.wheel_drive);
                objParam.Add("@street_name", Carmodel_tmptran_Model.street_name);
                objParam.Add("@model_code", Carmodel_tmptran_Model.model_code);
                objParam.Add("@remarks", Carmodel_tmptran_Model.remarks);
                objParam.Add("@action", Carmodel_tmptran_Model.action);
                objParam.Add("@created_by", Carmodel_tmptran_Model.created_by);
                objParam.Add("@pMessage", Carmodel_tmptran_Model.pMessage);


                Connection();
                mscon.Open();
                List<Carmodel_tmptran_Model> car_verrify = SqlMapper.Query<Carmodel_tmptran_Model>(mscon, "SP_CarModel_SingleData_Action", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();

                mscon.Close();
                return car_verrify.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region CarModelMix_Master_Checked
        public List<Carmodel_Check_Model> CarModelMix_Master_Checked(Carmodel_Check_Model Carmodel_Check_Model)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();
               
                objParam.Add("@modelmixed", Carmodel_Check_Model.modelmixed);
                objParam.Add("@model_change", Carmodel_Check_Model.model_change);
                objParam.Add("@minor_change", Carmodel_Check_Model.minor_change);
                objParam.Add("@fuel_type", Carmodel_Check_Model.fuel_type);
                objParam.Add("@engine_displacement", Carmodel_Check_Model.engine_displacement);
                objParam.Add("@engine_code", Carmodel_Check_Model.engine_code);
                objParam.Add("@transmission_type", Carmodel_Check_Model.transmission_type);
                objParam.Add("@body_type", Carmodel_Check_Model.body_type);
                objParam.Add("@hign_stant", Carmodel_Check_Model.hign_stant);
                objParam.Add("@wheel_drive", Carmodel_Check_Model.wheel_drive);
                objParam.Add("@street_name", Carmodel_Check_Model.street_name);

                Connection();
                mscon.Open();
                List<Carmodel_Check_Model> mas_list = SqlMapper.Query<Carmodel_Check_Model>(mscon, "SP_CarModel_Checked", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();

                mscon.Close();
                return mas_list.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region CarModelMix_Master_Upload_Photo
        public List<Carmodel_Photo_Model> CarModelMix_Master_Upload_Photo_V1(Carmodel_Photo_Model Carmodel_Photo_Model)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@model_id", Carmodel_Photo_Model.model_id);
                objParam.Add("@temp_id", Carmodel_Photo_Model.temp_id);
                objParam.Add("@modelmix", Carmodel_Photo_Model.modelmix);
                objParam.Add("@photo_name", Carmodel_Photo_Model.photo_name);
                objParam.Add("@photo_folder", Carmodel_Photo_Model.photo_folder);
                objParam.Add("@photo_url", Carmodel_Photo_Model.photo_url);
                objParam.Add("@photo_type", Carmodel_Photo_Model.photo_type);
                objParam.Add("@created_by", Carmodel_Photo_Model.created_by);
                objParam.Add("@pMessage", Carmodel_Photo_Model.pMessage);

                Connection();
                mscon.Open();
                List<Carmodel_Photo_Model> car_verrify = SqlMapper.Query<Carmodel_Photo_Model>(mscon, "SP_CarModel_Photo_Upload", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();

                mscon.Close();
                return car_verrify.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region CarModelMix_Master_Photo_Delete
        public List<Carmodel_Photo_Model> CarModelMix_Master_Photo_Delete(Carmodel_Photo_Model Carmodel_Photo_Model)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@model_id", Carmodel_Photo_Model.model_id);
                objParam.Add("@temp_id", Carmodel_Photo_Model.temp_id);
                objParam.Add("@modelmix", Carmodel_Photo_Model.modelmix);
                objParam.Add("@photo_name", Carmodel_Photo_Model.photo_name);
                objParam.Add("@photo_folder", Carmodel_Photo_Model.photo_folder);
                objParam.Add("@photo_url", Carmodel_Photo_Model.photo_url);
                objParam.Add("@photo_type", Carmodel_Photo_Model.photo_type);
                objParam.Add("@photo_no", Carmodel_Photo_Model.photo_no);
                objParam.Add("@vehicle_model", Carmodel_Photo_Model.vehicle_model);
                objParam.Add("@minor_change", Carmodel_Photo_Model.minor_change);
                objParam.Add("@body_type", Carmodel_Photo_Model.body_type);
                objParam.Add("@hign_stant", Carmodel_Photo_Model.hign_stant);
                objParam.Add("@street_name", Carmodel_Photo_Model.street_name);
                objParam.Add("@created_by", Carmodel_Photo_Model.created_by);
                objParam.Add("@pMessage", Carmodel_Photo_Model.pMessage);

                Connection();
                mscon.Open();
                List<Carmodel_Photo_Model> car_verrify = SqlMapper.Query<Carmodel_Photo_Model>(mscon, "SP_CarModel_Photo_Delete", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();

                mscon.Close();
                return car_verrify.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region CarModelMix_Master_Photo_Delete_Modelmix
        public List<Carmodel_Photo_Model> CarModelMix_Master_Photo_Delete_Modelmix(Carmodel_Photo_Model Carmodel_Photo_Model)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@model_id", Carmodel_Photo_Model.model_id);
                objParam.Add("@temp_id", Carmodel_Photo_Model.temp_id);
                objParam.Add("@modelmix", Carmodel_Photo_Model.modelmix);
                objParam.Add("@photo_name", Carmodel_Photo_Model.photo_name);
                objParam.Add("@photo_folder", Carmodel_Photo_Model.photo_folder);
                objParam.Add("@photo_url", Carmodel_Photo_Model.photo_url);
                objParam.Add("@photo_type", Carmodel_Photo_Model.photo_type);
                objParam.Add("@photo_no", Carmodel_Photo_Model.photo_no);
                objParam.Add("@vehicle_model", Carmodel_Photo_Model.vehicle_model);
                objParam.Add("@minor_change", Carmodel_Photo_Model.minor_change);
                objParam.Add("@body_type", Carmodel_Photo_Model.body_type);
                objParam.Add("@hign_stant", Carmodel_Photo_Model.hign_stant);
                objParam.Add("@street_name", Carmodel_Photo_Model.street_name);
                objParam.Add("@created_by", Carmodel_Photo_Model.created_by);
                objParam.Add("@pMessage", Carmodel_Photo_Model.pMessage);

                Connection();
                mscon.Open();
                List<Carmodel_Photo_Model> car_verrify = SqlMapper.Query<Carmodel_Photo_Model>(mscon, "SP_CarModel_Photo_Delete_Modelmix", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();

                mscon.Close();
                return car_verrify.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region CarModelMix_Master_Photo_Delete_Modelmix
        public List<Carmodel_Photo_Model> CarModelMix_Master_Photo_Delete_Sub(Carmodel_Photo_Model Carmodel_Photo_Model)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@model_id", Carmodel_Photo_Model.model_id);
                objParam.Add("@temp_id", Carmodel_Photo_Model.temp_id);
                objParam.Add("@modelmix", Carmodel_Photo_Model.modelmix);
                objParam.Add("@photo_name", Carmodel_Photo_Model.photo_name);
                objParam.Add("@photo_folder", Carmodel_Photo_Model.photo_folder);
                objParam.Add("@photo_url", Carmodel_Photo_Model.photo_url);
                objParam.Add("@photo_type", Carmodel_Photo_Model.photo_type);
                objParam.Add("@photo_no", Carmodel_Photo_Model.photo_no);
                objParam.Add("@vehicle_model", Carmodel_Photo_Model.vehicle_model);
                objParam.Add("@minor_change", Carmodel_Photo_Model.minor_change);
                objParam.Add("@body_type", Carmodel_Photo_Model.body_type);
                objParam.Add("@hign_stant", Carmodel_Photo_Model.hign_stant);
                objParam.Add("@street_name", Carmodel_Photo_Model.street_name);
                objParam.Add("@created_by", Carmodel_Photo_Model.created_by);
                objParam.Add("@pMessage", Carmodel_Photo_Model.pMessage);

                Connection();
                mscon.Open();
                List<Carmodel_Photo_Model> car_verrify = SqlMapper.Query<Carmodel_Photo_Model>(mscon, "SP_CarModel_Photo_Delete_Modelmix_Sub", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();

                mscon.Close();
                return car_verrify.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region CarModelMix_Master_Upload_Photo
        public void CarModelMix_Master_Upload_Photo(List<Carmodel_Photo_Model> Carmodel_Photo_Model)
        {
            try
            {

                Connection();
                mscon.Open();

                foreach (var ImportDataArrayData in Carmodel_Photo_Model)
                {
                    DynamicParameters objParam = new DynamicParameters();

                    objParam.Add("@model_id", ImportDataArrayData.model_id);
                    objParam.Add("@temp_id", ImportDataArrayData.temp_id);
                    objParam.Add("@modelmix", ImportDataArrayData.modelmix);
                    objParam.Add("@photo_name", ImportDataArrayData.photo_name);
                    objParam.Add("@photo_folder", ImportDataArrayData.photo_folder);
                    objParam.Add("@photo_url", ImportDataArrayData.photo_url);
                    objParam.Add("@photo_type", ImportDataArrayData.photo_type);
                    objParam.Add("@photo_no", ImportDataArrayData.photo_no);
                    objParam.Add("@vehicle_model", ImportDataArrayData.vehicle_model);
                    objParam.Add("@minor_change", ImportDataArrayData.minor_change);
                    objParam.Add("@body_type", ImportDataArrayData.body_type);
                    objParam.Add("@hign_stant", ImportDataArrayData.hign_stant);
                    objParam.Add("@street_name", ImportDataArrayData.street_name);
                    objParam.Add("@created_by", ImportDataArrayData.created_by);
                    objParam.Add("@pMessage", ImportDataArrayData.pMessage);

                    mscon.Execute("SP_CarModel_Photo_Upload", objParam, commandTimeout: 600, commandType: CommandType.StoredProcedure);

                }

                mscon.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region ImportData_CarModelMix_Item_Get
        public List<Carmodel_MasterModel> ImportData_CarModelMix_Item_Get(Carmodel_MasterModel Carmodel_MasterModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@modelmix", Carmodel_MasterModel.modelmix);

                Connection();
                mscon.Open();
                List<Carmodel_MasterModel> car_verrify = SqlMapper.Query<Carmodel_MasterModel>(mscon, "SP_Carmodel_Item_Get", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();

                mscon.Close();
                return car_verrify.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion
    }
}