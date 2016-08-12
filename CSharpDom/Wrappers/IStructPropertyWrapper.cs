using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.Wrappers
{
    public interface IStructPropertyWrapper :
        IStructProperty<IAttributeGroupWrapper, IStructTypeWrapper, ITypeReferenceWrapper, IStructAccessorWrapper>
    {
    }
}
