using CSharpDom.Common;

namespace CSharpDom.CodeAnalysis.WithSyntax
{
    public interface INestedClassSyntax :
        INestedClass<ITypeSyntax, IEventSyntax, IPropertySyntax, IIndexerSyntax, IMethodSyntax, IFieldSyntax, IConstructorSyntax, IEventPropertySyntax, IOperatorOverloadSyntax, IConversionOperatorSyntax, INestedClassSyntax, INestedDelegateSyntax, INestedEnumSyntax, INestedInterfaceSyntax, INestedStructSyntax, INestedDestructorSyntax>,
        ITypeSyntax,
        IHasDeclarations<INestedClassDeclarationSyntax>
    {
        void Accept(ISyntaxVisitor visitor);
    }
}
