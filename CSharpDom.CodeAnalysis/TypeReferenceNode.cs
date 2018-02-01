using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis
{
    internal sealed class TypeReferenceNode<TValue, TSyntax> : AbstractChildNode<TValue, TypeSyntax, TSyntax>
        where TValue : IInternalTypeReferenceWithCodeAnalysis
        where TSyntax : TypeSyntax
    {
        public TypeReferenceNode(TValue value)
            : base(value)
        {
        }
    }
}
