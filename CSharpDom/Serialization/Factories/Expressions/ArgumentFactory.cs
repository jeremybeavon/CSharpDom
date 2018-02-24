using CSharpDom.Common.Expressions;
using CSharpDom.Serialization.Expressions;

namespace CSharpDom.Serialization.Factories.Expressions
{
    public sealed class ArgumentFactory : AbstractExpressionFactory<IArgument, Argument>
    {
        public ArgumentFactory(IArgument expression)
            : base(expression)
        {
        }

        public override void VisitArgument<TExpression>(IArgument<TExpression> argument)
        {
            Value = new Argument()
            {
                Expression = new ExpressionFactory(argument.Expression).Value,
                Name = argument.Name
            };
        }

        public override void VisitRefArgument<TExpression>(IRefArgument<TExpression> refArgument)
        {
            Value = new Argument()
            {
                RefArgument = new RefArgumentFactory(refArgument).Value
            };
        }

        public override void VisitOutArgument<TExpression>(IOutArgument<TExpression> outArgument)
        {
            Value = new Argument()
            {
                OutArgument = new OutArgumentFactory(outArgument).Value
            };
        }
    }
}
