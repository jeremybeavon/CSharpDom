using System.Collections.Generic;

namespace CSharpDom.Common
{
    public interface IStaticClassNestedClassCollection<TClass, TAbstractClass, TSealedClass, TStaticClass, TPartialClassCollection> :
        IStaticClassNestedClassCollection,
        INestedClassCollection<TClass, TAbstractClass, TSealedClass, TStaticClass, TPartialClassCollection>
        where TClass : IStaticClassNestedClass
        where TAbstractClass : IStaticClassNestedAbstractClass
        where TSealedClass: IStaticClassNestedSealedClass
        where TStaticClass : IStaticClassNestedStaticClass
        where TPartialClassCollection : IPartialClassCollection
    {
    }
}
