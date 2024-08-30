using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using YoutubeBlog.Service.Services.Abstractions;

namespace YoutubeBlog.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize]
    public class HomeController : Controller
    {
        private readonly IArticleService _articleService;
        private readonly IDashboardService _dashboardService;

        public HomeController(IArticleService articleService, IDashboardService dashboardService)
        {
            _articleService = articleService;
            _dashboardService = dashboardService;
        }

        public async Task<IActionResult> Index()
        {
            var articles = await _articleService.GetAllArticlesWithCategoryNonDeletedAsync();
            return View(articles);
        }
        [HttpGet]
        public async Task<IActionResult> YearlyArticleCounts()
        {
            var count = await _dashboardService.GetYearlyArticleCounts();
            return Json(JsonConvert.SerializeObject(count));
        }

        [HttpGet]
        public async Task<IActionResult> TotalArticleCount()
        {
            
            var count = await _dashboardService.GetTotalArticleCounts();
            //Liste kullanılmadıgı için SerializeObject yapmaya gerek yok
            //return Json(JsonConvert.SerializeObject(count));
            return Json(count);
        }


        [HttpGet]
        public async Task<IActionResult> TotalCategoryCount()
        {
            var count = await _dashboardService.GetTotalCategoryCounts();
            return Json(count);
        }
    }
}
