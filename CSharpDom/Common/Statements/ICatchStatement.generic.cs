using System.Collections.Generic;

namespace CSharpDom.Common.Statements
{
    public interface ICatchStatement<TTypeReference, TStatement> : ICatchStatement
        where TTypeReference : ITypeReference
        where TStatement : IStatement
    {
        TTypeReference Type { get; }

        string VariableName { get; }

        IReadOnlyList<TStatement> Statements { get; }
    }
}
