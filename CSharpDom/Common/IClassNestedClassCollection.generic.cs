using System.Collections.Generic;

namespace CSharpDom.Common
{
    public interface IClassNestedClassCollection<TClass, TAbstractClass, TSealedClass, TStaticClass, TPartialClassCollection> :
        IClassNestedClassCollection,
        INestedClassCollection<TClass, TAbstractClass, TSealedClass, TStaticClass, TPartialClassCollection>
        where TClass : IClassNestedClass
        where TAbstractClass : IClassNestedAbstractClass
        where TSealedClass : IClassNestedSealedClass
        where TStaticClass : IClassNestedStaticClass
        where TPartialClassCollection : IPartialClassCollection
    {
    }
}
