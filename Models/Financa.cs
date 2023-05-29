namespace Models
{
    public class Financa
    {
        private int? _tipo;
        private string? _descricao;
        private float? _valor;

        public int? tipo
        {
            get => this._tipo;
            set => this._tipo = Convert.ToInt32(value);
        }

        public string? descricao
        {
            get => _descricao;
            set => _descricao = value;
        }

        public float? valor
        {
            get => _valor;
            set => _valor = value;
        }

        public Financa() { }

        public Financa(int tipo, string descricao, float valor)
        {
            this.tipo = tipo;
            this.descricao = descricao;
            this.valor = valor;
        }
    }
}