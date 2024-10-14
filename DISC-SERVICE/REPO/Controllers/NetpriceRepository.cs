using Dapper;
using REPO.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace REPO.Controllers
{
    public class NetpriceRepository : Controller
    {
        #region Connection_SQL Server
        //-------------------Start Connection_SQL ------------------------//
        public SqlConnection VSK_SA;
        public SqlConnection Vorwins;
        private void Connection()
        {
            VSK_SA = new SqlConnection(ConfigurationManager.ConnectionStrings["VSK_SA"].ToString());
            Vorwins = new SqlConnection(ConfigurationManager.ConnectionStrings["Vorwins"].ToString());
        }
        //-------------------End Connection_SQL ------------------------//
        #endregion

        public List<ResponseSelect2Model> prnetfile_select2_search(string id, string text, string keywords)
        {
            try
            {
                string SQLQuery = "SELECT TOP 5 " + id + " AS id, " + text + " as text , rtrim(lname) AS lname FROM prnetfile WHERE RTRIM(code) LIKE '" + keywords + "%' OR RTRIM(lname) LIKE '" + keywords + "%' OR RTRIM(remark) LIKE '" + keywords + "%'";
                Connection();
                Vorwins.Open();
                List<ResponseSelect2Model> RequestModelList = Vorwins.Query<ResponseSelect2Model>(SQLQuery).ToList();
                Vorwins.Close();
                return RequestModelList.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        #region prnetfile_select2
        public List<ResponseSelect2Model> prnetfile_select2(ResponseSelect2Model ResponseSelect2Model)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@id", ResponseSelect2Model.id);
                objParam.Add("@text", ResponseSelect2Model.text);
                objParam.Add("@keywords", ResponseSelect2Model.keywords);

                Connection();
                VSK_SA.Open();

                List<ResponseSelect2Model> DataList = SqlMapper.Query<ResponseSelect2Model>(VSK_SA, "SP_Prnetfile_Selete2_Search", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();

                VSK_SA.Close();
                return DataList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        #endregion

        #region prnetfile_check
        public List<NetPrice_Prnetfile_Model> prnetfile_check(string code)
        {
            try
            {
                string SQLQuery;


                SQLQuery = "SELECT TOP 1 code FROM prnetfile WHERE code = '" + code + "' ";


                Connection();
                Vorwins.Open();
                List<NetPrice_Prnetfile_Model> DataList = Vorwins.Query<NetPrice_Prnetfile_Model>(SQLQuery).ToList();
                Vorwins.Close();
                return DataList.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region prnetfile_action
        public List<NetPrice_Prnetfile_Model> prnetfile_action(NetPrice_Prnetfile_Model NetPrice_Prnetfile_Model)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@ref_id", NetPrice_Prnetfile_Model.ref_id);
                objParam.Add("@mode", NetPrice_Prnetfile_Model.mode);
                objParam.Add("@code", NetPrice_Prnetfile_Model.code);
                objParam.Add("@lname", NetPrice_Prnetfile_Model.lname);
                objParam.Add("@remark", NetPrice_Prnetfile_Model.remark);
                objParam.Add("@procby", NetPrice_Prnetfile_Model.procby);
                objParam.Add("@named", NetPrice_Prnetfile_Model.named);
                objParam.Add("@TYPE", NetPrice_Prnetfile_Model.TYPE);
                objParam.Add("@carbrand", NetPrice_Prnetfile_Model.carbrand);
                objParam.Add("@chrcode", NetPrice_Prnetfile_Model.chrcode);
                objParam.Add("@gmodel", NetPrice_Prnetfile_Model.gmodel);
                objParam.Add("@typeb", NetPrice_Prnetfile_Model.typeb);
                objParam.Add("@created_by", NetPrice_Prnetfile_Model.created_by);

                Connection();
                VSK_SA.Open();
                List<NetPrice_Prnetfile_Model> DataList = SqlMapper.Query<NetPrice_Prnetfile_Model>(VSK_SA, "SP_Prnetfile_Action", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();

                VSK_SA.Close();
                return DataList.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region prnetfile_list
        public List<prnetfileModel> prnetfile_list(prnetfileModel prnetfileModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@mode", prnetfileModel.mode);

                Connection();
                VSK_SA.Open();

                List<prnetfileModel> DataList = SqlMapper.Query<prnetfileModel>(VSK_SA, "SP_Prnetfile_List", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();

                VSK_SA.Close();
                return DataList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        #endregion

        #region import_prnetflie_temp_file
        public List<NetPrice_Prnetfile_Model> import_prnetflie_tmpfile(NetPrice_Prnetfile_Model NetPrice_Prnetfile_Model)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();
              
                objParam.Add("@ref_id", NetPrice_Prnetfile_Model.ref_id);
                objParam.Add("@mode", NetPrice_Prnetfile_Model.mode);
                objParam.Add("@created_by", NetPrice_Prnetfile_Model.created_by);
                objParam.Add("@count_trans", NetPrice_Prnetfile_Model.count_trans);

                Connection();
                VSK_SA.Open();

                List<NetPrice_Prnetfile_Model> DataList = SqlMapper.Query<NetPrice_Prnetfile_Model>(VSK_SA, "SP_Prnetfile_Import_file", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();

                VSK_SA.Close();
                return DataList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        #endregion

        #region import_prnetflie_tmptrans
        public void import_prnetflie_tmptrans(List<NetPrice_Prnetfile_Model> NetPrice_Prnetfile_Model)
        {
            try
            {

                Connection();
                VSK_SA.Open();

                foreach (var ImportDataArrayData in NetPrice_Prnetfile_Model)
                {
                    DynamicParameters objParam = new DynamicParameters();

                    objParam.Add("@ref_id", ImportDataArrayData.ref_id);
                    objParam.Add("@mode", ImportDataArrayData.mode);
                    objParam.Add("@code", ImportDataArrayData.code);
                    objParam.Add("@lname", ImportDataArrayData.lname);
                    objParam.Add("@remark", ImportDataArrayData.remark);
                    objParam.Add("@procby", ImportDataArrayData.procby);
                    objParam.Add("@created_by", ImportDataArrayData.created_by);
                    objParam.Add("@named", ImportDataArrayData.named);
                    objParam.Add("@TYPE", ImportDataArrayData.TYPE);
                    objParam.Add("@carbrand", ImportDataArrayData.carbrand);
                    objParam.Add("@chrcode", ImportDataArrayData.chrcode);
                    objParam.Add("@gmodel", ImportDataArrayData.gmodel);
                    objParam.Add("@typeb", ImportDataArrayData.typeb);

                    VSK_SA.Execute("SP_Prnetfile_Import_tmptran", objParam, commandTimeout: 600, commandType: CommandType.StoredProcedure);

                }

                VSK_SA.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region import_prnetflie_tmpverify
        public List<NetPrice_Model> import_prnetflie_tmpverify(NetPrice_Model NetPrice_Model)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@ref_id", NetPrice_Model.ref_id);

                Connection();
                VSK_SA.Open();

                List<NetPrice_Model> DataList = SqlMapper.Query<NetPrice_Model>(VSK_SA, "SP_Prnetfile_Import_verify", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();

                VSK_SA.Close();
                return DataList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        #endregion

        #region import_prnetflie_tmpupload
        public List<NetPrice_Model> import_prnetflie_tmpupload(NetPrice_Model NetPrice_Model)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@ref_id", NetPrice_Model.ref_id);
                objParam.Add("@updated_by", NetPrice_Model.updated_by);

                Connection();
                VSK_SA.Open();

                List<NetPrice_Model> DataList = SqlMapper.Query<NetPrice_Model>(VSK_SA, "SP_Prnetfile_Import_upload", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();

                VSK_SA.Close();
                return DataList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        #endregion


        #region import_prnetflie_tmptrans_emmas
        public void import_prnetflie_tmptrans_emmas(List<NetPrice_Prnetfile_Model> NetPrice_Prnetfile_Model)
        {
            try
            {

                Connection();
                VSK_SA.Open();

                foreach (var ImportDataArrayData in NetPrice_Prnetfile_Model)
                {
                    DynamicParameters objParam = new DynamicParameters();

                    objParam.Add("@ref_id", ImportDataArrayData.ref_id);
                    objParam.Add("@mode", ImportDataArrayData.mode);
                    objParam.Add("@netprice_code", ImportDataArrayData.netprice_code);
                    objParam.Add("@emmas_code", ImportDataArrayData.emmas_code);
                    objParam.Add("@emmas_name", ImportDataArrayData.emmas_name);
                    objParam.Add("@created_by", ImportDataArrayData.created_by);
                   
                    VSK_SA.Execute("SP_Prnetfile_Update_emmas_tmptran", objParam, commandTimeout: 600, commandType: CommandType.StoredProcedure);

                }

                VSK_SA.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region import_prnetflie_tmpverify_emmas
        public List<NetPrice_Model> import_prnetflie_tmpverify_emmas(NetPrice_Model NetPrice_Model)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@ref_id", NetPrice_Model.ref_id);

                Connection();
                VSK_SA.Open();

                List<NetPrice_Model> DataList = SqlMapper.Query<NetPrice_Model>(VSK_SA, "SP_Prnetfile_Update_emmas_verify", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();

                VSK_SA.Close();
                return DataList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        #endregion

        #region import_prnetflie_tmpupload_emmas
        public List<NetPrice_Model> import_prnetflie_tmpupload_emmas(NetPrice_Model NetPrice_Model)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@ref_id", NetPrice_Model.ref_id);
                objParam.Add("@updated_by", NetPrice_Model.updated_by);

                Connection();
                VSK_SA.Open();

                List<NetPrice_Model> DataList = SqlMapper.Query<NetPrice_Model>(VSK_SA, "SP_Prnetfile_Update_emmas_upload", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();

                VSK_SA.Close();
                return DataList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        #endregion


        #region prnettra_list
        public List<prnettraModel> prnettra_list(prnettraModel prnettraModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@ecode", prnettraModel.ecode);

                Connection();
                VSK_SA.Open();

                List<prnettraModel> DataList = SqlMapper.Query<prnettraModel>(VSK_SA, "SP_Prnettra_List", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();

                VSK_SA.Close();
                return DataList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        #endregion

        #region prnettra_action
        public List<prnettraModel> prnettra_action(prnettraModel prnettraModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@ref_id", prnettraModel.ref_id);
                objParam.Add("@mode", prnettraModel.mode);
                objParam.Add("@gcode", prnettraModel.gcode);
                objParam.Add("@gname", prnettraModel.gname);
                objParam.Add("@Qty_A", prnettraModel.Qty_A);
                objParam.Add("@Qty_B", prnettraModel.Qty_B);
                objParam.Add("@NetPrice", prnettraModel.NetPrice);
                objParam.Add("@gunit", prnettraModel.gunit);
                objParam.Add("@ecode", prnettraModel.ecode);
                objParam.Add("@created_by", prnettraModel.created_by);

                Connection();
                VSK_SA.Open();
                List<prnettraModel> DataList = SqlMapper.Query<prnettraModel>(VSK_SA, "SP_Prnettra_Action", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();

                VSK_SA.Close();
                return DataList.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region prnettra_check
        public List<prnetcheckModel> prnettra_check(string gcode, string ecode)
        {
            try
            {
                string SQLQuery;

                SQLQuery = "SELECT TOP 1 gcode FROM prnettra WHERE RTRIM(gcode) = '" + gcode + "' AND RTRIM(ecode) = '" + ecode + "'";

                Connection();
                Vorwins.Open();
                List<prnetcheckModel> Dis_prnettra_check = Vorwins.Query<prnetcheckModel>(SQLQuery).ToList();
                Vorwins.Close();
                return Dis_prnettra_check.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region prnettra_gunit
        public List<prnetcheckModel> prnettra_gunit(string gcode, string gunit)
        {
            try
            {
                string SQLQuery;

                SQLQuery = "SELECT TOP 1 stmas.code FROM vorswin.dbo.stmas stmas LEFT JOIN vorswin.dbo.goodprice goodprice ON stmas.code = goodprice.code WHERE RTRIM(stmas.code) = RTRIM('" + gcode + "' ) AND (RTRIM(stmas.UOM) = RTRIM('" + gunit + "') OR RTRIM(goodprice.gunit) = RTRIM('" + gunit + "') OR RTRIM(goodprice.goutput) = RTRIM('" + gunit + "'))  ";

                Connection();
                Vorwins.Open();
                List<prnetcheckModel> Dis_prnettra_gunit = Vorwins.Query<prnetcheckModel>(SQLQuery).ToList();
                Vorwins.Close();
                return Dis_prnettra_gunit.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region import_prnettra_temp_file
        public List<prnettraModel> import_prnettra_tmpfile(prnettraModel prnettraModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@ref_id", prnettraModel.ref_id);
                objParam.Add("@mode", prnettraModel.mode);
                objParam.Add("@created_by", prnettraModel.created_by);
                objParam.Add("@count_trans", prnettraModel.count_trans);

                Connection();
                VSK_SA.Open();

                List<prnettraModel> DataList = SqlMapper.Query<prnettraModel>(VSK_SA, "SP_Prnettra_Import_file", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();

                VSK_SA.Close();
                return DataList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        #endregion

        #region import_prnettra_tmptrans
        public void import_prnettra_tmptrans(List<prnettraModel> prnettraModel)
        {
            try
            {

                Connection();
                VSK_SA.Open();

                foreach (var ImportDataArrayData in prnettraModel)
                {
                    DynamicParameters objParam = new DynamicParameters();

                    objParam.Add("@ref_id", ImportDataArrayData.ref_id);
                    objParam.Add("@mode", ImportDataArrayData.mode);
                    objParam.Add("@gcode", ImportDataArrayData.gcode);
                    objParam.Add("@gname", ImportDataArrayData.gname);
                    objParam.Add("@Qty_A", ImportDataArrayData.Qty_A);
                    objParam.Add("@Qty_B", ImportDataArrayData.Qty_B);
                    objParam.Add("@NetPrice", ImportDataArrayData.NetPrice);
                    objParam.Add("@gunit", ImportDataArrayData.gunit);
                    objParam.Add("@ecode", ImportDataArrayData.ecode);
                    objParam.Add("@userid", ImportDataArrayData.userid);

                    VSK_SA.Execute("SP_Prnettra_Import_tmptran", objParam, commandTimeout: 600, commandType: CommandType.StoredProcedure);

                }

                VSK_SA.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region import_prnettra_tmpverify
        public List<prnettraModel> import_prnettra_tmpverify(prnettraModel prnettraModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@ref_id", prnettraModel.ref_id);

                Connection();
                VSK_SA.Open();

                List<prnettraModel> DataList = SqlMapper.Query<prnettraModel>(VSK_SA, "SP_Prnettra_Import_verify", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();

                VSK_SA.Close();
                return DataList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        #endregion

        #region import_prnettra_tmpupload
        public List<prnettraModel> import_prnettra_tmpupload(prnettraModel prnettraModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@ref_id", prnettraModel.ref_id);
                objParam.Add("@updated_by", prnettraModel.updated_by);

                Connection();
                VSK_SA.Open();

                List<prnettraModel> DataList = SqlMapper.Query<prnettraModel>(VSK_SA, "SP_Prnettra_Import_upload", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();

                VSK_SA.Close();
                return DataList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        #endregion

        public List<pre_emmaspModel> Dis_emmas_List(string code, string mode) //mode netprice or egdis
        {
            try
            {
                string SQLQuery;

                if (mode == "netprice")
                {
                    SQLQuery = "SELECT " +
                               "    RTRIM(code) AS emmas_code, " +
                               "    RTRIM(lname) AS emmas_lname, " +
                               "    RTRIM(eaddress) AS emmas_address, " +
                               "    RTRIM(etumbol) AS emmas_tumbol, " +
                               "    RTRIM(eamphur) AS emmas_eamphur, " +
                               "    RTRIM(eprovinc) AS emmas_eprovinc, " +
                               "    RTRIM(ezip) AS emmas_zip, " +
                               "    RTRIM(netprice) AS emmas_netprice, " +
                               "    RTRIM(egdis) AS emmas_egdis " +
                               "FROM dbo.emmas WHERE netprice = '" + code + "' ORDER BY code ASC";
                }
                else if (mode == "egdis")
                {
                    SQLQuery = "SELECT " +
                               "    RTRIM(code) AS emmas_code, " +
                               "    RTRIM(lname) AS emmas_lname, " +
                               "    RTRIM(eaddress) AS emmas_address, " +
                               "    RTRIM(etumbol) AS emmas_tumbol, " +
                               "    RTRIM(eamphur) AS emmas_eamphur, " +
                               "    RTRIM(eprovinc) AS emmas_eprovinc, " +
                               "    RTRIM(ezip) AS emmas_zip, " +
                               "    RTRIM(netprice) AS emmas_netprice, " +
                               "    RTRIM(egdis) AS emmas_egdis " +
                               "FROM dbo.emmas WHERE egdis = '" + code + "' ORDER BY code ASC";
                }
                else
                {
                    SQLQuery = "SELECT 'ERROR' as event_status";
                }

                Connection();
                Vorwins.Open();
                List<pre_emmaspModel> Dis_pre_emmaspList = Vorwins.Query<pre_emmaspModel>(SQLQuery).ToList();
                Vorwins.Close();
                return Dis_pre_emmaspList.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


    }
}