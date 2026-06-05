namespace VehiculosApp
{
    public class Moto : Vehiculo
    {
        public Moto(string marca, string modelo) : base(marca, modelo) { }

        public override string MostrarInfo()
        {
            return $"Moto: {Marca} {Modelo}";
        }

        public override string Encender()
        {
            return "La moto encendió con botón 🏍️";
        }
    }
}