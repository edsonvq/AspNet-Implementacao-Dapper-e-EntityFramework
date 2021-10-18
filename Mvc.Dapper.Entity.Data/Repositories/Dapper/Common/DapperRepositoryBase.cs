using Mvc.Dapper.Entity.Data.Mappings.Dapper;
using Mvc.Dapper.Entity.Domain.Interfaces.Repositories.Common;
using Dapper.FluentMap;
using Dapper.FluentMap.Dommel;
using Dommel;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Mvc.Dapper.Entity.Data.Repositories.Dapper.Common
{
    public abstract class DapperRepositoryBase<TEntity> : IRepositoryBase<TEntity> where TEntity : class
    {
        private readonly IConfiguration _configuration;
        protected readonly SqlConnection conn;

        public DapperRepositoryBase(IConfiguration configuration)
        {
            _configuration = configuration;
            if (FluentMapper.EntityMaps.IsEmpty)
            {
                FluentMapper.Initialize(c =>
                {
                    c.AddMap(new LivroDapperMap());
                    c.AddMap(new AutorDapperMap());
                    c.ForDommel();
                });
            }
            conn = new SqlConnection(_configuration.GetConnectionString("DefaultConnection"));
        }

        public void Add(TEntity obj) =>
            conn.Insert(obj);

        public virtual IEnumerable<TEntity> GetAll() =>
            conn.GetAll<TEntity>();

        public virtual TEntity GetById(int? id) =>
            conn.Get<TEntity>(id);

        public virtual void Remove(TEntity obj) =>
            conn.Delete(obj);

        public virtual void Update(TEntity obj) =>
            conn.Update(obj);

        private bool _disposed = false;

        ~DapperRepositoryBase() =>
            Dispose();

        public void Dispose()
        {
            if (!_disposed)
            {
                conn.Close();
                conn.Dispose();
                _disposed = true;
            }
            GC.SuppressFinalize(this);
        }
    }
}