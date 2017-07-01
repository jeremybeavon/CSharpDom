using CSharpDom.BaseClasses;
using System;
using System.Collections.Generic;

namespace CSharpDom.Reflection
{
    public sealed class AbstractClassWithReflection :
        AbstractAbstractClass<
            NamespaceWithReflection,
            AssemblyWithReflection,
            AssemblyWithReflection,
            AssemblyWithReflection,
            AttributeWithReflection,
            GenericParameterDeclarationWithReflection,
            ClassReferenceWithReflection,
            InterfaceReferenceWithReflection,
            AbstractClassEventCollectionWithReflection,
            AbstractClassPropertyCollectionWithReflection,
            AbstractClassIndexerCollectionWithReflection,
            AbstractClassMethodCollectionWithReflection,
            ClassFieldCollectionWithReflection,
            ClassConstructorWithReflection,
            OperatorOverloadWithReflection,
            ConversionOperatorWithReflection,
            ClassNestedClassCollectionWithReflection,
            ClassNestedDelegateWithReflection,
            ClassNestedEnumWithReflection,
            ClassNestedInterfaceWithReflection,
            ClassNestedStructCollectionWithReflection,
            DestructorWithReflection,
            StaticConstructorWithReflection>,
        ITypeWithReflection,
        IHasType//,
        //IVisitable<IReflectionVisitor>
    {
        private readonly ClassWithReflection classWithReflection;
        private readonly AbstractClassEventCollectionWithReflection events;
        private readonly AbstractClassIndexerCollectionWithReflection indexers;
        private readonly AbstractClassMethodCollectionWithReflection methods;
        private readonly AbstractClassPropertyCollectionWithReflection properties;

        internal AbstractClassWithReflection(AssemblyWithReflection assembly, NamespaceWithReflection @namespace, Type type)
        {
            classWithReflection = new ClassWithReflection(assembly, @namespace, type);
            events = new AbstractClassEventCollectionWithReflection(classWithReflection.TypeWithReflection);
            indexers = new AbstractClassIndexerCollectionWithReflection(classWithReflection.TypeWithReflection);
            methods = new AbstractClassMethodCollectionWithReflection(classWithReflection.TypeWithReflection);
            properties = new AbstractClassPropertyCollectionWithReflection(classWithReflection.TypeWithReflection);
        }

        public override IReadOnlyCollection<AttributeWithReflection> Attributes
        {
            get { return classWithReflection.Attributes; }
        }

        public override ClassNestedClassCollectionWithReflection Classes
        {
            get { return classWithReflection.Classes; }
        }

        public override IReadOnlyCollection<ClassConstructorWithReflection> Constructors
        {
            get { return classWithReflection.Constructors; }
        }

        public override IReadOnlyCollection<ConversionOperatorWithReflection> ConversionOperators
        {
            get { return classWithReflection.ConversionOperators; }
        }

        public override IReadOnlyCollection<ClassNestedDelegateWithReflection> Delegates
        {
            get { return classWithReflection.Delegates; }
        }

        public override DestructorWithReflection Destructor
        {
            get { return classWithReflection.Destructor; }
        }

        public override IReadOnlyCollection<ClassNestedEnumWithReflection> Enums
        {
            get { return classWithReflection.Enums; }
        }
        
        public override AbstractClassEventCollectionWithReflection Events
        {
            get { return events; }
        }

        public override ClassFieldCollectionWithReflection Fields
        {
            get { return classWithReflection.Fields; }
        }

        public override IReadOnlyList<GenericParameterDeclarationWithReflection> GenericParameters
        {
            get { return classWithReflection.GenericParameters; }
        }

        public override AbstractClassIndexerCollectionWithReflection Indexers
        {
            get { return indexers; }
        }

        public override IReadOnlyCollection<ClassNestedInterfaceWithReflection> Interfaces
        {
            get { return classWithReflection.Interfaces; }
        }

        public override AbstractClassMethodCollectionWithReflection Methods
        {
            get { return methods; }
        }

        public override string Name
        {
            get { return classWithReflection.Name; }
        }

        public override NamespaceWithReflection Namespace
        {
            get { return classWithReflection.Namespace; }
        }

        public override IReadOnlyCollection<OperatorOverloadWithReflection> OperatorOverloads
        {
            get { return classWithReflection.OperatorOverloads; }
        }

        public override AssemblyWithReflection Project
        {
            get { return classWithReflection.Project; }
        }

        public override AbstractClassPropertyCollectionWithReflection Properties
        {
            get { return properties; }
        }

        public override AssemblyWithReflection Solution
        {
            get { return classWithReflection.Solution; }
        }

        public override ClassNestedStructCollectionWithReflection Structs
        {
            get { return classWithReflection.Structs; }
        }

        public override ClassReferenceWithReflection BaseClass
        {
            get { return classWithReflection.BaseClass; }
        }

        public override IReadOnlyCollection<InterfaceReferenceWithReflection> ImplementedInterfaces
        {
            get { return classWithReflection.ImplementedInterfaces; }
        }
        
        public override TypeVisibilityModifier Visibility
        {
            get { return classWithReflection.Visibility; }
        }

        public Type Type
        {
            get { return classWithReflection.Type; }
        }
        
        public override StaticConstructorWithReflection StaticConstructor
        {
            get { return classWithReflection.StaticConstructor; }
        }

        public override AssemblyWithReflection Document
        {
            get { return classWithReflection.Document; }
        }
        
        /*public void Accept(IReflectionVisitor visitor)
        {
            visitor.VisitClassWithReflection(this);
        }

        public void AcceptChildren(IReflectionVisitor visitor)
        {
            AcceptChildren(new ForwardingGenericVisitor(visitor));
        }*/
    }
}
