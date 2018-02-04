using System.Collections.Generic;

namespace CSharpDom.Common.Editable
{
    public interface IHasEditableExplicitInterfaceMethods<TExplicitInterfaceMethod> :
        IHasExplicitInterfaceMethods<TExplicitInterfaceMethod>
    {
        new ICollection<TExplicitInterfaceMethod> ExplicitInterfaceMethods { get; set; }
    }
}