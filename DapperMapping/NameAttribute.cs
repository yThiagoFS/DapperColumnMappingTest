namespace DapperMapping
{
    public class NameAttribute : Attribute
    {
        public NameAttribute(string propertyMappingName) => Name = propertyMappingName;

        public string Name { get; } = string.Empty;
    }
}
