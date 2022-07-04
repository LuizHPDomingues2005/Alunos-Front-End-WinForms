using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace apAlunos
{
    public class InfoAluno
    {
        public int ra { get; }
        public string nome { get; }
        public int cep { get; }
        public string complemento { get; }
        public int numeroresidencia { get; }

        public string bairro { get; }
        public string cidade { get; }
        public string logradouro { get; }

        public InfoEstado estado_info { get; }
        public InfoCidade cidade_info { get; }
        public string estado { get; }
    }
}
