using System.Collections.Generic;

namespace CSharpDom.Common
{
    public interface IHasModuleAttributes<TAttribute>
    {
        IReadOnlyCollection<TAttribute> ModuleAttributes { get; }
    }
}
