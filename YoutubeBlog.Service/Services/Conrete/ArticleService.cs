using AutoMapper;
using YoutubeBlog.Data.UnitOfWorks;
using YoutubeBlog.Entity.DTOs.Articles;
using YoutubeBlog.Entity.Entities;
using YoutubeBlog.Service.Services.Abstractions;

namespace YoutubeBlog.Service.Services.Conrete
{
    public class ArticleService : IArticleService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public ArticleService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task CreateArticleAsync(ArticleAddDto articleAddDto)
        {
            var userId = Guid.Parse("2BAFF7A7-3BF5-4CF6-9597-22456A581A0B");
            var article = new Article
            {
                Title = articleAddDto.Title,
                Content = articleAddDto.Content,
                CategoryId = articleAddDto.CategoryId,
                UserId = userId
            };
            await _unitOfWork.GetRepository<Article>().AddAsync(article);
            await _unitOfWork.SaveAsync();
        }

        public async Task<List<ArticleDto>> GetAllArticlesWithCategoryNonDeletedAsync()
        {
            var articles = await _unitOfWork.GetRepository<Article>().GetAllAsync(x => x.IsDeleted == false, x => x.Category);
            var map = _mapper.Map<List<ArticleDto>>(articles);
            return map;
        }

        public async Task<ArticleDto> GetArticlesWithCategoryNonDeletedAsync(Guid articleId)
        {
            var article = await _unitOfWork.GetRepository<Article>().GetAsync(x => !x.IsDeleted && x.Id == articleId, x => x.Category);
            var map = _mapper.Map<ArticleDto>(article);
            return map;
        }

        public async Task<string> UpdateArticleAsync(ArticleUpdateDto articleUpdateDto)
        {
            var article = await _unitOfWork.GetRepository<Article>().GetAsync(x => !x.IsDeleted && x.Id == articleUpdateDto.Id, x => x.Category);
           //_mapper.Map<ArticleUpdateDto>(article);
           article.Title =articleUpdateDto.Title;
           article.Content =articleUpdateDto.Content;
           article.CategoryId =articleUpdateDto.CategoryId;
            

            await _unitOfWork.GetRepository<Article>().UpdateAsync(article);

            await _unitOfWork.SaveAsync();
            return articleUpdateDto.Title;
        }

        public async Task<string> SafeDeleteArticleAsync(Guid articleId)
        {
            var article = await _unitOfWork.GetRepository<Article>().GetByGuidAsync(articleId);
            article.IsDeleted = true;
            article.DeletedDate=DateTime.Now;

            await _unitOfWork.GetRepository<Article>().UpdateAsync(article);
            await _unitOfWork.SaveAsync();  
            return article.Title;
        }
    }
}
