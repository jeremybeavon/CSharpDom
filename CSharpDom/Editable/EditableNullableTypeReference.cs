using System;
using CSharpDom.Common;

namespace CSharpDom.Editable
{
    public abstract class EditableNullableTypeReference<TStructReference> :
        INullableTypeReference<TStructReference>
        where TStructReference : IStructReference
    {
        public abstract TStructReference Type { get; set; }

        public void Accept(IGenericVisitor visitor)
        {
            visitor.VisitNullableTypeReference(this);
        }

        public void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitNullableTypeReference(this, visitor);
        }
    }
}
