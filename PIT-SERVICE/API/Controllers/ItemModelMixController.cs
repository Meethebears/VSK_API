using REPO.Models;
using REPO.Controllers;
using System.Web.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;

namespace API.Controllers
{
    public class ItemModelMixController : ApiController
    {

        #region Item_ModelMix_ItemLastUpdatetime_Get
        [Route("api/Item_ModelMix_ItemLastUpdatetime_Get")]
        [HttpGet]
        public ResponseModel Item_ModelMix_ItemLastUpdatetime_Get([FromUri] TempItemModelMixModel TempItemModelMixModel)
        {

            try
            {
                CultureInfo cultureinfo = new CultureInfo("en-US");

                ItemModelMixRepository ItemModelMixRepository = new ItemModelMixRepository();

                List<TempItemModelMixModel> Item_ModelMix_ItemLastUpdatetime_Get = ItemModelMixRepository.Item_ModelMix_ItemLastUpdatetime_Get(TempItemModelMixModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = Item_ModelMix_ItemLastUpdatetime_Get;
                _ResponseModel.length = Item_ModelMix_ItemLastUpdatetime_Get.Count();
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
        #endregion

        #region Item_ModelMix_ProductGroupSales_Get
        [Route("api/Item_ModelMix_ProductGroupSales_Get")]
        [HttpGet]
        public ResponseModel Item_ModelMix_ProductGroupSales_Get([FromUri] TempItemModelMixModel TempItemModelMixModel)
        {

            try
            {
                CultureInfo cultureinfo = new CultureInfo("en-US");

                ItemModelMixRepository ItemModelMixRepository = new ItemModelMixRepository();

                List<TempItemModelMixModel> Item_ModelMix_ProductGroupSales_Get = ItemModelMixRepository.Item_ModelMix_ProductGroupSales_Get(TempItemModelMixModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = Item_ModelMix_ProductGroupSales_Get;
                _ResponseModel.length = Item_ModelMix_ProductGroupSales_Get.Count();
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
        #endregion

        #region Item_ModelMix_KeywordsSearchItem_Get
        [Route("api/Item_ModelMix_KeywordsSearchItem_Get")]
        [HttpGet]
        public ResponseModel Item_ModelMix_KeywordsSearchItem_Get([FromUri] ItemModelMixModel ItemModelMixModel)
        {

            try
            {
                CultureInfo cultureinfo = new CultureInfo("en-US");

                ItemModelMixRepository ItemModelMixRepository = new ItemModelMixRepository();

                List<ItemModelMixModel> Item_ModelMix_KeywordsSearchItem_Get = ItemModelMixRepository.Item_ModelMix_KeywordsSearchItem_Get(ItemModelMixModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = Item_ModelMix_KeywordsSearchItem_Get;
                _ResponseModel.length = Item_ModelMix_KeywordsSearchItem_Get.Count();
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
        #endregion

        #region Item_ModelMix_KeywordsSearchItem_Muti_Get
        [Route("api/Item_ModelMix_KeywordsSearchItem_Muti_Get")]
        [HttpGet]
        public ResponseModel Item_ModelMix_KeywordsSearchItem_Muti_Get([FromUri] ItemModelMixModel ItemModelMixModel)
        {

            try
            {
                CultureInfo cultureinfo = new CultureInfo("en-US");

                ItemModelMixRepository ItemModelMixRepository = new ItemModelMixRepository();

                List<ItemModelMixModel> Item_ModelMix_KeywordsSearchItem_Muti_Get = ItemModelMixRepository.Item_ModelMix_KeywordsSearchItem_Muti_Get(ItemModelMixModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = Item_ModelMix_KeywordsSearchItem_Muti_Get;
                _ResponseModel.length = Item_ModelMix_KeywordsSearchItem_Muti_Get.Count();
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
        #endregion
    }
}