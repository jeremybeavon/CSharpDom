using CSharpDom.BaseClasses;
using CSharpDom.Mono.Cecil.Internal;
using CSharpDom.Mono.Cecil.Internal.Hiding;
using Mono.Cecil;
using System;
using System.Collections.Generic;
using System.Reflection;

namespace CSharpDom.Mono.Cecil
{
    public sealed class SealedClassWithMonoCecil :
        AbstractSealedClass<
            NamespaceWithMonoCecil,
            AssemblyWithMonoCecil,
            AssemblyWithMonoCecil,
            AssemblyWithMonoCecil,
            AttributeWithMonoCecil,
            GenericParameterDeclarationWithMonoCecil,
            ClassReferenceWithMonoCecil,
            InterfaceReferenceWithMonoCecil,
            SealedClassEventCollectionWithMonoCecil,
            SealedClassPropertyCollectionWithMonoCecil,
            SealedClassIndexerCollectionWithMonoCecil,
            SealedClassMethodCollectionWithMonoCecil,
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
        IInternalTypeWithMonoCecil,
        IHasTypeDefinition//,
        //IVisitable<IReflectionVisitor>
    {
        private readonly AssemblyWithMonoCecil assembly;
        private readonly NamespaceWithMonoCecil @namespace;
        private readonly TypeDefinition type;
        private readonly ClassReferenceWithMonoCecil baseClass;
        private readonly SealedTypeWithMonoCecil typeWithMonoCecil;
        private readonly Lazy<DestructorWithMonoCecil> destructor;
        private readonly HiddenMembersAnalyzer hiddenMembersAnalyzer;

        internal SealedClassWithMonoCecil(AssemblyWithMonoCecil assembly, NamespaceWithMonoCecil @namespace, TypeDefinition type)
        {
            this.assembly = assembly;
            this.@namespace = @namespace;
            this.type = type;
            if (type.BaseType != null && type.FullName != "System.Object")
            {
                baseClass = new ClassReferenceWithMonoCecil(assembly, type.BaseType);
            }

            hiddenMembersAnalyzer = new HiddenMembersAnalyzer(assembly, type);
            typeWithMonoCecil = new SealedTypeWithMonoCecil(this);
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
        
        public override SealedClassEventCollectionWithMonoCecil Events
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

        public override SealedClassIndexerCollectionWithMonoCecil Indexers
        {
            get { return typeWithMonoCecil.Indexers; }
        }

        public override ClassNestedInterfaceCollectionWithMonoCecil Interfaces
        {
            get { return typeWithMonoCecil.Interfaces; }
        }

        public override SealedClassMethodCollectionWithMonoCecil Methods
        {
            get { return typeWithMonoCecil.Methods; }
        }

        public override string Name
        {
            get { return type.Name; }
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

        public override SealedClassPropertyCollectionWithMonoCecil Properties
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

        public TypeDefinition TypeDefinition
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

        internal SealedTypeWithMonoCecil TypeWithMonoCecil
        {
            get { return typeWithMonoCecil; }
        }

        HiddenMembersAnalyzer IInternalTypeWithMonoCecil.HiddenMembersAnalyzer
        {
            get { return hiddenMembersAnalyzer; }
        }

        public AssemblyWithMonoCecil Assembly
        {
            get { return assembly; }
        }

        private DestructorWithMonoCecil InitializeDestructor()
        {
            MethodDefinition method = typeWithMonoCecil.Destructor;
            return method == null ? null : new DestructorWithMonoCecil(assembly, this, method);
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
