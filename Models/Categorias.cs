namespace Models
{
    public class Categorias
    {
        private static Dictionary<int, string> categorias = new Dictionary<int, string>
        {
            {1, "Receita"},
            {2, "Despesa"}
        };
        public static string getCategoria(int id)
        {
            var categoria = categorias.FirstOrDefault(item => item.Key == id);
            return categoria.Value;
        }
    }
}