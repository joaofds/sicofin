using Contratos;
namespace Models
{
    public abstract class Cartao : ICartao
    {
        private string? _titular;
        private string? _bandeira;
        private string? _numero;
        private string? _agencia;
        private string? _conta;
        private string? _codigo;
        private DateTime? _validade;

        public string? titular
        {
            get => this._titular;
            set => this._titular = value;
        }
        public string? bandeira
        {
            get => this._bandeira;
            set => this._bandeira = value;
        }
        public string? numero
        {
            get => this._numero;
            set => this._numero = value;
        }
        public string? agencia
        {
            get => this._agencia;
            set => this._agencia = value;
        }
        public string? conta
        {
            get => this._conta;
            set => this._conta = value;
        }
        public string? codigo
        {
            get => this._codigo;
            set => this._codigo = value;
        }
        public DateTime? validade
        {
            get => this._validade;
            set => this._validade = value;
        }
    }
}