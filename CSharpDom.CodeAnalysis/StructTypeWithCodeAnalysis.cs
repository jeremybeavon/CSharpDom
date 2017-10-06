using CSharpDom.BaseClasses.Editable;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis
{
    public abstract class StructTypeWithCodeAnalysis :
        EditableStructType<
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
            StructNestedInterfaceWithCodeAnalysis,
            StructNestedStructCollectionWithCodeAnalysis,
            StaticConstructorWithCodeAnalysis>,
        IHasSyntax<StructDeclarationSyntax>
    {
        public abstract StructDeclarationSyntax Syntax { get; set; }

        internal abstract INode<StructDeclarationSyntax> Node { get; }
    }
}
