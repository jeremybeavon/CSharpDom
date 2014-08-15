using CSharpDom.Common;

namespace CSharpDom.WithSyntax
{
    public interface IFieldSyntax : IField, IHasDeclaringType<ITypeSyntax>
    {
        void Accept(ISyntaxVisitor visitor);
    }
}
