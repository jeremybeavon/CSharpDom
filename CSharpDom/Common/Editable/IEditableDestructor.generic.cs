namespace CSharpDom.Common.Editable
{
    public interface IEditableDestructor<TAttributeGroup, TDeclaringType, TMethodBody> :
        IEditableDestructor,
        IHasEditableAttributes<TAttributeGroup>,
        IHasEditableDeclaringType<TDeclaringType>,
        IHasEditableBody<TMethodBody>,
        IDestructor<TAttributeGroup, TDeclaringType, TMethodBody>
        where TAttributeGroup : IEditableAttributeGroup
        where TDeclaringType : IEditableClassType
        where TMethodBody : IEditableMethodBody
    {
    }
}