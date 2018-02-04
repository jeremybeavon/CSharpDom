using System.Collections.Generic;

namespace CSharpDom.Common.Editable
{
    public interface IHasEditableInterfaces<TInterface> : IHasInterfaces<TInterface>
    {
        new ICollection<TInterface> Interfaces { get; set; }
    }
}