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

        private void Connection()
        {

            VSK_IVC = new SqlConnection(ConfigurationManager.ConnectionStrings["VSK_IVC"].ToString());

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

    }
}