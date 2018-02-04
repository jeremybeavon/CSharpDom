using System.Collections.Generic;

namespace CSharpDom.Common.Editable
{
    public interface IEditableStructMethodCollection<TMethod, TExplicitInterfaceMethod> :
        IEditableStructMethodCollection,
        ICollection<TMethod>,
        IHasEditableExplicitInterfaceMethods<TExplicitInterfaceMethod>,
        IStructMethodCollection<TMethod, TExplicitInterfaceMethod>
        where TMethod : IEditableStructMethod
        where TExplicitInterfaceMethod : IEditableExplicitInterfaceMethod
    {
    }
}