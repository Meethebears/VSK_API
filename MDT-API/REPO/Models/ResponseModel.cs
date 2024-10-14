using System;
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

    public partial class DTT_RequestModel
    {

        public int draw { get; set; }
        public int start { get; set; }
        public int length { get; set; }
        public string search { get; set; }
    }
    public partial class DTT_ResponseModel
    {
        public string result_datetime { get; set; }
        public int draw { get; set; }
        public object data { set; get; }
        public int recordsFiltered { get; set; }
        public int recordsTotal { get; set; }
        public string status { get; set; }
        public string error_message { get; set; }
        public string error_stacktrace { get; set; }
        public string error_source { get; set; }
    }

    public partial class MRP_ResponseModel
    {
        public string result_datetime { get; set; }
        public int length { get; set; }
        public string status { get; set; }
        public string error_message { get; set; }
        public string error_stacktrace { get; set; }
        public string error_source { get; set; }
        public object data { set; get; }
        public string source_site_code { set; get; }
        public string destination_site_code { set; get; }

    }

    public class ResponseSelect2Model
    {
        public string id { get; set; }
        public string text { get; set; }

    }

}