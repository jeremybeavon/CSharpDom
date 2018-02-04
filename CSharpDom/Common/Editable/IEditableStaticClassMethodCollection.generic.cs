using System.Collections.Generic;

namespace CSharpDom.Common.Editable
{
    public interface IEditableStaticClassMethodCollection<TMethod, TExtensionMethod> :
        IEditableStaticClassMethodCollection,
        ICollection<TMethod>,
        IHasEditableExtensionMethods<TExtensionMethod>,
        IStaticClassMethodCollection<TMethod, TExtensionMethod>
        where TMethod : IEditableStaticClassMethod
        where TExtensionMethod : IEditableExtensionMethod
    {
    }
}