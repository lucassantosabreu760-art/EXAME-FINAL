using System.Globalization;
using System.Reflection.Metadata;

public class Cliente
{
    public int _id;
    public string _nome;
    public string _cpf;
    public string _cnh;
    public string _telefone;
    public string _email;

    public Cliente()
    {

    }

    public Cliente(string nome, string cpf, string cnh, string telefone, string email)
    {
        _cnh = cnh;
        _telefone = telefone;
        _email = email;
        _nome = nome;


    }




}