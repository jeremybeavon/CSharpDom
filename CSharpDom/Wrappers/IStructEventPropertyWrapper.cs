using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.Wrappers
{
    public interface IStructEventPropertyWrapper :
        IStructEventProperty<IAttributeGroupWrapper, IStructTypeWrapper, IDelegateReferenceWrapper, IMethodBodyWrapper>
    {
    }
}
