using System.Threading.Tasks;
using System.ComponentModel;
using System.Windows.Input;
using MauiAppCadastrodeeventos.Models; // Certifique-se de que a Model Evento está no namespace correto
using MauiAppCadastrodeeventos.Views;

namespace MauiAppCadastrodeeventos.ViewModels
{
    public class CadastroEventoViewModel : INotifyPropertyChanged
    {
        // Propriedade do Evento que será usada no Binding
        public Evento Evento { get; set; }

        // Comando para Cadastrar o Evento
        public ICommand CadastrarCommand { get; }

        public event PropertyChangedEventHandler PropertyChanged;

        public CadastroEventoViewModel()
        {
            // Inicializa o objeto Evento com datas padrão
            Evento = new Evento
            {
                DataInicio = DateTime.Today, // Data de Início padrão para hoje
                DataTermino = DateTime.Today.AddDays(1) // Data de Término padrão para amanhã
            };

            // Comando vinculado ao botão "Cadastrar"
            CadastrarCommand = new Command(CadastrarEvento, CanExecuteCadastrar);
        }

        private async void CadastrarEvento()
        {
            // Navega para a página ResumoEventoPage com os dados preenchidos
            await Application.Current.MainPage.Navigation.PushAsync(new ResumoEventoPage(Evento));
        }

        private bool CanExecuteCadastrar()
        {
            // Valida se a Data de Término é posterior à Data de Início
            return Evento.DataInicio < Evento.DataTermino;
        }

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
            (CadastrarCommand as Command)?.ChangeCanExecute(); // Atualiza a validação do comando
        }
    }
}