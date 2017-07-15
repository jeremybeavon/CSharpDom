using CSharpDom.Common;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis
{
    public interface IAbstractTypeWithCodeAnalysis :
        IAbstractType<
            AttributeGroupWithCodeAnalysis,
            GenericParameterDeclarationWithCodeAnalysis,
            ClassReferenceWithCodeAnalysis,
            InterfaceReferenceWithCodeAnalysis,
            AbstractClassEventCollectionWithCodeAnalysis,
            AbstractClassPropertyCollectionWithCodeAnalysis,
            AbstractClassIndexerCollectionWithCodeAnalysis,
            AbstractClassMethodCollectionWithCodeAnalysis,
            AbstractClassFieldCollectionWithCodeAnalysis,
            AbstractClassConstructorWithCodeAnalysis,
            OperatorOverloadWithCodeAnalysis,
            ConversionOperatorWithCodeAnalysis,
            AbstractClassNestedClassCollectionWithCodeAnalysis,
            AbstractClassNestedDelegateWithCodeAnalysis,
            AbstractClassNestedEnumWithCodeAnalysis,
            AbstractClassNestedInterfaceWithCodeAnalysis,
            AbstractClassNestedStructCollectionWithCodeAnalysis,
            StaticConstructorWithCodeAnalysis>,
        IHasSyntax<ClassDeclarationSyntax>
    {
    }
}
