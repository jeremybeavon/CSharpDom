using CSharpDom.Common;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis.WithSyntax
{
    public interface IClassDeclarationSyntax :
        IClass<INamespaceSyntax, IProjectSyntax, ISolutionSyntax, IEventSyntax, IPropertySyntax, IIndexerSyntax, IMethodSyntax, IFieldSyntax, IConstructorSyntax, IEventPropertySyntax, IOperatorOverloadSyntax, IConversionOperatorSyntax, INestedClassSyntax, INestedDelegateSyntax, INestedEnumSyntax, INestedInterfaceSyntax, INestedStructSyntax, IDestructorSyntax>,
        IHasLocation,
        IHasDeclaration<ClassDeclarationSyntax>,
        IHasCompositeType<IClassSyntax>,
        IHasDocument<IDocumentSyntax>,
        IHasProject<IProjectSyntax>,
        IHasSolution<ISolutionSyntax>,
        ITypeSyntax,
        IHasDestructor<IDestructorSyntax>
    {
        void Accept(ISyntaxVisitor visitor);
    }
}
