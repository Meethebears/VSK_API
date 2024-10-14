using System.Threading.Tasks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IO;
using System.Configuration;
using System.Diagnostics;

namespace API.Controllers
{
    public class FileUploadsController : Controller
    {
        public ActionResult UploadFile(HttpPostedFileBase postedFile, string pathname)
        {
            string strFolder;
            strFolder = Server.MapPath("./");

            if (postedFile != null)
            {
                string path = ConfigurationManager.AppSettings["FileUpload"] + "\\" + pathname + "\\";
                //string path = ConfigurationManager.AppSettings["PathUpload"] + '//'+; ;

                //string path = Server.MapPath("C:/uploads/");

                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }

                DateTime serverDate = DateTime.Now;

                string currentDateString = string.Format("{0}", serverDate.ToString("ssffffff"));

                postedFile.SaveAs(path + currentDateString + '_' + Path.GetFileName(postedFile.FileName.Replace(" ", "")));

                return Json(currentDateString + '_' + Path.GetFileName(postedFile.FileName), JsonRequestBehavior.AllowGet);
            }
            else
            {

                return Json("File uploaded error.", JsonRequestBehavior.AllowGet);

            }

        }


        public ActionResult DeleteFile(HttpPostedFileBase postedFile)
        {


            string path = ConfigurationManager.AppSettings["PathUpload"] + "\\" + postedFile;

            DirectoryInfo directory = new DirectoryInfo(path);

            foreach (FileInfo file in directory.EnumerateFiles())
            {
                file.Delete();
            }

            foreach (DirectoryInfo dir in directory.EnumerateDirectories())
            {
                dir.Delete(true);
            }

            return Json("File uploaded succees." + path, JsonRequestBehavior.AllowGet);

            //FileInfo file = new FileInfo(path);

            //if (file.Exists)
            //{


            //    file.Delete();

            //    return Json("File uploaded succees.", JsonRequestBehavior.AllowGet);
            //}

            //else
            //{

            //    return Json("File uploaded error." + path, JsonRequestBehavior.AllowGet);

            //}


        }

    }
}
