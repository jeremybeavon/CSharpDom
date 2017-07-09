using CSharpDom.Common.Expressions;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace CSharpDom.Serialization.Expressions
{
    public sealed class Expression : IExpression
    {
        [DefaultValue(null)]
        public AnonymousMethodExpression AnonymousMethodExpression { get; set; }

        [DefaultValue(null)]
        public ArrayIndexExpression ArrayIndexExpression { get; set; }

        [DefaultValue(null)]
        public AwaitExpression AwaitExpression { get; set; }

        [DefaultValue(null)]
        public BinaryOperatorExpression BinaryOperatorExpression { get; set; }

        [DefaultValue(null)]
        public CastExpression CastExpression { get; set; }

        [DefaultValue(null)]
        public DefaultExpression DefaultExpression { get; set; }

        [DefaultValue(null)]
        public DoubleConstantExpression DoubleConstantExpression { get; set; }

        [DefaultValue(null)]
        public IdentifierExpression IdentifierExpression { get; set; }

        [DefaultValue(null)]
        public IntegerConstantExpression IntegerConstantExpression { get; set; }

        [DefaultValue(null)]
        public ListInitializerExpression ListInitializerExpression { get; set; }

        [DefaultValue(null)]
        public MemberExpression MemberExpression { get; set; }

        [DefaultValue(null)]
        public MethodCallExpression MethodCallExpression { get; set; }

        [DefaultValue(null)]
        public NewAnonymousArrayExpression NewAnonymousArrayExpression { get; set; }

        [DefaultValue(null)]
        public NewAnonymousTypeExpression NewAnonymousTypeExpression { get; set; }

        [DefaultValue(null)]
        public NewArrayExpression NewArrayExpression { get; set; }

        [DefaultValue(null)]
        public NewExpression NewExpression { get; set; }

        [DefaultValue(null)]
        public NullExpression NullExpression { get; set; }

        [DefaultValue(null)]
        public ObjectInitializerExpression ObjectInitializerExpression { get; set; }

        [DefaultValue(null)]
        public OutExpression OutExpression { get; set; }

        [DefaultValue(null)]
        public ParenthesisExpression ParenthesisExpression { get; set; }

        [DefaultValue(null)]
        public QueryFromExpression QueryFromExpression { get; set; }

        [DefaultValue(null)]
        public RawExpression RawExpression { get; set; }

        [DefaultValue(null)]
        public RefExpression RefExpression { get; set; }

        [DefaultValue(null)]
        public StringConstantExpression StringConstantExpression { get; set; }

        [DefaultValue(null)]
        public TernaryOperatorExpression TernaryOperatorExpression { get; set; }

        [DefaultValue(null)]
        public TypeofExpression TypeofExpression { get; set; }

        [DefaultValue(null)]
        public UnaryOperatorExpression UnaryOperatorExpression { get; set; }

        private IEnumerable<IExpression> Expressions
        {
            get
            {
                yield return AnonymousMethodExpression;
                yield return ArrayIndexExpression;
                yield return AwaitExpression;
                yield return BinaryOperatorExpression;
                yield return CastExpression;
                yield return DefaultExpression;
                yield return DoubleConstantExpression;
                yield return IdentifierExpression;
                yield return IntegerConstantExpression;
                yield return ListInitializerExpression;
                yield return MemberExpression;
                yield return MethodCallExpression;
                yield return NewAnonymousArrayExpression;
                yield return NewAnonymousTypeExpression;
                yield return NewArrayExpression;
                yield return NewExpression;
                yield return NullExpression;
                yield return ObjectInitializerExpression;
                yield return OutExpression;
                yield return ParenthesisExpression;
                yield return RawExpression;
                yield return RefExpression;
                yield return StringConstantExpression;
                yield return TernaryOperatorExpression;
                yield return TypeofExpression;
                yield return UnaryOperatorExpression;
            }
        }

        public void Accept(IGenericExpressionVisitor visitor)
        {
            IExpression expressions = Expressions.FirstOrDefault(current => current != null);
            if (expressions != null)
            {
                expressions.Accept(visitor);
            }
        }

        public void AcceptChildren(IGenericExpressionVisitor visitor)
        {
            IExpression expressions = Expressions.FirstOrDefault(current => current != null);
            if (expressions != null)
            {
                expressions.AcceptChildren(visitor);
            }
        }
    }
}
