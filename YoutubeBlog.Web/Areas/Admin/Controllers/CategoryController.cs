using AutoMapper;
using FluentValidation;
using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Mvc;
using NToastNotify;
using System.ComponentModel.DataAnnotations;
using YoutubeBlog.Data.Mappings;
using YoutubeBlog.Entity.DTOs.Articles;
using YoutubeBlog.Entity.DTOs.Categories;
using YoutubeBlog.Entity.Entities;
using YoutubeBlog.Service.Services.Abstractions;
using YoutubeBlog.Service.Services.Conrete;
using YoutubeBlog.Web.ResultMessages;

namespace YoutubeBlog.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CategoryController : Controller
    {
        private readonly ICategoryService _categoryService;
        private readonly IValidator<Category> _validator;
        private readonly IMapper _mapper;
        private readonly IToastNotification _toastNotification;
        public CategoryController(ICategoryService categoryService, IValidator<Category> validator, IMapper mapper, IToastNotification toastNotification)
        {
            _categoryService = categoryService;
            _validator = validator;
            _mapper = mapper;
            _toastNotification = toastNotification;
        }

        public async Task<IActionResult> Index()
        {
            var categories = await _categoryService.GetAllCategoriesNonDeleted();
            return View(categories);
        }
        [HttpGet]
        public IActionResult Add()
        {
            return View(new CategoryAddDto { });
        }
        [HttpPost]
        public async Task<IActionResult> Add(CategoryAddDto categoryAddDto)
        {
            var map = _mapper.Map<Category>(categoryAddDto);
            var result = await _validator.ValidateAsync(map);
            //var context = new ValidationContext<Category>(map);
            //var result = await _validator.ValidateAsync(context);

            if (result.IsValid)
            {
                await _categoryService.CreateCategoryAsync(categoryAddDto);
                _toastNotification.AddSuccessToastMessage(Messages.Category.Add(categoryAddDto.Name), new ToastrOptions { Title = "Başarılı" });
                return RedirectToAction("Index", "Category", new { Area = "Admin" });
            }
            result.AddToModelState(this.ModelState);
            return View();

        }

        [HttpGet]
        public async Task<IActionResult> Update(Guid categoryId)
        {
            var category = await _categoryService.GetCategoryByGuid(categoryId);
            var map = _mapper.Map<Category, CategoryUpdateDto>(category);//category verisini de aynı zamanda gönderiyoruz


            return View(map);
        }
        [HttpPost]
        public async Task<IActionResult> Update(CategoryUpdateDto categoryUpdateDto)
        {
            var map = _mapper.Map<Category>(categoryUpdateDto);
            var result = await _validator.ValidateAsync(map);

            if (result.IsValid)
            {
                var name = await _categoryService.UpdateCategoryAsync(categoryUpdateDto);
                _toastNotification.AddSuccessToastMessage(Messages.Category.Update(name), new ToastrOptions { Title = "İşlem Başarılı" });
                return RedirectToAction("Index", "Category", new { Area = "Admin" });
            }

            result.AddToModelState(this.ModelState);
            return View();
        }

        public async Task<IActionResult> Delete(Guid categoryId)
        {
            var name = await _categoryService.SafeDeleteCategoryAsync(categoryId);
            _toastNotification.AddSuccessToastMessage(Messages.Category.Delete(name), new ToastrOptions() { Title = "İşlem Başarılı" });

            return RedirectToAction("Index", "Category", new { Area = "Admin" });
        }


    }
}
