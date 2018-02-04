namespace CSharpDom.Common.Editable
{
    public interface IEditableUsingDirective : IVisitable<IEditableVisitor>, IHasEditableName, IUsingDirective
    {
    }
}