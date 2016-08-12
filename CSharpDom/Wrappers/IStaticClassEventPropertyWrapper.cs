using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.Wrappers
{
    public interface IStaticClassEventPropertyWrapper :
        IStaticClassEventProperty<IAttributeGroupWrapper, IStaticTypeWrapper, IDelegateReferenceWrapper, IMethodBodyWrapper>
    {
    }
}
