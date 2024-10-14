using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using REPO.Models;
using REPO.Controllers;
using System.Web.Http;
using System.Globalization;


namespace API.Controllers
{
    public class BarcodePackageController : ApiController
    {

        #region BARCODE_PACKAGE_FILE_CREATE
        [Route("api/BARCODE_PACKAGE_FILE_CREATE")]
        [HttpPost]
        public ResponseModel BARCODE_PACKAGE_FILE_CREATE([FromBody] BarcodePackageFileModel BarcodePackageFileModel)
        {
            try
            {

                BarcodePackageRepository BarcodePackageRepository = new BarcodePackageRepository();

                List<BarcodePackageFileModel> BARCODE_PACKAGE_FILE_CREATE = BarcodePackageRepository.BARCODE_PACKAGE_FILE_CREATE(BarcodePackageFileModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = BARCODE_PACKAGE_FILE_CREATE;
                _ResponseModel.length = BARCODE_PACKAGE_FILE_CREATE.Count();
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

        #region  BARCODE_PACKAGE_DATA_IMPORT
        [Route("api/BARCODE_PACKAGE_DATA_IMPORT")]
        [HttpPost]
        public ResponseModel STMAS_IMPORT_CREATE([FromBody] IEnumerable<BarcodePackageDataModel> BarcodePackageDataModel)
        {
            try
            {
                ResponseModel _ResponseModel = new ResponseModel();

                BarcodePackageRepository BarcodePackageRepository = new BarcodePackageRepository();

                List<BarcodePackageDataModel> ImportDataArrayData = new List<BarcodePackageDataModel>();

                int i = 1;

                foreach (var ImportUpdateDataItem in BarcodePackageDataModel)
                {
                    BarcodePackageDataModel ImportDataArrayModel_data = new BarcodePackageDataModel();

                    ImportDataArrayModel_data.ref_id = ImportUpdateDataItem.ref_id;
                    ImportDataArrayModel_data.item_no = ImportUpdateDataItem.item_no;
                    ImportDataArrayModel_data.package_code = ImportUpdateDataItem.package_code;
                    ImportDataArrayModel_data.barcode_vsk = ImportUpdateDataItem.barcode_vsk;
                    ImportDataArrayModel_data.barcode_package = ImportUpdateDataItem.barcode_package;
                    ImportDataArrayModel_data.item_note = ImportUpdateDataItem.item_note;
                    ImportDataArrayModel_data.action_type = ImportUpdateDataItem.action_type;
                    ImportDataArrayModel_data.created_by = ImportUpdateDataItem.created_by;

                    ImportDataArrayData.Add(ImportDataArrayModel_data);

                    i++;
                }

                BarcodePackageRepository.BARCODE_PACKAGE_DATA_IMPORT(ImportDataArrayData);

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = ImportDataArrayData;
                _ResponseModel.length = ImportDataArrayData.Count();
                _ResponseModel.status = "Success";

                return _ResponseModel;
            }
            catch (Exception ex)
            {
                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.status = "Error";
                _ResponseModel.status = ex.ToString();

                return _ResponseModel;
            }
        }
        #endregion

        #region BARCODE_PACKAGE_VERIFY
        [Route("api/BARCODE_PACKAGE_VERIFY")]
        [HttpGet]
        public ResponseModel BARCODE_PACKAGE_VERIFY([FromUri] String ref_id)
        {

            try
            {
                CultureInfo cultureinfo = new CultureInfo("en-US");

                BarcodePackageRepository BarcodePackageRepository = new BarcodePackageRepository();

                List<BarcodePackageVerifyModel> BARCODE_PACKAGE_VERIFY = BarcodePackageRepository.BARCODE_PACKAGE_VERIFY(ref_id);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = BARCODE_PACKAGE_VERIFY;
                _ResponseModel.length = BARCODE_PACKAGE_VERIFY.Count();
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

        //#region BARCODE_PACKAGE_UPLOAD
        //[Route("api/BARCODE_PACKAGE_UPLOAD")]
        //[HttpPut]
        //public ResponseModel BARCODE_PACKAGE_UPLOAD([FromBody] String ref_id)
        //{
        //    try
        //    {

        //        BarcodePackageRepository BarcodePackageRepository = new BarcodePackageRepository();

        //        List<BarcodePackageDataModel> BARCODE_PACKAGE_UPLOAD = BarcodePackageRepository.BARCODE_PACKAGE_UPLOAD(ref_id);

        //        ResponseModel _ResponseModel = new ResponseModel();

        //        _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
        //        _ResponseModel.data = BARCODE_PACKAGE_UPLOAD;
        //        _ResponseModel.length = BARCODE_PACKAGE_UPLOAD.Count();
        //        _ResponseModel.status = "Success";

        //        return _ResponseModel;

        //    }
        //    catch (Exception ex)
        //    {
        //        ResponseModel _ResponseModel = new ResponseModel();
        //        _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
        //        _ResponseModel.status = "Error";
        //        _ResponseModel.error_message = ex.Message.ToString();
        //        _ResponseModel.error_stacktrace = ex.StackTrace.ToString();
        //        _ResponseModel.error_source = ex.Source.ToString();

        //        return _ResponseModel;

        //    }
        //}
        //#endregion

        #region BARCODE_PACKAGE_UPLOAD
        [Route("api/BARCODE_PACKAGE_UPLOAD")]
        [HttpPost]
        public ResponseModel BARCODE_PACKAGE_UPLOAD([FromBody] BarcodePackageParamModel BarcodePackageParamModel)
        {
            try
            {
                CultureInfo cultureinfo = new CultureInfo("en-US");

                BarcodePackageRepository BarcodePackageRepository = new BarcodePackageRepository();

                List<BarcodePackageDataModel> BARCODE_PACKAGE_UPLOAD = BarcodePackageRepository.BARCODE_PACKAGE_UPLOAD(BarcodePackageParamModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = BARCODE_PACKAGE_UPLOAD;
                _ResponseModel.length = BARCODE_PACKAGE_UPLOAD.Count();
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

        #region BARCODE_PACKAGE_LIST
        [Route("api/BARCODE_PACKAGE_LIST")]
        [HttpGet]
        public ResponseModel BARCODE_PACKAGE_LIST([FromUri] BarcodePackageSearchModel BarcodePackageSearchModel)
        {

            try
            {
                CultureInfo cultureinfo = new CultureInfo("en-US");

                BarcodePackageRepository BarcodePackageRepository = new BarcodePackageRepository();

                List<BarcodePackageListModel> BARCODE_PACKAGE_LIST = BarcodePackageRepository.BARCODE_PACKAGE_LIST(BarcodePackageSearchModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = BARCODE_PACKAGE_LIST;
                _ResponseModel.length = BARCODE_PACKAGE_LIST.Count();
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