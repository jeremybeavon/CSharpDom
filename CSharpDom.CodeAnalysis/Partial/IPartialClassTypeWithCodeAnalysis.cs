using CSharpDom.Common;
using CSharpDom.Common.Editable;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis.Partial
{
    public interface IPartialClassTypeWithCodeAnalysis :
        IEditableClassType,
        IClassTypeDefinitionWithCodeAnalysis,
        IClassType<
            AttributeGroupWithCodeAnalysis,
            GenericParameterDeclarationWithCodeAnalysis,
            ClassReferenceWithCodeAnalysis,
            InterfaceReferenceWithCodeAnalysis,
            PartialClassEventCollectionWithCodeAnalysis,
            PartialClassPropertyCollectionWithCodeAnalysis,
            PartialClassIndexerCollectionWithCodeAnalysis,
            PartialClassMethodCollectionWithCodeAnalysis,
            PartialClassFieldCollectionWithCodeAnalysis,
            PartialClassConstructorWithCodeAnalysis,
            PartialClassOperatorOverloadWithCodeAnalysis,
            PartialClassConversionOperatorWithCodeAnalysis,
            PartialClassNestedClassCollectionWithCodeAnalysis,
            PartialClassNestedDelegateWithCodeAnalysis,
            PartialClassNestedEnumWithCodeAnalysis,
            PartialClassNestedInterfaceWithCodeAnalysis,
            PartialClassNestedStructCollectionWithCodeAnalysis,
            PartialClassStaticConstructorWithCodeAnalysis,
            PartialClassDestructorWithCodeAnalysis>,
        IHasSyntax<ClassDeclarationSyntax>
    {
        IClassTypeWithCodeAnalysis Class { get; }
    }
}
