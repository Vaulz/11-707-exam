using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using FileSharing.Context;
using FileSharing.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace FileSharing.Controllers
{
    public class FileController : Controller
    {
        ApplicationDbContext _appContext;
        IHostingEnvironment _appEnvironment;
        public FileController(ApplicationDbContext applicationDbContext, IHostingEnvironment appEnvironment)
        {
            _appContext = applicationDbContext;
            _appEnvironment = appEnvironment;
        }
        public ActionResult Upload()
        {

            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Upload(IFormFile uploadedFile, string shortDescription, string description)
        {
            if (uploadedFile != null)
            {
                // путь к папке Files
                string path = "/Files/" + uploadedFile.FileName;
                // сохраняем файл в папку Files в каталоге wwwroot
                using (var fileStream = new FileStream(_appEnvironment.WebRootPath + path, FileMode.Create))
                {
                    await uploadedFile.CopyToAsync(fileStream);
                }
                FileModel file = new FileModel { Name = uploadedFile.FileName, Path = path };
                _appContext.Files.Add(file);
                _appContext.SaveChanges();
            }

            return RedirectToAction("GetAllFiles");
        }

        public ActionResult GetAllFiles()
        {
            return View();
        }
    }
}