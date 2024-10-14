using REPO.Controllers;
using REPO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace API.Controllers
{
    public class MoveMaxController : ApiController
    {

        [Route("v1/MM_ManifestNoteBike_Get")]
        [HttpGet]
        public MM_ResponseModel MM_ManifestNoteBike_Get([FromUri] string NUMBER, [FromUri] string ROUTE, [FromUri] string DRIVER, [FromUri] string CREATE_BY)
        {
            try
            {

                MoveMaxRepository MoveMaxRepository = new MoveMaxRepository();

                List<MM_ShippingNoteBookingModel> MM_ShippingNoteBookingBike_Get = (List<MM_ShippingNoteBookingModel>)MoveMaxRepository.MM_ShippingNoteBookingBike_Get(NUMBER, ROUTE, DRIVER, CREATE_BY);
                List<MM_ProductListModel> MM_ProductBike_Get = (List<MM_ProductListModel>)MoveMaxRepository.MM_ProductBike_Get(NUMBER, MM_ShippingNoteBookingBike_Get[0].code, CREATE_BY) ;

                MM_ResponseModel _MM_ResponseModel = new MM_ResponseModel();
                _MM_ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _MM_ResponseModel.manifestNoteList = MM_ShippingNoteBookingBike_Get;
                _MM_ResponseModel.length = MM_ShippingNoteBookingBike_Get.Count();
                _MM_ResponseModel.ProductList = MM_ProductBike_Get;
                _MM_ResponseModel.Productlength = MM_ProductBike_Get.Count();
                _MM_ResponseModel.status = "Success";

                return _MM_ResponseModel;
            }
            catch (Exception ex)
            {
                MM_ResponseModel _MM_ResponseModel = new MM_ResponseModel();
                _MM_ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _MM_ResponseModel.status = "Error";
                _MM_ResponseModel.error_message = ex.Message.ToString();
                _MM_ResponseModel.error_stacktrace = ex.StackTrace.ToString();
                _MM_ResponseModel.error_source = ex.Source.ToString();

                return _MM_ResponseModel;
            }

        }

        [Route("v1/MM_ManifestNoteJobCreate")]
        [HttpPost]
        public ResponseModel MM_ManifestNoteJob_Create([FromBody] MM_ManifestNoteJobModel MM_ManifestNoteJobModel)
        {
            try
            {
                MoveMaxRepository MoveMaxRepository = new MoveMaxRepository();

                MoveMaxRepository.MM_ManifestNoteJob_Create(MM_ManifestNoteJobModel);
                ResponseModel _ResponseModel = new ResponseModel();
                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
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
