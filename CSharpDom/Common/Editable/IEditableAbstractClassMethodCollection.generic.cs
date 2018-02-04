using System.Collections.Generic;

namespace CSharpDom.Common.Editable
{
    public interface IEditableAbstractClassMethodCollection<TMethod, TAbstractMethod, TExplicitInterfaceMethod> :
        IEditableAbstractClassMethodCollection,
        ICollection<TMethod>,
        IHasEditableAbstractMethods<TAbstractMethod>,
        IHasEditableExplicitInterfaceMethods<TExplicitInterfaceMethod>,
        IAbstractClassMethodCollection<TMethod, TAbstractMethod, TExplicitInterfaceMethod>
        where TMethod : IEditableClassMethod
        where TAbstractMethod : IEditableAbstractMethod
        where TExplicitInterfaceMethod : IEditableExplicitInterfaceMethod
    {
    }
}