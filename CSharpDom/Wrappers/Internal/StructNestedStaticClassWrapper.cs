﻿using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.Wrappers.Internal
{
    internal sealed class StructNestedStaticClassWrapper : AbstractWrapper<IStructNestedStaticClass>, IStructNestedStaticClassWrapper
    {
        public StructNestedStaticClassWrapper(IStructNestedStaticClass nestedClass)
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

        public IStaticClassNestedClassCollectionWrapper Classes
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

        public IReadOnlyCollection<IStaticClassNestedDelegateWrapper> Delegates
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public IReadOnlyCollection<IStaticClassNestedEnumWrapper> Enums
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public IStaticClassEventCollectionWrapper Events
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public IStaticClassFieldCollectionWrapper Fields
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

        public IReadOnlyCollection<IStaticClassNestedInterfaceWrapper> Interfaces
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public INestedStaticClassMethodCollectionWrapper Methods
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

        public IStaticClassPropertyCollectionWrapper Properties
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

        public IStaticClassNestedStructCollectionWrapper Structs
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

        public override void VisitStructNestedStaticClass<TAttributeGroup, TDeclaringType, TGenericParameter, TEventCollection, TProperty, TMethodCollection, TFieldCollection, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor>(
            IStructNestedStaticClass<TAttributeGroup, TDeclaringType, TGenericParameter, TEventCollection, TProperty, TMethodCollection, TFieldCollection, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor> nestedClass)
        {
        }
    }
}
