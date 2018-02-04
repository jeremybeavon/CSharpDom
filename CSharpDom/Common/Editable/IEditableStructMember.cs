namespace CSharpDom.Common.Editable
{
    public interface IEditableStructMember :
        IVisitable<IEditableVisitor>,
        IHasEditableStructMemberVisibilityModifier,
        IStructMember
    {
    }
}