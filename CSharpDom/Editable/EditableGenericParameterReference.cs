using CSharpDom.BaseClasses;
using CSharpDom.Common;

namespace CSharpDom.Editable
{
    public abstract class EditableGenericParameterReference : 
        AbstractGenericVisitableObject,
        IGenericParameterReference
    {
        public abstract string Name { get; set; }

        public override void Accept(IGenericVisitor visitor)
        {
            visitor.VisitGenericParameterReference(this);
        }

        public override void AcceptChildren(IGenericVisitor visitor)
        {
        }
    }
}
