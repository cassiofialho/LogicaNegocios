using Microsoft.AspNetCore.Mvc;

namespace EnviaArquivos.Controllers
{
    public class UploadController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult UploadFile()
        {
            return View();
        }

        //[HttpPost]
        //public IActionResult UploadFile(HttpPostFileBase file)
        //{
        //    try
        //    {
        //        if (file.ContentLenght > 0)
        //        {

        //        }
        //        return View();
        //    }
        //    catch (Exception e)
        //    {

        //    }
        //}
    }
}
