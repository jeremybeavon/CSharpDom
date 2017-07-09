using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDom.Common.Expressions
{
    public interface IQueryExpression<TQueryFromExpression, TQueryClauseExpression, TQueryEndExpression> :
        IQueryExpression
        where TQueryFromExpression : IQueryFromExpression
        where TQueryClauseExpression : IQueryClauseExpression
        where TQueryEndExpression : IQueryEndExpression
    {
        TQueryFromExpression StartExpression { get; }

        IReadOnlyList<TQueryClauseExpression> Expressions { get; }

        TQueryEndExpression EndExpression { get; }
    }
}
