using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.Wrappers
{
    public interface IConversionOperatorWrapper :
        IConversionOperator<
            IAttributeGroupWrapper,
            ITypeWrapper,
            ITypeReferenceWrapper,
            IOperatorParameterWrapper,
            IMethodBodyWrapper>
    {
    }
}
