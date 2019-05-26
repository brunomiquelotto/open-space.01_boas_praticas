using System;

namespace LuxOpenSpace.Encontro1.Application
{
    class Program
    {
        static void Main(string[] args)
        {
            var novaPessoa = new Pessoa();
            novaPessoa.Cpf = "123456789-12";
            novaPessoa.Nome = "José Fernando";
            novaPessoa.Telefone = "123456789";
            string resultadoCadastro = novaPessoa.Salvar();
            Console.WriteLine(resultadoCadastro);
        }
    }
}
