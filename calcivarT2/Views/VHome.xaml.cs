namespace calcivarT2.Views;

public partial class VHome : ContentPage
{
	public VHome()
	{
		InitializeComponent();
	}
    private async void OnCalcularClicked(object sender, EventArgs e)
    {
        if (double.TryParse(notaSeg1.Text, out double seguimiento1) && seguimiento1 >= 0.1 && seguimiento1 <= 10 &&
            double.TryParse(examen1.Text, out double ex1) && ex1 >= 0.1 && ex1 <= 10 &&
            double.TryParse(notaSeg2.Text, out double seguimiento2) && seguimiento2 >= 0.1 && seguimiento2 <= 10 &&
            double.TryParse(examen2.Text, out double ex2) && ex2 >= 0.1 && ex2 <= 10)
        {
            double notaParcial1 = seguimiento1 * 0.3 + ex1 * 0.2;
            double notaParcial2 = seguimiento2 * 0.3 + ex2 * 0.2;
            double notaFinal = notaParcial1 + notaParcial2;

            string estado;
            if (notaFinal >= 7)
                estado = "aprobado";
            else if (notaFinal >= 5 && notaFinal <= 6.9)
                estado = "complementario";
            else
                estado = "reprobado";

            await DisplayAlert("Resultados",
                $"Nombre: {pickerEstudiante.SelectedItem}\n" +
                $"Fecha: {fecha.Date.ToString("dd/MM/yyyy")}\n" +
                $"Nota Parcial 1: {notaParcial1:F2}\n" +
                $"Nota Parcial 2: {notaParcial2:F2}\n" +
                $"Nota Final: {notaFinal:F2}\n" +
                $"Estado: {estado}",
                "OK");
        }
        else
        {
            await DisplayAlert("Error", "Por favor, ingrese todas las notas en el rango de 0,1 a 10.", "OK");
        }
    }
}