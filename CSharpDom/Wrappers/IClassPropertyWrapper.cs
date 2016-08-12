using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.Wrappers
{
    public interface IClassPropertyWrapper :
        IClassProperty<IAttributeGroupWrapper, IClassTypeWrapper, ITypeReferenceWrapper, IClassAccessorWrapper>
    {
    }
}
