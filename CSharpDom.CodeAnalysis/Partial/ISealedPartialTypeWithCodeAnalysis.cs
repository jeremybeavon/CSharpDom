﻿using CSharpDom.Common;
using CSharpDom.Common.Editable;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis.Partial
{
    public interface ISealedPartialTypeWithCodeAnalysis :
        IEditableSealedType,
        IClassTypeDefinitionWithCodeAnalysis,
        ISealedType<
            AttributeGroupWithCodeAnalysis,
            GenericParameterDeclarationWithCodeAnalysis,
            ClassReferenceWithCodeAnalysis,
            InterfaceReferenceWithCodeAnalysis,
            SealedPartialClassEventCollectionWithCodeAnalysis,
            SealedPartialClassPropertyCollectionWithCodeAnalysis,
            SealedPartialClassIndexerCollectionWithCodeAnalysis,
            SealedPartialClassMethodCollectionWithCodeAnalysis,
            SealedPartialClassFieldCollectionWithCodeAnalysis,
            SealedPartialClassConstructorWithCodeAnalysis,
            SealedPartialClassOperatorOverloadWithCodeAnalysis,
            SealedPartialClassConversionOperatorWithCodeAnalysis,
            SealedPartialClassNestedClassCollectionWithCodeAnalysis,
            SealedPartialClassNestedDelegateWithCodeAnalysis,
            SealedPartialClassNestedEnumWithCodeAnalysis,
            SealedPartialClassNestedInterfaceWithCodeAnalysis,
            SealedPartialClassNestedStructCollectionWithCodeAnalysis,
            SealedPartialClassStaticConstructorWithCodeAnalysis,
            SealedPartialClassDestructorWithCodeAnalysis>,
        IHasSyntax<ClassDeclarationSyntax>
    {
        ISealedTypeWithCodeAnalysis Class { get; }
    }
}
