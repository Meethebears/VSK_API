﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace REPO.Models
{
    public partial class DetailModel
    {
        //start 1 รายละเอียด //
        public string employee_id { get; set; }
        public string employee_code { get; set; }
        public string employee_prefix { get; set; }
        public string employee_name { get; set; }
        public string employee_nickname { get; set; }
        public string employee_sec { get; set; }
        public string employee_dept { get; set; }
        public string employee_pos { get; set; }
        public DateTime employee_job_startdate { get; set; }
        public string employee_leader_asses1 { get; set; }
        public string employee_leader_asses2 { get; set; }
        public string employee_leader_asses3 { get; set; }
        public string employee_form { get; set; }
        public string created_by { get; set; }
        public DateTime created_date { get; set; }
        public string updated_by { get; set; }
        public DateTime updated_date { get; set; }
        public string record_status { get; set; }

        public string code { get; set; }
        public string data_quarter { get; set; }
        public string quarter_id { get; set; }
        public string quarter_name { get; set; }
        public string time_id { get; set; }
        public string time_employee_code { get; set; }
        public string time_employee_name { get; set; }
        public string time_employee_pos { get; set; }
        public string time_late_count { get; set; }
        public string time_late_time { get; set; }
        public string time_absent_count { get; set; }
        public string time_absent_time { get; set; }
        public string time_sick_leave { get; set; }
        public string time_personal_leave { get; set; }
        public string time_maternity_leave { get; set; }
        public string time_ordination_leave { get; set; }
        public string time_wage_leave { get; set; }
        public string time_funeral_wedding_leave { get; set; }
        public string time_warning_leave { get; set; }
        public string time_probate_leave { get; set; }
        public string time_data_quarter { get; set; }
        public string time_score { get; set; }
        public string updated_status { get; set; }

    }

    public partial class QuarterModel
    {
        //start 1 รายละเอียด //
        public string employee_code { get; set; }
        public string quarter_id { get; set; }
        public string quarter_year { get; set; }
        public string quarter_name { get; set; }
        public string quarter_status { get; set; }
        public string created_by { get; set; }
        public string created_date { get; set; }
        public string updated_by { get; set; }
        public string updated_date { get; set; }
        public string record_status { get; set; }
        public string quarter_value { get; set; }
        public string quarter_order { get; set; }
        public string quarter_code { get; set; }

    }

    public partial class CreateDATAModel
    {
        //start 1 รายละเอียด //
        public string data_id { get; set; }
        public string data_leader_assess { get; set; }
        public string data_employee_assess { get; set; }
        public int data_form { get; set; }
        public string data_quarter { get; set; }
        public int data_assess_by { get; set; }
        public string data_score_pms { get; set; }
        public string data_percent_pms { get; set; }
        public string record_status { get; set; }
        public string created_by { get; set; }
        public DateTime created_date { get; set; }
        public string updated_by { get; set; }
        public DateTime updated_date { get; set; }
        public string updated_status { get; set; }
        public string updated_command { get; set; }
        public string data_c_good { get; set; }
        public string data_c_fail { get; set; }

    }

    public partial class EmployeeModel
    {
        //start 1 รายละเอียด //
        public string trans_id { get; set; }
        public string temp_id { get; set; }
        public string employee_id { get; set; }
        public string user_id { get; set; }
        public string employee_code { get; set; }
        public string employee_prefix { get; set; }
        public string employee_name { get; set; }
        public string employee_nickname { get; set; }
        public string employee_sec { get; set; }
        public string employee_dept { get; set; }
        public string employee_pos { get; set; }
        public string employee_sec_id { get; set; }
        public string employee_dept_id { get; set; }
        public string employee_pos_id { get; set; }
        public DateTime employee_job_startdate { get; set; }
        public string employee_leader { get; set; }
        public string employee_leader_asses1 { get; set; }
        public string employee_leader_asses2 { get; set; }
        public string employee_leader_asses3 { get; set; }
        public string employee_form { get; set; }
        public string created_by { get; set; }
        public DateTime created_date { get; set; }
        public string updated_by { get; set; }
        public DateTime updated_date { get; set; }
        public int record_status { get; set; }
        public string data_leader_assess { get; set; }
        public string status_assess { get; set; }
        public string employee_prefix_th { get; set; }
        public string employee_first_name_th { get; set; }
        public string employee_last_name_th { get; set; }
        public string employee_full_name_th { get; set; }
        public string employee_prefix_en { get; set; }
        public string employee_first_name_en { get; set; }
        public string employee_last_name_en { get; set; }
        public string employee_full_name_en { get; set; }
        public string employee_photo { get; set; }
        public string employee_nickname_en { get; set; }
        public string employee_nickname_th { get; set; }

    }

    public partial class JobModel
    {
        //start 1 รายละเอียด //
        public string job_id { get; set; }
        public string job_name { get; set; }
        public string job_type { get; set; }
        public string created_by { get; set; }
        public DateTime created_date { get; set; }
        public string updated_by { get; set; }
        public DateTime updated_date { get; set; }
        public int record_status { get; set; }

    }

    public partial class TimeModel
    {
        public string time_id { get; set; }
        public string time_employee_code { get; set; }
        public string time_employee_name { get; set; }
        public string time_employee_pos { get; set; }
        public string time_late_count { get; set; }
        public string time_late_time { get; set; }
        public string time_absent_count { get; set; }
        public string time_absent_time { get; set; }
        public string time_sick_leave { get; set; }
        public string time_personal_leave { get; set; }
        public string time_maternity_leave { get; set; }
        public string time_ordination_leave { get; set; }
        public string time_wage_leave { get; set; }
        public string time_funeral_wedding_leave { get; set; }
        public string time_warning_leave { get; set; }
        public string time_probate_leave { get; set; }
        public string time_data_quarter { get; set; }
        public string time_score { get; set; }
        public string created_by { get; set; }
        public DateTime created_date { get; set; }
        public string updated_by { get; set; }
        public DateTime updated_date { get; set; }
        public int record_status { get; set; }
        public string employee_name { get; set; }
        public string employee_code { get; set; }
        public string employee_sec { get; set; }
        public string employee_dept { get; set; }
        public string employee_pos{ get; set; }

    }

    public partial class ScoreCreateModel
    {
        //start 1 รายละเอียด //
        public string sc_id { get; set; }
        public string sc_data_id { get; set; }
        public string sc_topic { get; set; }
        public string sc_weight { get; set; }
        public int sc_score { get; set; }
        public string sc_subheader_id { get; set; }
        public string sc_comment { get; set; }
        public int sc_order { get; set; }
        public int record_status { get; set; }
        public string created_by { get; set; }
        public DateTime created_date { get; set; }
        public string updated_by { get; set; }
        public DateTime updated_date { get; set; }

    }

    public partial class ScoreModel
    {
        //start 1 รายละเอียด //
        public string sc_id { get; set; }
        public string sc_data_id { get; set; }
        public string sc_answer_1 { get; set; }
        public string sc_answer_2_1 { get; set; }
        public string sc_answer_2_2 { get; set; }
        public string sc_answer_2_3 { get; set; }
        public string sc_answer_2_4 { get; set; }
        public string sc_answer_more { get; set; }
        public int record_status { get; set; }
        public string created_by { get; set; }
        public DateTime created_date { get; set; }
        public string updated_by { get; set; }
        public DateTime updated_date { get; set; }
        
    }

    public partial class ChackDataModel
    {
        //start 1 รายละเอียด //
        public string data_employee_assess { get; set; }
        public string data_quarter { get; set; }
        public string data_leader_assess { get; set; }
        public string data_assess_by { get; set; }
        public string status { get; set; }
        public string updated_status { get; set; }
        public DateTime created_date { get; set; }
    }

    public partial class ResultsModel
    {
        //start 1 รายละเอียด //

        public string pms_start_date { get; set; }
        public string pms_end_date { get; set; }
        public string employee_code { get; set; }
        public string employee_sec { get; set; }
        public string employee_dept { get; set; }
        public string employee_pos { get; set; }
        public string leader_code { get; set; }
        public string leader_sec { get; set; }
        public string leader_dept { get; set; }
        public string leader_pos { get; set; }
        public string data_id { get; set; }
        public string data_leader_assess { get; set; }
        public string leader_name { get; set; }
        public string data_employee_assess { get; set; }
        public string employee_name { get; set; }
        public int data_form { get; set; }
        public string data_form_name { get; set; }
        public string data_quarter { get; set; }
        public string quarter_name { get; set; }
        public int data_assess_by { get; set; }
        public string assess_by { get; set; }
        public string data_score_pms { get; set; }
        public string data_percent_pms { get; set; }
        public string data_c_good { get; set; }
        public string data_c_fail { get; set; }
        public string time_score { get; set; }
        public int record_status { get; set; }
        public string created_by { get; set; }
        public DateTime created_date { get; set; }
        public string updated_by { get; set; }
        public DateTime updated_date { get; set; }
        public string updated_status { get; set; }
        public string updated_command { get; set; }
    }

    public partial class ReportPmsModel
    {
        //start 1 รายละเอียด //
        public string data_id { get; set; }
        public string score_id { get; set; }
        public string sc_data_id { get; set; }
        public string sc_topic { get; set; }
        public string sc_weight { get; set; }
        public int sc_score { get; set; }
        public string sc_comment { get; set; }
        public int sc_order { get; set; }
        public int record_status { get; set; }
        public string created_by { get; set; }
        public DateTime created_date { get; set; }
        public string updated_by { get; set; }
        public DateTime updated_date { get; set; }
    }

    public partial class TimeAllModel
    {
        public string time_id { get; set; }
        public string time_score { get; set; }
        public string created_by { get; set; }
        public DateTime created_date { get; set; }
        public string updated_by { get; set; }
        public DateTime updated_date { get; set; }
        public int record_status { get; set; }

    }

    public partial class FormModel
    {
        public string header_id { get; set; }
        public string header_subject { get; set; }
        public double header_weight { get; set; }
        public int header_order { get; set; }
        public string header_type { get; set; }
        public string subheader_id { get; set; }
        public string subheader_name { get; set; }
        public int subheader_order { get; set; }
        public double subheader_weight { get; set; }
        public int subheader_choice { get; set; }
        public string topic_id { get; set; }
        public string topic_name { get; set; }
        public int topic_order { get; set; }
        public double topic_weight { get; set; }
    }

    public partial class Result_Assess_Model
    {
        public string data_id { get; set; }
        public string name_leader_assess { get; set; }
        public string name_employee_assess { get; set; }
        public string job_dept { get; set; }
        public string job_pos { get; set; }
        public string job_sec { get; set; }
        public DateTime employee_job_startdate { get; set; }
        public string quarter_name { get; set; }
        public string data_quarter { get; set; }
        public string employee_code { get; set; }
        public string data_score_pms { get; set; }
        public string data_percent_pms { get; set; }
        public string data_c_good { get; set; }
        public string data_c_fail { get; set; }
        public string sc_subheader_id { get; set; }
        public string sc_topic { get; set; }
        public string sc_weight { get; set; }
        public int sc_score { get; set; }
        public string sc_comment { get; set; }
        public int sc_order { get; set; }
        public int data_assess_by { get; set; }
    }
    
    public partial class Master_Model
    {
        public string mode { get; set; }
        public string keywords { get; set; }
        public string keywords1 { get; set; }
        public string keywords2 { get; set; }
        public string keywords3 { get; set; }
        public string id { get; set; }
        public string text { get; set; }
        public string code { get; set; }
        public string name { get; set; }
        
    }

    public partial class Confirm_Model
    {
        public string data_leader_assess { get; set; }
        public string data_employee_assess { get; set; }
        public string data_quarter { get; set; }
        public string updated_status { get; set; }
        public string employee_sec { get; set; }
        public string employee_dept { get; set; }
        public string employee_pos { get; set; }
        public string employee_id { get; set; }
        public string employee_code { get; set; }
        public string employee_full_name_th { get; set; }
        public string employee_data_id { get; set; }
        public string employee_pms { get; set; }
        public string leader_data_id_1 { get; set; }
        public string leader_name_1 { get; set; }
        public string leader_pms_1 { get; set; }
        public string leader_data_id_2 { get; set; }
        public string leader_name_2 { get; set; }
        public string leader_pms_2 { get; set; }
        public string leader_data_id_3 { get; set; }
        public string leader_name_3 { get; set; }
        public string leader_pms_3 { get; set; }
        public string check_assess { get; set; }
        public string check_leader { get; set; }
        public string count_leader_assess { get; set; }

    }
}