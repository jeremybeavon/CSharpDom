using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.Wrappers
{
    public interface IStructFieldWrapper :
        IStructField<IAttributeGroupWrapper, IStructTypeWrapper, ITypeReferenceWrapper, IFieldWrapper>
    {
    }
}
