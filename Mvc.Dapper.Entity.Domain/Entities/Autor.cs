using System.Collections.Generic;

namespace Mvc.Dapper.Entity.Domain.Entities
{
    public class Autor
    {
        public int ID { get; set; }
        public string Nome { get; set; }

        public virtual ICollection<Livro> Livros { get; set; }
    }
}