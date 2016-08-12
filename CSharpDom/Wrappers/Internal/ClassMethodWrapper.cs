using CSharpDom.Common;

namespace CSharpDom.Wrappers.Internal
{
    internal sealed class ClassMethodWrapper : AbstractWrapper<IClassMethod>
    {
        public ClassMethodWrapper(IClassMethod method)
            : base(method)
        {
        }

        public override void VisitClassMethod<TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TParameter, TMethodBody>(
            IClassMethod<TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TParameter, TMethodBody> method)
        {
            Value = new ClassMethod()
            {
                Attributes = method.Attributes.ToAttributeListUsingWrapper(),
                Body = new MethodBodyWrapper(method.Body).Value,
                GenericParameters = method.GenericParameters.ToGenericParameterDeclarationListUsingWrapper(),
                IsAsync = method.IsAsync,
                InheritanceModifier = method.InheritanceModifier,
                Name = method.Name,
                Parameters = method.Parameters.ToList(parameter => new MethodParameterWrapper(parameter).Value),
                ReturnAttributes = method.ReturnAttributes.ToAttributeListUsingWrapper(),
                ReturnType = new TypeReferenceWrapper(method.ReturnType).Value,
                Visibility = method.Visibility
            };
        }
    }
}
