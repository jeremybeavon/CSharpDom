﻿using CSharpDom.Common;
using CSharpDom.BaseClasses.Editable;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.Reflection;

namespace CSharpDom.CodeAnalysis
{
    public sealed class ClassWithCodeAnalysis :
        EditableClass<
            NamespaceWithCodeAnalysis,
            DocumentWithCodeAnalysis,
            ProjectWithCodeAnalysis,
            SolutionWithCodeAnalysis,
            AttributeGroupWithCodeAnalysis,
            GenericParameterDeclarationWithCodeAnalysis,
            ClassReferenceWithCodeAnalysis,
            InterfaceReferenceWithCodeAnalysis,
            ClassEventCollectionWithCodeAnalysis,
            ClassPropertyCollectionWithCodeAnalysis,
            ClassIndexerCollectionWithCodeAnalysis,
            ClassMethodCollectionWithCodeAnalysis,
            ClassFieldCollectionWithCodeAnalysis,
            ClassConstructorWithCodeAnalysis,
            ClassOperatorOverloadWithCodeAnalysis,
            ClassConversionOperatorWithCodeAnalysis,
            ClassNestedClassCollectionWithCodeAnalysis,
            ClassNestedDelegateWithCodeAnalysis,
            ClassNestedEnumWithCodeAnalysis,
            ClassNestedInterfaceWithCodeAnalysis,
            ClassNestedStructCollectionWithCodeAnalysis,
            ClassStaticConstructorWithCodeAnalysis,
            ClassDestructorWithCodeAnalysis>,
        IHasSyntax<ClassDeclarationSyntax>,
        IClassTypeWithCodeAnalysis,
        IHasNode<ClassDeclarationSyntax>//,
        //IVisitable<IReflectionVisitor>
    {
        private readonly ClassTypeWithCodeAnalysis classType;
        private readonly DocumentWithCodeAnalysis document;

        public ClassWithCodeAnalysis(
            DocumentWithCodeAnalysis document,
            TypeVisibilityModifier visibility,
            string name)
            : this(document)
        {
            Syntax = ClassDeclarationSyntaxExtensions.ToSyntax(name, visibility);
        }

        internal ClassWithCodeAnalysis(DocumentWithCodeAnalysis document, ClassTypeWithCodeAnalysis type = null)
        {
            classType = type ?? new InternalClassTypeWithCodeAnalysis<ClassWithCodeAnalysis>(this);
            this.document = document;
        }

        public ClassTypeWithCodeAnalysis Class
        {
            get { return classType; }
        }

        public override ICollection<AttributeGroupWithCodeAnalysis> Attributes
        {
            get { return classType.Attributes; }
            set { classType.Attributes = value; }
        }

        public override ClassNestedClassCollectionWithCodeAnalysis Classes
        {
            get { return classType.Classes; }
            set { classType.Classes = value; }
        }

        public override ICollection<ClassConstructorWithCodeAnalysis> Constructors
        {
            get { return classType.Constructors; }
            set { classType.Constructors = value; }
        }

        public override ICollection<ClassConversionOperatorWithCodeAnalysis> ConversionOperators
        {
            get { return classType.ConversionOperators; }
            set { classType.ConversionOperators = value; }
        }

        public override ICollection<ClassNestedDelegateWithCodeAnalysis> Delegates
        {
            get { return classType.Delegates; }
            set { classType.Delegates = value; }
        }

        public override ClassDestructorWithCodeAnalysis Destructor
        {
            get { return classType.Destructor; }
            set { classType.Destructor = value; }
        }

        public override ICollection<ClassNestedEnumWithCodeAnalysis> Enums
        {
            get { return classType.Enums; }
            set { classType.Enums = value; }
        }
        
        public override ClassEventCollectionWithCodeAnalysis Events
        {
            get { return classType.Events; }
            set { classType.Events = value; }
        }

        public override ClassFieldCollectionWithCodeAnalysis Fields
        {
            get { return classType.Fields; }
            set { classType.Fields = value; }
        }

        public override IList<GenericParameterDeclarationWithCodeAnalysis> GenericParameters
        {
            get { return classType.GenericParameters; }
            set { classType.GenericParameters = value; }
        }

        public override ClassIndexerCollectionWithCodeAnalysis Indexers
        {
            get { return classType.Indexers; }
            set { classType.Indexers = value; }
        }

        public override ICollection<ClassNestedInterfaceWithCodeAnalysis> Interfaces
        {
            get { return classType.Interfaces; }
            set { classType.Interfaces = value; }
        }

        public override ClassMethodCollectionWithCodeAnalysis Methods
        {
            get { return classType.Methods; }
            set { classType.Methods = value; }
        }

        public override string Name
        {
            get { return classType.Name; }
            set { classType.Name = value; }
        }
        
        public override ICollection<ClassOperatorOverloadWithCodeAnalysis> OperatorOverloads
        {
            get { return classType.OperatorOverloads; }
            set { classType.OperatorOverloads = value; }
        }
        
        public override ClassPropertyCollectionWithCodeAnalysis Properties
        {
            get { return classType.Properties; }
            set { classType.Properties = value; }
        }
        
        public override ClassNestedStructCollectionWithCodeAnalysis Structs
        {
            get { return classType.Structs; }
            set { classType.Structs = value; }
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
        
        public override ClassStaticConstructorWithCodeAnalysis StaticConstructor
        {
            get { return classType.StaticConstructor; }
            set { classType.StaticConstructor = value; }
        }
        
        public ClassDeclarationSyntax Syntax
        {
            get { return classType.Syntax; }
            set { classType.Syntax = value; }
        }
        
        public override DocumentWithCodeAnalysis Document
        {
            get { return document; }
            set { throw new NotSupportedException(); }
        }

        public override NamespaceWithCodeAnalysis Namespace
        {
            get { return classType.Node.GetParent<NamespaceWithCodeAnalysis>(); }
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

        INode<ClassDeclarationSyntax> IHasNode<ClassDeclarationSyntax>.Node
        {
            get { return classType.Node; }
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
