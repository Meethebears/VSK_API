﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace REPO.Models
{
    public partial class DashboardModel
    {
        //start 1 รายละเอียด //
        public string pk_date { get; set; }
        public string dashboard_id { get; set; }
        public string pk_type { get; set; }
        public string std_name { get; set; }
        /*
        public string pk_date { get; set; }
        public string pk_type { get; set; }
        */
        public string WH { get; set; }
        public string on_time { get; set; }
        public int sku_count_onprocess { get; set; }
        public int sku_count_checked { get; set; }
        public int bill_count_onprocess { get; set; }
        public int bill_count_checked { get; set; }
        public string created_by { get; set; }
        public DateTime created_date { get; set; }
        public string updated_by { get; set; }
        public DateTime updated_date { get; set; }
        public string record_status { get; set; }
        public DateTime last_updated_time { get; set; }
        public int sku_total { get; set; }
        public int bill_total { get; set; }
        public int sku_count_pka { get; set; }
        public int bill_count_pka { get; set; }
        public int sku_count_pkb { get; set; }
        public int bill_count_pkb { get; set; }
    }

    public partial class InvoiceModel
    {
        //start 1 รายละเอียด //
        public string invoice_id { get; set; }
        public string invoice_name { get; set; }
        public DateTime invoice_date { get; set; }
        public string invoice_on_time { get; set; }
        public string invoice_order_type { get; set; }
        public int invoice_count { get; set; }
        public string created_by { get; set; }
        public DateTime created_date { get; set; }
        public string updated_by { get; set; }
        public DateTime updated_date { get; set; }
        public string record_status { get; set; }
        public DateTime last_updated_time { get; set; }
        public string pk_date { get; set; }
        public string inv_total_date { get; set; }
        public DateTime inv_total_last_time { get; set; }
        public string inv_total_name { get; set; }
        public int inv_total_count { get; set; }
        public int inv_total_on_process { get; set; }
        public int inv_total_complete { get; set; }
        public DateTime bl_last_time { get; set; }
        public string bl_date { get; set; }
        public string bl1_name { get; set; }
        public int bl1_count { get; set; }
        public int bl_bike_count1{ get; set; }
        public int bl_car_count1 { get; set; }
        public int store1_count { get; set; }
        public int bike1_count { get; set; }
        public int car1_count { get; set; }
        public string bl2_name { get; set; }
        public int bl2_count { get; set; }
        public int bl_bike_count2 { get; set; }
        public int bl_car_count2 { get; set; }
        public int store2_count { get; set; }
        public int bike2_count { get; set; }
        public int car2_count { get; set; }
        public string bl3_name { get; set; }
        public int bl3_count { get; set; }
        public int bl_bike_count3 { get; set; }
        public int bl_car_count3 { get; set; }
        public int store3_count { get; set; }
        public int bike3_count { get; set; }
        public int car3_count { get; set; }
        public string bl4_name { get; set; }
        public int bl4_count { get; set; }
        public int bl_bike_count4 { get; set; }
        public int bl_car_count4 { get; set; }
        public int store4_count { get; set; }
        public int bike4_count { get; set; }
        public int car4_count { get; set; }
        public string bl5_name { get; set; }
        public int bl5_count { get; set; }
        public int bl_bike_count5 { get; set; }
        public int bl_car_count5 { get; set; }
        public int store5_count { get; set; }
        public int bike5_count { get; set; }
        public int car5_count { get; set; }
        public string bl6_name { get; set; }
        public int bl6_count { get; set; }
        public int bl_bike_count6 { get; set; }
        public int bl_car_count6 { get; set; }
        public int store6_count { get; set; }
        public int bike6_count { get; set; }
        public int car6_count { get; set; }
        public string bl7_name { get; set; }
        public int bl7_count { get; set; }
        public int bl_bike_count7 { get; set; }
        public int bl_car_count7 { get; set; }
        public int store7_count { get; set; }
        public int bike7_count { get; set; }
        public int car7_count { get; set; }
        public string bl8_name { get; set; }
        public int bl8_count { get; set; }
        public int bl_bike_count8 { get; set; }
        public int bl_car_count8 { get; set; }
        public int store8_count { get; set; }
        public int bike8_count { get; set; }
        public int car8_count { get; set; }
        public string bl9_name { get; set; }
        public int bl9_count { get; set; }
        public int bl_bike_count9 { get; set; }
        public int bl_car_count9 { get; set; }
        public int store9_count { get; set; }
        public int bike9_count { get; set; }
        public int car9_count { get; set; }
        public string bl10_name { get; set; }
        public int bl10_count { get; set; }
        public int bl_bike_count10 { get; set; }
        public int bl_car_count10 { get; set; }
        public int store10_count { get; set; }
        public int bike10_count { get; set; }
        public int car10_count { get; set; }
        public string bl11_name { get; set; }
        public int bl11_count { get; set; }
        public int bl_bike_count11 { get; set; }
        public int bl_car_count11 { get; set; }
        public int store11_count11 { get; set; }
        public int bike11_count { get; set; }
        public int car11_count { get; set; }
        public int bl_ytd_count { get; set; }
        public int bl_ytd_bike_count { get; set; }
        public int bl_ytd_car_count { get; set; }

    }

    public partial class TMS_JOBModel
    {
        public DateTime tms_job_date { get; set; }
        public string tms_job_route { get; set; }
        public string tms_job_plate { get; set; }
        public string tms_job_name { get; set; }
        public string tms_job_no { get; set; }
        public string tms_job_cus_name { get; set; }
        public DateTime tms_job_created_date { get; set; }
        public DateTime tms_job_delivery_date { get; set; }
        public string tms_job_status { get; set; }
        public string statusId { get; set; }

    }
   
}