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
    public class MasterDataRepository
    {

        #region Connection_SQL Server
        //-------------------Start Connection_SQL ------------------------//

        public SqlConnection VSK_DATA;

        private void Connection()
        {

            VSK_DATA = new SqlConnection(ConfigurationManager.ConnectionStrings["VSK_DATA"].ToString());

        }

        //-------------------End Connection_SQL ------------------------//
        #endregion

        #region MASTERDATA_GET
        public List<MasterDataModel> MASTERDATA_GET(MasterDataModel MasterDataModel)
        {
            try
            {
                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@mode", MasterDataModel.mode);
                objParam.Add("@keywords", MasterDataModel.keywords);
                objParam.Add("@p1", MasterDataModel.p1);
                objParam.Add("@p2", MasterDataModel.p2);
                objParam.Add("@p3", MasterDataModel.p3);
                objParam.Add("@p4", MasterDataModel.p4);
                objParam.Add("@p5", MasterDataModel.p5);

                Connection();
                VSK_DATA.Open();
                List<MasterDataModel> master_date = SqlMapper.Query<MasterDataModel>(VSK_DATA, "SP_MASTER_DATA", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();
                VSK_DATA.Close();
                return master_date.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

    }
}