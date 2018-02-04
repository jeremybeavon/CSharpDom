namespace CSharpDom.Common.Editable
{
    public interface IHasEditableClassMemberInheritanceModifier : IHasClassMemberInheritanceModifier
    {
        new ClassMemberInheritanceModifier InheritanceModifier { get; set; }
    }
}