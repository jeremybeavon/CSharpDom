namespace CSharpDom.Common.Editable
{
    public interface IEditableClassMember :
        IVisitable<IEditableVisitor>,
        IHasEditableClassMemberVisibilityModifier,
        IClassMember
    {
    }
}