using CSharpDom.Common;
using System.Collections.Generic;

namespace CSharpDom.Editable
{
    public class EditableNestedDestructor<TAttributeGroup, TDeclaringType, TMethodBody> :
        INestedDestructor<TAttributeGroup, TDeclaringType, TMethodBody>
        where TAttributeGroup : IAttributeGroup
        where TDeclaringType : INestedClass
        where TMethodBody : IMethodBody
    {
        public virtual IReadOnlyCollection<TAttributeGroup> Attributes { get; set; }

        public virtual TMethodBody Body { get; set; }

        public virtual TDeclaringType DeclaringType { get; set; }

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
