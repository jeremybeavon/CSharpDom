using CSharpDom.Common;

namespace CSharpDom.Serialization
{
    public sealed class NestedTypeReference : INestedTypeReference<TypeReference>
    {
        public TypeReference NestedType { get; set; }

        public TypeReference Type { get; set; }

        public void Accept(IGenericVisitor visitor)
        {
            visitor.VisitNestedTypeReference(this);
        }

        public void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitNestedTypeReferenceChildren(this, visitor);
        }
    }
}
