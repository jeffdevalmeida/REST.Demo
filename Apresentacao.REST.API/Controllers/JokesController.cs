using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Apresentacao.REST.API.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Apresentacao.REST.API.Controllers
{
    [Route("joke")]
    [ApiController]
    public class JokesController : ControllerBase
    {

        [HttpGet]
        [Route("")]
        public IActionResult Get()
        {
            Random random = new Random();

            List<Joke> jokes = new List<Joke>
            {
                new Joke("Piada 1"),
                new Joke("Piada 2"),
                new Joke("Piada 3"),
                new Joke("Piada 4")
            };

            try
            {
                var response = jokes[random.Next(0, 3)];

                return Ok(response);
            }
            catch(Exception ex)
            {
                var errorModel = new
                {
                    Mensagem = "Deu erro em algum trecho.",
                    Erro = ex.StackTrace
                };
                
                return StatusCode(500, errorModel);
            }
        }
    }
}
