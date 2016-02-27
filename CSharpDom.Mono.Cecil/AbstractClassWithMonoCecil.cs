using CSharpDom.BaseClasses;
using System;
using System.Collections.Generic;

namespace CSharpDom.Mono.Cecil
{
    public sealed class AbstractClassWithMonoCecil :
        AbstractAbstractClass<
            NamespaceWithMonoCecil,
            AssemblyWithMonoCecil,
            AssemblyWithMonoCecil,
            AssemblyWithMonoCecil,
            AttributeWithMonoCecil,
            GenericParameterDeclarationWithMonoCecil,
            ClassReferenceWithMonoCecil,
            InterfaceReferenceWithMonoCecil,
            AbstractClassEventCollectionWithMonoCecil,
            AbstractClassPropertyCollectionWithMonoCecil,
            AbstractClassIndexerCollectionWithMonoCecil,
            AbstractClassMethodCollectionWithMonoCecil,
            ClassFieldCollectionWithMonoCecil,
            ClassConstructorWithMonoCecil,
            OperatorOverloadWithMonoCecil,
            ConversionOperatorWithMonoCecil,
            ClassNestedClassCollectionWithMonoCecil,
            ClassNestedDelegateWithMonoCecil,
            ClassNestedEnumWithMonoCecil,
            ClassNestedInterfaceCollectionWithMonoCecil,
            ClassNestedStructCollectionWithMonoCecil,
            DestructorWithMonoCecil,
            StaticConstructorWithMonoCecil>,
        ITypeWithMonoCecil,
        IHasType//,
        //IVisitable<IReflectionVisitor>
    {
        private readonly ClassWithMonoCecil classWithMonoCecil;
        private readonly AbstractClassEventCollectionWithMonoCecil events;
        private readonly AbstractClassIndexerCollectionWithMonoCecil indexers;
        private readonly AbstractClassMethodCollectionWithMonoCecil methods;
        private readonly AbstractClassPropertyCollectionWithMonoCecil properties;

        internal AbstractClassWithMonoCecil(AssemblyWithMonoCecil assembly, NamespaceWithMonoCecil @namespace, Type type)
        {
            classWithMonoCecil = new ClassWithMonoCecil(assembly, @namespace, type);
            events = new AbstractClassEventCollectionWithMonoCecil(classWithMonoCecil.TypeWithMonoCecil);
            indexers = new AbstractClassIndexerCollectionWithMonoCecil(classWithMonoCecil.TypeWithMonoCecil);
            methods = new AbstractClassMethodCollectionWithMonoCecil(classWithMonoCecil.TypeWithMonoCecil);
            properties = new AbstractClassPropertyCollectionWithMonoCecil(classWithMonoCecil.TypeWithMonoCecil);
        }

        public override IReadOnlyCollection<AttributeWithMonoCecil> Attributes
        {
            get { return classWithMonoCecil.Attributes; }
        }

        public override ClassNestedClassCollectionWithMonoCecil Classes
        {
            get { return classWithMonoCecil.Classes; }
        }

        public override IReadOnlyCollection<ClassConstructorWithMonoCecil> Constructors
        {
            get { return classWithMonoCecil.Constructors; }
        }

        public override IReadOnlyCollection<ConversionOperatorWithMonoCecil> ConversionOperators
        {
            get { return classWithMonoCecil.ConversionOperators; }
        }

        public override IReadOnlyCollection<ClassNestedDelegateWithMonoCecil> Delegates
        {
            get { return classWithMonoCecil.Delegates; }
        }

        public override DestructorWithMonoCecil Destructor
        {
            get { return classWithMonoCecil.Destructor; }
        }

        public override IReadOnlyCollection<ClassNestedEnumWithMonoCecil> Enums
        {
            get { return classWithMonoCecil.Enums; }
        }
        
        public override AbstractClassEventCollectionWithMonoCecil Events
        {
            get { return events; }
        }

        public override ClassFieldCollectionWithMonoCecil Fields
        {
            get { return classWithMonoCecil.Fields; }
        }

        public override IReadOnlyList<GenericParameterDeclarationWithMonoCecil> GenericParameters
        {
            get { return classWithMonoCecil.GenericParameters; }
        }

        public override AbstractClassIndexerCollectionWithMonoCecil Indexers
        {
            get { return indexers; }
        }

        public override ClassNestedInterfaceCollectionWithMonoCecil Interfaces
        {
            get { return classWithMonoCecil.Interfaces; }
        }

        public override AbstractClassMethodCollectionWithMonoCecil Methods
        {
            get { return methods; }
        }

        public override string Name
        {
            get { return classWithMonoCecil.Name; }
        }

        public override NamespaceWithMonoCecil Namespace
        {
            get { return classWithMonoCecil.Namespace; }
        }

        public override IReadOnlyCollection<OperatorOverloadWithMonoCecil> OperatorOverloads
        {
            get { return classWithMonoCecil.OperatorOverloads; }
        }

        public override AssemblyWithMonoCecil Project
        {
            get { return classWithMonoCecil.Project; }
        }

        public override AbstractClassPropertyCollectionWithMonoCecil Properties
        {
            get { return properties; }
        }

        public override AssemblyWithMonoCecil Solution
        {
            get { return classWithMonoCecil.Solution; }
        }

        public override ClassNestedStructCollectionWithMonoCecil Structs
        {
            get { return classWithMonoCecil.Structs; }
        }

        public override ClassReferenceWithMonoCecil BaseClass
        {
            get { return classWithMonoCecil.BaseClass; }
        }

        public override IReadOnlyCollection<InterfaceReferenceWithMonoCecil> ImplementedInterfaces
        {
            get { return classWithMonoCecil.ImplementedInterfaces; }
        }
        
        public override TypeVisibilityModifier Visibility
        {
            get { return classWithMonoCecil.Visibility; }
        }

        public Type Type
        {
            get { return classWithMonoCecil.Type; }
        }
        
        public override StaticConstructorWithMonoCecil StaticConstructor
        {
            get { return classWithMonoCecil.StaticConstructor; }
        }

        public override AssemblyWithMonoCecil Document
        {
            get { return classWithMonoCecil.Document; }
        }
        
        /*public void Accept(IReflectionVisitor visitor)
        {
            visitor.VisitClassWithMonoCecil(this);
        }

        public void AcceptChildren(IReflectionVisitor visitor)
        {
            AcceptChildren(new ForwardingGenericVisitor(visitor));
        }*/
    }
}
