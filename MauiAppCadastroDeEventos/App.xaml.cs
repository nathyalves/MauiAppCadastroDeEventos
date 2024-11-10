using MauiAppCadastroDeEventos.Views;
using Microsoft.Maui.Controls;

namespace MauiAppCadastroDeEventos
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            MainPage = new NavigationPage(new CadastroEventos());
        }
    }
}

