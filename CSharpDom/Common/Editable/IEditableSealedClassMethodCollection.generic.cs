using System.Collections.Generic;

namespace CSharpDom.Common.Editable
{
    public interface IEditableSealedClassMethodCollection<TMethod, TExplicitInterfaceMethod> :
        IEditableSealedClassMethodCollection,
        ICollection<TMethod>,
        IHasEditableExplicitInterfaceMethods<TExplicitInterfaceMethod>,
        ISealedClassMethodCollection<TMethod, TExplicitInterfaceMethod>
        where TMethod : IEditableSealedClassMethod
        where TExplicitInterfaceMethod : IEditableExplicitInterfaceMethod
    {
    }
}