//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CRUD_WCF_REST_JSON
{
    using System;
    using System.Collections.Generic;
    
    public partial class GrupoEntidade
    {
        public GrupoEntidade()
        {
            this.Alimentoes = new HashSet<AlimentoEntidade>();
        }
    
        public int Id { get; set; }
        public string Nome { get; set; }
    
        public virtual ICollection<AlimentoEntidade> Alimentoes { get; set; }
    }
}
