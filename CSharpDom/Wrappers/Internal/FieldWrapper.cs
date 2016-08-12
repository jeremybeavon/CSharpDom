using CSharpDom.Common;
using CSharpDom.Wrappers.Internal.Expressions;

namespace CSharpDom.Wrappers.Internal
{
    internal sealed class FieldWrapper : AbstractWrapper<IField>
    {
        public FieldWrapper(IField field)
            : base(field)
        {
        }

        public override void VisitField<TExpression>(IField<TExpression> field)
        {
            Value = new Field()
            {
                InitialValue = new ExpressionWrapper(field.InitialValue).Value,
                Name = field.Name
            };
        }
    }
}
