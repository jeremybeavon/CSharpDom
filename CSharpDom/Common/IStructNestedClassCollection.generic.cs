using System.Collections.Generic;

namespace CSharpDom.Common
{
    public interface IStructNestedClassCollection<TClass, TAbstractClass, TSealedClass, TStaticClass, TPartialClassCollection> :
        IStructNestedClassCollection,
        INestedClassCollection<TClass, TAbstractClass, TSealedClass, TStaticClass, TPartialClassCollection>
        where TClass : IStructNestedClass
        where TAbstractClass : IStructNestedAbstractClass
        where TSealedClass: IStructNestedSealedClass
        where TStaticClass : IStructNestedStaticClass
        where TPartialClassCollection : IPartialClassCollection
    {
    }
}
