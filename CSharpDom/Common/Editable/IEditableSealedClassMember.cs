namespace CSharpDom.Common.Editable
{
    public interface IEditableSealedClassMember :
        IVisitable<IEditableVisitor>,
        IHasEditableClassMemberVisibilityModifier,
        ISealedClassMember
    {
    }
}