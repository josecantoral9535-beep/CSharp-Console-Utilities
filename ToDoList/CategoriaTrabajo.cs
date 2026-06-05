namespace ToDoList
{
    public class CategoriaTrabajo : Categoria
    {
        public CategoriaTrabajo() : base("Trabajo") { }

        public override string MostrarCategoria()
        {
            return "Trabajo";
        }
    }
}