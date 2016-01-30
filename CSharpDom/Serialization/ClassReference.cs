using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.Serialization
{
    public sealed class ClassReference : IClassReference<GenericParameter>
    {
        public ClassReference()
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
            visitor.VisitClassReference(this);
        }

        public void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitClassReferenceChildren(this, visitor);
        }
    }
}
