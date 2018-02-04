using System.Collections.Generic;

namespace CSharpDom.Common.Editable
{
    public interface IHasEditableModuleAttributes<TAttribute> : IHasModuleAttributes<TAttribute>
    {
        new ICollection<TAttribute> ModuleAttributes { get; set; }
    }
}