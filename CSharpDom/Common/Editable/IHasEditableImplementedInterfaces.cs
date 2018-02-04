using System.Collections.Generic;

namespace CSharpDom.Common.Editable
{
    public interface IHasEditableImplementedInterfaces<TInterfaceReference> : IHasImplementedInterfaces<TInterfaceReference>
    {
        new ICollection<TInterfaceReference> ImplementedInterfaces { get; set; }
    }
}