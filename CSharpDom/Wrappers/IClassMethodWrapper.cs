using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.Wrappers
{
    public interface IClassMethodWrapper :
        IClassMethod<
            IAttributeGroupWrapper,
            IClassTypeWrapper,
            IGenericParameterDeclarationWrapper,
            ITypeReferenceWrapper,
            IMethodParameterWrapper,
            IMethodBodyWrapper>
    {
    }
}
