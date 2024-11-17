using EventosApp.Models;

namespace EventosApp.ViewModels;

public class ResumoEventoViewModel
{
    public Evento Evento { get; }

    public ResumoEventoViewModel(Evento evento)
    {
        Evento = evento;
    }

    public decimal CustoTotal => Evento.CalcularCustoTotal();
    public int Duracao => Evento.CalcularDuracao();
}
