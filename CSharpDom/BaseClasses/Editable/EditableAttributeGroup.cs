using CSharpDom.BaseClasses;
using CSharpDom.Common;
using CSharpDom.Wrappers.Internal;
using System.Collections.Generic;

namespace CSharpDom.BaseClasses.Editable
{
    public abstract class EditableAttributeGroup<TAttribute> :
        AbstractGenericVisitableObject,
        IAttributeGroup<TAttribute>
        where TAttribute : IAttribute
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

        public override void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitAttributeGroupChildren(this, visitor);
        }
    }
}
