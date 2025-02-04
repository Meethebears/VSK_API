﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace REPO.Models
{
    public partial class ResponseModel
    {
        public string result_datetime { get; set; }
        public int length { get; set; }
        public string status { get; set; }
        public string error_message { get; set; }
        public string error_stacktrace { get; set; }
        public string error_source { get; set; }
        public object data { set; get; }

    }

    public class ResponseSelect2Model
    {
        public string id { get; set; }
        public string text { get; set; }
        public string lname { get; set; }
        public string name { get; set; }
        public string mode { get; set; }
        public string code { get; set; }
        public string DiscGroup { get; set; }
        public string gcode_a { get; set; }
        public string gname { get; set; }
        public string codechr { get; set; }
        public string itemgroup { get; set; }
        public string groupname { get; set; }
        public string uom { get; set; }
        public string userid { get; set; }
        public string startdate { get; set; }
        public string rec { get; set; }
        public string lov_code { get; set; }
        public string keywords { get; set; }
    }


    public class ResponseStmasSelect2Model
    {
        public string id { get; set; }
        public string text { get; set; }
        public string avgcost { get; set; }
        public string AvgSalecost { get; set; }
        public string UOM { get; set; }
        public string name { get; set; }


    }

}