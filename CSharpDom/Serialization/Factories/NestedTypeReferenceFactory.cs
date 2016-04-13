using CSharpDom.Common;

namespace CSharpDom.Serialization.Factories
{
    public sealed class NestedTypeReferenceFactory : AbstractFactory<INestedTypeReference, NestedTypeReference>
    {
        public NestedTypeReferenceFactory(INestedTypeReference typeReference)
            : base(typeReference)
        {
        }

        public override void VisitNestedTypeReference<TTypeReference>(INestedTypeReference<TTypeReference> nestedTypeReference)
        {
            Value = new NestedTypeReference()
            {
                NestedType = new TypeReferenceFactory(nestedTypeReference.NestedType).Value,
                Type = new TypeReferenceFactory(nestedTypeReference.Type).Value
            };
        }
    }
}
