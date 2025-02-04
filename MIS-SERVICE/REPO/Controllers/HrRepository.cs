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
    public class HrRepository
    {

        #region Connection_SQL Server
        //-------------------Start Connection_SQL ------------------------//

        public SqlConnection mscon;

        private void Connection()
        {

            string msconstr = ConfigurationManager.ConnectionStrings["VSK_DEV"].ToString();
            //string msconstr = ConfigurationManager.ConnectionStrings["VSK_HR"].ToString();
            mscon = new SqlConnection(msconstr);
        }

        //-------------------End Connection_SQL ------------------------//
        #endregion

        #region Hr_Verify_ID
        public List<DetailModel> Hr_Verify_Employee(DetailModel DetailModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@code", DetailModel.code);

                Connection();
                mscon.Open();
                List<DetailModel> HrList = SqlMapper.Query<DetailModel>(mscon, "SP_Hr_Verify_Employee", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();

                mscon.Close();
                return HrList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Hr_Employee_Detail
        public List<DetailModel> Hr_Employee_Detail(DetailModel DetailModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@employee_id", DetailModel.employee_id);

                Connection();
                mscon.Open();
                List<DetailModel> HrList = SqlMapper.Query<DetailModel>(mscon, "SP_Hr_employee_Detail", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();

                mscon.Close();
                return HrList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Hr_Employee_Time
        public List<DetailModel> Hr_Employee_Time(DetailModel DetailModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@employee_code", DetailModel.employee_code);
                objParam.Add("@data_quarter", DetailModel.data_quarter);

                Connection();
                mscon.Open();
                List<DetailModel> HrList = SqlMapper.Query<DetailModel>(mscon, "SP_Hr_Employee_Time", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();

                mscon.Close();
                return HrList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Hr_Quarter_Get
        public List<QuarterModel> Hr_Quarter_Get(QuarterModel QuarterModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@quarter_id", QuarterModel.quarter_id);

                Connection();
                mscon.Open();
                List<QuarterModel> HrList = SqlMapper.Query<QuarterModel>(mscon, "SP_Hr_Quarter_Get", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();

                mscon.Close();
                return HrList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Hr_Quarter_Create 
        public List<QuarterModel> Hr_Quarter_Create(QuarterModel QuarterModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@quarter_code", QuarterModel.quarter_code);
                objParam.Add("@quarter_name", QuarterModel.quarter_name);
                objParam.Add("@quarter_year", QuarterModel.quarter_year);
                objParam.Add("@quarter_order", QuarterModel.quarter_order);
                objParam.Add("@created_by", QuarterModel.created_by);


                Connection();
                mscon.Open();
                List<QuarterModel> HrList = SqlMapper.Query<QuarterModel>(mscon, "SP_Hr_Quarter_Create", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();

                mscon.Close();
                return HrList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Hr_Quarter_Update 
        public List<QuarterModel> Hr_Quarter_Update(QuarterModel QuarterModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@quarter_id", QuarterModel.quarter_id);
                objParam.Add("@quarter_year", QuarterModel.quarter_year);
                objParam.Add("@quarter_status", QuarterModel.quarter_status);
                objParam.Add("@updated_by", QuarterModel.updated_by);


                Connection();
                mscon.Open();
                List<QuarterModel> HrList = SqlMapper.Query<QuarterModel>(mscon, "SP_Hr_Quarter_Update", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();

                mscon.Close();
                return HrList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Hr_Create_Data
        public List<CreateDATAModel> Hr_Create_Data(CreateDATAModel CreateDATAModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@data_id", CreateDATAModel.data_id);
                objParam.Add("@data_leader_assess", CreateDATAModel.data_leader_assess);
                objParam.Add("@data_employee_assess", CreateDATAModel.data_employee_assess);
                objParam.Add("@data_form", CreateDATAModel.data_form);
                objParam.Add("@data_quarter", CreateDATAModel.data_quarter);
                objParam.Add("@data_assess_by", CreateDATAModel.data_assess_by);
                objParam.Add("@data_score_pms", CreateDATAModel.data_score_pms);
                objParam.Add("@data_percent_pms", CreateDATAModel.data_percent_pms);
                objParam.Add("@record_status", CreateDATAModel.record_status);
                objParam.Add("@created_by", CreateDATAModel.created_by);
                objParam.Add("@data_c_good", CreateDATAModel.data_c_good);
                objParam.Add("@data_c_fail", CreateDATAModel.data_c_fail);

                Connection();
                mscon.Open();
                List<CreateDATAModel> HrList = SqlMapper.Query<CreateDATAModel>(mscon, "SP_Hr_Create_Data", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();

                mscon.Close();
                return HrList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Hr_Create_Score

        public void Hr_Create_Score(List<ScoreCreateModel> ScoreCreateModel)
        {
            try
            {

                foreach (var HR_ScoreData in ScoreCreateModel)
                {
                    DynamicParameters objParam = new DynamicParameters();

                    objParam.Add("@sc_data_id", HR_ScoreData.sc_data_id);
                    objParam.Add("@sc_topic", HR_ScoreData.sc_topic);
                    objParam.Add("@sc_weight", HR_ScoreData.sc_weight);
                    objParam.Add("@sc_score", HR_ScoreData.sc_score);
                    objParam.Add("@sc_comment", HR_ScoreData.sc_comment);
                    objParam.Add("@sc_order", HR_ScoreData.sc_order);
                    objParam.Add("@sc_subheader_id", HR_ScoreData.sc_subheader_id);
                    objParam.Add("@created_by", HR_ScoreData.created_by);

                    Connection();
                    mscon.Open();
                    mscon.Execute("SP_Hr_Create_Score", objParam, commandType: CommandType.StoredProcedure, commandTimeout: 210);
                    mscon.Close();
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Hr_Update_Data
        public List<CreateDATAModel> Hr_Update_Data(CreateDATAModel CreateDATAModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@data_id", CreateDATAModel.data_id);
                objParam.Add("@updated_status", CreateDATAModel.updated_status);
                objParam.Add("@updated_command", CreateDATAModel.updated_command);
                objParam.Add("@updated_by", CreateDATAModel.updated_by);

                Connection();
                mscon.Open();
                List<CreateDATAModel> HrList = SqlMapper.Query<CreateDATAModel>(mscon, "SP_Hr_Status_Data", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();

                mscon.Close();
                return HrList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Hr_Delete_Data
        public List<CreateDATAModel> Hr_Delete_Data(CreateDATAModel CreateDATAModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@data_id", CreateDATAModel.data_id);
                objParam.Add("@updated_by", CreateDATAModel.updated_by);

                Connection();
                mscon.Open();
                List<CreateDATAModel> HrList = SqlMapper.Query<CreateDATAModel>(mscon, "SP_Hr_Delete_Data", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();

                mscon.Close();
                return HrList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Hr_Employee_Import
        public void Hr_Employee_Import(List<EmployeeModel> EmployeeModel)
        {
            try
            {

                foreach (var Employee_Data in EmployeeModel)
                {
                    DynamicParameters objParam = new DynamicParameters();

                    objParam.Add("@user_id", Employee_Data.user_id);
                    objParam.Add("@employee_code", Employee_Data.employee_code);
                    objParam.Add("@employee_sec", Employee_Data.employee_sec);
                    objParam.Add("@employee_dept", Employee_Data.employee_dept);
                    objParam.Add("@employee_pos", Employee_Data.employee_pos);
                    objParam.Add("@employee_job_startdate", Employee_Data.employee_job_startdate);
                    objParam.Add("@employee_leader_asses1", Employee_Data.employee_leader_asses1);
                    objParam.Add("@employee_leader_asses2", Employee_Data.employee_leader_asses2);
                    objParam.Add("@employee_leader_asses3", Employee_Data.employee_leader_asses3);
                    objParam.Add("@employee_form", Employee_Data.employee_form);
                    objParam.Add("@created_by", Employee_Data.created_by);
                    objParam.Add("@employee_prefix_th", Employee_Data.employee_prefix_th);
                    objParam.Add("@employee_first_name_th", Employee_Data.employee_first_name_th);
                    objParam.Add("@employee_last_name_th", Employee_Data.employee_last_name_th);
                    //objParam.Add("@employee_full_name_th", Employee_Data.employee_full_name_th);
                    objParam.Add("@employee_prefix_en", Employee_Data.employee_prefix_en);
                    objParam.Add("@employee_first_name_en", Employee_Data.employee_first_name_en);
                    objParam.Add("@employee_last_name_en", Employee_Data.employee_last_name_en);
                    //objParam.Add("@employee_full_name_en", Employee_Data.employee_full_name_en);
                    //objParam.Add("@employee_photo", Employee_Data.employee_photo);
                    objParam.Add("@employee_nickname_th", Employee_Data.employee_nickname_th);
                    objParam.Add("@employee_nickname_en", Employee_Data.employee_nickname_en);
                    objParam.Add("@temp_id", Employee_Data.temp_id);

                    Connection();
                    mscon.Open();
                    mscon.Execute("SP_Hr_Employee_Import", objParam, commandType: CommandType.StoredProcedure, commandTimeout: 210);
                    mscon.Close();
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Hr_Employee_Create
        public List<EmployeeModel> Hr_Employee_Create(EmployeeModel EmployeeModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@user_id", EmployeeModel.user_id);
                objParam.Add("@employee_code", EmployeeModel.employee_code);
                objParam.Add("@employee_prefix", EmployeeModel.employee_prefix);
                objParam.Add("@employee_name", EmployeeModel.employee_name);
                objParam.Add("@employee_nickname", EmployeeModel.employee_nickname);
                objParam.Add("@employee_sec", EmployeeModel.employee_sec);
                objParam.Add("@employee_dept", EmployeeModel.employee_dept);
                objParam.Add("@employee_pos", EmployeeModel.employee_pos);
                objParam.Add("@employee_job_startdate", EmployeeModel.employee_job_startdate);
                objParam.Add("@employee_leader_asses1", EmployeeModel.employee_leader_asses1);
                objParam.Add("@employee_leader_asses2", EmployeeModel.employee_leader_asses2);
                objParam.Add("@employee_leader_asses3", EmployeeModel.employee_leader_asses3);
                objParam.Add("@employee_form", EmployeeModel.employee_form);
                objParam.Add("@created_by", EmployeeModel.created_by);
                objParam.Add("@employee_prefix_th", EmployeeModel.employee_prefix_th);
                objParam.Add("@employee_first_name_th", EmployeeModel.employee_first_name_th);
                objParam.Add("@employee_last_name_th", EmployeeModel.employee_last_name_th);
                objParam.Add("@employee_full_name_th", EmployeeModel.employee_full_name_th);
                objParam.Add("@employee_prefix_en", EmployeeModel.employee_prefix_en);
                objParam.Add("@employee_first_name_en", EmployeeModel.employee_first_name_en);
                objParam.Add("@employee_last_name_en", EmployeeModel.employee_last_name_en);
                objParam.Add("@employee_full_name_en", EmployeeModel.employee_full_name_en);
                objParam.Add("@employee_photo", EmployeeModel.employee_photo);
                objParam.Add("@employee_nickname_th", EmployeeModel.employee_nickname_th);
                objParam.Add("@employee_nickname_en", EmployeeModel.employee_nickname_en);


                Connection();
                mscon.Open();
                List<EmployeeModel> HrList = SqlMapper.Query<EmployeeModel>(mscon, "SP_Hr_Employee_Create", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();

                mscon.Close();
                return HrList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Hr_Employee_Get
        public List<EmployeeModel> Hr_Employee_Get(EmployeeModel EmployeeModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@employee_id", EmployeeModel.employee_id);
                objParam.Add("@employee_name", EmployeeModel.employee_name);
                objParam.Add("@employee_form", EmployeeModel.employee_form);
                objParam.Add("@employee_code", EmployeeModel.employee_code);
                objParam.Add("@employee_sec", EmployeeModel.employee_sec);
                objParam.Add("@employee_dept", EmployeeModel.employee_dept);
                objParam.Add("@employee_pos", EmployeeModel.employee_pos);
                objParam.Add("@employee_leader", EmployeeModel.employee_leader);

                Connection();
                mscon.Open();
                List<EmployeeModel> HrList = SqlMapper.Query<EmployeeModel>(mscon, "SP_Hr_Employee_Get", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();

                mscon.Close();
                return HrList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Hr_Employee_Update
        public List<EmployeeModel> Hr_Employee_Update(EmployeeModel EmployeeModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@employee_id", EmployeeModel.employee_id);
                objParam.Add("@employee_code", EmployeeModel.employee_code);
                objParam.Add("@employee_prefix", EmployeeModel.employee_prefix);
                objParam.Add("@employee_name", EmployeeModel.employee_name);
                objParam.Add("@employee_nickname", EmployeeModel.employee_nickname);
                objParam.Add("@employee_sec", EmployeeModel.employee_sec);
                objParam.Add("@employee_dept", EmployeeModel.employee_dept);
                objParam.Add("@employee_pos", EmployeeModel.employee_pos);
                objParam.Add("@employee_job_startdate", EmployeeModel.employee_job_startdate);
                objParam.Add("@employee_leader_asses1", EmployeeModel.employee_leader_asses1);
                objParam.Add("@employee_leader_asses2", EmployeeModel.employee_leader_asses2);
                objParam.Add("@employee_leader_asses3", EmployeeModel.employee_leader_asses3);
                objParam.Add("@employee_form", EmployeeModel.employee_form);
                objParam.Add("@updated_by", EmployeeModel.updated_by);
                objParam.Add("@employee_prefix_th", EmployeeModel.employee_prefix_th);
                objParam.Add("@employee_first_name_th", EmployeeModel.employee_first_name_th);
                objParam.Add("@employee_last_name_th", EmployeeModel.employee_last_name_th);
                objParam.Add("@employee_full_name_th", EmployeeModel.employee_full_name_th);
                objParam.Add("@employee_prefix_en", EmployeeModel.employee_prefix_en);
                objParam.Add("@employee_first_name_en", EmployeeModel.employee_first_name_en);
                objParam.Add("@employee_last_name_en", EmployeeModel.employee_last_name_en);
                objParam.Add("@employee_full_name_en", EmployeeModel.employee_full_name_en);
                objParam.Add("@employee_photo", EmployeeModel.employee_photo);
                objParam.Add("@employee_nickname_th", EmployeeModel.employee_nickname_th);
                objParam.Add("@employee_nickname_en", EmployeeModel.employee_nickname_en);


                Connection();
                mscon.Open();
                List<EmployeeModel> HrList = SqlMapper.Query<EmployeeModel>(mscon, "SP_Hr_Employee_Update", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();

                mscon.Close();
                return HrList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Hr_Employee_Delete
        public List<EmployeeModel> Hr_Employee_Delete(EmployeeModel EmployeeModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@employee_id", EmployeeModel.employee_id);
                objParam.Add("@updated_by", EmployeeModel.updated_by);


                Connection();
                mscon.Open();
                List<EmployeeModel> HrList = SqlMapper.Query<EmployeeModel>(mscon, "SP_Hr_Employee_Delete", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();

                mscon.Close();
                return HrList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Hr_Job_Get
        public List<JobModel> Hr_Job_Get(JobModel JobModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@job_type", JobModel.job_type);

                Connection();
                mscon.Open();
                List<JobModel> HrList = SqlMapper.Query<JobModel>(mscon, "SP_Hr_Job", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();

                mscon.Close();
                return HrList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Hr_Time_Get
        public List<TimeModel> Hr_Time_Get(TimeModel TimeModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@employee_code", TimeModel.employee_code);
                objParam.Add("@employee_sec", TimeModel.employee_sec);
                objParam.Add("@employee_dept", TimeModel.employee_dept);
                objParam.Add("@employee_pos", TimeModel.employee_pos);
                objParam.Add("@time_data_quarter", TimeModel.time_data_quarter);

                Connection();
                mscon.Open();
                List<TimeModel> HrList = SqlMapper.Query<TimeModel>(mscon, "SP_Hr_Time_Get", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();

                mscon.Close();
                return HrList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Hr_Time_Create
        public void Hr_Time_Create(List<TimeModel> TimeModel)
        {
            try
            {

                foreach (var TIME_JOBData in TimeModel)
                {
                    DynamicParameters objParam = new DynamicParameters();

                    objParam.Add("@time_employee_code", TIME_JOBData.time_employee_code);
                    objParam.Add("@time_employee_name", TIME_JOBData.time_employee_name);
                    objParam.Add("@time_employee_pos", TIME_JOBData.time_employee_pos);
                    objParam.Add("@time_late_count", TIME_JOBData.time_late_count);
                    objParam.Add("@time_late_time", TIME_JOBData.time_late_time);
                    objParam.Add("@time_absent_count", TIME_JOBData.time_absent_count);
                    objParam.Add("@time_absent_time", TIME_JOBData.time_absent_time);
                    objParam.Add("@time_sick_leave", TIME_JOBData.time_sick_leave);
                    objParam.Add("@time_personal_leave", TIME_JOBData.time_personal_leave);
                    objParam.Add("@time_maternity_leave", TIME_JOBData.time_maternity_leave);
                    objParam.Add("@time_ordination_leave", TIME_JOBData.time_ordination_leave);
                    objParam.Add("@time_wage_leave", TIME_JOBData.time_wage_leave);
                    objParam.Add("@time_funeral_wedding_leave", TIME_JOBData.time_funeral_wedding_leave);
                    objParam.Add("@time_warning_leave", TIME_JOBData.time_warning_leave);
                    objParam.Add("@time_probate_leave", TIME_JOBData.time_probate_leave);
                    objParam.Add("@time_data_quarter", TIME_JOBData.time_data_quarter);
                    ///objParam.Add("@time_score", TimeModel.time_score);
                    objParam.Add("@created_by", TIME_JOBData.created_by);

                    Connection();
                    mscon.Open();
                    mscon.Execute("SP_Hr_Time_Create", objParam, commandType: CommandType.StoredProcedure, commandTimeout: 210);
                    mscon.Close();
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Hr_Check_Data
        public List<ChackDataModel> Hr_Check_Data(ChackDataModel ChackDataModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@data_employee_assess", ChackDataModel.data_employee_assess);
                objParam.Add("@data_quarter", ChackDataModel.data_quarter);
                objParam.Add("@data_leader_assess", ChackDataModel.data_leader_assess);

                Connection();
                mscon.Open();
                List<ChackDataModel> HrList = SqlMapper.Query<ChackDataModel>(mscon, "SP_Hr_Check_Data", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();

                mscon.Close();
                return HrList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Hr_Results_Admin_Get
        public List<ResultsModel> Hr_Results_Admin_Get(ResultsModel ResultsModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@data_leader_assess", ResultsModel.data_leader_assess);
                objParam.Add("@data_employee_assess", ResultsModel.data_employee_assess);
                objParam.Add("@data_form", ResultsModel.data_form);
                objParam.Add("@data_quarter", ResultsModel.data_quarter);
                objParam.Add("@data_assess_by", ResultsModel.data_assess_by);
                objParam.Add("@updated_status", ResultsModel.updated_status);
                objParam.Add("@employee_sec", ResultsModel.employee_sec);
                objParam.Add("@employee_dept", ResultsModel.employee_dept);
                objParam.Add("@employee_pos", ResultsModel.employee_pos);
                objParam.Add("@pms_start_date", ResultsModel.pms_start_date);
                objParam.Add("@pms_end_date", ResultsModel.pms_end_date);
                //objParam.Add("@record_status", ResultsModel.record_status);
            
                Connection();
                mscon.Open();
                List<ResultsModel> HrList = SqlMapper.Query<ResultsModel>(mscon, "SP_Hr_Assessment_Results_Admin", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();

                mscon.Close();
                return HrList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Hr_Results_Manage_Get
        public List<ResultsModel> Hr_Results_Manage_Get(ResultsModel ResultsModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@data_leader_assess", ResultsModel.data_leader_assess);
                objParam.Add("@data_employee_assess", ResultsModel.data_employee_assess);
                objParam.Add("@data_form", ResultsModel.data_form);
                objParam.Add("@data_quarter", ResultsModel.data_quarter);
                objParam.Add("@data_assess_by", ResultsModel.data_assess_by);
                objParam.Add("@updated_status", ResultsModel.updated_status);
                objParam.Add("@employee_sec", ResultsModel.employee_sec);
                objParam.Add("@employee_dept", ResultsModel.employee_dept);
                objParam.Add("@employee_pos", ResultsModel.employee_pos);
                objParam.Add("@pms_start_date", ResultsModel.pms_start_date);
                objParam.Add("@pms_end_date", ResultsModel.pms_end_date);
                //objParam.Add("@record_status", ResultsModel.record_status);

                Connection();
                mscon.Open();
                List<ResultsModel> HrList = SqlMapper.Query<ResultsModel>(mscon, "SP_Hr_Assessment_Results_Manage", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();

                mscon.Close();
                return HrList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Hr_Report_Pms
        public List<ReportPmsModel> Hr_Report_Pms(ReportPmsModel ReportPmsModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@data_id", ReportPmsModel.data_id);

                Connection();
                mscon.Open();
                List<ReportPmsModel> HrList = SqlMapper.Query<ReportPmsModel>(mscon, "SP_Hr_Report_Pms", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();

                mscon.Close();
                return HrList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Hr_Form_Get
        public List<FormModel> Hr_Form_Get(FormModel FormModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@header_type", FormModel.header_type);

                Connection();
                mscon.Open();
                List<FormModel> HrList = SqlMapper.Query<FormModel>(mscon, "SP_Hr_Form_Get", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();

                mscon.Close();
                return HrList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Hr_Form_More_Get
        public List<FormModel> Hr_Form_More_Get(FormModel FormModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@header_type", FormModel.header_type);

                Connection();
                mscon.Open();
                List<FormModel> HrList = SqlMapper.Query<FormModel>(mscon, "SP_Hr_Form_More_Get", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();

                mscon.Close();
                return HrList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Hr_Result_Assess_Get
        public List<Result_Assess_Model> Hr_Result_Assess_Get(Result_Assess_Model Result_Assess_Model)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@data_id", Result_Assess_Model.data_id);

                Connection();
                mscon.Open();
                List<Result_Assess_Model> HrList = SqlMapper.Query<Result_Assess_Model>(mscon, "SP_Hr_Result_Assess_Get", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();

                mscon.Close();
                return HrList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Hr_Verify_Assess_Get
        public List<EmployeeModel> Hr_Verify_Assess_Get(EmployeeModel EmployeeModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@data_leader_assess", EmployeeModel.data_leader_assess);

                Connection();
                mscon.Open();
                List<EmployeeModel> HrList = SqlMapper.Query<EmployeeModel>(mscon, "SP_Hr_Verify_Assess", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();

                mscon.Close();
                return HrList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Hr_Master_Get
        public List<Master_Model> Hr_Master_Get(Master_Model Master_Model)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@mode", Master_Model.mode);
                objParam.Add("@keywords", Master_Model.keywords);
                objParam.Add("@keywords1", Master_Model.keywords1);
                objParam.Add("@keywords2", Master_Model.keywords2);
                objParam.Add("@keywords3", Master_Model.keywords3);

                Connection();
                mscon.Open();
                List<Master_Model> HrList = SqlMapper.Query<Master_Model>(mscon, "SP_Hr_Master_Get", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();

                mscon.Close();
                return HrList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Hr_Assess_Confirm
        public List<Confirm_Model> Hr_Assess_Confirm(Confirm_Model Confirm_Model)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@data_leader_assess", Confirm_Model.data_leader_assess);
                objParam.Add("@data_employee_assess", Confirm_Model.data_employee_assess);
                objParam.Add("@data_quarter", Confirm_Model.data_quarter);
                objParam.Add("@count_leader_assess", Confirm_Model.count_leader_assess);
                objParam.Add("@employee_sec", Confirm_Model.employee_sec);
                objParam.Add("@employee_dept", Confirm_Model.employee_dept);
                objParam.Add("@employee_pos", Confirm_Model.employee_pos);

                Connection();
                mscon.Open();
                List<Confirm_Model> HrList = SqlMapper.Query<Confirm_Model>(mscon, "SP_Hr_Assess_Confirm", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();

                mscon.Close();
                return HrList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion
    }
}