﻿using System;
using System.Collections;
using System.Collections.Generic;
using CSharpDom.Common;
using CSharpDom.Wrappers.Internal;

namespace CSharpDom.Editable
{
    public class EditableClassCollection<TClass, TAbstractClass, TSealedClass, TStaticClass, TPartialClassCollection> :
        IClassCollection<TClass, TAbstractClass, TSealedClass, TStaticClass, TPartialClassCollection>
        where TClass : IClass
        where TAbstractClass : IAbstractClass
        where TSealedClass : ISealedClass
        where TStaticClass : IStaticClass
        where TPartialClassCollection : IPartialClassCollection
    {
        public virtual ICollection<TAbstractClass> AbstractClasses { get; set; }

        public int Count
        {
            get { return Classes.Count + AbstractClasses.Count + SealedClasses.Count + StaticClasses.Count + PartialClasses.Count; }
        }

        public virtual TPartialClassCollection PartialClasses { get; set; }

        public virtual ICollection<TSealedClass> SealedClasses { get; set; }

        public virtual ICollection<TStaticClass> StaticClasses { get; set; }

        public virtual ICollection<TClass> Classes { get; set; }

        IReadOnlyCollection<TAbstractClass> IHasAbstractClasses<TAbstractClass>.AbstractClasses
        {
            get { return new ReadOnlyCollectionWrapper<TAbstractClass>(AbstractClasses); }
        }

        IReadOnlyCollection<TSealedClass> IHasSealedClasses<TSealedClass>.SealedClasses
        {
            get { return new ReadOnlyCollectionWrapper<TSealedClass>(SealedClasses); }
        }

        IReadOnlyCollection<TStaticClass> IHasStaticClasses<TStaticClass>.StaticClasses
        {
            get { return new ReadOnlyCollectionWrapper<TStaticClass>(StaticClasses); }
        }

        public void Accept(IGenericVisitor visitor)
        {
            visitor.VisitClassCollection(this);
        }

        public void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitClassCollectionChildren(this, visitor);
        }

        public IEnumerator<TClass> GetEnumerator()
        {
            return Classes.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}