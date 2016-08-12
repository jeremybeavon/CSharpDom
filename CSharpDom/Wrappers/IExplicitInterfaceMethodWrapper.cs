using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.Wrappers
{
    public interface IExplicitInterfaceMethodWrapper :
        IExplicitInterfaceMethod<
            IAttributeGroupWrapper,
            ITypeWrapper,
            IInterfaceReferenceWrapper,
            IGenericParameterDeclarationWrapper,
            ITypeReferenceWrapper,
            IMethodParameterWrapper,
            IMethodBodyWrapper>
    {
    }
}
