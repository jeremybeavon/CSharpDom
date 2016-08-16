using CSharpDom.Common;

namespace CSharpDom.Editable
{
    public class EditableStaticClassConstant<TAttributeGroup, TDeclaringType, TTypeReference, TConstant> :
        EditableConstantGroup<TAttributeGroup, TDeclaringType, TTypeReference, TConstant>,
        IStaticClassConstant<TAttributeGroup, TDeclaringType, TTypeReference, TConstant>
        where TAttributeGroup : IAttributeGroup
        where TDeclaringType : IStaticType
        where TTypeReference : ITypeReference
        where TConstant : IConstant
    {
        public virtual StaticClassMemberVisibilityModifier Visibility { get; set; }

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
