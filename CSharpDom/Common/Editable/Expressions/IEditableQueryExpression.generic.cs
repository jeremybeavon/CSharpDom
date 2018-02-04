using CSharpDom.Common.Expressions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDom.Common.Editable.Expressions
{
    public interface IEditableQueryExpression<TQueryFromExpression, TQueryClauseExpression, TQueryEndExpression> :
        IEditableQueryExpression,
        IQueryExpression<TQueryFromExpression, TQueryClauseExpression, TQueryEndExpression>
        where TQueryFromExpression : IEditableQueryFromExpression
        where TQueryClauseExpression : IEditableQueryClauseExpression
        where TQueryEndExpression : IEditableQueryEndExpression
    {
        new TQueryFromExpression StartExpression { get; set; }

        new IList<TQueryClauseExpression> Expressions { get; set; }

        new TQueryEndExpression EndExpression { get; set; }
    }
}