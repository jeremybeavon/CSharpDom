using CSharpDom.Common;
using CSharpDom.Wrappers.Internal.Expressions;

namespace CSharpDom.Wrappers.Internal
{
    internal sealed class ConstantWrapper : AbstractWrapper<IConstant>
    {
        public ConstantWrapper(IConstant @enum)
            : base(@enum)
        {
        }

        public override void VisitConstant<TExpression>(IConstant<TExpression> field)
        {
            Value = new Constant()
            {
                ConstantValue = new ExpressionWrapper(field.ConstantValue).Value,
                Name = field.Name
            };
        }
    }
}
