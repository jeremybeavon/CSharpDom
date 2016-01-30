using CSharpDom.Common;

namespace CSharpDom.Serialization.Factories
{
    public sealed class InterfaceReferenceFactory : AbstractFactory<IInterfaceReference, InterfaceReference>
    {
        public InterfaceReferenceFactory(IInterfaceReference interfaceReference)
            : base(interfaceReference)
        {
        }

        public override void VisitInterfaceReference<TGenericParameter>(IInterfaceReference<TGenericParameter> interfaceReference)
        {
            Value = new InterfaceReference()
            {
                GenericParameters = interfaceReference.GenericParameters.ToGenericParameterListUsingFactory(),
                Name = interfaceReference.Name
            };
        }
    }
}
