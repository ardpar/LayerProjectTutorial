using NLayerProject.Core.Repository;
using NLayerProject.Core.UnitOfWorks;
using NLayerProject.Data.Repository;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NLayerProject.Data.UnitOfWorks
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext context;
        private IProductRepository _ProductsRepository;
        private ICategoryRepository _CategoryRepository;
        public IProductRepository Products => _ProductsRepository = _ProductsRepository ??
            new ProductRepository(context);

        public ICategoryRepository Categories => _CategoryRepository = _CategoryRepository ??
            new CategoryRepository(context);

        public UnitOfWork(AppDbContext appDbContext)
        {
            context = appDbContext;
        }

        public void Commit()
        {
            context.SaveChanges();
        }

        public async Task CommitAsync()
        {
           await context.SaveChangesAsync();
        }
    }
}
