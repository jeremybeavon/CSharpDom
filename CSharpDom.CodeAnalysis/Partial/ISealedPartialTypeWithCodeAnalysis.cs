using CSharpDom.Common;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis.Partial
{
    public interface ISealedPartialTypeWithCodeAnalysis :
        ISealedType<
            AttributeGroupWithCodeAnalysis,
            GenericParameterDeclarationWithCodeAnalysis,
            ClassReferenceWithCodeAnalysis,
            InterfaceReferenceWithCodeAnalysis,
            SealedClassEventCollectionWithCodeAnalysis,
            SealedClassPropertyCollectionWithCodeAnalysis,
            SealedClassIndexerCollectionWithCodeAnalysis,
            SealedPartialClassMethodCollectionWithCodeAnalysis,
            SealedClassFieldCollectionWithCodeAnalysis,
            SealedClassConstructorWithCodeAnalysis,
            OperatorOverloadWithCodeAnalysis,
            ConversionOperatorWithCodeAnalysis,
            SealedClassNestedClassCollectionWithCodeAnalysis,
            SealedClassNestedDelegateWithCodeAnalysis,
            SealedClassNestedEnumWithCodeAnalysis,
            SealedClassNestedInterfaceWithCodeAnalysis,
            SealedClassNestedStructCollectionWithCodeAnalysis,
            StaticConstructorWithCodeAnalysis>,
        IHasSyntax<ClassDeclarationSyntax>
    {
    }
}
