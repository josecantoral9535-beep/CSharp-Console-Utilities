namespace ToDoList
{
    public class Tareas
    {
        public string Titulo { get; set; } = "";
        public string Descripcion { get; set; } = "";
        public string FechaVencimiento { get; set; } = "";
        public string Estado { get; set; } = "";
        public string Categoria { get; set; } = "";

        public Tareas() { }

        public Tareas(string titulo, string descripcion, string fecha, string estado, string categoria)
        {
            Titulo = titulo;
            Descripcion = descripcion;
            FechaVencimiento = fecha;
            Estado = estado;
            Categoria = categoria;
        }
    }
}