namespace Models
{
    public class Financa
    {
        private int? _tipo;
        private string? _descricao;
        private float? _valor;
        private DateTime _data;

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

        public DateTime data
        {
            get => this._data;
            set => this._data = value;
        }

        public Financa() { }

        public Financa(int tipo, string descricao, float valor, DateTime data)
        {
            this.tipo = tipo;
            this.descricao = descricao;
            this.valor = valor;
            this.data = data;
        }
    }
}