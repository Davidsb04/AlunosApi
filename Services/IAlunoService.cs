using alunosapi.Models;

namespace alunosapi.Services
{
    public interface IAlunoService
    {
        Task<IEnumerable<AlunoModel>> GetAlunos();
        Task<AlunoModel> GetAluno(int id);
        Task<IEnumerable<AlunoModel>> GetAlunosPeloNome(string nome);
        Task CreateAluno(AlunoModel aluno);
        Task UpdateAluno(AlunoModel aluno);
        Task DeleteAluno(AlunoModel aluno);
    }
}
