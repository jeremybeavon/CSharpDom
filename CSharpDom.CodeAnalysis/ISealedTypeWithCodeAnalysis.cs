using CSharpDom.Common;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis
{
    public interface ISealedTypeWithCodeAnalysis :
        ISealedType<
            AttributeGroupWithCodeAnalysis,
            GenericParameterDeclarationWithCodeAnalysis,
            ClassReferenceWithCodeAnalysis,
            InterfaceReferenceWithCodeAnalysis,
            SealedClassEventCollectionWithCodeAnalysis,
            SealedClassPropertyCollectionWithCodeAnalysis,
            SealedClassIndexerCollectionWithCodeAnalysis,
            SealedClassMethodCollectionWithCodeAnalysis,
            ClassFieldCollectionWithCodeAnalysis,
            ClassConstructorWithCodeAnalysis,
            OperatorOverloadWithCodeAnalysis,
            ConversionOperatorWithCodeAnalysis,
            ClassNestedClassCollectionWithCodeAnalysis,
            ClassNestedDelegateWithCodeAnalysis,
            ClassNestedEnumWithCodeAnalysis,
            ClassNestedInterfaceCollectionWithCodeAnalysis,
            ClassNestedStructCollectionWithCodeAnalysis,
            StaticConstructorWithCodeAnalysis>,
        IHasSyntax<ClassDeclarationSyntax>
    {
    }
}
