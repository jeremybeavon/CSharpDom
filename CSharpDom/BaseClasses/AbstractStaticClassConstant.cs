using CSharpDom.Common;

namespace CSharpDom.BaseClasses
{
    public abstract class AbstractStaticClassConstant<TAttributeGroup, TDeclaringType, TTypeReference, TConstant> :
        AbstractConstantGroup<TAttributeGroup, TDeclaringType, TTypeReference, TConstant>,
        IStaticClassConstant<TAttributeGroup, TDeclaringType, TTypeReference, TConstant>
        where TAttributeGroup : IAttributeGroup
        where TDeclaringType : IStaticType
        where TTypeReference : ITypeReference
        where TConstant : IConstant
    {
        public abstract StaticClassMemberVisibilityModifier Visibility { get; }

        public override void Accept(IGenericVisitor visitor)
        {
            visitor.VisitStaticClassConstant(this);
        }

        public override void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitStaticClassConstantChildren(this, visitor);
        }
    }
}
