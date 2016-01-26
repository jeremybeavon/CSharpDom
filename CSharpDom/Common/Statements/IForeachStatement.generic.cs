using CSharpDom.Common.Expressions;

namespace CSharpDom.Common.Statements
{
    public interface IForeachStatement<TTypeReference, TExpression, TStatement> : IForeachStatement
        where TTypeReference : ITypeReference
        where TExpression : IExpression
        where TStatement : IStatement
    {
        TTypeReference Type { get; }

        string VariableName { get; }

        TExpression Iterator { get; }

        TStatement Statement { get; }
    }
}
