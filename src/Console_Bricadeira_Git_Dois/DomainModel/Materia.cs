using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Bricadeira_Git_Dois.DomainModel
{
    public class Materia :EntityBase 
    {
        public string Nome { get; set; }
        public string Descricao { get; set; }

        public override void Validar()
        {
            base.Validar();
        }
    }
}
