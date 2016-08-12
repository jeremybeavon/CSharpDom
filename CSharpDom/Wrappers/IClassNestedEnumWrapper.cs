using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.Wrappers
{
    public interface IClassNestedEnumWrapper :
        IClassNestedEnum<IAttributeGroupWrapper, IClassTypeWrapper, INestedEnumMemberWrapper>
    {
    }
}
