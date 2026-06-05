namespace VehiculosApp
{
    public class Auto : Vehiculo
    {
        public Auto(string marca, string modelo) : base(marca, modelo) { }

        public override string MostrarInfo()
        {
            return $"Auto: {Marca} {Modelo}";
        }

        public override string Encender()
        {
            return "El auto encendió con llave 🔑";
        }
    }
}