using System;

namespace LuxOpenSpace.Encontro1.Application
{
    class Program
    {
        static void Main(string[] args)
        {
            RepositorioPessoa repositorio = new RepositorioPessoa();
            repositorio.AdicionaValidacao(new ValidaNomePessoa());
            repositorio.AdicionaValidacao(new ValidaTelefonePessoa());
            repositorio.AdicionaValidacao(new ValidaCpfPessoa());

            var novaPessoa = new Pessoa();
            novaPessoa.Cpf = "43993034841";
            novaPessoa.Nome = "José Fernando";
            novaPessoa.Telefone = "123456789";

            string resultadoCadastro = repositorio.Salvar(novaPessoa);
            Console.WriteLine(resultadoCadastro);
        }
    }
}
