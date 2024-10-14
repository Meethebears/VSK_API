using REPO.Models;
using REPO.Controllers;
using System.Web.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;

namespace API.Controllers
{
    public class Upload_LoscanController : ApiController
    {
        #region Loscan_Import_Data_Tmp
        [Route("api/Loscan_Import_Data_Tmp")]
        [HttpPost]
        public ResponseModel Loscan_Import_Data_Tmp([FromBody] LoscanModel LoscanModel)
        {

            try
            {
                CultureInfo cultureinfo = new CultureInfo("en-US");

                Upload_LoscanRepository Upload_ScanRepository = new Upload_LoscanRepository();

                List<LoscanModel> Loscan_Import_Data_Tmp = Upload_ScanRepository.Loscan_Import_Data_Tmp(LoscanModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = Loscan_Import_Data_Tmp;
                _ResponseModel.length = Loscan_Import_Data_Tmp.Count();
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

        #region  Loscan_Import_Data_TmpTran
        [Route("api/Loscan_Import_Data_TmpTran")]
        [HttpPost]
        public ResponseModel Loscan_Import_Data_TmpTran([FromBody] IEnumerable<LoscanModel> LoscanModel)
        {
            try
            {
                ResponseModel _ResponseModel = new ResponseModel();

                Upload_LoscanRepository Upload_LoscanRepository = new Upload_LoscanRepository();

                List<LoscanModel> ImportDataArrayData = new List<LoscanModel>();

                int i = 1;

                foreach (var ImportUpdateDataItem in LoscanModel)
                {
                    LoscanModel ImportDataArrayModel_data = new LoscanModel();
                    ImportDataArrayModel_data.temp_id = ImportUpdateDataItem.temp_id;
                    ImportDataArrayModel_data.scan_date = ImportUpdateDataItem.scan_date;
                    ImportDataArrayModel_data.user_scan = ImportUpdateDataItem.user_scan;
                    ImportDataArrayModel_data.wh = ImportUpdateDataItem.wh;
                    ImportDataArrayModel_data.location = ImportUpdateDataItem.location;
                    ImportDataArrayModel_data.barcode = ImportUpdateDataItem.barcode;
                    ImportDataArrayModel_data.remarks = ImportUpdateDataItem.remarks;
                    ImportDataArrayModel_data.action_type = ImportUpdateDataItem.action_type;
                    ImportDataArrayModel_data.created_by = ImportUpdateDataItem.created_by;
                    ImportDataArrayData.Add(ImportDataArrayModel_data);
                    i++;
                }

                Upload_LoscanRepository.Loscan_Import_Data_TmpTran(ImportDataArrayData);

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                //_ResponseModel.data = ImportData_CarModelMix_Tmp;
                //_ResponseModel.length = ImportData_CarModelMix_Tmp.Count();
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

        #region Loscan_Import_Data_Check
        [Route("api/Loscan_Import_Data_Check")]
        [HttpGet]
        public ResponseModel Loscan_Import_Data_Check([FromUri] LoscanModel LoscanModel)
        {

            try
            {
                CultureInfo cultureinfo = new CultureInfo("en-US");

                Upload_LoscanRepository Upload_ScanRepository = new Upload_LoscanRepository();

                List<LoscanModel> Loscan_Import_Data_Check = Upload_ScanRepository.Loscan_Import_Data_Check(LoscanModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = Loscan_Import_Data_Check;
                _ResponseModel.length = Loscan_Import_Data_Check.Count();
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

        #region Loscan_Import_Data_TmpVerify
        [Route("api/Loscan_Import_Data_TmpVerify")]
        [HttpGet]
        public ResponseModel Loscan_Import_Data_TmpVerify([FromUri] LoscanModel LoscanModel)
        {

            try
            {
                CultureInfo cultureinfo = new CultureInfo("en-US");

                Upload_LoscanRepository Upload_ScanRepository = new Upload_LoscanRepository();

                List<LoscanModel> Loscan_Import_Data_TmpVerify = Upload_ScanRepository.Loscan_Import_Data_TmpVerify(LoscanModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = Loscan_Import_Data_TmpVerify;
                _ResponseModel.length = Loscan_Import_Data_TmpVerify.Count();
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

        #region Loscan_Import_Data_Upload
        [Route("api/Loscan_Import_Data_Upload")]
        [HttpGet]
        public ResponseModel Loscan_Import_Data_Upload([FromUri] LoscanModel LoscanModel)
        {

            try
            {
                CultureInfo cultureinfo = new CultureInfo("en-US");

                Upload_LoscanRepository Upload_ScanRepository = new Upload_LoscanRepository();

                List<LoscanModel> Loscan_Import_Data_Upload = Upload_ScanRepository.Loscan_Import_Data_Upload(LoscanModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = Loscan_Import_Data_Upload;
                _ResponseModel.length = Loscan_Import_Data_Upload.Count();
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

        #region Loscan_List
        [Route("api/Loscan_List")]
        [HttpGet]
        public ResponseModel Loscan_List([FromUri] LoscanModel LoscanModel)
        {

            try
            {
                CultureInfo cultureinfo = new CultureInfo("en-US");

                Upload_LoscanRepository Upload_ScanRepository = new Upload_LoscanRepository();

                List<LoscanModel> Loscan_List = Upload_ScanRepository.Loscan_List(LoscanModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = Loscan_List;
                _ResponseModel.length = Loscan_List.Count();
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

        #region Loscan_Detail
        [Route("api/Loscan_Detail")]
        [HttpGet]
        public ResponseModel Loscan_Detail([FromUri] LoscanModel LoscanModel)
        {

            try
            {
                CultureInfo cultureinfo = new CultureInfo("en-US");

                Upload_LoscanRepository Upload_ScanRepository = new Upload_LoscanRepository();

                List<LoscanModel> Loscan_Detail = Upload_ScanRepository.Loscan_Detail(LoscanModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = Loscan_Detail;
                _ResponseModel.length = Loscan_Detail.Count();
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

        #region Loscan_Delete
        [Route("api/Loscan_Delete")]
        [HttpDelete]
        public ResponseModel Loscan_Delete([FromBody] LoscanModel LoscanModel)
        {

            try
            {
                CultureInfo cultureinfo = new CultureInfo("en-US");

                Upload_LoscanRepository Upload_ScanRepository = new Upload_LoscanRepository();

                List<LoscanModel> Loscan_Delete = Upload_ScanRepository.Loscan_Delete(LoscanModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = Loscan_Delete;
                _ResponseModel.length = Loscan_Delete.Count();
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
