﻿using CSharpDom.Common;
using CSharpDom.BaseClasses.Editable.Partial;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Collections.Generic;
using System;
using Microsoft.CodeAnalysis.CSharp;

namespace CSharpDom.CodeAnalysis.Partial
{
    public sealed class StructNestedStaticPartialClassWithCodeAnalysis :
        EditableStructNestedStaticPartialClass<
            AttributeGroupWithCodeAnalysis,
            IStructTypeWithCodeAnalysis,
            GenericParameterDeclarationWithCodeAnalysis,
            NestedStaticPartialClassEventCollectionWithCodeAnalysis,
            NestedStaticPartialClassPropertyCollectionWithCodeAnalysis,
            NestedStaticPartialClassMethodCollectionWithCodeAnalysis,
            NestedStaticPartialClassFieldCollectionWithCodeAnalysis,
            NestedStaticPartialClassNestedClassCollectionWithCodeAnalysis,
            NestedStaticPartialClassNestedDelegateWithCodeAnalysis,
            NestedStaticPartialClassNestedEnumWithCodeAnalysis,
            NestedStaticPartialClassNestedInterfaceWithCodeAnalysis,
            NestedStaticPartialClassNestedStructCollectionWithCodeAnalysis,
            StaticConstructorWithCodeAnalysis>,
        IHasSyntax<ClassDeclarationSyntax>,
        IHasNode<ClassDeclarationSyntax>,
        INestedStaticPartialTypeWithCodeAnalysis
    {
        private readonly StructNestedStaticClassWithCodeAnalysis classType;
        private readonly InternalNestedStaticPartialClassWithCodeAnalysis<StructNestedStaticPartialClassWithCodeAnalysis> partialType;

        public StructNestedStaticPartialClassWithCodeAnalysis(StructMemberVisibilityModifier visibility, string name)
            : this()
        {
            Syntax = ClassDeclarationSyntaxExtensions.ToSyntax(
                name,
                visibility,
                SyntaxKind.StaticKeyword,
                SyntaxKind.PartialKeyword);
        }

        internal StructNestedStaticPartialClassWithCodeAnalysis()
        {
            var type = new InternalNestedStaticClassWithCodeAnalysis<StructNestedStaticPartialClassWithCodeAnalysis>(this);
            classType = new StructNestedStaticClassWithCodeAnalysis(type);
            partialType = new InternalNestedStaticPartialClassWithCodeAnalysis<StructNestedStaticPartialClassWithCodeAnalysis>(type);
        }

        public StructNestedStaticClassWithCodeAnalysis Class
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

        public override IStructTypeWithCodeAnalysis DeclaringType
        {
            get { return classType.DeclaringType; }
            set { classType.DeclaringType = value; }
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

        public override NestedStaticPartialClassPropertyCollectionWithCodeAnalysis Properties
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

        public override StructMemberVisibilityModifier Visibility
        {
            get { return classType.Visibility; }
            set { classType.Visibility = value; }
        }

        INode<ClassDeclarationSyntax> IHasNode<ClassDeclarationSyntax>.Node => classType.Class.Node;

        INestedStaticTypeWithCodeAnalysis INestedStaticPartialTypeWithCodeAnalysis.Class => classType;

        internal Func<IStructTypeWithCodeAnalysis> DeclaringTypeFunc
        {
            get { return classType.DeclaringTypeFunc; }
            set { classType.DeclaringTypeFunc = value; }
        }
    }
}