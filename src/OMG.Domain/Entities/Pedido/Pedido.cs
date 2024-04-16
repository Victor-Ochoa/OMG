using OMG.Domain.Base;

namespace OMG.Domain.Entities.Pedido;
public class Pedido : Entity
{
    public required Cliente Cliente { get; set; }
    public required DateOnly DataEntrega { get; set; }
    public required ICollection<Item> Items { get; set; } = [];
    public float Desconto { get; set; } = 0f;

    public float ValorTotal() => Items.Sum(x => x.Produto.Valor * x.Quantidade) - Desconto;
}

