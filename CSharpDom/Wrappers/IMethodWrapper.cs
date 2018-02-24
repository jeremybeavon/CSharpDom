using CSharpDom.Common;

namespace CSharpDom.Wrappers
{
    public interface IMethodWrapper :
        IMethod<
            IAttributeGroupWrapper,
            ITypeWrapper,
            IGenericParameterDeclarationWrapper,
            ITypeReferenceWrapper,
            IMethodParameterWrapper>
    {
    }
}
