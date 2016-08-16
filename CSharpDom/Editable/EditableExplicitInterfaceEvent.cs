using CSharpDom.Common;
using CSharpDom.BaseClasses.Wrappers;

namespace CSharpDom.Editable
{
    public class EditableExplicitInterfaceEvent<TAttributeGroup, TDeclaringType, TInterfaceReference, TDelegateReference, TMethodBody> :
        EditableEventProperty<TAttributeGroup, TDeclaringType, TDelegateReference, TMethodBody>,
        IExplicitInterfaceEvent<TAttributeGroup, TDeclaringType, TInterfaceReference, TDelegateReference, TMethodBody>
        where TAttributeGroup : IAttributeGroup
        where TDeclaringType : IType
        where TInterfaceReference: IInterfaceReference
        where TDelegateReference : IDelegateReference
        where TMethodBody : IMethodBody
    {
        public virtual TInterfaceReference ExplicitInterface { get; set; }

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
