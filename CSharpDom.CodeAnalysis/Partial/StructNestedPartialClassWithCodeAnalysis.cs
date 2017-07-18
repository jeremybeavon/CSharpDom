﻿using System;
using System.Collections.Generic;
using CSharpDom.Common;
using CSharpDom.Editable.Partial;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis.Partial
{
    public sealed class StructNestedPartialClassWithCodeAnalysis :
        EditableStructNestedPartialClass<
            AttributeGroupWithCodeAnalysis,
            IStructTypeWithCodeAnalysis,
            GenericParameterDeclarationWithCodeAnalysis,
            ClassReferenceWithCodeAnalysis,
            InterfaceReferenceWithCodeAnalysis,
            PartialClassEventCollectionWithCodeAnalysis,
            PartialClassPropertyCollectionWithCodeAnalysis,
            PartialClassIndexerCollectionWithCodeAnalysis,
            PartialClassMethodCollectionWithCodeAnalysis,
            PartialClassFieldCollectionWithCodeAnalysis,
            PartialClassConstructorWithCodeAnalysis,
            PartialClassOperatorOverloadWithCodeAnalysis,
            PartialClassConversionOperatorWithCodeAnalysis,
            PartialClassNestedClassCollectionWithCodeAnalysis,
            PartialClassNestedDelegateWithCodeAnalysis,
            PartialClassNestedEnumWithCodeAnalysis,
            PartialClassNestedInterfaceWithCodeAnalysis,
            PartialClassNestedStructCollectionWithCodeAnalysis,
            PartialClassStaticConstructorWithCodeAnalysis,
            PartialClassDestructorWithCodeAnalysis>,
        IHasSyntax<ClassDeclarationSyntax>,
        IHasNode<ClassDeclarationSyntax>,
        IPartialClassTypeWithCodeAnalysis
    {
        private readonly StructNestedClassWithCodeAnalysis classType;
        private readonly PartialClassTypeWithCodeAnalysis<StructNestedClassWithCodeAnalysis> partialType;
        private readonly PartialClassMethodCollectionWithCodeAnalysis methods;

        internal StructNestedPartialClassWithCodeAnalysis()
        {
            classType = new StructNestedClassWithCodeAnalysis();
            partialType = new PartialClassTypeWithCodeAnalysis<StructNestedClassWithCodeAnalysis>(
                classType.InternalClass.InternalClass);
            methods = new InternalPartialClassMethodCollectionWithCodeAnalysis<StructNestedClassWithCodeAnalysis>(
                classType.InternalClass.InternalClass);
        }
        
        public StructNestedClassWithCodeAnalysis Class
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

        public override PartialClassNestedClassCollectionWithCodeAnalysis Classes
        {
            get { return partialType.Classes; }
            set { partialType.Classes = value; }
        }

        public override ICollection<PartialClassConstructorWithCodeAnalysis> Constructors
        {
            get { return partialType.Constructors; }
            set { partialType.Constructors = value; }
        }

        public override ICollection<PartialClassConversionOperatorWithCodeAnalysis> ConversionOperators
        {
            get { return partialType.ConversionOperators; }
            set { partialType.ConversionOperators = value; }
        }

        public override IStructTypeWithCodeAnalysis DeclaringType
        {
            get { return classType.DeclaringType; }
            set { classType.DeclaringType = value; }
        }

        public override ICollection<PartialClassNestedDelegateWithCodeAnalysis> Delegates
        {
            get { return partialType.Delegates; }
            set { partialType.Delegates = value; }
        }

        public override PartialClassDestructorWithCodeAnalysis Destructor
        {
            get { return partialType.Destructor; }
            set { partialType.Destructor = value; }
        }

        public override ICollection<PartialClassNestedEnumWithCodeAnalysis> Enums
        {
            get { return partialType.Enums; }
            set { partialType.Enums = value; }
        }

        public override PartialClassEventCollectionWithCodeAnalysis Events
        {
            get { return partialType.Events; }
            set { partialType.Events = value; }
        }

        public override PartialClassFieldCollectionWithCodeAnalysis Fields
        {
            get { return partialType.Fields; }
            set { partialType.Fields = value; }
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

        public override PartialClassIndexerCollectionWithCodeAnalysis Indexers
        {
            get { return partialType.Indexers; }
            set { partialType.Indexers = value; }
        }

        public override ICollection<PartialClassNestedInterfaceWithCodeAnalysis> Interfaces
        {
            get { return partialType.Interfaces; }
            set { partialType.Interfaces = value; }
        }

        public override PartialClassMethodCollectionWithCodeAnalysis Methods
        {
            get { return methods; }
            set { classType.InternalClass.InternalClass.Members.Replace(value); }
        }

        public override string Name
        {
            get { return classType.Name; }
            set { classType.Name = value; }
        }

        public override ICollection<PartialClassOperatorOverloadWithCodeAnalysis> OperatorOverloads
        {
            get { return partialType.OperatorOverloads; }
            set { partialType.OperatorOverloads = value; }
        }

        public override PartialClassPropertyCollectionWithCodeAnalysis Properties
        {
            get { return partialType.Properties; }
            set { partialType.Properties = value; }
        }

        public override PartialClassStaticConstructorWithCodeAnalysis StaticConstructor
        {
            get { return partialType.StaticConstructor; }
            set { partialType.StaticConstructor = value; }
        }

        public override PartialClassNestedStructCollectionWithCodeAnalysis Structs
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
            get { return Syntax.Modifiers.ToStructMemberVisibilityModifier(); }
            set
            {
                ClassDeclarationSyntax syntax = Syntax;
                Syntax = syntax.WithModifiers(syntax.Modifiers.WithStructMemberVisibilityModifier(value));
            }
        }
        
        INode<ClassDeclarationSyntax> IHasNode<ClassDeclarationSyntax>.Node
        {
            get { return classType.InternalClass.InternalClass.Node; }
        }

        IClassTypeWithCodeAnalysis IPartialClassTypeWithCodeAnalysis.Class => classType;
    }
}
