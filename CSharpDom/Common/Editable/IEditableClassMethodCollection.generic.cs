using System.Collections.Generic;

namespace CSharpDom.Common.Editable
{
    public interface IEditableClassMethodCollection<TMethod, TExplicitInterfaceMethod> :
        IEditableClassMethodCollection,
        ICollection<TMethod>,
        IHasEditableExplicitInterfaceMethods<TExplicitInterfaceMethod>,
        IClassMethodCollection<TMethod, TExplicitInterfaceMethod>
        where TMethod : IEditableClassMethod
        where TExplicitInterfaceMethod : IEditableExplicitInterfaceMethod
    {
    }
}