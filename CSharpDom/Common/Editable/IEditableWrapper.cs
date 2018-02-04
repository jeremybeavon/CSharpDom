namespace CSharpDom.Common.Editable
{
    public interface IEditableWrapper<T> : IWrapper<T>
    {
        new T WrappedObject { get; set; }
    }
}