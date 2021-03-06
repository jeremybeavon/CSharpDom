﻿using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.Wrappers.Internal
{
    internal sealed class NamespaceWrapper : AbstractWrapper<INamespace>, INamespaceWrapper
    {
        public NamespaceWrapper(INamespace @namespace)
            : base(@namespace)
        {
        }

        public IClassCollectionWrapper Classes
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public IReadOnlyCollection<IDelegateWrapper> Delegates
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public IReadOnlyCollection<IEnumWrapper> Enums
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public IReadOnlyCollection<IInterfaceWrapper> Interfaces
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

        public IReadOnlyCollection<INamespaceWrapper> Namespaces
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public IStructCollectionWrapper Structs
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public IReadOnlyCollection<IUsingDirectiveWrapper> UsingDirectives
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

        public override void VisitNamespace<TUsingDirective, TNamespace, TClassCollection, TDelegate, TEnum, TInterface, TStructCollection>(
            INamespace<TUsingDirective, TNamespace, TClassCollection, TDelegate, TEnum, TInterface, TStructCollection> @namespace)
        {
        }
    }
}
