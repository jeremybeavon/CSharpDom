using CSharpDom.Editable;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;

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
            StaticClassNestedInterfaceCollectionWithCodeAnalysis,
            StaticClassNestedStructCollectionWithCodeAnalysis,
            StaticConstructorWithCodeAnalysis>,
        IHasSyntax<ClassDeclarationSyntax>,
        IHasNode<ClassDeclarationSyntax>//,
        //IVisitable<IReflectionVisitor>
    {
        private readonly StaticTypeWithCodeAnalysis type;
        private readonly DocumentWithCodeAnalysis document;

        internal StaticClassWithCodeAnalysis(DocumentWithCodeAnalysis document)
        {
            type = new StaticTypeWithCodeAnalysis();
            this.document = document;
        }

        public StaticTypeWithCodeAnalysis Type
        {
            get { return type; }
        }

        public override ICollection<AttributeGroupWithCodeAnalysis> Attributes
        {
            get { return type.Attributes; }
            set { type.Attributes = value; }
        }

        public override StaticClassNestedClassCollectionWithCodeAnalysis Classes
        {
            get { return type.Classes; }
            set { type.Classes = value; }
        }
        
        public override ICollection<StaticClassNestedDelegateWithCodeAnalysis> Delegates
        {
            get { return type.Delegates; }
            set { type.Delegates = value; }
        }
        
        public override ICollection<StaticClassNestedEnumWithCodeAnalysis> Enums
        {
            get { return type.Enums; }
            set { type.Enums = value; }
        }
        
        public override StaticClassEventCollectionWithCodeAnalysis Events
        {
            get { return type.Events; }
            set { type.Events = value; }
        }

        public override StaticClassFieldCollectionWithCodeAnalysis Fields
        {
            get { return type.Fields; }
            set { type.Fields = value; }
        }

        public override IList<GenericParameterDeclarationWithCodeAnalysis> GenericParameters
        {
            get { return type.GenericParameters; }
            set { type.GenericParameters = value; }
        }
        
        public override StaticClassNestedInterfaceCollectionWithCodeAnalysis Interfaces
        {
            get { return type.Interfaces; }
            set { type.Interfaces = value; }
        }

        public override StaticClassMethodCollectionWithCodeAnalysis Methods
        {
            get { return type.Methods; }
            set { type.Methods = value; }
        }

        public override string Name
        {
            get { return type.Name; }
            set { type.Name = value; }
        }

        public override ICollection<StaticClassPropertyWithCodeAnalysis> Properties
        {
            get { return type.Properties; }
            set { type.Properties = value; }
        }
        
        public override StaticClassNestedStructCollectionWithCodeAnalysis Structs
        {
            get { return type.Structs; }
            set { type.Structs = value; }
        }
        
        public override StaticConstructorWithCodeAnalysis StaticConstructor
        {
            get { return type.StaticConstructor; }
            set { type.StaticConstructor = value; }
        }
        public override DocumentWithCodeAnalysis Document
        {
            get { return document; }
            set { throw new NotSupportedException(); }
        }
        
        public override NamespaceWithCodeAnalysis Namespace
        {
            get { return type.Node.GetParentNode<NamespaceWithCodeAnalysis>(); }
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
            get { return type.Syntax; }
            set { type.Syntax = value; }
        }

        INode<ClassDeclarationSyntax> IHasNode<ClassDeclarationSyntax>.Node
        {
            get { return type.Node; }
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
