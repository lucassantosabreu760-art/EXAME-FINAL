public class VeiculoCarga : Veiculo
{
    public double _CapacidadeCargaKg;
    public int _numeroEixos;
    public string _PossuiBauFechado;

    public double CalcularValorDiaria()
    {
        _valorDiaria = _valorDiaria + (_valorDiaria * 0.2);
        return _valorDiaria;
    }

}