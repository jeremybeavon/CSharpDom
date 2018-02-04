using CSharpDom.Common.Partial;
using System.Collections.Generic;

namespace CSharpDom.Common.Editable.Partial
{
    public interface IHasEditablePartialMethodDefinitions<TPartialMethodDefinition> :
        IHasPartialMethodDefinitions<TPartialMethodDefinition>
    {
        new ICollection<TPartialMethodDefinition> PartialMethodDefinitions { get; set; }
    }
}