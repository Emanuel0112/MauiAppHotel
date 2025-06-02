namespace MauiAppHotel.Viwes;

public partial class ContratacaoHospedagem : ContentPage
{
	public ContratacaoHospedagem()
	{
		InitializeComponent();
	}

	// Adicione este método ao code-behind para navegação
	private async void OnSobreClicked(object sender, EventArgs e)
	{
		await Navigation.PushAsync(new Sobre());
	}
}