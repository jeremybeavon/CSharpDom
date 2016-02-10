using System.Collections.Generic;

namespace CSharpDom.Common
{
    public interface IHasSealedClasses<TSealedClass>
    {
        IReadOnlyCollection<TSealedClass> SealedClasses { get; }
    }
}
