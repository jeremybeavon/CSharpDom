using CSharpDom.Common.Statements;
using System.Collections.Generic;

namespace CSharpDom.Common.Editable.Statements
{
    public interface IEditableBlockStatement<TStatement> : IEditableBlockStatement, IBlockStatement<TStatement>
        where TStatement : IEditableStatement
    {
        new IList<TStatement> Statements { get; set; }
    }
}