using System;
using CSharpDom.Common;

namespace CSharpDom.Serialization
{
    public sealed class GenericParameter : IGenericParameter
    {
        public TypeReference Type { get; set; }

        public void Accept(IGenericVisitor visitor)
        {
            visitor.VisitGenericParameter(this);
        }

        public void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitIfNotNull(Type, visitor);
        }
    }
}
