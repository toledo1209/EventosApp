namespace EventosApp.Models;

public class Evento
{
    public string Nome { get; set; }
    public DateTime DataInicio { get; set; }
    public DateTime DataFim { get; set; }
    public int NumeroParticipantes { get; set; }
    public decimal CustoPorPessoa { get; set; }

    public decimal CalcularCustoTotal()
    {
        return NumeroParticipantes * CustoPorPessoa;
    }

    public int CalcularDuracao()
    {
        return (int)(DataFim - DataInicio).TotalDays + 1;
    }
}
