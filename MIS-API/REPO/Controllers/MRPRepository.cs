using Dapper;
using REPO.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace REPO.Controllers
{
    public class MRPRepository : Controller
    {

        #region Connection_SQL Server
        //-------------------Start Connection_SQL ------------------------//
        public SqlConnection VSK_MRP;

        private void Connection()
        {
            VSK_MRP = new SqlConnection(ConfigurationManager.ConnectionStrings["VSK_MRP"].ToString());
        }
        //-------------------End Connection_SQL ------------------------//
        #endregion

        public void MRPItemImport(List<MRPItemImportModel> MRPItemImportModel)
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
                    objParam.Add("@ImportFilename", MRPItemImportItem.ImportFilename);
                    objParam.Add("@created_by", MRPItemImportItem.Created_by);

                    Connection();
                    VSK_MRP.Open();
                    SqlMapper.Query(VSK_MRP, "SP_MRP_ITEM_IMPORT", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();
                    VSK_MRP.Close();
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}