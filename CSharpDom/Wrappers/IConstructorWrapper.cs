using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.Wrappers
{
    public interface IConstructorWrapper :
        IConstructor<IAttributeGroupWrapper, ITypeWrapper, IConstructorParameterWrapper, IMethodBodyWrapper>
    {
    }
}
