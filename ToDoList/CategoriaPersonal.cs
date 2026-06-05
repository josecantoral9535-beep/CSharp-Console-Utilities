namespace ToDoList
{
    public class CategoriaPersonal : Categoria
    {
        public CategoriaPersonal() : base("Personal") { }

        public override string MostrarCategoria()
        {
            return "Personal";
        }
    }
}