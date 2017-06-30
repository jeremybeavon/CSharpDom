using CSharpDom.Common;

namespace CSharpDom.Serialization.Factories
{
    public sealed class GenericParameterFactory : AbstractFactory<IGenericParameter, GenericParameter>
    {
        public GenericParameterFactory(IGenericParameter genericParameter)
            : base(genericParameter)
        {
        }

        public override void VisitGenericParameter(IGenericParameter genericParameter)
        {
            Value = new GenericParameter()
            {
                Type = new TypeReferenceFactory(genericParameter).Value
            };
        }
    }
}
