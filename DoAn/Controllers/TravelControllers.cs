using DoAn.Data;
using DoAn.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DoAn.ViewModels;
using DoAn.Image;

namespace DoAn.Controllers
{
    public class TravelControllers : Controller
    {
        private readonly ApplicationDbContext _appDbContext;
        private readonly IWebHostEnvironment _webHostEnvironment;
        public TravelControllers(ApplicationDbContext appDbContext, IWebHostEnvironment webHostEnvironment)
        {
            _appDbContext = appDbContext;
            _webHostEnvironment = webHostEnvironment;
        }
        public IActionResult Index()
        {
            var products = _appDbContext.TravelModels.Include(p => p.Status).ToList();

            return View(products);
        }
        public IActionResult Create()
        {
            TravelCreateVM productVM = new TravelCreateVM()
            {
                TravelModel = new TravelModel(),
                StatusSelectList = _appDbContext.Statuses.Select(item => new SelectListItem
                {
                    Text = item.Statuss,
                    Value = item.Id.ToString()
                }),
                TagSelectList = _appDbContext.Tags.Select(item => new SelectListItem
                {
                    Text = item.Name,
                    Value = item.Id.ToString()
                })
            };

            return View(productVM);
        }

        [HttpPost]
        public IActionResult Create(TravelCreateVM productCreateVM)
        {
            var files = HttpContext.Request.Form.Files;
            var files1 = HttpContext.Request.Form.Files;
            var files2 = HttpContext.Request.Form.Files;
            var files3 = HttpContext.Request.Form.Files;
            var files4 = HttpContext.Request.Form.Files;
            string webRootPath = _webHostEnvironment.WebRootPath;

            string upload = webRootPath + ImageDefault.ImagePath;
            string fileName = Guid.NewGuid().ToString();
            string extension = Path.GetExtension(files[0].FileName);
            string fileName1 = Guid.NewGuid().ToString();
            string extension1 = Path.GetExtension(files1[1].FileName);
            string fileName2 = Guid.NewGuid().ToString();
            string extension2 = Path.GetExtension(files2[2].FileName);
            string fileName3 = Guid.NewGuid().ToString();
            string extension3 = Path.GetExtension(files3[3].FileName);
            string fileName4 = Guid.NewGuid().ToString();
            string extension4 = Path.GetExtension(files4[4].FileName);

            using (var fileStream = new FileStream(Path.Combine(upload, fileName + extension), FileMode.Create))
            {
                files[0].CopyTo(fileStream);
            }
            using (var fileStream = new FileStream(Path.Combine(upload, fileName1 + extension1), FileMode.Create))
            {
                files1[1].CopyTo(fileStream);
            }
            using (var fileStream = new FileStream(Path.Combine(upload, fileName2 + extension2), FileMode.Create))
            {
                files2[2].CopyTo(fileStream);
            }
            using (var fileStream = new FileStream(Path.Combine(upload, fileName3 + extension3), FileMode.Create))
            {
                files3[3].CopyTo(fileStream);
            }
            using (var fileStream = new FileStream(Path.Combine(upload, fileName4 + extension4), FileMode.Create))
            {
                files4[4].CopyTo(fileStream);
            }

            productCreateVM.TravelModel.ImageUrl = fileName + extension;
            productCreateVM.TravelModel.ImageUrl1 = fileName1 + extension1;
            productCreateVM.TravelModel.ImageUrl2 = fileName2 + extension2;
            productCreateVM.TravelModel.ImageUrl3 = fileName3 + extension3;
            productCreateVM.TravelModel.ImageUrl4 = fileName4 + extension4;

            /*            foreach (var item in productCreateVM.SelectListTagIds)
                        {
                            productCreateVM.TravelModel.TravelTags.Add(new TravelTag()
                            {
                                TagId = item
                            });
                        }*/

            _appDbContext.TravelModels.Add(productCreateVM.TravelModel);

            _appDbContext.SaveChanges();

            return RedirectToAction("Index");
        }
        public IActionResult Edit(int? id)
        {
            var product = _appDbContext.TravelModels.Find(id);
            var tags = _appDbContext.Tags.ToList();
            var selectList = new List<SelectListItem>();
            TravelCreateVM productVM = new TravelCreateVM()
            {
                TravelModel = _appDbContext.TravelModels.FirstOrDefault(item => item.Id == id),
                StatusSelectList = _appDbContext.Statuses.Select(item => new SelectListItem
                {
                    Text = item.Statuss,
                    Value = item.Id.ToString()
                }),
                TagSelectList = selectList
                /* SelectListTagIds = Product..Select(sc => sc.CourseId)*/
            };

            return View(productVM);
        }

