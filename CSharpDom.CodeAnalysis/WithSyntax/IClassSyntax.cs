using CSharpDom.Common;

namespace CSharpDom.CodeAnalysis.WithSyntax
{
    public interface IClassSyntax :
        IClass<INamespaceSyntax, IProjectSyntax, ISolutionSyntax, IEventSyntax, IPropertySyntax, IIndexerSyntax, IMethodSyntax, IFieldSyntax, IConstructorSyntax, IEventPropertySyntax, IOperatorOverloadSyntax, IConversionOperatorSyntax, INestedClassSyntax, INestedDelegateSyntax, INestedEnumSyntax, INestedInterfaceSyntax, INestedStructSyntax, IDestructorSyntax>,
        ITypeSyntax,
        IHasDeclarations<IClassDeclarationSyntax>
    {
        void Accept(ISyntaxVisitor visitor);
    }
}
