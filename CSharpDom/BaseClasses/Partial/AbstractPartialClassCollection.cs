using System.Collections.Generic;
using CSharpDom.Common;
using CSharpDom.Common.Partial;

namespace CSharpDom.BaseClasses.Partial
{
    public abstract class AbstractPartialClassCollection<TClass, TAbstractClass, TSealedClass, TStaticClass> :
        AbstractGenericVisitableObject,
        IPartialClassCollection<TClass, TAbstractClass, TSealedClass, TStaticClass>
        where TClass : IClassType
        where TAbstractClass : IAbstractType
        where TSealedClass : ISealedType
        where TStaticClass : IStaticType
    {
        public abstract IReadOnlyCollection<TClass> Classes { get; }

        public abstract IReadOnlyCollection<TAbstractClass> AbstractClasses { get; }

        public abstract IReadOnlyCollection<TSealedClass> SealedClasses { get; }

        public abstract IReadOnlyCollection<TStaticClass> StaticClasses { get; }

        public int Count
        {
            get { return Classes.Count + AbstractClasses.Count + SealedClasses.Count + StaticClasses.Count; }
        }

        public override void Accept(IGenericVisitor visitor)
        {
            visitor.VisitPartialClassCollection(this);
        }

        public override void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitPartialClassCollectionChildren(this, visitor);
        }
    }
}
