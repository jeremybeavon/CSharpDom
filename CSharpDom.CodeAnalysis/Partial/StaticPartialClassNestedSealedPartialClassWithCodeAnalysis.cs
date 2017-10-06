using System;
using System.Collections.Generic;
using CSharpDom.Common;
using CSharpDom.BaseClasses.Editable.Partial;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis.Partial
{
    public sealed class StaticPartialClassNestedSealedPartialClassWithCodeAnalysis :
        EditableStaticClassNestedSealedPartialClass<
            AttributeGroupWithCodeAnalysis,
            StaticPartialClassWithCodeAnalysis,
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
        private readonly StaticClassNestedSealedPartialClassWithCodeAnalysis classType;

        internal StaticPartialClassNestedSealedPartialClassWithCodeAnalysis(
            StaticClassNestedSealedPartialClassWithCodeAnalysis type)
        {
            classType = type;
            classType.DeclaringTypeFunc = () => DeclaringType.Class;
        }
        
        public StaticClassNestedSealedPartialClassWithCodeAnalysis Class
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
            get { return classType.Classes; }
            set { classType.Classes = value; }
        }

        public override ICollection<SealedPartialClassConstructorWithCodeAnalysis> Constructors
        {
            get { return classType.Constructors; }
            set { classType.Constructors = value; }
        }

        public override ICollection<SealedPartialClassConversionOperatorWithCodeAnalysis> ConversionOperators
        {
            get { return classType.ConversionOperators; }
            set { classType.ConversionOperators = value; }
        }

        public override StaticPartialClassWithCodeAnalysis DeclaringType
        {
            get { return classType.Class.Class.Node.GetParentNode<StaticPartialClassWithCodeAnalysis>(); }
            set { throw new NotSupportedException(); }
        }

        public override ICollection<SealedPartialClassNestedDelegateWithCodeAnalysis> Delegates
        {
            get { return classType.Delegates; }
            set { classType.Delegates = value; }
        }

        public override SealedPartialClassDestructorWithCodeAnalysis Destructor
        {
            get { return classType.Destructor; }
            set { classType.Destructor = value; }
        }

        public override ICollection<SealedPartialClassNestedEnumWithCodeAnalysis> Enums
        {
            get { return classType.Enums; }
            set { classType.Enums = value; }
        }

        public override SealedPartialClassEventCollectionWithCodeAnalysis Events
        {
            get { return classType.Events; }
            set { classType.Events = value; }
        }

        public override SealedPartialClassFieldCollectionWithCodeAnalysis Fields
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

        public override SealedPartialClassIndexerCollectionWithCodeAnalysis Indexers
        {
            get { return classType.Indexers; }
            set { classType.Indexers = value; }
        }

        public override ICollection<SealedPartialClassNestedInterfaceWithCodeAnalysis> Interfaces
        {
            get { return classType.Interfaces; }
            set { classType.Interfaces = value; }
        }

        public override SealedPartialClassMethodCollectionWithCodeAnalysis Methods
        {
            get { return classType.Methods; }
            set { classType.Methods = value; }
        }

        public override string Name
        {
            get { return classType.Name; }
            set { classType.Name = value; }
        }

        public override ICollection<SealedPartialClassOperatorOverloadWithCodeAnalysis> OperatorOverloads
        {
            get { return classType.OperatorOverloads; }
            set { classType.OperatorOverloads = value; }
        }

        public override SealedPartialClassPropertyCollectionWithCodeAnalysis Properties
        {
            get { return classType.Properties; }
            set { classType.Properties = value; }
        }

        public override SealedPartialClassStaticConstructorWithCodeAnalysis StaticConstructor
        {
            get { return classType.StaticConstructor; }
            set { classType.StaticConstructor = value; }
        }

        public override SealedPartialClassNestedStructCollectionWithCodeAnalysis Structs
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
            get { return Syntax.Modifiers.ToClassMemberVisibilityModifier(); }
            set
            {
                ClassDeclarationSyntax syntax = Syntax;
                Syntax = syntax.WithModifiers(syntax.Modifiers.WithClassMemberVisibilityModifier(value));
            }
        }

        ISealedTypeWithCodeAnalysis ISealedPartialTypeWithCodeAnalysis.Class => classType.Class;
    }
}
