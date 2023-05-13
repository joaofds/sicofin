namespace Models
{
    public class Usuario : Pessoa
    {
        private string? _email;
        private string? _password;
        public bool logged = false;

        public string? email
        {
            get => _email;
            set => this._email = value;
        }

        public string password
        {
            set
            {
                this._password = value;
            }
        }
    }
}