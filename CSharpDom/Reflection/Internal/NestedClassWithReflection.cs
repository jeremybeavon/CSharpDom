﻿using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses;
using CSharpDom.Reflection.Internal;
using CSharpDom.Reflection.Internal.Hiding;
using System.Reflection;

namespace CSharpDom.Reflection.Internal
{
    internal sealed class NestedClassWithReflection :
        AbstractNestedClass<
            AttributeWithReflection,
            ITypeWithReflection,
            GenericParameterDeclarationWithReflection,
            ClassReferenceWithReflection,
            InterfaceReferenceWithReflection,
            ClassEventCollectionWithReflection,
            ClassPropertyCollectionWithReflection,
            ClassIndexerCollectionWithReflection,
            ClassMethodCollectionWithReflection,
            ClassFieldCollectionWithReflection,
            ClassConstructorWithReflection,
            OperatorOverloadWithReflection,
            ConversionOperatorWithReflection,
            ClassNestedClassCollectionWithReflection,
            ClassNestedDelegateWithReflection,
            ClassNestedEnumWithReflection,
            ClassNestedInterfaceWithReflection,
            ClassNestedStructCollectionWithReflection,
            StaticConstructorWithReflection,
            DestructorWithReflection>,
        IClassTypeWithReflection,
        ITypeWithReflection,
        IInternalTypeWithReflection,
        IHasType
    {
        private readonly ITypeWithReflection declaringType;
        private readonly HiddenMembersAnalyzer hiddenMembersAnalyzer;
        private readonly Type type;
        private readonly ClassReferenceWithReflection baseClass;
        private readonly ClassTypeWithReflection typeWithReflection;
        private readonly Lazy<DestructorWithReflection> destructor;

        internal NestedClassWithReflection(ITypeWithReflection declaringType, Type type)
        {
            this.declaringType = declaringType;
            hiddenMembersAnalyzer = new HiddenMembersAnalyzer(type);
            this.type = type;
            if (type.BaseType != null && type.BaseType != typeof(object))
            {
                baseClass = new ClassReferenceWithReflection(type.BaseType);
            }

            typeWithReflection = new ClassTypeWithReflection(this);
            destructor = new Lazy<DestructorWithReflection>(() =>
            {
                MethodInfo destructorMethod = typeWithReflection.Destructor;
                return destructorMethod == null ? null : new DestructorWithReflection(this, destructorMethod);
            });
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

        public override ITypeWithReflection DeclaringType
        {
            get { return declaringType; }
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
        
        public override ClassEventCollectionWithReflection Events
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

        public override ClassIndexerCollectionWithReflection Indexers
        {
            get { return typeWithReflection.Indexers; }
        }

        public override IReadOnlyCollection<ClassNestedInterfaceWithReflection> Interfaces
        {
            get { return typeWithReflection.Interfaces; }
        }
        
        public override ClassMethodCollectionWithReflection Methods
        {
            get { return typeWithReflection.Methods; }
        }

        public override string Name
        {
            get { return type.Name(); }
        }
        
        public override IReadOnlyCollection<OperatorOverloadWithReflection> OperatorOverloads
        {
            get { return typeWithReflection.OperatorOverloads; }
        }
        
        public override ClassPropertyCollectionWithReflection Properties
        {
            get { return typeWithReflection.Properties; }
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
        
        public Type Type
        {
            get { return type; }
        }
        
        public override StaticConstructorWithReflection StaticConstructor
        {
            get { return typeWithReflection.StaticConstructor; }
        }

        public HiddenMembersAnalyzer HiddenMembersAnalyzer
        {
            get { return hiddenMembersAnalyzer; }
        }

        public ClassTypeWithReflection TypeWithReflection
        {
            get { return typeWithReflection; }
        }
    }
}
