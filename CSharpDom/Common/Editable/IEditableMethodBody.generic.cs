using System.Collections.Generic;

namespace CSharpDom.Common.Editable
{
    public interface IEditableMethodBody<TStatement> : IEditableMethodBody, IMethodBody<TStatement>
    {
        new IList<TStatement> Statements { get; set; }
    }
}