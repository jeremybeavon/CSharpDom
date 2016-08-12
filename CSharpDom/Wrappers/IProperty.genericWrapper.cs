using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.Wrappers
{
    public interface IPropertyWrapper :
        IProperty<IAttributeGroupWrapper, ITypeWrapper, ITypeReferenceWrapper, IAccessorWrapper>
    {
    }
}
