using CSharpDom.Common;
using CSharpDom.Editable;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis
{
    public abstract class NestedStructWithCodeAnalysis :
        EditableNestedStruct<
            AttributeGroupWithCodeAnalysis,
            IType,
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
            StructNestedInterfaceWithCodeAnalysis,
            StructNestedStructCollectionWithCodeAnalysis,
            StaticConstructorWithCodeAnalysis>,
        IHasSyntax<StructDeclarationSyntax>
    {
        public abstract StructDeclarationSyntax Syntax { get; set; }
    }
}
