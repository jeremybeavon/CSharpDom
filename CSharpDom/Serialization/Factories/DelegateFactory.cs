using CSharpDom.Common;

namespace CSharpDom.Serialization.Factories
{
    public sealed class DelegateFactory : AbstractFactory<IDelegate, Delegate>
    {
        public DelegateFactory(IDelegate @delegate)
            : base(@delegate)
        {
        }

        public override void VisitDelegate<TNamespace, TProject, TSolution, TAttributeGroup, TGenericParameter, TTypeReference, TParameter>(
            IDelegate<TNamespace, TProject, TSolution, TAttributeGroup, TGenericParameter, TTypeReference, TParameter> @delegate)
        {
            Value = new Delegate()
            {
                Attributes = @delegate.Attributes.ToAttributeListUsingFactory(),
                GenericParameters = @delegate.GenericParameters.ToGenericParameterDeclarationListUsingFactory(),
                Name = @delegate.Name,
                Parameters = @delegate.Parameters.ToParameterListUsingFactory(),
                ReturnType = new TypeReferenceFactory(@delegate.ReturnType).Value,
                Visibility = @delegate.Visibility
            };
        }
    }
}
