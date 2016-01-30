using System.Linq.Expressions;

namespace CSharpDom.Linq.Expressions
{
    public interface ILinqStatement<TStatement> : ILinqStatement
        where TStatement : Expression
    {
        new TStatement Statement { get; }
    }
}
