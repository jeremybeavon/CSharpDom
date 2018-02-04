namespace CSharpDom.Common.Editable
{
    public interface IHasEditableProject<TProject> : IHasProject<TProject>
    {
        new TProject Project { get; set; }
    }
}