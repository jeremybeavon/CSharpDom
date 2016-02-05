namespace CSharpDom.Common
{
    public interface IEnum<TNamespace, TDocument, TProject, TSolution, TAttributeGroup, TEnumMember> :
        IEnum,
        IHasName,
        IHasEnumBaseType,
        IHasTypeVisibilityModifier,
        IHasNamespace<TNamespace>,
        IHasDocument<TDocument>,
        IHasProject<TProject>,
        IHasSolution<TSolution>,
        IHasAttributes<TAttributeGroup>,
        IHasEnumMembers<TEnumMember>
        where TNamespace : INamespace
        where TDocument : IDocument
        where TProject : IProject
        where TSolution : ISolution
        where TAttributeGroup : IAttributeGroup
        where TEnumMember : IEnumMember
    {
    }
}
