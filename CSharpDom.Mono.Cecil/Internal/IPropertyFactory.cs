using Mono.Cecil;
using System.Reflection;

namespace CSharpDom.Mono.Cecil.Internal
{
    internal interface IPropertyFactory<TProperty, TIndexer, TType>
        where TType : ITypeWithMonoCecil
    {
        TProperty CreateProperty(TType declaringType, PropertyDefinition property);

        TIndexer CreateIndexer(TType declaringType, PropertyDefinition property);
    }
}
