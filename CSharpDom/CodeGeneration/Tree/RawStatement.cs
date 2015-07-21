using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDom.CodeGeneration.Tree
{
    public sealed class RawStatement : Statement, IExpressionStatement
    {
        public RawStatement()
        {
        }

        public RawStatement(string statement)
        {
            Statement = statement;
        }

        public string Statement { get; set; }

        public override void Accept(CodeGenerationVisitor visitor)
        {
            throw new NotImplementedException();
        }
    }
}
