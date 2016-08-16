using System;
using CSharpDom.Common;

namespace CSharpDom.Editable
{
    public class EditableGenericParameter<TTypeReference> : IGenericParameter<TTypeReference>
        where TTypeReference : ITypeReference
    {
        public virtual TTypeReference Type { get; set; }

        public void Accept(IGenericVisitor visitor)
        {
            visitor.VisitGenericParameter(this);
        }

        public void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitGenericParameter(this, visitor);
        }
    }
}
