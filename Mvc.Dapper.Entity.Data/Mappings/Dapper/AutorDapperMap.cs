using Mvc.Dapper.Entity.Domain.Entities;
using Dapper.FluentMap.Dommel.Mapping;

namespace Mvc.Dapper.Entity.Data.Mappings.Dapper
{
    public class AutorDapperMap : DommelEntityMap<Autor>
    {
        public AutorDapperMap()
        {
            ToTable("Autor");
            Map(p => p.ID).IsKey();
        }
    }
}