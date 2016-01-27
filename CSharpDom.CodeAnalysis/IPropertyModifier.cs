using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis
{
    internal interface IPropertyModifier<TProperty> : IMemberModifier<TProperty>
    {
        TProperty WithAccessors(TProperty property, AccessorListSyntax accessors);
    }
}
