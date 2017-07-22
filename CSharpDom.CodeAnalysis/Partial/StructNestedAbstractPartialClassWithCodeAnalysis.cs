using System;
using System.Collections.Generic;
using CSharpDom.Common;
using CSharpDom.Editable.Partial;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis.Partial
{
    public sealed class StructNestedAbstractPartialClassWithCodeAnalysis :
        EditableStructNestedAbstractPartialClass<
            AttributeGroupWithCodeAnalysis,
            IStructTypeWithCodeAnalysis,
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
        private readonly StructNestedAbstractClassWithCodeAnalysis classType;
        private readonly AbstractPartialTypeWithCodeAnalysis<StructNestedAbstractPartialClassWithCodeAnalysis> abstractType;

        internal StructNestedAbstractPartialClassWithCodeAnalysis()
        {
            var type = new InternalNestedAbstractClassWithCodeAnalysis<StructNestedAbstractPartialClassWithCodeAnalysis>(this);
            classType = new StructNestedAbstractClassWithCodeAnalysis(type);
            abstractType = new AbstractPartialTypeWithCodeAnalysis<StructNestedAbstractPartialClassWithCodeAnalysis>(type);
        }
        
        public StructNestedAbstractClassWithCodeAnalysis Class
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
            get { return abstractType.Classes; }
            set { abstractType.Classes = value; }
        }

        public override ICollection<AbstractPartialClassConstructorWithCodeAnalysis> Constructors
        {
            get { return abstractType.Constructors; }
            set { abstractType.Constructors = value; }
        }

        public override ICollection<AbstractPartialClassConversionOperatorWithCodeAnalysis> ConversionOperators
        {
            get { return abstractType.ConversionOperators; }
            set { abstractType.ConversionOperators = value; }
        }

        public override IStructTypeWithCodeAnalysis DeclaringType
        {
            get { return classType.Class.Class.Node.GetParentNode<IStructTypeWithCodeAnalysis>(); }
            set { throw new NotSupportedException(); }
        }

        public override ICollection<AbstractPartialClassNestedDelegateWithCodeAnalysis> Delegates
        {
            get { return abstractType.Delegates; }
            set { abstractType.Delegates = value; }
        }

        public override AbstractPartialClassDestructorWithCodeAnalysis Destructor
        {
            get { return abstractType.Destructor; }
            set { abstractType.Destructor = value; }
        }

        public override ICollection<AbstractPartialClassNestedEnumWithCodeAnalysis> Enums
        {
            get { return abstractType.Enums; }
            set { abstractType.Enums = value; }
        }

        public override AbstractPartialClassEventCollectionWithCodeAnalysis Events
        {
            get { return abstractType.Events; }
            set { abstractType.Events = value; }
        }

        public override AbstractPartialClassFieldCollectionWithCodeAnalysis Fields
        {
            get { return abstractType.Fields; }
            set { abstractType.Fields = value; }
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
            get { return abstractType.Indexers; }
            set { abstractType.Indexers = value; }
        }

        public override ICollection<AbstractPartialClassNestedInterfaceWithCodeAnalysis> Interfaces
        {
            get { return abstractType.Interfaces; }
            set { abstractType.Interfaces = value; }
        }

        public override AbstractPartialClassMethodCollectionWithCodeAnalysis Methods
        {
            get { return abstractType.Methods; }
            set { abstractType.Methods = value; }
        }

        public override string Name
        {
            get { return classType.Name; }
            set { classType.Name = value; }
        }

        public override ICollection<AbstractPartialClassOperatorOverloadWithCodeAnalysis> OperatorOverloads
        {
            get { return abstractType.OperatorOverloads; }
            set { abstractType.OperatorOverloads = value; }
        }

        public override AbstractPartialClassPropertyCollectionWithCodeAnalysis Properties
        {
            get { return abstractType.Properties; }
            set { abstractType.Properties = value; }
        }

        public override AbstractPartialClassStaticConstructorWithCodeAnalysis StaticConstructor
        {
            get { return abstractType.StaticConstructor; }
            set { abstractType.StaticConstructor = value; }
        }

        public override AbstractPartialClassNestedStructCollectionWithCodeAnalysis Structs
        {
            get { return abstractType.Structs; }
            set { abstractType.Structs = value; }
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
        
        INode<ClassDeclarationSyntax> IHasNode<ClassDeclarationSyntax>.Node
        {
            get { return classType.Class.Class.Node; }
        }

        IAbstractTypeWithCodeAnalysis IAbstractPartialTypeWithCodeAnalysis.Class => classType.Class.Class;
    }
}
