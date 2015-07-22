using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDom.CodeGeneration.Tree
{
    public sealed class WhileStatement : Statement
    {
        public IExpressionStatement Condition { get; set; }

        public Statement Statement { get; set; }

        public override void Accept(CodeGenerationVisitor visitor)
        {
            if (visitor != null)
            {
                visitor.Visit(this);
            }
        }

        public override void AcceptChildren(CodeGenerationVisitor visitor)
        {
            Condition.AcceptIfNotNull(visitor);
            Statement.AcceptIfNotNull(visitor);
        }
    }
}
