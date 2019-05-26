using System;

namespace LuxOpenSpace.Encontro1.Application
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = new Pessoa();
            var retorno = "";
            a.Cpf = "123456789-12";
            a.Nome = "José Fernando";
            a.Telefone = "123456789";
            retorno = a.Salvar();
            Console.WriteLine(retorno);
        }
    }
}
