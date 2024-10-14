using REPO.Controllers;
using REPO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace API.Controllers
{
    public class NetPriceController : ApiController
    {

        [Route("v1/prnetfile_select2_search")]
        [HttpGet]
        public ResponseModel prnetfile_select2_search([FromUri] string id, string text, string keywords)
        {
            try
            {
                NetpriceRepository NetpriceRepository = new NetpriceRepository();

                List<ResponseSelect2Model> dis_pre_group_search = NetpriceRepository.prnetfile_select2_search(id, text, keywords);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = dis_pre_group_search;
                _ResponseModel.length = dis_pre_group_search.Count();
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

        #region prnetfile_select2
        [Route("v1/prnetfile_select2")]
        [HttpGet]
        public ResponseModel prnetfile_select2([FromUri] ResponseSelect2Model ResponseSelect2Model)
        {
            try
            {
                NetpriceRepository NetpriceRepository = new NetpriceRepository();

                List<ResponseSelect2Model> prnetfile_select2 = NetpriceRepository.prnetfile_select2(ResponseSelect2Model);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = prnetfile_select2;
                _ResponseModel.length = prnetfile_select2.Count();
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

        #region prnetfile_check
        [Route("v1/prnetfile_check")]
        [HttpGet]
        public ResponseModel prnetfile_check([FromUri] string code)
        {
            try
            {
                NetpriceRepository NetpriceRepository = new NetpriceRepository();

                List<NetPrice_Prnetfile_Model> prnetfile_check = NetpriceRepository.prnetfile_check(code);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = prnetfile_check;
                _ResponseModel.length = prnetfile_check.Count();
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

        #region prnetfile_action
        [Route("v1/prnetfile_action")]
        [HttpPost]
        public ResponseModel prnetfile_action([FromBody] NetPrice_Prnetfile_Model NetPrice_Prnetfile_Model)
        {
            try
            {

                ResponseModel _ResponseCheckModel = new ResponseModel();
                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseCheckModel = prnetfile_check(NetPrice_Prnetfile_Model.code);

                if (_ResponseCheckModel.length <= 0 && NetPrice_Prnetfile_Model.mode == "CREATE")
                {
                    NetpriceRepository NetpriceRepository = new NetpriceRepository();

                    NetpriceRepository.prnetfile_action(NetPrice_Prnetfile_Model);

                    _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                    _ResponseModel.data = NetPrice_Prnetfile_Model.mode;
                    //_ResponseModel.length = Dis_prnetfile_action.Count();
                    _ResponseModel.status = "Success";

                }
                else if (_ResponseCheckModel.length > 0 && NetPrice_Prnetfile_Model.mode == "CREATE")
                {

                    _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                    _ResponseModel.length = _ResponseCheckModel.length;
                    _ResponseModel.status = "Duplicate";

                }
                else if (_ResponseCheckModel.length > 0 && NetPrice_Prnetfile_Model.mode != "CREATE")
                {

                    NetpriceRepository NetpriceRepository = new NetpriceRepository();

                    NetpriceRepository.prnetfile_action(NetPrice_Prnetfile_Model);

                    _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                    _ResponseModel.data = NetPrice_Prnetfile_Model.mode;
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

        #region prnetfile_list
        [Route("v1/prnetfile_list")]
        [HttpGet]
        public ResponseModel prnetfile_list([FromUri] prnetfileModel prnetfileModel)
        {
            try
            {
                NetpriceRepository NetpriceRepository = new NetpriceRepository();

                List<prnetfileModel> prnetfile_list = NetpriceRepository.prnetfile_list(prnetfileModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = prnetfile_list;
                _ResponseModel.length = prnetfile_list.Count();
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

        #region import_prnetflie_tmpfile
        [Route("v1/import_prnetflie_tmpfile")]
        [HttpGet]
        public ResponseModel import_prnetflie_tmpfile([FromUri] NetPrice_Prnetfile_Model NetPrice_Prnetfile_Model)
        {
            try
            {
                NetpriceRepository NetpriceRepository = new NetpriceRepository();

                List<NetPrice_Prnetfile_Model> import_prnetflie_tmpfile = NetpriceRepository.import_prnetflie_tmpfile(NetPrice_Prnetfile_Model);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = import_prnetflie_tmpfile;
                _ResponseModel.length = import_prnetflie_tmpfile.Count();
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

        #region import_prnetflie_tmptrans
        [Route("v1/import_prnetflie_tmptrans")]
        [HttpPost]
        public ResponseModel import_prnetflie_tmptrans([FromBody] IEnumerable<NetPrice_Prnetfile_Model> NetPrice_Prnetfile_Model)
        {
            try
            {
                ResponseModel _ResponseModel = new ResponseModel();

                NetpriceRepository NetpriceRepository = new NetpriceRepository();

                List<NetPrice_Prnetfile_Model> ImportDataArrayData = new List<NetPrice_Prnetfile_Model>();

                int i = 1;

                foreach (var ImportUpdateDataItem in NetPrice_Prnetfile_Model)
                {
                    NetPrice_Prnetfile_Model ImportDataArrayModel_data = new NetPrice_Prnetfile_Model();
                    ImportDataArrayModel_data.ref_id = ImportUpdateDataItem.ref_id;
                    ImportDataArrayModel_data.mode = ImportUpdateDataItem.mode;
                    ImportDataArrayModel_data.code = ImportUpdateDataItem.code;
                    ImportDataArrayModel_data.lname = ImportUpdateDataItem.lname;
                    ImportDataArrayModel_data.remark = ImportUpdateDataItem.remark;
                    ImportDataArrayModel_data.procby = ImportUpdateDataItem.procby;
                    ImportDataArrayModel_data.created_by = ImportUpdateDataItem.created_by;
                    ImportDataArrayModel_data.named = ImportUpdateDataItem.named;
                    ImportDataArrayModel_data.TYPE = ImportUpdateDataItem.TYPE;
                    ImportDataArrayModel_data.carbrand = ImportUpdateDataItem.carbrand;
                    ImportDataArrayModel_data.chrcode = ImportUpdateDataItem.chrcode;
                    ImportDataArrayModel_data.gmodel = ImportUpdateDataItem.gmodel;
                    ImportDataArrayModel_data.typeb = ImportUpdateDataItem.typeb;
                    ImportDataArrayData.Add(ImportDataArrayModel_data);

                    i++;
                }

                NetpriceRepository.import_prnetflie_tmptrans(ImportDataArrayData);

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = NetPrice_Prnetfile_Model;
                _ResponseModel.length = NetPrice_Prnetfile_Model.Count();
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

        #region import_prnetflie_tmpverify
        [Route("v1/import_prnetflie_tmpverify")]
        [HttpGet]
        public ResponseModel import_prnetflie_tmpverify([FromUri] NetPrice_Model NetPrice_Model)
        {
            try
            {
                NetpriceRepository NetpriceRepository = new NetpriceRepository();

                List<NetPrice_Model> import_prnetflie_tmpverify = NetpriceRepository.import_prnetflie_tmpverify(NetPrice_Model);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = import_prnetflie_tmpverify;
                _ResponseModel.length = import_prnetflie_tmpverify.Count();
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

        #region import_prnetflie_tmpupload
        [Route("v1/import_prnetflie_tmpupload")]
        [HttpGet]
        public ResponseModel import_prnetflie_tmpupload([FromUri] NetPrice_Model NetPrice_Model)
        {
            try
            {
                NetpriceRepository NetpriceRepository = new NetpriceRepository();

                List<NetPrice_Model> import_prnetflie_tmpupload = NetpriceRepository.import_prnetflie_tmpupload(NetPrice_Model);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = import_prnetflie_tmpupload;
                _ResponseModel.length = import_prnetflie_tmpupload.Count();
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

        #region import_prnetflie_tmptrans_emmas
        [Route("v1/import_prnetflie_tmptrans_emmas")]
        [HttpPost]
        public ResponseModel import_prnetflie_tmptrans_emmas([FromBody] IEnumerable<NetPrice_Prnetfile_Model> NetPrice_Prnetfile_Model)
        {
            try
            {
                ResponseModel _ResponseModel = new ResponseModel();

                NetpriceRepository NetpriceRepository = new NetpriceRepository();

                List<NetPrice_Prnetfile_Model> ImportDataArrayData = new List<NetPrice_Prnetfile_Model>();

                int i = 1;

                foreach (var ImportUpdateDataItem in NetPrice_Prnetfile_Model)
                {
                    NetPrice_Prnetfile_Model ImportDataArrayModel_data = new NetPrice_Prnetfile_Model();
                    ImportDataArrayModel_data.ref_id = ImportUpdateDataItem.ref_id;
                    ImportDataArrayModel_data.mode = ImportUpdateDataItem.mode;
                    ImportDataArrayModel_data.netprice_code = ImportUpdateDataItem.netprice_code;
                    ImportDataArrayModel_data.emmas_code = ImportUpdateDataItem.emmas_code;
                    ImportDataArrayModel_data.emmas_name = ImportUpdateDataItem.emmas_name;
                    ImportDataArrayModel_data.created_by = ImportUpdateDataItem.created_by;
                    ImportDataArrayData.Add(ImportDataArrayModel_data);

                    i++;
                }

                NetpriceRepository.import_prnetflie_tmptrans_emmas(ImportDataArrayData);

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = NetPrice_Prnetfile_Model;
                _ResponseModel.length = NetPrice_Prnetfile_Model.Count();
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

        #region import_prnetflie_tmpverify_emmas
        [Route("v1/import_prnetflie_tmpverify_emmas")]
        [HttpGet]
        public ResponseModel import_prnetflie_tmpverify_emmas([FromUri] NetPrice_Model NetPrice_Model)
        {
            try
            {
                NetpriceRepository NetpriceRepository = new NetpriceRepository();

                List<NetPrice_Model> import_prnetflie_tmpverify_emmas = NetpriceRepository.import_prnetflie_tmpverify_emmas(NetPrice_Model);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = import_prnetflie_tmpverify_emmas;
                _ResponseModel.length = import_prnetflie_tmpverify_emmas.Count();
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

        #region import_prnetflie_tmpupload_emmas
        [Route("v1/import_prnetflie_tmpupload_emmas")]
        [HttpGet]
        public ResponseModel import_prnetflie_tmpupload_emmas([FromUri] NetPrice_Model NetPrice_Model)
        {
            try
            {
                NetpriceRepository NetpriceRepository = new NetpriceRepository();

                List<NetPrice_Model> import_prnetflie_tmpupload_emmas = NetpriceRepository.import_prnetflie_tmpupload_emmas(NetPrice_Model);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = import_prnetflie_tmpupload_emmas;
                _ResponseModel.length = import_prnetflie_tmpupload_emmas.Count();
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


        #region prnettra_list
        [Route("v1/prnettra_list")]
        [HttpGet]
        public ResponseModel prnettra_list([FromUri] prnettraModel prnettraModel)
        {
            try
            {
                NetpriceRepository NetpriceRepository = new NetpriceRepository();

                List<prnettraModel> prnettra_list = NetpriceRepository.prnettra_list(prnettraModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = prnettra_list;
                _ResponseModel.length = prnettra_list.Count();
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

        #region prnettra_check
        [Route("v1/prnettra_check")]
        [HttpPost]
        public ResponseModel prnettra_check([FromBody] string gcode, string ecode)
        {
            try
            {
                NetpriceRepository NetpriceRepository = new NetpriceRepository();

                List<prnetcheckModel> prnettra_check = NetpriceRepository.prnettra_check(gcode, ecode);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = prnettra_check;
                _ResponseModel.length = prnettra_check.Count();
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

        #region prnettra_gunit
        [Route("v1/prnettra_gunit")]
        [HttpGet]
        public ResponseModel prnettra_gunit([FromUri] string gcode, string gunit)
        {
            try
            {
                NetpriceRepository NetpriceRepository = new NetpriceRepository();

                List<prnetcheckModel> prnettra_gunit = NetpriceRepository.prnettra_gunit(gcode, gunit);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = prnettra_gunit;
                _ResponseModel.length = prnettra_gunit.Count();
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

        [Route("v1/prnettra_action")]
        [HttpPost]
        public ResponseModel prnettra_action([FromBody] prnettraModel prnettraModel)
        {
            try
            {
                ResponseModel _ResponseGunitkModel = new ResponseModel();
                ResponseModel _ResponseCheckModel = new ResponseModel();
                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseCheckModel = prnettra_check(prnettraModel.gcode, prnettraModel.ecode);
                _ResponseGunitkModel = prnettra_gunit(prnettraModel.gcode, prnettraModel.gunit);

                if (_ResponseGunitkModel.length <= 0)
                {
                    NetpriceRepository NetpriceRepository = new NetpriceRepository();

                    _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                    _ResponseModel.data = _ResponseGunitkModel.length;
                    _ResponseModel.status = "Not_Found_Gunit";

                }
                else
                {
                    if (_ResponseCheckModel.length <= 0 && prnettraModel.mode == "CREATE")
                    {
                        NetpriceRepository NetpriceRepository = new NetpriceRepository();

                        NetpriceRepository.prnettra_action(prnettraModel);

                        _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                        _ResponseModel.data = prnettraModel.mode;
                        _ResponseModel.status = "Success";

                    }
                    else if (_ResponseCheckModel.length > 0 && prnettraModel.mode == "CREATE")
                    {
                        _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                        _ResponseModel.length = _ResponseCheckModel.length;
                        _ResponseModel.status = "Duplicate";

                    }
                    else if (_ResponseCheckModel.length > 0 && prnettraModel.mode != "CREATE")
                    {
                        NetpriceRepository NetpriceRepository = new NetpriceRepository();

                        NetpriceRepository.prnettra_action(prnettraModel);

                        _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                        _ResponseModel.data = prnettraModel.mode;
                        _ResponseModel.status = "Success";

                    }
                    else
                    {
                        _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                        _ResponseModel.length = _ResponseCheckModel.length;
                        _ResponseModel.status = "Error";
                    }
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

        #region import_prnettra_tmpfile
        [Route("v1/import_prnettra_tmpfile")]
        [HttpGet]
        public ResponseModel import_prnettra_tmpfile([FromUri] prnettraModel prnettraModel)
        {
            try
            {
                NetpriceRepository NetpriceRepository = new NetpriceRepository();

                List<prnettraModel> import_prnettra_tmpfile = NetpriceRepository.import_prnettra_tmpfile(prnettraModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = import_prnettra_tmpfile;
                _ResponseModel.length = import_prnettra_tmpfile.Count();
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

        #region import_prnettra_tmptrans
        [Route("v1/import_prnettra_tmptrans")]
        [HttpPost]
        public ResponseModel import_prnettra_tmptrans([FromBody] IEnumerable<prnettraModel> prnettraModel)
        {
            try
            {
                ResponseModel _ResponseModel = new ResponseModel();

                NetpriceRepository NetpriceRepository = new NetpriceRepository();

                List<prnettraModel> ImportDataArrayData = new List<prnettraModel>();

                int i = 1;

                foreach (var ImportUpdateDataItem in prnettraModel)
                {
                    prnettraModel ImportDataArrayModel_data = new prnettraModel();
                    ImportDataArrayModel_data.ref_id = ImportUpdateDataItem.ref_id;
                    ImportDataArrayModel_data.mode = ImportUpdateDataItem.mode;
                    ImportDataArrayModel_data.gcode = ImportUpdateDataItem.gcode;
                    ImportDataArrayModel_data.gname = ImportUpdateDataItem.gname;
                    ImportDataArrayModel_data.Qty_A = ImportUpdateDataItem.Qty_A;
                    ImportDataArrayModel_data.Qty_B = ImportUpdateDataItem.Qty_B;
                    ImportDataArrayModel_data.NetPrice = ImportUpdateDataItem.NetPrice;
                    ImportDataArrayModel_data.gunit = ImportUpdateDataItem.gunit;
                    ImportDataArrayModel_data.ecode = ImportUpdateDataItem.ecode;
                    ImportDataArrayModel_data.userid = ImportUpdateDataItem.userid;
                    ImportDataArrayData.Add(ImportDataArrayModel_data);

                    i++;
                }

                NetpriceRepository.import_prnettra_tmptrans(ImportDataArrayData);

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = prnettraModel;
                _ResponseModel.length = prnettraModel.Count();
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

        #region import_prnettra_tmpverify
        [Route("v1/import_prnettra_tmpverify")]
        [HttpGet]
        public ResponseModel import_prnettra_tmpverify([FromUri] prnettraModel prnettraModel)
        {
            try
            {
                NetpriceRepository NetpriceRepository = new NetpriceRepository();

                List<prnettraModel> import_prnettra_tmpverify = NetpriceRepository.import_prnettra_tmpverify(prnettraModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = import_prnettra_tmpverify;
                _ResponseModel.length = import_prnettra_tmpverify.Count();
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

        #region import_prnettra_tmpupload
        [Route("v1/import_prnettra_tmpupload")]
        [HttpGet]
        public ResponseModel import_prnettra_tmpupload([FromUri] prnettraModel prnettraModel)
        {
            try
            {
                NetpriceRepository NetpriceRepository = new NetpriceRepository();

                List<prnettraModel> import_prnettra_tmpupload = NetpriceRepository.import_prnettra_tmpupload(prnettraModel);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = import_prnettra_tmpupload;
                _ResponseModel.length = import_prnettra_tmpupload.Count();
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

        [Route("v1/dis_emmas_List")]
        [HttpGet]
        public ResponseModel Dis_emmas_List([FromUri] string code, string mode)
        {
            try
            {
                NetpriceRepository NetpriceRepository = new NetpriceRepository();

                List<pre_emmaspModel> Dis_emmas_List = NetpriceRepository.Dis_emmas_List(code, mode);

                ResponseModel _ResponseModel = new ResponseModel();

                _ResponseModel.result_datetime = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                _ResponseModel.data = Dis_emmas_List;
                _ResponseModel.length = Dis_emmas_List.Count();
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
