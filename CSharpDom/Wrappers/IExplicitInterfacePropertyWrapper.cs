using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.Wrappers
{
    public interface IExplicitInterfacePropertyWrapper :
        IExplicitInterfaceProperty<
            IAttributeGroupWrapper,
            ITypeWrapper,
            IInterfaceReferenceWrapper, 
            ITypeReferenceWrapper,
            IAccessorWrapper>
    {
    }
}
