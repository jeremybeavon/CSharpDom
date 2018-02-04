using System.Collections.Generic;

namespace CSharpDom.Common.Editable
{
    public interface IHasEditableExtensionMethods<TExtensionMethod> : IHasExtensionMethods<TExtensionMethod>
    {
        new ICollection<TExtensionMethod> ExtensionMethods { get; set; }
    }
}