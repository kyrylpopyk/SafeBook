using SafeBook.EfCore.Infrastructure.Persistance.Repositories.Common;
using SafeBook.EfCore.Infrastructure.Persistance.Repositories.Shop;
using System;

namespace SafeBook.Domain.Persistence
{

    public interface IUnitOfWork : IDisposable
    {
        INewsRepository News { get; }
        IUsersRepository Users { get; }
        IProjectsRepository Projects { get; }
        IRolesRepository Roles { get; }
        IProductsRepository Products { get; }
        IProductCategoryRepository ProductCategories { get; }
        int Save();
    }
}
