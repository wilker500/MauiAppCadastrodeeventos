namespace MauiAppCadastrodeeventos.Views
{
    public partial class CadastroEventoPage : ContentPage
    {
        public CadastroEventoPage()
        {
            InitializeComponent();
            // Inicializa as datas padrão
            dtpck_inicio.MinimumDate = DateTime.Today; // Data mínima para hoje
            dtpck_inicio.Date = DateTime.Today;

            dtpck_termino.MinimumDate = DateTime.Today.AddDays(1); // Término no mínimo 1 dia após hoje
            dtpck_termino.Date = DateTime.Today.AddDays(1);
        }

        private void dtpck_inicio_DateSelected(object sender, DateChangedEventArgs e)
        {
            // Atualiza o MinimumDate do DatePicker de Término com base na nova Data de Início
            dtpck_termino.MinimumDate = e.NewDate.AddDays(1);

            // Ajusta automaticamente a Data de Término se estiver inválida
            if (dtpck_termino.Date <= e.NewDate)
            {
                dtpck_termino.Date = e.NewDate.AddDays(1);
            }
        }
    }

}