        [HttpPost]
        public IActionResult Edit(TravelCreateVM productCreateVM)
        {
            var files = HttpContext.Request.Form.Files;
            var files1 = HttpContext.Request.Form.Files;
            var files2 = HttpContext.Request.Form.Files;
            var files3 = HttpContext.Request.Form.Files;
            var files4 = HttpContext.Request.Form.Files;
            string webRootPath = _webHostEnvironment.WebRootPath;

            var objProduct = _appDbContext.TravelModels.AsNoTracking().FirstOrDefault(pro => pro.Id == productCreateVM.TravelModel.Id);
            var objProduct1 = _appDbContext.TravelModels.AsNoTracking().FirstOrDefault(pro => pro.Id == productCreateVM.TravelModel.Id);
            var objProduct2 = _appDbContext.TravelModels.AsNoTracking().FirstOrDefault(pro => pro.Id == productCreateVM.TravelModel.Id);
            var objProduct3 = _appDbContext.TravelModels.AsNoTracking().FirstOrDefault(pro => pro.Id == productCreateVM.TravelModel.Id);
            var objProduct4 = _appDbContext.TravelModels.AsNoTracking().FirstOrDefault(pro => pro.Id == productCreateVM.TravelModel.Id);
            if (files.Count > 0 && files1.Count > 1 && files2.Count > 2 && files3.Count > 3 && files4.Count > 4)
            {
                string upload = webRootPath + ImageDefault.ImagePath;
                string fileName = Guid.NewGuid().ToString();
                string extension = Path.GetExtension(files[0].FileName);
                string fileName1 = Guid.NewGuid().ToString();
                string extension1 = Path.GetExtension(files1[1].FileName);
                string fileName2 = Guid.NewGuid().ToString();
                string extension2 = Path.GetExtension(files2[2].FileName);
                string fileName3 = Guid.NewGuid().ToString();
                string extension3 = Path.GetExtension(files3[3].FileName);
                string fileName4 = Guid.NewGuid().ToString();
                string extension4 = Path.GetExtension(files4[4].FileName);

                using (var fileStream = new FileStream(Path.Combine(upload, fileName + extension), FileMode.Create))
                {
                    files[0].CopyTo(fileStream);
                }
                using (var fileStream = new FileStream(Path.Combine(upload, fileName1 + extension1), FileMode.Create))
                {
                    files1[1].CopyTo(fileStream);
                }
                using (var fileStream = new FileStream(Path.Combine(upload, fileName2 + extension2), FileMode.Create))
                {
                    files2[2].CopyTo(fileStream);
                }
                using (var fileStream = new FileStream(Path.Combine(upload, fileName3 + extension3), FileMode.Create))
                {
                    files3[3].CopyTo(fileStream);
                }
                using (var fileStream = new FileStream(Path.Combine(upload, fileName4 + extension4), FileMode.Create))
                {
                    files4[4].CopyTo(fileStream);
                }

                productCreateVM.TravelModel.ImageUrl = fileName + extension;
                productCreateVM.TravelModel.ImageUrl1 = fileName1 + extension1;
                productCreateVM.TravelModel.ImageUrl2 = fileName2 + extension2;
                productCreateVM.TravelModel.ImageUrl3 = fileName3 + extension3;
                productCreateVM.TravelModel.ImageUrl4 = fileName4 + extension4;
            }
            else
            {
                productCreateVM.TravelModel.ImageUrl = objProduct.ImageUrl;
                productCreateVM.TravelModel.ImageUrl1 = objProduct1.ImageUrl1;
                productCreateVM.TravelModel.ImageUrl2 = objProduct2.ImageUrl2;
                productCreateVM.TravelModel.ImageUrl3 = objProduct3.ImageUrl3;
                productCreateVM.TravelModel.ImageUrl4 = objProduct4.ImageUrl4;
            }

            _appDbContext.TravelModels.Update(productCreateVM.TravelModel);
            _appDbContext.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}
