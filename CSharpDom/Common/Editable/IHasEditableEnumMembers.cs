using System.Collections.Generic;

namespace CSharpDom.Common.Editable
{
    public interface IHasEditableEnumMembers<TEnumMember> : IHasEnumMembers<TEnumMember>
    {
        new IList<TEnumMember> EnumMembers { get; set; }
    }
}