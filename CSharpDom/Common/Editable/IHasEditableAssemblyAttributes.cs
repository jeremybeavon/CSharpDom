using System.Collections.Generic;

namespace CSharpDom.Common.Editable
{
    public interface IHasEditableAssemblyAttributes<TAttribute> : IHasAssemblyAttributes<TAttribute>
    {
        new ICollection<TAttribute> AssemblyAttributes { get; set; }
    }
}