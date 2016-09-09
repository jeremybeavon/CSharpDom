using System;
using CSharpDom.Common;

namespace CSharpDom.Editable
{
    public abstract class EditableGenericParameter<TTypeReference> : IGenericParameter<TTypeReference>
        where TTypeReference : ITypeReference
    {
        public abstract TTypeReference Type { get; set; }

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
