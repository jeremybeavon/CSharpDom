using System.Collections.Generic;

namespace CSharpDom.Common
{
    public interface IClassCollection<TClass, TAbstractClass, TSealedClass, TStaticClass, TPartialClassCollection> :
        IClassCollection,
        IReadOnlyCollection<TClass>,
        IHasAbstractClasses<TAbstractClass>,
        IHasSealedClasses<TSealedClass>,
        IHasStaticClasses<TStaticClass>,
        IHasPartialClassCollection<TPartialClassCollection>
        where TClass : IClass
        where TAbstractClass : IAbstractClass
        where TSealedClass: ISealedClass
        where TStaticClass : IStaticClass
        where TPartialClassCollection : IPartialClassCollection
    {
    }
}
