using CSharpDom.Common;
using System.Collections.Generic;

namespace CSharpDom.Editable
{
    public class EditableDelegateReference<TGenericParameter> : IDelegateReference<TGenericParameter>
        where TGenericParameter : IGenericParameter
    {
        public virtual IReadOnlyList<TGenericParameter> GenericParameters { get; set; }

        public virtual string Name { get; set; }

        public void Accept(IGenericVisitor visitor)
        {
            visitor.VisitDelegateReference(this);
        }

        public void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitDelegateReferenceChildren(this, visitor);
        }
    }
}
