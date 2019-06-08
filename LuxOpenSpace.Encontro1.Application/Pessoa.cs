namespace LuxOpenSpace.Encontro1.Application
{
    public class Pessoa
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Telefone { get; set; }

        public string Falar()
        {
            return $"Olá, me chamo ${Nome}, sejam bem vindos ao OpenSpace";
        }
    }
}
