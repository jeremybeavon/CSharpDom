using System.Collections.Generic;

namespace CSharpDom.Common.Editable
{
    public interface IHasEditableEvents<TEvent> : IHasEvents<TEvent>
    {
        new ICollection<TEvent> Events { get; set; }
    }
}