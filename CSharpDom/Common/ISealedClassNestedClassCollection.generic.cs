using System.Collections.Generic;

namespace CSharpDom.Common
{
    public interface ISealedClassNestedClassCollection<TClass, TAbstractClass, TSealedClass, TStaticClass, TPartialClassCollection> :
        ISealedClassNestedClassCollection,
        INestedClassCollection<TClass, TAbstractClass, TSealedClass, TStaticClass, TPartialClassCollection>
        where TClass : ISealedClassNestedClass
        where TAbstractClass : ISealedClassNestedAbstractClass
        where TSealedClass: ISealedClassNestedSealedClass
        where TStaticClass : ISealedClassNestedStaticClass
        where TPartialClassCollection : IPartialClassCollection
    {
    }
}
