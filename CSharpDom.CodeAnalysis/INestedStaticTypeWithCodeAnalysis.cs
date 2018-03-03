using CSharpDom.Common;
using CSharpDom.Common.Editable;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis
{
    public interface INestedStaticTypeWithCodeAnalysis :
        IEditableStaticType,
        IStaticType<
            AttributeGroupWithCodeAnalysis,
            GenericParameterDeclarationWithCodeAnalysis,
            NestedStaticClassEventCollectionWithCodeAnalysis,
            NestedStaticClassPropertyCollectionWithCodeAnalysis,
            NestedStaticClassMethodCollectionWithCodeAnalysis,
            NestedStaticClassFieldCollectionWithCodeAnalysis,
            NestedStaticClassNestedClassCollectionWithCodeAnalysis,
            NestedStaticClassNestedDelegateWithCodeAnalysis,
            NestedStaticClassNestedEnumWithCodeAnalysis,
            NestedStaticClassNestedInterfaceWithCodeAnalysis,
            NestedStaticClassNestedStructCollectionWithCodeAnalysis,
            StaticConstructorWithCodeAnalysis>,
        IHasSyntax<ClassDeclarationSyntax>
    {
    }
}
