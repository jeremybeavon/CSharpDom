using CSharpDom.BaseClasses;
using CSharpDom.Common;

namespace CSharpDom.BaseClasses.Editable
{
    public abstract class EditableNullableTypeReference<TStructReference> :
        AbstractGenericVisitableObject,
        INullableTypeReference<TStructReference>
        where TStructReference : IStructReference
    {
        public abstract TStructReference Type { get; set; }

        public override void Accept(IGenericVisitor visitor)
        {
            visitor.VisitNullableTypeReference(this);
        }

        public override void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitNullableTypeReference(this, visitor);
        }
    }
}
