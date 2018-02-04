namespace CSharpDom.Common.Editable
{
    public interface IHasEditableConversionOperatorType : IHasConversionOperatorType
    {
        new ConversionOperatorType OperatorType { get; set; }
    }
}