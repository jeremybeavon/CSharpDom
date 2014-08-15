using System.Collections.Generic;

namespace CSharpDom.Common
{
    public interface IHasEnumMembers<TEnumMember>
    {
        IReadOnlyCollection<TEnumMember> EnumMembers { get; }
    }
}
