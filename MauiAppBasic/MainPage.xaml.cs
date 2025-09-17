namespace MauiAppBasic
{
    public partial class MainPage : ContentPage
    {
        //Inserindo nome
        string nome = "";

        public MainPage()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            try
            {
                nome = await DisplayPromptAsync("Olá!" , "Digite seu nome: ");
                //Criando um simples botão
                await DisplayAlert("", "Olá, " + nome + "!" , "Ok");
            }
            catch (Exception ex)
            {
                await DisplayAlert("Aviso!", ex.Message, "Ok");
            }
        }
    }
}
