using System;
using System.Collections.ObjectModel;
using System.Linq;

namespace ToDoList
{
    public partial class MainPage : ContentPage
    {
        private ObservableCollection<Tareas> tareas = new ObservableCollection<Tareas>();
        private GestorTareas gestor = new GestorTareas();

        public MainPage()
        {
            InitializeComponent();

            var tareasGuardadas = gestor.CargarTareas();

            foreach (var tarea in tareasGuardadas)
            {
                tareas.Add(tarea);
            }

            TareasListView.ItemsSource = tareas;
        }

        private void OnAgregarTareaClicked(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TituloEntry.Text) &&
                !string.IsNullOrEmpty(DescripcionEntry.Text) &&
                EstadoPicker.SelectedItem != null &&
                CategoriaPicker.SelectedItem != null)
            {
                string categoriaSeleccionada = CategoriaPicker.SelectedItem as string;
                string estadoSeleccionado = EstadoPicker.SelectedItem as string;

                Categoria categoriaObj = categoriaSeleccionada switch
                {
                    "Trabajo" => new CategoriaTrabajo(),
                    "Hogar" => new CategoriaHogar(),
                    "Personal" => new CategoriaPersonal(),
                    _ => new CategoriaPersonal()
                };

                Tareas nuevaTarea = new Tareas(
                    TituloEntry.Text,
                    DescripcionEntry.Text,
                    $"{FechaVencimientoPicker.Date:dd/MM/yyyy}",
                    estadoSeleccionado,
                    categoriaObj.MostrarCategoria()
                );

                tareas.Add(nuevaTarea);

                gestor.GuardarTareas(tareas.ToList());

                TituloEntry.Text = "";
                DescripcionEntry.Text = "";
                EstadoPicker.SelectedIndex = -1;
                CategoriaPicker.SelectedIndex = -1;
            }
        }

        private void OnEliminarTareaClicked(object sender, EventArgs e)
        {
            if (TareasListView.SelectedItem is Tareas tareaSeleccionada)
            {
                tareas.Remove(tareaSeleccionada);
                gestor.GuardarTareas(tareas.ToList());
            }
        }
    }
}