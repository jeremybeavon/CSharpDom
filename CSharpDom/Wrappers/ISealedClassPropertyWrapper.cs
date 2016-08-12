using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.Wrappers
{
    public interface ISealedClassPropertyWrapper :
        ISealedClassProperty<IAttributeGroupWrapper, ISealedTypeWrapper, ITypeReferenceWrapper, IClassAccessorWrapper>
    {
    }
}
