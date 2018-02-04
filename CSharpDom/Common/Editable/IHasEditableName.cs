namespace CSharpDom.Common.Editable
{
    public interface IHasEditableName : IHasName
    {
        new string Name { get; set; }
    }
}