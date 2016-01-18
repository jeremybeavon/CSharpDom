using CSharpDom.Common;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis.WithSyntax
{
    public interface INestedClassDeclarationSyntax :
        INestedClass<ITypeSyntax, IEventSyntax, IPropertySyntax, IIndexerSyntax, IMethodSyntax, IFieldSyntax, IConstructorSyntax, IEventPropertySyntax, IOperatorOverloadSyntax, IConversionOperatorSyntax, INestedClassSyntax, INestedDelegateSyntax, INestedEnumSyntax, INestedInterfaceSyntax, INestedStructSyntax, INestedDestructorSyntax>,
        ITypeSyntax,
        IHasDeclaration<ClassDeclarationSyntax>,
        IHasCompositeType<INestedClassSyntax>
    {
        void Accept(ISyntaxVisitor visitor);
    }
}
