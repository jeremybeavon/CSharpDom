using System.Collections.Generic;

namespace CSharpDom.Common
{
    public interface IHasEnumMembers<TEnumMember>
    {
        IReadOnlyList<TEnumMember> EnumMembers { get; }
    }
}
