﻿using CSharpDom.Common;
using CSharpDom.BaseClasses.Editable.Partial;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Collections.Generic;
using System;
using Microsoft.CodeAnalysis.CSharp;

namespace CSharpDom.CodeAnalysis.Partial
{
    public sealed class ClassNestedStaticPartialClassWithCodeAnalysis :
        EditableClassNestedStaticPartialClass<
            AttributeGroupWithCodeAnalysis,
            IClassTypeWithCodeAnalysis,
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
        private readonly ClassNestedStaticClassWithCodeAnalysis classType;
        private readonly InternalNestedStaticPartialClassWithCodeAnalysis<ClassNestedStaticPartialClassWithCodeAnalysis> partialType;

        public ClassNestedStaticPartialClassWithCodeAnalysis(ClassMemberVisibilityModifier visibility, string name)
            : this()
        {
            Syntax = ClassDeclarationSyntaxExtensions.ToSyntax(
                name,
                visibility,
                SyntaxKind.StaticKeyword,
                SyntaxKind.PartialKeyword);
        }

        internal ClassNestedStaticPartialClassWithCodeAnalysis()
        {
            var type = new InternalNestedStaticClassWithCodeAnalysis<ClassNestedStaticPartialClassWithCodeAnalysis>(this);
            classType = new ClassNestedStaticClassWithCodeAnalysis(type);
            partialType = new InternalNestedStaticPartialClassWithCodeAnalysis<ClassNestedStaticPartialClassWithCodeAnalysis>(type);
        }

        public ClassNestedStaticClassWithCodeAnalysis Class
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

        public override IClassTypeWithCodeAnalysis DeclaringType
        {
            get { return DeclaringTypeFunc?.Invoke() ?? classType.Class.Node.GetParentNode<IClassTypeWithCodeAnalysis>(); }
            set { throw new NotSupportedException(); }
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
            get { return null; }
            set { }
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
            get { return classType.Visibility; }
            set { classType.Visibility = value; }
        }

        INode<ClassDeclarationSyntax> IHasNode<ClassDeclarationSyntax>.Node => classType.Class.Node;

        internal Func<IClassTypeWithCodeAnalysis> DeclaringTypeFunc { get; set; }

        INestedStaticTypeWithCodeAnalysis INestedStaticPartialTypeWithCodeAnalysis.Class => classType;
    }
}