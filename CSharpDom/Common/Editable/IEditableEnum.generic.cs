namespace CSharpDom.Common.Editable
{
    public interface IEditableEnum<TNamespace, TDocument, TProject, TSolution, TAttributeGroup, TEnumMember> :
        IEditableEnum,
        IHasEditableName,
        IHasEditableEnumBaseType,
        IHasEditableTypeVisibilityModifier,
        IHasEditableNamespace<TNamespace>,
        IHasEditableDocument<TDocument>,
        IHasEditableProject<TProject>,
        IHasEditableSolution<TSolution>,
        IHasEditableAttributes<TAttributeGroup>,
        IHasEditableEnumMembers<TEnumMember>,
        IEnum<TNamespace, TDocument, TProject, TSolution, TAttributeGroup, TEnumMember>
        where TNamespace : IEditableNamespace
        where TDocument : IEditableDocument
        where TProject : IEditableProject
        where TSolution : IEditableSolution
        where TAttributeGroup : IEditableAttributeGroup
        where TEnumMember : IEditableEnumMember
    {
    }
}