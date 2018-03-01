namespace CSharpDom.Common.Editable
{
    public interface IHasEditableAbstractMemberVisibilityModifier : IHasAbstractMemberVisibilityModifier
    {
        new AbstractMemberVisibilityModifier Visibility { get; set; }
    }
}
