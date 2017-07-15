using CSharpDom.Editable;
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
        public abstract ClassDeclarationSyntax Syntax { get; set; }
    }
}
