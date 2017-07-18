﻿using System;
using System.Collections.Generic;
using CSharpDom.Common;
using CSharpDom.Editable.Partial;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis.Partial
{
    public sealed class NestedStaticPartialClassNestedSealedPartialClassWithCodeAnalysis :
        EditableStaticClassNestedSealedPartialClass<
            AttributeGroupWithCodeAnalysis,
            INestedStaticPartialTypeWithCodeAnalysis,
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
        ISealedPartialTypeWithCodeAnalysis
    {
        private readonly NestedStaticClassNestedSealedClassWithCodeAnalysis classType;
        private readonly SealedPartialTypeWithCodeAnalysis<NestedStaticClassNestedSealedClassWithCodeAnalysis> sealedType;
        private readonly SealedPartialClassMethodCollectionWithCodeAnalysis methods;

        internal NestedStaticPartialClassNestedSealedPartialClassWithCodeAnalysis()
        {
            classType = new NestedStaticClassNestedSealedClassWithCodeAnalysis();
            sealedType = new SealedPartialTypeWithCodeAnalysis<NestedStaticClassNestedSealedClassWithCodeAnalysis>(
                classType.InternalClass.InternalClass);
            methods = new InternalSealedPartialClassMethodCollectionWithCodeAnalysis<NestedStaticClassNestedSealedClassWithCodeAnalysis>(
                classType.InternalClass.InternalClass.Type);
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

        public override INestedStaticPartialTypeWithCodeAnalysis DeclaringType
        {
            get { return classType.InternalClass.InternalClass.Type.Node.GetParentNode<INestedStaticPartialTypeWithCodeAnalysis>(); }
            set { throw new NotSupportedException(); }
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
            get { return methods; }
            set { classType.InternalClass.InternalClass.Type.Members.Replace(value); }
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
            get { return Syntax.Modifiers.ToClassMemberVisibilityModifier(); }
            set
            {
                ClassDeclarationSyntax syntax = Syntax;
                Syntax = syntax.WithModifiers(syntax.Modifiers.WithClassMemberVisibilityModifier(value));
            }
        }
    }
}
