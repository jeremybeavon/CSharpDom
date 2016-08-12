using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.Wrappers
{
    public interface IConstantGroupWrapper :
        IConstantGroup<IAttributeGroupWrapper, ITypeWrapper, ITypeReferenceWrapper, IConstantWrapper>
    {
    }
}
