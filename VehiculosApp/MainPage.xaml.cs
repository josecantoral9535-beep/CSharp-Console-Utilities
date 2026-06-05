using System;
using System.Collections.ObjectModel;

namespace VehiculosApp
{
    public partial class MainPage : ContentPage
    {
        private ObservableCollection<string> lista = new ObservableCollection<string>();

        public MainPage()
        {
            InitializeComponent();
            VehiculosList.ItemsSource = lista;
        }

        private void OnAgregarVehiculo(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(MarcaEntry.Text) &&
                !string.IsNullOrEmpty(ModeloEntry.Text) &&
                TipoVehiculoPicker.SelectedItem != null)
            {
                string tipo = TipoVehiculoPicker.SelectedItem as string;

                Vehiculo vehiculo = null;

                if (tipo == "Auto")
                    vehiculo = new Auto(MarcaEntry.Text, ModeloEntry.Text);
                else if (tipo == "Moto")
                    vehiculo = new Moto(MarcaEntry.Text, ModeloEntry.Text);
                else if (tipo == "Camión")
                    vehiculo = new Camion(MarcaEntry.Text, ModeloEntry.Text);

                if (vehiculo != null)
                {
                    lista.Add(vehiculo.MostrarInfo() + " - " + vehiculo.Encender());
                }

                MarcaEntry.Text = "";
                ModeloEntry.Text = "";
                TipoVehiculoPicker.SelectedIndex = -1;
            }
        }
    }
}