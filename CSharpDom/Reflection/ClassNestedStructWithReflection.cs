using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses;
using CSharpDom.Reflection.Internal;

namespace CSharpDom.Reflection
{
    public sealed class ClassNestedStructWithReflection :
        AbstractClassNestedStruct<
            AttributeWithReflection,
            ITypeWithReflection,
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
            ExplicitInterfaceMethodWithReflection>
    {
        private readonly NestedStructWithReflection nestedStruct;

        internal ClassNestedStructWithReflection(ITypeWithReflection declaringType, Type type)
        {
            nestedStruct = new NestedStructWithReflection(declaringType, type);
        }

        public override IReadOnlyCollection<AttributeWithReflection> Attributes
        {
            get
            {
                throw new NotImplementedException();
            }
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

        public override ITypeWithReflection DeclaringType
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

        public override IReadOnlyCollection<OperatorOverloadWithReflection> OperatorOverloads
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

        public override ClassMemberVisibilityModifier Visibility
        {
            get
            {
                throw new NotImplementedException();
            }
        }
    }
}
