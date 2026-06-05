using System.Text.Json;

namespace ToDoList
{
    public class GestorTareas
    {
        private string ruta = Path.Combine(FileSystem.AppDataDirectory, "tareas.json");

        public void GuardarTareas(List<Tareas> tareas)
        {
            string json = JsonSerializer.Serialize(tareas);
            File.WriteAllText(ruta, json);
        }

        public List<Tareas> CargarTareas()
        {
            if (!File.Exists(ruta))
                return new List<Tareas>();

            string json = File.ReadAllText(ruta);
            return JsonSerializer.Deserialize<List<Tareas>>(json) ?? new List<Tareas>();
        }
    }
}