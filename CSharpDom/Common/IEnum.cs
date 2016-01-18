namespace CSharpDom.Common
{
    public interface IEnum<TNamespace, TProject, TSolution, TEnumMember> :
        IHasName,
        IHasNamespace<TNamespace>,
        IHasProject<TProject>,
        IHasSolution<TSolution>,
        IHasEnumMembers<TEnumMember>
    {
    }
}
