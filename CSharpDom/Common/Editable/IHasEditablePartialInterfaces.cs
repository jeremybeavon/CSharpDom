using System.Collections.Generic;

namespace CSharpDom.Common.Editable
{
    public interface IHasEditablePartialInterfaces<TPartialInterface> : IHasPartialInterfaces<TPartialInterface>
    {
        new ICollection<TPartialInterface> PartialInterfaces { get; set; }
    }
}