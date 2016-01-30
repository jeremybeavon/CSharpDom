using CSharpDom.Common;

namespace CSharpDom.Serialization.Factories
{
    public sealed class GenericParameterFactory : AbstractFactory<IGenericParameter, GenericParameter>
    {
        public GenericParameterFactory(IGenericParameter genericParameter)
            : base(genericParameter)
        {
        }

        public override void VisitGenericParameter<TTypeReference>(IGenericParameter<TTypeReference> genericParameter)
        {
            Value = new GenericParameter()
            {
                Type = new TypeReferenceFactory(genericParameter.Type).Value
            };
        }
    }
}
