using CSharpDom.BaseClasses;
using CSharpDom.Common;
using CSharpDom.Common.Editable;

namespace CSharpDom.BaseClasses.Editable
{
    public abstract class EditableGenericParameterReference : 
        EditableTypeReference,
        IEditableGenericParameterReference
    {
        public abstract string Name { get; set; }

        public override void Accept(IGenericVisitor visitor)
        {
            visitor.VisitGenericParameterReference(this);
        }

        public override void Accept(IEditableVisitor visitor)
        {
            visitor.VisitGenericParameterReference(this);
        }
    }
}
