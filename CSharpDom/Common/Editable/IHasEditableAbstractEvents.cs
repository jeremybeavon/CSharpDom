using System.Collections.Generic;

namespace CSharpDom.Common.Editable
{
    public interface IHasEditableAbstractEvents<TEvent> : IHasAbstractEvents<TEvent>
    {
        new ICollection<TEvent> AbstractEvents { get; set; }
    }
}