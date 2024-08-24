using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YoutubeBlog.Data.Context;
using YoutubeBlog.Data.Repositories.Abstractions;
using YoutubeBlog.Data.Repositories.Concretes;

namespace YoutubeBlog.Data.UnitOfWorks
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _appDbContext;

        public UnitOfWork(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async ValueTask DisposeAsync()
        {
            await _appDbContext.DisposeAsync();
        }

        public int Save()
        {
          return  _appDbContext.SaveChanges();
        }

        public async Task<int> SaveAsync()
        {
          return  await _appDbContext.SaveChangesAsync();
        }

        IRepository<T> IUnitOfWork.GetRepository<T>()
        {
            return new Repository<T>(_appDbContext);
        }
    }
}
