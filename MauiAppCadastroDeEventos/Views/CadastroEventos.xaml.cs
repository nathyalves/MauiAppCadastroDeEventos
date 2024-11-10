using MauiAppCadastroDeEventos.Views;
using Microsoft.Maui.Controls;
using System;

namespace MauiAppCadastroDeEventos.Views
{
    public partial class CadastroEventos : ContentPage
    {
        private Evento evento;

        public CadastroEventos()
        {
            InitializeComponent();
            evento = new Evento();
            BindingContext = evento;
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            // Aqui, removemos a atribui��o manual ao 'evento' e permitimos que o binding fa�a o trabalho
            evento.Nome = NomeEventoEntry.Text;
            evento.Local = LocalEventoEntry.Text;
            evento.DataInicio = dtpck_inicio.Date;
            evento.DataTermino = dtpck_termino.Date;
            evento.NumeroParticipantes = (int)stp_participantes.Value;
            evento.CustoPorParticipante = decimal.TryParse(CustoEntry.Text, out var custo) ? custo : 0;

            // Calculando a dura��o do evento em dias
            evento.Duracao = (evento.DataTermino - evento.DataInicio).Days;

            // Navegar para a pr�xima p�gina
            await Navigation.PushAsync(new EventoContratado(evento));
        }

        // M�todo do evento DateSelected para o DatePicker
        private void dtpck_inicio_DateSelected(object sender, DateChangedEventArgs e)
        {
            // L�gica para tratar a data selecionada
            // Exemplo: atualizar a DataInicio do evento
            evento.DataInicio = e.NewDate;
        }
    }
}
