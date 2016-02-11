using CSharpDom.Common;

namespace CSharpDom.Serialization.Factories
{
    public sealed class ProtectedOverrideMethodFactory : AbstractFactory<IProtectedOverrideMethod, ProtectedOverrideMethod>
    {
        public ProtectedOverrideMethodFactory(IProtectedOverrideMethod method)
            : base(method)
        {
        }

        public override void VisitProtectedOverrideMethod<TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TParameter, TMethodBody>(
            IProtectedOverrideMethod<TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TParameter, TMethodBody> method)
        {
            Value = new ProtectedOverrideMethod()
            {
                Attributes = method.Attributes.ToAttributeListUsingFactory(),
                Body = new MethodBodyFactory(method.Body).Value,
                GenericParameters = method.GenericParameters.ToGenericParameterDeclarationListUsingFactory(),
                IsAsync = method.IsAsync,
                IsInternal = method.IsInternal,
                IsSealed = method.IsSealed,
                Name = method.Name,
                Parameters = method.Parameters.ToParameterListUsingFactory(),
                ReturnType = new TypeReferenceFactory(method.ReturnType).Value
            };
        }
    }
}
