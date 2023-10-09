namespace DapperMapping;

public class Product
{
    public long Id { get; set; }

    [NameAttribute("Nome")]
    public string Name { get; set; } = string.Empty;

    [NameAttribute("Descricao")]
    public string Description { get; set; } = string.Empty;
}
