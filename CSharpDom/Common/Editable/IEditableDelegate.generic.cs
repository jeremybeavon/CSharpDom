namespace CSharpDom.Common.Editable
{
    public interface IEditableDelegate<TNamespace, TDocument, TProject, TSolution, TAttributeGroup, TGenericParameter, TTypeReference, TParameter> :
        IEditableDelegate,
        IHasEditableTypeVisibilityModifier,
        IHasEditableNamespace<TNamespace>,
        IHasEditableDocument<TDocument>,
        IHasEditableProject<TProject>,
        IHasEditableSolution<TSolution>,
        IEditableDelegateType<TAttributeGroup, TGenericParameter, TTypeReference, TParameter>,
        IDelegate<TNamespace, TDocument, TProject, TSolution, TAttributeGroup, TGenericParameter, TTypeReference, TParameter>
        where TNamespace : IEditableNamespace
        where TDocument : IEditableDocument
        where TProject : IEditableProject
        where TSolution : IEditableSolution
        where TAttributeGroup : IEditableAttributeGroup
        where TGenericParameter : IEditableGenericParameterDeclaration
        where TTypeReference : IEditableTypeReference
        where TParameter : IEditableDelegateParameter
    {
    }
}