using CSharpDom.Common;

namespace CSharpDom.BaseClasses
{
    public abstract class AbstractStructConstant<TAttributeGroup, TDeclaringType, TTypeReference, TConstant> :
        AbstractConstantGroup<TAttributeGroup, TDeclaringType, TTypeReference, TConstant>,
        IStructConstant<TAttributeGroup, TDeclaringType, TTypeReference, TConstant>
        where TAttributeGroup : IAttributeGroup
        where TDeclaringType : IStructType
        where TTypeReference : ITypeReference
        where TConstant : IConstant
    {
        public abstract StructMemberVisibilityModifier Visibility { get; }

        public override void Accept(IGenericVisitor visitor)
        {
            visitor.VisitStructConstant(this);
        }

        public override void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitStructConstantChildren(this, visitor);
        }
    }
}
