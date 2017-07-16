using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.Serialization
{
    public sealed class StructReference : IStructReference<TypeReference>
    {
        public StructReference()
        {
            GenericParameters = new List<TypeReference>();
        }

        public List<TypeReference> GenericParameters { get; set; }

        public string Name { get; set; }

        IReadOnlyList<TypeReference> IHasGenericParameters<TypeReference>.GenericParameters
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
