using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses;
using CSharpDom.Reflection.Internal;

namespace CSharpDom.Reflection
{
    public sealed class SealedClassNestedStructWithReflection :
        AbstractSealedClassNestedStruct<
            AttributeWithReflection,
            ITypeWithReflection,
            GenericParameterDeclarationWithReflection,
            InterfaceReferenceWithReflection,
            StructEventCollectionWithReflection,
            StructPropertyCollectionWithReflection,
            StructIndexerCollectionWithReflection,
            StructMethodCollectionWithReflection,
            StructFieldCollectionWithReflection,
            StructConstructorWithReflection,
            OperatorOverloadWithReflection,
            ConversionOperatorWithReflection,
            StructNestedClassCollectionWithReflection,
            StructNestedDelegateWithReflection,
            StructNestedEnumWithReflection,
            StructNestedInterfaceCollectionWithReflection,
            StructNestedStructCollectionWithReflection,
            StaticConstructorWithReflection>
    {
        private readonly NestedStructWithReflection nestedStruct;

        internal SealedClassNestedStructWithReflection(ITypeWithReflection declaringType, Type type)
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

        public override StructNestedClassCollectionWithReflection Classes
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

        public override StructEventCollectionWithReflection Events
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public override StructFieldCollectionWithReflection Fields
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

        public override StructIndexerCollectionWithReflection Indexers
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public override StructNestedInterfaceCollectionWithReflection Interfaces
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public override StructMethodCollectionWithReflection Methods
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

        public override StructPropertyCollectionWithReflection Properties
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

        public override StructNestedStructCollectionWithReflection Structs
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
