using System.Collections.Generic;

namespace CSharpDom.Common.Editable
{
    public interface IHasEditableEnums<TEnum> : IHasEnums<TEnum>
    {
        new ICollection<TEnum> Enums { get; set; }
    }
}