using CSharpDom.Common;
using System.Collections.Generic;

namespace CSharpDom.Wrappers
{
    public interface INestedEnumMemberWrapper :
        INestedEnumMember<IAttributeGroupWrapper, INestedEnumWrapper>
    {
    }
}
