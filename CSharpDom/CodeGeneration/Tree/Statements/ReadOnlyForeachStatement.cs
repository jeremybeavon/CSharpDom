using CSharpDom.BaseClasses.Statements;
using CSharpDom.CodeGeneration.Tree.Types;
using System.Collections.Generic;
using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDom.CodeGeneration.Tree.Statements
{
    public sealed class ReadOnlyForeachStatement :
        AbstractForeachStatement<ReadOnlyTypeReference, ReadOnlyExpressionStatement, ReadOnlyStatement>
    {
        private readonly ReadOnlyTypeReference type;
        private readonly string variableName;
        private readonly ReadOnlyExpressionStatement iterator;
        private readonly ReadOnlyStatement statement;

        public ReadOnlyForeachStatement(ForeachStatement foreachStatement)
        {
            type = new ReadOnlyTypeReference(foreachStatement.Type);
            variableName = foreachStatement.VariableName;
            iterator = new ReadOnlyExpressionStatement(foreachStatement.Iterator);
            statement = new ReadOnlyStatement(foreachStatement.Statement);
        }

        public override ReadOnlyExpressionStatement Iterator
        {
            get { return iterator; }
        }

        public override ReadOnlyStatement Statement
        {
            get { return statement; }
        }

        public override ReadOnlyTypeReference Type
        {
            get { return type; }
        }

        public override string VariableName
        {
            get { return variableName; }
        }
    }
}
