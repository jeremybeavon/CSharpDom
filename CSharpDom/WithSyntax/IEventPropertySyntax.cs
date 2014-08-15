using CSharpDom.Common;

namespace CSharpDom.WithSyntax
{
    public interface IEventPropertySyntax : IEventProperty, IHasDeclaringType<ITypeSyntax>
    {
        void Accept(ISyntaxVisitor visitor);
    }
}
