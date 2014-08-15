using CSharpDom.Common;

namespace CSharpDom.WithSyntax
{
    public interface INamespaceSyntax : INamespace,
        IHasClasses<IClassSyntax>,
        IHasDelegates<IDelegateSyntax>,
        IHasEnums<IEnumSyntax>,
        IHasInterfaces<IInterfaceSyntax>,
        IHasStructs<IStructSyntax>
    {
        void Accept(ISyntaxVisitor visitor);
    }
}
