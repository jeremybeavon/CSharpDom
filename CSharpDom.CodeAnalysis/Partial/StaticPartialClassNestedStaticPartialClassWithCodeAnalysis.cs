﻿using CSharpDom.Common;
using CSharpDom.Editable.Partial;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Collections.Generic;
using System;

namespace CSharpDom.CodeAnalysis.Partial
{
    public sealed class StaticPartialClassNestedStaticPartialClassWithCodeAnalysis :
        EditableStaticClassNestedStaticPartialClass<
            AttributeGroupWithCodeAnalysis,
            StaticPartialClassWithCodeAnalysis,
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
        IHasSyntax<ClassDeclarationSyntax>,
        INestedStaticPartialTypeWithCodeAnalysis,
        IHasNode<ClassDeclarationSyntax>
    {
        private readonly StaticClassNestedStaticClassWithCodeAnalysis classType;
        private readonly InternalNestedStaticPartialClassWithCodeAnalysis<StaticPartialClassNestedStaticPartialClassWithCodeAnalysis> partialType;

        internal StaticPartialClassNestedStaticPartialClassWithCodeAnalysis()
        {
            var type = new InternalNestedStaticClassWithCodeAnalysis<StaticPartialClassNestedStaticPartialClassWithCodeAnalysis>(this);
            classType = new StaticClassNestedStaticClassWithCodeAnalysis(type);
            partialType = new InternalNestedStaticPartialClassWithCodeAnalysis<StaticPartialClassNestedStaticPartialClassWithCodeAnalysis>(
                type);
        }

        public StaticClassNestedStaticClassWithCodeAnalysis Class
        {
            get { return classType; }
        }
        
        public override ICollection<AttributeGroupWithCodeAnalysis> Attributes
        {
            get { return classType.Attributes; }
            set { classType.Attributes = value; }
        }

        public override NestedStaticPartialClassNestedClassCollectionWithCodeAnalysis Classes
        {
            get { return partialType.Classes; }
            set { partialType.Classes = value; }
        }

        public override StaticPartialClassWithCodeAnalysis DeclaringType
        {
            get { return classType.Class.Node.GetParentNode<StaticPartialClassWithCodeAnalysis>(); }
            set { partialType.DeclaringType = value; }
        }

        public override ICollection<NestedStaticPartialClassNestedDelegateWithCodeAnalysis> Delegates
        {
            get { return partialType.Delegates; }
            set { partialType.Delegates = value; }
        }

        public override ICollection<NestedStaticPartialClassNestedEnumWithCodeAnalysis> Enums
        {
            get { return partialType.Enums; }
            set { partialType.Enums = value; }
        }

        public override NestedStaticPartialClassEventCollectionWithCodeAnalysis Events
        {
            get { return partialType.Events; }
            set { partialType.Events = value; }
        }

        public override NestedStaticPartialClassFieldCollectionWithCodeAnalysis Fields
        {
            get { return partialType.Fields; }
            set { partialType.Fields = value; }
        }

        public override IList<GenericParameterDeclarationWithCodeAnalysis> GenericParameters
        {
            get { return classType.GenericParameters; }
            set { classType.GenericParameters = value; }
        }

        public override ICollection<NestedStaticPartialClassNestedInterfaceWithCodeAnalysis> Interfaces
        {
            get { return partialType.Interfaces; }
            set { partialType.Interfaces = value; }
        }

        public override NestedStaticPartialClassMethodCollectionWithCodeAnalysis Methods
        {
            get { return partialType.Methods; }
            set { partialType.Methods = value; }
        }

        public override string Name
        {
            get { return classType.Name; }
            set { classType.Name = value; }
        }

        public override ICollection<NestedStaticPartialClassPropertyWithCodeAnalysis> Properties
        {
            get { return partialType.Properties; }
            set { partialType.Properties = value; }
        }

        public override StaticConstructorWithCodeAnalysis StaticConstructor
        {
            get { return classType.StaticConstructor; }
            set { classType.StaticConstructor = value; }
        }

        public override NestedStaticPartialClassNestedStructCollectionWithCodeAnalysis Structs
        {
            get { return partialType.Structs; }
            set { partialType.Structs = value; }
        }

        public ClassDeclarationSyntax Syntax
        {
            get { return classType.Syntax; }
            set { classType.Syntax = value; }
        }

        public override ClassMemberVisibilityModifier Visibility
        {
            get { return Syntax.Modifiers.ToClassMemberVisibilityModifier(); }
            set
            {
                ClassDeclarationSyntax syntax = Syntax;
                Syntax = syntax.WithModifiers(syntax.Modifiers.WithClassMemberVisibilityModifier(value));
            }
        }

        INode<ClassDeclarationSyntax> IHasNode<ClassDeclarationSyntax>.Node => classType.Class.Node;
    }
}