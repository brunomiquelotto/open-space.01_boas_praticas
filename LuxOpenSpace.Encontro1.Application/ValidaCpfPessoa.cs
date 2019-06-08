namespace LuxOpenSpace.Encontro1.Application
{
    public class ValidaCpfPessoa : IValidacaoPessoa
    {
        public bool Valida(Pessoa pessoa)
        {
            if (pessoa.Cpf.Length <= 0)
            {
                return true;
            }
            string cpf = pessoa.Cpf.Trim();
            cpf = cpf.Replace(".", "").Replace("-", "");
            if (cpf.Length != 11)
            {
                return false;
            }

            string cpfTemp = cpf.Substring(0, 9);
            string digitoVerificador = CalculaDigitoVerificador1(cpfTemp);
            cpfTemp += digitoVerificador;
            digitoVerificador += CalculaDigitoVerificador2(cpfTemp);

            if (!cpf.EndsWith(digitoVerificador))
            {
                return false;
            }
            return true;
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
