using CSharpDom.Common;

namespace CSharpDom.Serialization.Factories
{
    public sealed class ArrayTypeReferenceFactory : AbstractFactory<IArrayTypeReference, ArrayTypeReference>
    {
        public ArrayTypeReferenceFactory(IArrayTypeReference arrayTypeReference)
            : base(arrayTypeReference)
        {
        }

        public override void VisitArrayTypeReference<TTypeReference>(IArrayTypeReference<TTypeReference> arrayTypeReference)
        {
            Value = new ArrayTypeReference()
            {
                Dimensions = arrayTypeReference.Dimensions,
                ElementType = new TypeReferenceFactory(arrayTypeReference.ElementType).Value
            };
        }
    }
}
