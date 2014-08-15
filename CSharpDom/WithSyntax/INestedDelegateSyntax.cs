using CSharpDom.Common;

namespace CSharpDom.WithSyntax
{
    public interface INestedDelegateSyntax : IDelegate, IHasDeclaringType<ITypeSyntax>
    {
        void Accept(ISyntaxVisitor visitor);
    }
}
