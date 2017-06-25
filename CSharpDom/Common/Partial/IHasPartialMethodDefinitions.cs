using System.Collections.Generic;

namespace CSharpDom.Common.Partial
{
    public interface IHasPartialMethodDefinitions<TPartialMethodDefinition>
    {
        IReadOnlyCollection<TPartialMethodDefinition> PartialMethodDefinitions { get; }
    }
}
