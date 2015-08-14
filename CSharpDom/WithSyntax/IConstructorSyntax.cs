using CSharpDom.Common;

namespace CSharpDom.WithSyntax
{
    public interface IConstructorSyntax : IConstructor, IHasDeclaringType<ITypeSyntax>
    {
        void Accept(ISyntaxVisitor visitor);
    }
}
