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
    public class MDTRepository : Controller
    {

        #region Connection_SQL Server
        //-------------------Start Connection_SQL ------------------------//
        public SqlConnection SPP_MDT;

        private void Connection()
        {
            SPP_MDT = new SqlConnection(ConfigurationManager.ConnectionStrings["SPP_MDT"].ToString());
        }
        //-------------------End Connection_SQL ------------------------//
        #endregion

        public List<MDTModel> INV_DAILY_GET(DateTime ORDER_DATE, string ORDER_TYPE, string BRANCH)
        {
            try
            {
                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@ORDER_DATE", ORDER_DATE);
                objParam.Add("@ORDER_TYPE", ORDER_TYPE);

                Connection();
                SPP_MDT.Open();

                List<MDTModel> INV_DAILY_LIST;

                if (BRANCH == "VSK")
                {
                    INV_DAILY_LIST = SqlMapper.Query<MDTModel>(SPP_MDT, "SP_VSK_INV_DAILY_GET", objParam, commandTimeout: 60, commandType: CommandType.StoredProcedure).ToList();
                }
                //else if (BRANCH == "")
                //{
                //    INV_DAILY_LIST = SqlMapper.Query<MDTModel>(SPP_MDT, "SP__INV_DAILY_GET", objParam, commandTimeout: 60, commandType: CommandType.StoredProcedure).ToList();
                //}
                else if (BRANCH == "VSF")
                {
                    INV_DAILY_LIST = SqlMapper.Query<MDTModel>(SPP_MDT, "SP_VSF_INV_DAILY_GET", objParam, commandTimeout: 60, commandType: CommandType.StoredProcedure).ToList();
                }
                else if (BRANCH == "KSW")
                {
                    INV_DAILY_LIST = SqlMapper.Query<MDTModel>(SPP_MDT, "SP_KSW_INV_DAILY_GET", objParam, commandTimeout: 60, commandType: CommandType.StoredProcedure).ToList();
                }
                else if (BRANCH == "KLH")
                {
                    INV_DAILY_LIST = SqlMapper.Query<MDTModel>(SPP_MDT, "SP_KLH_INV_DAILY_GET", objParam, commandTimeout: 60, commandType: CommandType.StoredProcedure).ToList();
                }
                else if (BRANCH == "LLK")
                {
                    INV_DAILY_LIST = SqlMapper.Query<MDTModel>(SPP_MDT, "SP_LLK_INV_DAILY_GET", objParam, commandTimeout: 60, commandType: CommandType.StoredProcedure).ToList();
                }
                else if (BRANCH == "NWM")
                {
                    INV_DAILY_LIST = SqlMapper.Query<MDTModel>(SPP_MDT, "SP_NWM_INV_DAILY_GET", objParam, commandTimeout: 60, commandType: CommandType.StoredProcedure).ToList();
                }
                else if (BRANCH == "SNK")
                {
                    INV_DAILY_LIST = SqlMapper.Query<MDTModel>(SPP_MDT, "SP_SNK_INV_DAILY_GET", objParam, commandTimeout: 60, commandType: CommandType.StoredProcedure).ToList();
                }
                else if (BRANCH == "EBB")
                {
                    INV_DAILY_LIST = SqlMapper.Query<MDTModel>(SPP_MDT, "SP_EBB_INV_DAILY_GET", objParam, commandTimeout: 60, commandType: CommandType.StoredProcedure).ToList();
                }
                else if (BRANCH == "RTB")
                {
                    INV_DAILY_LIST = SqlMapper.Query<MDTModel>(SPP_MDT, "SP_RTB_INV_DAILY_GET", objParam, commandTimeout: 60, commandType: CommandType.StoredProcedure).ToList();
                }
                else if (BRANCH == "STP")
                {
                    INV_DAILY_LIST = SqlMapper.Query<MDTModel>(SPP_MDT, "SP_STP_INV_DAILY_GET", objParam, commandTimeout: 60, commandType: CommandType.StoredProcedure).ToList();
                }
                else
                {
                    INV_DAILY_LIST = SqlMapper.Query<MDTModel>(SPP_MDT, "SP_VSK_INV_DAILY_GET", objParam, commandTimeout: 60, commandType: CommandType.StoredProcedure).ToList();
                }

                SPP_MDT.Close();

                return INV_DAILY_LIST.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public List<MDTModel> INV_DAILY_DRIVER(string NUMBER, string DRIVER, string BRANCH)
        {
            try
            {
                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@NUMBER", NUMBER);
                objParam.Add("@DRIVER", DRIVER);

                Connection();
                SPP_MDT.Open();

                List<MDTModel> INV_DAILY_LIST;

                if (BRANCH == "VSK")
                {
                    INV_DAILY_LIST = SqlMapper.Query<MDTModel>(SPP_MDT, "SP_VSK_INV_DAILY_DRIVER", objParam, commandTimeout: 60, commandType: CommandType.StoredProcedure).ToList();
                }
                //else if (BRANCH == "")
                //{
                //    INV_DAILY_LIST = SqlMapper.Query<MDTModel>(SPP_MDT, "SP__INV_DAILY_DRIVER", objParam, commandTimeout: 60, commandType: CommandType.StoredProcedure).ToList();
                //}
                else if (BRANCH == "VSF")
                {
                    INV_DAILY_LIST = SqlMapper.Query<MDTModel>(SPP_MDT, "SP_VSF_INV_DAILY_DRIVER", objParam, commandTimeout: 60, commandType: CommandType.StoredProcedure).ToList();
                }
                else if (BRANCH == "KSW")
                {
                    INV_DAILY_LIST = SqlMapper.Query<MDTModel>(SPP_MDT, "SP_KSW_INV_DAILY_DRIVER", objParam, commandTimeout: 60, commandType: CommandType.StoredProcedure).ToList();
                }
                else if (BRANCH == "KLH")
                {
                    INV_DAILY_LIST = SqlMapper.Query<MDTModel>(SPP_MDT, "SP_KLH_INV_DAILY_DRIVER", objParam, commandTimeout: 60, commandType: CommandType.StoredProcedure).ToList();
                }
                else if (BRANCH == "LLK")
                {
                    INV_DAILY_LIST = SqlMapper.Query<MDTModel>(SPP_MDT, "SP_LLK_INV_DAILY_DRIVER", objParam, commandTimeout: 60, commandType: CommandType.StoredProcedure).ToList();
                }
                else if (BRANCH == "NWM")
                {
                    INV_DAILY_LIST = SqlMapper.Query<MDTModel>(SPP_MDT, "SP_NWM_INV_DAILY_DRIVER", objParam, commandTimeout: 60, commandType: CommandType.StoredProcedure).ToList();
                }
                else if (BRANCH == "SNK")
                {
                    INV_DAILY_LIST = SqlMapper.Query<MDTModel>(SPP_MDT, "SP_SNK_INV_DAILY_DRIVER", objParam, commandTimeout: 60, commandType: CommandType.StoredProcedure).ToList();
                }
                else if (BRANCH == "EBB")
                {
                    INV_DAILY_LIST = SqlMapper.Query<MDTModel>(SPP_MDT, "SP_EBB_INV_DAILY_DRIVER", objParam, commandTimeout: 60, commandType: CommandType.StoredProcedure).ToList();
                }
                else if (BRANCH == "RTB")
                {
                    INV_DAILY_LIST = SqlMapper.Query<MDTModel>(SPP_MDT, "SP_RTB_INV_DAILY_DRIVER", objParam, commandTimeout: 60, commandType: CommandType.StoredProcedure).ToList();
                }
                else if (BRANCH == "STP")
                {
                    INV_DAILY_LIST = SqlMapper.Query<MDTModel>(SPP_MDT, "SP_STP_INV_DAILY_DRIVER", objParam, commandTimeout: 60, commandType: CommandType.StoredProcedure).ToList();
                }
                else
                {
                    INV_DAILY_LIST = SqlMapper.Query<MDTModel>(SPP_MDT, "SP_VSK_INV_DAILY_DRIVER", objParam, commandTimeout: 60, commandType: CommandType.StoredProcedure).ToList();
                }

                /*
                if (BRANCH == "SNK")
                {
                    INV_DAILY_LIST = SqlMapper.Query<MDTModel>(SPP_MDT, "SP_SNK_INV_DAILY_DRIVER", objParam, commandTimeout: 60, commandType: CommandType.StoredProcedure).ToList();
                }
                else if (BRANCH == "EBB")
                {
                    INV_DAILY_LIST = SqlMapper.Query<MDTModel>(SPP_MDT, "SP_EBB_INV_DAILY_DRIVER", objParam, commandTimeout: 60, commandType: CommandType.StoredProcedure).ToList();
                }
                else if (BRANCH == "RTB")
                {
                    INV_DAILY_LIST = SqlMapper.Query<MDTModel>(SPP_MDT, "SP_RTB_INV_DAILY_DRIVER", objParam, commandTimeout: 60, commandType: CommandType.StoredProcedure).ToList();
                }
                else if (BRANCH == "RTB")
                {
                    INV_DAILY_LIST = SqlMapper.Query<MDTModel>(SPP_MDT, "SP_RTB_INV_DAILY_DRIVER", objParam, commandTimeout: 60, commandType: CommandType.StoredProcedure).ToList();
                }
                else
                {
                    INV_DAILY_LIST = SqlMapper.Query<MDTModel>(SPP_MDT, "SP_VSM_INV_DAILY_DRIVER", objParam, commandTimeout: 60, commandType: CommandType.StoredProcedure).ToList();
                }
                */
                SPP_MDT.Close();

                return INV_DAILY_LIST.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

    }
}