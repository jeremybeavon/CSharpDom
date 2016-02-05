namespace CSharpDom.Common
{
    public interface IStaticClassEventProperty<TAttributeGroup, TDeclaringType, TDelegateReference, TMethodBody> :
        IStaticClassEventProperty,
        IEventProperty<TAttributeGroup, TDeclaringType, TDelegateReference, TMethodBody>
        where TAttributeGroup : IAttributeGroup
        where TDeclaringType : IStaticType
        where TDelegateReference : IDelegateReference
        where TMethodBody : IMethodBody
    {
    }
}
