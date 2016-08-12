using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.Wrappers
{
    public interface IStaticClassFieldWrapper :
        IStaticClassField<
            IAttributeGroupWrapper,
            IStaticTypeWrapper,
            ITypeReferenceWrapper,
            IFieldWrapper>
    {
    }
}
