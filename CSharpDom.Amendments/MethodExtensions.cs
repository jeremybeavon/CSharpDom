using CSharpDom.Common;

namespace CSharpDom.Amendments
{
    public static class MethodExtensions
    {
        public static IAmendment Amend<TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TParameter, TMethodBody>(
            IMethod<TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TParameter, TMethodBody> method)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IType
            where TGenericParameter : IGenericParameterDeclaration
            where TTypeReference : ITypeReference
            where TParameter : IMethodParameter
            where TMethodBody : IMethodBody
        {
            return null;
        }
    }
}
