using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses;
using CSharpDom.Reflection.Internal;

namespace CSharpDom.Reflection
{
    public sealed class StructWithReflection :
        AbstractStruct<
            NamespaceWithReflection,
            AssemblyWithReflection,
            AssemblyWithReflection,
            AttributeWithReflection,
            GenericParameterDeclarationWithReflection,
            InterfaceReferenceWithReflection,
            StructEventWithReflection,
            StructPropertyWithReflection,
            StructIndexerWithReflection,
            StructMethodWithReflection,
            StructFieldWithReflection,
            StructConstructorWithReflection,
            StructEventPropertyWithReflection,
            OperatorOverloadWithReflection,
            ConversionOperatorWithReflection,
            StructNestedClassWithReflection,
            StructNestedDelegateWithReflection,
            StructNestedEnumWithReflection,
            StructNestedInterfaceWithReflection,
            StructNestedStructWithReflection,
            StaticConstructorWithReflection,
            ExplicitInterfaceEventWithReflection,
            ExplicitInterfacePropertyWithReflection,
            ExplicitInterfaceIndexerWithReflection,
            ExplicitInterfaceMethodWithReflection>//,
        //ITypeWithReflection,
        //IVisitable<IReflectionVisitor>
    {
        private readonly AssemblyWithReflection assembly;
        private readonly NamespaceWithReflection @namespace;
        private readonly Type type;
        private readonly TypeWithReflection typeWithReflection;

        internal StructWithReflection(AssemblyWithReflection assembly, NamespaceWithReflection @namespace, Type type)
        {
            this.assembly = assembly;
            this.@namespace = @namespace;
            this.type = type;
            typeWithReflection = new TypeWithReflection(null, type);
        }

        public override IReadOnlyCollection<AttributeWithReflection> Attributes
        {
            get { return typeWithReflection.Attributes; }
        }

        public override IReadOnlyCollection<StructNestedClassWithReflection> Classes
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public override IReadOnlyCollection<StructConstructorWithReflection> Constructors
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

        public override IReadOnlyCollection<StructNestedDelegateWithReflection> Delegates
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public override IReadOnlyCollection<StructNestedEnumWithReflection> Enums
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public override IReadOnlyCollection<StructEventPropertyWithReflection> EventProperties
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public override IReadOnlyCollection<StructEventWithReflection> Events
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

        public override IReadOnlyCollection<StructFieldWithReflection> Fields
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

        public override IReadOnlyCollection<StructIndexerWithReflection> Indexers
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public override IReadOnlyCollection<StructNestedInterfaceWithReflection> Interfaces
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

        public override IReadOnlyCollection<StructMethodWithReflection> Methods
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

        public override IReadOnlyCollection<OperatorOverloadWithReflection> OperatorOverloads
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

        public override IReadOnlyCollection<StructPropertyWithReflection> Properties
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

        public override StaticConstructorWithReflection StaticConstructor
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public override IReadOnlyCollection<StructNestedStructWithReflection> Structs
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

        public override bool IsPartial
        {
            get { return false; }
        }

        public void Accept(IReflectionVisitor visitor)
        {
            visitor.VisitStructWithReflection(this);
        }

        public void AcceptChildren(IReflectionVisitor visitor)
        {
            AcceptChildren(new ForwardingGenericVisitor(visitor));
        }*/
    }
}
