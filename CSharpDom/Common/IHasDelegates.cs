using System.Collections.Generic;

namespace CSharpDom.Common
{
    public interface IHasDelegates<TDelegate>
    {
        IReadOnlyCollection<TDelegate> Delegates { get; }
    }
}
