using System;
using System.Collections;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.Editable
{
    public class EditableNestedClassCollection<TClass, TAbstractClass, TSealedClass, TStaticClass, TPartialClassCollection> :
        INestedClassCollection<TClass, TAbstractClass, TSealedClass, TStaticClass, TPartialClassCollection>
        where TClass : INestedClass
        where TAbstractClass : INestedAbstractClass
        where TSealedClass : INestedSealedClass
        where TStaticClass : INestedStaticClass
        where TPartialClassCollection : IPartialClassCollection
    {
        public virtual IReadOnlyCollection<TAbstractClass> AbstractClasses { get; set; }

        public int Count
        {
            get { return Classes.Count + AbstractClasses.Count + SealedClasses.Count + StaticClasses.Count + PartialClasses.Count; }
        }

        public virtual TPartialClassCollection PartialClasses { get; set; }

        public virtual IReadOnlyCollection<TSealedClass> SealedClasses { get; set; }

        public virtual IReadOnlyCollection<TStaticClass> StaticClasses { get; set; }

        protected virtual IReadOnlyCollection<TClass> Classes { get; set; }

        public virtual void Accept(IGenericVisitor visitor)
        {
            visitor.VisitNestedClassCollection(this);
        }

        public virtual void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitNestedClassCollectionChildren(this, visitor);
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
