namespace LuxOpenSpace.Encontro1.Application
{
    public class Pessoa
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Telefone { get; set; }

        public string Salvar()
        {
            var sucesso = true;
            var mensagem = "";
            if (this.Nome.Length == 0)
            {
                sucesso = false;
                mensagem += "nome inválido";
            }

            if (this.Telefone.Length == 0)
            {
                sucesso = false;
                mensagem += ";telefone inválido";
            }

            if (this.Cpf.Length == 0)
            {
                sucesso = false;
                mensagem += ";cpf inválido";
            }

            if (sucesso)
            {
                //Salva
                return "sucesso";
            }
            else
            {
                return mensagem;
            }
        }
    }
}
