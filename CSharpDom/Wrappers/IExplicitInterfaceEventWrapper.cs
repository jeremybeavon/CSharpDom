using CSharpDom.Common;

namespace CSharpDom.Wrappers
{
    public interface IExplicitInterfaceEventWrapper :
        IExplicitInterfaceEvent<
            IAttributeGroupWrapper, 
            ITypeWrapper,
            IInterfaceReferenceWrapper,
            IDelegateReferenceWrapper,
            IMethodBodyWrapper>
    {
    }
}
