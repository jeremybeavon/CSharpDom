using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.Wrappers
{
    public interface IExtensionMethodWrapper :
        IExtensionMethod<
            IAttributeGroupWrapper,
            IStaticClassWrapper,
            IGenericParameterDeclarationWrapper,
            ITypeReferenceWrapper,
            IExtensionParameterWrapper,
            IMethodParameterWrapper,
            IMethodBodyWrapper>
    {
    }
}
