using alunosapi.Models;
using alunosapi.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace alunosapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlunoController : ControllerBase
    {
        private readonly IAlunoService _alunoService;

        public AlunoController(IAlunoService alunoService)
        {
            _alunoService = alunoService;
        }

        [HttpGet]
        public async Task<ActionResult<IAsyncEnumerable<AlunoModel>>> GetAlunos()
        {
            try
            {
                var alunos = await _alunoService.GetAlunos();
                return Ok(alunos);
            }
            catch
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Erro ao obter a lista de alunos");
            }
        }

        [HttpGet("AlunosPorNome")]
        public async Task<ActionResult<IAsyncEnumerable<AlunoModel>>> GetAlunosPeloNome([FromQuery] string nome)
        {
            try
            {
                var alunos = await _alunoService.GetAlunosPeloNome(nome);
                if (alunos.Count() == 0)
                    return NotFound($"Não existe alunos com o nome: {nome}");

                return Ok(alunos);
            }
            catch
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Erro ao obter os alunos");
            }
        }

        [HttpGet("{id:int}", Name = "GetAluno")]
        public async Task<ActionResult> GetAluno(int id)
        {
            try
            {
                var alunos = await _alunoService.GetAluno(id);
                if (alunos == null)
                    return NotFound($"Não existe um aluno com o id: {id}");

                return Ok(alunos);
            }
            catch
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Erro ao obter aluno");
            }
        }

        [HttpPost]
        public async Task<ActionResult> Create(AlunoModel aluno)
        {
            try
            {
                await _alunoService.CreateAluno(aluno);
                return Ok(aluno);
            }
            catch
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Erro ao cadastrar aluno");
            }
        }

        [HttpPut("{id:int}")]
        public async Task<ActionResult> Update(int id, [FromBody] AlunoModel aluno)
        {
            try
            {
                if (aluno.Id == id)
                {
                    await _alunoService.UpdateAluno(aluno);
                    return Ok($"O aluno com o id:{id} foi alterado com sucesso.");
                }
                return BadRequest("Dados inconsistentes.");
            }
            catch
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Erro ao atualizar dados do aluno.");
            }
        }

        [HttpDelete("{id:int}")]
        public async Task<ActionResult> Delete(int id)
        {
            try
            {
                var aluno = await _alunoService.GetAluno(id);
                if (aluno == null)
                    return BadRequest($"Aluno com id:{id} não encontrado.");

                await _alunoService.DeleteAluno(aluno);
                return Ok($"O aluno com o id:{id} foi deletado com sucesso.");
            }
            catch
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Erro ao atualizar dados do aluno.");
            }
        }
    }
}
