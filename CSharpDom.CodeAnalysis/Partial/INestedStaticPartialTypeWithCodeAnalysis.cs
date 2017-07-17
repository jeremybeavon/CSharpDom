using CSharpDom.Common;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis.Partial
{
    public interface INestedStaticPartialTypeWithCodeAnalysis :
        IStaticType<
            AttributeGroupWithCodeAnalysis,
            GenericParameterDeclarationWithCodeAnalysis,
            NestedStaticPartialClassEventCollectionWithCodeAnalysis,
            NestedStaticPartialClassPropertyWithCodeAnalysis,
            NestedStaticPartialClassMethodCollectionWithCodeAnalysis,
            NestedStaticPartialClassFieldCollectionWithCodeAnalysis,
            NestedStaticPartialClassNestedClassCollectionWithCodeAnalysis,
            NestedStaticPartialClassNestedDelegateWithCodeAnalysis,
            NestedStaticPartialClassNestedEnumWithCodeAnalysis,
            NestedStaticPartialClassNestedInterfaceWithCodeAnalysis,
            NestedStaticPartialClassNestedStructCollectionWithCodeAnalysis,
            StaticConstructorWithCodeAnalysis>,
        IHasSyntax<ClassDeclarationSyntax>
    {
    }
}
