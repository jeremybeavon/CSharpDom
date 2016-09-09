﻿using System;
using System.Collections;
using System.Collections.Generic;
using CSharpDom.Common;
using CSharpDom.Wrappers.Internal;

namespace CSharpDom.Editable
{
    public abstract class EditableStructIndexerCollection<TIndexer, TExplicitInterfaceIndexer> :
        IStructIndexerCollection<TIndexer, TExplicitInterfaceIndexer>
        where TIndexer : IStructIndexer
        where TExplicitInterfaceIndexer : IExplicitInterfaceIndexer
    {
        public int Count
        {
            get { return Indexers.Count + ExplicitInterfaceIndexers.Count; }
        }

        public abstract ICollection<TExplicitInterfaceIndexer> ExplicitInterfaceIndexers { get; set; }

        public abstract ICollection<TIndexer> Indexers { get; set; }

        IReadOnlyCollection<TExplicitInterfaceIndexer> IHasExplicitInterfaceIndexers<TExplicitInterfaceIndexer>.ExplicitInterfaceIndexers
        {
            get { return new ReadOnlyCollectionWrapper<TExplicitInterfaceIndexer>(ExplicitInterfaceIndexers); }
        }

        public void Accept(IGenericVisitor visitor)
        {
            visitor.VisitStructIndexerCollection(this);
        }

        public void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitStructIndexerCollectionChildren(this, visitor);
        }

        public IEnumerator<TIndexer> GetEnumerator()
        {
            return Indexers.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
