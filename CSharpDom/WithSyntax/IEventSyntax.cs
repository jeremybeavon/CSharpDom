using CSharpDom.Common;

namespace CSharpDom.WithSyntax
{
    public interface IEventSyntax : IEvent, IHasDeclaringType<IBasicTypeSyntax>
    {
        void Accept(ISyntaxVisitor visitor);
    }
}
