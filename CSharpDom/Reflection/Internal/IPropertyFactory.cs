using System.Reflection;

namespace CSharpDom.Reflection.Internal
{
    internal interface IPropertyFactory<TProperty, TIndexer, TType>
        where TType : ITypeWithReflection
    {
        TProperty CreateProperty(TType declaringType, PropertyInfo property);

        TIndexer CreateIndexer(TType declaringType, PropertyInfo property);
    }
}
