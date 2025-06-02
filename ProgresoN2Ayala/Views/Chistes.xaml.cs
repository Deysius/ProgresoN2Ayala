using ProgresoN2Ayala.Repository;

namespace ProgresoN2Ayala.Views;

public partial class Chistes : ContentPage
{
    private readonly ChisteRepository _chistesRepository;

    public Chistes()
    {
        InitializeComponent();
        _chistesRepository = new ChisteRepository();
        CargarChiste();
    }

    private async void CargarChiste()
    {
        try
        {
            var chiste = await _chistesRepository.GetChisteAsync();
            ChisteLabel.Text = chiste;
        }
        catch
        {
            ChisteLabel.Text = "Error al cargar el chiste";
        }
    }

    private void OnOtroChisteClicked(object sender, EventArgs e)
    {
        CargarChiste();
    }
}