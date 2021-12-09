using Data.Models;
using Data.Repositorys;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Http.Cors;

namespace apiLab.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AgendamentoController : BaseController<AgendamentoRepository,AgendamentoModel>
    {

    }
}
