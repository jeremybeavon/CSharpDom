using CSharpDom.Common;

namespace CSharpDom.Editable
{
    public abstract class EditableClassConstant<TAttributeGroup, TDeclaringType, TTypeReference, TConstant> :
        EditableConstantGroup<TAttributeGroup, TDeclaringType, TTypeReference, TConstant>,
        IClassConstant<TAttributeGroup, TDeclaringType, TTypeReference, TConstant>
        where TAttributeGroup : IAttributeGroup
        where TDeclaringType : IClassType
        where TTypeReference : ITypeReference
        where TConstant : IConstant
    {
        public abstract ClassMemberVisibilityModifier Visibility { get; set; }

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
