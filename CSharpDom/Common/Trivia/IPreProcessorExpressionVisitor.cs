namespace CSharpDom.Common.Trivia
{
    public interface IPreProcessorExpressionVisitor
    {
        void Visit(IPreProcessorExpression expression);
 
        void VisitAndExpression<TPreProcessorExpression>(IPreProcessorAndExpression<TPreProcessorExpression> expression)
            where TPreProcessorExpression : IPreProcessorExpression;

        void VisitEqualExpression<TPreProcessorExpression>(IPreProcessorEqualExpression<TPreProcessorExpression> expression)
            where TPreProcessorExpression : IPreProcessorExpression;

        void VisitIdentifierExpression(IPreProcessorIdentifierExpression expression);

        void VisitNotEqualExpression<TPreProcessorExpression>(IPreProcessorNotEqualExpression<TPreProcessorExpression> expression)
            where TPreProcessorExpression : IPreProcessorExpression;

        void VisitNotExpression<TPreProcessorExpression>(IPreProcessorNotExpression<TPreProcessorExpression> expression)
            where TPreProcessorExpression : IPreProcessorExpression;

        void VisitOrExpression<TPreProcessorExpression>(IPreProcessorOrExpression<TPreProcessorExpression> expression)
            where TPreProcessorExpression : IPreProcessorExpression;

        void VisitParenthesisExpression<TPreProcessorExpression>(IPreProcessorParenthesisExpression<TPreProcessorExpression> expression)
            where TPreProcessorExpression : IPreProcessorExpression;
    }
}
