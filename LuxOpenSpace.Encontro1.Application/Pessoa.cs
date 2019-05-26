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

            if (this.cpf.Length > 0)
            {
                int[] m1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
                int[] m2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
                string tmp;
                string dg;
                int soma;
                int resto;
                var cpf = "";

                cpf = this.cpf.Trim();
                cpf = cpf.Replace(".", "").Replace("-", "");
                if (cpf.Length != 11)
                {
                    sucesso = false;
                    mensagem += ";cpf inválido(tamanho)";
                }

                tmp = cpf.Substring(0, 9);

                soma = 0;

                for (int i = 0; i < 9; i++)
                    soma += int.Parse(tmp[i].ToString()) * m1[i];
                resto = soma % 11;
                if (resto < 2)
                    resto = 0;
                else
                    resto = 11 - resto;
                dg = resto.ToString();
                tmp = tmp + dg;
                soma = 0;
                for (int i = 0; i < 10; i++)
                    soma += int.Parse(tmp[i].ToString()) * m2[i];
                resto = soma % 11;
                if (resto < 2)
                    resto = 0;
                else
                    resto = 11 - resto;
                dg = dg + resto.ToString();
                if (!cpf.EndsWith(dg))
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
