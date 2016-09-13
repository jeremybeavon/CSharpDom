using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis
{
    internal interface IInternalTypeReferenceWithCodeAnalysis : ITypeReferenceWithCodeAnalysis, IHasId, IHasNode<TypeSyntax>
    {
    }
}
