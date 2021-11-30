using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class AgendamentoModel:BaseModel
    {
        public string motorista { get; set; }
        public string placa { get; set; }
        public decimal pesoMax { get; set; }
        public DateTime diaColeta { get; set; }
    }
}
