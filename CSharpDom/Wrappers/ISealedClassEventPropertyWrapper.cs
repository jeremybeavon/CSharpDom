using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.Wrappers
{
    public interface ISealedClassEventPropertyWrapper :
        ISealedClassEventProperty<IAttributeGroupWrapper, ISealedTypeWrapper, IDelegateReferenceWrapper, IMethodBodyWrapper>
    {
    }
}
