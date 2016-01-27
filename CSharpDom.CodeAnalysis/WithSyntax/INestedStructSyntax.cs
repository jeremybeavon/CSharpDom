using CSharpDom.Common;

namespace CSharpDom.CodeAnalysis.WithSyntax
{
    public interface INestedStructSyntax :
        INestedStruct<ITypeSyntax, IEventSyntax, IPropertySyntax, IIndexerSyntax, IMethodSyntax, IFieldSyntax, IConstructorSyntax, IEventPropertySyntax, IOperatorOverloadSyntax, IConversionOperatorSyntax, INestedClassSyntax, INestedDelegateSyntax, INestedEnumSyntax, INestedInterfaceSyntax, INestedStructSyntax>,
        ITypeSyntax,
        IHasDeclarations<INestedStructDeclarationSyntax>
    {
        void Accept(ISyntaxVisitor visitor);
    }
}
