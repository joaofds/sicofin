namespace Models
{
    public class Pessoa
    {
        private string? _nome;
        private string? _sobrenome;
        private string? _cpf;
        public string? nome
        {
            get => _nome;
            set => _nome = value;
        }

        public string? sobrenome
        {
            get => _sobrenome;
            set => _sobrenome = value;
        }

        public string? cpf
        {
            get => _cpf;
            set => _cpf = value;
        }
    }
}