using CSharpDom.Common;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis.WithSyntax
{
    public interface INestedStructDeclarationSyntax : 
        INestedStruct<ITypeSyntax, IEventSyntax, IPropertySyntax, IIndexerSyntax, IMethodSyntax, IFieldSyntax, IConstructorSyntax, IEventPropertySyntax, IOperatorOverloadSyntax, IConversionOperatorSyntax, INestedClassSyntax, INestedDelegateSyntax, INestedEnumSyntax, INestedInterfaceSyntax, INestedStructSyntax>,
        ITypeSyntax,
        IHasLocation,
        IHasDeclaration<StructDeclarationSyntax>,
        IHasCompositeType<INestedStructSyntax>
    {
        void Accept(ISyntaxVisitor visitor);
    }
}
