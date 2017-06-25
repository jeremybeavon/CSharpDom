using System.Collections.Generic;

namespace CSharpDom.Common.Partial
{
    public interface IHasPartialMethodImplementations<TPartialMethodImplementation>
    {
        IReadOnlyCollection<TPartialMethodImplementation> PartialMethodImplementions { get; }
    }
}
