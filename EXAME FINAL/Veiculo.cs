public class Veiculo
{
    public string _placa;
    public string _modelo;
    public string _marca;
    public string _ano;
    public string _categoria;
    public double _valorDiaria;
    public string _statusDisponivel;
    public string _tipoCombustivel;


    public double CalcularValorDiaria()
    {
        return _valorDiaria;
    }
}