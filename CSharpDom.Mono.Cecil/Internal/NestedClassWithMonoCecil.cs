using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses;
using CSharpDom.Mono.Cecil.Internal;
using CSharpDom.Mono.Cecil.Internal.Hiding;

namespace CSharpDom.Mono.Cecil.Internal
{
    internal sealed class NestedClassWithMonoCecil :
        AbstractNestedClass<
            AttributeWithMonoCecil,
            ITypeWithMonoCecil,
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
            NestedDestructorWithMonoCecil,
            StaticConstructorWithMonoCecil>,
        ITypeWithMonoCecil,
        IInternalTypeWithMonoCecil,
        IHasType
    {
        private readonly ITypeWithMonoCecil declaringType;
        private readonly HiddenMembersAnalyzer hiddenMembersAnalyzer;
        private readonly Type type;
        private readonly ClassReferenceWithMonoCecil baseClass;
        private readonly ClassTypeWithMonoCecil typeWithMonoCecil;
        private readonly Lazy<NestedDestructorWithMonoCecil> destructor;

        internal NestedClassWithMonoCecil(ITypeWithMonoCecil declaringType, Type type)
        {
            this.declaringType = declaringType;
            hiddenMembersAnalyzer = new HiddenMembersAnalyzer(type);
            this.type = type;
            if (type.BaseType != null && type.BaseType != typeof(object))
            {
                baseClass = new ClassReferenceWithMonoCecil(type.BaseType);
            }

            typeWithMonoCecil = new ClassTypeWithMonoCecil(this);
            destructor = new Lazy<NestedDestructorWithMonoCecil>(
                () => new NestedDestructorWithMonoCecil(this, typeWithMonoCecil.Destructor));
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

        public override ITypeWithMonoCecil DeclaringType
        {
            get { return declaringType; }
        }

        public override IReadOnlyCollection<ClassNestedDelegateWithMonoCecil> Delegates
        {
            get { return typeWithMonoCecil.Delegates; }
        }

        public override NestedDestructorWithMonoCecil Destructor
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
            get { return type.Name; }
        }
        
        public override IReadOnlyCollection<OperatorOverloadWithMonoCecil> OperatorOverloads
        {
            get { return typeWithMonoCecil.OperatorOverloads; }
        }
        
        public override ClassPropertyCollectionWithMonoCecil Properties
        {
            get { return typeWithMonoCecil.Properties; }
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
        
        public Type Type
        {
            get { return type; }
        }
        
        public override StaticConstructorWithMonoCecil StaticConstructor
        {
            get { return typeWithMonoCecil.StaticConstructor; }
        }

        public HiddenMembersAnalyzer HiddenMembersAnalyzer
        {
            get { return hiddenMembersAnalyzer; }
        }

        public ClassTypeWithMonoCecil TypeWithMonoCecil
        {
            get { return typeWithMonoCecil; }
        }
    }
}
