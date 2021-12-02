using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class AgendamentoModel:BaseModel
    {
        [ForeignKey("solicitacaoId")]
        public SolicitacaoModel solicitacao { get; set; }
        public int? solicitacaoId { get; set; }
        public string motorista { get; set; }
        public string placa { get; set; }
        public decimal pesoMax { get; set; }
        public DateTime diaColeta { get; set; }
    }
}
