using CSharpDom.Common;

namespace CSharpDom.Serialization.Factories
{
    public sealed class GenericParameterReferenceFactory : AbstractFactory<IGenericParameterReference, GenericParameterReference>
    {
        public GenericParameterReferenceFactory(IGenericParameterReference genericParameterReference)
            : base(genericParameterReference)
        {
        }

        public override void VisitGenericParameterReference(IGenericParameterReference genericParameterReference)
        {
            Value = new GenericParameterReference()
            {
                Name = genericParameterReference.Name
            };
        }
    }
}
