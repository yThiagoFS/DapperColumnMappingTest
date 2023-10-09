using Dapper;
using static Dapper.SqlMapper;

namespace DapperMapping
{
    public static class MappingByAttribute<T>
    {
        public static ITypeMap Map()
        {
            return new CustomPropertyTypeMap(
                typeof(T),
                (type, columnName) =>
                {
                    var propriedades = type.GetProperties();
                    var propriedade = propriedades.FirstOrDefault(prop =>
                            prop.GetCustomAttributes(false)
                                .OfType<NameAttribute>()
                                .Any(attr => attr.Name == columnName));

                    return propriedade ?? propriedades.FirstOrDefault(prop => prop.Name == columnName)!;
                });
        }
    }
}
