namespace LuxOpenSpace.Encontro1.Application
{
    public class Pessoa
    {
        public int id { get; set; }
        public string nome { get; set; }
        public string cpf { get; set; }
        public string telefone { get; set; }

        public string Salvar()
        {
            var sucesso = true;
            var mensagem = "";
            if (this.nome.Length == 0)
            {
                sucesso = false;
                mensagem += "nome inválido";
            }

            if (this.telefone.Length == 0)
            {
                sucesso = false;
                mensagem += ";telefone inválido";
            }

            if (this.cpf.Length == 0)
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
