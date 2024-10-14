using Dapper;
using REPO.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web.Mvc;

namespace REPO.Controllers
{
    public class DiscountRepository : Controller
    {
        #region Connection_SQL Server
        //-------------------Start Connection_SQL ------------------------//
        public SqlConnection VSK_Data;
        public SqlConnection Vorwins;
        public SqlConnection Vskmis;
        public SqlConnection VSK_SA;


        private void Connection()
        {
            VSK_Data = new SqlConnection(ConfigurationManager.ConnectionStrings["VSK_Data"].ToString());
            Vorwins = new SqlConnection(ConfigurationManager.ConnectionStrings["Vorwins"].ToString());
            //Vorwins = new SqlConnection(ConfigurationManager.ConnectionStrings["Vorwins"].ToString()); //เปลี่ยนด้วย
            Vskmis = new SqlConnection(ConfigurationManager.ConnectionStrings["Vskmis"].ToString());
            VSK_SA = new SqlConnection(ConfigurationManager.ConnectionStrings["VSK_SA"].ToString());
        }

        //-------------------End Connection_SQL ------------------------//
        #endregion
      
        public List<ResponseSelect2Model> gdishead_select2_search(string id, string text, string keywords, string name)
        {
            try
            {
                string SQLQuery = "SELECT TOP 5 " + id + " AS id, " + text + " as text, " + name + " as name  FROM gdishead WHERE RTRIM(code) LIKE '" + keywords + "%' OR RTRIM(lname) LIKE '" + keywords + "%' OR RTRIM(remark) LIKE '" + keywords + "%'";
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
        public List<ResponseStmasSelect2Model> stmas_select2_search(string id, string text, string keywords)
        {
            try
            {

                //List<ResponseStmasSelect2Model> MasListData = new List<ResponseStmasSelect2Model>();
                //List<ResponseStmasSelect2Model> MasList;

                //string SQLQuery1 = "SELECT TOP 10 " + id + " AS id, " + text + " as text , AvgSalecost, UOM , name FROM vorswin.dbo.stmas WHERE '" + keywords + "' != '' AND  (RTRIM(gbarcode) LIKE '%" + keywords + "%' OR RTRIM(name) LIKE '%" + keywords + "%' OR RTRIM(code) LIKE '%" + keywords + "%' OR RTRIM(SPCODES) LIKE '%" + keywords + "%' OR RTRIM(CHRCODE) LIKE '%" + keywords + "%')";
                //string SQLQuery2 = "SELECT TOP 10 " + id + " AS id, " + text + " as text , AvgSalecost, UOM , name FROM vorswin.dbo.stmas_exp WHERE '" + keywords + "' != '' AND  (RTRIM(gbarcode) LIKE '%" + keywords + "%' OR RTRIM(name) LIKE '%" + keywords + "%' OR RTRIM(code) LIKE '%" + keywords + "%' OR RTRIM(SPCODES) LIKE '%" + keywords + "%' OR RTRIM(CHRCODE) LIKE '%" + keywords + "%')";

                //Connection();
                //Vskmis.Open();

                //MasList = Vskmis.Query<ResponseStmasSelect2Model>(SQLQuery1).ToList();
                //MasListData.AddRange(MasList);

                //MasList = Vskmis.Query<ResponseStmasSelect2Model>(SQLQuery2).ToList();
                //MasListData.AddRange(MasList);

                string SQLQuery = "SELECT TOP 10 " + id + " AS id, " + text + " as text, AvgSalecost, UOM , name FROM vorswin.dbo.stmas WHERE '" + keywords + "' != '' AND  (RTRIM(gbarcode) LIKE '%" + keywords + "%' OR RTRIM(name) LIKE '%" + keywords + "%' OR RTRIM(code) LIKE '%" + keywords + "%' OR RTRIM(SPCODES) LIKE '%" + keywords + "%')";
                Connection();
                Vorwins.Open();
                List<ResponseStmasSelect2Model> RequestModelList = Vorwins.Query<ResponseStmasSelect2Model>(SQLQuery).ToList();

                Vorwins.Close();
                return RequestModelList.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public List<ResponseSelect2Model> discgroup_select2_search(string id, string text, string keywords, string mode)
        {
            try
            {
                string SQLQuery = "SELECT DISTINCT " + id + " AS id, " + text + " as text , RTRIM(named) as gname  " +
                                   " FROM vorswin.dbo.stmas stmas" +
                                   " WHERE TYPE != '' AND RTRIM(TYPE) = '" + mode + "' ";

                Connection();
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
        public List<ResponseSelect2Model> gcode_a_select2_search(string id, string text, string keywords)
        {
            try
            {
                string SQLQuery = "SELECT TOP 10 " + id + " AS id, " + text + " as text ,gname ,codechr ,itemgroup ,groupname ,uom " +
                                    " FROM vorswin.dbo.gcode_a gcode_a" +
                                    " WHERE '" + keywords + "' != '' " +
                                    " AND ( RTRIM(code) LIKE '%" + keywords + "%' OR RTRIM(gname) LIKE '%" + keywords + "%' OR RTRIM(codechr) LIKE '%" + keywords + "%' OR RTRIM(itemgroup) LIKE '%" + keywords + "%' OR RTRIM(groupname) LIKE '%" + keywords + "%' )";
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
        public List<ResponseSelect2Model> gcode_c_select2_search(string id, string text, string keywords)
        {
            try
            {
                string SQLQuery = "SELECT DISTINCT TOP 10 " + id + " AS id, " + text + " as text , RTRIM(TYPE) as gname  " +
                                    " FROM vorswin.dbo.stmas stmas" +
                                    " WHERE '" + keywords + "' != '' " +
                                    " AND ( RTRIM(code) LIKE '%" + keywords + "%' OR RTRIM(TYPE) LIKE '%" + keywords + "%' )";
                //string SQLQuery = "SELECT TOP 10 " + id + " AS id, " + text + " as text ,gname ,rec " +
                //                    " FROM vorswin.dbo.gcode_c gcode_c" +
                //                    " WHERE '" + keywords + "' != '' " +
                //                    " AND ( RTRIM(code) LIKE '%" + keywords + "%' OR RTRIM(gname) LIKE '%" + keywords + "%' )";
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

        #region ediscount_list
        public List<ediscountModel> ediscount_list(ediscountModel ediscountModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@mode", ediscountModel.mode);
                objParam.Add("@ecode", ediscountModel.ecode);

                Connection();
                VSK_SA.Open();

                List<ediscountModel> DataList = SqlMapper.Query<ediscountModel>(VSK_SA, "SP_Ediscount_List", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();

                VSK_SA.Close();
                return DataList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        #endregion
        #region ediscount_action
        public List<ediscountModel> ediscount_action(ediscountModel ediscountModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@code", ediscountModel.code);
                objParam.Add("@cargroup", ediscountModel.cargroup);
                objParam.Add("@chrcode", ediscountModel.chrcode);
                objParam.Add("@adis1", ediscountModel.adis1);
                objParam.Add("@adis2", ediscountModel.adis2);
                objParam.Add("@adis3", ediscountModel.adis3);
                objParam.Add("@bdis1", ediscountModel.bdis1);
                objParam.Add("@bdis2", ediscountModel.bdis2);
                objParam.Add("@bdis3", ediscountModel.bdis3);
                objParam.Add("@cdis1", ediscountModel.cdis1);
                objParam.Add("@cdis2", ediscountModel.cdis2);
                objParam.Add("@cdis3", ediscountModel.cdis3);
                objParam.Add("@ddis1", ediscountModel.ddis1);
                objParam.Add("@ddis2", ediscountModel.ddis2);
                objParam.Add("@ddis3", ediscountModel.ddis3);
                objParam.Add("@edis1", ediscountModel.edis1);
                objParam.Add("@edis2", ediscountModel.edis2);
                objParam.Add("@edis3", ediscountModel.edis3);
                objParam.Add("@dvat", ediscountModel.dvat);
                objParam.Add("@ecode", ediscountModel.ecode);
                objParam.Add("@created_by", ediscountModel.created_by);
                objParam.Add("@mode", ediscountModel.mode);
                objParam.Add("@ref_id", ediscountModel.ref_id);

                Connection();
                VSK_SA.Open();
                List<ediscountModel> DataList = SqlMapper.Query<ediscountModel>(VSK_SA, "SP_Ediscount_Action", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();

                VSK_SA.Close();
                return DataList.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion
        #region ediscount_check
        public List<ediscountModel> ediscount_check(string code, string cargroup, string ecode, string chrcode)
        {
            try
            {
                string SQLQuery;


                SQLQuery = "SELECT TOP 1 code FROM ediscount WHERE RTRIM(code) = '" + code + "' AND RTRIM(cargroup) = '" + cargroup + "' AND RTRIM(ecode) = '" + ecode + "' AND RTRIM(chrcode) = '" + chrcode + "'";


                Connection();
                Vorwins.Open();
                List<ediscountModel> Dis_ediscount_check = Vorwins.Query<ediscountModel>(SQLQuery).ToList();
                Vorwins.Close();
                return Dis_ediscount_check.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region import_ediscount_temp_file
        public List<ediscountModel> import_ediscount_tmpfile(ediscountModel ediscountModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@ref_id", ediscountModel.ref_id);
                objParam.Add("@mode", ediscountModel.mode);
                objParam.Add("@created_by", ediscountModel.created_by);
                objParam.Add("@count_trans", ediscountModel.count_trans);

                Connection();
                VSK_SA.Open();

                List<ediscountModel> DataList = SqlMapper.Query<ediscountModel>(VSK_SA, "SP_Ediscount_Import_file", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();

                VSK_SA.Close();
                return DataList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        #endregion

        #region import_ediscount_tmptrans
        public void import_ediscount_tmptrans(List<ediscountModel> ediscountModel)
        {
            try
            {

                Connection();

                VSK_SA.Open();

                foreach (var ImportDataArrayData in ediscountModel)
                {
                    DynamicParameters objParam = new DynamicParameters();

                    objParam.Add("@code", ImportDataArrayData.code);
                    objParam.Add("@cargroup", ImportDataArrayData.cargroup);
                    objParam.Add("@chrcode", ImportDataArrayData.chrcode);
                    objParam.Add("@adis1", ImportDataArrayData.adis1);
                    objParam.Add("@adis2", ImportDataArrayData.adis2);
                    objParam.Add("@adis3", ImportDataArrayData.adis3);
                    objParam.Add("@bdis1", ImportDataArrayData.bdis1);
                    objParam.Add("@bdis2", ImportDataArrayData.bdis2);
                    objParam.Add("@bdis3", ImportDataArrayData.bdis3);
                    objParam.Add("@cdis1", ImportDataArrayData.cdis1);
                    objParam.Add("@cdis2", ImportDataArrayData.cdis2);
                    objParam.Add("@cdis3", ImportDataArrayData.cdis3);
                    objParam.Add("@ddis1", ImportDataArrayData.ddis1);
                    objParam.Add("@ddis2", ImportDataArrayData.ddis2);
                    objParam.Add("@ddis3", ImportDataArrayData.ddis3);
                    objParam.Add("@edis1", ImportDataArrayData.edis1);
                    objParam.Add("@edis2", ImportDataArrayData.edis2);
                    objParam.Add("@edis3", ImportDataArrayData.edis3);
                    objParam.Add("@dvat", ImportDataArrayData.dvat);
                    objParam.Add("@ecode", ImportDataArrayData.ecode);
                    objParam.Add("@created_by", ImportDataArrayData.created_by);
                    objParam.Add("@mode", ImportDataArrayData.mode);
                    objParam.Add("@ref_id", ImportDataArrayData.ref_id);

                    VSK_SA.Execute("SP_Ediscount_Import_tmptran", objParam, commandTimeout: 600, commandType: CommandType.StoredProcedure);

                }

                VSK_SA.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region import_ediscount_tmpverify
        public List<ediscountModel> import_ediscount_tmpverify(ediscountModel ediscountModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@ref_id", ediscountModel.ref_id);

                Connection();
                VSK_SA.Open();

                List<ediscountModel> DataList = SqlMapper.Query<ediscountModel>(VSK_SA, "SP_Ediscount_Import_verify", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();

                VSK_SA.Close();
                return DataList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        #endregion

        #region import_ediscount_tmpupload
        public List<ediscountModel> import_ediscount_tmpupload(ediscountModel ediscountModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@ref_id", ediscountModel.ref_id);
                objParam.Add("@updated_by", ediscountModel.updated_by);

                Connection();
                VSK_SA.Open();

                List<ediscountModel> DataList = SqlMapper.Query<ediscountModel>(VSK_SA, "SP_Ediscount_Import_upload", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();

                VSK_SA.Close();
                return DataList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        #endregion


        #region gdishead_list
        public List<gdisheadModel> gdishead_list(gdisheadModel gdisheadModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@mode", gdisheadModel.mode);

                Connection();
                VSK_SA.Open();

                List<gdisheadModel> DataList = SqlMapper.Query<gdisheadModel>(VSK_SA, "SP_Gdishead_List", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();

                VSK_SA.Close();
                return DataList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        #endregion

        #region gdishead_action
        public List<gdisheadModel> gdishead_action(gdisheadModel gdisheadModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@ref_id", gdisheadModel.ref_id);
                objParam.Add("@mode", gdisheadModel.mode);
                objParam.Add("@code", gdisheadModel.code);
                objParam.Add("@lname", gdisheadModel.lname);
                objParam.Add("@remark", gdisheadModel.remark);
                objParam.Add("@procby", gdisheadModel.procby);
                objParam.Add("@created_by", gdisheadModel.created_by);

                Connection();
                VSK_SA.Open();
                List<gdisheadModel> DataList = SqlMapper.Query<gdisheadModel>(VSK_SA, "SP_Gdishead_Action", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();

                VSK_SA.Close();
                return DataList.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region gdishead_check
        public List<gdisheadModel> gdishead_check(string code)
        {
            try
            {
                string SQLQuery;

                SQLQuery = "SELECT TOP 1 code FROM gdishead WHERE code = '" + code + "' ";

                Connection();
                Vorwins.Open();
                List<gdisheadModel> Dis_gdishead_check = Vorwins.Query<gdisheadModel>(SQLQuery).ToList();
                Vorwins.Close();
                return Dis_gdishead_check.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion


    }
}