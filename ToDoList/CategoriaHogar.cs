namespace ToDoList
{
    public class CategoriaHogar : Categoria
    {
        public CategoriaHogar() : base("Hogar") { }

        public override string MostrarCategoria()
        {
            return "Hogar";
        }
    }
}