using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses;
using CSharpDom.Reflection.Internal;

namespace CSharpDom.Reflection
{
    public sealed class NestedClassWithReflection :
        AbstractNestedClass<
            AttributeWithReflection,
            ITypeWithReflection,
            GenericParameterDeclarationWithReflection,
            ClassReferenceWithReflection,
            InterfaceReferenceWithReflection,
            EventWithReflection,
            PropertyWithReflection,
            IndexerWithReflection,
            MethodWithReflection,
            FieldWithReflection,
            ConstructorWithReflection,
            EventPropertyWithReflection,
            OperatorOverloadWithReflection,
            ConversionOperatorWithReflection,
            NestedClassWithReflection,
            NestedDelegateWithReflection,
            NestedEnumWithReflection,
            NestedInterfaceWithReflection,
            NestedStructWithReflection,
            NestedDestructorWithReflection>,
        ITypeWithReflection,
        IHasType,
        IVisitable<IReflectionVisitor>
    {
        private readonly ITypeWithReflection declaringType;
        private readonly Type type;
        private readonly ClassReferenceWithReflection baseClass;
        private readonly TypeWithReflection typeWithReflection;
        private readonly Lazy<NestedDestructorWithReflection> destructor;

        internal NestedClassWithReflection(ITypeWithReflection declaringType, Type type)
        {
            this.declaringType = declaringType;
            this.type = type;
            if (type.BaseType != null && type.BaseType != typeof(object))
            {
                baseClass = new ClassReferenceWithReflection(type.BaseType);
            }

            typeWithReflection = new TypeWithReflection(this, type);
            destructor = new Lazy<NestedDestructorWithReflection>(
                () => new NestedDestructorWithReflection(this, typeWithReflection.Destructor));
        }

        public override IReadOnlyCollection<AttributeWithReflection> Attributes
        {
            get { return typeWithReflection.Attributes; }
        }

        public override IReadOnlyCollection<NestedClassWithReflection> Classes
        {
            get { return typeWithReflection.Classes; }
        }

        public override IReadOnlyCollection<ConstructorWithReflection> Constructors
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

        public override IReadOnlyCollection<NestedDelegateWithReflection> Delegates
        {
            get { return typeWithReflection.Delegates; }
        }

        public override NestedDestructorWithReflection Destructor
        {
            get { return destructor.Value; }
        }

        public override IReadOnlyCollection<NestedEnumWithReflection> Enums
        {
            get { return typeWithReflection.Enums; }
        }

        public override IReadOnlyCollection<EventPropertyWithReflection> EventProperties
        {
            get { return typeWithReflection.EventProperties; }
        }

        public override IReadOnlyCollection<EventWithReflection> Events
        {
            get { return typeWithReflection.Events; }
        }

        public override IReadOnlyCollection<FieldWithReflection> Fields
        {
            get { return typeWithReflection.Fields; }
        }

        public override IReadOnlyList<GenericParameterDeclarationWithReflection> GenericParameters
        {
            get { return typeWithReflection.GenericParameters; }
        }

        public override IReadOnlyCollection<IndexerWithReflection> Indexers
        {
            get { return typeWithReflection.Indexers; }
        }

        public override IReadOnlyCollection<NestedInterfaceWithReflection> Interfaces
        {
            get { return typeWithReflection.Interfaces; }
        }

        public override bool IsPartial
        {
            get { return false; }
        }

        public override IReadOnlyCollection<MethodWithReflection> Methods
        {
            get { return typeWithReflection.Methods; }
        }

        public override string Name
        {
            get { return type.Name; }
        }
        
        public override IReadOnlyCollection<OperatorOverloadWithReflection> OperatorOverloads
        {
            get { return typeWithReflection.OperatorOverloads; }
        }
        
        public override IReadOnlyCollection<PropertyWithReflection> Properties
        {
            get { return typeWithReflection.Properties; }
        }
        
        public override IReadOnlyCollection<NestedStructWithReflection> Structs
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

        public override TypeInheritanceModifier InheritanceModifier
        {
            get { return type.InheritanceModifier(); }
        }

        public override MemberVisibilityModifier Visibility
        {
            get { return type.NestedVisibility(); }
        }

        public Type Type
        {
            get { return type; }
        }
        
        public void Accept(IReflectionVisitor visitor)
        {
            visitor.VisitNestedClassWithReflection(this);
        }

        public void AcceptChildren(IReflectionVisitor visitor)
        {
            AcceptChildren(new ForwardingGenericVisitor(visitor));
        }
    }
}
