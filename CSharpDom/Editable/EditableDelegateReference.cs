using CSharpDom.Common;
using System.Collections.Generic;
using System;
using System.Collections.ObjectModel;

namespace CSharpDom.Editable
{
    public class EditableDelegateReference<TGenericParameter> : IDelegateReference<TGenericParameter>
        where TGenericParameter : IGenericParameter
    {
        public virtual IList<TGenericParameter> GenericParameters { get; set; }

        public virtual string Name { get; set; }

        IReadOnlyList<TGenericParameter> IHasGenericParameters<TGenericParameter>.GenericParameters
        {
            get { return new ReadOnlyCollection<TGenericParameter>(GenericParameters); }
        }

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
