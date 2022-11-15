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

        [HttpGet("{fkDisc}")]
        public List<Object> Listar(int fkDisc)
        {
            return (from avaliacao in this.contexto.Avaliacaos
                    join aula in this.contexto.Aulas on avaliacao.FkAula equals aula.IdAula
                    join disciplina in this.contexto.Disciplinas on aula.FkDisc equals disciplina.IdDisc
                    where aula.FkDisc == fkDisc
                    select new { avaliacao.IdAval, avaliacao.DataPostagem, avaliacao.Mensagem, avaliacao.Qualidade, avaliacao.FkAula, avaliacao.FkAluno, aula.Tema }).ToList<Object>();
        }

        [HttpPost]
        public string NovaAvaliacao([FromBody] Avaliacao novaAvaliacao)
        {
            contexto.Add(novaAvaliacao);
            contexto.SaveChanges();
            return "Avaliação realizada com sucesso!";
        }

        [HttpDelete("{id}")]
        public string Excluir(int id)
        {
            // Avaliacao? avaliacao = JsonSerializer.Deserialize<Avaliacao>(json);

            Avaliacao? dados = contexto.Avaliacaos.FirstOrDefault(p => p.IdAval == id);

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