using CSharpDom.Common.Partial;

namespace CSharpDom.Common.Editable.Partial
{
    public interface IEditablePartialClassCollection : IVisitable<IEditableVisitor>, IPartialClassCollection
    {
        new int Count { get; set; }
    }
}