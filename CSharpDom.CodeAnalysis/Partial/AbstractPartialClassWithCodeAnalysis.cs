using CSharpDom.Common;
using CSharpDom.Editable.Partial;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace CSharpDom.CodeAnalysis.Partial
{
    public sealed class AbstractPartialClassWithCodeAnalysis :
        EditableAbstractPartialClass<
            NamespaceWithCodeAnalysis,
            DocumentWithCodeAnalysis,
            ProjectWithCodeAnalysis,
            SolutionWithCodeAnalysis,
            AttributeGroupWithCodeAnalysis,
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
        IAbstractPartialTypeWithCodeAnalysis//,
                                        //IVisitable<IReflectionVisitor>
    {
        private readonly AbstractClassWithCodeAnalysis classType;
        private readonly AbstractPartialTypeWithCodeAnalysis<AbstractPartialClassWithCodeAnalysis> partialType;

        internal AbstractPartialClassWithCodeAnalysis(DocumentWithCodeAnalysis document)
        {
            var abstractType = new InternalAbstractTypeWithCodeAnalysis<AbstractPartialClassWithCodeAnalysis>(this);
            classType = new AbstractClassWithCodeAnalysis(document, abstractType);
            partialType = new AbstractPartialTypeWithCodeAnalysis<AbstractPartialClassWithCodeAnalysis>(abstractType);
        }

        public AbstractClassWithCodeAnalysis Class
        {
            get { return classType; }
        }

        public override ICollection<AttributeGroupWithCodeAnalysis> Attributes
        {
            get { return classType.Attributes; }
            set { classType.Attributes = value; }
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

        public override AbstractPartialClassNestedStructCollectionWithCodeAnalysis Structs
        {
            get { return partialType.Structs; }
            set { partialType.Structs = value; }
        }

        public override ClassReferenceWithCodeAnalysis BaseClass
        {
            get { return classType.BaseClass; }
            set { classType.BaseClass = value; }
        }

        public override ICollection<InterfaceReferenceWithCodeAnalysis> ImplementedInterfaces
        {
            get { return classType.ImplementedInterfaces; }
            set { classType.ImplementedInterfaces = value; }
        }

        public override AbstractPartialClassStaticConstructorWithCodeAnalysis StaticConstructor
        {
            get { return partialType.StaticConstructor; }
            set { partialType.StaticConstructor = value; }
        }

        public ClassDeclarationSyntax Syntax
        {
            get { return classType.Syntax; }
            set { classType.Syntax = value; }
        }

        public override DocumentWithCodeAnalysis Document
        {
            get { return classType.Document; }
            set { classType.Document = value; }
        }

        public override NamespaceWithCodeAnalysis Namespace
        {
            get { return classType.Namespace; }
            set { classType.Namespace = value; }
        }

        public override ProjectWithCodeAnalysis Project
        {
            get { return classType.Project; }
            set { classType.Project = value; }
        }

        public override SolutionWithCodeAnalysis Solution
        {
            get { return classType.Solution; }
            set { classType.Solution = value; }
        }

        public override TypeVisibilityModifier Visibility
        {
            get { return classType.Visibility; }
            set { classType.Visibility = value; }
        }

        INode<ClassDeclarationSyntax> IHasNode<ClassDeclarationSyntax>.Node
        {
            get { return classType.Class.Node; }
        }

        /*public void Accept(IReflectionVisitor visitor)
        {
            visitor.VisitClassWithCodeAnalysis(this);
        }

        public void AcceptChildren(IReflectionVisitor visitor)
        {
            AcceptChildren(new ForwardingGenericVisitor(visitor));
        }*/
    }
}
