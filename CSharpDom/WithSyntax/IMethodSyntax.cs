using CSharpDom.Common;

namespace CSharpDom.WithSyntax
{
    public interface IMethodSyntax : IMethod, IHasDeclaringType<IBasicTypeSyntax>
    {
        void Accept(ISyntaxVisitor visitor);
    }
}
