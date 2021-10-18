using Mvc.Dapper.Entity.Data.Context;
using Mvc.Dapper.Entity.Data.Repositories.EntityFramework.Common;
using Mvc.Dapper.Entity.Domain.Entities;
using Mvc.Dapper.Entity.Domain.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace Mvc.Dapper.Entity.Data.Repositories.EntityFramework
{
    public class LivroEFRepository : EFRepositoryBase<Livro>, ILivroEFRepository
    {
        public LivroEFRepository(AppDbContext context) : base(context) { }

        public override IEnumerable<Livro> GetAll() =>
            db.Livros.Include(x => x.Autor).ToList();

        public override Livro GetById(int? id) =>
            db.Livros.Include(x => x.Autor).FirstOrDefault(x => x.ID == id);
    }
}