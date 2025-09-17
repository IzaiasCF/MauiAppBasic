namespace MauiAppBasic
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            try
            {
                //Criando um simples botão
                await DisplayAlert("Aviso!", "Olá, mundo!", "Ok");
            }
            catch (Exception ex)
            {
                await DisplayAlert("Aviso!", ex.Message, "Ok");
            }
        }
    }
}
