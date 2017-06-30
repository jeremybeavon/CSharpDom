using System.Collections.Generic;
using CSharpDom.Common;
using CSharpDom.Common.Partial;
using CSharpDom.Wrappers.Internal;

namespace CSharpDom.Editable.Partial
{
    public abstract class EditablePartialClassCollection<TClass, TAbstractClass, TSealedClass, TStaticClass> :
        IPartialClassCollection<TClass, TAbstractClass, TSealedClass, TStaticClass>
        where TClass : IClassType
        where TAbstractClass : IAbstractType
        where TSealedClass : ISealedType
        where TStaticClass : IStaticType
    {
        public abstract ICollection<TAbstractClass> AbstractClasses { get; set; }
        
        public abstract ICollection<TSealedClass> SealedClasses { get; set; }

        public abstract ICollection<TStaticClass> StaticClasses { get; set; }

        public abstract ICollection<TClass> Classes { get; set; }

        IReadOnlyCollection<TAbstractClass> IHasAbstractClasses<TAbstractClass>.AbstractClasses
        {
            get { return new ReadOnlyCollectionWrapper<TAbstractClass>(AbstractClasses); }
        }

        IReadOnlyCollection<TClass> IHasClasses<TClass>.Classes
        {
            get { return new ReadOnlyCollectionWrapper<TClass>(Classes); }
        }

        IReadOnlyCollection<TSealedClass> IHasSealedClasses<TSealedClass>.SealedClasses
        {
            get { return new ReadOnlyCollectionWrapper<TSealedClass>(SealedClasses); }
        }

        IReadOnlyCollection<TStaticClass> IHasStaticClasses<TStaticClass>.StaticClasses
        {
            get { return new ReadOnlyCollectionWrapper<TStaticClass>(StaticClasses); }
        }

        public int Count
        {
            get { return Classes.Count + AbstractClasses.Count + SealedClasses.Count + StaticClasses.Count; }
        }

        public void Accept(IGenericVisitor visitor)
        {
            visitor.VisitPartialClassCollection(this);
        }

        public void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitPartialClassCollectionChildren(this, visitor);
        }
    }
}
