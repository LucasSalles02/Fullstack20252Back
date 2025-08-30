using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aluno.Dominio
{
    public class Aluno1
    {
        public int Id { get; set; }
        public string Nome {  get; set; }
        public int Idade { get; set; }

        public bool EhMaiordeIdade()
        {
            return Idade >= 18;
        }
    }
}
