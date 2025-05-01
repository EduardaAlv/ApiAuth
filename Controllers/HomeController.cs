using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using ApiAuth.Models;
using ApiAuth.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace ApiAuth.Controllers
{
    [ApiController]
    public class HomeController : ControllerBase
    {
        //Para autorizar, colocar o token no Authtorization/Bearer do postman, swagger, ou onde a api for exposta.

        [HttpGet]
        [Route("anonymous")]
        [AllowAnonymous]
        public string Anonymous() => "Rota que não exige auth";

        [HttpGet]
        [Route("authenticated")]
        [Authorize]
        public string Authenticated() => "Rota que exige auth";

        [HttpGet]
        [Route("employee")]
        [Authorize(Roles = "employee,manager")]
        public string Employee() => "Api autorizada para empregado e gerente, filtrado pelo Roles";

        [HttpGet]
        [Route("manager")]
        [Authorize(Roles = "manager")]
        public string Manager() => "Api autorizada somente para empregado e gerente, filtrado pelo Roles";
    }
}
