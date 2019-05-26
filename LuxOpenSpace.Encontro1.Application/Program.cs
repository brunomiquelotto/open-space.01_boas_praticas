using System;

namespace LuxOpenSpace.Encontro1.Application
{
    class Program
    {
        static void Main(string[] args)
        {
            var l = new Pessoa();
            var retorno = "";
            l.cpf = "123456789-12";
            l.nome = "José Fernando";
            l.telefone = "123456789";
            retorno = l.Salvar();
            Console.WriteLine(retorno);
        }
    }
}
