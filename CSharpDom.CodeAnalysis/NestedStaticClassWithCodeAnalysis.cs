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
            NestedStaticClassEventCollectionWithCodeAnalysis,
            NestedStaticClassPropertyWithCodeAnalysis,
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
        public abstract ClassDeclarationSyntax Syntax { get; set; }

        internal abstract INode<ClassDeclarationSyntax> Node { get; }

        internal abstract IMemberList Members { get; }
    }
}