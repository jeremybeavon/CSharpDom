using CSharpDom.Common;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis.Partial
{
    public interface IPartialClassTypeWithCodeAnalysis :
        IClassType<
            AttributeGroupWithCodeAnalysis,
            GenericParameterDeclarationWithCodeAnalysis,
            ClassReferenceWithCodeAnalysis,
            InterfaceReferenceWithCodeAnalysis,
            ClassEventCollectionWithCodeAnalysis,
            ClassPropertyCollectionWithCodeAnalysis,
            ClassIndexerCollectionWithCodeAnalysis,
            PartialClassMethodCollectionWithCodeAnalysis,
            ClassFieldCollectionWithCodeAnalysis,
            ClassConstructorWithCodeAnalysis,
            OperatorOverloadWithCodeAnalysis,
            ConversionOperatorWithCodeAnalysis,
            ClassNestedClassCollectionWithCodeAnalysis,
            ClassNestedDelegateWithCodeAnalysis,
            ClassNestedEnumWithCodeAnalysis,
            ClassNestedInterfaceCollectionWithCodeAnalysis,
            ClassNestedStructCollectionWithCodeAnalysis,
            StaticConstructorWithCodeAnalysis,
            DestructorWithCodeAnalysis>,
        IHasSyntax<ClassDeclarationSyntax>
    {
    }
}
