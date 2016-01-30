using CSharpDom.Common;

namespace CSharpDom.Serialization.Factories
{
    public sealed class DelegateReferenceFactory : AbstractFactory<IDelegateReference, DelegateReference>
    {
        public DelegateReferenceFactory(IDelegateReference delegateReference)
            : base(delegateReference)
        {
        }

        public override void VisitDelegateReference<TGenericParameter>(IDelegateReference<TGenericParameter> delegateReference)
        {
            Value = new DelegateReference()
            {
                GenericParameters = delegateReference.GenericParameters.ToGenericParameterListUsingFactory(),
                Name = delegateReference.Name
            };
        }
    }
}
