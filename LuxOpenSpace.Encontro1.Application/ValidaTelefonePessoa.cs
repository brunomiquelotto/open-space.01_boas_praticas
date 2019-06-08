using System.Linq;

namespace LuxOpenSpace.Encontro1.Application
{
    public class ValidaTelefonePessoa : IValidacaoPessoa
    {
        public bool Valida(Pessoa pessoa)
        {
            return pessoa.Telefone.Any();
        }
    }
}
