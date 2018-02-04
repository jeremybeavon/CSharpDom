using System.Collections.Generic;

namespace CSharpDom.Common.Editable
{
    public interface IHasEditableExplicitInterfaceProperties<TExplicitInterfaceProperty> :
        IHasExplicitInterfaceProperties<TExplicitInterfaceProperty>
    {
        new ICollection<TExplicitInterfaceProperty> ExplicitInterfaceProperties { get; set; }
    }
}