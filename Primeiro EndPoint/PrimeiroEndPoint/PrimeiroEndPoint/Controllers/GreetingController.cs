using Microsoft.AspNetCore.Mvc;
using PrimeiroEndPoint.Models;

namespace PrimeiroEndPoint.Controllers
{
    [ApiController]
    /*
        Annotation/atributo [ApiController] indica que esta classe é um controlador de API. 
        Ela habilita recursos específicos para APIs, 
        como validação automática de modelo e respostas automáticas para erros de validação.

    */

    [Route("[controller]")]
    /*
        Annotation/atributo [Route("[controller]")] define a rota para os endpoints deste controlador. 
        O placeholder [controller] é substituído pelo nome do controlador, 
        que neste caso é "Greeting". 
        Portanto, a rota para acessar os endpoints deste controlador será "/greeting".
    */

    public class GreetingController : ControllerBase 
    {
        private static long _counter = 0; // Variável estática para contar o número de saudações geradas

        private static readonly string _template = "Ola, mundo de merda {0}"; // Template para a mensagem de saudação,
                                                                              // onde {0} será substituído pelo número da saudação


        [HttpGet]
        public Greeting Get([FromQuery] string name = " ")
        {
            var id = Interlocked.Increment(ref _counter);       // Incrementa o contador de forma thread-safe e obtém o novo valor
            var content = string.Format(_template, name);       // Formata a mensagem de saudação usando o template e o nome fornecido
            return new Greeting(1, content);
        }
    }

}
