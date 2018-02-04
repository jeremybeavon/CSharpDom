namespace CSharpDom.Common.Editable
{
    public interface IHasEditableParameter<TParameter> : IHasParameter<TParameter>
    {
        new TParameter Parameter { get; set; }
    }
}