using CSharpDom.Common;
using CSharpDom.Serialization.Factories.Expressions;

namespace CSharpDom.Serialization.Factories
{
    public sealed class FieldFactory : AbstractFactory<IField, Field>
    {
        public FieldFactory(IField field)
            : base(field)
        {
        }

        public override void VisitField<TExpression>(IField<TExpression> field)
        {
            Value = new Field()
            {
                InitialValue = new ExpressionFactory(field.InitialValue).Value,
                Name = field.Name
            };
        }
    }
}
