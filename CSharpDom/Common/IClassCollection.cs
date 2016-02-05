using System.Collections.Generic;

namespace CSharpDom.Common
{
    public interface IClassCollection<TClass, TAbstractClass, TSealedClass, TStaticClass, TPartialClassCollection>
    {
        IReadOnlyCollection<TClass> Classes { get; }

        IReadOnlyCollection<TAbstractClass> AbstractClasses { get; }

        IReadOnlyCollection<TSealedClass> SealedClasses { get; }

        IReadOnlyCollection<TStaticClass> StaticClasses { get; }

        TPartialClassCollection PartialClasses { get; }
    }
}
