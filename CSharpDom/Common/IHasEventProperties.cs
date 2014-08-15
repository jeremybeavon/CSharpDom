using System.Collections.Generic;

namespace CSharpDom.Common
{
    public interface IHasEventProperties<TEventProperty>
    {
        IReadOnlyCollection<TEventProperty> EventProperties { get; }
    }
}
