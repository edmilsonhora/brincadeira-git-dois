using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Bricadeira_Git_Dois.DomainModel
{
    public abstract class EntityBase
    {
        protected StringBuilder RegrasQuebradas = new StringBuilder();
        public int Id { get; set; }

        public virtual void Validar()
        {
            if(RegrasQuebradas.Length > 0)
            {
                throw new ApplicationException(RegrasQuebradas.ToString());
            }
        }
    }
}
