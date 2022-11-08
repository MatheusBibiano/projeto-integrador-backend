using Microsoft.AspNetCore.Mvc;
using backend.Models;

namespace backend.Controlles
{
    [Route("[controller]/[action]")]
    [ApiController]

    public class AulaController : ControllerBase
    {
        private BDContexto contexto;

        public AulaController(BDContexto bdContexto)
        {
            contexto = bdContexto;
        }

        [HttpGet("{fkDisc}")]
        public List<Aula> Listar(int fkDisc)
        {
            var result = (from aula in this.contexto.Aulas
                          where aula.FkDisc == fkDisc
                          select aula).ToList();

            return result;
        }

        [HttpPost]
        public string NovaAula([FromBody] Aula novaAula)
        {
            contexto.Add(novaAula);
            contexto.SaveChanges();
            return "Aula cadastrada com sucesso!";
        }
    }
}