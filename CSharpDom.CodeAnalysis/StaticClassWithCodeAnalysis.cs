using CSharpDom.BaseClasses.Editable;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharpDom.CodeAnalysis
{
    public sealed class StaticClassWithCodeAnalysis :
        EditableStaticClass<
            NamespaceWithCodeAnalysis,
            DocumentWithCodeAnalysis,
            ProjectWithCodeAnalysis,
            SolutionWithCodeAnalysis,
            AttributeGroupWithCodeAnalysis,
            GenericParameterDeclarationWithCodeAnalysis,
            StaticClassEventCollectionWithCodeAnalysis,
            StaticClassPropertyWithCodeAnalysis,
            StaticClassMethodCollectionWithCodeAnalysis,
            StaticClassFieldCollectionWithCodeAnalysis,
            StaticClassNestedClassCollectionWithCodeAnalysis,
            StaticClassNestedDelegateWithCodeAnalysis,
            StaticClassNestedEnumWithCodeAnalysis,
            StaticClassNestedInterfaceWithCodeAnalysis,
            StaticClassNestedStructCollectionWithCodeAnalysis,
            StaticConstructorWithCodeAnalysis>,
        IHasSyntax<ClassDeclarationSyntax>,
        IHasNode<ClassDeclarationSyntax>//,
        //IVisitable<IReflectionVisitor>
    {
        private readonly DocumentWithCodeAnalysis document;
        private readonly StaticTypeWithCodeAnalysis classType;

        internal StaticClassWithCodeAnalysis(DocumentWithCodeAnalysis document, StaticTypeWithCodeAnalysis type = null)
        {
            this.document = document;
            classType = type ?? new InternalStaticTypeWithCodeAnalysis<StaticClassWithCodeAnalysis>(this);
        }

        public override ICollection<AttributeGroupWithCodeAnalysis> Attributes
        {
            get { return classType.Attributes; }
            set { classType.Attributes = value; }
        }

        public override StaticClassNestedClassCollectionWithCodeAnalysis Classes
        {
            get { return classType.Classes; }
            set { classType.Classes = value; }
        }

        public override ICollection<StaticClassNestedEnumWithCodeAnalysis> Enums
        {
            get { return classType.Enums; }
            set { classType.Enums = value; }
        }

        public override ICollection<StaticClassNestedDelegateWithCodeAnalysis> Delegates
        {
            get { return classType.Delegates; }
            set { classType.Delegates = value; }
        }

        public override StaticClassEventCollectionWithCodeAnalysis Events
        {
            get { return classType.Events; }
            set { classType.Events = value; }
        }

        public override StaticClassFieldCollectionWithCodeAnalysis Fields
        {
            get { return classType.Fields; }
            set { classType.Fields = value; }
        }

        public override IList<GenericParameterDeclarationWithCodeAnalysis> GenericParameters
        {
            get { return classType.GenericParameters; }
            set { classType.GenericParameters = value; }
        }

        public override ICollection<StaticClassNestedInterfaceWithCodeAnalysis> Interfaces
        {
            get { return classType.Interfaces; }
            set { classType.Interfaces = value; }
        }

        public override StaticClassMethodCollectionWithCodeAnalysis Methods
        {
            get { return classType.Methods; }
            set { classType.Methods = value; }
        }

        public override string Name
        {
            get { return classType.Name; }
            set { classType.Name = value; }
        }

        public override ICollection<StaticClassPropertyWithCodeAnalysis> Properties
        {
            get { return classType.Properties; }
            set { classType.Properties = value; }
        }

        public override StaticConstructorWithCodeAnalysis StaticConstructor
        {
            get { return classType.StaticConstructor; }
            set { classType.StaticConstructor = value; }
        }

        public override StaticClassNestedStructCollectionWithCodeAnalysis Structs
        {
            get { return classType.Structs; }
            set { classType.Structs = value; }
        }

        public override DocumentWithCodeAnalysis Document
        {
            get { return document; }
            set { throw new NotSupportedException(); }
        }
        
        public override NamespaceWithCodeAnalysis Namespace
        {
            get { return classType.Node.GetParentNode<NamespaceWithCodeAnalysis>(); }
            set { throw new NotSupportedException(); }
        }

        public override ProjectWithCodeAnalysis Project
        {
            get { return document.Project; }
            set { throw new NotSupportedException(); }
        }

        public override SolutionWithCodeAnalysis Solution
        {
            get { return document.Solution; }
            set { throw new NotSupportedException(); }
        }

        public override TypeVisibilityModifier Visibility
        {
            get { return Syntax.Modifiers.ToTypeVisibilityModifier(); }
            set
            {
                ClassDeclarationSyntax syntax = Syntax;
                Syntax = syntax.WithModifiers(syntax.Modifiers.WithTypeVisibilityModifier(value));
            }
        }

        public ClassDeclarationSyntax Syntax
        {
            get { return classType.Syntax; }
            set { classType.Syntax = value; }
        }

        INode<ClassDeclarationSyntax> IHasNode<ClassDeclarationSyntax>.Node
        {
            get { return classType.Node; }
        }

        internal INode<ClassDeclarationSyntax> Node => classType.Node;

        internal IMemberList Members
        {
            get { return classType.Members; }
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
