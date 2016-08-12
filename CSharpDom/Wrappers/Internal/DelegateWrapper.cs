using CSharpDom.Common;

namespace CSharpDom.Wrappers.Internal
{
    internal sealed class DelegateWrapper : AbstractWrapper<IDelegate>
    {
        public DelegateWrapper(IDelegate @delegate)
            : base(@delegate)
        {
        }

        public override void VisitDelegate<TNamespace, TDocument, TProject, TSolution, TAttributeGroup, TGenericParameter, TTypeReference, TParameter>(
            IDelegate<TNamespace, TDocument, TProject, TSolution, TAttributeGroup, TGenericParameter, TTypeReference, TParameter> @delegate)
        {
            Value = new Delegate()
            {
                Attributes = @delegate.Attributes.ToAttributeListUsingWrapper(),
                GenericParameters = @delegate.GenericParameters.ToGenericParameterDeclarationListUsingWrapper(),
                Name = @delegate.Name,
                Parameters = @delegate.Parameters.ToList(parameter => new DelegateParameterWrapper(parameter).Value),
                ReturnType = new TypeReferenceWrapper(@delegate.ReturnType).Value,
                Visibility = @delegate.Visibility
            };
        }
    }
}
