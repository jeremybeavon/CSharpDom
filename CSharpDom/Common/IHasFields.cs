using System.Collections.Generic;

namespace CSharpDom.Common
{
    public interface IHasFields<TField>
    {
        IReadOnlyCollection<TField> Fields { get; }
    }
}
