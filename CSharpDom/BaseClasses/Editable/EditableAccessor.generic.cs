using CSharpDom.Common;
using CSharpDom.Common.Editable;
using CSharpDom.Wrappers.Internal;
using System.Collections.Generic;

namespace CSharpDom.BaseClasses.Editable
{
    public abstract class EditableAccessor<TAttributeGroup> :
        EditableVisitableObject,
        IEditableAccessor<TAttributeGroup>
        where TAttributeGroup : IEditableAttributeGroup
    {
        public abstract ICollection<TAttributeGroup> Attributes { get; set; }

        IReadOnlyCollection<TAttributeGroup> IHasAttributes<TAttributeGroup>.Attributes
        {
            get { return new ReadOnlyCollectionWrapper<TAttributeGroup>(Attributes); }
        }
    }
}
