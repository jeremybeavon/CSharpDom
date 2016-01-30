using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.Serialization
{
    public sealed class DelegateReference : IDelegateReference<GenericParameter>
    {
        public DelegateReference()
        {
            GenericParameters = new List<GenericParameter>();
        }

        public List<GenericParameter> GenericParameters { get; set; }

        public string Name { get; set; }

        IReadOnlyList<GenericParameter> IHasGenericParameters<GenericParameter>.GenericParameters
        {
            get { return GenericParameters; }
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
