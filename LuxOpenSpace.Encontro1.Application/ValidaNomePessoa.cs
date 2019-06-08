using System.Linq;

namespace LuxOpenSpace.Encontro1.Application
{
    public class ValidaNomePessoa : IValidacaoPessoa
    {
        public bool Valida(Pessoa pessoa)
        {
            return pessoa.Nome.Any();
        }
    }
}
