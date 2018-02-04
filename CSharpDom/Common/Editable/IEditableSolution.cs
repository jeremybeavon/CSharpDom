using System.Collections.Generic;

namespace CSharpDom.Common.Editable
{
    public interface IEditableSolution : IAsyncVisitable<IEditableVisitor>, ISolution
    {
    }
}