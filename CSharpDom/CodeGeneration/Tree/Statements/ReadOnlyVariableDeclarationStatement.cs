using CSharpDom.BaseClasses.Statements;
using CSharpDom.CodeGeneration.Tree.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDom.CodeGeneration.Tree.Statements
{
    public sealed class ReadOnlyVariableDeclarationStatement :
        AbstractVariableDeclarationStatement<ReadOnlyTypeReference, ReadOnlyExpressionStatement>
    {
        public ReadOnlyVariableDeclarationStatement(VariableDeclarationStatement variableDeclarationStatement)
        {
        }

        public override IReadOnlyList<ReadOnlyExpressionStatement> Expressions
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public override ReadOnlyTypeReference Type
        {
            get
            {
                throw new NotImplementedException();
            }
        }
    }
}
