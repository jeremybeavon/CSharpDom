using System.Collections.Generic;

namespace CSharpDom.Common
{
    public interface IHasAssemblyAttributes<TAttribute>
    {
        IReadOnlyCollection<TAttribute> AssemblyAttributes { get; }
    }
}
