using Mvc.Dapper.Entity.Data.Repositories.Dapper.Common;
using Mvc.Dapper.Entity.Domain.Entities;
using Mvc.Dapper.Entity.Domain.Interfaces.Repositories;
using Microsoft.Extensions.Configuration;

namespace Mvc.Dapper.Entity.Data.Repositories.Dapper
{
    public class AutorDapperRepository : DapperRepositoryBase<Autor>, IAutorDapperRepository
    {
        public AutorDapperRepository(IConfiguration configuration) : base(configuration) { }
    }
}