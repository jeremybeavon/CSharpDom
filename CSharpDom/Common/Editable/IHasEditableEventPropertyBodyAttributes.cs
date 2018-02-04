using System.Collections.Generic;

namespace CSharpDom.Common.Editable
{
    public interface IHasEditableEventPropertyBodyAttributes<TAttributeGroup> :
        IHasEventPropertyBodyAttributes<TAttributeGroup>
    {
        new ICollection<TAttributeGroup> AddAttributes { get; set; }

        new ICollection<TAttributeGroup> RemoveAttributes { get; set; }
    }
}