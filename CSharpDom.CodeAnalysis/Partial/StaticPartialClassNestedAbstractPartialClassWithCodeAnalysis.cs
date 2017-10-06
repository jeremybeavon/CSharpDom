using System;
using System.Collections.Generic;
using CSharpDom.Common;
using CSharpDom.BaseClasses.Editable.Partial;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis.Partial
{
    public sealed class StaticPartialClassNestedAbstractPartialClassWithCodeAnalysis :
        EditableStaticClassNestedAbstractPartialClass<
            AttributeGroupWithCodeAnalysis,
            StaticPartialClassWithCodeAnalysis,
            GenericParameterDeclarationWithCodeAnalysis,
            ClassReferenceWithCodeAnalysis,
            InterfaceReferenceWithCodeAnalysis,
            AbstractPartialClassEventCollectionWithCodeAnalysis,
            AbstractPartialClassPropertyCollectionWithCodeAnalysis,
            AbstractPartialClassIndexerCollectionWithCodeAnalysis,
            AbstractPartialClassMethodCollectionWithCodeAnalysis,
            AbstractPartialClassFieldCollectionWithCodeAnalysis,
            AbstractPartialClassConstructorWithCodeAnalysis,
            AbstractPartialClassOperatorOverloadWithCodeAnalysis,
            AbstractPartialClassConversionOperatorWithCodeAnalysis,
            AbstractPartialClassNestedClassCollectionWithCodeAnalysis,
            AbstractPartialClassNestedDelegateWithCodeAnalysis,
            AbstractPartialClassNestedEnumWithCodeAnalysis,
            AbstractPartialClassNestedInterfaceWithCodeAnalysis,
            AbstractPartialClassNestedStructCollectionWithCodeAnalysis,
            AbstractPartialClassStaticConstructorWithCodeAnalysis,
            AbstractPartialClassDestructorWithCodeAnalysis>,
        IHasSyntax<ClassDeclarationSyntax>,
        IAbstractPartialTypeWithCodeAnalysis
    {
        private readonly StaticClassNestedAbstractPartialClassWithCodeAnalysis classType;

        public StaticPartialClassNestedAbstractPartialClassWithCodeAnalysis(
            ClassMemberVisibilityModifier visibility,
            string name)
            : this(new StaticClassNestedAbstractPartialClassWithCodeAnalysis(visibility, name))
        {
        }

        internal StaticPartialClassNestedAbstractPartialClassWithCodeAnalysis(
            StaticClassNestedAbstractPartialClassWithCodeAnalysis type)
        {
            classType = type;
        }
        
        public StaticClassNestedAbstractPartialClassWithCodeAnalysis Class
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

        public override AbstractPartialClassNestedClassCollectionWithCodeAnalysis Classes
        {
            get { return classType.Classes; }
            set { classType.Classes = value; }
        }

        public override ICollection<AbstractPartialClassConstructorWithCodeAnalysis> Constructors
        {
            get { return classType.Constructors; }
            set { classType.Constructors = value; }
        }

        public override ICollection<AbstractPartialClassConversionOperatorWithCodeAnalysis> ConversionOperators
        {
            get { return classType.ConversionOperators; }
            set { classType.ConversionOperators = value; }
        }

        public override StaticPartialClassWithCodeAnalysis DeclaringType
        {
            get { return classType.Class.Class.Node.GetParentNode<StaticPartialClassWithCodeAnalysis>(); }
            set { throw new NotSupportedException(); }
        }

        public override ICollection<AbstractPartialClassNestedDelegateWithCodeAnalysis> Delegates
        {
            get { return classType.Delegates; }
            set { classType.Delegates = value; }
        }

        public override AbstractPartialClassDestructorWithCodeAnalysis Destructor
        {
            get { return classType.Destructor; }
            set { classType.Destructor = value; }
        }

        public override ICollection<AbstractPartialClassNestedEnumWithCodeAnalysis> Enums
        {
            get { return classType.Enums; }
            set { classType.Enums = value; }
        }

        public override AbstractPartialClassEventCollectionWithCodeAnalysis Events
        {
            get { return classType.Events; }
            set { classType.Events = value; }
        }

        public override AbstractPartialClassFieldCollectionWithCodeAnalysis Fields
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

        public override AbstractPartialClassIndexerCollectionWithCodeAnalysis Indexers
        {
            get { return classType.Indexers; }
            set { classType.Indexers = value; }
        }

        public override ICollection<AbstractPartialClassNestedInterfaceWithCodeAnalysis> Interfaces
        {
            get { return classType.Interfaces; }
            set { classType.Interfaces = value; }
        }

        public override AbstractPartialClassMethodCollectionWithCodeAnalysis Methods
        {
            get { return classType.Methods; }
            set { classType.Methods = value; }
        }

        public override string Name
        {
            get { return classType.Name; }
            set { classType.Name = value; }
        }

        public override ICollection<AbstractPartialClassOperatorOverloadWithCodeAnalysis> OperatorOverloads
        {
            get { return classType.OperatorOverloads; }
            set { classType.OperatorOverloads = value; }
        }

        public override AbstractPartialClassPropertyCollectionWithCodeAnalysis Properties
        {
            get { return classType.Properties; }
            set { classType.Properties = value; }
        }

        public override AbstractPartialClassStaticConstructorWithCodeAnalysis StaticConstructor
        {
            get { return classType.StaticConstructor; }
            set { classType.StaticConstructor = value; }
        }

        public override AbstractPartialClassNestedStructCollectionWithCodeAnalysis Structs
        {
            get { return classType.Structs; }
            set { classType.Structs = value; }
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

        IAbstractTypeWithCodeAnalysis IAbstractPartialTypeWithCodeAnalysis.Class => classType.Class.Class.Class;
    }
}
