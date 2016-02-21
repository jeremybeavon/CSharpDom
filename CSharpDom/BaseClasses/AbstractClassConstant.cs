using CSharpDom.Common;

namespace CSharpDom.BaseClasses
{
    public abstract class AbstractClassConstant<TAttributeGroup, TDeclaringType, TTypeReference, TConstant> :
        AbstractConstantGroup<TAttributeGroup, TDeclaringType, TTypeReference, TConstant>,
        IClassConstant<TAttributeGroup, TDeclaringType, TTypeReference, TConstant>
        where TAttributeGroup : IAttributeGroup
        where TDeclaringType : IClassType
        where TTypeReference : ITypeReference
        where TConstant : IConstant
    {
        public abstract ClassMemberVisibilityModifier Visibility { get; }

        public override void Accept(IGenericVisitor visitor)
        {
            visitor.VisitClassConstant(this);
        }

        public override void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitClassConstantChildren(this, visitor);
        }
    }
}
