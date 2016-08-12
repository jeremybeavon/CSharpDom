using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.Wrappers
{
    public interface IStructEventWrapper :
        IStructEvent<IAttributeGroupWrapper, IStructTypeWrapper, IDelegateReferenceWrapper>
    {
    }
}
