namespace Models
{
    public class Usuario : Pessoa
    {
        public bool logged = false;
        private string? _email;
        private string? _password;
        private List<Financa> _financas = new List<Financa>();
        private List<CartaoCredito> _cartoes = new List<CartaoCredito>();

        public string? email
        {
            get => _email;
            set => this._email = value;
        }

        public string password
        {
            get => _password!;
            set
            {
                this._password = value;
            }
        }

        public List<Financa> financas
        {
            get => this._financas;
            set => this._financas = value;
        }

        public List<CartaoCredito> cartoes
        {
            get => this._cartoes;
            set => this._cartoes = value;
        }

        /*
        * Rotina para logar o usuario.
        *
        */
        public bool isLogged(string email, string password)
        {
            if ((this.email == email) && (this.password == password))
            {
                this.logged = true;
                return true;
            }
            return false;
        }
    }
}