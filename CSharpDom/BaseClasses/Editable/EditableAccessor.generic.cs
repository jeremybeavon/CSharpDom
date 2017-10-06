using CSharpDom.BaseClasses;
using CSharpDom.Common;
using CSharpDom.Wrappers.Internal;
using System;
using System.Collections.Generic;

namespace CSharpDom.BaseClasses.Editable
{
    public abstract class EditableAccessor<TAttributeGroup> :
        AbstractGenericVisitableObject,
        IAccessor<TAttributeGroup>
        where TAttributeGroup : IAttributeGroup
    {
        public abstract ICollection<TAttributeGroup> Attributes { get; set; }

        IReadOnlyCollection<TAttributeGroup> IHasAttributes<TAttributeGroup>.Attributes
        {
            get { return new ReadOnlyCollectionWrapper<TAttributeGroup>(Attributes); }
        }

        public override void Accept(IGenericVisitor visitor)
        {
            throw new NotImplementedException();
        }

        public override void AcceptChildren(IGenericVisitor visitor)
        {
            throw new NotImplementedException();
        }
    }
}
