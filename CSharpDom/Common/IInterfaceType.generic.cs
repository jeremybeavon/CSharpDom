namespace CSharpDom.Common
{
    public interface IInterfaceType<TAttributeGroup, TGenericParameter, TInterfaceReference, TEvent, TProperty, TIndexer, TMethod> :
        IInterfaceType,
        IHasName,
        IHasAttributes<TAttributeGroup>,
        IHasGenericParameters<TGenericParameter>,
        IHasInterfaces<TInterfaceReference>,
        IHasEvents<TEvent>,
        IHasProperties<TProperty>,
        IHasIndexers<TIndexer>,
        IHasMethods<TMethod>
        where TAttributeGroup : IAttributeGroup
        where TGenericParameter : IGenericParameterDeclaration
        where TInterfaceReference : IInterfaceReference
        where TEvent : IInterfaceEvent
        where TProperty : IInterfaceProperty
        where TIndexer : IInterfaceIndexer
        where TMethod : IInterfaceMethod
    {
    }
}
