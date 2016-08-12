using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.Wrappers
{
    public interface IClassEventPropertyWrapper :
        IClassEventProperty<IAttributeGroupWrapper, IClassTypeWrapper, IDelegateReferenceWrapper, IMethodBodyWrapper>
    {
    }
}
