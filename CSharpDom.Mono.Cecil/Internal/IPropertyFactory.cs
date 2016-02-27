using System.Reflection;

namespace CSharpDom.Mono.Cecil.Internal
{
    internal interface IPropertyFactory<TProperty, TIndexer, TType>
        where TType : ITypeWithMonoCecil
    {
        TProperty CreateProperty(TType declaringType, PropertyInfo property);

        TIndexer CreateIndexer(TType declaringType, PropertyInfo property);
    }
}
