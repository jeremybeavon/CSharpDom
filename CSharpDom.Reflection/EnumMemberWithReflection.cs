using System.Reflection;

namespace CSharpDom.Reflection
{
    public sealed class EnumMemberWithReflection : AbstractEnumMemberWithReflection<EnumWithReflection>
    {
        internal EnumMemberWithReflection(EnumWithReflection declaringType, FieldInfo field)
            : base(declaringType, field)
        {
        }
    }
}
