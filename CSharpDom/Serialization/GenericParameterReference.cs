using System;
using CSharpDom.Common;

namespace CSharpDom.Serialization
{
    public sealed class GenericParameterReference : IGenericParameterReference
    {
        public string Name { get; set; }

        public void Accept(IGenericVisitor visitor)
        {
            visitor.VisitGenericParameterReference(this);
        }

        public void AcceptChildren(IGenericVisitor visitor)
        {
        }
    }
}
