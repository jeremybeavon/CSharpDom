namespace CSharpDom.Common
{
    public interface IDelegate<
        TNamespace,
        TDocument,
        TProject,
        TSolution,
        TAttributeGroup,
        TGenericParameter,
        TTypeReference,
        TParameter> :
        IDelegate,
        IHasTypeVisibilityModifier,
        IHasNamespace<TNamespace>,
        IHasDocument<TDocument>,
        IHasProject<TProject>,
        IHasSolution<TSolution>,
        IDelegateType<TAttributeGroup, TGenericParameter, TTypeReference, TParameter>
        where TNamespace : INamespace
        where TDocument : IDocument
        where TProject : IProject
        where TSolution : ISolution
        where TAttributeGroup : IAttributeGroup
        where TGenericParameter : IGenericParameterDeclaration
        where TTypeReference : ITypeReference
        where TParameter : IDelegateParameter
    {
    }
}
