using Microsoft.CodeAnalysis.CSharp.Syntax;
using CSharpDom.Common;

namespace CSharpDom.CodeAnalysis.WithSyntax
{
    public interface IStructDeclarationSyntax :
        IStruct<INamespaceSyntax, IProjectSyntax, ISolutionSyntax, IEventSyntax, IPropertySyntax, IIndexerSyntax, IMethodSyntax, IFieldSyntax, IConstructorSyntax, IEventPropertySyntax, IOperatorOverloadSyntax, IConversionOperatorSyntax, INestedClassSyntax, INestedDelegateSyntax, INestedEnumSyntax, INestedInterfaceSyntax, INestedStructSyntax>,
        IHasLocation,
        IHasDeclaration<StructDeclarationSyntax>,
        IHasCompositeType<IStructSyntax>,
        IHasDocument<IDocumentSyntax>,
        ITypeSyntax
    {
        void Accept(ISyntaxVisitor visitor);
    }
}
