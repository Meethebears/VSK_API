using REPO.Controllers;
using REPO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace API.Controllers
{
    public class DiscountController : ApiController
    {

        [Route("v1/gdishead_select2_search")]
        [HttpGet]
        public ResponseModel gdishead_select2_search([FromUri] string id, string text, string keywords, string name)
        {
            try
            {
                DiscountRepository DiscountRepository = new DiscountRepository();

                List<ResponseSelect2Model> gdishead_select2_search = DiscountRepository.gdishead_select2_search(id, text, keywords, name);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = gdishead_select2_search;
                _ResponseModel.length = gdishead_select2_search.Count();
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

        [Route("v1/stmas_select2_search")]
        [HttpGet]
        public ResponseModel stmas_select2_search([FromUri] string id, string text, string keywords)
        {
            try
            {
                DiscountRepository DiscountRepository = new DiscountRepository();

                List<ResponseStmasSelect2Model> stmas_select2_search = DiscountRepository.stmas_select2_search(id, text, keywords);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = stmas_select2_search;
                _ResponseModel.length = stmas_select2_search.Count();
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

        [Route("v1/discgroup_select2_search")]
        [HttpGet]
        public ResponseModel discgroup_select2_search([FromUri] string id, string text, string keywords, string mode)
        {
            try
            {
                DiscountRepository DiscountRepository = new DiscountRepository();

                List<ResponseSelect2Model> discgroup_select2_search = DiscountRepository.discgroup_select2_search(id, text, keywords, mode);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = discgroup_select2_search;
                _ResponseModel.length = discgroup_select2_search.Count();
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

        [Route("v1/gcode_a_select2_search")]
        [HttpGet]
        public ResponseModel gcode_a_select2_search([FromUri] string id, string text, string keywords)
        {
            try
            {
                DiscountRepository DiscountRepository = new DiscountRepository();

                List<ResponseSelect2Model> gcode_a_select2_search = DiscountRepository.gcode_a_select2_search(id, text, keywords);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = gcode_a_select2_search;
                _ResponseModel.length = gcode_a_select2_search.Count();
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

        [Route("v1/gcode_c_select2_search")]
        [HttpGet]
        public ResponseModel gcode_c_select2_search([FromUri] string id, string text, string keywords)
        {
            try
            {
                DiscountRepository DiscountRepository = new DiscountRepository();

                List<ResponseSelect2Model> gcode_c_select2_search = DiscountRepository.gcode_c_select2_search(id, text, keywords);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = gcode_c_select2_search;
                _ResponseModel.length = gcode_c_select2_search.Count();
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



        [Route("v1/ediscount_list")]
        [HttpGet]
        public ResponseModel ediscount_list([FromUri] ediscountModel ediscountModel)
        {
            try
            {
                DiscountRepository DiscountRepository = new DiscountRepository();

                List<ediscountModel> ediscount_list = DiscountRepository.ediscount_list(ediscountModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = ediscount_list;
                _ResponseModel.length = ediscount_list.Count();
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

        [Route("v1/ediscount_action")]
        [HttpPost]
        public ResponseModel ediscount_action([FromBody] ediscountModel ediscountModel)
        {
            try
            {

                ResponseModel _ResponseCheckModel = new ResponseModel();
                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseCheckModel = ediscount_check(ediscountModel.code, ediscountModel.cargroup, ediscountModel.ecode, ediscountModel.chrcode);


                if (_ResponseCheckModel.length <= 0 && ediscountModel.mode == "CREATE")
                {
                    DiscountRepository DiscountRepository = new DiscountRepository();

                    DiscountRepository.ediscount_action(ediscountModel);

                    _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                    _ResponseModel.data = ediscountModel.mode;
                    _ResponseModel.status = "Success";

                }
                else if (_ResponseCheckModel.length > 0 && ediscountModel.mode == "CREATE")
                {
                    _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                    _ResponseModel.length = _ResponseCheckModel.length;
                    _ResponseModel.status = "Duplicate";

                }
                else if (_ResponseCheckModel.length > 0 && ediscountModel.mode != "CREATE")
                {
                    DiscountRepository DiscountRepository = new DiscountRepository();

                    DiscountRepository.ediscount_action(ediscountModel);

                    _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                    _ResponseModel.data = ediscountModel.mode;
                    _ResponseModel.status = "Success";

                }
                else
                {
                    _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                    _ResponseModel.length = _ResponseCheckModel.length;
                    _ResponseModel.status = "Error";
                }


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

        [Route("v1/ediscount_check")]
        [HttpGet]
        public ResponseModel ediscount_check([FromUri] string code, string cargroup, string ecode, string chrcode)
        {
            try
            {
                DiscountRepository DiscountRepository = new DiscountRepository();

                List<ediscountModel> Dis_ediscount_check = DiscountRepository.ediscount_check(code, cargroup, ecode, chrcode);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = Dis_ediscount_check;
                _ResponseModel.length = Dis_ediscount_check.Count();
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


        #region import_ediscount_tmpfile
        [Route("v1/import_ediscount_tmpfile")]
        [HttpGet]
        public ResponseModel import_ediscount_tmpfile([FromUri] ediscountModel ediscountModel)
        {
            try
            {
                DiscountRepository DiscountRepository = new DiscountRepository();

                List<ediscountModel> import_ediscount_tmpfile = DiscountRepository.import_ediscount_tmpfile(ediscountModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = import_ediscount_tmpfile;
                _ResponseModel.length = import_ediscount_tmpfile.Count();
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

        #region import_ediscount_tmptrans
        [Route("v1/import_ediscount_tmptrans")]
        [HttpPost]
        public ResponseModel import_ediscount_tmptrans([FromBody] IEnumerable<ediscountModel> ediscountModel)
        {
            try
            {
                ResponseModel _ResponseModel = new ResponseModel();

                DiscountRepository DiscountRepository = new DiscountRepository();

                List<ediscountModel> ImportDataArrayData = new List<ediscountModel>();

                int i = 1;

                foreach (var ImportUpdateDataItem in ediscountModel)
                {
                    ediscountModel ImportDataArrayModel_data = new ediscountModel();
                    ImportDataArrayModel_data.ref_id = ImportUpdateDataItem.ref_id;
                    ImportDataArrayModel_data.code = ImportUpdateDataItem.code;
                    ImportDataArrayModel_data.cargroup = ImportUpdateDataItem.cargroup;
                    ImportDataArrayModel_data.chrcode = ImportUpdateDataItem.chrcode;
                    ImportDataArrayModel_data.adis1 = ImportUpdateDataItem.adis1;
                    ImportDataArrayModel_data.adis2 = ImportUpdateDataItem.adis2;
                    ImportDataArrayModel_data.adis3 = ImportUpdateDataItem.adis3;
                    ImportDataArrayModel_data.bdis1 = ImportUpdateDataItem.bdis1;
                    ImportDataArrayModel_data.bdis2 = ImportUpdateDataItem.bdis2;
                    ImportDataArrayModel_data.bdis3 = ImportUpdateDataItem.bdis3;
                    ImportDataArrayModel_data.cdis1 = ImportUpdateDataItem.cdis1;
                    ImportDataArrayModel_data.cdis2 = ImportUpdateDataItem.cdis2;
                    ImportDataArrayModel_data.cdis3 = ImportUpdateDataItem.cdis3;
                    ImportDataArrayModel_data.ddis1 = ImportUpdateDataItem.ddis1;
                    ImportDataArrayModel_data.ddis2 = ImportUpdateDataItem.ddis2;
                    ImportDataArrayModel_data.ddis3 = ImportUpdateDataItem.ddis3;
                    ImportDataArrayModel_data.edis1 = ImportUpdateDataItem.edis1;
                    ImportDataArrayModel_data.edis2 = ImportUpdateDataItem.edis2;
                    ImportDataArrayModel_data.edis3 = ImportUpdateDataItem.edis3;
                    ImportDataArrayModel_data.dvat = ImportUpdateDataItem.dvat;
                    ImportDataArrayModel_data.ecode = ImportUpdateDataItem.ecode;
                    ImportDataArrayModel_data.created_by = ImportUpdateDataItem.created_by;
                    ImportDataArrayModel_data.mode = ImportUpdateDataItem.mode;
                    ImportDataArrayModel_data.ref_id = ImportUpdateDataItem.ref_id;
                    ImportDataArrayData.Add(ImportDataArrayModel_data);

                    i++;
                }

                DiscountRepository.import_ediscount_tmptrans(ImportDataArrayData);

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = ediscountModel;
                _ResponseModel.length = ediscountModel.Count();
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

        #region import_ediscount_tmpverify
        [Route("v1/import_ediscount_tmpverify")]
        [HttpGet]
        public ResponseModel import_ediscount_tmpverify([FromUri] ediscountModel ediscountModel)
        {
            try
            {
                DiscountRepository DiscountRepository = new DiscountRepository();

                List<ediscountModel> import_ediscount_tmpverify = DiscountRepository.import_ediscount_tmpverify(ediscountModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = import_ediscount_tmpverify;
                _ResponseModel.length = import_ediscount_tmpverify.Count();
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

        #region import_ediscount_tmpupload
        [Route("v1/import_ediscount_tmpupload")]
        [HttpGet]
        public ResponseModel import_ediscount_tmpupload([FromUri] ediscountModel ediscountModel)
        {
            try
            {
                DiscountRepository DiscountRepository = new DiscountRepository();

                List<ediscountModel> import_ediscount_tmpupload = DiscountRepository.import_ediscount_tmpupload(ediscountModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = import_ediscount_tmpupload;
                _ResponseModel.length = import_ediscount_tmpupload.Count();
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

        #region gdishead_list
        [Route("v1/gdishead_list")]
        [HttpGet]
        public ResponseModel gdishead_list([FromUri] gdisheadModel gdisheadModel)
        {
            try
            {
                DiscountRepository DiscountRepository = new DiscountRepository();

                List<gdisheadModel> gdishead_list = DiscountRepository.gdishead_list(gdisheadModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = gdishead_list;
                _ResponseModel.length = gdishead_list.Count();
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

        #region gdishead_check
        [Route("v1/gdishead_check")]
        [HttpGet]
        public ResponseModel gdishead_check([FromUri] string code)
        {
            try
            {
                DiscountRepository DiscountRepository = new DiscountRepository();

                List<gdisheadModel> gdishead_check = DiscountRepository.gdishead_check(code);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = gdishead_check;
                _ResponseModel.length = gdishead_check.Count();
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

        #region gdishead_action
        [Route("v1/gdishead_action")]
        [HttpPost]
        public ResponseModel gdishead_action([FromBody] gdisheadModel gdisheadModel)
        {
            try
            {

                ResponseModel _ResponseCheckModel = new ResponseModel();
                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseCheckModel = gdishead_check(gdisheadModel.code);

                if (_ResponseCheckModel.length <= 0 && gdisheadModel.mode == "CREATE")
                {
                    DiscountRepository DiscountRepository = new DiscountRepository();

                    DiscountRepository.gdishead_action(gdisheadModel);

                    _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                    _ResponseModel.data = gdisheadModel.mode;
                    //_ResponseModel.length = Dis_prnetfile_action.Count();
                    _ResponseModel.status = "Success";

                }
                else if (_ResponseCheckModel.length > 0 && gdisheadModel.mode == "CREATE")
                {

                    _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                    _ResponseModel.length = _ResponseCheckModel.length;
                    _ResponseModel.status = "Duplicate";

                }
                else if (_ResponseCheckModel.length > 0 && gdisheadModel.mode != "CREATE")
                {

                    DiscountRepository DiscountRepository = new DiscountRepository();

                    DiscountRepository.gdishead_action(gdisheadModel);

                    _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                    _ResponseModel.data = gdisheadModel.mode;
                    //_ResponseModel.length = Dis_prnetfile_action.Count();
                    _ResponseModel.status = "Success";

                }
                else
                {
                    _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                    _ResponseModel.length = _ResponseCheckModel.length;
                    _ResponseModel.status = "Error";
                }


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
