using System.Collections.Generic;

namespace CSharpDom.Common.Editable
{
    public interface IHasEditableExplicitInterfaceEvents<TExplicitInterfaceEvent> :
        IHasExplicitInterfaceEvents<TExplicitInterfaceEvent>
    {
        new ICollection<TExplicitInterfaceEvent> ExplicitInterfaceEvents { get; set; }
    }
}