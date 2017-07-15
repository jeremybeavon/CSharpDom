using CSharpDom.Common;
using CSharpDom.Editable;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Collections.Generic;
using System;

namespace CSharpDom.CodeAnalysis
{
    public abstract class NestedSealedClassWithCodeAnalysis :
        EditableNestedSealedClass<
            AttributeGroupWithCodeAnalysis,
            IType,
            GenericParameterDeclarationWithCodeAnalysis,
            ClassReferenceWithCodeAnalysis,
            InterfaceReferenceWithCodeAnalysis,
            SealedClassEventCollectionWithCodeAnalysis,
            SealedClassPropertyCollectionWithCodeAnalysis,
            SealedClassIndexerCollectionWithCodeAnalysis,
            SealedClassMethodCollectionWithCodeAnalysis,
            SealedClassFieldCollectionWithCodeAnalysis,
            SealedClassConstructorWithCodeAnalysis,
            OperatorOverloadWithCodeAnalysis,
            ConversionOperatorWithCodeAnalysis,
            SealedClassNestedClassCollectionWithCodeAnalysis,
            SealedClassNestedDelegateWithCodeAnalysis,
            SealedClassNestedEnumWithCodeAnalysis,
            SealedClassNestedInterfaceWithCodeAnalysis,
            SealedClassNestedStructCollectionWithCodeAnalysis,
            DestructorWithCodeAnalysis,
            StaticConstructorWithCodeAnalysis>,
        IHasSyntax<ClassDeclarationSyntax>
    {   
        public abstract SealedTypeWithCodeAnalysis Class { get; }

        public abstract ClassDeclarationSyntax Syntax { get; set; }
    }
}