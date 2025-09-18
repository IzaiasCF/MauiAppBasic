namespace MauiAppBasic
{
    public partial class MainPage : TabbedPage
    {
        //Inserindo nome
        string nome = "";

        public MainPage()
        {
            InitializeComponent();

            string endereco = @"<iframe width=""560"" height=""315"" src=""https://www.youtube.com/embed/DeQ9CgfPgtI?si=Dp7yvY4Dsgoeu-zm"" title=""YouTube video player"" frameborder=""0"" allow=""accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture; web-share"" referrerpolicy=""strict-origin-when-cross-origin"" allowfullscreen></iframe>";
            ICFvideos.Source = new HtmlWebViewSource
                {
                    Html = endereco
                };
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
