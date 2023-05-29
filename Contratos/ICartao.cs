namespace Contratos
{
    interface ICartao
    {
        public string? titular { get; set; }
        public string? bandeira { get; set; }
        public string? numero { get; set; }
        public string? agencia { get; set; }
        public string? conta { get; set; }
        public string? codigo { get; set; }
        public DateTime? validade { get; set; }
    }
}