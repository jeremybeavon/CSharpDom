using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.Wrappers
{
    public interface IClassFieldWrapper :
        IClassField<IAttributeGroupWrapper, IClassTypeWrapper, ITypeReferenceWrapper, IFieldWrapper>
    {
    }
}
