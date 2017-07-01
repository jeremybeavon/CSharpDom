using CSharpDom.BaseClasses;
using CSharpDom.Reflection.Internal;
using CSharpDom.Reflection.Internal.Hiding;
using System;
using System.Collections.Generic;
using System.Reflection;

namespace CSharpDom.Reflection
{
    public sealed class SealedClassWithReflection :
        AbstractSealedClass<
            NamespaceWithReflection,
            AssemblyWithReflection,
            AssemblyWithReflection,
            AssemblyWithReflection,
            AttributeWithReflection,
            GenericParameterDeclarationWithReflection,
            ClassReferenceWithReflection,
            InterfaceReferenceWithReflection,
            SealedClassEventCollectionWithReflection,
            SealedClassPropertyCollectionWithReflection,
            SealedClassIndexerCollectionWithReflection,
            SealedClassMethodCollectionWithReflection,
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
        IInternalTypeWithReflection,
        IHasType//,
        //IVisitable<IReflectionVisitor>
    {
        private readonly AssemblyWithReflection assembly;
        private readonly NamespaceWithReflection @namespace;
        private readonly Type type;
        private readonly ClassReferenceWithReflection baseClass;
        private readonly SealedTypeWithReflection typeWithReflection;
        private readonly Lazy<DestructorWithReflection> destructor;
        private readonly HiddenMembersAnalyzer hiddenMembersAnalyzer;

        internal SealedClassWithReflection(AssemblyWithReflection assembly, NamespaceWithReflection @namespace, Type type)
        {
            this.assembly = assembly;
            this.@namespace = @namespace;
            this.type = type;
            if (type.BaseType != null && type.BaseType != typeof(object))
            {
                baseClass = new ClassReferenceWithReflection(type.BaseType);
            }

            hiddenMembersAnalyzer = new HiddenMembersAnalyzer(type);
            typeWithReflection = new SealedTypeWithReflection(this);
            destructor = new Lazy<DestructorWithReflection>(InitializeDestructor);
        }

        public override IReadOnlyCollection<AttributeWithReflection> Attributes
        {
            get { return typeWithReflection.Attributes; }
        }

        public override ClassNestedClassCollectionWithReflection Classes
        {
            get { return typeWithReflection.Classes; }
        }

        public override IReadOnlyCollection<ClassConstructorWithReflection> Constructors
        {
            get { return typeWithReflection.Constructors; }
        }

        public override IReadOnlyCollection<ConversionOperatorWithReflection> ConversionOperators
        {
            get { return typeWithReflection.ConversionOperators; }
        }

        public override IReadOnlyCollection<ClassNestedDelegateWithReflection> Delegates
        {
            get { return typeWithReflection.Delegates; }
        }

        public override DestructorWithReflection Destructor
        {
            get { return destructor.Value; }
        }

        public override IReadOnlyCollection<ClassNestedEnumWithReflection> Enums
        {
            get { return typeWithReflection.Enums; }
        }
        
        public override SealedClassEventCollectionWithReflection Events
        {
            get { return typeWithReflection.Events; }
        }

        public override ClassFieldCollectionWithReflection Fields
        {
            get { return typeWithReflection.Fields; }
        }

        public override IReadOnlyList<GenericParameterDeclarationWithReflection> GenericParameters
        {
            get { return typeWithReflection.GenericParameters; }
        }

        public override SealedClassIndexerCollectionWithReflection Indexers
        {
            get { return typeWithReflection.Indexers; }
        }

        public override IReadOnlyCollection<ClassNestedInterfaceWithReflection> Interfaces
        {
            get { return typeWithReflection.Interfaces; }
        }

        public override SealedClassMethodCollectionWithReflection Methods
        {
            get { return typeWithReflection.Methods; }
        }

        public override string Name
        {
            get { return type.Name(); }
        }

        public override NamespaceWithReflection Namespace
        {
            get { return @namespace; }
        }

        public override IReadOnlyCollection<OperatorOverloadWithReflection> OperatorOverloads
        {
            get { return typeWithReflection.OperatorOverloads; }
        }

        public override AssemblyWithReflection Project
        {
            get { return assembly; }
        }

        public override SealedClassPropertyCollectionWithReflection Properties
        {
            get { return typeWithReflection.Properties; }
        }

        public override AssemblyWithReflection Solution
        {
            get { return assembly; }
        }

        public override ClassNestedStructCollectionWithReflection Structs
        {
            get { return typeWithReflection.Structs; }
        }

        public override ClassReferenceWithReflection BaseClass
        {
            get { return baseClass; }
        }

        public override IReadOnlyCollection<InterfaceReferenceWithReflection> ImplementedInterfaces
        {
            get { return typeWithReflection.ImplementedInterfaces; }
        }
        
        public override TypeVisibilityModifier Visibility
        {
            get { return type.Visibility(); }
        }

        public Type Type
        {
            get { return type; }
        }
        
        public override StaticConstructorWithReflection StaticConstructor
        {
            get { return typeWithReflection.StaticConstructor; }
        }

        public override AssemblyWithReflection Document
        {
            get { return assembly; }
        }

        internal SealedTypeWithReflection TypeWithReflection
        {
            get { return typeWithReflection; }
        }

        HiddenMembersAnalyzer IInternalTypeWithReflection.HiddenMembersAnalyzer
        {
            get { return hiddenMembersAnalyzer; }
        }

        private DestructorWithReflection InitializeDestructor()
        {
            MethodInfo method = typeWithReflection.Destructor;
            return method == null ? null : new DestructorWithReflection(this, method);
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
