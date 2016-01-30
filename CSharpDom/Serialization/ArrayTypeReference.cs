using System;
using CSharpDom.Common;

namespace CSharpDom.Serialization
{
    public sealed class ArrayTypeReference : IArrayTypeReference<TypeReference>
    {
        public int Dimensions { get; set; }

        public TypeReference ElementType { get; set; }

        public void Accept(IGenericVisitor visitor)
        {
            visitor.VisitArrayTypeReference(this);
        }

        public void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitArrayTypeReferenceChildren(this, visitor);
        }
    }
}
