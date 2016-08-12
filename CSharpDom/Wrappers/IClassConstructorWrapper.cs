using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.Wrappers
{
    public interface IClassConstructorWrapper :
        IClassConstructor<IAttributeGroupWrapper, IClassTypeWrapper, IConstructorParameterWrapper, IMethodBodyWrapper>
    {
    }
}
