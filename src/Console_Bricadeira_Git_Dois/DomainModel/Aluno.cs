using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Bricadeira_Git_Dois.DomainModel
{
    public class Aluno : EntityBase
    {
        public string Nome { get; set; }
        public string RA { get; set; }

        public override void Validar()
        {
            base.Validar();
        }
    }

    public interface IAlunoRepository : IRepositoryBase<Aluno> { }
}
