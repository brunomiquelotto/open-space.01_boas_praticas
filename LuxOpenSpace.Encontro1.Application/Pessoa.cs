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
            string mensagemValidacao = Validar();
            bool sucesso = mensagemValidacao.Length == 0;
            if (sucesso)
            {
                //Salva
                return "sucesso";
            }
            else
            {
                return mensagemValidacao;
            }
        }

        private string Validar()
        {
            string mensagem = "";
            if (this.Nome.Length == 0)
            {
                mensagem += "nome inválido";
            }

            if (this.Telefone.Length == 0)
            {
                mensagem += ";telefone inválido";
            }

            mensagem += ValidarCpf();
            return mensagem;
        }

        private string ValidarCpf()
        {
            if (this.Cpf.Length > 0)
            {
                string cpf = this.Cpf.Trim();
                cpf = cpf.Replace(".", "").Replace("-", "");
                if (cpf.Length != 11)
                {
                    return ";cpf inválido(tamanho)";
                }

                string cpfTemp = cpf.Substring(0, 9);
                string digitoVerificador = CalculaDigitoVerificador1(cpfTemp);
                cpfTemp += digitoVerificador;
                digitoVerificador += CalculaDigitoVerificador2(cpfTemp);

                if (!cpf.EndsWith(digitoVerificador))
                {
                    return ";cpf inválido(digito verificador)";
                }
            }
            return "";
        }

        private string CalculaDigitoVerificador2(string cpfTemp)
        {
            int resto;
            int[] multiplicadorDigito2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int soma = 0;
            for (int i = 0; i < 10; i++)
            {
                soma += int.Parse(cpfTemp[i].ToString()) * multiplicadorDigito2[i];
            }
            resto = soma % 11;

            resto = resto < 2 ? 0 : 11 - resto;

            return resto.ToString();
        }

        private string CalculaDigitoVerificador1(string cpfTemp)
        {
            int[] multiplicadorDigito1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };

            int soma = 0;
            for (int i = 0; i < 9; i++)
            {
                soma += int.Parse(cpfTemp[i].ToString()) * multiplicadorDigito1[i];
            }

            int resto = soma % 11;
            resto = resto < 2 ? 0 : 11 - resto;

            return resto.ToString();
        }
    }
}
