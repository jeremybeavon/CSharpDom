using System.Collections.Generic;

namespace CSharpDom.Common
{
    public interface IHasEnums<TEnum>
    {
        IReadOnlyCollection<TEnum> Enums { get; }
    }
}
