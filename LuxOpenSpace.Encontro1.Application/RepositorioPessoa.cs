using System.Collections.Generic;

namespace LuxOpenSpace.Encontro1.Application
{
    public class RepositorioPessoa
    {
        private List<Pessoa> _pessoas;
        private List<IValidacaoPessoa> _validacoes;
        public RepositorioPessoa()
        {
            _validacoes = new List<IValidacaoPessoa>();
            _pessoas = new List<Pessoa>();
        }
        public void AdicionaValidacao(IValidacaoPessoa validacao)
        {
            this._validacoes.Add(validacao);
        }

        public string Salvar(Pessoa pessoa)
        {
            foreach (IValidacaoPessoa validacao in this._validacoes)
            {
                if (!validacao.Valida(pessoa))
                {
                    return "Inválida";
                }
            }
            _pessoas.Add(pessoa);
            return "Sucesso";
        }

        public void Excluir(Pessoa pessoa)
        {

        }

        public void Alterar(Pessoa pessoa)
        {

        }

        public List<Pessoa> Listar()
        {
            return _pessoas;
        }
    }
}
