using CSharpDom.Common;

namespace CSharpDom.Serialization.Factories
{
    public sealed class ClassMethodFactory : AbstractFactory<IClassMethod, ClassMethod>
    {
        public ClassMethodFactory(IClassMethod method)
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
                IsAsync = method.IsAsync,
                InheritanceModifier = method.InheritanceModifier,
                Name = method.Name,
                Parameters = method.Parameters.ToList(parameter => new MethodParameterFactory(parameter).Value),
                ReturnAttributes = method.ReturnAttributes.ToAttributeListUsingFactory(),
                ReturnType = new TypeReferenceFactory(method.ReturnType).Value,
                Visibility = method.Visibility
            };
        }
    }
}
