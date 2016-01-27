using System.Collections.Generic;

namespace CSharpDom.Common.Statements
{
    public interface IBlockStatement<TStatement> : IBlockStatement
        where TStatement : IStatement
    {
        IReadOnlyList<TStatement> Statements { get; }
    }
}
