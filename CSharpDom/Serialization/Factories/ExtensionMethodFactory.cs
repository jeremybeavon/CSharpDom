using CSharpDom.Common;

namespace CSharpDom.Serialization.Factories
{
    public sealed class ExtensionMethodFactory : AbstractFactory<IExtensionMethod, ExtensionMethod>
    {
        public ExtensionMethodFactory(IExtensionMethod method)
            : base(method)
        {
        }

        public override void VisitExtensionMethod<TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TExtensionParameter, TParameter, TMethodBody>(
            IExtensionMethod<TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TExtensionParameter, TParameter, TMethodBody> method)
        {
            Value = new ExtensionMethod()
            {
                Attributes = method.Attributes.ToAttributeListUsingFactory(),
                Body = new MethodBodyFactory(method.Body).Value,
                ExtensionParameter = new ExtensionParameterFactory(method.ExtensionParameter).Value,
                GenericParameters = method.GenericParameters.ToGenericParameterDeclarationListUsingFactory(),
                IsAsync = method.IsAsync,
                Name = method.Name,
                Parameters = method.Parameters.ToList(parameter => new MethodParameterFactory(parameter).Value),
                ReturnType = new TypeReferenceFactory(method.ReturnType).Value
            };
        }
    }
}
