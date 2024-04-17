using OMG.Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OMG.Domain.ValueObjects;

public class Endereco : ValueObject
{
    public Endereco(string rua, string numero, string bairro, string cidade, string estado, string cep, string complemento = "")
    {
        Rua = rua;
        Numero = numero;
        Bairro = bairro;
        Complemento = complemento;
        Cidade = cidade;
        Estado = estado;
        CEP = cep;
    }

    public string Rua { get; }
    public string Numero { get; }
    public string Bairro { get; set; }
    public string Complemento { get; }
    public string Cidade { get; }
    public string Estado { get; }
    public string CEP { get; }

    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Rua;
        yield return Numero;
        yield return Bairro;
        yield return Complemento;
        yield return Cidade;
        yield return Estado;
        yield return CEP;
    }

    public override string ToString()
    {
        return $"{Rua}, nº {Numero}, {Bairro}, {Cidade}, {Estado}, CEP: {CEP} ";
    }
}

