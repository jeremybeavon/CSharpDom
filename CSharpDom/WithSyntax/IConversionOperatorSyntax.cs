using CSharpDom.Common;

namespace CSharpDom.WithSyntax
{
    public interface IConversionOperatorSyntax : IConversionOperator, IHasDeclaringType<ITypeSyntax>
    {
        void Accept(ISyntaxVisitor visitor);
    }
}
