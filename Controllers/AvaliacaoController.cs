using Microsoft.AspNetCore.Mvc;
using backend.Models;
using System.Text.Json;

namespace backend.Controlles
{
    [Route("[controller]/[action]")]
    [ApiController]

    public class AvaliacaoController : ControllerBase
    {
        private BDContexto contexto;

        public AvaliacaoController(BDContexto bdContexto)
        {
            contexto = bdContexto;
        }

        [HttpGet]
        public List<Avaliacao> Listar()
        {
            return contexto.Avaliacaos.ToList();
        }

        [HttpPost]
        public string NovaAvaliacao([FromBody] Avaliacao novaAvaliacao)
        {
            contexto.Add(novaAvaliacao);
            contexto.SaveChanges();
            return "Avaliação realizada com sucesso!";
        }

        [HttpDelete]
        public string Excluir([FromBody] Avaliacao avaliacao)
        {
            // Avaliacao? avaliacao = JsonSerializer.Deserialize<Avaliacao>(json);

            Avaliacao? dados = contexto.Avaliacaos.FirstOrDefault(p => p.IdAval == avaliacao.IdAval);

            if (dados == null)
            {
                return "ID da avaliação não encontrado.";
            }
            else
            {
                contexto.Remove(dados);
                contexto.SaveChanges();

                return "Avaliação removida com sucesso!";
            }
        }
    }
}