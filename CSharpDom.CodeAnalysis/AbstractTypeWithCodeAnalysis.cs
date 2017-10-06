using CSharpDom.BaseClasses.Editable;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis
{
    public abstract class AbstractTypeWithCodeAnalysis :
        EditableAbstractType<
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
            AbstractClassOperatorOverloadWithCodeAnalysis,
            AbstractClassConversionOperatorWithCodeAnalysis,
            AbstractClassNestedClassCollectionWithCodeAnalysis,
            AbstractClassNestedDelegateWithCodeAnalysis,
            AbstractClassNestedEnumWithCodeAnalysis,
            AbstractClassNestedInterfaceWithCodeAnalysis,
            AbstractClassNestedStructCollectionWithCodeAnalysis,
            AbstractClassStaticConstructorWithCodeAnalysis,
            AbstractClassDestructorWithCodeAnalysis>,
        IHasSyntax<ClassDeclarationSyntax>,
        IAbstractTypeWithCodeAnalysis
    {
        public abstract ClassDeclarationSyntax Syntax { get; set; }

        public abstract IClassTypeWithCodeAnalysis Class { get; }

        internal abstract INode<ClassDeclarationSyntax> Node { get; }
    }
}
