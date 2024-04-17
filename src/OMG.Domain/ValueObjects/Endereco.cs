using OMG.Domain.Base;

namespace OMG.Domain.ValueObjects;

public class Endereco(string rua, string numero, string bairro, string cidade, string estado, string cep, string complemento = "") : ValueObject
{
    public string Rua { get; } = rua;
    public string Numero { get; } = numero;
    public string Bairro { get; set; } = bairro;
    public string Complemento { get; } = complemento;
    public string Cidade { get; } = cidade;
    public string Estado { get; } = estado;
    public string CEP { get; } = cep;

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

    public override string ToString() => $"{Rua}, nº {Numero}, {Bairro}, {Cidade}, {Estado}, CEP: {CEP} ";
}

