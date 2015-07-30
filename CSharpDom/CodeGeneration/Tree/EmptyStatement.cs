using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDom.CodeGeneration.Tree
{
    public sealed class EmptyStatement : CodeGenerationNode
    {
        public override void Accept(CodeGenerationVisitor visitor)
        {
            visitor.Visit(this);
        }

        public override void AcceptChildren(CodeGenerationVisitor visitor)
        {
        }
    }
}
