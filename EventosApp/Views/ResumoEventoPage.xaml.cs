using EventosApp.Models;
using EventosApp.ViewModels;

namespace EventosApp.Views;

public partial class ResumoEventoPage : ContentPage
{
    public ResumoEventoPage(Evento evento)
    {
        InitializeComponent();
        BindingContext = new ResumoEventoViewModel(evento);
    }
}
