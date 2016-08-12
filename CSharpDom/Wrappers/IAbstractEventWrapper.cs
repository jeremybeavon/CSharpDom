using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.Wrappers
{
    public interface IAbstractEventWrapper :
        IAbstractEvent<IAttributeGroupWrapper, IAbstractTypeWrapper, IDelegateReferenceWrapper>
    {
    }
}
