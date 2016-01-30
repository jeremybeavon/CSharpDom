using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.Serialization
{
    public sealed class StructReference : IStructReference<GenericParameter>
    {
        public StructReference()
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
            visitor.VisitStructReference(this);
        }

        public void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitStructReferenceChildren(this, visitor);
        }
    }
}
