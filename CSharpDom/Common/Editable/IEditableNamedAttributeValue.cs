using CSharpDom.Common.Editable.Expressions;

namespace CSharpDom.Common.Editable
{
    public interface IEditableNamedAttributeValue : IVisitable<IEditableVisitor>, INamedAttributeValue
    {
    }
}