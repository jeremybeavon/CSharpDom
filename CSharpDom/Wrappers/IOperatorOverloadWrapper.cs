using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.Wrappers
{
    public interface IOperatorOverloadWrapper :
        IOperatorOverload<
            IAttributeGroupWrapper,
            ITypeWrapper,
            ITypeReferenceWrapper,
            IOperatorParameterWrapper,
            IMethodBodyWrapper>
    {
    }
}
