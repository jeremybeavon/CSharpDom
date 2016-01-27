using System.Collections.Generic;

namespace CSharpDom.Common.Statements
{
    public interface IDefaultCaseStatement<TStatement> : IDefaultCaseStatement
    {
        IReadOnlyList<TStatement> Statements { get; }
    }
}
