using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CRUD_WCF_REST_JSON
{
    public class Refeicao
    {
        public Refeicao()
        {
            this.Alimentos = new HashSet<Alimento>();
        }

        public int Id { get; set; }
        public string Descricao { get; set; }

        public virtual ICollection<Alimento> Alimentos { get; set; }
    }
}