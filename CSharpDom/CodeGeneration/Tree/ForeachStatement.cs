using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDom.CodeGeneration.Tree
{
    public sealed class ForeachStatement : Statement
    {
        public TypeReference Type { get; set; }

        public string VariableName { get; set; }

        public IExpressionStatement Iterator { get; set; }

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
            Type.AcceptIfNotNull(visitor);
            Iterator.AcceptIfNotNull(visitor);
            Statement.AcceptIfNotNull(visitor);
        }
    }
}
