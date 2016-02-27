using CSharpDom.BaseClasses;
using CSharpDom.Mono.Cecil.Internal;
using CSharpDom.Mono.Cecil.Internal.Hiding;
using System;
using System.Collections.Generic;
using System.Reflection;

namespace CSharpDom.Mono.Cecil
{
    public sealed class ClassWithMonoCecil :
        AbstractClass<
            NamespaceWithMonoCecil,
            AssemblyWithMonoCecil,
            AssemblyWithMonoCecil,
            AssemblyWithMonoCecil,
            AttributeWithMonoCecil,
            GenericParameterDeclarationWithMonoCecil,
            ClassReferenceWithMonoCecil,
            InterfaceReferenceWithMonoCecil,
            ClassEventCollectionWithMonoCecil,
            ClassPropertyCollectionWithMonoCecil,
            ClassIndexerCollectionWithMonoCecil,
            ClassMethodCollectionWithMonoCecil,
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
        IClassTypeWithMonoCecil,
        IInternalTypeWithMonoCecil,
        IHasType//,
        //IVisitable<IReflectionVisitor>
    {
        private readonly AssemblyWithMonoCecil assembly;
        private readonly NamespaceWithMonoCecil @namespace;
        private readonly Type type;
        private readonly ClassReferenceWithMonoCecil baseClass;
        private readonly ClassTypeWithMonoCecil typeWithMonoCecil;
        private readonly Lazy<DestructorWithMonoCecil> destructor;
        private readonly HiddenMembersAnalyzer hiddenMembersAnalyzer;

        internal ClassWithMonoCecil(AssemblyWithMonoCecil assembly, NamespaceWithMonoCecil @namespace, Type type)
        {
            this.assembly = assembly;
            this.@namespace = @namespace;
            this.type = type;
            if (type.BaseType != null && type.BaseType != typeof(object))
            {
                baseClass = new ClassReferenceWithMonoCecil(type.BaseType);
            }

            hiddenMembersAnalyzer = new HiddenMembersAnalyzer(type);
            typeWithMonoCecil = new ClassTypeWithMonoCecil(this);
            destructor = new Lazy<DestructorWithMonoCecil>(InitializeDestructor);
        }

        public override IReadOnlyCollection<AttributeWithMonoCecil> Attributes
        {
            get { return typeWithMonoCecil.Attributes; }
        }

        public override ClassNestedClassCollectionWithMonoCecil Classes
        {
            get { return typeWithMonoCecil.Classes; }
        }

        public override IReadOnlyCollection<ClassConstructorWithMonoCecil> Constructors
        {
            get { return typeWithMonoCecil.Constructors; }
        }

        public override IReadOnlyCollection<ConversionOperatorWithMonoCecil> ConversionOperators
        {
            get { return typeWithMonoCecil.ConversionOperators; }
        }

        public override IReadOnlyCollection<ClassNestedDelegateWithMonoCecil> Delegates
        {
            get { return typeWithMonoCecil.Delegates; }
        }

        public override DestructorWithMonoCecil Destructor
        {
            get { return destructor.Value; }
        }

        public override IReadOnlyCollection<ClassNestedEnumWithMonoCecil> Enums
        {
            get { return typeWithMonoCecil.Enums; }
        }
        
        public override ClassEventCollectionWithMonoCecil Events
        {
            get { return typeWithMonoCecil.Events; }
        }

        public override ClassFieldCollectionWithMonoCecil Fields
        {
            get { return typeWithMonoCecil.Fields; }
        }

        public override IReadOnlyList<GenericParameterDeclarationWithMonoCecil> GenericParameters
        {
            get { return typeWithMonoCecil.GenericParameters; }
        }

        public override ClassIndexerCollectionWithMonoCecil Indexers
        {
            get { return typeWithMonoCecil.Indexers; }
        }

        public override ClassNestedInterfaceCollectionWithMonoCecil Interfaces
        {
            get { return typeWithMonoCecil.Interfaces; }
        }

        public override ClassMethodCollectionWithMonoCecil Methods
        {
            get { return typeWithMonoCecil.Methods; }
        }

        public override string Name
        {
            get { return type.Name(); }
        }

        public override NamespaceWithMonoCecil Namespace
        {
            get { return @namespace; }
        }

        public override IReadOnlyCollection<OperatorOverloadWithMonoCecil> OperatorOverloads
        {
            get { return typeWithMonoCecil.OperatorOverloads; }
        }

        public override AssemblyWithMonoCecil Project
        {
            get { return assembly; }
        }

        public override ClassPropertyCollectionWithMonoCecil Properties
        {
            get { return typeWithMonoCecil.Properties; }
        }

        public override AssemblyWithMonoCecil Solution
        {
            get { return assembly; }
        }

        public override ClassNestedStructCollectionWithMonoCecil Structs
        {
            get { return typeWithMonoCecil.Structs; }
        }

        public override ClassReferenceWithMonoCecil BaseClass
        {
            get { return baseClass; }
        }

        public override IReadOnlyCollection<InterfaceReferenceWithMonoCecil> ImplementedInterfaces
        {
            get { return typeWithMonoCecil.ImplementedInterfaces; }
        }
        
        public override TypeVisibilityModifier Visibility
        {
            get { return type.Visibility(); }
        }

        public Type Type
        {
            get { return type; }
        }
        
        public override StaticConstructorWithMonoCecil StaticConstructor
        {
            get { return typeWithMonoCecil.StaticConstructor; }
        }

        public override AssemblyWithMonoCecil Document
        {
            get { return assembly; }
        }

        internal ClassTypeWithMonoCecil TypeWithMonoCecil
        {
            get { return typeWithMonoCecil; }
        }

        HiddenMembersAnalyzer IInternalTypeWithMonoCecil.HiddenMembersAnalyzer
        {
            get { return hiddenMembersAnalyzer; }
        }

        private DestructorWithMonoCecil InitializeDestructor()
        {
            MethodInfo method = typeWithMonoCecil.Destructor;
            return method == null ? null : new DestructorWithMonoCecil(this, method);
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
