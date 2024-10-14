using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace REPO.Models
{
    public partial class ReturnModel
    {
        //start 1 รายละเอียด //
        public string mode { get; set; }
        public string temp_id { get; set; }
        public string ref_id { get; set; }
        public string rtfile_id { get; set; }
        public string rtfile_temp_id { get; set; }
        public string rtfile_ref_id { get; set; }
        public string rtfile_rt_no { get; set; }
        public string return_no { get; set; }
        public DateTime rtfile_rt_date { get; set; }
        public string rtfile_start_branch { get; set; }
        public string rtfile_end_branch { get; set; }
        public int rtfile_item_amount { get; set; }
        public int rtfile_item_qty { get; set; }
        public int rttra_sum_qty { get; set; }

        public string rttra_temp_id { get; set; }
        public string rttra_item_code { get; set; }
        public string rttra_rt_no { get; set; }
        public string rttra_item_name { get; set; }
        public string rttra_uom { get; set; }
        public int rttra_qty { get; set; }
        public string rttra_price { get; set; }
        public string rttra_location { get; set; }
        public string rttra_zone { get; set; }
        public string rttra_branch { get; set; }

        public string trndate_start { get; set; }
        public string trndate_end { get; set; }
        public string branch { get; set; }
        public string gbarcode { get; set; }
        public string event_name { get; set; }
        public string event_status { get; set; }
        public string created_by { get; set; }
        public DateTime created_date { get; set; }
        public string updated_by { get; set; }
        public DateTime updated_date { get; set; }
        public int record_status { get; set; }
        public string text_status { get; set; }
        public string rtfile_remark { get; set; }

    }

    public partial class RtFileModel
    {
        //start 1 รายละเอียด //
        public string mode { get; set; }
        public string rtfile_id { get; set; }
        public string rtfile_temp_id { get; set; }
        public string rtfile_ref_id { get; set; }
        public string return_no { get; set; }
        public string rtfile_remark { get; set; }
        public DateTime rtfile_rt_date { get; set; }
        public string rtfile_start_branch { get; set; }
        public string rtfile_end_branch { get; set; }
        public string event_name { get; set; }
        public string event_status { get; set; }
        public string created_by { get; set; }
        public DateTime created_date { get; set; }
        public string updated_by { get; set; }
        public DateTime updated_date { get; set; }
        public int record_status { get; set; }
        public int rtfile_item_amount { get; set; }
        public int rtfile_item_qty { get; set; }

    }

}