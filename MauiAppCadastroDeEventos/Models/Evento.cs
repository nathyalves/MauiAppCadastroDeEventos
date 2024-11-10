public class Evento
{
    public string Nome { get; set; }
    public DateTime DataInicio { get; set; } = DateTime.Now;
    public DateTime DataTermino { get; set; } = DateTime.Now.AddDays(1);
    public int NumeroParticipantes { get; set; }
    public string Local { get; set; }
    public decimal CustoPorParticipante { get; set; }

    // Propriedade para o custo total
    public decimal CustoTotal => NumeroParticipantes * CustoPorParticipante;

    // Nova propriedade para armazenar a duração
    public int Duracao { get; set; }

    public Evento() { }
}
