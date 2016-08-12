using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.Wrappers
{
    public interface IStaticClassEventWrapper :
        IStaticClassEvent<IAttributeGroupWrapper, IStaticTypeWrapper, IDelegateReferenceWrapper>
    {
    }
}
