using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses;
using CSharpDom.Reflection.Internal;

namespace CSharpDom.Reflection.Internal
{
    internal sealed class NestedClassWithReflection :
        AbstractNestedClass<
            AttributeWithReflection,
            ITypeWithReflection,
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
            NestedDestructorWithReflection,
            StaticConstructorWithReflection,
            ExplicitInterfaceEventWithReflection,
            ExplicitInterfacePropertyWithReflection,
            ExplicitInterfaceIndexerWithReflection,
            ExplicitInterfaceMethodWithReflection>,
        ITypeWithReflection,
        IHasType
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

        /*public override IReadOnlyCollection<NestedClassWithReflection> Classes
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
        }*/
        
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

        public override ClassReferenceWithReflection BaseClass
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public override ITypeWithReflection DeclaringType
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public override NestedDestructorWithReflection Destructor
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public override IReadOnlyList<GenericParameterDeclarationWithReflection> GenericParameters
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public override IReadOnlyCollection<InterfaceReferenceWithReflection> ImplementedInterfaces
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public override TypeInheritanceModifier InheritanceModifier
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public override bool IsPartial
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public override string Name
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public override IReadOnlyCollection<ClassNestedClassWithReflection> Classes
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public override IReadOnlyCollection<ClassConstructorWithReflection> Constructors
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public override IReadOnlyCollection<ConversionOperatorWithReflection> ConversionOperators
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public override IReadOnlyCollection<ClassNestedDelegateWithReflection> Delegates
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public override IReadOnlyCollection<ClassNestedEnumWithReflection> Enums
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public override IReadOnlyCollection<ClassEventPropertyWithReflection> EventProperties
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public override IReadOnlyCollection<ClassFieldWithReflection> Fields
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public override IReadOnlyCollection<ClassNestedInterfaceWithReflection> Interfaces
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public override IReadOnlyCollection<OperatorOverloadWithReflection> OperatorOverloads
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public override IReadOnlyCollection<ClassNestedStructWithReflection> Structs
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public override IReadOnlyCollection<ClassEventWithReflection> Events
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public override IReadOnlyCollection<ClassIndexerWithReflection> Indexers
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public override IReadOnlyCollection<ClassMethodWithReflection> Methods
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public override IReadOnlyCollection<ClassPropertyWithReflection> Properties
        {
            get
            {
                throw new NotImplementedException();
            }
        }
    }
}
