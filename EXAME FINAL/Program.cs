using System.Diagnostics;
using System.Linq.Expressions;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;

List<VeiculoPasseio> veiculoPasseios = new List<VeiculoPasseio> ();
List<VeiculoCarga> veiculoCargas = new List<VeiculoCarga>();
List<Cliente> clientes = new List<Cliente>();
List<Locacao> locacaos = new List<Locacao>();



Console.WriteLine("---MENU SISTEMA LOCAÇÃO---");

Console.WriteLine("1- Cadastrar Cliente.\n2-Cadastrar Veiculo de Passeio.\n3-Cadastrar Veiculo de Carga.\n4-Cadastrar Locação.\n5-Dados Locação.\n");
int menu;
menu = Convert.ToInt32(Console.ReadLine());

if (menu == 1)
{
    Cliente c1 = new Cliente();
    Console.WriteLine("infome o Nome do Cliente:");
    c1._nome = Console.ReadLine();
    Console.WriteLine("infome o CPF do Cliente:");
    c1._cpf = Console.ReadLine();
    if (c1._cpf.Length != 11)
    {
        throw new Exception("CPF INVALIDO");
    }
    Console.WriteLine("infome a CNH do Cliente:");
    c1._cnh = Console.ReadLine();
    Console.WriteLine("infome o telefone do Cliente:");
    c1._telefone = Console.ReadLine();
    Console.WriteLine("infome o E-mail do Cliente:");
    c1._email = Console.ReadLine();

    clientes.Add(c1);

}
else if (menu == 2)
{
    VeiculoPasseio vp1 = new VeiculoPasseio();
    Console.WriteLine("Informe a Placa do Veiculo:");
    vp1._placa = Console.ReadLine();
    Console.WriteLine("Informe o modelo do Veiculo:");
    vp1._modelo = Console.ReadLine();
    Console.WriteLine("Informe a marca do Veiculo:");
    vp1._marca = Console.ReadLine();
    Console.WriteLine("Informe o ano do Veiculo:");
    vp1._ano = Console.ReadLine();
    Console.WriteLine("Informe a categoria do Veiculo:");
    vp1._categoria = Console.ReadLine();
    Console.WriteLine("Informe o Valor da Diaria do Veiculo:");
    vp1._valorDiaria = Convert.ToInt32(Console.ReadLine());
    if (vp1._valorDiaria <= 0)
    {
        throw new Exception("Valor de Diaria Invalido");
    }
    Console.WriteLine("Informe o Status do Veiculo:");
    vp1._statusDisponivel = Console.ReadLine();
    Console.WriteLine("Informe o Tipo de Combustivel do Veiculo:");
    vp1._tipoCombustivel = Console.ReadLine();
    Console.WriteLine("Informe a Quantidade de Portas do Veiculo:");
    vp1._quantidadePortas = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Informe o câmbio do Veiculo:");
    vp1._tipoCambio = Console.ReadLine();

    veiculoPasseios.Add(vp1);

}
else if (menu == 3)
{
    VeiculoCarga vc1 = new VeiculoCarga();
    Console.WriteLine("Informe a Placa do Veiculo:");
    vc1._placa = Console.ReadLine();
    Console.WriteLine("Informe o modelo do Veiculo:");
    vc1._modelo = Console.ReadLine();
    Console.WriteLine("Informe a marca do Veiculo:");
    vc1._marca = Console.ReadLine();
    Console.WriteLine("Informe o ano do Veiculo:");
    vc1._ano = Console.ReadLine();
    Console.WriteLine("Informe a categoria do Veiculo:");
    vc1._categoria = Console.ReadLine();
    Console.WriteLine("Informe o Valor da Diaria do Veiculo:");
    vc1._valorDiaria = Convert.ToInt32(Console.ReadLine());
    if (vc1._valorDiaria <= 0)
    {
        throw new Exception("Valor de Diaria Invalido");
    }
    Console.WriteLine("Informe o Status do Veiculo:");
    vc1._statusDisponivel = Console.ReadLine();
    Console.WriteLine("Informe o Tipo de Combustivel do Veiculo:");
    vc1._tipoCombustivel = Console.ReadLine();
    Console.WriteLine("Informe a Capacidade de Carga em kgs Portas do Veiculo:");
    vc1._CapacidadeCargaKg = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Informe a quantia de Eixos do Veiculo:");
    vc1._numeroEixos = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Informe se tem bau fechado no Veiculo:");
    vc1._PossuiBauFechado = Console.ReadLine();


    veiculoCargas.Add(vc1);
}
else if (menu == 4)
{

    

}

else if (menu == 5)
{

}

