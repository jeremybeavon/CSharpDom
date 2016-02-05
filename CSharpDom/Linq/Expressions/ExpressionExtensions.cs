using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace CSharpDom.Linq.Expressions
{
    public static class ExpressionExtensions
    {
        public static LoopExpression While(Expression condition, Expression body)
        {
            return While(condition, body, null);
        }

        public static LoopExpression While(Expression condition, Expression body, LabelTarget @break)
        {
            return While(condition, body, null, null);
        }

        public static LoopExpression While(Expression condition, Expression body, LabelTarget @break, LabelTarget @continue)
        {
            if (@break == null)
            {
                @break = Expression.Label();
            }

            return Expression.Loop(Expression.Block(ExitLoop(condition, @break), body), @break, @continue);
        }

        public static LoopExpression DoWhile(Expression condition, Expression body)
        {
            LabelTarget breakTarget = Expression.Label();
            return Expression.Loop(
                Expression.Block(body, ExitLoop(condition, breakTarget)),
                breakTarget,
                Expression.Label());
        }

        public static LoopExpression DoWhile(Expression condition, Expression body, LabelTarget @break)
        {
            LabelTarget breakTarget = Expression.Label();
            return Expression.Loop(
                Expression.Block(body, ExitLoop(condition, breakTarget)),
                breakTarget,
                Expression.Label());
        }

        public static LoopExpression DoWhile(Expression condition, Expression body, LabelTarget @break, LabelTarget @continue)
        {
            if (@break == null)
            {
                @break = Expression.Label();
            }

            return Expression.Loop(Expression.Block(body, ExitLoop(condition, @break)), @break, @continue);
        }

        public static BlockExpression For(ForStatement statement)
        {
            Expression body = GetForStatementBody(statement);
            IEnumerable<Expression> expressions = (statement.Initializers ?? new Expression[0]).Concat(new[] { body });
            return Expression.Block(statement.DeclaredVariables ?? new ParameterExpression[0], expressions);
        }

        private static Expression GetForStatementExitCondition(ForStatement statement)
        {
            if (statement.Condition != null)
            {
                if (statement.BreakTarget == null)
                {
                    statement.BreakTarget = Expression.Label();
                }

                return ExitLoop(statement.Condition, statement.BreakTarget);
            }

            return null;
        }

        private static Expression GetForStatementBody(ForStatement statement)
        {
            Expression exitExpression = GetForStatementExitCondition(statement);
            if (exitExpression == null && statement.Body == null)
            {
                return Expression.Empty();
            }

            if (exitExpression == null && statement.Body != null)
            {
                return statement.Body;
            }

            if (exitExpression != null && statement.Body != null)
            {
                return Expression.Block(exitExpression, statement.Body);
            }

            return exitExpression;
        }

        private static Expression ExitLoop(Expression condition, LabelTarget breakTarget)
        {
            return Expression.IfThen(Expression.Not(condition), Expression.Break(breakTarget));
        }
    }
}
