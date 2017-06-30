using System.Collections.Generic;

namespace CSharpDom.Common.Partial
{
    public interface IPartialClassCollection<TClass, TAbstractClass, TSealedClass, TStaticClass> :
        IPartialClassCollection,
        IHasClasses<TClass>,
        IHasAbstractClasses<TAbstractClass>,
        IHasSealedClasses<TSealedClass>,
        IHasStaticClasses<TStaticClass>
        where TClass : IClassType
        where TAbstractClass : IAbstractType
        where TSealedClass : ISealedType
        where TStaticClass : IStaticType
    {
    }
}
