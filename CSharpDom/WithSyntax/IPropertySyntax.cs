using CSharpDom.Common;

namespace CSharpDom.WithSyntax
{
    public interface IPropertySyntax : IProperty, IHasDeclaringType<IBasicTypeSyntax>
    {
        void Accept(ISyntaxVisitor visitor);
    }
}
