using System.Collections.Generic;

namespace CSharpDom.Common
{
    public interface INestedClassCollection<TClass, TAbstractClass, TSealedClass, TStaticClass, TPartialClassCollection> :
        INestedClassCollection,
        IReadOnlyCollection<TClass>,
        IHasAbstractClasses<TAbstractClass>,
        IHasSealedClasses<TSealedClass>,
        IHasStaticClasses<TStaticClass>,
        IHasPartialClassCollection<TPartialClassCollection>
        where TClass : INestedClass
        where TAbstractClass : INestedAbstractClass
        where TSealedClass: INestedSealedClass
        where TStaticClass : INestedStaticClass
        where TPartialClassCollection : IPartialClassCollection
    {
    }
}
