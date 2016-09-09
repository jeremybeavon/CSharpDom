using CSharpDom.Common;

namespace CSharpDom.CodeAnalysis
{
    public interface IStructTypeWithCodeAnalysis :
        IStructType<
            AttributeGroupWithCodeAnalysis,
            GenericParameterDeclarationWithCodeAnalysis,
            InterfaceReferenceWithCodeAnalysis,
            StructEventCollectionWithCodeAnalysis,
            StructPropertyCollectionWithCodeAnalysis,
            StructIndexerCollectionWithCodeAnalysis,
            StructMethodCollectionWithCodeAnalysis,
            StructFieldCollectionWithCodeAnalysis,
            StructConstructorWithCodeAnalysis,
            OperatorOverloadWithCodeAnalysis,
            ConversionOperatorWithCodeAnalysis,
            StructNestedClassCollectionWithCodeAnalysis,
            StructNestedDelegateWithCodeAnalysis,
            StructNestedEnumWithCodeAnalysis,
            StructNestedInterfaceCollectionWithCodeAnalysis,
            StructNestedStructCollectionWithCodeAnalysis,
            StaticConstructorWithCodeAnalysis>
    {
    }
}
