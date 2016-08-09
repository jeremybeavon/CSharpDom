namespace CSharpDom.Common
{
    public interface ISealedClassEventProperty<TAttributeGroup, TDeclaringType, TDelegateReference, TMethodBody> :
        ISealedClassEventProperty,
        IEventProperty<TAttributeGroup, TDeclaringType, TDelegateReference, TMethodBody>,
        IHasSealedClassMemberInheritanceModifier
        where TAttributeGroup : IAttributeGroup
        where TDeclaringType : ISealedType
        where TDelegateReference : IDelegateReference
        where TMethodBody : IMethodBody
    {
    }
}
