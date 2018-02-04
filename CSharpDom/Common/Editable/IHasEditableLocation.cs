namespace CSharpDom.Common.Editable
{
    public interface IHasEditableLocation : IHasLocation
    {
        new int StartLine { get; set; }

        new int EndLine { get; set; }
    }
}