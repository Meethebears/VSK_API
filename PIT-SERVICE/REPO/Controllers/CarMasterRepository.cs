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
    public class CarMasterRepository
    {

        #region Connection_SQL Server
        //-------------------Start Connection_SQL ------------------------//

        public SqlConnection VSK_PIT;

        private void Connection()
        {

            VSK_PIT = new SqlConnection(ConfigurationManager.ConnectionStrings["VSK_PIT_247"].ToString());

        }

        //-------------------End Connection_SQL ------------------------//
        #endregion


        #region CarMasterData_Get
        public List<ResponseSelect2Model> CarMasterData_Get(CarMasterPmtModel CarMasterPmtModel)
        {
            try
            {
                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@mode", CarMasterPmtModel.mode);
                objParam.Add("@keywords", CarMasterPmtModel.keywords);
                objParam.Add("@keywords_1", CarMasterPmtModel.keywords_1);
                objParam.Add("@keywords_2", CarMasterPmtModel.keywords_2);
                objParam.Add("@keywords_3", CarMasterPmtModel.keywords_3);
                objParam.Add("@keywords_4", CarMasterPmtModel.keywords_4);
                objParam.Add("@keywords_5", CarMasterPmtModel.keywords_5);
                objParam.Add("@keywords_6", CarMasterPmtModel.keywords_6);

                Connection();
                VSK_PIT.Open();
                List<ResponseSelect2Model> mas_list = SqlMapper.Query<ResponseSelect2Model>(VSK_PIT, "SP_CarMasterData_Get", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();

                VSK_PIT.Close();
                return mas_list.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region SP_CarMasterData_List
        public List<LovDataModel> CarMasterData_List(CarMasterPmtModel CarMasterPmtModel)
        {
            try
            {
                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@mode", CarMasterPmtModel.mode);
                objParam.Add("@lov_group", CarMasterPmtModel.lov_group);
                objParam.Add("@lov_type", CarMasterPmtModel.lov_type);
                objParam.Add("@active_flag", CarMasterPmtModel.active_flag);

                Connection();
                VSK_PIT.Open();
                List<LovDataModel> mas_list = SqlMapper.Query<LovDataModel>(VSK_PIT, "SP_CarMasterData_List", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();

                VSK_PIT.Close();
                return mas_list.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion


        #region CarModelMix_CarShapeData_List
        public List<Carmodel_MasterModel> CarModelMix_CarShapeData_List(Carmodel_MasterModel Carmodel_MasterModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@vehicle_segments", Carmodel_MasterModel.vehicle_segments);
                objParam.Add("@vehicle_brand", Carmodel_MasterModel.vehicle_brand);
                objParam.Add("@vehicle_model", Carmodel_MasterModel.vehicle_model);
                objParam.Add("@car_shape_code", Carmodel_MasterModel.car_shape_code);
                objParam.Add("@car_shape_name", Carmodel_MasterModel.car_shape_name);
                objParam.Add("@record_status", Carmodel_MasterModel.record_status);

                Connection();
                VSK_PIT.Open();
                List<Carmodel_MasterModel> mas_list = SqlMapper.Query<Carmodel_MasterModel>(VSK_PIT, "SP_CarModel_CarShapeData_List", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();

                VSK_PIT.Close();
                return mas_list.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region CarModelMix_CarShapeData_Create
        public List<Carmodel_MasterModel> CarModelMix_CarShapeData_Create(Carmodel_MasterModel Carmodel_MasterModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@car_shape_no", Carmodel_MasterModel.car_shape_no);
                objParam.Add("@car_shape_name", Carmodel_MasterModel.car_shape_name);
                objParam.Add("@car_shape_type", Carmodel_MasterModel.car_shape_type);
                objParam.Add("@car_shape_remark", Carmodel_MasterModel.car_shape_remark);
                objParam.Add("@vehicle_segments", Carmodel_MasterModel.vehicle_segments);
                objParam.Add("@vehicle_brand", Carmodel_MasterModel.vehicle_brand);
                objParam.Add("@vehicle_model", Carmodel_MasterModel.vehicle_model);
                objParam.Add("@model_change", Carmodel_MasterModel.model_change);
                objParam.Add("@minor_change", Carmodel_MasterModel.minor_change);
                objParam.Add("@body_type", Carmodel_MasterModel.body_type);
                objParam.Add("@hign_stant", Carmodel_MasterModel.hign_stant);
                objParam.Add("@street_name", Carmodel_MasterModel.street_name);
                objParam.Add("@wheel_drive", Carmodel_MasterModel.wheel_drive);
                objParam.Add("@wheel", Carmodel_MasterModel.wheel);
                objParam.Add("@chassis_model", Carmodel_MasterModel.chassis_model);
                objParam.Add("@created_by", Carmodel_MasterModel.created_by);
                
                Connection();
                VSK_PIT.Open();
                List<Carmodel_MasterModel> mas_list = SqlMapper.Query<Carmodel_MasterModel>(VSK_PIT, "SP_CarModel_CarShapeData_Create", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();
                VSK_PIT.Close();
                return mas_list.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region CarModelMix_CarShapeData_Update
        public List<Carmodel_MasterModel> CarModelMix_CarShapeData_Update(Carmodel_MasterModel Carmodel_MasterModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@car_shape_id", Carmodel_MasterModel.car_shape_id);
                objParam.Add("@car_shape_no", Carmodel_MasterModel.car_shape_no);
                objParam.Add("@car_shape_name", Carmodel_MasterModel.car_shape_name);
                objParam.Add("@car_shape_type", Carmodel_MasterModel.car_shape_type);
                objParam.Add("@car_shape_remark", Carmodel_MasterModel.car_shape_remark);
                objParam.Add("@vehicle_segments", Carmodel_MasterModel.vehicle_segments);
                objParam.Add("@vehicle_brand", Carmodel_MasterModel.vehicle_brand);
                objParam.Add("@vehicle_model", Carmodel_MasterModel.vehicle_model);
                objParam.Add("@model_change", Carmodel_MasterModel.model_change);
                objParam.Add("@minor_change", Carmodel_MasterModel.minor_change);
                objParam.Add("@body_type", Carmodel_MasterModel.body_type);
                objParam.Add("@hign_stant", Carmodel_MasterModel.hign_stant);
                objParam.Add("@street_name", Carmodel_MasterModel.street_name);
                objParam.Add("@wheel_drive", Carmodel_MasterModel.wheel_drive);
                objParam.Add("@wheel", Carmodel_MasterModel.wheel);
                objParam.Add("@chassis_model", Carmodel_MasterModel.chassis_model);
                objParam.Add("@updated_by", Carmodel_MasterModel.updated_by);

                Connection();
                VSK_PIT.Open();
                List<Carmodel_MasterModel> mas_list = SqlMapper.Query<Carmodel_MasterModel>(VSK_PIT, "SP_CarModel_CarShapeData_Update", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();
                VSK_PIT.Close();
                return mas_list.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region CarModelMix_CarShapeData_Delete
        public List<Carmodel_MasterModel> CarModelMix_CarShapeData_Delete(Carmodel_MasterModel Carmodel_MasterModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@car_shape_id", Carmodel_MasterModel.car_shape_id);
                objParam.Add("@car_shape_code", Carmodel_MasterModel.car_shape_code);
                objParam.Add("@updated_by", Carmodel_MasterModel.updated_by);

                Connection();
                VSK_PIT.Open();
                List<Carmodel_MasterModel> mas_list = SqlMapper.Query<Carmodel_MasterModel>(VSK_PIT, "SP_CarModel_CarShapeData_Delete", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();
                VSK_PIT.Close();
                return mas_list.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region CarModelMix_CarShapePicture_List
        public List<Carmodel_MasterModel> CarModelMix_CarShapePicture_List(Carmodel_MasterModel Carmodel_MasterModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@vehicle_segments", Carmodel_MasterModel.vehicle_segments);
                objParam.Add("@vehicle_brand", Carmodel_MasterModel.vehicle_brand);
                objParam.Add("@vehicle_model", Carmodel_MasterModel.vehicle_model);
                objParam.Add("@car_shape_code", Carmodel_MasterModel.car_shape_code);
                objParam.Add("@car_shape_name", Carmodel_MasterModel.car_shape_name);
                objParam.Add("@record_status", Carmodel_MasterModel.record_status);

                Connection();
                VSK_PIT.Open();
                List<Carmodel_MasterModel> mas_list = SqlMapper.Query<Carmodel_MasterModel>(VSK_PIT, "SP_CarModel_CarShapePicture_List", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();

                VSK_PIT.Close();
                return mas_list.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion


        #region CarModelMix_CarPicture_Code
        public List<Carmodel_MasterModel> CarModelMix_CarPicture_Code(Carmodel_MasterModel Carmodel_MasterModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@vehicle_brand", Carmodel_MasterModel.vehicle_brand);
                objParam.Add("@vehicle_model", Carmodel_MasterModel.vehicle_model);
                objParam.Add("@car_shape_code", Carmodel_MasterModel.car_shape_code);

                Connection();
                VSK_PIT.Open();
                List<Carmodel_MasterModel> mas_list = SqlMapper.Query<Carmodel_MasterModel>(VSK_PIT, "SP_CarModel_CarPicture_Code", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();

                VSK_PIT.Close();
                return mas_list.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region CarModel_CarPicture_Create
        public List<Carmodel_MasterModel> CarModel_CarPicture_Create(Carmodel_MasterModel Carmodel_MasterModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@car_picture_name", Carmodel_MasterModel.car_picture_name);
                objParam.Add("@car_picture_folder", Carmodel_MasterModel.car_picture_folder);
                objParam.Add("@car_picture_type", Carmodel_MasterModel.car_picture_type);
                objParam.Add("@car_picture_ref_id", Carmodel_MasterModel.car_picture_ref_id);
                objParam.Add("@ref_shape_id", Carmodel_MasterModel.ref_shape_id);
                objParam.Add("@ref_shape_code", Carmodel_MasterModel.ref_shape_code);
                objParam.Add("@created_by", Carmodel_MasterModel.created_by);

                Connection();
                VSK_PIT.Open();
                List<Carmodel_MasterModel> mas_list = SqlMapper.Query<Carmodel_MasterModel>(VSK_PIT, "SP_CarModel_CarPicture_Create", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();
                VSK_PIT.Close();
                return mas_list.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region CarModel_CarPicture_SetOrder
        public List<Carmodel_MasterModel> CarModel_CarPicture_SetOrder(Carmodel_MasterModel Carmodel_MasterModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@car_picture_id", Carmodel_MasterModel.car_picture_id);
                objParam.Add("@car_picture_order", Carmodel_MasterModel.car_picture_order);
                objParam.Add("@updated_by", Carmodel_MasterModel.updated_by);

                Connection();
                VSK_PIT.Open();
                List<Carmodel_MasterModel> mas_list = SqlMapper.Query<Carmodel_MasterModel>(VSK_PIT, "SP_CarModel_CarPicture_SetOrder", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();
                VSK_PIT.Close();
                return mas_list.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region CarModel_CarPicture_Delete
        public List<Carmodel_MasterModel> CarModel_CarPicture_Delete(Carmodel_MasterModel Carmodel_MasterModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@mode", Carmodel_MasterModel.mode);
                objParam.Add("@ref_shape_id", Carmodel_MasterModel.ref_shape_id);
                objParam.Add("@car_picture_id", Carmodel_MasterModel.car_picture_id);
                objParam.Add("@updated_by", Carmodel_MasterModel.updated_by);

                Connection();
                VSK_PIT.Open();
                List<Carmodel_MasterModel> mas_list = SqlMapper.Query<Carmodel_MasterModel>(VSK_PIT, "SP_CarModel_CarPicture_Delete", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();
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