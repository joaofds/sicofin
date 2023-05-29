namespace Models
{
    public class CartaoCredito : Cartao
    {
        private float? _limite;
        private float? _saldo;

        public float? limite
        {
            get => this._limite;
            set => this._limite = value;
        }
        public float? saldo
        {
            get => this._saldo;
            set => this._saldo = value;
        }

        public CartaoCredito() { }

        public CartaoCredito
        (
            string titular,
            string numero,
            string agencia,
            string conta,
            string codigo,
            DateTime validade
        )
        {
            this.titular = titular;
            this.numero = numero;
            this.agencia = agencia;
            this.conta = conta;
            this.codigo = codigo;
            this.validade = validade;
        }
    }
}