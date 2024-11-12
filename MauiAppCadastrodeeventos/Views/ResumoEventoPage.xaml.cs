using MauiAppCadastrodeeventos.Models;

namespace MauiAppCadastrodeeventos.Views
{
    public partial class ResumoEventoPage : ContentPage
    {
        public ResumoEventoPage(Evento evento)
        {
            InitializeComponent();
            BindingContext = evento; // Define o contexto de dados para a página
        }
    }
}