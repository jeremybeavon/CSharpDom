namespace CSharpDom.Common
{
    public interface IEnum<TNamespace, TProject, TSolution, TAttributeGroup, TEnumMember> :
        IEnum,
        IHasName,
        IHasEnumBaseType,
        IHasTypeVisibilityModifier,
        IHasNamespace<TNamespace>,
        IHasProject<TProject>,
        IHasSolution<TSolution>,
        IHasAttributes<TAttributeGroup>,
        IHasEnumMembers<TEnumMember>
        where TNamespace : INamespace
        where TProject : IProject
        where TSolution : ISolution
        where TAttributeGroup : IAttributeGroup
        where TEnumMember : IEnumMember
    {
    }
}
