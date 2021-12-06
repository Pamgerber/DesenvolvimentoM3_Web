using Data.Models;
using Data.Repositorys;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace apiLab.Controllers
{
    public class AgendamentoController : BaseController<AgendamentoRepository,AgendamentoModel>
    {

    }
}
