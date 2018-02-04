namespace CSharpDom.Common.Editable
{
    public interface IEditableInterfaceMember :
        IVisitable<IEditableVisitor>,
        IHasEditableInterfaceMemberInheritanceModifier,
        IInterfaceMember
    {
    }
}