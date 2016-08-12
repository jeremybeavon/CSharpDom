using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.Wrappers
{
    public interface IFieldGroupWrapper :
        IFieldGroup<IAttributeGroupWrapper, ITypeWrapper, ITypeReferenceWrapper, IFieldWrapper>
    {
    }
}
