using System.Collections.Generic;

namespace CSharpDom.Common.Editable
{
    public interface IEditableNamespace : IVisitable<IEditableVisitor>, INamespace
    {
    }
}