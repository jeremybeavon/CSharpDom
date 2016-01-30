using CSharpDom.Common;

namespace CSharpDom.Serialization.Factories
{
    public sealed class StructReferenceFactory : AbstractFactory<IStructReference, StructReference>
    {
        public StructReferenceFactory(IStructReference structReference)
            : base(structReference)
        {
        }

        public override void VisitStructReference<TGenericParameter>(IStructReference<TGenericParameter> structReference)
        {
            Value = new StructReference()
            {
                GenericParameters = structReference.GenericParameters.ToGenericParameterListUsingFactory(),
                Name = structReference.Name
            };
        }
    }
}
