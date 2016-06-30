using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorArquivoCNAB240.Domains
{
    public class ClsHeaderArquivo
    {
        public string banco { get; set; }
        public string lote { get; set; }
        public string registro { get; set; }
        public string CNAB { get; set; }
        public TipoPessoa TipoInscricao { get; set; }
    }
}
