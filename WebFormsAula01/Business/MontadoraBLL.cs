using Business.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class MontadoraBLL
    {
        public void Salvar(montadoraModel model)
        {
            if (model.ID == 0) 
            {
                Adicionar(model);
                return;
            }
            Alterar(model);
        }

        private void Adicionar(montadoraModel model)
        {

        }

        private void Alterar(montadoraModel model)
        {

        }


    }
}
