namespace CSharpDom.Common.Editable
{
    public interface IHasEditableStructMemberVisibilityModifier : IHasStructMemberVisibilityModifier
    {
        new StructMemberVisibilityModifier Visibility { get; set; }
    }
}