using CSharpDom.Common;
using CSharpDom.Editable;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Collections.Generic;
using System;

namespace CSharpDom.CodeAnalysis
{
    public abstract class NestedStaticClassWithCodeAnalysis :
        EditableNestedStaticClass<
            AttributeGroupWithCodeAnalysis,
            IType,
            GenericParameterDeclarationWithCodeAnalysis,
            StaticClassEventCollectionWithCodeAnalysis,
            StaticClassPropertyWithCodeAnalysis,
            NestedStaticClassMethodCollectionWithCodeAnalysis,
            StaticClassFieldCollectionWithCodeAnalysis,
            StaticClassNestedClassCollectionWithCodeAnalysis,
            StaticClassNestedDelegateWithCodeAnalysis,
            StaticClassNestedEnumWithCodeAnalysis,
            StaticClassNestedInterfaceWithCodeAnalysis,
            StaticClassNestedStructCollectionWithCodeAnalysis,
            StaticConstructorWithCodeAnalysis>,
        IHasSyntax<ClassDeclarationSyntax>
    {
        public abstract ClassDeclarationSyntax Syntax { get; set; }
    }
}