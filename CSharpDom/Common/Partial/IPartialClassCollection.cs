using System.Collections.Generic;

namespace CSharpDom.Common.Partial
{
    public interface IPartialClassCollection<TClass, TAbstractClass, TSealedClass, TStaticClass>
    {
        IReadOnlyCollection<TClass> Classes { get; }

        IReadOnlyCollection<TAbstractClass> AbstractClasses { get; }

        IReadOnlyCollection<TSealedClass> SealedClasses { get; }

        IReadOnlyCollection<TStaticClass> StaticClasses { get; }
    }
}
