using CSharpDom.Common;
using CSharpDom.BaseClasses.Wrappers;

namespace CSharpDom.BaseClasses
{
    public abstract class AbstractExplicitInterfaceEvent<TAttributeGroup, TDeclaringType, TInterfaceReference, TDelegateReference, TMethodBody> :
        AbstractEventProperty<TAttributeGroup, TDeclaringType, TDelegateReference, TMethodBody>,
        IExplicitInterfaceEvent<TAttributeGroup, TDeclaringType, TInterfaceReference, TDelegateReference, TMethodBody>
        where TAttributeGroup : IAttributeGroup
        where TDeclaringType : IType
        where TInterfaceReference: IInterfaceReference
        where TDelegateReference : IDelegateReference
        where TMethodBody : IMethodBody
    {
        public abstract TInterfaceReference ExplicitInterface { get; }

        public override void Accept(IGenericVisitor visitor)
        {
            visitor.VisitExplicitInterfaceEvent(this);
        }

        public override void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitExplicitInterfaceEventChildren(this, visitor);
        }
    }
}
