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

        public SqlConnection VSK_PIT;

        private void Connection()
        {

            VSK_PIT = new SqlConnection(ConfigurationManager.ConnectionStrings["VSK_PIT_187"].ToString());

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
                VSK_PIT.Open();
                List<Carmodel_MasterModel> MasList = VSK_PIT.Query<Carmodel_MasterModel>(SQLQuery).ToList();
                VSK_PIT.Close();
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
                VSK_PIT.Open();
                List<Carmodel_MasterModel> MasList = VSK_PIT.Query<Carmodel_MasterModel>(SQLQuery).ToList();
                VSK_PIT.Close();
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
                VSK_PIT.Open();
                List<Carmodel_MasterModel> MasList = VSK_PIT.Query<Carmodel_MasterModel>(SQLQuery).ToList();
                VSK_PIT.Close();
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
                VSK_PIT.Open();
                List<Carmodel_MasterModel> MasList = VSK_PIT.Query<Carmodel_MasterModel>(SQLQuery).ToList();
                VSK_PIT.Close();
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
                VSK_PIT.Open();
                List<Item_masterModel> MasList = VSK_PIT.Query<Item_masterModel>(SQLQuery).ToList();
                VSK_PIT.Close();
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
                objParam.Add("@keywords_2", Carmodel_MasterModel.keywords_2);
                objParam.Add("@keywords_3", Carmodel_MasterModel.keywords_3);
                objParam.Add("@keywords_4", Carmodel_MasterModel.keywords_4);
                objParam.Add("@keywords_5", Carmodel_MasterModel.keywords_5);
                objParam.Add("@keywords_6", Carmodel_MasterModel.keywords_6);

                Connection();
                VSK_PIT.Open();
                List<Carmodel_MasterModel> mas_list = SqlMapper.Query<Carmodel_MasterModel>(VSK_PIT, "SP_Carmodel_Master_Get", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();

                VSK_PIT.Close();
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
                VSK_PIT.Open();
                List<Carmodel_tmp_Model> ImportUpdateData = SqlMapper.Query<Carmodel_tmp_Model>(VSK_PIT, "SP_CarModel_ImportData_Tmp", objParam, commandTimeout: 600, commandType: CommandType.StoredProcedure).ToList();
                VSK_PIT.Close();
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
                VSK_PIT.Open();

                foreach (var ImportDataArrayData in Carmodel_tmptran_Model)
                {
                    DynamicParameters objParam = new DynamicParameters();

                    objParam.Add("@temp_id", ImportDataArrayData.temp_id);
                    objParam.Add("@model_id", ImportDataArrayData.model_id);
                    objParam.Add("@modelmixed", ImportDataArrayData.modelmixed);
                    objParam.Add("@vehicle_brand", ImportDataArrayData.vehicle_brand);
                    objParam.Add("@vehicle_model", ImportDataArrayData.vehicle_model);
                    objParam.Add("@vehicle_segments", ImportDataArrayData.vehicle_segments);
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

                    objParam.Add("@car_models", ImportDataArrayData.car_models);
                    objParam.Add("@car_models_ref", ImportDataArrayData.car_models_ref);

                    objParam.Add("@chassis", ImportDataArrayData.chassis);
                    objParam.Add("@horsepower", ImportDataArrayData.horsepower);
                    objParam.Add("@wheel", ImportDataArrayData.wheel);
                    objParam.Add("@chassis_model", ImportDataArrayData.chassis_model);
                    objParam.Add("@chassis_code", ImportDataArrayData.chassis_code);
                    objParam.Add("@transmission", ImportDataArrayData.transmission);
                    objParam.Add("@gross_vehicle_weight", ImportDataArrayData.gross_vehicle_weight);
                    objParam.Add("@item", ImportDataArrayData.item);


                    // objParam.Add("@car_models", ImportDataArrayData.car_models);

                    VSK_PIT.Execute("SP_CarModel_ImportData_TmpTran", objParam, commandTimeout: 600, commandType: CommandType.StoredProcedure);

                }

                VSK_PIT.Close();
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
                VSK_PIT.Open();
                List<Carmodel_tmptran_Model> ImportUpdateData = SqlMapper.Query<Carmodel_tmptran_Model>(VSK_PIT, "SP_CarModel_ImportData_TmpVerify", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();

                VSK_PIT.Close();
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
                VSK_PIT.Open();
                List<Carmodel_tmptran_Model> ImportUpdateData = SqlMapper.Query<Carmodel_tmptran_Model>(VSK_PIT, "SP_CarModel_ImportData_Upload", objParam, commandTimeout: 600, commandType: CommandType.StoredProcedure).ToList();
                VSK_PIT.Close();
                return ImportUpdateData.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region ImportData_CarModelMix_Get
        public IList<Carmodel_tmptran_Model> ImportData_CarModelMix_Get(Carmodel_tmptran_Model Carmodel_tmptran_Model)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@mode", Carmodel_tmptran_Model.mode);
                objParam.Add("@modelmix", Carmodel_tmptran_Model.modelmix);
                objParam.Add("@photo_no", Carmodel_tmptran_Model.photo_no);
                objParam.Add("@photo_name", Carmodel_tmptran_Model.photo_name);
                objParam.Add("@vehicle_brand", Carmodel_tmptran_Model.vehicle_brand);
                objParam.Add("@vehicle_segments", Carmodel_tmptran_Model.vehicle_segments);
                objParam.Add("@vehicle_model", Carmodel_tmptran_Model.vehicle_model);
                objParam.Add("@minor_change", Carmodel_tmptran_Model.minor_change);
                objParam.Add("@model_change", Carmodel_tmptran_Model.model_change);
                objParam.Add("@engine_displacement", Carmodel_tmptran_Model.engine_displacement);
                objParam.Add("@engine_code", Carmodel_tmptran_Model.engine_code);
                objParam.Add("@street_name", Carmodel_tmptran_Model.street_name);
                objParam.Add("@body_type", Carmodel_tmptran_Model.body_type);
                objParam.Add("@hign_stant", Carmodel_tmptran_Model.hign_stant);
                objParam.Add("@wheel_drive", Carmodel_tmptran_Model.wheel_drive);
                objParam.Add("@wheel", Carmodel_tmptran_Model.wheel);
                objParam.Add("@chassis_model", Carmodel_tmptran_Model.chassis_model);

                Connection();
                VSK_PIT.Open();
                IList<Carmodel_tmptran_Model> car_verrify = SqlMapper.Query<Carmodel_tmptran_Model>(VSK_PIT, "SP_CarModel_Get", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();

                VSK_PIT.Close();
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
                objParam.Add("@vehicle_segments", Carmodel_tmptran_Model.vehicle_segments);
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

                objParam.Add("@car_models", Carmodel_tmptran_Model.car_models);
                objParam.Add("@car_models_ref", Carmodel_tmptran_Model.car_models_ref);

                objParam.Add("@chassis", Carmodel_tmptran_Model.chassis);
                objParam.Add("@horsepower", Carmodel_tmptran_Model.horsepower);
                objParam.Add("@wheel", Carmodel_tmptran_Model.wheel);
                objParam.Add("@chassis_model", Carmodel_tmptran_Model.chassis_model);
                objParam.Add("@chassis_code", Carmodel_tmptran_Model.chassis_code);
                objParam.Add("@transmission", Carmodel_tmptran_Model.transmission);
                objParam.Add("@gross_vehicle_weight", Carmodel_tmptran_Model.gross_vehicle_weight);
                objParam.Add("@item", Carmodel_tmptran_Model.item);

                objParam.Add("@pMessage", Carmodel_tmptran_Model.pMessage);


                Connection();
                VSK_PIT.Open();
                List<Carmodel_tmptran_Model> car_verrify = SqlMapper.Query<Carmodel_tmptran_Model>(VSK_PIT, "SP_CarModel_SingleData_Action", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();

                VSK_PIT.Close();
                return car_verrify.ToList();
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
                VSK_PIT.Open();
                List<Carmodel_Photo_Model> car_verrify = SqlMapper.Query<Carmodel_Photo_Model>(VSK_PIT, "SP_CarModel_Photo_Upload", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();

                VSK_PIT.Close();
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
                objParam.Add("@vehicle_segments", Carmodel_Photo_Model.vehicle_segments);
                objParam.Add("@wheel", Carmodel_Photo_Model.wheel);
                objParam.Add("@wheel_drive", Carmodel_Photo_Model.wheel_drive);
                objParam.Add("@chassis_model", Carmodel_Photo_Model.chassis_model);

                Connection();
                VSK_PIT.Open();
                List<Carmodel_Photo_Model> car_verrify = SqlMapper.Query<Carmodel_Photo_Model>(VSK_PIT, "SP_CarModel_Photo_Delete", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();

                VSK_PIT.Close();
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
                VSK_PIT.Open();
                List<Carmodel_Photo_Model> car_verrify = SqlMapper.Query<Carmodel_Photo_Model>(VSK_PIT, "SP_CarModel_Photo_Delete_Modelmix", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();

                VSK_PIT.Close();
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
                VSK_PIT.Open();
                List<Carmodel_Photo_Model> car_verrify = SqlMapper.Query<Carmodel_Photo_Model>(VSK_PIT, "SP_CarModel_Photo_Delete_Modelmix_Sub", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();

                VSK_PIT.Close();
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
                VSK_PIT.Open();

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
                    objParam.Add("@model_change", ImportDataArrayData.model_change);
                    objParam.Add("@minor_change", ImportDataArrayData.minor_change);
                    objParam.Add("@body_type", ImportDataArrayData.body_type);
                    objParam.Add("@hign_stant", ImportDataArrayData.hign_stant);
                    objParam.Add("@wheel_drive", ImportDataArrayData.wheel_drive);
                    objParam.Add("@wheel", ImportDataArrayData.wheel);
                    objParam.Add("@chassis_model", ImportDataArrayData.chassis_model);
                    objParam.Add("@street_name", ImportDataArrayData.street_name);
                    objParam.Add("@created_by", ImportDataArrayData.created_by);
                    objParam.Add("@pMessage", ImportDataArrayData.pMessage);

                    VSK_PIT.Execute("SP_CarModel_Photo_Upload", objParam, commandTimeout: 600, commandType: CommandType.StoredProcedure);

                }

                VSK_PIT.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region CarModelMix_Item_List
        public List<Carmodel_MasterModel> CarModelMix_Item_List(Carmodel_MasterModel Carmodel_MasterModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@mode", Carmodel_MasterModel.mode);
                objParam.Add("@modelmix", Carmodel_MasterModel.modelmix);
                objParam.Add("@code", Carmodel_MasterModel.code);
                objParam.Add("@name", Carmodel_MasterModel.name);
                objParam.Add("@gbarcode", Carmodel_MasterModel.gbarcode);
                objParam.Add("@spcodes", Carmodel_MasterModel.spcodes);
                objParam.Add("@gnamechr", Carmodel_MasterModel.gnamechr);
                objParam.Add("@goem", Carmodel_MasterModel.goem);
                objParam.Add("@type", Carmodel_MasterModel.type);
                objParam.Add("@gmodel", Carmodel_MasterModel.gmodel);
                objParam.Add("@gused", Carmodel_MasterModel.gused);
                objParam.Add("@vehicle_brand", Carmodel_MasterModel.vehicle_brand);
                objParam.Add("@vehicle_segments", Carmodel_MasterModel.vehicle_segments);
                objParam.Add("@vehicle_model", Carmodel_MasterModel.vehicle_model);
                objParam.Add("@minor_change", Carmodel_MasterModel.minor_change);
                objParam.Add("@model_change", Carmodel_MasterModel.model_change);
                objParam.Add("@fuel_type", Carmodel_MasterModel.fuel_type);
                objParam.Add("@engine_displacement", Carmodel_MasterModel.engine_displacement);
                objParam.Add("@engine_code", Carmodel_MasterModel.engine_code);
                objParam.Add("@transmission_type", Carmodel_MasterModel.transmission_type);
                objParam.Add("@body_type", Carmodel_MasterModel.body_type);
                objParam.Add("@hign_stant", Carmodel_MasterModel.hign_stant);
                objParam.Add("@wheel_drive", Carmodel_MasterModel.wheel_drive);
                objParam.Add("@street_name", Carmodel_MasterModel.street_name);
                objParam.Add("@keywords", Carmodel_MasterModel.keywords);
                objParam.Add("@product_division", Carmodel_MasterModel.product_division);
                objParam.Add("@main_category", Carmodel_MasterModel.main_category);
                objParam.Add("@sub_category", Carmodel_MasterModel.sub_category);
                objParam.Add("@pages", Carmodel_MasterModel.pages);
                objParam.Add("@show", Carmodel_MasterModel.show);

                objParam.Add("@wheel", Carmodel_MasterModel.wheel);
                objParam.Add("@chassis_model", Carmodel_MasterModel.chassis_model);
                objParam.Add("@horsepower", Carmodel_MasterModel.horsepower);

                Connection();
                VSK_PIT.Open();
                List<Carmodel_MasterModel> mas_list = SqlMapper.Query<Carmodel_MasterModel>(VSK_PIT, "SP_Carmodel_Item_List", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();

                VSK_PIT.Close();
                return mas_list.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region CarModelMix_Item_Gcode
        public List<Carmodel_Gcode> CarModelMix_Item_Gcode(Carmodel_Gcode Carmodel_Gcode)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@mode", Carmodel_Gcode.mode);
                objParam.Add("@vehicle_brand", Carmodel_Gcode.vehicle_brand);
                objParam.Add("@vehicle_model", Carmodel_Gcode.vehicle_model);
                objParam.Add("@vehicle_segments", Carmodel_Gcode.vehicle_segments);
                objParam.Add("@minor_change", Carmodel_Gcode.minor_change);
                objParam.Add("@model_change", Carmodel_Gcode.model_change);
                objParam.Add("@fuel_type", Carmodel_Gcode.fuel_type);
                objParam.Add("@engine_displacement", Carmodel_Gcode.engine_displacement);
                objParam.Add("@engine_code", Carmodel_Gcode.engine_code);
                objParam.Add("@transmission_type", Carmodel_Gcode.transmission_type);
                objParam.Add("@body_type", Carmodel_Gcode.body_type);
                objParam.Add("@hign_stant", Carmodel_Gcode.hign_stant);
                objParam.Add("@wheel_drive", Carmodel_Gcode.wheel_drive);
                objParam.Add("@street_name", Carmodel_Gcode.street_name);
                objParam.Add("@keywords", Carmodel_Gcode.keywords);
                objParam.Add("@product_division", Carmodel_Gcode.product_division);
                objParam.Add("@main_category", Carmodel_Gcode.main_category);
                objParam.Add("@sub_category", Carmodel_Gcode.sub_category);

                Connection();
                VSK_PIT.Open();
                List<Carmodel_Gcode> mas_list = SqlMapper.Query<Carmodel_Gcode>(VSK_PIT, "SP_Carmodel_Item_Gcode", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();

                VSK_PIT.Close();
                return mas_list.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region CarModelMix_Item_Detail
        public List<Carmodel_MasterModel> CarModelMix_Item_Detail(Carmodel_MasterModel Carmodel_MasterModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@code", Carmodel_MasterModel.code);
              
                Connection();
                VSK_PIT.Open();
                List<Carmodel_MasterModel> mas_list = SqlMapper.Query<Carmodel_MasterModel>(VSK_PIT, "SP_Carmodel_Item_Detail", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();

                VSK_PIT.Close();
                return mas_list.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region ImportData_CarModelMix_Verify_Car
        public List<Carmodel_tmptran_Model> ImportData_CarModelMix_Verify_Car(Carmodel_tmptran_Model Carmodel_tmptran_Model)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@temp_id", Carmodel_tmptran_Model.temp_id);
                objParam.Add("@updated_by", Carmodel_tmptran_Model.updated_by);

                Connection();
                VSK_PIT.Open();
                List<Carmodel_tmptran_Model> ImportUpdateData = SqlMapper.Query<Carmodel_tmptran_Model>(VSK_PIT, "SP_CarModel_ImportData_TmpVerify_Car", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();

                VSK_PIT.Close();
                return ImportUpdateData.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region ImportData_CarModelMix_Verify_Truck
        public List<Carmodel_tmptran_Model> ImportData_CarModelMix_Verify_Truck(Carmodel_tmptran_Model Carmodel_tmptran_Model)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@temp_id", Carmodel_tmptran_Model.temp_id);
                objParam.Add("@updated_by", Carmodel_tmptran_Model.updated_by);

                Connection();
                VSK_PIT.Open();
                List<Carmodel_tmptran_Model> ImportUpdateData = SqlMapper.Query<Carmodel_tmptran_Model>(VSK_PIT, "SP_CarModel_ImportData_TmpVerify_Truck", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();

                VSK_PIT.Close();
                return ImportUpdateData.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion


        //#region CarModelMix_CarShapeData_List
        //public List<Carmodel_MasterModel> CarModelMix_CarShapeData_List(Carmodel_MasterModel Carmodel_MasterModel)
        //{
        //    try
        //    {

        //        DynamicParameters objParam = new DynamicParameters();

        //        objParam.Add("@vehicle_segments", Carmodel_MasterModel.vehicle_segments);
        //        objParam.Add("@vehicle_brand", Carmodel_MasterModel.vehicle_brand);
        //        objParam.Add("@vehicle_model", Carmodel_MasterModel.vehicle_model);
        //        objParam.Add("@car_shape_code", Carmodel_MasterModel.car_shape_code);
        //        objParam.Add("@car_shape_name", Carmodel_MasterModel.car_shape_name);
        //        objParam.Add("@record_status", Carmodel_MasterModel.record_status);

        //        Connection();
        //        VSK_PIT.Open();
        //        List<Carmodel_MasterModel> mas_list = SqlMapper.Query<Carmodel_MasterModel>(VSK_PIT, "SP_CarModel_CarShapeData_List", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();

        //        VSK_PIT.Close();
        //        return mas_list.ToList();

        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //}
        //#endregion

        //#region CarModelMix_CarShapeData_Create
        //public List<Carmodel_MasterModel> CarModelMix_CarShapeData_Create(Carmodel_MasterModel Carmodel_MasterModel)
        //{
        //    try
        //    {

        //        DynamicParameters objParam = new DynamicParameters();

        //        objParam.Add("@car_shape_no", Carmodel_MasterModel.car_shape_no);
        //        objParam.Add("@car_shape_name", Carmodel_MasterModel.car_shape_name);
        //        objParam.Add("@car_shape_type", Carmodel_MasterModel.car_shape_type);
        //        objParam.Add("@car_shape_remark", Carmodel_MasterModel.car_shape_remark);
        //        objParam.Add("@vehicle_segments", Carmodel_MasterModel.vehicle_segments);
        //        objParam.Add("@vehicle_brand", Carmodel_MasterModel.vehicle_brand);
        //        objParam.Add("@vehicle_model", Carmodel_MasterModel.vehicle_model);
        //        objParam.Add("@model_change", Carmodel_MasterModel.model_change);
        //        objParam.Add("@minor_change", Carmodel_MasterModel.minor_change);
        //        objParam.Add("@body_type", Carmodel_MasterModel.body_type);
        //        objParam.Add("@hign_stant", Carmodel_MasterModel.hign_stant);
        //        objParam.Add("@street_name", Carmodel_MasterModel.street_name);
        //        objParam.Add("@wheel_drive", Carmodel_MasterModel.wheel_drive);
        //        objParam.Add("@wheel", Carmodel_MasterModel.wheel);
        //        objParam.Add("@chassis_model", Carmodel_MasterModel.chassis_model);
        //        objParam.Add("@created_by", Carmodel_MasterModel.created_by);
                
        //        Connection();
        //        VSK_PIT.Open();
        //        List<Carmodel_MasterModel> mas_list = SqlMapper.Query<Carmodel_MasterModel>(VSK_PIT, "SP_CarModel_CarShapeData_Create", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();
        //        VSK_PIT.Close();
        //        return mas_list.ToList();

        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //}
        //#endregion

        //#region CarModelMix_CarShapeData_Update
        //public List<Carmodel_MasterModel> CarModelMix_CarShapeData_Update(Carmodel_MasterModel Carmodel_MasterModel)
        //{
        //    try
        //    {

        //        DynamicParameters objParam = new DynamicParameters();

        //        objParam.Add("@car_shape_id", Carmodel_MasterModel.car_shape_id);
        //        objParam.Add("@car_shape_no", Carmodel_MasterModel.car_shape_no);
        //        objParam.Add("@car_shape_name", Carmodel_MasterModel.car_shape_name);
        //        objParam.Add("@car_shape_type", Carmodel_MasterModel.car_shape_type);
        //        objParam.Add("@car_shape_remark", Carmodel_MasterModel.car_shape_remark);
        //        objParam.Add("@vehicle_segments", Carmodel_MasterModel.vehicle_segments);
        //        objParam.Add("@vehicle_brand", Carmodel_MasterModel.vehicle_brand);
        //        objParam.Add("@vehicle_model", Carmodel_MasterModel.vehicle_model);
        //        objParam.Add("@model_change", Carmodel_MasterModel.model_change);
        //        objParam.Add("@minor_change", Carmodel_MasterModel.minor_change);
        //        objParam.Add("@body_type", Carmodel_MasterModel.body_type);
        //        objParam.Add("@hign_stant", Carmodel_MasterModel.hign_stant);
        //        objParam.Add("@street_name", Carmodel_MasterModel.street_name);
        //        objParam.Add("@wheel_drive", Carmodel_MasterModel.wheel_drive);
        //        objParam.Add("@wheel", Carmodel_MasterModel.wheel);
        //        objParam.Add("@chassis_model", Carmodel_MasterModel.chassis_model);
        //        objParam.Add("@updated_by", Carmodel_MasterModel.updated_by);

        //        Connection();
        //        VSK_PIT.Open();
        //        List<Carmodel_MasterModel> mas_list = SqlMapper.Query<Carmodel_MasterModel>(VSK_PIT, "SP_CarModel_CarShapeData_Update", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();
        //        VSK_PIT.Close();
        //        return mas_list.ToList();

        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //}
        //#endregion

        //#region CarModelMix_CarShapeData_Delete
        //public List<Carmodel_MasterModel> CarModelMix_CarShapeData_Delete(Carmodel_MasterModel Carmodel_MasterModel)
        //{
        //    try
        //    {

        //        DynamicParameters objParam = new DynamicParameters();

        //        objParam.Add("@car_shape_id", Carmodel_MasterModel.car_shape_id);
        //        objParam.Add("@car_shape_code", Carmodel_MasterModel.car_shape_code);
        //        objParam.Add("@updated_by", Carmodel_MasterModel.updated_by);

        //        Connection();
        //        VSK_PIT.Open();
        //        List<Carmodel_MasterModel> mas_list = SqlMapper.Query<Carmodel_MasterModel>(VSK_PIT, "SP_CarModel_CarShapeData_Delete", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();
        //        VSK_PIT.Close();
        //        return mas_list.ToList();

        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //}
        //#endregion

        //#region CarModelMix_CarShapePicture_List
        //public List<Carmodel_MasterModel> CarModelMix_CarShapePicture_List(Carmodel_MasterModel Carmodel_MasterModel)
        //{
        //    try
        //    {

        //        DynamicParameters objParam = new DynamicParameters();

        //        objParam.Add("@vehicle_segments", Carmodel_MasterModel.vehicle_segments);
        //        objParam.Add("@vehicle_brand", Carmodel_MasterModel.vehicle_brand);
        //        objParam.Add("@vehicle_model", Carmodel_MasterModel.vehicle_model);
        //        objParam.Add("@car_shape_code", Carmodel_MasterModel.car_shape_code);
        //        objParam.Add("@car_shape_name", Carmodel_MasterModel.car_shape_name);
        //        objParam.Add("@record_status", Carmodel_MasterModel.record_status);

        //        Connection();
        //        VSK_PIT.Open();
        //        List<Carmodel_MasterModel> mas_list = SqlMapper.Query<Carmodel_MasterModel>(VSK_PIT, "SP_CarModel_CarShapePicture_List", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();

        //        VSK_PIT.Close();
        //        return mas_list.ToList();

        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //}
        //#endregion


        //#region CarModelMix_CarPicture_Code
        //public List<Carmodel_MasterModel> CarModelMix_CarPicture_Code(Carmodel_MasterModel Carmodel_MasterModel)
        //{
        //    try
        //    {

        //        DynamicParameters objParam = new DynamicParameters();

        //        objParam.Add("@vehicle_brand", Carmodel_MasterModel.vehicle_brand);
        //        objParam.Add("@vehicle_model", Carmodel_MasterModel.vehicle_model);
        //        objParam.Add("@car_shape_code", Carmodel_MasterModel.car_shape_code);

        //        Connection();
        //        VSK_PIT.Open();
        //        List<Carmodel_MasterModel> mas_list = SqlMapper.Query<Carmodel_MasterModel>(VSK_PIT, "SP_CarModel_CarPicture_Code", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();

        //        VSK_PIT.Close();
        //        return mas_list.ToList();

        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //}
        //#endregion

        //#region CarModel_CarPicture_Create
        //public List<Carmodel_MasterModel> CarModel_CarPicture_Create(Carmodel_MasterModel Carmodel_MasterModel)
        //{
        //    try
        //    {

        //        DynamicParameters objParam = new DynamicParameters();

        //        objParam.Add("@car_picture_name", Carmodel_MasterModel.car_picture_name);
        //        objParam.Add("@car_picture_folder", Carmodel_MasterModel.car_picture_folder);
        //        objParam.Add("@car_picture_type", Carmodel_MasterModel.car_picture_type);
        //        objParam.Add("@car_picture_ref_id", Carmodel_MasterModel.car_picture_ref_id);
        //        objParam.Add("@ref_shape_id", Carmodel_MasterModel.ref_shape_id);
        //        objParam.Add("@ref_shape_code", Carmodel_MasterModel.ref_shape_code);
        //        objParam.Add("@created_by", Carmodel_MasterModel.created_by);

        //        Connection();
        //        VSK_PIT.Open();
        //        List<Carmodel_MasterModel> mas_list = SqlMapper.Query<Carmodel_MasterModel>(VSK_PIT, "SP_CarModel_CarPicture_Create", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();
        //        VSK_PIT.Close();
        //        return mas_list.ToList();

        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //}
        //#endregion

        //#region CarModel_CarPicture_SetOrder
        //public List<Carmodel_MasterModel> CarModel_CarPicture_SetOrder(Carmodel_MasterModel Carmodel_MasterModel)
        //{
        //    try
        //    {

        //        DynamicParameters objParam = new DynamicParameters();

        //        objParam.Add("@car_picture_id", Carmodel_MasterModel.car_picture_id);
        //        objParam.Add("@car_picture_order", Carmodel_MasterModel.car_picture_order);
        //        objParam.Add("@updated_by", Carmodel_MasterModel.updated_by);

        //        Connection();
        //        VSK_PIT.Open();
        //        List<Carmodel_MasterModel> mas_list = SqlMapper.Query<Carmodel_MasterModel>(VSK_PIT, "SP_CarModel_CarPicture_SetOrder", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();
        //        VSK_PIT.Close();
        //        return mas_list.ToList();

        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //}
        //#endregion

        //#region CarModel_CarPicture_Delete
        //public List<Carmodel_MasterModel> CarModel_CarPicture_Delete(Carmodel_MasterModel Carmodel_MasterModel)
        //{
        //    try
        //    {

        //        DynamicParameters objParam = new DynamicParameters();

        //        objParam.Add("@car_picture_id", Carmodel_MasterModel.car_picture_id);
        //        objParam.Add("@updated_by", Carmodel_MasterModel.updated_by);

        //        Connection();
        //        VSK_PIT.Open();
        //        List<Carmodel_MasterModel> mas_list = SqlMapper.Query<Carmodel_MasterModel>(VSK_PIT, "SP_CarModel_CarPicture_Delete", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();
        //        VSK_PIT.Close();
        //        return mas_list.ToList();

        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //}
        //#endregion
    }
}