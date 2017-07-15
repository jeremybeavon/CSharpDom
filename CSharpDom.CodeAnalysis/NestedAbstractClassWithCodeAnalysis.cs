using CSharpDom.Common;
using CSharpDom.Editable;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Collections.Generic;
using System;

namespace CSharpDom.CodeAnalysis
{
    public abstract class NestedAbstractClassWithCodeAnalysis :
        EditableNestedAbstractClass<
            AttributeGroupWithCodeAnalysis,
            IType,
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
            DestructorWithCodeAnalysis,
            StaticConstructorWithCodeAnalysis>,
        IHasSyntax<ClassDeclarationSyntax>
    {
        public abstract ClassDeclarationSyntax Syntax { get; set; }
    }
}