using Mvc.Dapper.Entity.Domain.Entities;
using Dapper.FluentMap.Dommel.Mapping;

namespace Mvc.Dapper.Entity.Data.Mappings.Dapper
{
    public class LivroDapperMap : DommelEntityMap<Livro>
    {
        public LivroDapperMap()
        {
            ToTable("Livro");
            Map(p => p.ID).IsKey().IsIdentity();
        }
    }
}