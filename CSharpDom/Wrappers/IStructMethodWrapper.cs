using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.Wrappers
{
    public interface IStructMethodWrapper :
        IStructMethod<
            IAttributeGroupWrapper,
            IStructTypeWrapper,
            IGenericParameterDeclarationWrapper,
            ITypeReferenceWrapper,
            IMethodParameterWrapper,
            IMethodBodyWrapper>
    {
    }
}
