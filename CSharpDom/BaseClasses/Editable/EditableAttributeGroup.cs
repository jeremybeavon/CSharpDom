using CSharpDom.BaseClasses;
using CSharpDom.Common;
using CSharpDom.Common.Editable;
using CSharpDom.Wrappers.Internal;
using System.Collections.Generic;

namespace CSharpDom.BaseClasses.Editable
{
    public abstract class EditableAttributeGroup<TAttribute> :
        EditableVisitableObject,
        IEditableAttributeGroup<TAttribute>
        where TAttribute : IEditableAttribute
    {
        public abstract ICollection<TAttribute> Attributes { get; set; }

        IReadOnlyCollection<TAttribute> IHasAttributes<TAttribute>.Attributes
        {
            get { return new ReadOnlyCollectionWrapper<TAttribute>(Attributes); }
        }

        public override void Accept(IGenericVisitor visitor)
        {
            visitor.VisitAttributeGroup(this);
        }

        public override void Accept(IEditableVisitor visitor)
        {
            visitor.VisitAttributeGroup(this);
        }

        public override void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitAttributeGroupChildren(this, visitor);
        }

        public override void AcceptChildren(IEditableVisitor visitor)
        {
            throw new System.NotImplementedException();
        }
    }
}
