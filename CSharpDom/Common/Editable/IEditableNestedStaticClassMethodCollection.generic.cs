using System.Collections.Generic;

namespace CSharpDom.Common.Editable
{
    public interface IEditableNestedStaticClassMethodCollection<TMethod> :
        IEditableNestedStaticClassMethodCollection,
        ICollection<TMethod>,
        INestedStaticClassMethodCollection<TMethod>
        where TMethod : IEditableStaticClassMethod
    {
    }
}