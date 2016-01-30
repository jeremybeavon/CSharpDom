using CSharpDom.BaseClasses.Statements;
using CSharpDom.Reflection;
using CSharpDom.Reflection.Internal;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace CSharpDom.Linq.Expressions
{
    public sealed class CatchStatementWithLinqExpressions :
        AbstractCatchStatement<ITypeReferenceWithReflection, ILinqStatement>
    {
        private readonly ITypeReferenceWithReflection type;
        private readonly IReadOnlyList<ILinqStatement> statements;

        public CatchStatementWithLinqExpressions(CatchBlock statement)
        {
            Statement = statement;
            type = TypeReferenceWithReflectionFactory.CreateReference(statement.Test);
            BlockExpression block = statement.Body as BlockExpression;
            statements = block == null ?
                new ILinqStatement[] { LinqStatementBuilder.BuildStatement(statement.Body) } :
                LinqStatementBuilder.BuildStatements(block.Expressions);
        }

        public CatchBlock Statement { get; private set; }

        public override IReadOnlyList<ILinqStatement> Statements
        {
            get { return statements; }
        }

        public override ITypeReferenceWithReflection Type
        {
            get { return type; }
        }

        public override string VariableName
        {
            get { return Statement.Variable.Name; }
        }
    }
}
