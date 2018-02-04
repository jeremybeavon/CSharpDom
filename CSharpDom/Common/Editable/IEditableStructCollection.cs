using System.Collections.Generic;

namespace CSharpDom.Common.Editable
{
    public interface IEditableStructCollection : IVisitable<IEditableVisitor>, IStructCollection
    {
    }
}