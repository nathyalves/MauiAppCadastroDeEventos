using Microsoft.Maui.Controls;

namespace MauiAppCadastroDeEventos.Views
{
    public partial class EventoContratado : ContentPage
    {
        public EventoContratado(Evento evento)
        {
            InitializeComponent();
            BindingContext = evento;
        }

        private async void OnBackButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}
