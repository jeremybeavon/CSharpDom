﻿using System;
using System.Collections.Generic;
using CSharpDom.Common;
using CSharpDom.BaseClasses.Editable.Partial;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.CSharp;

namespace CSharpDom.CodeAnalysis.Partial
{
    public sealed class NestedStaticClassNestedSealedPartialClassWithCodeAnalysis :
        EditableStaticClassNestedSealedPartialClass<
            AttributeGroupWithCodeAnalysis,
            INestedStaticTypeWithCodeAnalysis,
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
        IHasSyntax<ClassDeclarationSyntax>,
        IHasNode<ClassDeclarationSyntax>,
        ISealedPartialTypeWithCodeAnalysis
    {
        private readonly NestedStaticClassNestedSealedClassWithCodeAnalysis classType;
        private readonly SealedPartialTypeWithCodeAnalysis<NestedStaticClassNestedSealedPartialClassWithCodeAnalysis> sealedType;

        public NestedStaticClassNestedSealedPartialClassWithCodeAnalysis(
            ClassMemberVisibilityModifier visibility,
            string name)
            : this()
        {
            Syntax = ClassDeclarationSyntaxExtensions.ToSyntax(
                name,
                visibility,
                SyntaxKind.SealedKeyword,
                SyntaxKind.PartialKeyword);
        }

        internal NestedStaticClassNestedSealedPartialClassWithCodeAnalysis()
        {
            var type = new InternalNestedSealedClassWithCodeAnalysis<NestedStaticClassNestedSealedPartialClassWithCodeAnalysis>(this);
            classType = new NestedStaticClassNestedSealedClassWithCodeAnalysis(type);
            sealedType = new SealedPartialTypeWithCodeAnalysis<NestedStaticClassNestedSealedPartialClassWithCodeAnalysis>(type);
        }
        
        public NestedStaticClassNestedSealedClassWithCodeAnalysis Class
        {
            get { return classType; }
        }

        public override ICollection<AttributeGroupWithCodeAnalysis> Attributes
        {
            get { return classType.Attributes; }
            set { classType.Attributes = value; }
        }

        public override ClassReferenceWithCodeAnalysis BaseClass
        {
            get { return classType.BaseClass; }
            set { classType.BaseClass = value; }
        }

        public override SealedPartialClassNestedClassCollectionWithCodeAnalysis Classes
        {
            get { return sealedType.Classes; }
            set { sealedType.Classes = value; }
        }

        public override ICollection<SealedPartialClassConstructorWithCodeAnalysis> Constructors
        {
            get { return sealedType.Constructors; }
            set { sealedType.Constructors = value; }
        }

        public override ICollection<SealedPartialClassConversionOperatorWithCodeAnalysis> ConversionOperators
        {
            get { return sealedType.ConversionOperators; }
            set { sealedType.ConversionOperators = value; }
        }

        public override INestedStaticTypeWithCodeAnalysis DeclaringType
        {
            get { return classType.DeclaringType; }
            set { classType.DeclaringType = value; }
        }

        public override ICollection<SealedPartialClassNestedDelegateWithCodeAnalysis> Delegates
        {
            get { return sealedType.Delegates; }
            set { sealedType.Delegates = value; }
        }

        public override SealedPartialClassDestructorWithCodeAnalysis Destructor
        {
            get { return sealedType.Destructor; }
            set { sealedType.Destructor = value; }
        }

        public override ICollection<SealedPartialClassNestedEnumWithCodeAnalysis> Enums
        {
            get { return sealedType.Enums; }
            set { sealedType.Enums = value; }
        }

        public override SealedPartialClassEventCollectionWithCodeAnalysis Events
        {
            get { return sealedType.Events; }
            set { sealedType.Events = value; }
        }

        public override SealedPartialClassFieldCollectionWithCodeAnalysis Fields
        {
            get { return sealedType.Fields; }
            set { sealedType.Fields = value; }
        }

        public override IList<GenericParameterDeclarationWithCodeAnalysis> GenericParameters
        {
            get { return classType.GenericParameters; }
            set { classType.GenericParameters = value; }
        }

        public override ICollection<InterfaceReferenceWithCodeAnalysis> ImplementedInterfaces
        {
            get { return classType.ImplementedInterfaces; }
            set { classType.ImplementedInterfaces = value; }
        }

        public override SealedPartialClassIndexerCollectionWithCodeAnalysis Indexers
        {
            get { return sealedType.Indexers; }
            set { sealedType.Indexers = value; }
        }

        public override ICollection<SealedPartialClassNestedInterfaceWithCodeAnalysis> Interfaces
        {
            get { return sealedType.Interfaces; }
            set { sealedType.Interfaces = value; }
        }

        public override SealedPartialClassMethodCollectionWithCodeAnalysis Methods
        {
            get { return sealedType.Methods; }
            set { sealedType.Methods = value; }
        }

        public override string Name
        {
            get { return classType.Name; }
            set { classType.Name = value; }
        }

        public override ICollection<SealedPartialClassOperatorOverloadWithCodeAnalysis> OperatorOverloads
        {
            get { return sealedType.OperatorOverloads; }
            set { sealedType.OperatorOverloads = value; }
        }

        public override SealedPartialClassPropertyCollectionWithCodeAnalysis Properties
        {
            get { return sealedType.Properties; }
            set { sealedType.Properties = value; }
        }

        public override SealedPartialClassStaticConstructorWithCodeAnalysis StaticConstructor
        {
            get { return sealedType.StaticConstructor; }
            set { sealedType.StaticConstructor = value; }
        }

        public override SealedPartialClassNestedStructCollectionWithCodeAnalysis Structs
        {
            get { return sealedType.Structs; }
            set { sealedType.Structs = value; }
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
        
        INode<ClassDeclarationSyntax> IHasNode<ClassDeclarationSyntax>.Node
        {
            get { return classType.Class.Node; }
        }

        ISealedTypeWithCodeAnalysis ISealedPartialTypeWithCodeAnalysis.Class => classType;

        internal Func<INestedStaticTypeWithCodeAnalysis> DeclaringTypeFunc
        {
            get { return classType.DeclaringTypeFunc; }
            set { classType.DeclaringTypeFunc = value; }
        }
    }
}
