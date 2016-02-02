namespace CSharpDom.Common
{
    public interface IEventProperty<TAttributeGroup, TDeclaringType, TDelegateReference, TMethodBody> :
        IHasName,
        IHasAttributes<TAttributeGroup>,
        IHasDeclaringType<TDeclaringType>,
        IHasEventType<TDelegateReference>,
        IHasEventPropertyBody<TMethodBody>
        where TAttributeGroup : IAttributeGroup
        where TDeclaringType : IType
        where TDelegateReference : IDelegateReference
        where TMethodBody : IMethodBody
    {
    }
}
