using CSharpDom.BaseClasses;
using CSharpDom.Reflection.Internal;
using System;
using System.Collections.Generic;

namespace CSharpDom.Reflection
{
    public sealed class ClassWithReflection :
        AbstractClass<
            NamespaceWithReflection,
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
        private readonly TypeWithReflection typeWithReflection;
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

            typeWithReflection = new TypeWithReflection(this, type);
            destructor = new Lazy<DestructorWithReflection>(() => new DestructorWithReflection(this, typeWithReflection.Destructor));
        }

        public override IReadOnlyCollection<AttributeWithReflection> Attributes
        {
            get { return typeWithReflection.Attributes; }
        }

        /*public override IReadOnlyCollection<NestedClassWithReflection> Classes
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

        public override IReadOnlyCollection<NestedDelegateWithReflection> Delegates
        {
            get { return typeWithReflection.Delegates; }
        }

        public override DestructorWithReflection Destructor
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

        public override IReadOnlyCollection<MethodWithReflection> Methods
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

        public override IReadOnlyCollection<PropertyWithReflection> Properties
        {
            get { return typeWithReflection.Properties; }
        }

        public override AssemblyWithReflection Solution
        {
            get { return assembly; }
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

        public override TypeVisibilityModifier Visibility
        {
            get { return type.Visibility(); }
        }*/

        public Type Type
        {
            get { return type; }
        }

        public override bool IsPartial
        {
            get { return false; }
        }

        public override ClassReferenceWithReflection BaseClass
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public override DestructorWithReflection Destructor
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

        public override string Name
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public override NamespaceWithReflection Namespace
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public override AssemblyWithReflection Project
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public override AssemblyWithReflection Solution
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public override TypeVisibilityModifier Visibility
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

        public override IReadOnlyCollection<ExplicitInterfaceEventWithReflection> ExplicitInterfaceEvents
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public override IReadOnlyCollection<ExplicitInterfaceIndexerWithReflection> ExplicitInterfaceIndexers
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public override IReadOnlyCollection<ExplicitInterfaceMethodWithReflection> ExplicitInterfaceMethods
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public override IReadOnlyCollection<ExplicitInterfacePropertyWithReflection> ExplicitInterfaceProperties
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

        public override StaticConstructorWithReflection StaticConstructor
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
