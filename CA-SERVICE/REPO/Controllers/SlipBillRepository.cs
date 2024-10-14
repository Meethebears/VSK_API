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
    public class SlipBillRepository : Controller
    {
        #region Connection_SQL Server
        //-------------------Start Connection_SQL ------------------------//
        public SqlConnection VSK_CA;
        public SqlConnection VSK_CA_VSK;
        public SqlConnection VSK_CA_VSF;
        public SqlConnection VSK_CA_KLH;
        public SqlConnection VSK_CA_LKS;
        public SqlConnection VSK_CA_LLK;
        public SqlConnection VSK_CA_NWM;
        public SqlConnection VSK_CA_SNK;
        public SqlConnection VSK_CA_EBB;
        public SqlConnection VSK_CA_RTB;
        public SqlConnection VSK_CA_STP;
        // Open Branch New //
        //public SqlConnection ???_DATA;
        // End Branch New //

        private void Connection()
        {
            VSK_CA = new SqlConnection(ConfigurationManager.ConnectionStrings["VSK_CA_187"].ToString());
            VSK_CA_VSK = new SqlConnection(ConfigurationManager.ConnectionStrings["VSK_CA_VSK"].ToString());
            VSK_CA_VSF = new SqlConnection(ConfigurationManager.ConnectionStrings["VSK_CA_VSF"].ToString());
            VSK_CA_KLH = new SqlConnection(ConfigurationManager.ConnectionStrings["VSK_CA_KLH"].ToString());
            VSK_CA_LKS = new SqlConnection(ConfigurationManager.ConnectionStrings["VSK_CA_LKS"].ToString());
            VSK_CA_LLK = new SqlConnection(ConfigurationManager.ConnectionStrings["VSK_CA_LLK"].ToString());
            VSK_CA_NWM = new SqlConnection(ConfigurationManager.ConnectionStrings["VSK_CA_NWM"].ToString());
            VSK_CA_SNK = new SqlConnection(ConfigurationManager.ConnectionStrings["VSK_CA_SNK"].ToString());
            VSK_CA_EBB = new SqlConnection(ConfigurationManager.ConnectionStrings["VSK_CA_EBB"].ToString());
            VSK_CA_RTB = new SqlConnection(ConfigurationManager.ConnectionStrings["VSK_CA_RTB"].ToString());
            VSK_CA_STP = new SqlConnection(ConfigurationManager.ConnectionStrings["VSK_CA_STP"].ToString());
            // Open Branch New //
            // ???_DATA = new SqlConnection(ConfigurationManager.ConnectionStrings["???_DATA"].ToString());
            // End Branch New //
        }
        //-------------------End Connection_SQL ------------------------//
        #endregion
        public List<SlipAllModel> Slip_List(SlipAllModel SlipAllModel)
        {
            try
            {
                string trndate_start = SlipAllModel.slip_datetime_start == DateTime.MinValue ? null : SlipAllModel.slip_datetime_start.ToString("yyyy-MM-dd HH:mm");
                string trndate_end = SlipAllModel.slip_datetime_end == DateTime.MinValue ? null : SlipAllModel.slip_datetime_end.ToString("yyyy-MM-dd HH:mm");

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@slip_cuscode", SlipAllModel.slip_cuscode);
                //objParam.Add("@slip_datetime_start", SlipAllModel.slip_datetime_start);
                //objParam.Add("@slip_datetime_end", SlipAllModel.slip_datetime_end);
                objParam.Add("@slip_jobdate_start", SlipAllModel.slip_jobdate_start);
                objParam.Add("@slip_jobdate_end", SlipAllModel.slip_jobdate_end);
                objParam.Add("@slip_refno", SlipAllModel.slip_refno);
                objParam.Add("@slip_bank", SlipAllModel.slip_bank);
                objParam.Add("@created_by", SlipAllModel.created_by);
                objParam.Add("@slip_bill", SlipAllModel.slip_bill);
                objParam.Add("@slip_total", SlipAllModel.slip_total);
                objParam.Add("@branch", SlipAllModel.branch);

                Connection();
                VSK_CA.Open();

                List<SlipAllModel> SlipList = SqlMapper.Query<SlipAllModel>(VSK_CA, "SP_CA_SLIP_LIST", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();

                VSK_CA.Close();
                return SlipList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public List<SlipModel> Slip_Create(SlipModel SlipModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@slip_refno", SlipModel.slip_refno);
                objParam.Add("@slip_datetime", SlipModel.slip_datetime);
                objParam.Add("@slip_total", SlipModel.slip_total);
                objParam.Add("@slip_bank", SlipModel.slip_bank);
                objParam.Add("@branch", SlipModel.branch);
                objParam.Add("@slip_cusname", SlipModel.slip_cusname);
                objParam.Add("@created_by", SlipModel.created_by);

                Connection();
                VSK_CA.Open();

                List<SlipModel> SlipList = SqlMapper.Query<SlipModel>(VSK_CA, "SP_CA_SLIP_CREATE", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();

                VSK_CA.Close();
                return SlipList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public List<SlipModel> Slip_Update(SlipModel SlipModel)
        {
            try
            {
                // string trndate_start = SlipModel.slip_jobdate == DateTime.MinValue ? null : SlipModel.slip_jobdate.ToString("yyyy-MM-dd HH:mm");

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@slip_jobno", SlipModel.slip_jobno);
                objParam.Add("@slip_cuscode", SlipModel.slip_cuscode);
                objParam.Add("@slip_jobdate", SlipModel.slip_jobdate);
                objParam.Add("@updated_by", SlipModel.updated_by);

                Connection();
                VSK_CA.Open();

                List<SlipModel> SlipList = SqlMapper.Query<SlipModel>(VSK_CA, "SP_CA_SLIP_UPDATE", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();

                VSK_CA.Close();
                return SlipList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public List<SlipBillModel> Slip_Delete(SlipBillModel SlipBillModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@ref_id", SlipBillModel.ref_id);
                objParam.Add("@trans_id", SlipBillModel.trans_id);
                objParam.Add("@updated_by", SlipBillModel.updated_by);

                Connection();
                VSK_CA.Open();

                List<SlipBillModel> SlipList = SqlMapper.Query<SlipBillModel>(VSK_CA, "SP_CA_SLIP_DELETE", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();

                VSK_CA.Close();
                return SlipList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public List<SlipImageModel> Slip_Upload(SlipImageModel SlipImageModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@ref_id", SlipImageModel.ref_id);
                objParam.Add("@image_name", SlipImageModel.image_name);
                objParam.Add("@created_by", SlipImageModel.created_by);
                objParam.Add("@job_no", SlipImageModel.job_no);

                Connection();
                VSK_CA.Open();

                List<SlipImageModel> SlipList = SqlMapper.Query<SlipImageModel>(VSK_CA, "SP_CA_SLIP_UPLOAD", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();

                VSK_CA.Close();
                return SlipList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public List<SlipAllModel> Slip_Detail(SlipAllModel SlipAllModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@slip_jobno", SlipAllModel.slip_jobno);

                Connection();
                VSK_CA.Open();

                List<SlipAllModel> SlipList = SqlMapper.Query<SlipAllModel>(VSK_CA, "SP_CA_SLIP_DETAIL", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();

                VSK_CA.Close();
                return SlipList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public List<SlipBillModel> Slip_Bill_Create(List<SlipBillModel> SlipBillItem, SlipBillModel SlipBillModel)
        {
            try
            {

                List<SlipBillModel> SlipList;

                DynamicParameters objParam = new DynamicParameters();

                foreach (var SlipBillData in SlipBillItem)
                {

                    objParam.Add("@ref_id", SlipBillModel.ref_id);
                    objParam.Add("@bill_no", SlipBillModel.bill_no);
                    objParam.Add("@branch", SlipBillModel.branch);
                    objParam.Add("@created_by", SlipBillModel.created_by);

                    objParam.Add("@bill_invname", SlipBillData.invname);
                    objParam.Add("@bill_invtotal", SlipBillData.invsumtt);
                    objParam.Add("@bill_invpay", SlipBillData.invpay);
                    objParam.Add("@bill_invdate", SlipBillData.invdate);
                    objParam.Add("@bill_userid", SlipBillData.invuserid);
                    objParam.Add("@bill_invcode", SlipBillData.invcode);
                    objParam.Add("@bill_invpkuser", SlipBillData.invpkuser);
                    // objParam.Add("@branch", SlipBillData.branch);
                    Connection();

                }

                VSK_CA.Open();
                SlipList = SqlMapper.Query<SlipBillModel>(VSK_CA, "SP_CA_SLIP_BILL_CREATE", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();
                VSK_CA.Close();
                return SlipList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public List<SlipBillModel> Slip_Bill_Get(SlipBillModel SlipBillModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@bill_no", SlipBillModel.bill_no);
                objParam.Add("@branch", SlipBillModel.branch);

                Connection();

                List<SlipBillModel> SlipList;

                if (SlipBillModel.branch == "VSK" || SlipBillModel.branch == "VSM")
                {
                    VSK_CA_VSK.Open();
                    SlipList = SqlMapper.Query<SlipBillModel>(VSK_CA_VSK, "SP_CA_SLIP_BILL_GET", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();
                    VSK_CA_VSK.Close();
                }
                else if (SlipBillModel.branch == "VSF")
                {
                    VSK_CA_VSF.Open();
                    SlipList = SqlMapper.Query<SlipBillModel>(VSK_CA_VSF, "SP_CA_SLIP_BILL_GET", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();
                    VSK_CA_VSF.Close();
                }
                else if (SlipBillModel.branch == "KLH")
                {
                    VSK_CA_KLH.Open();
                    SlipList = SqlMapper.Query<SlipBillModel>(VSK_CA_KLH, "SP_CA_SLIP_BILL_GET", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();
                    VSK_CA_KLH.Close();
                }
                else if (SlipBillModel.branch == "LKS" || SlipBillModel.branch == "KSW")
                {
                    VSK_CA_LKS.Open();
                    SlipList = SqlMapper.Query<SlipBillModel>(VSK_CA_LKS, "SP_CA_SLIP_BILL_GET", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();
                    VSK_CA_LKS.Close();
                }
                else if (SlipBillModel.branch == "LLK")
                {
                    VSK_CA_LLK.Open();
                    SlipList = SqlMapper.Query<SlipBillModel>(VSK_CA_LLK, "SP_CA_SLIP_BILL_GET", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();
                    VSK_CA_LLK.Close();
                }
                else if (SlipBillModel.branch == "NWM")
                {
                    VSK_CA_NWM.Open();
                    SlipList = SqlMapper.Query<SlipBillModel>(VSK_CA_NWM, "SP_CA_SLIP_BILL_GET", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();
                    VSK_CA_NWM.Close();
                }
                else if (SlipBillModel.branch == "SNK")
                {
                    VSK_CA_SNK.Open();
                    SlipList = SqlMapper.Query<SlipBillModel>(VSK_CA_SNK, "SP_CA_SLIP_BILL_GET", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();
                    VSK_CA_SNK.Close();
                }
                else if (SlipBillModel.branch == "EBB")
                {
                    VSK_CA_EBB.Open();
                    SlipList = SqlMapper.Query<SlipBillModel>(VSK_CA_EBB, "SP_CA_SLIP_BILL_GET", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();
                    VSK_CA_EBB.Close();
                }
                else if (SlipBillModel.branch == "RTB")
                {
                    VSK_CA_RTB.Open();
                    SlipList = SqlMapper.Query<SlipBillModel>(VSK_CA_RTB, "SP_CA_SLIP_BILL_GET", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();
                    VSK_CA_RTB.Close();
                }
                else if (SlipBillModel.branch == "STP")
                {
                    VSK_CA_STP.Open();
                    SlipList = SqlMapper.Query<SlipBillModel>(VSK_CA_STP, "SP_CA_SLIP_BILL_GET", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();
                    VSK_CA_STP.Close();
                }
                else
                {
                    VSK_CA.Open();
                    SlipList = SqlMapper.Query<SlipBillModel>(VSK_CA, "SP_CA_SLIP_BILL_GET", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();
                    VSK_CA.Close();
                }


                return SlipList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public List<SlipBillModel> Slip_Bill_List(SlipBillModel SlipBillModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@ref_id", SlipBillModel.ref_id);

                Connection();
                VSK_CA.Open();

                List<SlipBillModel> SlipList = SqlMapper.Query<SlipBillModel>(VSK_CA, "SP_CA_SLIP_BILL_LIST", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();

                VSK_CA.Close();
                return SlipList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public List<SlipBillModel> Slip_Bill_Delete(SlipBillModel SlipBillModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@ref_id", SlipBillModel.ref_id);
                objParam.Add("@trans_id", SlipBillModel.trans_id);
                objParam.Add("@updated_by", SlipBillModel.updated_by);

                Connection();
                VSK_CA.Open();

                List<SlipBillModel> SlipList = SqlMapper.Query<SlipBillModel>(VSK_CA, "SP_CA_SLIP_BILL_DELETE", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();

                VSK_CA.Close();
                return SlipList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public List<Master_Model> Slip_Master(Master_Model Master_Model)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@mode", Master_Model.mode);
                objParam.Add("@keywords", Master_Model.keywords);
                objParam.Add("@keywords1", Master_Model.keywords1);
                objParam.Add("@keywords2", Master_Model.keywords2);
                objParam.Add("@keywords3", Master_Model.keywords3);

                Connection();
                VSK_CA.Open();

                List<Master_Model> SlipList = SqlMapper.Query<Master_Model>(VSK_CA, "SP_CA_SLIP_MASTER", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();

                VSK_CA.Close();
                return SlipList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }


        public List<SlipBillModel> BILL_BRANCH_GET(SlipBillModel SlipBillModel)
        {
            try
            {
                Connection();

                List<SlipBillModel> _ResponseData;

                string SQLQuery = "";
                string str_number = SlipBillModel.bill_no.Substring(0, 2);

                SQLQuery = "DECLARE @temp_salefile TABLE ( " +
                " invnumber VARCHAR(50) " +
                " ,invpo VARCHAR(50) " +
                " ,invcode VARCHAR(50) " +
                " ,invname VARCHAR(180) " +
                " ,invdate DATE " +
                " ,invsumtt DECIMAL(10,2) " +
                " ,invpay VARCHAR(50) " +
                " ,invuserid VARCHAR(50) " +
                " ,invpaych DECIMAL(10,2) " +
                " ,invpaytr DECIMAL(10,2) " +
                " ,invpaycr DECIMAL(10,2) " +
                " ,invpayoth DECIMAL(10,2) " +
                " ,invtoption INT " +
                " ,invdue INT " +
                " ,invtype VARCHAR(50) " +
                " ,invpkuser VARCHAR(50) " +
                " ,invrdeleted INT " +
                " ) ";

                SQLQuery += " INSERT INTO @temp_salefile " +
                // salefile STRAT
                " SELECT " +
                " RTRIM(f.number) AS invnumber " + ",RTRIM(f.invpo) AS invpo " + ",RTRIM(f.invcode) AS invcode " +
                ",RTRIM(f.invname) AS invname " + ",f.invdate AS invdate " + ",f.invsumtt AS invsumtt " +
                ",CASE  " +
                " WHEN f.paycash > 0 THEN 'paycash' " +
                " WHEN f.paytran > 0 THEN 'paytran' " +
                " WHEN f.paycard > 0 THEN 'paycard' " +
                " WHEN f.payoth > 0 THEN 'payoth' " +
                " ELSE 'NULL' " +
                " END AS invpay  " +
                ",RTRIM(f.userid) AS invuserid " + ",f.paycash AS invpaych " + ",f.paytran AS invpaytr " + ",f.paycard AS invpaycr " +
                ",f.payoth AS invpayoth " + ",0 AS invtoption " + ",f.invdue AS invdue " +
                ",CASE " +
                " WHEN f.ckcash = 1 THEN 'CH' " +
                " WHEN f.cktran = 1 THEN 'TR' " +
                " WHEN f.ckcard = 1 THEN 'CR' " +
                " ELSE 'OTHER' " +
                " END AS invtype " +
                ",RTRIM(f.pkuser) AS invpkuser " + ",f.rdeleted AS invrdeleted " +
                "FROM dbo.salefile f " +
                "WHERE f.rdeleted = 0 " +
                "AND RTRIM(f.number) = '" + SlipBillModel.bill_no + "'  " +
                // salefile END
                " UNION ALL " +
                // rdfile STRAT
                " SELECT " +
                " RTRIM(f.number) AS invnumber " + ",RTRIM(f.invpo) AS invpo " + ",RTRIM(f.invcode) AS invcode " +
                ",RTRIM(f.invname) AS invname " + ",f.invdate AS invdate " + ",f.invsumtt AS invsumtt " +
                ",CASE  " +
                " WHEN f.paycash > 0 THEN 'paycash' " +
                " WHEN f.paytran > 0 THEN 'paytran' " +
                " WHEN f.paycard > 0 THEN 'paycard' " +
                " WHEN f.payoth > 0 THEN 'payoth' " +
                " ELSE 'NULL' " +
                " END AS invpay  " +
                ",RTRIM(f.userid) AS invuserid " + ",f.paycash AS invpaych " + ",f.paytran AS invpaytr " + ",f.paycard AS invpaycr " +
                ",0 AS invpayoth " + ",'' AS invtoption " + ",0 AS invdue " +
                ",CASE " +
                " WHEN f.ckcash = 1 THEN 'CH' " +
                " WHEN f.cktran = 1 THEN 'TR' " +
                " WHEN f.ckcard = 1 THEN 'CR' " +
                " ELSE 'OTHER' " +
                " END AS invtype " +
                ",RTRIM('') AS invpkuser " + ",f.rdeleted AS invrdeleted " +
                "FROM dbo.rdfile f " +
                "WHERE f.rdeleted = 0 " +
                "AND RTRIM(f.number) = '" + SlipBillModel.bill_no + "'  " +
                // rdfile END
                " UNION ALL " +
                // rebill STRAT
                " SELECT " +
                " RTRIM(f.keyref) AS invnumber " + ",RTRIM('') AS invpo " + ",RTRIM(f.recode) AS invcode " +
                ",RTRIM(f.biname) AS invname " + ",f.cmpdate AS invdate " + ",f.cmpqty AS invsumtt " +
                ",CASE  " +
                " WHEN f.cmpcash > 0 THEN 'paycash' " +
                " WHEN f.cmptrn > 0 THEN 'paytran' " +
                " WHEN f.cmpchq > 0 THEN 'paycard' " +
                " ELSE 'NULL' " +
                " END AS invpay  " +
                ",RTRIM(f.userid) AS invuserid " + ",0 AS invpaych " + ",0 AS invpaytr " + ",0 AS invpaycr " +
                ",0 AS invpayoth " + ",'' AS invtoption " + ",0 AS invdue " +
                ",'' AS invtype " +
                ",RTRIM('') AS invpkuser " + ",0 AS invrdeleted " +
                "FROM dbo.rebill f " +
                "WHERE RTRIM(f.keyref) = '" + SlipBillModel.bill_no + "'  " +
                // rebill END
                " UNION ALL " +
                // retfile STRAT
                " SELECT " +
                " RTRIM(f.number) AS invnumber " + ",RTRIM(f.invref) AS invpo " + ",RTRIM(f.invcode) AS invcode " +
                ",RTRIM(f.invname) AS invname " + ",f.invdate AS invdate " + ",f.invsumtt AS invsumtt " +
                ",'NULL' AS invpay  " +
                ",RTRIM(f.userid) AS invuserid " + ",0 AS invpaych " + ",0 AS invpaytr " + ",0 AS invpaycr " +
                ",0 AS invpayoth " + ",'' AS invtoption " + ",f.invdue AS invdue " +
                ",'OTHER' AS invtype " +
                ",RTRIM(f.PKuser_id) AS invpkuser " + ",f.rdeleted AS invrdeleted " +
                "FROM dbo.retfile f " +
                "WHERE f.rdeleted = 0 " +
                "AND RTRIM(f.number) = '" + SlipBillModel.bill_no + "'  ";
                // retfile END
                SQLQuery += " SELECT * FROM @temp_salefile";


                if (SlipBillModel.branch == "VSK" || SlipBillModel.branch == "VSM")
                {
                    VSK_CA_VSK.Open();
                    _ResponseData = VSK_CA_VSK.Query<SlipBillModel>(SQLQuery).ToList();
                    VSK_CA_VSK.Close();
                }
                else if (SlipBillModel.branch == "VSF")
                {
                    VSK_CA_VSF.Open();
                    _ResponseData = VSK_CA_VSF.Query<SlipBillModel>(SQLQuery).ToList();
                    VSK_CA_VSF.Close();
                }
                else if (SlipBillModel.branch == "KLH")
                {
                    VSK_CA_KLH.Open();
                    _ResponseData = VSK_CA_KLH.Query<SlipBillModel>(SQLQuery).ToList();
                    VSK_CA_KLH.Close();
                }
                //else if (branch == "LKS" || branch == "KSW")
                //{
                //    VSK_CA_LKS.Open();
                //    _ResponseData = VSK_CA_LKS.Query<SlipBillModel>(SQLQuery).ToList();
                //    VSK_CA_LKS.Close();
                //}
                else if (SlipBillModel.branch == "LLK")
                {
                    VSK_CA_LLK.Open();
                    _ResponseData = VSK_CA_LLK.Query<SlipBillModel>(SQLQuery).ToList();
                    VSK_CA_LLK.Close();
                }
                else if (SlipBillModel.branch == "NWM")
                {
                    VSK_CA_NWM.Open();
                    _ResponseData = VSK_CA_NWM.Query<SlipBillModel>(SQLQuery).ToList();
                    VSK_CA_NWM.Close();
                }
                else if (SlipBillModel.branch == "SNK")
                {
                    VSK_CA_SNK.Open();
                    _ResponseData = VSK_CA_SNK.Query<SlipBillModel>(SQLQuery).ToList();
                    VSK_CA_SNK.Close();
                }
                else if (SlipBillModel.branch == "EBB")
                {
                    VSK_CA_EBB.Open();
                    _ResponseData = VSK_CA_EBB.Query<SlipBillModel>(SQLQuery).ToList();
                    VSK_CA_EBB.Close();
                }
                else if (SlipBillModel.branch == "RTB")
                {
                    VSK_CA_RTB.Open();
                    _ResponseData = VSK_CA_RTB.Query<SlipBillModel>(SQLQuery).ToList();
                    VSK_CA_RTB.Close();
                }
                else if (SlipBillModel.branch == "STP")
                {
                    VSK_CA_STP.Open();
                    _ResponseData = VSK_CA_STP.Query<SlipBillModel>(SQLQuery).ToList();
                    VSK_CA_STP.Close();
                }
                else if (SlipBillModel.branch == "LKS" || SlipBillModel.branch == "KSW")
                {
                    VSK_CA_LKS.Open();
                    _ResponseData = VSK_CA_LKS.Query<SlipBillModel>(SQLQuery).ToList();
                    VSK_CA_LKS.Close();
                }
                else
                {
                    VSK_CA_VSK.Open();
                    _ResponseData = VSK_CA_VSK.Query<SlipBillModel>(SQLQuery).ToList();
                    VSK_CA_VSK.Close();
                }

                return _ResponseData.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }


        public List<SlipBillModel> DATA_BILL_GET_V1(string bill_no, string branch)
        {
            try
            {
                Connection();

                List<SlipBillModel> _ResponseData;

                string SQLQuery = "";
                string str_number = bill_no.Substring(0, 2);


                if (branch == "VSK")
                {
                    VSK_CA_VSK.Open();

                    if (str_number == "IV")
                    {

                        SQLQuery = "DECLARE @temp_salefile TABLE ( " +
                        " invnumber VARCHAR(50) " +
                        " ,invpo VARCHAR(50) " +
                        " ,invcode VARCHAR(50) " +
                        " ,invname VARCHAR(180) " +
                        " ,invdate DATE " +
                        " ,invsumtt DECIMAL(10,2) " +
                        " ,invpay VARCHAR(50) " +
                        " ,invuserid VARCHAR(50) " +
                        " ,invpaych DECIMAL(10,2) " +
                        " ,invpaytr DECIMAL(10,2) " +
                        " ,invpaycr DECIMAL(10,2) " +
                        " ,invpayoth DECIMAL(10,2) " +
                        " ,invtoption INT " +
                        " ,invdue INT " +
                        " ,invtype VARCHAR(50) " +
                        " ,invpkuser VARCHAR(50) " +
                        " ) " +
                        " INSERT INTO @temp_salefile " +
                        " SELECT " +
                        " RTRIM(f.number) " +
                        ",RTRIM(f.invpo) " +
                        ",RTRIM(f.invcode) " +
                        ",RTRIM(f.invname) " +
                        ",f.invdate " +
                        ",f.invsumtt " +
                        ",CASE  " +
                        " WHEN f.paycash > 0 THEN 'paycash' " +
                        " WHEN f.paytran > 0 THEN 'paytran' " +
                        " WHEN f.paycard > 0 THEN 'paycard' " +
                        " WHEN f.payoth > 0 THEN 'payoth' " +
                        " ELSE 'NULL' " +
                        "END  " +
                        ",RTRIM(f.userid) " +
                        ",f.paycash " +
                        ",f.paytran " +
                        ",f.paycard " +
                        ",f.payoth " +
                        ",f.toption " +
                        ",f.invdue " +
                        ",CASE " +
                        " WHEN f.ckcash = 1 THEN 'CH' " +
                        " WHEN f.cktran = 1 THEN 'TR' " +
                        " WHEN f.ckcard = 1 THEN 'CR' " +
                        " ELSE 'OTHER' " +
                        "END AS bill_invpay " +
                        ",RTRIM(f.pkuser) " +
                        "FROM dbo.salefile f " +
                        "WHERE f.rdeleted = 0 " +
                        "AND RTRIM(f.number) = '" + bill_no + "'  " +


                    " SELECT * FROM @temp_salefile";

                    }
                    else
                    {
                        SQLQuery = "";
                    }

                    _ResponseData = VSK_CA_VSK.Query<SlipBillModel>(SQLQuery).ToList();
                    VSK_CA_VSK.Close();
                }
                else
                {

                    _ResponseData = VSK_CA_VSK.Query<SlipBillModel>(SQLQuery).ToList();
                    VSK_CA_VSK.Close();
                }

                return _ResponseData.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public List<SlipBillModel> DATA_BILL_GET_V2(string bill_no, string branch)
        {
            try
            {
                Connection();

                List<SlipBillModel> _ResponseData;

                string SQLQuery = "";
                string str_number = bill_no.Substring(0, 2);


                if (branch == "VSK")
                {
                    VSK_CA_VSK.Open();

                    if (str_number == "IV")
                    {
                        SQLQuery = "DECLARE @temp_salefile TABLE ( " +
                        " invnumber VARCHAR(50) " +
                        " ,invpo VARCHAR(50) " +
                        " ,invcode VARCHAR(50) " +
                        " ,invname VARCHAR(180) " +
                        " ,invdate DATE " +
                        " ,invsumtt DECIMAL(10,2) " +
                        " ,invpay VARCHAR(50) " +
                        " ,invuserid VARCHAR(50) " +
                        " ,invpaych DECIMAL(10,2) " +
                        " ,invpaytr DECIMAL(10,2) " +
                        " ,invpaycr DECIMAL(10,2) " +
                        " ,invpayoth DECIMAL(10,2) " +
                        " ,invtoption INT " +
                        " ,invdue INT " +
                        " ,invtype VARCHAR(50) " +
                        " ,invpkuser VARCHAR(50) " +
                        " ,invrdeleted INT " +
                        " ) " +

                        " INSERT INTO @temp_salefile " +

                        " SELECT " +
                        " RTRIM(f.number) AS invnumber " +
                        ",RTRIM(f.invpo) AS invpo " +
                        ",RTRIM(f.invcode) AS invcode " +
                        ",RTRIM(f.invname) AS invname " +
                        ",f.invdate AS invdate " +
                        ",f.invsumtt AS invsumtt " +
                        ",CASE  " +
                        " WHEN f.paycash > 0 THEN 'paycash' " +
                        " WHEN f.paytran > 0 THEN 'paytran' " +
                        " WHEN f.paycard > 0 THEN 'paycard' " +
                        " WHEN f.payoth > 0 THEN 'payoth' " +
                        " ELSE 'NULL' " +
                        " END AS invpay  " +
                        ",RTRIM(f.userid) AS invuserid " +
                        ",f.paycash AS invpaych " +
                        ",f.paytran AS invpaytr " +
                        ",f.paycard AS invpaycr " +
                        ",f.payoth AS invpayoth " +
                        ",f.toption AS invtoption " +
                        ",f.invdue AS invdue " +
                        ",CASE " +
                        " WHEN f.ckcash = 1 THEN 'CH' " +
                        " WHEN f.cktran = 1 THEN 'TR' " +
                        " WHEN f.ckcard = 1 THEN 'CR' " +
                        " ELSE 'OTHER' " +
                        " END AS invtype " +
                        ",RTRIM(f.pkuser) AS invpkuser " +
                        ",f.rdeleted AS invrdeleted " +
                        "FROM dbo.salefile f " +
                        "WHERE f.rdeleted = 0 " +
                        "AND RTRIM(f.number) = '" + bill_no + "'  " +

                        " SELECT * FROM @temp_salefile";

                    }
                    else
                    {
                        SQLQuery = "";
                    }

                    _ResponseData = VSK_CA_VSK.Query<SlipBillModel>(SQLQuery).ToList();
                    VSK_CA_VSK.Close();
                }
                else
                {

                    _ResponseData = VSK_CA_VSK.Query<SlipBillModel>(SQLQuery).ToList();
                    VSK_CA_VSK.Close();
                }

                return _ResponseData.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }


    }
}