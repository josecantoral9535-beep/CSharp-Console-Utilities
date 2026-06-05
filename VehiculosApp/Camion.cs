namespace VehiculosApp
{
    public class Camion : Vehiculo
    {
        public Camion(string marca, string modelo) : base(marca, modelo) { }

        public override string MostrarInfo()
        {
            return $"Camión: {Marca} {Modelo}";
        }

        public override string Encender()
        {
            return "El camión encendió con sistema pesado 🚚";
        }
    }
}