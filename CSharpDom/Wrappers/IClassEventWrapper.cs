using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.Wrappers
{
    public interface IClassEventWrapper :
        IClassEvent<IAttributeGroupWrapper, IClassTypeWrapper, IDelegateReferenceWrapper>
    {
    }
}
