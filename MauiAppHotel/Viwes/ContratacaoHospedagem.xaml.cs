namespace MauiAppHotel.Viwes;

public partial class ContratacaoHospedagem : ContentPage
{
	public ContratacaoHospedagem()
	{
		InitializeComponent();
	}

	// Adicione este m�todo ao code-behind para navega��o
	private async void OnSobreClicked(object sender, EventArgs e)
	{
		await Navigation.PushAsync(new Sobre());
	}
}