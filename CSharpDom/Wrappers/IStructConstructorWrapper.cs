using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.Wrappers
{
    public interface IStructConstructorWrapper :
        IStructConstructor<IAttributeGroupWrapper, IStructTypeWrapper, IConstructorParameterWrapper, IMethodBodyWrapper>
    {
    }
}
