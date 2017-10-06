using CSharpDom.BaseClasses.Editable;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis
{
    public abstract class SealedTypeWithCodeAnalysis :
        EditableSealedType<
            AttributeGroupWithCodeAnalysis,
            GenericParameterDeclarationWithCodeAnalysis,
            ClassReferenceWithCodeAnalysis,
            InterfaceReferenceWithCodeAnalysis,
            SealedClassEventCollectionWithCodeAnalysis,
            SealedClassPropertyCollectionWithCodeAnalysis,
            SealedClassIndexerCollectionWithCodeAnalysis,
            SealedClassMethodCollectionWithCodeAnalysis,
            SealedClassFieldCollectionWithCodeAnalysis,
            SealedClassConstructorWithCodeAnalysis,
            SealedClassOperatorOverloadWithCodeAnalysis,
            SealedClassConversionOperatorWithCodeAnalysis,
            SealedClassNestedClassCollectionWithCodeAnalysis,
            SealedClassNestedDelegateWithCodeAnalysis,
            SealedClassNestedEnumWithCodeAnalysis,
            SealedClassNestedInterfaceWithCodeAnalysis,
            SealedClassNestedStructCollectionWithCodeAnalysis,
            SealedClassStaticConstructorWithCodeAnalysis,
            SealedClassDestructorWithCodeAnalysis>,
        IHasSyntax<ClassDeclarationSyntax>
    {
        public abstract ClassDeclarationSyntax Syntax { get; set; }

        public abstract ClassTypeWithCodeAnalysis Class { get; }

        internal abstract INode<ClassDeclarationSyntax> Node { get; }
    }
}
