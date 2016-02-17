﻿using System;
using System.Collections;
using System.Collections.Generic;
using CSharpDom.Common;
using CSharpDom.Common.Partial;

namespace CSharpDom.BaseClasses
{
    public abstract class AbstractInterfaceCollection<TInterface, TPartialInterface> :
        IInterfaceCollection<TInterface, TPartialInterface>
        where TInterface : IInterface
        where TPartialInterface : IPartialInterface
    {
        public int Count
        {
            get { return PartialInterfaces.Count + Interfaces.Count; }
        }

        public abstract IReadOnlyCollection<TPartialInterface> PartialInterfaces { get; }

        protected abstract IReadOnlyCollection<TInterface> Interfaces { get; }

        public void Accept(IGenericVisitor visitor)
        {
            visitor.VisitInterfaceCollection(this);
        }

        public void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitInterfaceCollectionChildren(this, visitor);
        }

        public IEnumerator<TInterface> GetEnumerator()
        {
            return Interfaces.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
