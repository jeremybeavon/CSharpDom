using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDom.CodeGeneration.Tree
{
    public sealed class IfStatement : Statement
    {
        public IExpressionStatement Condition { get; set; }

        public Statement ThenStatement { get; set; }

        public Statement ElseStatement { get; set; }

        public override void Accept(CodeGenerationVisitor visitor)
        {
            throw new NotImplementedException();
        }
    }
}
