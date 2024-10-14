using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace REPO.Models
{
    public class MasterDataModel
    {
        public string mode { get; set; }

        public string id { get; set; }
        public string text { get; set; }
    
        public string keywords { get; set; }
        public string parameter_1 { get; set; }
        public string parameter_2 { get; set; }
        public string parameter_3 { get; set; }
        public string parameter_4 { get; set; }

    }

}