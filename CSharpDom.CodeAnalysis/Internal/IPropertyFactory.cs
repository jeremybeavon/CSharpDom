using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Reflection;

namespace CSharpDom.CodeAnalysis.Internal
{
    internal interface IPropertyFactory<TProperty, TIndexer, TType>
        where TType : ITypeWithCodeAnalysis
    {
        TProperty CreateProperty(TType declaringType, PropertyDefinition property);

        TIndexer CreateIndexer(TType declaringType, PropertyDefinition property);
    }
}
