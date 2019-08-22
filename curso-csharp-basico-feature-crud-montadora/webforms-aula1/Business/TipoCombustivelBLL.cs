using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Data;
using Business.Model;

namespace Business
{
    public class TipoCombustivelBLL
    {
        public void Salvar(TipoCombustivelModel model)
        {
            if (model.Id == 0)
            {
                Adicionar(model);
                return;
            }
            Alterar(model);
        }

        public void Adicionar(TipoCombustivelModel model)
        {
            Entities db = new Entities();
            TipoCombustivel tpCombustivel = new TipoCombustivel();
            tpCombustivel.Descricao = model.Descricao;
            db.TipoCombustivel.Add(tpCombustivel);
            db.SaveChanges();
        }

        public void Alterar(TipoCombustivelModel model)
        {
            Entities db = new Entities();
            TipoCombustivel tp = db.TipoCombustivel.Find(model.Id);
            tp.Descricao = model.Descricao;
            db.Entry(tp).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
        }

        public void Excluir(int id)
        {
            Entities db = new Entities();
            TipoCombustivel tp = db.TipoCombustivel.Find(id);
            db.TipoCombustivel.Remove(tp);
            db.SaveChanges();

        }

        public List<TipoCombustivelModel> Buscar()
        {
            Entities db = new Entities();
            var listaObjBanco = db.TipoCombustivel.ToList();
            var listaModel = new List<TipoCombustivelModel>();
            foreach (var item in listaObjBanco)
            {
                listaModel.Add(new TipoCombustivelModel
                {
                    Id = item.Id,
                    Descricao = item.Descricao
                });
            }
            return listaModel;
        }

        public TipoCombustivelModel Buscar(int id)
        {
            Entities db = new Entities();
            TipoCombustivel tp = db.TipoCombustivel.Find(id);
            return new TipoCombustivelModel
            {
                Id = tp.Id,
                Descricao = tp.Descricao
            };
        }
    }
}