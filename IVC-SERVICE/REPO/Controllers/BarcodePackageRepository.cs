using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

using Dapper;
using REPO.Models;

namespace REPO.Controllers
{
    public class BarcodePackageRepository
    {

        #region Connection_SQL Server

        public SqlConnection VSK_IVC;

        private void Connection()
        {
            VSK_IVC = new SqlConnection(ConfigurationManager.ConnectionStrings["VSK_IVC_187"].ToString());
        }

        #endregion

        #region BARCODE_PACKAGE_FILE_CREATE
        public List<BarcodePackageFileModel> BARCODE_PACKAGE_FILE_CREATE(BarcodePackageFileModel BarcodePackageFileModel)
        {
            try
            {
                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@ref_id", BarcodePackageFileModel.ref_id);
                objParam.Add("@job_date", BarcodePackageFileModel.job_date);
                objParam.Add("@data_all", BarcodePackageFileModel.data_all);
                objParam.Add("@data_error", BarcodePackageFileModel.data_error);
                objParam.Add("@data_success", BarcodePackageFileModel.data_success);
                objParam.Add("@created_by", BarcodePackageFileModel.created_by);

                Connection();
                VSK_IVC.Open();
                List<BarcodePackageFileModel> DataList = SqlMapper.Query<BarcodePackageFileModel>(VSK_IVC, "SP_BARCODE_PACKAGE_FILE_CREATE", objParam,commandTimeout:210,commandType: CommandType.StoredProcedure).ToList();
                VSK_IVC.Close();
                return DataList.ToList();
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region BARCODE_PACKAGE_DATA_IMPORT
        public void BARCODE_PACKAGE_DATA_IMPORT(List<BarcodePackageDataModel> BarcodePackageDataModel)
        {
            try
            {
                Connection();
                VSK_IVC.Open();
                foreach (var ImportDataArrayData in BarcodePackageDataModel)
                {
                    DynamicParameters objParam = new DynamicParameters();
                    objParam.Add("ref_id", ImportDataArrayData.ref_id);
                    objParam.Add("item_no", ImportDataArrayData.item_no);
                    objParam.Add("package_code", ImportDataArrayData.package_code);
                    objParam.Add("barcode_vsk", ImportDataArrayData.barcode_vsk);
                    objParam.Add("barcode_package", ImportDataArrayData.barcode_package);
                    objParam.Add("item_note", ImportDataArrayData.item_note);
                    objParam.Add("action_type", ImportDataArrayData.action_type);
                    objParam.Add("created_by", ImportDataArrayData.created_by);
                    VSK_IVC.Execute("SP_BARCODE_PACKAGE_DATA_IMPORT", objParam, commandTimeout: 600, commandType: CommandType.StoredProcedure);
                }
                VSK_IVC.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region BARCODE_PACKAGE_VERIFY
        public List<BarcodePackageVerifyModel> BARCODE_PACKAGE_VERIFY( string ref_id)
        {
            try
            {
                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@ref_id", ref_id);

                Connection();
                VSK_IVC.Open();
                List<BarcodePackageVerifyModel> DataList = SqlMapper.Query<BarcodePackageVerifyModel>(VSK_IVC, "SP_BARCODE_PACKAGE_VERIFY", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();
                VSK_IVC.Close();
                return DataList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region BARCODE_PACKAGE_UPLOAD
        public List<BarcodePackageDataModel> BARCODE_PACKAGE_UPLOAD(BarcodePackageParamModel BarcodePackageParamModel)
        {
            try
            {
                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@ref_id", BarcodePackageParamModel.ref_id);

                Connection();
                VSK_IVC.Open();
                List<BarcodePackageDataModel> DataList = SqlMapper.Query<BarcodePackageDataModel>(VSK_IVC, "SP_BARCODE_PACKAGE_UPLOAD", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();
                VSK_IVC.Close();
                return DataList.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region BARCODE_PACKAGE_LIST
        public List<BarcodePackageListModel> BARCODE_PACKAGE_LIST(BarcodePackageSearchModel BarcodePackageSearchModel)
        {
            try
            {
                DynamicParameters objParam = new DynamicParameters();

                objParam.Add("@keywords", BarcodePackageSearchModel.keywords);
                objParam.Add("@barcode_vsk", BarcodePackageSearchModel.barcode_vsk);
                objParam.Add("@barcode_package", BarcodePackageSearchModel.barcode_package);
                objParam.Add("@package_code", BarcodePackageSearchModel.package_code);
                objParam.Add("@item_code", BarcodePackageSearchModel.item_code);
                objParam.Add("@item_name", BarcodePackageSearchModel.item_name);
                objParam.Add("@item_spcodes", BarcodePackageSearchModel.item_spcodes);

                Connection();
                VSK_IVC.Open();
                List<BarcodePackageListModel> DataList = SqlMapper.Query<BarcodePackageListModel>(VSK_IVC, "SP_BARCODE_PACKAGE_LIST", objParam, commandTimeout: 210, commandType: CommandType.StoredProcedure).ToList();
                VSK_IVC.Close();
                return DataList.ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

    }
}