using CSharpDom.Common;
using System.Collections.Generic;
using System;
using CSharpDom.Wrappers.Internal;

namespace CSharpDom.Editable
{
    public abstract class EditableNestedDestructor<TAttributeGroup, TDeclaringType, TMethodBody> :
        INestedDestructor<TAttributeGroup, TDeclaringType, TMethodBody>
        where TAttributeGroup : IAttributeGroup
        where TDeclaringType : INestedClass
        where TMethodBody : IMethodBody
    {
        public abstract ICollection<TAttributeGroup> Attributes { get; set; }

        public abstract TMethodBody Body { get; set; }

        public abstract TDeclaringType DeclaringType { get; set; }

        IReadOnlyCollection<TAttributeGroup> IHasAttributes<TAttributeGroup>.Attributes
        {
            get { return new ReadOnlyCollectionWrapper<TAttributeGroup>(Attributes); }
        }

        public void Accept(IGenericVisitor visitor)
        {
            visitor.VisitNestedDestructor(this);
        }

        public void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitNestedDestructorChildren(this, visitor);
        }
    }
}
