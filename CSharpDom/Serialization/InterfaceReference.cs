using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.Serialization
{
    public sealed class InterfaceReference : IInterfaceReference<TypeReference>
    {
        public InterfaceReference()
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
            visitor.VisitInterfaceReference(this);
        }

        public void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitInterfaceReferenceChildren(this, visitor);
        }
    }
}
