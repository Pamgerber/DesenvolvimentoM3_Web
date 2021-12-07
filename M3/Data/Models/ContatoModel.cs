using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class ContatoModel : BaseModel
    {
        public string nome { get; set; }
        public string email { get; set; }
        public string assunto { get; set; }
        public string mensagem { get; set; }
    }
}
