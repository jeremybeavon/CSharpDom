using System;
using CSharpDom.BaseClasses.Statements;
using CSharpDom.Common.Expressions;

namespace CSharpDom.CodeGeneration.Tree.Statements
{
    public sealed class ReadOnlyReturnStatement : AbstractReturnStatement<IExpression>
    {
        public ReadOnlyReturnStatement(ReturnStatement returnStatement)
        {

        }

        public override IExpression Expression
        {
            get
            {
                throw new NotImplementedException();
            }
        }
    }
}
