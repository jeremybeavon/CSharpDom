namespace CSharpDom.Common.Editable
{
    public interface IHasEditableStructMemberInheritanceModifier : IHasStructMemberInheritanceModifier
    {
        new StructMemberInheritanceModifier InheritanceModifier { get; set; }
    }
}