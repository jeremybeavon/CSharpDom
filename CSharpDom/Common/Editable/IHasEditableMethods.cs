using System.Collections.Generic;

namespace CSharpDom.Common.Editable
{
    public interface IHasEditableMethods<TMethod> : IHasMethods<TMethod>
    {
        new ICollection<TMethod> Methods { get; set; }
    }
}