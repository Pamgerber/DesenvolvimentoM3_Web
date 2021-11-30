using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    class SolicitacaoModel : BaseModel
    {
        public int nota { get; set; }
        public string ordemVenda { get; set; }
        public decimal frete { get; set; }
        public DateTime prazoInicio { get; set; }
        public DateTime prazoFim { get; set; }
        public string status { get; set; }
    }
}
