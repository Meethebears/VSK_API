using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

using Dapper;
using MySql.Data.MySqlClient;
using REPO.Models;

namespace REPO.Controllers
{
    public class MasterDataRepository
    {

        #region Connection_SQL Server
        //-------------------Start Connection_SQL ------------------------//

        public SqlConnection VSK_IVC;
        public SqlConnection VSK_DATA_249;
        public SqlConnection VSK_DATA_213;
        public SqlConnection VSK_DATA_187;

        private void Connection()
        {

            VSK_IVC = new SqlConnection(ConfigurationManager.ConnectionStrings["VSK_IVC_187"].ToString());
            VSK_DATA_249 = new SqlConnection(ConfigurationManager.ConnectionStrings["VSK_DATA_249"].ToString());
            VSK_DATA_213 = new SqlConnection(ConfigurationManager.ConnectionStrings["VSK_DATA_213"].ToString());
            VSK_DATA_187 = new SqlConnection(ConfigurationManager.ConnectionStrings["VSK_DATA_187"].ToString());

        }

        //-------------------End Connection_SQL ------------------------//
        #endregion

        #region MasterData_Get
        public List<MasterDataModel> MasterData_Get(MasterDataModel MasterDataModel)
        {
            try
            {
                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@mode", MasterDataModel.mode);
                objParam.Add("@keywords", MasterDataModel.keywords);
                objParam.Add("@parameter_1", MasterDataModel.parameter_1);
                objParam.Add("@parameter_2", MasterDataModel.parameter_2);
                objParam.Add("@parameter_3", MasterDataModel.parameter_3);

                Connection();
                VSK_IVC.Open();
                List<MasterDataModel> master_date = SqlMapper.Query<MasterDataModel>(VSK_IVC, "SP_MASTER_DATA", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();

                VSK_IVC.Close();
                return master_date.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        /*
        #region Cn_Req_Saletra_Branch_Get
        public List<StmasModel> Cn_Req_Saletra_Branch_Get(string branch, string number)
        {
            try
            {

                List<StmasModel> _ResponseData;

                string dbstr;
                string SQLQuery = "";

                SQLQuery = "SELECT" +
                            " trndate AS trndate, RTRIM( number ) AS number, RTRIM( invpo ) AS invpo, RTRIM( empcod ) AS empcod, RTRIM( empname ) AS empname, RTRIM( stkcod ) AS stkcod, RTRIM( gbarcode ) AS gbarcode, RTRIM( spcodes ) AS spcodes, RTRIM( stkname ) AS stkname, RTRIM( stkunit ) AS stkunit, RTRIM( whdiscode ) AS whdiscode, RTRIM( userid ) AS userid, RTRIM( salegroup_uptodate ) AS salegroup_uptodate, RTRIM( named ) AS named, RTRIM( customerGrade ) AS customerGrade, RTRIM( PKuser ) AS PKuser, RTRIM( saleperson ) AS saleperson, trnqty AS item,trnprnet AS trnprnet " +
                            " FROM saletra t" +
                            " WHERE RTRIM(t.number) = '" + number + "' ";

                if (branch == "VSK" || branch == "VSM")
                {
                    dbstr = ConfigurationManager.ConnectionStrings["VSK_DATA_249"].ToString();

                }
                else if (branch == "VSF")
                {
                    dbstr = ConfigurationManager.ConnectionStrings["VSF_DATA"].ToString();

                }
                else if (branch == "KLH")
                {
                    dbstr = ConfigurationManager.ConnectionStrings["KLH_DATA"].ToString();

                }
                else if (branch == "LLK")
                {
                    dbstr = ConfigurationManager.ConnectionStrings["LLK_DATA"].ToString();

                }
                else if (branch == "NWM")
                {
                    dbstr = ConfigurationManager.ConnectionStrings["NWM_DATA"].ToString();

                }
                else if (branch == "LKS" && branch == "KSW")
                {
                    dbstr = ConfigurationManager.ConnectionStrings["LKS_DATA"].ToString();

                }
                else if (branch == "SNK")
                {
                    dbstr = ConfigurationManager.ConnectionStrings["SNK_DATA"].ToString();

                }
                else if (branch == "EBB")
                {
                    dbstr = ConfigurationManager.ConnectionStrings["EBB_DATA"].ToString();

                }
                else if (branch == "RTB")
                {
                    dbstr = ConfigurationManager.ConnectionStrings["RTB_DATA"].ToString();

                }
                else
                {
                    dbstr = ConfigurationManager.ConnectionStrings["VSK_DATA"].ToString();

                }

                mscon = new SqlConnection(dbstr);
                mscon.Open();
                _ResponseData = mscon.Query<CnReqSaletraModel>(SQLQuery).ToList();
                mscon.Close();
                return _ResponseData.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        #endregion
        */

        public List<BRModel> MasterBR_Get(string number)
        {
            try
            {
                string SQLQuery = "SELECT brfile.* , (SELECT TOP 1 pobatch FROM brtra WHERE brtra.number = brfile.number ) AS pobatch FROM brfile WHERE RTRIM(brfile.number) = '" + number + "' ";
                Connection();
                VSK_DATA_249.Open();
                List<BRModel> _ResponseData = VSK_DATA_249.Query<BRModel>(SQLQuery).ToList();
                VSK_DATA_249.Close();
                return _ResponseData.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public List<StmasModel> MasterStmas_Get(StmasModel StmasModel)
        {
            try
            {
                Connection();

                List<StmasModel> _ResponseData;

                string SQLQuery = "";

                SQLQuery = "SELECT TOP 1 " +
                "rtrim(code) as code, " +
                "rtrim(name) as name, " +
                "rtrim(gnamechr) as gnamechr, " +
                "rtrim(CHRCODE) as CHRCODE, " +
                "rtrim(code_a) as code_a, " +
                "rtrim(gmodel) as gmodel, " +
                "rtrim(code_b) as code_b, " +
                "rtrim(TYPE) as TYPE, " +
                "rtrim(code_c) as code_c, " +
                "rtrim(GUSED) as GUSED, " +
                "rtrim(code_d) as code_d, " +
                "rtrim(gOem) as gOem, " +
                "rtrim(code_e) as code_e, " +
                "rtrim(gbarcode) as gbarcode, " +
                "rtrim(SPCODES) as SPCODES, " +
                "rtrim(UOM) as UOM, " +
                "rtrim(codeOem) as CodeOem, " +
                "rtrim(GDIMENSION) as GDIMENSION, " +
                "rtrim(carGeneration) as Cargeneration, " +
                "rtrim(matchinno) as matchinno, " +
                "rtrim(bodyno) as bodyno, " +
                "rtrim(carEngine) as CarEngine, " +
                "rtrim(carBody) as Carbody, " +
                "rtrim(carBodyCode) as Carbodycode, " +
                "rtrim(carFmyear) as carFmyear, " +
                "rtrim(carToyear) as CarToyear, " +
                "gdescript, " +
                "rtrim(partOem) as partOem, " +
                "rtrim(glocat) as glocat, " +
                "rtrim(gzone) as gzone, " +
                "rtrim(onpend) as Onpend, " +
                "rtrim(onhandv) as Onhandv, " +
                "rtrim(gamountv) as gamountv, " +
                "rtrim(donotpur) as donotpur, " +
                "rtrim(donotsale) as donotsale, " +
                "rtrim(ginactive) as ginactive, " +
                "rtrim(custconfirm) as custconfirm, " +
                "rtrim(WH02) as WH02, " +
                "rtrim(WH03) as WH03, " +
                "rtrim(WH04) as WH04, " +
                "rtrim(WH05) as WH05, " +
                "rtrim(WH06) as WH06, " +
                "rtrim(WH07) as WH07, " +
                "rtrim(WH08) as WH08, " +
                "rtrim(WH09) as WH09, " +
                "rtrim(WH10) as WH10, " +
                "rtrim(WH11) as WH11, " +
                "rtrim(WH12) as WH12, " +
                "rtrim(gperA) as gperA, " +
                "rtrim(gperB) as gperB, " +
                "rtrim(gperC) as gperC, " +
                "rtrim(gperD) as gperD, " +
                "rtrim(gperE) as gperE, " +
                "rtrim(gperF) as gperF, " +
                "rtrim(gpriceA) as gpriceA, " +
                "rtrim(gpriceB) as gpriceB, " +
                "rtrim(gpriceC) as gpriceC, " +
                "rtrim(gpriceD) as gpriceD, " +
                "rtrim(gpriceE) as gpriceE, " +
                "rtrim(gpriceF) as gpriceF, " +
                "rtrim(gprice) as gprice, " +
                "rtrim(gpricepur) as gpricepur, " +
                "rtrim(Salecost) as Salecost, " +
                "rtrim(gcost) as gcost, " +
                "rtrim(AvgSalecost) as AvgSalecost, " +
                "rtrim(avgcost) as avgcost, " +
                "rtrim(qtysmall) as qtysmall, " +
                "rtrim(costtype) as costtype, " +
                "rtrim(namedpu) as namedpu " +
                " FROM dbo.stmas s " +
                " WHERE ( RTRIM(s.code) = RTRIM('" + StmasModel.keywords + "') " +
                " OR RTRIM(s.gbarcode) = RTRIM('" + StmasModel.keywords + "')  " +
                " OR RTRIM(s.spcodes) = RTRIM('" + StmasModel.keywords + "') )";

                VSK_DATA_213.Open();
                _ResponseData = VSK_DATA_213.Query<StmasModel>(SQLQuery).ToList();
                VSK_DATA_213.Close();


                return _ResponseData.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public List<StmasModel> MasterStmas_213_Get(StmasModel StmasModel)
        {
            try
            {
                Connection();

                List<StmasModel> _ResponseData;

                string SQLQuery = "";

                SQLQuery = "SELECT TOP 1 " +
                "rtrim(code) as code, " +
                "rtrim(name) as name, " +
                "rtrim(gnamechr) as gnamechr, " +
                "rtrim(CHRCODE) as CHRCODE, " +
                "rtrim(code_a) as code_a, " +
                "rtrim(gmodel) as gmodel, " +
                "rtrim(code_b) as code_b, " +
                "rtrim(TYPE) as TYPE, " +
                "rtrim(code_c) as code_c, " +
                "rtrim(GUSED) as GUSED, " +
                "rtrim(code_d) as code_d, " +
                "rtrim(gOem) as gOem, " +
                "rtrim(code_e) as code_e, " +
                "rtrim(gbarcode) as gbarcode, " +
                "rtrim(SPCODES) as SPCODES, " +
                "rtrim(UOM) as UOM, " +
                "rtrim(codeOem) as CodeOem, " +
                "rtrim(GDIMENSION) as GDIMENSION, " +
                "rtrim(carGeneration) as Cargeneration, " +
                "rtrim(matchinno) as matchinno, " +
                "rtrim(bodyno) as bodyno, " +
                "rtrim(carEngine) as CarEngine, " +
                "rtrim(carBody) as Carbody, " +
                "rtrim(carBodyCode) as Carbodycode, " +
                "rtrim(carFmyear) as carFmyear, " +
                "rtrim(carToyear) as CarToyear, " +
                "gdescript, " +
                "rtrim(partOem) as partOem, " +
                "rtrim(glocat) as glocat, " +
                "rtrim(gzone) as gzone, " +
                "rtrim(onpend) as Onpend, " +
                "rtrim(onhandv) as Onhandv, " +
                "rtrim(gamountv) as gamountv, " +
                "rtrim(donotpur) as donotpur, " +
                "rtrim(donotsale) as donotsale, " +
                "rtrim(ginactive) as ginactive, " +
                "rtrim(custconfirm) as custconfirm, " +
                "rtrim(WH02) as WH02, " +
                "rtrim(WH03) as WH03, " +
                "rtrim(WH04) as WH04, " +
                "rtrim(WH05) as WH05, " +
                "rtrim(WH06) as WH06, " +
                "rtrim(WH07) as WH07, " +
                "rtrim(WH08) as WH08, " +
                "rtrim(WH09) as WH09, " +
                "rtrim(WH10) as WH10, " +
                "rtrim(WH11) as WH11, " +
                "rtrim(WH12) as WH12, " +
                "rtrim(gperA) as gperA, " +
                "rtrim(gperB) as gperB, " +
                "rtrim(gperC) as gperC, " +
                "rtrim(gperD) as gperD, " +
                "rtrim(gperE) as gperE, " +
                "rtrim(gperF) as gperF, " +
                "rtrim(gpriceA) as gpriceA, " +
                "rtrim(gpriceB) as gpriceB, " +
                "rtrim(gpriceC) as gpriceC, " +
                "rtrim(gpriceD) as gpriceD, " +
                "rtrim(gpriceE) as gpriceE, " +
                "rtrim(gpriceF) as gpriceF, " +
                "rtrim(gprice) as gprice, " +
                "rtrim(gpricepur) as gpricepur, " +
                "rtrim(Salecost) as Salecost, " +
                "rtrim(gcost) as gcost, " +
                "rtrim(AvgSalecost) as AvgSalecost, " +
                "rtrim(avgcost) as avgcost, " +
                "rtrim(qtysmall) as qtysmall, " +
                "rtrim(costtype) as costtype, " +
                "rtrim(namedpu) as namedpu " +
                " FROM dbo.stmas s " +
                " WHERE ( RTRIM(s.code) = RTRIM('" + StmasModel.keywords + "') " +
                " OR RTRIM(s.gbarcode) = RTRIM('" + StmasModel.keywords + "')  " +
                " OR RTRIM(s.spcodes) = RTRIM('" + StmasModel.keywords + "') )";

                VSK_DATA_213.Open();
                _ResponseData = VSK_DATA_213.Query<StmasModel>(SQLQuery).ToList();
                VSK_DATA_213.Close();


                return _ResponseData.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public List<StmasModel> MasterStmas_187_Get(StmasModel StmasModel)
        {
            try
            {
                Connection();

                List<StmasModel> _ResponseData;

                string SQLQuery = "";

                SQLQuery = "SELECT TOP 1 " +
                "rtrim(code) as code, " +
                "rtrim(name) as name, " +
                "rtrim(gnamechr) as gnamechr, " +
                "rtrim(CHRCODE) as CHRCODE, " +
                "rtrim(code_a) as code_a, " +
                "rtrim(gmodel) as gmodel, " +
                "rtrim(code_b) as code_b, " +
                "rtrim(TYPE) as TYPE, " +
                "rtrim(code_c) as code_c, " +
                "rtrim(GUSED) as GUSED, " +
                "rtrim(code_d) as code_d, " +
                "rtrim(gOem) as gOem, " +
                "rtrim(code_e) as code_e, " +
                "rtrim(gbarcode) as gbarcode, " +
                "rtrim(SPCODES) as SPCODES, " +
                "rtrim(UOM) as UOM, " +
                "rtrim(codeOem) as CodeOem, " +
                "rtrim(GDIMENSION) as GDIMENSION, " +
                "rtrim(carGeneration) as Cargeneration, " +
                "rtrim(matchinno) as matchinno, " +
                "rtrim(bodyno) as bodyno, " +
                "rtrim(carEngine) as CarEngine, " +
                "rtrim(carBody) as Carbody, " +
                "rtrim(carBodyCode) as Carbodycode, " +
                "rtrim(carFmyear) as carFmyear, " +
                "rtrim(carToyear) as CarToyear, " +
                "gdescript, " +
                "rtrim(partOem) as partOem, " +
                "rtrim(glocat) as glocat, " +
                "rtrim(gzone) as gzone, " +
                "rtrim(onpend) as Onpend, " +
                "rtrim(onhandv) as Onhandv, " +
                "rtrim(gamountv) as gamountv, " +
                "rtrim(donotpur) as donotpur, " +
                "rtrim(donotsale) as donotsale, " +
                "rtrim(ginactive) as ginactive, " +
                "rtrim(custconfirm) as custconfirm, " +
                "rtrim(WH02) as WH02, " +
                "rtrim(WH03) as WH03, " +
                "rtrim(WH04) as WH04, " +
                "rtrim(WH05) as WH05, " +
                "rtrim(WH06) as WH06, " +
                "rtrim(WH07) as WH07, " +
                "rtrim(WH08) as WH08, " +
                "rtrim(WH09) as WH09, " +
                "rtrim(WH10) as WH10, " +
                "rtrim(WH11) as WH11, " +
                "rtrim(WH12) as WH12, " +
                "rtrim(gperA) as gperA, " +
                "rtrim(gperB) as gperB, " +
                "rtrim(gperC) as gperC, " +
                "rtrim(gperD) as gperD, " +
                "rtrim(gperE) as gperE, " +
                "rtrim(gperF) as gperF, " +
                "rtrim(gpriceA) as gpriceA, " +
                "rtrim(gpriceB) as gpriceB, " +
                "rtrim(gpriceC) as gpriceC, " +
                "rtrim(gpriceD) as gpriceD, " +
                "rtrim(gpriceE) as gpriceE, " +
                "rtrim(gpriceF) as gpriceF, " +
                "rtrim(gprice) as gprice, " +
                "rtrim(gpricepur) as gpricepur, " +
                "rtrim(Salecost) as Salecost, " +
                "rtrim(gcost) as gcost, " +
                "rtrim(AvgSalecost) as AvgSalecost, " +
                "rtrim(avgcost) as avgcost, " +
                "rtrim(qtysmall) as qtysmall, " +
                "rtrim(costtype) as costtype, " +
                "rtrim(namedpu) as namedpu " +
                " FROM dbo.stmas s " +
                " LEFT JOIN dbo.barcode_ean13 ean ON rtrim(ean.barcode) = rtrim(s.gbarcode) AND ean.record_status = 1 " +
                " WHERE ( RTRIM(s.code) = RTRIM('" + StmasModel.keywords + "') " +
                " OR RTRIM(s.gbarcode) = RTRIM('" + StmasModel.keywords + "')  " +
                " OR RTRIM(s.spcodes) = RTRIM('" + StmasModel.keywords + "') " +
                " OR ean.ean13 = RTRIM('" + StmasModel.keywords + "') )";

                VSK_DATA_187.Open();
                _ResponseData = VSK_DATA_187.Query<StmasModel>(SQLQuery).ToList();
                VSK_DATA_187.Close();


                return _ResponseData.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }


        public List<MasterEan13Model> MasterEan13_Get(MasterEan13Model MasterEan13Model)
        {
            try
            {
                Connection();

                List<MasterEan13Model> _ResponseData;

                string SQLQuery = "";

                SQLQuery = "SELECT TOP 1 * " +
                " FROM dbo.barcode_ean13 m " +
                " WHERE ( RTRIM(m.ean13) = RTRIM('" + MasterEan13Model.keywords + "') " +
                " OR RTRIM(m.barcode) = RTRIM('" + MasterEan13Model.keywords + "') )";

                VSK_DATA_187.Open();
                _ResponseData = VSK_DATA_187.Query<MasterEan13Model>(SQLQuery).ToList();
                VSK_DATA_187.Close();


                return _ResponseData.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

    }
}