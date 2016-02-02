using CSharpDom.Common;

namespace CSharpDom.Serialization.Factories
{
    public sealed class MethodFactory : AbstractFactory<IClassMethod, ClassMethod>
    {
        public MethodFactory(IClassMethod method)
            : base(method)
        {
        }

        public override void VisitClassMethod<TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TParameter, TMethodBody>(
            IClassMethod<TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TParameter, TMethodBody> method)
        {
            Value = new ClassMethod()
            {
                Attributes = method.Attributes.ToAttributeListUsingFactory(),
                Body = new MethodBodyFactory(method.Body).Value,
                GenericParameters = method.GenericParameters.ToGenericParameterDeclarationListUsingFactory(),
                InheritanceModifier = method.InheritanceModifier,
                IsAsync = method.IsAsync,
                IsPartial = method.IsPartial,
                Name = method.Name,
                Parameters = method.Parameters.ToParameterListUsingFactory(),
                ReturnType = new TypeReferenceFactory(method.ReturnType).Value,
                Visibility = method.Visibility
            };
        }
    }
}
