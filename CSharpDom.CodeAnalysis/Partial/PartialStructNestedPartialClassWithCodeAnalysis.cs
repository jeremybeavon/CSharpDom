﻿using System;
using System.Collections.Generic;
using CSharpDom.Common;
using CSharpDom.BaseClasses.Editable.Partial;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.CSharp;

namespace CSharpDom.CodeAnalysis.Partial
{
    public sealed class PartialStructNestedPartialClassWithCodeAnalysis :
        EditableStructNestedPartialClass<
            AttributeGroupWithCodeAnalysis,
            IPartialStructTypeWithCodeAnalysis,
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
        IPartialClassTypeWithCodeAnalysis
    {
        private readonly StructNestedPartialClassWithCodeAnalysis classType;

        public PartialStructNestedPartialClassWithCodeAnalysis(
            StructMemberVisibilityModifier visibility,
            string name)
            : this(new StructNestedPartialClassWithCodeAnalysis(visibility, name))
        {
        }

        internal PartialStructNestedPartialClassWithCodeAnalysis(
            StructNestedPartialClassWithCodeAnalysis classType)
        {
            this.classType = classType;
            classType.DeclaringTypeFunc = () => DeclaringType.Struct;
        }
        
        public StructNestedPartialClassWithCodeAnalysis Class
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
            get { return classType.Classes; }
            set { classType.Classes = value; }
        }

        public override ICollection<PartialClassConstructorWithCodeAnalysis> Constructors
        {
            get { return classType.Constructors; }
            set { classType.Constructors = value; }
        }

        public override ICollection<PartialClassConversionOperatorWithCodeAnalysis> ConversionOperators
        {
            get { return classType.ConversionOperators; }
            set { classType.ConversionOperators = value; }
        }

        public override IPartialStructTypeWithCodeAnalysis DeclaringType
        {
            get { return classType.Class.Class.Node.GetParent<IPartialStructTypeWithCodeAnalysis>(); }
            set { throw new NotSupportedException(); }
        }

        public override ICollection<PartialClassNestedDelegateWithCodeAnalysis> Delegates
        {
            get { return classType.Delegates; }
            set { classType.Delegates = value; }
        }

        public override PartialClassDestructorWithCodeAnalysis Destructor
        {
            get { return classType.Destructor; }
            set { classType.Destructor = value; }
        }

        public override ICollection<PartialClassNestedEnumWithCodeAnalysis> Enums
        {
            get { return classType.Enums; }
            set { classType.Enums = value; }
        }

        public override PartialClassEventCollectionWithCodeAnalysis Events
        {
            get { return classType.Events; }
            set { classType.Events = value; }
        }

        public override PartialClassFieldCollectionWithCodeAnalysis Fields
        {
            get { return classType.Fields; }
            set { classType.Fields = value; }
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
            get { return classType.Indexers; }
            set { classType.Indexers = value; }
        }

        public override ICollection<PartialClassNestedInterfaceWithCodeAnalysis> Interfaces
        {
            get { return classType.Interfaces; }
            set { classType.Interfaces = value; }
        }

        public override PartialClassMethodCollectionWithCodeAnalysis Methods
        {
            get { return classType.Methods; }
            set { classType.Methods = value; }
        }

        public override string Name
        {
            get { return classType.Name; }
            set { classType.Name = value; }
        }

        public override ICollection<PartialClassOperatorOverloadWithCodeAnalysis> OperatorOverloads
        {
            get { return classType.OperatorOverloads; }
            set { classType.OperatorOverloads = value; }
        }

        public override PartialClassPropertyCollectionWithCodeAnalysis Properties
        {
            get { return classType.Properties; }
            set { classType.Properties = value; }
        }

        public override PartialClassStaticConstructorWithCodeAnalysis StaticConstructor
        {
            get { return classType.StaticConstructor; }
            set { classType.StaticConstructor = value; }
        }

        public override PartialClassNestedStructCollectionWithCodeAnalysis Structs
        {
            get { return classType.Structs; }
            set { classType.Structs = value; }
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

        IClassTypeWithCodeAnalysis IPartialClassTypeWithCodeAnalysis.Class => classType.Class;
    }
}
