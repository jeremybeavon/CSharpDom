using CSharpDom.Common.Statements;
using System.Collections.Generic;

namespace CSharpDom.Common.Editable.Statements
{
    public interface IEditableDefaultCaseStatement<TStatement> :
        IEditableDefaultCaseStatement,
        IDefaultCaseStatement<TStatement>
    {
        new IList<TStatement> Statements { get; set; }
    }
}