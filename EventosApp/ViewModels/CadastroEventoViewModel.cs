using System.ComponentModel;
using System.Windows.Input;
using EventosApp.Models;

namespace EventosApp.ViewModels;

public class CadastroEventoViewModel : INotifyPropertyChanged
{
    public Evento Evento { get; set; } = new Evento
    {
        DataInicio = DateTime.Now,
        DataFim = DateTime.Now.AddDays(1),
        CustoPorPessoa = 0,
        NumeroParticipantes = 1
    };

    public ICommand CadastrarCommand { get; }

    public event PropertyChangedEventHandler PropertyChanged;

    public CadastroEventoViewModel()
    {
        CadastrarCommand = new Command(() =>
        {
            Application.Current.MainPage.Navigation.PushAsync(new Views.ResumoEventoPage(Evento));
        });
    }
}
