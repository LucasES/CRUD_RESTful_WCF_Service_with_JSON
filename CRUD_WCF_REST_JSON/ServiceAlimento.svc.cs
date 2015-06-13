using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace CRUD_WCF_REST_JSON
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ServiceAlimento" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select ServiceAlimento.svc or ServiceAlimento.svc.cs at the Solution Explorer and start debugging.
    public class ServiceAlimento : IServiceAlimento
    {
        public List<Alimento> findall()
        {
            using (MyDemoEntities mde = new MyDemoEntities())
            {
                return mde.AlimentoEntidades.Select(ae => new Alimento
                {
                    Id = ae.id,
                    Nome = ae.nome,
                    Grupo = ae.grupo,
                    Porcao = ae.porcao,
                    Valor_calorico = ae.valor_calorico.Value,
                    Cho = ae.cho.Value,
                    Proteinas = ae.proteinas.Value,
                    Gorduras_totais = ae.gorduras_totais.Value,
                    Gorduras_saturadas = ae.gorduras_saturadas.Value,
                    Colesterol = ae.colesterol.Value,
                    Fosforo = ae.fosforo.Value,
                    Poliinsaturados = ae.poliinsaturados.Value,
                    Monoinsaturados = ae.monoinsaturados.Value,
                    Vitamina_b1 = ae.vitamina_b1.Value,
                    Vitamina_b2 = ae.vitamina_b2.Value,
                    Vitamina_b3 = ae.vitamina_b3.Value,
                    Vitamina_b6 = ae.vitamina_b6.Value,
                    Gordura_trans = ae.gordura_trans.Value,
                    Fibra_alimentar = ae.fibra_alimentar.Value,
                    Acucar = ae.acucar.Value,
                    Sodio = ae.sodio.Value,
                    Selenio = ae.selenio.Value,
                    Calcio = ae.calcio.Value,
                    Ferro = ae.ferro.Value,
                    Potassio = ae.potassio.Value,
                    Zinco = ae.zinco.Value,
                    Magnesio = ae.magnesio.Value,
                    Vitamina_a = ae.vitamina_a.Value,
                    Vitamina_b = ae.vitamina_b.Value,
                    Vitamina_c = ae.vitamina_c.Value,
                    Vitamina_d = ae.vitamina_d.Value,
                    Vitamina_e = ae.vitamina_e.Value,
                    Vitamina_b9 = ae.vitamina_b9.Value,
                    Vitamina_b12 = ae.vitamina_b12.Value
                }).ToList();
            };
        }

        public Alimento find(int id)
        {
            using (MyDemoEntities mde = new MyDemoEntities())
            {
                return mde.AlimentoEntidades.Where(ae => ae.id == id).Select(ae => new Alimento
                {
                    Id = ae.id,
                    Nome = ae.nome,
                    Grupo = ae.grupo,
                    Porcao = ae.porcao,
                    Valor_calorico = ae.valor_calorico.Value,
                    Cho = ae.cho.Value,
                    Proteinas = ae.proteinas.Value,
                    Gorduras_totais = ae.gorduras_totais.Value,
                    Gorduras_saturadas = ae.gorduras_saturadas.Value,
                    Colesterol = ae.colesterol.Value,
                    Fosforo = ae.fosforo.Value,
                    Poliinsaturados = ae.poliinsaturados.Value,
                    Monoinsaturados = ae.monoinsaturados.Value,
                    Vitamina_b1 = ae.vitamina_b1.Value,
                    Vitamina_b2 = ae.vitamina_b2.Value,
                    Vitamina_b3 = ae.vitamina_b3.Value,
                    Vitamina_b6 = ae.vitamina_b6.Value,
                    Gordura_trans = ae.gordura_trans.Value,
                    Fibra_alimentar = ae.fibra_alimentar.Value,
                    Acucar = ae.acucar.Value,
                    Sodio = ae.sodio.Value,
                    Selenio = ae.selenio.Value,
                    Calcio = ae.calcio.Value,
                    Ferro = ae.ferro.Value,
                    Potassio = ae.potassio.Value,
                    Zinco = ae.zinco.Value,
                    Magnesio = ae.magnesio.Value,
                    Vitamina_a = ae.vitamina_a.Value,
                    Vitamina_b = ae.vitamina_b.Value,
                    Vitamina_c = ae.vitamina_c.Value,
                    Vitamina_d = ae.vitamina_d.Value,
                    Vitamina_e = ae.vitamina_e.Value,
                    Vitamina_b9 = ae.vitamina_b9.Value,
                    Vitamina_b12 = ae.vitamina_b12.Value
                }).First();
            };
        }

        public bool create(Alimento alimento)
        {
            using (MyDemoEntities mde = new MyDemoEntities())
            {
                try
                {
                    AlimentoEntidade ae = new AlimentoEntidade();
                    ae.nome = alimento.Nome;
                    ae.grupo = alimento.Grupo;
                    ae.porcao = alimento.Porcao;
                    ae.valor_calorico = alimento.Valor_calorico;
                    ae.cho = alimento.Cho;
                    ae.proteinas = alimento.Proteinas;
                    ae.gorduras_totais = alimento.Gorduras_totais;
                    ae.gorduras_saturadas = alimento.Gorduras_saturadas;
                    ae.colesterol = alimento.Colesterol;
                    ae.fosforo = alimento.Fosforo;
                    ae.poliinsaturados = alimento.Poliinsaturados;
                    ae.monoinsaturados = alimento.Monoinsaturados;
                    ae.vitamina_b1 = alimento.Vitamina_b1;
                    ae.vitamina_b2 = alimento.Vitamina_b2;
                    ae.vitamina_b3 = alimento.Vitamina_b3;
                    ae.vitamina_b6 = alimento.Vitamina_b6;
                    ae.gordura_trans = alimento.Gordura_trans;
                    ae.fibra_alimentar = alimento.Fibra_alimentar;
                    ae.acucar = alimento.Acucar;
                    ae.sodio = alimento.Sodio;
                    ae.selenio = alimento.Selenio;
                    ae.calcio = alimento.Calcio;
                    ae.ferro = alimento.Ferro;
                    ae.potassio = alimento.Potassio;
                    ae.zinco = alimento.Zinco;
                    ae.magnesio = alimento.Magnesio;
                    ae.vitamina_a = alimento.Vitamina_a;
                    ae.vitamina_b = alimento.Vitamina_b;
                    ae.vitamina_c = alimento.Vitamina_c;
                    ae.vitamina_d = alimento.Vitamina_d;
                    ae.vitamina_e = alimento.Vitamina_e;
                    ae.vitamina_b9 = alimento.Vitamina_b9;
                    ae.vitamina_b12 = alimento.Vitamina_b12;
                    mde.AlimentoEntidades.Add(ae);
                    mde.SaveChanges();
                    return true;
                }
                catch
                {
                    return false;
                }
            };
        }

        public bool edit(Alimento alimento)
        {
            using (MyDemoEntities mde = new MyDemoEntities())
            {
                try
                {
                    int id = alimento.Id;
                    AlimentoEntidade ae = mde.AlimentoEntidades.Single(a => a.id == id);
                    ae.nome = alimento.Nome;
                    ae.grupo = alimento.Grupo;
                    ae.porcao = alimento.Porcao;
                    ae.valor_calorico = alimento.Valor_calorico;
                    ae.cho = alimento.Cho;
                    ae.proteinas = alimento.Proteinas;
                    ae.gorduras_totais = alimento.Gorduras_totais;
                    ae.gorduras_saturadas = alimento.Gorduras_saturadas;
                    ae.colesterol = alimento.Colesterol;
                    ae.fosforo = alimento.Fosforo;
                    ae.poliinsaturados = alimento.Poliinsaturados;
                    ae.monoinsaturados = alimento.Monoinsaturados;
                    ae.vitamina_b1 = alimento.Vitamina_b1;
                    ae.vitamina_b2 = alimento.Vitamina_b2;
                    ae.vitamina_b3 = alimento.Vitamina_b3;
                    ae.vitamina_b6 = alimento.Vitamina_b6;
                    ae.gordura_trans = alimento.Gordura_trans;
                    ae.fibra_alimentar = alimento.Fibra_alimentar;
                    ae.acucar = alimento.Acucar;
                    ae.sodio = alimento.Sodio;
                    ae.selenio = alimento.Selenio;
                    ae.calcio = alimento.Calcio;
                    ae.ferro = alimento.Ferro;
                    ae.potassio = alimento.Potassio;
                    ae.zinco = alimento.Zinco;
                    ae.magnesio = alimento.Magnesio;
                    ae.vitamina_a = alimento.Vitamina_a;
                    ae.vitamina_b = alimento.Vitamina_b;
                    ae.vitamina_c = alimento.Vitamina_c;
                    ae.vitamina_d = alimento.Vitamina_d;
                    ae.vitamina_e = alimento.Vitamina_e;
                    ae.vitamina_b9 = alimento.Vitamina_b9;
                    ae.vitamina_b12 = alimento.Vitamina_b12;
                    mde.SaveChanges();
                    return true;
                }
                catch
                {
                    return false;
                }
            };
        }

        public bool delete(Alimento alimento)
        {
            using (MyDemoEntities mde = new MyDemoEntities())
            {
                try
                {
                    int id = alimento.Id;
                    AlimentoEntidade ae = mde.AlimentoEntidades.Single(a => a.id == id);
                    mde.AlimentoEntidades.Remove(ae);                    
                    mde.SaveChanges();
                    return true;
                }
                catch
                {
                    return false;
                }
            };
        }
    }
}
