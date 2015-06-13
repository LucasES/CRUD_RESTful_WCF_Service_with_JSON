using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CRUD_WCF_REST_JSON
{
    public class AlimentoRefeicao
    {
        public int Id { get; set; }

        public virtual ICollection<Alimento> Alimentos { get; set; }
        public virtual ICollection<Refeicao> Refeicoes { get; set; }
    }
}