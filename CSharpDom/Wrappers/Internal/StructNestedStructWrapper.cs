using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.Wrappers.Internal
{
    internal sealed class StructNestedStructWrapper : AbstractWrapper<IStructNestedStruct>, IStructNestedStructWrapper
    {
        public StructNestedStructWrapper(IStructNestedStruct nestedStruct)
            : base(nestedStruct)
        {
        }

        public IReadOnlyCollection<IAttributeGroupWrapper> Attributes
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public IStructNestedClassCollectionWrapper Classes
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public IReadOnlyCollection<IStructConstructorWrapper> Constructors
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public IReadOnlyCollection<IConversionOperatorWrapper> ConversionOperators
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public IStructTypeWrapper DeclaringType
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public IReadOnlyCollection<IStructNestedDelegateWrapper> Delegates
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public IReadOnlyCollection<IStructNestedEnumWrapper> Enums
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public IStructEventCollectionWrapper Events
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public IStructFieldCollectionWrapper Fields
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public IReadOnlyList<IGenericParameterDeclarationWrapper> GenericParameters
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public IReadOnlyCollection<IInterfaceReferenceWrapper> ImplementedInterfaces
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public IStructIndexerCollectionWrapper Indexers
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public IStructNestedInterfaceWrapper Interfaces
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public IStructMethodCollectionWrapper Methods
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public string Name
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public IReadOnlyCollection<IOperatorOverloadWrapper> OperatorOverloads
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public IStructPropertyCollectionWrapper Properties
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public IStaticConstructorWrapper StaticConstructor
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public IStructNestedStructCollectionWrapper Structs
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public StructMemberVisibilityModifier Visibility
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public void Accept(IGenericVisitor visitor)
        {
            throw new NotImplementedException();
        }

        public void AcceptChildren(IGenericVisitor visitor)
        {
            throw new NotImplementedException();
        }

        public override void VisitStructNestedStruct<TAttributeGroup, TDeclaringType, TGenericParameter, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor>(
            IStructNestedStruct<TAttributeGroup, TDeclaringType, TGenericParameter, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor> nestedStruct)
        {
        }
    }
}
