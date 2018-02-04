using CSharpDom.Common.Partial;
using System.Collections.Generic;

namespace CSharpDom.Common.Editable.Partial
{
    public interface IHasEditablePartialMethodImplementations<TPartialMethodImplementation> :
        IHasPartialMethodImplementations<TPartialMethodImplementation>
    {
        new ICollection<TPartialMethodImplementation> PartialMethodImplementations { get; set; }
    }
}