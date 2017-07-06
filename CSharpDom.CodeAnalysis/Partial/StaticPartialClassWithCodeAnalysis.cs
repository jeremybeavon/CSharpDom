using CSharpDom.Editable.Partial;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;

namespace CSharpDom.CodeAnalysis.Partial
{
    public sealed class StaticPartialClassWithCodeAnalysis :
        EditableStaticPartialClass<
            NamespaceWithCodeAnalysis,
            DocumentWithCodeAnalysis,
            ProjectWithCodeAnalysis,
            SolutionWithCodeAnalysis,
            AttributeGroupWithCodeAnalysis,
            GenericParameterDeclarationWithCodeAnalysis,
            StaticClassEventCollectionWithCodeAnalysis,
            StaticClassPropertyWithCodeAnalysis,
            StaticPartialClassMethodCollectionWithCodeAnalysis,
            StaticClassFieldCollectionWithCodeAnalysis,
            StaticClassNestedClassCollectionWithCodeAnalysis,
            StaticClassNestedDelegateWithCodeAnalysis,
            StaticClassNestedEnumWithCodeAnalysis,
            StaticClassNestedInterfaceWithCodeAnalysis,
            StaticClassNestedStructCollectionWithCodeAnalysis,
            StaticConstructorWithCodeAnalysis>,
        IHasSyntax<ClassDeclarationSyntax>,
        IHasNode<ClassDeclarationSyntax>,
        IStaticPartialTypeWithCodeAnalysis//,
        //IVisitable<IReflectionVisitor>
    {
        private readonly StaticClassWithCodeAnalysis type;
        private readonly StaticPartialClassMethodCollectionWithCodeAnalysis methods;

        internal StaticPartialClassWithCodeAnalysis(DocumentWithCodeAnalysis document)
        {
            type = new StaticClassWithCodeAnalysis(document);
            methods = new StaticPartialClassMethodCollectionWithCodeAnalysis(type.Type);
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
        
        public override ICollection<StaticClassNestedInterfaceWithCodeAnalysis> Interfaces
        {
            get { return type.Interfaces; }
            set { type.Interfaces = value; }
        }

        public override StaticPartialClassMethodCollectionWithCodeAnalysis Methods
        {
            get { return methods; }
            set { methods.Replace(value); }
        }

        public override string Name
        {
            get { return type.Name; }
            set { type.Name = value; }
        }

        public override NamespaceWithCodeAnalysis Namespace
        {
            get { return type.Namespace; }
            set { type.Namespace = value; }
        }
        
        public override ProjectWithCodeAnalysis Project
        {
            get { return type.Project; }
            set { type.Project = value; }
        }

        public override ICollection<StaticClassPropertyWithCodeAnalysis> Properties
        {
            get { return type.Properties; }
            set { type.Properties = value; }
        }

        public override SolutionWithCodeAnalysis Solution
        {
            get { return type.Solution; }
            set { type.Solution = value; }
        }

        public override StaticClassNestedStructCollectionWithCodeAnalysis Structs
        {
            get { return type.Structs; }
            set { type.Structs = value; }
        }
        
        public override TypeVisibilityModifier Visibility
        {
            get { return type.Visibility; }
            set { type.Visibility = value; }
        }
        
        public override StaticConstructorWithCodeAnalysis StaticConstructor
        {
            get { return type.StaticConstructor; }
            set { type.StaticConstructor = value; }
        }

        public override DocumentWithCodeAnalysis Document
        {
            get { return type.Document; }
            set { type.Document = value; }
        }
        
        public ClassDeclarationSyntax Syntax
        {
            get { return type.Syntax; }
            set { type.Syntax = value; }
        }

        INode<ClassDeclarationSyntax> IHasNode<ClassDeclarationSyntax>.Node
        {
            get { return type.Type.Node; }
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
