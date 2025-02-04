﻿using REPO.Models;
using REPO.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Text;
using System.IO;
using System.Globalization;
using System.Threading;
using System.Data;
using System.ComponentModel;
using OfficeOpenXml;
using System.Collections;
using System.Web.Http;

namespace API.Controllers
{
    public class CnExportController : Controller
    {


        private static decimal GetExcelDecimalValueForDate(DateTime date)
        {
            DateTime start = new DateTime(1900, 1, 1);
            TimeSpan diff = date - start;
            return diff.Days + 2;
        }

        public FileStreamResult Cn_Job_Detail_Export(CnModel CnModel)
        {

            CultureInfo cultureinfo = new CultureInfo("th-TH");

            CnRepository CnRepository = new CnRepository();
            List<CnModel> Cn_Job_Detail_Export = CnRepository.Cn_Pre_Job_Get(CnModel);

            StringBuilder sb = new StringBuilder();
            MemoryStream memStream;
            int startColum = 1;
            //int row_no = 1;
            using (var package = new ExcelPackage())
            {
                var worksheet = package.Workbook.Worksheets.Add("Cn_Job_Detail_Export");
                worksheet.Cells[startColum, 1].Value = "DATE";
                worksheet.Cells[startColum, 2].Value = "STATUS";
                worksheet.Cells[startColum, 3].Value = "ASSIGE";
                worksheet.Cells[startColum, 4].Value = "NO";
                worksheet.Cells[startColum, 5].Value = "ITEM NAME";
                worksheet.Cells[startColum, 6].Value = "QTY";
                worksheet.Cells[startColum, 7].Value = "NOTICE TYPE";
                worksheet.Cells[startColum, 8].Value = "CAUSE";
                worksheet.Cells[startColum, 9].Value = "REMARK";

                foreach (CnModel Cn_Job_Detail_List in Cn_Job_Detail_Export)
                {
                    startColum++;
                    worksheet.Cells[startColum, 1].Value = Cn_Job_Detail_List.created_date;
                    worksheet.Cells[startColum, 2].Value = Cn_Job_Detail_List.cn_pre_job_status;
                    worksheet.Cells[startColum, 3].Value = Cn_Job_Detail_List.cn_pre_job_assige;

                    worksheet.Cells[startColum, 4].Value = Cn_Job_Detail_List.salefile_number;
                    worksheet.Cells[startColum, 5].Value = Cn_Job_Detail_List.saletra_item_name;
                    worksheet.Cells[startColum, 6].Value = Cn_Job_Detail_List.cn_pre_job_qty;

                    if (Cn_Job_Detail_List.cn_pre_job_type == "1")
                    {
                        worksheet.Cells[startColum, 7].Value = "รับคืน";

                    }
                    else if (Cn_Job_Detail_List.cn_pre_job_type == "2" )
                    {
                        worksheet.Cells[startColum, 7].Value = "หน้างาน";
                    }
                    else
                    {
                        worksheet.Cells[startColum, 7].Value = "-";
                    }


                    if (Cn_Job_Detail_List.cn_pre_job_comment == "EXT_CUS_01")
                    {
                        worksheet.Cells[startColum, 8].Value = "ลูกค้ายกเลิก สั่งซ้ำ ไม่ได้ใช้งาน";
                    }
                    else if (Cn_Job_Detail_List.cn_pre_job_comment == "EXT_CUS_02")
                    {
                        worksheet.Cells[startColum, 8].Value = "ลูกค้าสั่งผิดรุ่น เปลี่ยนยี่ห้อใหม่ ไม่เหมือนตัวอย่าง";
                    }
                    else if (Cn_Job_Detail_List.cn_pre_job_comment == "EXT_CUS_03")
                    {
                        worksheet.Cells[startColum, 8].Value = "ลูกค้าเปลี่ยนเอาแท้/เทียบ เปลี่ยนเอาแบบชุด";
                    }
                    else if (Cn_Job_Detail_List.cn_pre_job_comment == "EXT_CUS_04")
                    {
                        worksheet.Cells[startColum, 8].Value = "รับคืนแบตเก่า";
                    }
                    else if (Cn_Job_Detail_List.cn_pre_job_comment == "INT_SAL_01")
                    {
                        worksheet.Cells[startColum, 8].Value = "เซลล์จัดผิด ผิดรุ่น ผิดตำแหน่ง จัดเกิน จัดซ้ำ จัดไปเผื่อ";
                    }
                    else if (Cn_Job_Detail_List.cn_pre_job_comment == "INT_SAL_02")
                    {
                        worksheet.Cells[startColum, 8].Value = "คืนสินค้าตัวอย่าง";
                    }
                    else if (Cn_Job_Detail_List.cn_pre_job_comment == "INT_SUP_01")
                    {
                        worksheet.Cells[startColum, 8].Value = "คืนซัพพลาย";
                    }
                    else if (Cn_Job_Detail_List.cn_pre_job_comment == "INT_SUP_02")
                    {
                        worksheet.Cells[startColum, 8].Value = "ชำรุด เป็นรอย เสียหาย แตกหัก รั่ว";
                    }
                    else
                    {
                        worksheet.Cells[startColum, 8].Value = "-";
                    }
                    worksheet.Cells[startColum, 9].Value = Cn_Job_Detail_List.cn_pre_job_detail_remark;

                }

                worksheet.Cells.AutoFitColumns();
                memStream = new MemoryStream(package.GetAsByteArray());

            }
            var fileName = "Job_Export_" + DateTime.Now.ToString("ddmmyyyyhhmm") + ".xlsx";

            return File(memStream, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", fileName);
        }


    }


}

