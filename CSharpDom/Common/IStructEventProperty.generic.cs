namespace CSharpDom.Common
{
    public interface IStructEventProperty<TAttributeGroup, TDeclaringType, TDelegateReference, TMethodBody> :
        IStructEventProperty,
        IEventProperty<TAttributeGroup, TDeclaringType, TDelegateReference, TMethodBody>,
        IHasStructMemberInheritanceModifier
        where TAttributeGroup : IAttributeGroup
        where TDeclaringType : IStructType
        where TDelegateReference : IDelegateReference
        where TMethodBody : IMethodBody
    {
    }
}
