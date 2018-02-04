namespace CSharpDom.Common.Editable
{
    public interface IHasEditableOperatorOverloadType : IHasOperatorOverloadType
    {
        new OperatorOverloadType OperatorType { get; set; }
    }
}