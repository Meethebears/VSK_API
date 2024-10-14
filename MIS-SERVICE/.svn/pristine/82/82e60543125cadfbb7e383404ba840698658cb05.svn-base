using REPO.Controllers;
using REPO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace API.Controllers
{
    public class ItemMasterController : ApiController
    {
        [Route("v1/stmas_get")]
        [HttpGet]
        public ResponseModel Stmas_Get([FromUri] string item_code)
        {
            try
            {
                ItemMasterRepository AccurateRepository = new ItemMasterRepository();
                List<StmasModel> Stmas_Get = AccurateRepository.Stmas_Get(item_code);
                ResponseModel _ResponseModel = new ResponseModel();
                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = Stmas_Get;
                _ResponseModel.length = Stmas_Get.Count();
                _ResponseModel.status = "Success";

                return _ResponseModel;
            }
            catch (Exception ex)
            {
                ResponseModel _ResponseModel = new ResponseModel();
                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.status = "Error";
                _ResponseModel.error_message = ex.Message.ToString();
                _ResponseModel.error_stacktrace = ex.StackTrace.ToString();
                _ResponseModel.error_source = ex.Source.ToString();

                return _ResponseModel;
            }

        }

        [Route("v1/stmas_search")]
        [HttpGet]
        public ResponseModel Stmas_Search([FromUri] string item_code = "", [FromUri] string item_name = "", [FromUri] string item_CHRCODE = "", [FromUri] string item_SPCODES = "", [FromUri] string item_gbarcode = "", [FromUri] string mode = "")
        {
            try
            {
                ItemMasterRepository AccurateRepository = new ItemMasterRepository();
                List<StmasModel> Stmas_Search = AccurateRepository.Stmas_Search(item_code, item_name, item_CHRCODE, item_SPCODES, item_gbarcode, mode);
                ResponseModel _ResponseModel = new ResponseModel();
                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = Stmas_Search;
                _ResponseModel.length = Stmas_Search.Count();
                _ResponseModel.status = "Success";

                return _ResponseModel;
            }
            catch (Exception ex)
            {
                ResponseModel _ResponseModel = new ResponseModel();
                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.status = "Error";
                _ResponseModel.error_message = ex.Message.ToString();
                _ResponseModel.error_stacktrace = ex.StackTrace.ToString();
                _ResponseModel.error_source = ex.Source.ToString();

                return _ResponseModel;
            }

        }

        [Route("v1/product_purplan_stock_factor_get")]
        [HttpGet]
        public ResponseModel Product_PurPlan_Stock_Factor_Get([FromUri] string item_code)
        {
            try
            {
                ItemMasterRepository AccurateRepository = new ItemMasterRepository();
                List<Product_PurPlan_Stock_FactorModel> Product_PurPlan_Stock_Factor_Get = AccurateRepository.Product_PurPlan_Stock_Factor_Get(item_code);
                ResponseModel _ResponseModel = new ResponseModel();
                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = Product_PurPlan_Stock_Factor_Get;
                _ResponseModel.length = Product_PurPlan_Stock_Factor_Get.Count();
                _ResponseModel.status = "Success";

                return _ResponseModel;
            }
            catch (Exception ex)
            {
                ResponseModel _ResponseModel = new ResponseModel();
                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.status = "Error";
                _ResponseModel.error_message = ex.Message.ToString();
                _ResponseModel.error_stacktrace = ex.StackTrace.ToString();
                _ResponseModel.error_source = ex.Source.ToString();

                return _ResponseModel;
            }

        }

        [Route("v2/product_purplan_stock_factor_get")]
        [HttpGet]
        public ResponseModel Product_PurPlan_Stock_Factor_Get_V2([FromUri] string item_code)
        {
            try
            {
                ItemMasterRepository AccurateRepository = new ItemMasterRepository();
                List<Product_PurPlan_Stock_FactorModel_v2> Product_PurPlan_Stock_Factor_Get = AccurateRepository.Product_PurPlan_Stock_Factor_Get_v2(item_code);
                ResponseModel _ResponseModel = new ResponseModel();
                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = Product_PurPlan_Stock_Factor_Get;
                _ResponseModel.length = Product_PurPlan_Stock_Factor_Get.Count();
                _ResponseModel.status = "Success";

                return _ResponseModel;
            }
            catch (Exception ex)
            {
                ResponseModel _ResponseModel = new ResponseModel();
                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.status = "Error";
                _ResponseModel.error_message = ex.Message.ToString();
                _ResponseModel.error_stacktrace = ex.StackTrace.ToString();
                _ResponseModel.error_source = ex.Source.ToString();

                return _ResponseModel;
            }

        }

        [Route("v1/gcode_get")]
        [HttpGet]
        public ResponseModel Gcode_Get([FromUri] GcodeModel GcodeModel)
        {
            try
            {
                ItemMasterRepository AccurateRepository = new ItemMasterRepository();
                List<GcodeModel> Gcode_Get = AccurateRepository.Gcode_Get(GcodeModel);
                ResponseModel _ResponseModel = new ResponseModel();
                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = Gcode_Get;
                _ResponseModel.length = Gcode_Get.Count();
                _ResponseModel.status = "Success";

                return _ResponseModel;
            }
            catch (Exception ex)
            {
                ResponseModel _ResponseModel = new ResponseModel();
                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.status = "Error";
                _ResponseModel.error_message = ex.Message.ToString();
                _ResponseModel.error_stacktrace = ex.StackTrace.ToString();
                _ResponseModel.error_source = ex.Source.ToString();

                return _ResponseModel;
            }

        }

        [Route("v1/goodprice_get")]
        [HttpGet]
        public ResponseModel Goodprice_Get([FromUri] string item_code, [FromUri] string item_gbarcode = "")
        {
            try
            {
                ItemMasterRepository AccurateRepository = new ItemMasterRepository();
                List<GoodpriceModel> Goodprice_Get = AccurateRepository.Goodprice_Get(item_code, item_gbarcode);
                ResponseModel _ResponseModel = new ResponseModel();
                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = Goodprice_Get;
                _ResponseModel.length = Goodprice_Get.Count();
                _ResponseModel.status = "Success";

                return _ResponseModel;
            }
            catch (Exception ex)
            {
                ResponseModel _ResponseModel = new ResponseModel();
                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.status = "Error";
                _ResponseModel.error_message = ex.Message.ToString();
                _ResponseModel.error_stacktrace = ex.StackTrace.ToString();
                _ResponseModel.error_source = ex.Source.ToString();

                return _ResponseModel;
            }

        }

        [Route("v1/glocat_get")]
        [HttpGet]
        public ResponseModel Glocat_get([FromUri] string wh_code)
        {
            try
            {
                ItemMasterRepository AccurateRepository = new ItemMasterRepository();
                List<GlocatModel> Glocat_get = AccurateRepository.Glocat_get(wh_code);
                ResponseModel _ResponseModel = new ResponseModel();
                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = Glocat_get;
                _ResponseModel.length = Glocat_get.Count();
                _ResponseModel.status = "Success";

                return _ResponseModel;
            }
            catch (Exception ex)
            {
                ResponseModel _ResponseModel = new ResponseModel();
                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.status = "Error";
                _ResponseModel.error_message = ex.Message.ToString();
                _ResponseModel.error_stacktrace = ex.StackTrace.ToString();
                _ResponseModel.error_source = ex.Source.ToString();

                return _ResponseModel;
            }

        }

        // tbl tbdata
        [Route("v1/uom_get")]
        [HttpGet]
        public ResponseModel Uom_get([FromUri] string uom_code)
        {
            try
            {
                ItemMasterRepository AccurateRepository = new ItemMasterRepository();
                List<UomModel> Uom_get = AccurateRepository.Uom_get(uom_code);
                ResponseModel _ResponseModel = new ResponseModel();
                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = Uom_get;
                _ResponseModel.length = Uom_get.Count();
                _ResponseModel.status = "Success";

                return _ResponseModel;
            }
            catch (Exception ex)
            {
                ResponseModel _ResponseModel = new ResponseModel();
                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.status = "Error";
                _ResponseModel.error_message = ex.Message.ToString();
                _ResponseModel.error_stacktrace = ex.StackTrace.ToString();
                _ResponseModel.error_source = ex.Source.ToString();

                return _ResponseModel;
            }

        }
       
        [Route("v1/gcode_select2_get")]
        [HttpGet]
        public ResponseModel Gcode_Select2_Get([FromUri] GcodeModel GcodeModel)
        {
            try
            {
                ItemMasterRepository ItemMasterRepository = new ItemMasterRepository();
                List<ResponseSelect2Model> Gcode_Select2_Get = ItemMasterRepository.Gcode_Select2_Get(GcodeModel);

                ResponseModel _ResponseModel = new ResponseModel();
                
                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = Gcode_Select2_Get;
                _ResponseModel.length = Gcode_Select2_Get.Count();
                _ResponseModel.status = "Success";

                return _ResponseModel;
            }
            catch (Exception ex)
            {
                ResponseModel _ResponseModel = new ResponseModel();
                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.status = "Error";
                _ResponseModel.error_message = ex.Message.ToString();
                _ResponseModel.error_stacktrace = ex.StackTrace.ToString();
                _ResponseModel.error_source = ex.Source.ToString();

                return _ResponseModel;
            }

        }
        

    }
}
