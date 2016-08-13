using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.Wrappers.Internal
{
    internal sealed class StaticClassNestedStructWrapper : AbstractWrapper<IStaticClassNestedStruct>, IStaticClassNestedStructWrapper
    {
        public StaticClassNestedStructWrapper(IStaticClassNestedStruct nestedStruct)
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

        public IStaticTypeWrapper DeclaringType
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

        public IStructNestedInterfaceCollectionWrapper Interfaces
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

        public ClassMemberVisibilityModifier Visibility
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

        public override void VisitStaticClassNestedStruct<TAttributeGroup, TDeclaringType, TGenericParameter, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterfaceCollection, TNestedStructCollection, TStaticConstructor>(
            IStaticClassNestedStruct<TAttributeGroup, TDeclaringType, TGenericParameter, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterfaceCollection, TNestedStructCollection, TStaticConstructor> nestedStruct)
        {
        }
    }
}
