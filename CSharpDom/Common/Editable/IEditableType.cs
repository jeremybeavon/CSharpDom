namespace CSharpDom.Common.Editable
{
    public interface IEditableType : IVisitable<IEditableVisitor>, IEditableBasicType, IType
    {
    }
}