﻿using CSharpDom.BaseClasses;
using CSharpDom.Reflection.Internal;
using System;
using System.Collections.Generic;
using System.Reflection;

namespace CSharpDom.Reflection
{
    public sealed class ClassWithReflection :
        AbstractClass<
            NamespaceWithReflection,
            AssemblyWithReflection,
            AssemblyWithReflection,
            AssemblyWithReflection,
            AttributeWithReflection,
            GenericParameterDeclarationWithReflection,
            ClassReferenceWithReflection,
            InterfaceReferenceWithReflection,
            ClassEventWithReflection,
            ClassPropertyWithReflection,
            ClassIndexerWithReflection,
            ClassMethodWithReflection,
            ClassFieldWithReflection,
            ClassConstructorWithReflection,
            ClassEventPropertyWithReflection,
            OperatorOverloadWithReflection,
            ConversionOperatorWithReflection,
            ClassNestedClassWithReflection,
            ClassNestedDelegateWithReflection,
            ClassNestedEnumWithReflection,
            ClassNestedInterfaceWithReflection,
            ClassNestedStructWithReflection,
            DestructorWithReflection,
            StaticConstructorWithReflection,
            ExplicitInterfaceEventWithReflection,
            ExplicitInterfacePropertyWithReflection,
            ExplicitInterfaceIndexerWithReflection,
            ExplicitInterfaceMethodWithReflection>,
        ITypeWithReflection,
        IHasType//,
        //IVisitable<IReflectionVisitor>
    {
        private readonly AssemblyWithReflection assembly;
        private readonly NamespaceWithReflection @namespace;
        private readonly Type type;
        private readonly ClassReferenceWithReflection baseClass;
        private readonly ClassTypeWithReflection typeWithReflection;
        private readonly Lazy<DestructorWithReflection> destructor;

        internal ClassWithReflection(AssemblyWithReflection assembly, NamespaceWithReflection @namespace, Type type)
        {
            this.assembly = assembly;
            this.@namespace = @namespace;
            this.type = type;
            if (type.BaseType != null && type.BaseType != typeof(object))
            {
                baseClass = new ClassReferenceWithReflection(type.BaseType);
            }

            typeWithReflection = new ClassTypeWithReflection(this, type);
            destructor = new Lazy<DestructorWithReflection>(InitializeDestructor);
        }

        public override IReadOnlyCollection<AttributeWithReflection> Attributes
        {
            get { return typeWithReflection.Attributes; }
        }

        public override IReadOnlyCollection<ClassNestedClassWithReflection> Classes
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

        public override IReadOnlyCollection<ClassEventPropertyWithReflection> EventProperties
        {
            get { return typeWithReflection.EventProperties; }
        }

        public override IReadOnlyCollection<ClassEventWithReflection> Events
        {
            get { return typeWithReflection.Events; }
        }

        public override IReadOnlyCollection<ClassFieldWithReflection> Fields
        {
            get { return typeWithReflection.Fields; }
        }

        public override IReadOnlyList<GenericParameterDeclarationWithReflection> GenericParameters
        {
            get { return typeWithReflection.GenericParameters; }
        }

        public override IReadOnlyCollection<ClassIndexerWithReflection> Indexers
        {
            get { return typeWithReflection.Indexers; }
        }

        public override IReadOnlyCollection<ClassNestedInterfaceWithReflection> Interfaces
        {
            get { return typeWithReflection.Interfaces; }
        }

        public override IReadOnlyCollection<ClassMethodWithReflection> Methods
        {
            get { return typeWithReflection.Methods; }
        }

        public override string Name
        {
            get { return type.Name; }
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

        public override IReadOnlyCollection<ClassPropertyWithReflection> Properties
        {
            get { return typeWithReflection.Properties; }
        }

        public override AssemblyWithReflection Solution
        {
            get { return assembly; }
        }

        public override IReadOnlyCollection<ClassNestedStructWithReflection> Structs
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
        
        public override IReadOnlyCollection<ExplicitInterfaceEventWithReflection> ExplicitInterfaceEvents
        {
            get { return typeWithReflection.ExplicitInterfaceEvents; }
        }

        public override IReadOnlyCollection<ExplicitInterfaceIndexerWithReflection> ExplicitInterfaceIndexers
        {
            get { return typeWithReflection.ExplicitInterfaceIndexers; }
        }

        public override IReadOnlyCollection<ExplicitInterfaceMethodWithReflection> ExplicitInterfaceMethods
        {
            get { return typeWithReflection.ExplicitInterfaceMethods; }
        }

        public override IReadOnlyCollection<ExplicitInterfacePropertyWithReflection> ExplicitInterfaceProperties
        {
            get { return typeWithReflection.ExplicitInterfaceProperties; }
        }

        public override StaticConstructorWithReflection StaticConstructor
        {
            get { return typeWithReflection.StaticConstructor; }
        }

        public override AssemblyWithReflection Document
        {
            get { return assembly; }
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