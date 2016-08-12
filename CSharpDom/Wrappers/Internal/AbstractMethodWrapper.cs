using CSharpDom.Common;

namespace CSharpDom.Wrappers.Internal
{
    internal sealed class AbstractMethodWrapper : AbstractWrapper<IAbstractMethod>
    {
        public AbstractMethodWrapper(IAbstractMethod method)
            : base(method)
        {
        }

        public override void VisitAbstractMethod<TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TParameter>(
            IAbstractMethod<TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TParameter> method)
        {
            Value = new AbstractMethod()
            {
                Attributes = method.Attributes.ToAttributeListUsingWrapper(),
                GenericParameters = method.GenericParameters.ToGenericParameterDeclarationListUsingWrapper(),
                Name = method.Name,
                Parameters = method.Parameters.ToList(parameter => new MethodParameterWrapper(parameter).Value),
                ReturnAttributes = method.ReturnAttributes.ToAttributeListUsingWrapper(),
                ReturnType = new TypeReferenceWrapper(method.ReturnType).Value
            };
        }
    }
}
