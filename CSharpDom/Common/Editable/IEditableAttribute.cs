using System.Collections.Generic;

namespace CSharpDom.Common.Editable
{
    public interface IEditableAttribute : IVisitable<IEditableVisitor>, IAttribute
    {
    }
}