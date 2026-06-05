namespace Calculadora_Propinas;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    private void CalcularTodo(object sender, EventArgs e)
    {
        // Verifica que el usuario haya escrito algo válido
        if (double.TryParse(txtCuenta.Text, out double cuenta))
        {
            // Valores Controles
            double porcentajePropina = stpPropina.Value;
            int numPersonas = (int)stpPersonas.Value;

            // Etiquetas visuales
            lblPropina.Text = $"{porcentajePropina}%";
            lblPersonas.Text = numPersonas.ToString();

            // Calcula la propina y el total
            double montoPropina = cuenta * (porcentajePropina / 100);
            double totalFinal = (cuenta + montoPropina) / numPersonas;

            // 3. Aplica el redondeo si el Switch está activo
            if (swRedondeo.IsToggled)
            {
                totalFinal = Math.Round(totalFinal);
            }

            // Muestra el resultado
            lblTotal.Text = $"Total por Persona: {totalFinal:C}";
        }
        else
        {
            lblTotal.Text = "Esperando monto...";
        }
    }
}
