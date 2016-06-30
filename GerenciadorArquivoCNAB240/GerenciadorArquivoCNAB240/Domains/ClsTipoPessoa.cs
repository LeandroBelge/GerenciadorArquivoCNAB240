using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorArquivoCNAB240.Domains
{
    public static class TipoPessoa
    {
        enum Tipo { CPF, CNPJ };

        public static Tipo tipoPessoa { get; set; }
        
    }
}
