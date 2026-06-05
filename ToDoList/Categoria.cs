namespace ToDoList
{
    public abstract class Categoria
    {
        public string Nombre { get; set; }

        public Categoria(string nombre)
        {
            Nombre = nombre;
        }

        public abstract string MostrarCategoria();
    }
}