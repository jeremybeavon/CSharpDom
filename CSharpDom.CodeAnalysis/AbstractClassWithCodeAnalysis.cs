using CSharpDom.BaseClasses;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;

namespace CSharpDom.CodeAnalysis
{
    public sealed class AbstractClassWithCodeAnalysis :
        AbstractAbstractClass<
            NamespaceWithCodeAnalysis,
            AssemblyWithCodeAnalysis,
            AssemblyWithCodeAnalysis,
            AssemblyWithCodeAnalysis,
            AttributeGroupWithCodeAnalysis,
            GenericParameterDeclarationWithCodeAnalysis,
            ClassReferenceWithCodeAnalysis,
            InterfaceReferenceWithCodeAnalysis,
            AbstractClassEventCollectionWithCodeAnalysis,
            AbstractClassPropertyCollectionWithCodeAnalysis,
            AbstractClassIndexerCollectionWithCodeAnalysis,
            AbstractClassMethodCollectionWithCodeAnalysis,
            ClassFieldCollectionWithCodeAnalysis,
            ClassConstructorWithCodeAnalysis,
            OperatorOverloadWithCodeAnalysis,
            ConversionOperatorWithCodeAnalysis,
            ClassNestedClassCollectionWithCodeAnalysis,
            ClassNestedDelegateWithCodeAnalysis,
            ClassNestedEnumWithCodeAnalysis,
            ClassNestedInterfaceCollectionWithCodeAnalysis,
            ClassNestedStructCollectionWithCodeAnalysis,
            DestructorWithCodeAnalysis,
            StaticConstructorWithCodeAnalysis>,
        ITypeWithCodeAnalysis,
        IHasTypeDefinition//,
        //IVisitable<IReflectionVisitor>
    {
        private readonly ClassWithCodeAnalysis classWithCodeAnalysis;
        private readonly AbstractClassEventCollectionWithCodeAnalysis events;
        private readonly AbstractClassIndexerCollectionWithCodeAnalysis indexers;
        private readonly AbstractClassMethodCollectionWithCodeAnalysis methods;
        private readonly AbstractClassPropertyCollectionWithCodeAnalysis properties;

        internal AbstractClassWithCodeAnalysis(AssemblyWithCodeAnalysis assembly, NamespaceWithCodeAnalysis @namespace, TypeDefinition type)
        {
            classWithCodeAnalysis = new ClassWithCodeAnalysis(assembly, @namespace, type);
            events = new AbstractClassEventCollectionWithCodeAnalysis(classWithCodeAnalysis.TypeWithCodeAnalysis);
            indexers = new AbstractClassIndexerCollectionWithCodeAnalysis(classWithCodeAnalysis.TypeWithCodeAnalysis);
            methods = new AbstractClassMethodCollectionWithCodeAnalysis(classWithCodeAnalysis.TypeWithCodeAnalysis);
            properties = new AbstractClassPropertyCollectionWithCodeAnalysis(classWithCodeAnalysis.TypeWithCodeAnalysis);
        }

        public override IReadOnlyCollection<AttributeGroupWithCodeAnalysis> Attributes
        {
            get { return classWithCodeAnalysis.Attributes; }
        }

        public override ClassNestedClassCollectionWithCodeAnalysis Classes
        {
            get { return classWithCodeAnalysis.Classes; }
        }

        public override IReadOnlyCollection<ClassConstructorWithCodeAnalysis> Constructors
        {
            get { return classWithCodeAnalysis.Constructors; }
        }

        public override IReadOnlyCollection<ConversionOperatorWithCodeAnalysis> ConversionOperators
        {
            get { return classWithCodeAnalysis.ConversionOperators; }
        }

        public override IReadOnlyCollection<ClassNestedDelegateWithCodeAnalysis> Delegates
        {
            get { return classWithCodeAnalysis.Delegates; }
        }

        public override DestructorWithCodeAnalysis Destructor
        {
            get { return classWithCodeAnalysis.Destructor; }
        }

        public override IReadOnlyCollection<ClassNestedEnumWithCodeAnalysis> Enums
        {
            get { return classWithCodeAnalysis.Enums; }
        }
        
        public override AbstractClassEventCollectionWithCodeAnalysis Events
        {
            get { return events; }
        }

        public override ClassFieldCollectionWithCodeAnalysis Fields
        {
            get { return classWithCodeAnalysis.Fields; }
        }

        public override IReadOnlyList<GenericParameterDeclarationWithCodeAnalysis> GenericParameters
        {
            get { return classWithCodeAnalysis.GenericParameters; }
        }

        public override AbstractClassIndexerCollectionWithCodeAnalysis Indexers
        {
            get { return indexers; }
        }

        public override ClassNestedInterfaceCollectionWithCodeAnalysis Interfaces
        {
            get { return classWithCodeAnalysis.Interfaces; }
        }

        public override AbstractClassMethodCollectionWithCodeAnalysis Methods
        {
            get { return methods; }
        }

        public override string Name
        {
            get { return classWithCodeAnalysis.Name; }
        }

        public override NamespaceWithCodeAnalysis Namespace
        {
            get { return classWithCodeAnalysis.Namespace; }
        }

        public override IReadOnlyCollection<OperatorOverloadWithCodeAnalysis> OperatorOverloads
        {
            get { return classWithCodeAnalysis.OperatorOverloads; }
        }

        public override AssemblyWithCodeAnalysis Project
        {
            get { return classWithCodeAnalysis.Project; }
        }

        public override AbstractClassPropertyCollectionWithCodeAnalysis Properties
        {
            get { return properties; }
        }

        public override AssemblyWithCodeAnalysis Solution
        {
            get { return classWithCodeAnalysis.Solution; }
        }

        public override ClassNestedStructCollectionWithCodeAnalysis Structs
        {
            get { return classWithCodeAnalysis.Structs; }
        }

        public override ClassReferenceWithCodeAnalysis BaseClass
        {
            get { return classWithCodeAnalysis.BaseClass; }
        }

        public override IReadOnlyCollection<InterfaceReferenceWithCodeAnalysis> ImplementedInterfaces
        {
            get { return classWithCodeAnalysis.ImplementedInterfaces; }
        }
        
        public override TypeVisibilityModifier Visibility
        {
            get { return classWithCodeAnalysis.Visibility; }
        }

        public TypeDefinition TypeDefinition
        {
            get { return classWithCodeAnalysis.TypeDefinition; }
        }
        
        public override StaticConstructorWithCodeAnalysis StaticConstructor
        {
            get { return classWithCodeAnalysis.StaticConstructor; }
        }

        public override AssemblyWithCodeAnalysis Document
        {
            get { return classWithCodeAnalysis.Document; }
        }

        public AssemblyWithCodeAnalysis Assembly
        {
            get { return classWithCodeAnalysis.Assembly; }
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
