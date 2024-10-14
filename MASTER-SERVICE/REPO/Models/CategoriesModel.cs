using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace REPO.Models
{
    public class CategoriesGetModel
    {
        public string category_id { get; set; }
        public string category_name { get; set; }
        public string parent_category_id { get; set; }
        public string event_status { get; set; }
        public int recode_status { get; set; }
        public string created_by { get; set; }
        public DateTime created_datetime { get; set; }
        public string updated_by { get; set; }
        public DateTime updated_datetime { get; set; }
        public int order_by { get; set; }
    }
}