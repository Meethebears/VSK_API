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
    public class MRP_ItemSetupRepository
    {

        #region Connection_SQL Server
        //-------------------Start Connection_SQL ------------------------//
        public SqlConnection VSK_MRP;

        private void Connection()
        {
            VSK_MRP = new SqlConnection(ConfigurationManager.ConnectionStrings["VSK_MRP_187"].ToString());
        }

        //-------------------End Connection_SQL ------------------------//
        #endregion

        #region MRP_Item_Setup_List
        public IList<ItemSetupModel> MRP_Item_Setup_List(ItemSetupModel ItemSetupModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@BRANCH", ItemSetupModel.BRANCH);
                objParam.Add("@Barcode", ItemSetupModel.Barcode);
                objParam.Add("@Source_Site", ItemSetupModel.Source_Site);
                objParam.Add("@Source_Site_Stock_Status", ItemSetupModel.Source_Site_Stock_Status);
                objParam.Add("@Destination_Site", ItemSetupModel.Destination_Site);
                objParam.Add("@CODE_1", ItemSetupModel.CODE_1);
                objParam.Add("@CODE_2", ItemSetupModel.CODE_2);
                objParam.Add("@CODE_3", ItemSetupModel.CODE_3);
                objParam.Add("@CODE_4", ItemSetupModel.CODE_4);

                Connection();
                VSK_MRP.Open();
               // List<ItemSetupModel> MrpList = SqlMapper.Query<ItemSetupModel>(VSK_MRP_187, "SP_MRP_GET", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();
                IList<ItemSetupModel> MrpList = VSK_MRP.Query<ItemSetupModel>("SP_MRP_GET", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();

                VSK_MRP.Close();
                return MrpList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region MRP_Item_Setup_Import
        public void MRP_Item_Setup_Import(List<MRPItemImportModel> MRPItemImportModel)
        {
            try
            {
                foreach (var MRPItemImportItem in MRPItemImportModel)
                {
                    DynamicParameters objParam = new DynamicParameters();
                    objParam.Add("@Destination_Site", MRPItemImportItem.Destination_Site);
                    objParam.Add("@Item_Code", MRPItemImportItem.Item_Code);
                    objParam.Add("@Remark", MRPItemImportItem.Remark);
                    objParam.Add("@MIN", MRPItemImportItem.MIN);
                    objParam.Add("@MAX", MRPItemImportItem.MAX);
                    objParam.Add("@Replenish_Status", MRPItemImportItem.Replenish_Status);
                    objParam.Add("@Action", MRPItemImportItem.Action);
                    objParam.Add("@created_by", MRPItemImportItem.created_by);
                    objParam.Add("@ImportFilename", MRPItemImportItem.ImportFilename);
                    objParam.Add("@ImportPathname", MRPItemImportItem.ImportPathname);

                    Connection();
                    VSK_MRP.Open();
                    SqlMapper.Query(VSK_MRP, "SP_MRP_ITEM_SETUP_IMPORT", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();
                    VSK_MRP.Close();
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion  #endregion

        #region MRP_Item_Setup_Verify
        public IList<MRPItemImportModel> MRP_Item_Setup_Verify(MRPItemImportModel MRPItemImportModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@ImportFilename", MRPItemImportModel.ImportFilename);
                objParam.Add("@created_by", MRPItemImportModel.created_by);

                Connection();
                VSK_MRP.Open();
                IList<MRPItemImportModel> MrpList = VSK_MRP.Query<MRPItemImportModel>("SP_MRP_ITEM_SETUP_VERIFY", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();
                VSK_MRP.Close();
                return MrpList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region MRP_Item_Setup_Upload
        public IList<MRPItemImportModel> MRP_Item_Setup_Upload(MRPItemImportModel MRPItemImportModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@ImportFilename", MRPItemImportModel.ImportFilename);
                objParam.Add("@created_by", MRPItemImportModel.created_by);

                Connection();
                VSK_MRP.Open();
                IList<MRPItemImportModel> MrpList = VSK_MRP.Query<MRPItemImportModel>("SP_MRP_ITEM_SETUP_UPLOAD", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();
                VSK_MRP.Close();
                return MrpList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region MRP_Item_Setup_Refresh_All
        public IList<ItemSetupModel> MRP_Item_Setup_Refresh_All(ItemSetupModel ItemSetupModel)
        {
            try
            {

                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@BRANCH", ItemSetupModel.BRANCH);

                Connection();
                VSK_MRP.Open();
                IList<ItemSetupModel> MrpList = VSK_MRP.Query<ItemSetupModel>("SP_MRP_REFRESH_ALL", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();
                VSK_MRP.Close();
                return MrpList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

    }
}