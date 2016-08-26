using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis
{
    internal interface IAttributeCollection : IChildCollection<AttributeGroupWithCodeAnalysis, AttributeListSyntax>
    {
    }
}
