using Mvc.Dapper.Entity.Data.Context;
using Mvc.Dapper.Entity.Data.Repositories.EntityFramework.Common;
using Mvc.Dapper.Entity.Domain.Entities;
using Mvc.Dapper.Entity.Domain.Interfaces.Repositories;

namespace Mvc.Dapper.Entity.Data.Repositories.EntityFramework
{
    public class AutorEFRepository : EFRepositoryBase<Autor>, IAutorEFRepository
    {
        public AutorEFRepository(AppDbContext context) : base(context) { }
    }
}