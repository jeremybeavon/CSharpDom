using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.Wrappers.Internal
{
    internal sealed class ClassNestedClassWrapper : AbstractWrapper<IClassNestedClass>, IClassNestedClassWrapper
    {
        public ClassNestedClassWrapper(IClassNestedClass nestedClass)
            : base(nestedClass)
        {
        }

        public IReadOnlyCollection<IAttributeGroupWrapper> Attributes
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public IClassReferenceWrapper BaseClass
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public IClassNestedClassCollectionWrapper Classes
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public IReadOnlyCollection<IClassConstructorWrapper> Constructors
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

        public IClassTypeWrapper DeclaringType
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public IReadOnlyCollection<IClassNestedDelegateWrapper> Delegates
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public INestedDestructorWrapper Destructor
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public IReadOnlyCollection<IClassNestedEnumWrapper> Enums
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public IClassEventCollectionWrapper Events
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public IClassFieldCollectionWrapper Fields
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

        public IClassIndexerCollectionWrapper Indexers
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public IReadOnlyCollection<IClassNestedInterfaceWrapper> Interfaces
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public IClassMethodCollectionWrapper Methods
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

        public IClassPropertyCollectionWrapper Properties
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

        public IClassNestedStructCollectionWrapper Structs
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

        public override void VisitClassNestedClass<TAttributeGroup, TDeclaringType, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TNestedDestructor, TStaticConstructor>(
            IClassNestedClass<TAttributeGroup, TDeclaringType, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TNestedDestructor, TStaticConstructor> nestedClass)
        {
        }
    }
}
