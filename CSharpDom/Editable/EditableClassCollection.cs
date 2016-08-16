using System;
using System.Collections;
using System.Collections.Generic;
using CSharpDom.Common;

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
        public virtual IReadOnlyCollection<TAbstractClass> AbstractClasses { get; set; }

        public int Count
        {
            get { return Classes.Count + AbstractClasses.Count + SealedClasses.Count + StaticClasses.Count + PartialClasses.Count; }
        }

        public virtual TPartialClassCollection PartialClasses { get; set; }

        public virtual IReadOnlyCollection<TSealedClass> SealedClasses { get; set; }

        public virtual IReadOnlyCollection<TStaticClass> StaticClasses { get; set; }

        protected virtual IReadOnlyCollection<TClass> Classes { get; set; }

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
