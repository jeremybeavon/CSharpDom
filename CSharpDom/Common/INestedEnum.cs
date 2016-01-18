namespace CSharpDom.Common
{
    public interface INestedEnum<TDeclaringType, TEnumMember> :
        IHasName,
        IHasDeclaringType<TDeclaringType>,
        IHasEnumMembers<TEnumMember>
    {
    }
}
