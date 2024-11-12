namespace MauiAppCadastrodeeventos.Views
{
    public partial class CadastroEventoPage : ContentPage
    {
        public CadastroEventoPage()
        {
            InitializeComponent();
            // Inicializa as datas padr�o
            dtpck_inicio.MinimumDate = DateTime.Today; // Data m�nima para hoje
            dtpck_inicio.Date = DateTime.Today;

            dtpck_termino.MinimumDate = DateTime.Today.AddDays(1); // T�rmino no m�nimo 1 dia ap�s hoje
            dtpck_termino.Date = DateTime.Today.AddDays(1);
        }

        private void dtpck_inicio_DateSelected(object sender, DateChangedEventArgs e)
        {
            // Atualiza o MinimumDate do DatePicker de T�rmino com base na nova Data de In�cio
            dtpck_termino.MinimumDate = e.NewDate.AddDays(1);

            // Ajusta automaticamente a Data de T�rmino se estiver inv�lida
            if (dtpck_termino.Date <= e.NewDate)
            {
                dtpck_termino.Date = e.NewDate.AddDays(1);
            }
        }
    }

}