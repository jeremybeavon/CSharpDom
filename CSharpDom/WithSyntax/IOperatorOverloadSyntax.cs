using CSharpDom.Common;

namespace CSharpDom.WithSyntax
{
    public interface IOperatorOverloadSyntax : IOperatorOverload, IHasDeclaringType<ITypeSyntax>
    {
        void Accept(ISyntaxVisitor visitor);
    }
}
