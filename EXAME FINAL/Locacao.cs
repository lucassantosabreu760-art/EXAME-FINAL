public class Locacao
{
    public string _dataInicio;
    public string _dataFim;
    public double _valorTotal;
    public string _status;
    public DateTime _diasLocados;

    public Locacao(string dataInicio, string dataFim, double valorTotal, string status, DateTime diasLocados)
    {
        _dataFim = dataFim;
        _valorTotal = valorTotal;   
        _status = status;
        _dataInicio = dataInicio;
        _diasLocados = diasLocados;
    }

}