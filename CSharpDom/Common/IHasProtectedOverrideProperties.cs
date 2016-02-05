using System.Collections.Generic;

namespace CSharpDom.Common
{
    public interface IHasProtectedOverrideProperties<TProperty>
    {
        IReadOnlyCollection<TProperty> ProtectedOverrideProperties { get; }
    }
}
