namespace CSharpDom.Common
{
    public interface IEventProperty<TAttributeGroup, TDeclaringType, TDelegateReference, TMethodBody> :
        IEventProperty,
        IHasName,
        IHasAttributes<TAttributeGroup>,
        IHasDeclaringType<TDeclaringType>,
        IHasEventType<TDelegateReference>,
        IHasEventPropertyBody<TMethodBody>,
        IHasEventPropertyBodyAttributes<TAttributeGroup>
        where TAttributeGroup : IAttributeGroup
        where TDeclaringType : IType
        where TDelegateReference : IDelegateReference
        where TMethodBody : IMethodBody
    {
    }
}
