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

            if (this.Cpf.Length > 0)
            {
                string cpf = this.Cpf.Trim();
                cpf = cpf.Replace(".", "").Replace("-", "");
                if (cpf.Length != 11)
                {
                    sucesso = false;
                    mensagem += ";cpf inválido(tamanho)";
                }

                string cpfTemp = cpf.Substring(0, 9);

                int soma = 0;

                int[] multiplicadorDigito1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };

                for (int i = 0; i < 9; i++)
                {
                    soma += int.Parse(cpfTemp[i].ToString()) * multiplicadorDigito1[i];
                }

                int resto = soma % 11;

                resto = resto < 2 ? 0 : 11 - resto;

                string digitoVerificador = resto.ToString();
                cpfTemp += digitoVerificador;

                soma = 0;
                int[] multiplicadorDigito2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
                for (int i = 0; i < 10; i++)
                {
                    soma += int.Parse(cpfTemp[i].ToString()) * multiplicadorDigito2[i];
                }
                resto = soma % 11;

                resto = resto < 2 ? 0 : 11 - resto;

                digitoVerificador += resto.ToString();

                if (!cpf.EndsWith(digitoVerificador))
                {
                    sucesso = false;
                    mensagem = ";cpf inválido(digito verificador)";
                }
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
