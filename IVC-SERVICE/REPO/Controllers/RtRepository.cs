﻿using System;
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
    public class RtRepository
    {
        private string temp_id;

        #region Connection_SQL Server
        //-------------------Start Connection_SQL ------------------------//

        public SqlConnection mscon;

        private void Connection()
        {
            string msconstr = ConfigurationManager.ConnectionStrings["VSK_IVC_187"].ToString();
            mscon = new SqlConnection(msconstr);
        }

        //-------------------End Connection_SQL ------------------------//
        #endregion


        #region Return_Create
        public List<ReturnModel> Return_Create(ReturnModel ReturnModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@temp_id", ReturnModel.temp_id);
                objParam.Add("@ref_id", ReturnModel.ref_id);
                //objParam.Add("@return_no", ReturnModel.return_no);
                objParam.Add("@rtfile_start_branch", ReturnModel.rtfile_start_branch);
                objParam.Add("@rtfile_end_branch", ReturnModel.rtfile_end_branch);
                objParam.Add("@mode", ReturnModel.mode);
                objParam.Add("@created_by", ReturnModel.created_by);
                objParam.Add("@rtfile_remark", ReturnModel.rtfile_remark);

                Connection();
                mscon.Open();
                List<ReturnModel> Rt = SqlMapper.Query<ReturnModel>(mscon, "SP_Return_Create", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();

                mscon.Close();
                return Rt.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Rt_Create_Tran
        public List<ReturnModel> Rt_Create_Tran(List<ReturnModel> ReturnModel)
        {
            try
            {
                string SQLQuery;
                int i = 1;
                int item_length = ReturnModel.Count;


                Connection();
                mscon.Open();

                foreach (var RtData in ReturnModel)
                {
                    temp_id = RtData.temp_id;

                    DynamicParameters objParam = new DynamicParameters();

                    objParam.Add("@mode", RtData.mode);
                    objParam.Add("@temp_id", RtData.temp_id);
                    objParam.Add("@ref_id", RtData.ref_id);
                    objParam.Add("@return_no", RtData.return_no);
                    objParam.Add("@rttra_item_code", RtData.rttra_item_code);
                    objParam.Add("@rttra_item_name", RtData.rttra_item_name);
                    objParam.Add("@rttra_uom", RtData.rttra_uom);
                    objParam.Add("@rttra_qty", RtData.rttra_qty);
                    objParam.Add("@rttra_price", RtData.rttra_price);
                    objParam.Add("@rttra_location", RtData.rttra_location);
                    objParam.Add("@rttra_zone", RtData.rttra_zone);
                    objParam.Add("@rttra_branch", RtData.rttra_branch);
                    objParam.Add("@item_count", i);
                    objParam.Add("@item_length", item_length);

                    objParam.Add("@created_by", RtData.created_by);

                    i++;

                    mscon.Execute("SP_Return_Create_Tarn", objParam, commandTimeout: 600, commandType: CommandType.StoredProcedure);

                }
                SQLQuery = "SELECT * , " +
                            "RTRIM(stmas.gbarcode) AS gbarcode ,  " +
                            //"(SELECT TOP 1 stmas.gbarcode FROM [SRVHQDB02].vorswin.dbo.stmas stmas WHERE rttl.rttra_item_code = stmas.code) AS gbarcode ,  " + //20230917
                            //"(SELECT TOP 1 stmas.gbarcode FROM dbo.stmas stmas WHERE rttl.rttra_item_code = stmas.code) AS gbarcode ,  " +
                            "CASE " +
                            "WHEN rttl.record_status = 1 THEN 'OK' " +
                            "WHEN rttl.record_status = 2 THEN 'ไม่พบข้อมูลรหัสสินค้า' " +
                            "WHEN rttl.record_status = 3 THEN 'สาขาต้นทางไม่ตรงกัน' " +
                            "WHEN rttl.record_status = 4 THEN 'ไม่พบจำนวนสินค้า' " +
                            "ELSE 'ERROR' END AS 'text_status'" +
                            "FROM returntra_log rttl " +
                            "LEFT JOIN  VSK_Data.dbo.temp_stmas stmas ON rttl.rttra_item_code = stmas.code " +
                            "WHERE rttl.rttra_temp_id = '" + temp_id + "' " +
                            "AND rttl.event_status = 'PENDING' " +
                            //"ORDER BY record_status DESC";
                            "ORDER BY rttra_item_code ASC";

                //List <ReturnModel> Rt = SqlMapper.Query<ReturnModel>(mscon, "SP_Return_Create_Tarn", commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();
                List<ReturnModel> Rt = mscon.Query<ReturnModel>(SQLQuery).ToList();
                mscon.Close();

                return Rt.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Return_Get
        public List<ReturnModel> Return_Get(ReturnModel ReturnModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                //string trndate_start = ReturnModel.trndate_start == DateTime.MinValue ? null : ReturnModel.trndate_start.ToString("yyyy-MM-dd HH:mm");
                //string trndate_end = ReturnModel.trndate_end == DateTime.MinValue ? null : ReturnModel.trndate_end.ToString("yyyy-MM-dd HH:mm");


                objParam.Add("@mode", ReturnModel.mode);
                objParam.Add("@return_no", ReturnModel.return_no);
                objParam.Add("@branch", ReturnModel.branch);
                objParam.Add("@created_by", ReturnModel.created_by);
                objParam.Add("@temp_id", ReturnModel.temp_id);
                objParam.Add("@trndate_start", ReturnModel.trndate_start);
                objParam.Add("@trndate_end", ReturnModel.trndate_end);

                Connection();
                mscon.Open();
                List<ReturnModel> Rt = SqlMapper.Query<ReturnModel>(mscon, "SP_Return_Get", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();

                mscon.Close();
                return Rt.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Return_Update
        public List<ReturnModel> Return_Update(ReturnModel ReturnModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@temp_id", ReturnModel.temp_id);
                objParam.Add("@updated_by", ReturnModel.updated_by);

                Connection();
                mscon.Open();
                List<ReturnModel> Rt = SqlMapper.Query<ReturnModel>(mscon, "SP_Return_Update", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();

                mscon.Close();
                return Rt.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

    }
}