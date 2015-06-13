using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CRUD_WCF_REST_JSON
{
    public partial class Grupo
    {
        public Grupo()
        {
            this.Alimentos = new HashSet<Alimento>();
        }

        public int Id { get; set; }
        public string Nome { get; set; }

        public virtual ICollection<Alimento> Alimentos { get; set; }
    }
}