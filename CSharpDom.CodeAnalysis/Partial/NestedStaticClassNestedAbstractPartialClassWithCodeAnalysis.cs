using System;
using System.Collections.Generic;
using CSharpDom.Common;
using CSharpDom.BaseClasses.Editable.Partial;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.CSharp;

namespace CSharpDom.CodeAnalysis.Partial
{
    public sealed class NestedStaticClassNestedAbstractPartialClassWithCodeAnalysis :
        EditableStaticClassNestedAbstractPartialClass<
            AttributeGroupWithCodeAnalysis,
            INestedStaticTypeWithCodeAnalysis,
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
        IHasNode<ClassDeclarationSyntax>,
        IAbstractPartialTypeWithCodeAnalysis
    {
        private readonly StaticClassNestedAbstractClassWithCodeAnalysis classType;
        private readonly AbstractPartialTypeWithCodeAnalysis<NestedStaticClassNestedAbstractPartialClassWithCodeAnalysis> partialType;

        public NestedStaticClassNestedAbstractPartialClassWithCodeAnalysis(
            ClassMemberVisibilityModifier visibility,
            string name)
            : this()
        {
            Syntax = ClassDeclarationSyntaxExtensions.ToSyntax(
                name,
                visibility,
                SyntaxKind.AbstractKeyword,
                SyntaxKind.PartialKeyword);
        }

        internal NestedStaticClassNestedAbstractPartialClassWithCodeAnalysis()
        {
            var abstractType = new InternalNestedAbstractClassWithCodeAnalysis<NestedStaticClassNestedAbstractPartialClassWithCodeAnalysis>(this);
            classType = new StaticClassNestedAbstractClassWithCodeAnalysis(abstractType);
            partialType = new AbstractPartialTypeWithCodeAnalysis<NestedStaticClassNestedAbstractPartialClassWithCodeAnalysis>(
                abstractType);
        }
        
        public StaticClassNestedAbstractClassWithCodeAnalysis Class
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
            get { return partialType.Classes; }
            set { partialType.Classes = value; }
        }

        public override ICollection<AbstractPartialClassConstructorWithCodeAnalysis> Constructors
        {
            get { return partialType.Constructors; }
            set { partialType.Constructors = value; }
        }

        public override ICollection<AbstractPartialClassConversionOperatorWithCodeAnalysis> ConversionOperators
        {
            get { return partialType.ConversionOperators; }
            set { partialType.ConversionOperators = value; }
        }

        public override INestedStaticTypeWithCodeAnalysis DeclaringType
        {
            get { return DeclaringTypeFunc?.Invoke() ?? classType.Node.GetParentNode<INestedStaticTypeWithCodeAnalysis>(); }
            set { throw new NotSupportedException(); }
        }

        public override ICollection<AbstractPartialClassNestedDelegateWithCodeAnalysis> Delegates
        {
            get { return partialType.Delegates; }
            set { partialType.Delegates = value; }
        }

        public override AbstractPartialClassDestructorWithCodeAnalysis Destructor
        {
            get { return partialType.Destructor; }
            set { partialType.Destructor = value; }
        }

        public override ICollection<AbstractPartialClassNestedEnumWithCodeAnalysis> Enums
        {
            get { return partialType.Enums; }
            set { partialType.Enums = value; }
        }

        public override AbstractPartialClassEventCollectionWithCodeAnalysis Events
        {
            get { return partialType.Events; }
            set { partialType.Events = value; }
        }

        public override AbstractPartialClassFieldCollectionWithCodeAnalysis Fields
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

        public override AbstractPartialClassIndexerCollectionWithCodeAnalysis Indexers
        {
            get { return partialType.Indexers; }
            set { partialType.Indexers = value; }
        }

        public override ICollection<AbstractPartialClassNestedInterfaceWithCodeAnalysis> Interfaces
        {
            get { return partialType.Interfaces; }
            set { partialType.Interfaces = value; }
        }

        public override AbstractPartialClassMethodCollectionWithCodeAnalysis Methods
        {
            get { return partialType.Methods; }
            set { partialType.Methods = value; }
        }

        public override string Name
        {
            get { return classType.Name; }
            set { classType.Name = value; }
        }

        public override ICollection<AbstractPartialClassOperatorOverloadWithCodeAnalysis> OperatorOverloads
        {
            get { return partialType.OperatorOverloads; }
            set { partialType.OperatorOverloads = value; }
        }

        public override AbstractPartialClassPropertyCollectionWithCodeAnalysis Properties
        {
            get { return partialType.Properties; }
            set { partialType.Properties = value; }
        }

        public override AbstractPartialClassStaticConstructorWithCodeAnalysis StaticConstructor
        {
            get { return partialType.StaticConstructor; }
            set { partialType.StaticConstructor = value; }
        }

        public override AbstractPartialClassNestedStructCollectionWithCodeAnalysis Structs
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
        
        INode<ClassDeclarationSyntax> IHasNode<ClassDeclarationSyntax>.Node
        {
            get { return classType.Node; }
        }

        IAbstractTypeWithCodeAnalysis IAbstractPartialTypeWithCodeAnalysis.Class => classType.Class.Class;

        internal Func<INestedStaticTypeWithCodeAnalysis> DeclaringTypeFunc { get; set; }
    }
}
